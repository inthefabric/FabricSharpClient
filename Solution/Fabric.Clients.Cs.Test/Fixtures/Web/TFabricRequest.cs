using System;
using System.IO;
using System.Net;
using System.Text;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Session;
using Fabric.Clients.Cs.Test.Common;
using Fabric.Clients.Cs.Web;
using Moq;
using NUnit.Framework;
using ServiceStack.Text;

namespace Fabric.Clients.Cs.Test.Fixtures.Web {
	
	/*================================================================================================*/
	[TestFixture]
	public class TFabricRequest {

		private Mock<IFabricAppSession> vMockAppSess;
		private Mock<IFabricPersonSession> vMockPerSess;
		private Mock<IFabricClientConfig> vMockConfig;
		private Mock<IClientContext> vMockContext;
		private IClientContext vContext;

		private Mock<FabricHttpProvider> vMoqHttpProv;
		private TestFabricHttpRequest vHttpReq;
		private Mock<IFabricHttpResponse> vMockResp;

		private string vMethod;
		private string vPath;
		private string vQuery;
		private string vPost;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public void SetUp() {
			vMethod = "GET";
			vPath = "test/path/items";
			vQuery = "test=1&other=false";
			vPost = "post=true&notes=abcdefg";

			vMockAppSess = new Mock<IFabricAppSession>(MockBehavior.Strict);
			vMockAppSess.SetupGet(x => x.BearerToken).Returns((string)null);
			vMockAppSess.Setup(x => x.RefreshTokenIfNecessary(vPath)).Returns(false);

			vMockPerSess = new Mock<IFabricPersonSession>(MockBehavior.Strict);
			vMockPerSess.SetupGet(x => x.BearerToken).Returns((string)null);
			vMockPerSess.Setup(x => x.RefreshTokenIfNecessary(vPath)).Returns(false);

			vMockConfig = new Mock<IFabricClientConfig>(MockBehavior.Strict);
			vMockConfig.SetupGet(x => x.ApiPath).Returns(vPath);

			vMockContext = new Mock<IClientContext>(MockBehavior.Strict);
			vMockContext.SetupGet(x => x.Config).Returns(vMockConfig.Object);
			vMockContext.SetupGet(x => x.ActiveSess).Returns(vMockAppSess.Object);
			vMockContext.SetupGet(x => x.AppSess).Returns(vMockAppSess.Object);
			vMockContext.SetupGet(x => x.PersonSess).Returns(vMockPerSess.Object);
			vMockContext.Setup(x => x.LogDebug(It.IsAny<string>()));
			vMockContext.Setup(x => x.LogInfo(It.IsAny<string>()));
			vMockContext.Setup(x => x.LogError(It.IsAny<string>()));
			vContext = vMockContext.Object;

			vHttpReq = new TestFabricHttpRequest();
			vMockResp = new Mock<IFabricHttpResponse>(MockBehavior.Strict);

			vMoqHttpProv = new Mock<FabricHttpProvider>(MockBehavior.Strict);

			vMoqHttpProv
				.Setup(x => x.CreateRequest(It.IsAny<string>()))
				.Returns<string>(uri => {
					vHttpReq.RequestUri = uri;
					return vHttpReq;
				});
			vMoqHttpProv
				.Setup(x => x.GetResponse(vHttpReq))
				.Returns(vMockResp.Object);
		}

		/*--------------------------------------------------------------------------------------------*/
		[TearDown]
		public void TearDown() {
			FabricClient.ResetInitialization();
		}

		/*--------------------------------------------------------------------------------------------*/
		private FabricRequest<T> NewFabricRequest<T>() {
			return new FabricRequest<T>(vMoqHttpProv.Object, vMethod, vPath, vQuery, vPost);
		}

		/*--------------------------------------------------------------------------------------------*/
		private void SetupResponseStream<T>(T pObject) {
			vMockResp
				.Setup(x => x.GetResponseStream())
				.Returns(GetStream(pObject));
		}
		
		/*--------------------------------------------------------------------------------------------*/
		private static Stream GetStream<T>(T pObject) {
			return GetStream(pObject.ToJson());
		}

		/*--------------------------------------------------------------------------------------------*/
		private static Stream GetStream(string pJson) {
			byte[] byteArray = Encoding.ASCII.GetBytes(pJson);
			return new MemoryStream(byteArray);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void NewRequest() {
			var req = NewFabricRequest<FabApp>();

			Assert.AreEqual(vMethod, req.Method, "Incorrect Method.");
			Assert.AreEqual(vPath, req.Path, "Incorrect Path.");
			Assert.AreEqual(vQuery, req.Query, "Incorrect Query.");
			Assert.AreEqual(vPost, req.Post, "Incorrect Post.");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void SendSuccess() {
			var req = NewFabricRequest<FabApp>();
			var app = new FabApp { Name = "TestApp" };
			SetupResponseStream(app);

			FabApp result = req.Send(vContext, SessionType.Default);

			Assert.NotNull(result, "Result should be filled.");
			Assert.AreEqual(app.Name, result.Name, "Incorrect result.");
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void SendNoResponse() {
			vMoqHttpProv
				.Setup(x => x.GetResponse(vHttpReq))
				.Throws(new WebException("NoResponse"));

			var req = NewFabricRequest<FabApp>();

			try {
				req.Send(vContext, SessionType.Default);
				Assert.Fail("Exception expected.");
			}
			catch {}
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void SendFabricError() {
			var fe = new FabError();
			fe.Name = "Test";
			fe.Message = "Desc";
			fe.Code = 500;

			var fr = new FabResponse();
			fr.Error = fe;

			var wr = new TestWebResponse(GetStream(fr.ToJson()));
			var we = new WebException("Error", null, WebExceptionStatus.UnknownError, wr);

			vMoqHttpProv
				.Setup(x => x.GetResponse(vHttpReq))
				.Throws(we);

			var req = NewFabricRequest<FabResponse<FabApp>>();

			try {
				req.Send(vContext, SessionType.Default);
				Assert.Fail("WebException expected, but not thrown.");
			}
			catch ( FabricErrorException errEx ) {
				Assert.NotNull(errEx.RespError, "Error should be filled.");
				Assert.Null(errEx.OauthError, "OauthError should be null.");
				Assert.AreEqual(fe.Code, errEx.RespError.Error.Code, "Incorrect Error.Code.");
				Assert.AreEqual(fe.Name, errEx.RespError.Error.Name, "Incorrect Error.Name.");
				Assert.AreEqual(fe.Message, errEx.RespError.Error.Message, "Incorrect Error.Message.");
			}
			catch ( Exception e ) {
				Assert.Fail("WebException expected: "+e);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void SendFabricOauthError() {
			FabOauthError foe = new FabOauthError();
			foe.error = "Test";
			foe.error_description = "Desc";

			var wr = new TestWebResponse(GetStream(foe));
			var we = new WebException("Error", null, WebExceptionStatus.UnknownError, wr);

			vMoqHttpProv
				.Setup(x => x.GetResponse(vHttpReq))
				.Throws(we);

			var req = NewFabricRequest<FabOauthAccess>();

			try {
				req.Send(vContext, SessionType.Default);
				Assert.Fail("WebException expected, but not thrown.");
			}
			catch ( FabricErrorException errEx ) {
				Assert.Null(errEx.RespError, "Error should be null.");
				Assert.NotNull(errEx.OauthError, "OauthError should be filled.");
				Assert.AreEqual(foe.error, errEx.OauthError.error, "Incorrect OauthError.error.");
				Assert.AreEqual(foe.error_description, errEx.OauthError.error_description,
					"Incorrect OauthError.error_description.");
			}
			catch ( Exception e ) {
				Assert.Fail("WebException expected: "+e);
			}
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[TestCase("my/path", "test=1&asdf=false")]
		[TestCase("some/other/path", "test=1")]
		[TestCase("this/path", "")]
		[TestCase("this/path/null", null)]
		public void RequestUri(string pPath, string pQuery) {
			vPath = pPath;
			vQuery = pQuery;

			const string apiPath = "this/is/a/test/";
			vMockConfig.Setup(x => x.ApiPath).Returns(apiPath);
			vMockAppSess.Setup(x => x.RefreshTokenIfNecessary(vPath)).Returns(false);

			string expect = apiPath+pPath;
			if ( pQuery != null ) { expect += "?"+pQuery; }

			var req = NewFabricRequest<FabApp>();
			SetupResponseStream(new FabApp());

			req.Send(vContext, SessionType.Default);

			Assert.AreEqual(expect, vHttpReq.RequestUri, "Incorrect RequestUri.");
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase("test=1&asdf=false")]
		[TestCase("test=1")]
		public void PostContent(string pPost) {
			vMethod = "POST";
			vPost = pPost;

			var req = NewFabricRequest<FabApp>();
			SetupResponseStream(new FabApp());
			req.Send(vContext, SessionType.Default);

			Assert.AreEqual("application/x-www-form-urlencoded", vHttpReq.ContentType,
				"Incorrect ContentType.");
			Assert.AreEqual(pPost.Length, vHttpReq.ContentLength, "Incorrect ContentLength.");

			/*Stream s = vHttpReq.GetRequestStream();
			s.Position = 0;
			var sr = new StreamReader(s);
			Assert.Fail(sr.ReadToEnd());*/
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase("GET")]
		[TestCase("POST")]
		[TestCase("PUT")]
		[TestCase("DELETE")]
		public void MethodAccept(string pMethod) {
			vMethod = pMethod;

			var req = NewFabricRequest<FabApp>();
			SetupResponseStream(new FabApp());
			req.Send(vContext, SessionType.Default);

			Assert.AreEqual(pMethod, vHttpReq.Method, "Incorrect Method.");
			Assert.AreEqual("application/json", vHttpReq.Accept, "Incorrect Accept.");
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(SessionType.Default, "BearerToken1234")]
		[TestCase(SessionType.Default, null)]
		[TestCase(SessionType.App, "BearerToken1234")]
		[TestCase(SessionType.App, null)]
		[TestCase(SessionType.Person, "BearerToken1234")]
		[TestCase(SessionType.Person, null)]
		public void HeaderAuthorization(SessionType pSessType, string pBearer) {
			switch ( pSessType ) {
				case SessionType.Default:
				case SessionType.App:
					vMockAppSess.SetupGet(x => x.BearerToken).Returns(pBearer);
					break;

				case SessionType.Person:
					vMockPerSess.SetupGet(x => x.BearerToken).Returns(pBearer);
					break;
			}

			var req = NewFabricRequest<FabApp>();
			SetupResponseStream(new FabApp());
			req.Send(vContext, pSessType);

			if ( pBearer != null ) {
				Assert.AreEqual("Bearer "+pBearer, vHttpReq.Headers["Authorization"],
					"Incorrect Authorization Header.");
			}
			else {
				Assert.Null(vHttpReq.Headers["Authorization"],
					"Authorization Header should be null.");
			}
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[TestCase("BearerToken1234")]
		[TestCase(null)]
		public void RefreshPerson(string pBearer) {
			var req = NewFabricRequest<FabApp>();
			SetupResponseStream(new FabApp());
			req.Send(vContext, SessionType.Person);

			vMockPerSess.Verify(x => x.RefreshTokenIfNecessary(vPath), Times.Once);
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase("BearerToken1234")]
		[TestCase(null)]
		public void RefreshApp(string pBearer) {
			vMockPerSess.SetupGet(x => x.BearerToken).Returns(pBearer);

			var req = NewFabricRequest<FabApp>();
			SetupResponseStream(new FabApp());
			req.Send(vContext, SessionType.App);

			vMockAppSess.Verify(x => x.RefreshTokenIfNecessary(vPath), Times.Once);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------* /
		[Test]
		[Category("Integration")]
		public void RefreshPersonLoop() {
			var sessContain = new FabricSessionContainer { Person = vMockPerSess.Object };
			var config = new FabricClientConfig("Test", "http://localhost/fakeApi", 1,
				"MySecretCode", (k => "http://testdomain.com/oauth"), (k => sessContain));
			var context = new ClientContext(config, vMockAppSess.Object);
			FabricClient.InitOnce(config);

			var req = NewFabricRequest<FabApp>();
			SetupResponseStream(new FabApp());

			var fc = new FabricClient();
			var ps = new PersonSession(fc.Config, fc.Services.Oauth);
			ps.RefreshToken = "test";
			ps.Expiration = DateTime.UtcNow.AddSeconds(-1);
			sessContain.Person = ps;

			try {
				//caused infinite loop prior to fix, see GitHub issue #3
				req.Send(context, SessionType.Default);
			}
			catch ( WebException ) {
				return;
			}

			Assert.Fail("This should throw a WebException.");
		}*/

	}

}