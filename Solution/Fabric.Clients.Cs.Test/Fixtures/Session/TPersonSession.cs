using System;
using System.Collections.Specialized;
using System.Web;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Session;
using Moq;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test.Fixtures.Session {
	
	/*================================================================================================*/
	[TestFixture]
	public class TPersonSession : TOauthSession {

		private PersonSession PersonSess { get { return (PersonSession)OauthSess; } }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		internal override OauthSession NewOauthSess(FabricClientConfig pConfig, 
																		IOauthService pClientOauth) {
			return new PersonSession(pConfig, pClientOauth);
		}

		/*--------------------------------------------------------------------------------------------*/
		private string BuildGrantCodeUrl(PersonSession pPerSess, bool pSwitchUser=false) {
			return Config.ApiPath+"/Oauth/Login?"+
				"client_id="+Config.AppId+
				"&redirect_uri="+Config.AppOAuthRedirectUri+
				"&response_type=code"+
				"&scope="+
				"&state="+pPerSess.SessionId+
				"&switchMode="+(pSwitchUser ? "1" : "0");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[TestCase(true, 1, false)]
		[TestCase(true, -1, true)]
		[TestCase(false, 1, false)]
		[TestCase(false, -1, false)]
		public virtual void RefreshTokenIfNecessary(
											bool pHasRefresh, int pAddSeconds, bool pExpectRefresh) {
			string refresh = (pHasRefresh ? "OldRefreshToken" : null);
			DateTime expiry = DateTime.Now.AddSeconds(pAddSeconds);
			PersonSess.RefreshToken = refresh;
			PersonSess.Expiration = expiry;

			FabOauthAccess expectResult = NewFabOauthAccess();

			MockOauth
				.Setup(x => x.AccessTokenRefresh.Get(
					Config.AppOAuthRedirectUri,
					Config.AppSecret,
					refresh
				))
				.Returns(expectResult);

			bool result = PersonSess.RefreshTokenIfNecessary();

			Assert.AreEqual(pExpectRefresh, result, "Incorrect result.");

			if ( pExpectRefresh ) {
				CheckSessionProperties(expectResult);
			}
			else {
				Assert.AreEqual(refresh, PersonSess.RefreshToken, "Incorrect RefreshToken.");
				CheckExpiration(expiry);
			}
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[TestCase(false)]
		[TestCase(true)]
		public virtual void GetGrantCodeUrl(bool pSwitchUser) {
			var perSess = new PersonSession(Config, new OauthService(null));
			string expectUrl = BuildGrantCodeUrl(perSess, pSwitchUser);

			string url = perSess.GetGrantCodeUrl(pSwitchUser);

			Assert.AreEqual(expectUrl, url, "Incorrect URL.");
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(null)]
		[TestCase("http://testurl.com/whatever/dude")]
		public virtual void GetGrantWindowOpenScript(string pGrantCodeUrl) {
			var perSess = new PersonSession(Config, new OauthService(null));
			string url = (pGrantCodeUrl ?? BuildGrantCodeUrl(perSess));
			string expectScript = "window.open('"+url+"', 'fabOauth', 'status=0,toolbar=0,menubar=0,"+
				"directories=0,width=500,height=400,resizable=1,scrollbars=1');";

			string script = perSess.GetGrantWindowOpenScript(pGrantCodeUrl);

			Assert.AreEqual(expectScript, script, "Incorrect script.");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public virtual void HandleGrantCodeRedirect() {
			const string grantCode = "GrantCode1234";

			var q = new NameValueCollection();
			q.Add("code", grantCode);
			q.Add("state", PersonSess.SessionId);

			var mockReq = new Mock<HttpRequestBase>();
			mockReq.SetupGet(x => x.QueryString).Returns(q);

			var expectResult = NewFabOauthAccess();

			MockOauth
				.Setup(x => x.AccessTokenAuthCode.Get(
					Config.AppOAuthRedirectUri,
					Config.AppSecret,
					grantCode
				))
				.Returns(expectResult);

			FabOauthAccess result = PersonSess.HandleGrantCodeRedirect(mockReq.Object);

			Assert.AreEqual(expectResult, result, "Incorrect result.");
			Assert.AreEqual(grantCode, PersonSess.GrantCode, "Incorrect GrantCode.");
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase("EpicFail", null)]
		[TestCase(null, "BadState")]
		public virtual void HandleGrantCodeRedirectFailure(string pError, string pState) {
			const string grantCode = "GrantCode1234";
			PersonSess.GrantCode = grantCode;

			var q = new NameValueCollection();
			q.Add("error", pError);
			q.Add("state", (pState ?? PersonSess.SessionId));

			var mockReq = new Mock<HttpRequestBase>();
			mockReq.SetupGet(x => x.QueryString).Returns(q);

			try {
				PersonSess.HandleGrantCodeRedirect(mockReq.Object);
				Assert.Fail("Exception expected.");
			}
			catch {}

			Assert.AreEqual(grantCode, PersonSess.GrantCode, "GrantCode should not change.");
		}

	}

}