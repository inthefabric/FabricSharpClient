﻿using System;
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
		internal override OauthSession NewOauthSess(IFabricClientConfig pConfig, 
																		IOauthService pClientOauth) {
			return new PersonSession(pConfig, pClientOauth);
		}

		/*--------------------------------------------------------------------------------------------*/
		private string BuildGrantCodeUrl(PersonSession pPerSess, bool pSwitchUser=false) {
			return MockConfig.Object.ApiPath+"/Oauth/Login?"+
				"response_type=code"+
				"&client_id="+MockConfig.Object.AppId+
				"&redirect_uri="+MockConfig.Object.GetOauthRedirectUri()+
				"&scope="+
				"&state="+pPerSess.SessionId+
				"&switchMode="+(pSwitchUser ? "1" : "0");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[TestCase(true, 1, null, false)]
		[TestCase(true, -1, null, true)]
		[TestCase(false, 1, null, false)]
		[TestCase(false, -1, null, false)]
		[TestCase(true, 1, OauthAccessTokenGetOperation.Uri, false)]
		[TestCase(true, -1, OauthAccessTokenGetOperation.Uri, false)]
		[TestCase(false, 1, OauthAccessTokenGetOperation.Uri, false)]
		[TestCase(false, -1, OauthAccessTokenGetOperation.Uri, false)]
		public virtual void RefreshTokenIfNecessary(bool pHasRefresh, int pAddSeconds, 
																string pApiPath, bool pExpectRefresh) {
			string refresh = (pHasRefresh ? "OldRefreshToken" : null);
			DateTime expiry = DateTime.UtcNow.AddSeconds(pAddSeconds);
			PersonSess.RefreshToken = refresh;
			PersonSess.Expiration = expiry;

			FabOauthAccess expectResult = NewFabOauthAccess();

			MockOauth
				.Setup(x => x.AccessTokenRefresh.Get(
					refresh,
					MockConfig.Object.AppSecret,
					MockConfig.Object.GetOauthRedirectUri(),
					SessionType.Person
				))
				.Returns(expectResult);

			bool result = PersonSess.RefreshTokenIfNecessary(pApiPath);

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
			var perSess = new PersonSession(MockConfig.Object, new OauthService(null));
			string expectUrl = BuildGrantCodeUrl(perSess, pSwitchUser);

			string url = perSess.GetGrantCodeUrl(pSwitchUser);

			Assert.AreEqual(expectUrl, url, "Incorrect URL.");
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(null)]
		[TestCase("http://testurl.com/whatever/dude")]
		public virtual void GetGrantWindowOpenScript(string pGrantCodeUrl) {
			var perSess = new PersonSession(MockConfig.Object, new OauthService(null));
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

			var mockReq = new Mock<HttpRequestBase>(MockBehavior.Strict);
			mockReq.SetupGet(x => x.QueryString).Returns(q);

			var expectResult = NewFabOauthAccess();

			MockOauth
				.Setup(x => x.AccessTokenAuthCode.Get(
					grantCode,
					MockConfig.Object.AppSecret,
					MockConfig.Object.GetOauthRedirectUri(),
					SessionType.Person
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

			var mockReq = new Mock<HttpRequestBase>(MockBehavior.Strict);
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