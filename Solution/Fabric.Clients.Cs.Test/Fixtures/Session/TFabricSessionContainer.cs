using System;
using System.Web;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Logging;
using Fabric.Clients.Cs.Session;
using Moq;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test.Fixtures.Session {
	
	/*================================================================================================*/
	[TestFixture]
	public class TFabricSessionContainer {

		private Mock<IFabricClientConfig> vMockConfig;
		private Mock<IOauthService> vMockOauthService;
		private Mock<IFabricServices> vMockServices;
		private Mock<IFabricClient> vMockClient;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public virtual void SetUp() {
			vMockConfig = new Mock<IFabricClientConfig>(MockBehavior.Strict);
			vMockConfig.Setup(x => x.GetOauthRedirectUri()).Returns("testRedirUri");

			vMockOauthService = new Mock<IOauthService>(MockBehavior.Strict);

			vMockServices = new Mock<IFabricServices>(MockBehavior.Strict);
			vMockServices.SetupGet(x => x.Oauth).Returns(vMockOauthService.Object);

			vMockClient = new Mock<IFabricClient>(MockBehavior.Strict);
			vMockClient.SetupGet(x => x.Config).Returns(vMockConfig.Object);
			vMockClient.SetupGet(x => x.Services).Returns(vMockServices.Object);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public virtual void FromValues() {
			const string sessId = "sessId";
			const string grant = "grant";
			const string bearer = "bearer";
			const string refresh = "refresh";
			DateTime exp = DateTime.UtcNow.AddMinutes(30);

			IFabricSessionContainer sc = FabricSessionContainer.FromValues(vMockClient.Object,
				sessId, grant, bearer, refresh, exp);

			Assert.NotNull(sc, "Container should be filled.");
			Assert.NotNull(sc.Person, "Container.Person should be filled.");
			Assert.AreEqual(sessId, sc.Person.SessionId, "Incorrect Person.SessionId.");
			Assert.AreEqual(grant, sc.Person.GrantCode, "Incorrect Person.GrantCode.");
			Assert.AreEqual(bearer, sc.Person.BearerToken, "Incorrect Person.BearerToken.");
			Assert.AreEqual(refresh, sc.Person.RefreshToken, "Incorrect Person.RefreshToken.");
			Assert.AreEqual(exp, sc.Person.Expiration, "Incorrect Person.Expiration.");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		[TestCase(false)]
		[TestCase(true)]
		public virtual void FromCookies(bool pHasCookie) {
			var cookies = (pHasCookie ? 
				TOauthSession.CreateWorkingCookie() : new HttpCookieCollection());

			var mockLogger = new Mock<IFabricLog>(MockBehavior.Strict);
			mockLogger.Setup(x => x.Info(It.IsAny<string>(), It.IsAny<string>()));

			vMockConfig.SetupGet(x => x.Logger).Returns(mockLogger.Object);

			IFabricSessionContainer sc = 
				FabricSessionContainer.FromCookies(vMockClient.Object, cookies);

			if ( pHasCookie ) {
				Assert.NotNull(sc, "Container should be filled.");
				Assert.NotNull(sc.Person, "Container.Person should be filled.");
				Assert.AreEqual("sessId", sc.Person.SessionId, "Incorrect Person.SessionId.");
			}
			else {
				Assert.Null(sc, "Container should be null.");
			}
		}

		/*--------------------------------------------------------------------------------------------* /
		[TestCase(false)]
		[TestCase(true)]
		public virtual void FromHttpContext(bool pHasCookie) {
			var req = new HttpRequest("file", "http://test.com", null);
			var resp = new HttpResponse(new StringWriter());
			var hc = new HttpContext(req, resp);
			Assert.NotNull(hc.Session);
			//Can't mock/fake this easily. Ignoring for now.
		}*/

	}

}