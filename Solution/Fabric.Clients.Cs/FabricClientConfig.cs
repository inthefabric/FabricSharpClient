﻿using System;
using System.Web;
using Fabric.Clients.Cs.Logging;
using Fabric.Clients.Cs.Session;

namespace Fabric.Clients.Cs {
	
	/*================================================================================================*/
	/// <summary />
	public class FabricClientConfig : IFabricClientConfig {

		//TODO: consider WebSessionStorage (like SharpArch) instead of FabricSessionContainer?

		/// <summary />
		public string ConfigKey { get; private set; }

		/// <summary />
		public string ApiPath { get; private set; }

		/// <summary />
		public long AppId { get; private set; }

		/// <summary />
		public string AppSecret { get; private set; }

		/// <summary />
		public long AppDataProvPersonId { get; private set; }

		/// <summary />
		public string AppOAuthRedirectUri { get; private set; }

		/// <summary />
		public IFabricLog Logger { get; set; }

		private readonly SessionContainerProvider vSessProv;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public FabricClientConfig(string configKey, string apiPath, long appId, string appSecret,
												long appDataProvPersonId, string appOauthRedirectUri,
												SessionContainerProvider sessionContainerProvider) {

			if ( string.IsNullOrWhiteSpace(configKey) ) {
				throw new Exception("Invalid ConfigKey.");
			}
			
			if ( string.IsNullOrWhiteSpace(apiPath) ) {
				throw new Exception("Invalid ApiPath.");
			}

			if ( appId <= 0 ) {
				throw new Exception("Invalid AppId.");
			}

			if ( string.IsNullOrWhiteSpace(appSecret) ) {
				throw new Exception("Invalid AppSecret.");
			}

			if ( string.IsNullOrWhiteSpace(appOauthRedirectUri) ) {
				throw new Exception("Invalid AppOAuthRedirectUri.");
			}

			if ( sessionContainerProvider == null ) {
				throw new Exception("Invalid SessionContainerProvider.");
			}

			////

			Logger = new FabricLog();
			ConfigKey = configKey;

			ApiPath = apiPath;
			//if ( ApiPath[ApiPath.Length-1] != '/' ) { ApiPath += "/"; }

			AppId = appId;
			AppSecret = appSecret;
			AppDataProvPersonId = appDataProvPersonId;
			AppOAuthRedirectUri = HttpUtility.UrlEncode(appOauthRedirectUri);

			vSessProv = sessionContainerProvider;
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public delegate IFabricSessionContainer SessionContainerProvider(string configKey);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public IFabricSessionContainer GetSessionContainer() {
			return vSessProv(ConfigKey);
		}

	}

}
