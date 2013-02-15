using System;
using System.Collections.Specialized;
using System.Web;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Web;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	internal class PersonSession : OauthSession, IFabricPersonSession {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public PersonSession(IFabricClientConfig pConfig, IOauthService pClientOauth) :
																		base(pConfig, pClientOauth) {}

		/*--------------------------------------------------------------------------------------------*/
		public override string SessionDebugName { get { return "Person"; } }
		
		/*--------------------------------------------------------------------------------------------*/
		public override bool RefreshTokenIfNecessary() {
			if ( RefreshToken == null ) {
				return false;
			}

			if ( !IsRefreshNecessary() ) {
				return false;
			}

			Config.LogInfo("Refreshing Person token...");

			GetAccessToken(() => ClientOauth.AccessTokenRefresh
				.Get(Config.AppSecret, Config.AppOAuthRedirectUri, RefreshToken));
			return true;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public virtual string GetGrantCodeUrl(bool pSwitchUser=false) {
			LoginOperation op = (LoginOperation)ClientOauth.Login;
			FabricRequest<IFabOauthLogin> req = op.Request(Config.AppId+"",
				Config.AppOAuthRedirectUri, "code", null, SessionId, (pSwitchUser ? "1" : "0"));
			return Config.ApiPath+req.Path+"?"+req.Query;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public virtual string GetGrantWindowOpenScript(string pGrantCodeUrl=null) {
			return String.Format("window.open('{0}', 'fabOauth', 'status=0,toolbar=0,menubar=0,"+
				"directories=0,width=500,height=400,resizable=1,scrollbars=1');",
				(pGrantCodeUrl ?? GetGrantCodeUrl()));
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public virtual IFabOauthAccess HandleGrantCodeRedirect(HttpRequestBase pRedirectRequest) {
			NameValueCollection q = pRedirectRequest.QueryString;
			string err;

			if ( q["error"] != null ) {
				err = "GRANT ERROR: "+q;
				Config.LogError(err);
				throw new Exception(err);
			}

			if ( q["state"] != SessionId ) {
				err = "GRANT ERROR: incorrect 'state' value for this OAuth session ("+
					SessionId+" != "+q["state"]+")";
				Config.LogError(err);
				throw new Exception(err);
			}
			
			GrantCode = pRedirectRequest.QueryString["code"];

			return GetAccessToken(() => ClientOauth.AccessTokenAuthCode
				.Get(Config.AppSecret, GrantCode, Config.AppOAuthRedirectUri));
		}

	}

}