using System;
using System.Web;
using Fabric.Clients.Cs.Session;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test.Fixtures.Session {
	
	/*================================================================================================*/
	[TestFixture]
	public class TFabricSessionContainer {

		private FabricClientConfig vConfig;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public virtual void SetUp() {
			vConfig = new FabricClientConfig("Test", "http://testFabric.com/api", 1,
				"MySecretCode", (k => "http://testdomain.com/oauth"), 
				(k => new FabricSessionContainer()));

			FabricClient.InitOnce(vConfig);
		}

		/*--------------------------------------------------------------------------------------------*/
		[TearDown]
		public void TearDown() {
			FabricClient.ResetInitialization();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		[Category("Integration")]
		public virtual void FromValues() {
			const string sessId = "sessId";
			const string grant = "grant";
			const string bearer = "bearer";
			const string refresh = "refresh";
			DateTime exp = DateTime.UtcNow.AddMinutes(30);

			IFabricSessionContainer sc = FabricSessionContainer.FromValues(new FabricClient(),
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
		[Category("Integration")]
		public virtual void FromCookies(bool pHasCookie) {
			var cookies = (pHasCookie ? 
				TOauthSession.CreateWorkingCookie() : new HttpCookieCollection());

			IFabricSessionContainer sc = 
				FabricSessionContainer.FromCookies(new FabricClient(), cookies);

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
		[Category("Integration")]
		public virtual void FromHttpContext(bool pHasCookie) {
			var req = new HttpRequest("file", "http://test.com", null);
			var resp = new HttpResponse(new StringWriter());
			var hc = new HttpContext(req, resp);
			Assert.NotNull(hc.Session);
			//Can't mock/fake this easily. Ignoring for now.
		}*/

	}

}