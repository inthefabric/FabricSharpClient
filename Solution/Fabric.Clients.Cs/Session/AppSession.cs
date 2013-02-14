﻿using Fabric.Clients.Cs.Api;
using FabOauthAccess = Fabric.Clients.Cs.Api.FabOauthAccess;
using IOauthService = Fabric.Clients.Cs.Api.IOauthService;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	internal class AppSession : OauthSession, IFabricAppSession {

		private readonly object vAccessLock;

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AppSession(IFabricClientConfig pConfig, IOauthService pClientOauth)
																		: base(pConfig, pClientOauth) {
			vAccessLock = new object();
		}

		/*--------------------------------------------------------------------------------------------*/
		public override string SessionDebugName { get { return "App"; } }

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
					Config.AppOAuthRedirectUri, Config.AppSecret, Config.AppId+"");
				//Config.LogDebug("... Client_credentials Complete");
				//return oa;
			}
		}

	}

}