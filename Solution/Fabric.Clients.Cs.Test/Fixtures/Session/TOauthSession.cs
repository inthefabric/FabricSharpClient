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
	public abstract class TOauthSession {

		protected Mock<IFabricClientConfig> MockConfig { get; private set; }
		internal Mock<IOauthService> MockOauth { get; private set; }
		internal OauthSession OauthSess { get; private set; }

		private FabricSessionContainer vSessContain;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public virtual void SetUp() {
			vSessContain = new FabricSessionContainer();

			MockConfig = new Mock<IFabricClientConfig>();
			MockConfig.SetupGet(x => x.Logger).Returns(new FabricLog());

			MockOauth = new Mock<IOauthService>();
			OauthSess = NewOauthSess(MockConfig.Object, MockOauth.Object);
		}

		/*--------------------------------------------------------------------------------------------*/
		[TearDown]
		public virtual void TearDown() {}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected virtual IFabricSessionContainer SessionContainerProvider(string pConfigKey) {
			return vSessContain;
		}

		/*--------------------------------------------------------------------------------------------*/
		internal abstract OauthSession NewOauthSess(IFabricClientConfig pConfig,
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
			CheckExpiration(DateTime.UtcNow.AddSeconds(3600-60));
		}

		/*--------------------------------------------------------------------------------------------*/
		protected void CheckExpiration(DateTime pExpect) {
			Assert.LessOrEqual(OauthSess.Expiration, new DateTime(pExpect.Ticks).AddSeconds(1),
				"Expiration should be reset to DateTime.UtcNow.");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void NewSession() {
			Assert.NotNull(OauthSess, "Session should be filled.");
			
			Assert.Null(OauthSess.GrantCode, "GrantCode should be null.");
			Assert.Null(OauthSess.BearerToken, "BearerToken should be null.");
			Assert.Null(OauthSess.RefreshToken, "RefreshToken should be null.");
			CheckExpiration(DateTime.UtcNow);

			Assert.False(OauthSess.IsAuthenticated, "Incorrect IsAuthenticated.");

			Assert.NotNull(OauthSess.SessionId, "SessionId should be filled.");
			Assert.AreEqual(32, OauthSess.SessionId.Length, "Incorrect SessionId length.");
			Assert.AreEqual(MockConfig.Object.GetOauthRedirectUri(), OauthSess.OAuthRedirectUri,
				"Incorrect OAuthRedirectUri.");
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
			OauthSess.Expiration = DateTime.UtcNow.AddDays(2);

			var expectResult = new FabOauthLogout();
			var expectSess = ((this as TAppSession) == null ? SessionType.Person : SessionType.App);

			MockOauth
				.Setup(x => x.Logout.Get(It.IsAny<string>(), expectSess))
				.Returns(expectResult);

			FabOauthLogout result = OauthSess.Logout();

			Assert.AreEqual(expectResult, result, "Incorrect result.");

			Assert.Null(OauthSess.GrantCode, "GrantCode should be null.");
			Assert.Null(OauthSess.BearerToken, "BearerToken should be null.");
			Assert.Null(OauthSess.RefreshToken, "RefreshToken should be null.");
			CheckExpiration(DateTime.UtcNow);

			Assert.False(OauthSess.IsAuthenticated, "Incorrect IsAuthenticated.");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void SaveToCookies() {
			var cookies = new HttpCookieCollection();
			OauthSess.SaveToCookies(cookies);

			HttpCookie c = cookies[OauthSession.CookieKey];
			Assert.NotNull(c, "Cookie should be filled.");
			Assert.NotNull(c.Value, "Cookie.Value should be filled.");
			Assert.Greater(c.Value.Length, 1, "Cookie.Value should not be empty.");
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void LoadFromCookies() {
			bool success = OauthSess.LoadFromCookies(CreateWorkingCookie());

			Assert.True(success, "Expected successful result.");
			Assert.AreEqual("sessId", OauthSess.SessionId, "Incorrect SessionId.");
			Assert.AreEqual("grant", OauthSess.GrantCode, "Incorrect GrantCode.");
			Assert.AreEqual("bearer", OauthSess.BearerToken, "Incorrect BearerToken.");
			Assert.AreEqual("refresh", OauthSess.RefreshToken, "Incorrect RefreshToken.");
			Assert.AreEqual(123456, OauthSess.Expiration.Ticks, "Incorrect Expiration.");
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(false, null)]
		[TestCase(true, null)]
		[TestCase(true, "")]
		[TestCase(true, "|||")]
		[TestCase(true, "|||||")]
		public void LoadFromCookiesFail(bool pHasCookie, string pValue) {
			var cookies = new HttpCookieCollection();
			HttpCookie c;

			if ( pHasCookie ) {
				c = new HttpCookie(OauthSession.CookieKey);
				c.Value = pValue;
				cookies.Add(c);
			}

			bool success = OauthSess.LoadFromCookies(cookies);
			Assert.False(success, "Expected failed result.");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static HttpCookieCollection CreateWorkingCookie() {
			var c = new HttpCookie(OauthSession.CookieKey);
			c.Value = "sessId|grant|bearer|refresh|123456";

			var cookies = new HttpCookieCollection();
			cookies.Add(c);
			return cookies;
		}

	}

}