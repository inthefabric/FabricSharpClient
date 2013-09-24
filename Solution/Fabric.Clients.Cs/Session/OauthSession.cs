using System;
using System.Web;
using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	internal abstract class OauthSession : IFabricOauthSession {
		
		public string GrantCode { get; internal set; }
		public string BearerToken { get; internal set; }
		public string RefreshToken { get; internal set; }
		public bool IsAuthenticated { get { return (BearerToken != null); } }
		public DateTime Expiration { get; internal set; }
		public string SessionId { get; internal set; }

		internal IFabricClientConfig Config { get; private set; }
		internal IOauthService ClientOauth { get; private set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected OauthSession(IFabricClientConfig pConfig, IOauthService pClientOauth) {
			Config = pConfig;
			ClientOauth = pClientOauth;
			SessionId = Guid.NewGuid().ToString("N");
			ClearToken();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthLogout Logout() {
			FabOauthLogout logout = ClientOauth.Logout.Get(BearerToken);
			ClearToken();
			Config.Logger.Info(SessionId,
				"Logout: success="+logout.success+", access_token="+logout.access_token);
			return logout;
		}

		/*--------------------------------------------------------------------------------------------*/
		public abstract bool RefreshTokenIfNecessary();

		/*--------------------------------------------------------------------------------------------*/
		public abstract string SessionDebugName { get; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		//TEST: OauthSession.SaveToCookies()
		public void SaveToCookies(HttpCookieCollection pCookies) {
			var c = new HttpCookie("FabOauthSess");
			c.Value = SessionId+"|"+GrantCode+"|"+BearerToken+"|"+RefreshToken+"|"+Expiration.Ticks;
			pCookies.Add(c);
			Config.Logger.Info(SessionId, "SaveToCookies: "+c.Value);
		}

		/*--------------------------------------------------------------------------------------------*/
		//TEST: OauthSession.LoadFromCookies()
		public bool LoadFromCookies(HttpCookieCollection pCookies) {
			HttpCookie c = pCookies["FabOauthSess"];
			Config.Logger.Info(SessionId, "LoadFromCookies: "+(c == null ? null : c.Value));

			if ( c == null || c.Value == null ) {
				return false;
			}

			string[] vals = c.Value.Split('|');

			if ( vals.Length != 5 ) {
				return false;
			}

			SessionId = vals[0];
			GrantCode = vals[1];
			BearerToken = vals[2];
			RefreshToken = vals[3];
			Expiration = new DateTime(long.Parse(vals[4]));

			return true;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected FabOauthAccess GetAccessToken(Func<FabOauthAccess> pAccessFunc) {
			FabOauthAccess oa;

			try {
				oa = pAccessFunc();

				BearerToken = oa.access_token;
				RefreshToken = oa.refresh_token;
				Expiration = DateTime.Now.AddSeconds(oa.expires_in-60);
				Config.Logger.Info(SessionId, SessionDebugName+" "+
					"GetAccessToken: BearerToken="+BearerToken+
					", RefreshToken="+RefreshToken+", Expiration="+Expiration+
					", Now="+DateTime.Now);
			}
			catch ( FabricErrorException fe ) {
				Config.Logger.Error(SessionId, "FabricErrorException: "+fe);
				ClearToken();
				return null;
			}

			return oa;
		}

		/*--------------------------------------------------------------------------------------------*/
		protected virtual bool IsRefreshNecessary() {
			Config.Logger.Info(SessionId, "IsRefreshNecessary: "+SessionDebugName+" expires in "+
				new TimeSpan(Expiration.Ticks-DateTime.Now.Ticks).TotalSeconds+" sec");
			return (DateTime.Now >= Expiration);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private void ClearToken() {
			GrantCode = null;
			BearerToken = null;
			RefreshToken = null;
			Expiration = DateTime.Now;
		}

	}

}