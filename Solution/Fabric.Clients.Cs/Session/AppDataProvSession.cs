﻿using System;
using System.Web;
using Fabric.Clients.Cs.Api;
using FabOauthAccess = Fabric.Clients.Cs.Api.FabOauthAccess;
using IOauthService = Fabric.Clients.Cs.Api.IOauthService;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	internal class AppDataProvSession : PersonSession, IFabricAppDataProvSession {

		public IFabricAppSession AppSess { get; private set; }
		private readonly object vAccessLock;

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AppDataProvSession(IFabricClientConfig pConfig, IOauthService pClientOauth,
											IFabricAppSession pAppSess) : base(pConfig, pClientOauth) {
			AppSess = pAppSess;
			vAccessLock = new object();
		}

		/*--------------------------------------------------------------------------------------------*/
		public override string SessionDebugName { get { return "DataProv"; } }

		/*--------------------------------------------------------------------------------------------*/
		public FabOauthAccess RequestAuthentication() {
			return GetAccessToken(GetDataProvAccess);
		}

		/*--------------------------------------------------------------------------------------------*/
		public override bool RefreshTokenIfNecessary() {
			lock ( vAccessLock ) {
				if ( !IsAuthenticated ) {
					GetAccessToken(GetDataProvAccess);
					return true;
				}

				return base.RefreshTokenIfNecessary();
			}
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public override string GetGrantCodeUrl(bool pSwitchUser=false) {
			throw new NotSupportedException("Not available for DataProvider.");
		}

		/*--------------------------------------------------------------------------------------------*/
		public override string GetGrantWindowOpenScript(string pGrantCodeUrl=null) {
			throw new NotSupportedException("Not available for DataProvider.");
		}

		/*--------------------------------------------------------------------------------------------*/
		public override FabOauthAccess HandleGrantCodeRedirect(HttpRequestBase pRedirectRequest) {
			throw new NotSupportedException("Not available for DataProvider.");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private FabOauthAccess GetDataProvAccess() {
			lock ( vAccessLock ) {
				return ClientOauth.AccessTokenClientDataProv.Get(Config.AppOAuthRedirectUri,
					Config.AppSecret, Config.AppId+"", Config.AppDataProvPersonId+"");
			}
		}

	}

}