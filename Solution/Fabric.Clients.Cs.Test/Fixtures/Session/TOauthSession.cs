using System;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Session;
using Moq;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test.Fixtures.Session {
	
	/*================================================================================================*/
	[TestFixture]
	public abstract class TOauthSession {

		protected FabricClientConfig Config { get; private set; }
		internal Mock<IOauthService> MockOauth { get; private set; }
		internal OauthSession OauthSess { get; private set; }

		private FabricSessionContainer vSessContain;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public virtual void SetUp() {
			vSessContain = new FabricSessionContainer();

			Config = new FabricClientConfig("Test", "http://testFabric.com/api", 1,
				"MySecretCode", 1, "http://testdomain.com/oauth", FabricSessionContainerProvider);
			MockOauth = new Mock<IOauthService>();
			OauthSess = NewOauthSess(Config, MockOauth.Object);
		}

		/*--------------------------------------------------------------------------------------------*/
		[TearDown]
		public virtual void TearDown() {}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected virtual IFabricSessionContainer FabricSessionContainerProvider(string pConfigKey) {
			return vSessContain;
		}

		/*--------------------------------------------------------------------------------------------*/
		internal abstract OauthSession NewOauthSess(FabricClientConfig pConfig,
																			IOauthService pClientOauth);

		/*--------------------------------------------------------------------------------------------*/
		protected FabOauthAccess NewFabOauthAccess() {
			var oa = new FabOauthAccess();
			oa.token_type = "Bearer";
			oa.access_token = "AccessToken1234";
			oa.refresh_token = "RefreshToken1234";
			oa.expires_in = 3600;
			return oa;
		}

		/*--------------------------------------------------------------------------------------------*/
		protected void CheckSessionProperties(FabOauthAccess pAccess) {
			Assert.AreEqual(pAccess.access_token, OauthSess.BearerToken, "Incorrect BearerToken.");
			Assert.AreEqual(pAccess.refresh_token, OauthSess.RefreshToken, "Incorrect RefreshToken.");
			CheckExpiration(DateTime.Now.AddSeconds(3600-60));
		}

		/*--------------------------------------------------------------------------------------------*/
		protected void CheckExpiration(DateTime pExpect) {
			Assert.LessOrEqual(OauthSess.Expiration, new DateTime(pExpect.Ticks).AddSeconds(1),
				"Expiration should be reset to DateTime.Now.");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void NewSession() {
			Assert.NotNull(OauthSess, "Session should be filled.");
			
			Assert.Null(OauthSess.GrantCode, "GrantCode should be null.");
			Assert.Null(OauthSess.BearerToken, "BearerToken should be null.");
			Assert.Null(OauthSess.RefreshToken, "RefreshToken should be null.");
			CheckExpiration(DateTime.Now);

			Assert.False(OauthSess.IsAuthenticated, "Incorrect IsAuthenticated.");

			Assert.NotNull(OauthSess.SessionId, "SessionId should be filled.");
			Assert.AreEqual(32, OauthSess.SessionId.Length, "Incorrect SessionId length.");
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase("BearerToken1234", true)]
		[TestCase(null, false)]
		public void IsAuthenticated(string pBearerToken, bool pExpectAuth) {
			OauthSess.BearerToken = pBearerToken;
			Assert.AreEqual(pExpectAuth, OauthSess.IsAuthenticated, "Incorrect IsAuthenticated.");
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void Logout() {
			OauthSess.GrantCode = "GrantCode1234";
			OauthSess.BearerToken = "BearerToken1234";
			OauthSess.RefreshToken = "RefreshToken1234";
			OauthSess.Expiration = DateTime.Now.AddDays(2);

			var expectResult = new FabOauthLogout();

			MockOauth
				.Setup(x => x.Logout.Get(It.IsAny<string>()))
				.Returns(expectResult);

			FabOauthLogout result = OauthSess.Logout();

			Assert.AreEqual(expectResult, result, "Incorrect result.");

			Assert.Null(OauthSess.GrantCode, "GrantCode should be null.");
			Assert.Null(OauthSess.BearerToken, "BearerToken should be null.");
			Assert.Null(OauthSess.RefreshToken, "RefreshToken should be null.");
			CheckExpiration(DateTime.Now);

			Assert.False(OauthSess.IsAuthenticated, "Incorrect IsAuthenticated.");
		}

	}

}