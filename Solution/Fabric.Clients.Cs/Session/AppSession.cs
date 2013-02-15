using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	internal class AppSession : OauthSession, IFabricAppSession {

		private readonly object vAccessLock;

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AppSession(IFabricClientConfig pConfig, IOauthService pClientOauth) :
																		base(pConfig, pClientOauth) {
			vAccessLock = new object();
		}

		/*--------------------------------------------------------------------------------------------*/
		public override string SessionDebugName {
			get { return "App"; }
		}

		/*--------------------------------------------------------------------------------------------*/
		public FabOauthAccess RequestAuthentication() {
			return GetAccessToken(GetClientAccess);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public override bool RefreshTokenIfNecessary() {
			//Config.LogDebug("RefreshTokenIfNecessary()");

			lock ( vAccessLock ) {
				if ( IsAuthenticated && !IsRefreshNecessary() ) { return false; }
				GetAccessToken(GetClientAccess);
			}

			return true;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private FabOauthAccess GetClientAccess() {
			//Config.LogDebug("GetClientAccess()");

			lock ( vAccessLock ) {
				//Config.LogDebug("... Client_credentials Start");
				//FabOauthAccess oa =
				return ClientOauth.AccessTokenClientCredentials.Get(
					Config.AppId+"", Config.AppSecret, Config.AppOAuthRedirectUri);
				//Config.LogDebug("... Client_credentials Complete");
				//return oa;
			}
		}

	}

}