using System;
using System.Web;
using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	internal abstract class OauthSession : IFabricOauthSession {

		public const string CookieKey = "FabOauthSess";

		public string OAuthRedirectUri { get; private set; }
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
			OAuthRedirectUri = pConfig.GetOauthRedirectUri();
			ClearToken();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthLogout Logout() {
			SessionType type = (this as AppSession == null ? SessionType.Person : SessionType.App);
			FabOauthLogout logout = ClientOauth.Logout.Get(BearerToken, type);
			ClearToken();
			Config.Logger.Info(SessionId,
				"Logout: success="+logout.success+", access_token="+logout.access_token);
			return logout;
		}

		/*--------------------------------------------------------------------------------------------*/
		public abstract bool RefreshTokenIfNecessary(string pApiPath);

		/*--------------------------------------------------------------------------------------------*/
		private string GetDebugName() {
			return GetType().Name;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public void SaveToCookies(HttpCookieCollection pCookies) {
			var c = new HttpCookie(CookieKey);
			c.Value = SessionId+"|"+GrantCode+"|"+BearerToken+"|"+RefreshToken+"|"+Expiration.Ticks;
			pCookies.Add(c);
			Config.Logger.Info(SessionId, "SaveToCookies: "+c.Value);
		}

		/*--------------------------------------------------------------------------------------------*/
		public bool LoadFromCookies(HttpCookieCollection pCookies) {
			HttpCookie c = pCookies[CookieKey];
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
				Expiration = DateTime.UtcNow.AddSeconds(oa.expires_in-60);
				Config.Logger.Info(SessionId, GetDebugName()+" "+
					"GetAccessToken: BearerToken="+BearerToken+
					", RefreshToken="+RefreshToken+", Expiration="+Expiration+
					", Now="+DateTime.UtcNow);
			}
			catch ( FabricErrorException fe ) {
				Config.Logger.Error(SessionId, "FabricErrorException: "+fe);
				ClearToken();
				return null;
			}

			return oa;
		}

		/*--------------------------------------------------------------------------------------------*/
		protected virtual bool IsExpired() {
			Config.Logger.Info(SessionId, "IsRefreshNecessary: "+GetDebugName()+" expires in "+
				new TimeSpan(Expiration.Ticks-DateTime.UtcNow.Ticks).TotalSeconds+" sec");
			return (DateTime.UtcNow >= Expiration);
		}

		/*--------------------------------------------------------------------------------------------*/
		protected bool IsOauthOperation(string pApiPath) {
			Config.Logger.Info(SessionId, "OAUTH? "+pApiPath+" / "+OauthAccessTokenClientCredentialsGetOperation.Uri);

			switch ( pApiPath ) {
				case OauthAccessTokenGetOperation.Uri:
				case OauthAccessTokenAuthCodeGetOperation.Uri:
				case OauthAccessTokenRefreshGetOperation.Uri:
				case OauthAccessTokenClientCredentialsGetOperation.Uri:
				case OauthLoginGetOperation.Uri:
				case OauthLogoutGetOperation.Uri:
					return true;
			}

			return false;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private void ClearToken() {
			GrantCode = null;
			BearerToken = null;
			RefreshToken = null;
			Expiration = DateTime.UtcNow;
		}

	}

}