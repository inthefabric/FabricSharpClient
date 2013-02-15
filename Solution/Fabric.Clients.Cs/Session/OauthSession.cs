using System;
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
		public IFabOauthLogout Logout() {
			IFabOauthLogout logout = ClientOauth.Logout.Get(BearerToken);
			ClearToken();
			Config.LogInfo("Logout: success="+logout.success+", access_token="+logout.access_token);
			return logout;
		}

		/*--------------------------------------------------------------------------------------------*/
		public abstract bool RefreshTokenIfNecessary();
		public abstract string SessionDebugName { get; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected IFabOauthAccess GetAccessToken(Func<IFabOauthAccess> pAccessFunc) {
			IFabOauthAccess oa;

			try {
				oa = pAccessFunc();

				BearerToken = oa.access_token;
				RefreshToken = oa.refresh_token;
				Expiration = DateTime.Now.AddSeconds(oa.expires_in-60);
				Config.LogInfo(SessionDebugName+" GetAccessToken: BearerToken="+BearerToken+
					", RefreshToken="+RefreshToken+", Expiration="+Expiration+
					", Now="+DateTime.Now);
			}
			catch ( FabricErrorException fe ) {
				Config.LogInfo("FabricErrorException: "+fe);
				ClearToken();
				return null;
			}

			return oa;
		}

		/*--------------------------------------------------------------------------------------------*/
		protected virtual bool IsRefreshNecessary() {
			Config.LogInfo("IsRefreshNecessary: "+SessionDebugName+" expires in "+
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