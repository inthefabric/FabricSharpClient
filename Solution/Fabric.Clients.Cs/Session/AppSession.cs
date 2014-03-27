using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	internal class AppSession : OauthSession, IFabricAppSession {

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AppSession(IFabricClientConfig pConfig, IOauthService pClientOauth) :
																		base(pConfig, pClientOauth) {}

		/*--------------------------------------------------------------------------------------------*/
		public FabOauthAccess RequestAuthentication() {
			return GetAccessToken(GetAccessTokenClient);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public override bool RefreshTokenIfNecessary(string pApiPath) {
			lock ( Config ) {
				if ( IsOauthOperation(pApiPath) || !IsExpired() ) {
					return false;
				}

				GetAccessToken(GetAccessTokenClient);
			}

			return true;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private FabOauthAccess GetAccessTokenClient() {
			lock ( Config ) {
				return ClientOauth.AccessTokenClientCredentials.Get(
					Config.AppId, Config.AppSecret, OAuthRedirectUri, SessionType.App);
			}
		}

	}

}