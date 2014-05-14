using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Session;
using ServiceStack.Text;

[assembly:InternalsVisibleTo("Fabric.Clients.Cs.Test")]
[assembly:InternalsVisibleTo("Moq")]
[assembly:InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace Fabric.Clients.Cs {
	
	/*================================================================================================*/
	/// <summary />
	public class FabricClient : IFabricClient {

		private static bool IsInit;
		private static Dictionary<string, IFabricClientConfig> ConfigMap =
			new Dictionary<string, IFabricClientConfig>();
		private static Dictionary<string, IFabricAppSession> AppSessMap =
			new Dictionary<string, IFabricAppSession>();
		private static string DefaultConfigKey;

		/// <summary />
		public static string ApiVersion;

		internal ClientContext Context { get; private set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static void ResetInitialization() {
			IsInit = false;
			ConfigMap = new Dictionary<string, IFabricClientConfig>();
			AppSessMap = new Dictionary<string, IFabricAppSession>();
			DefaultConfigKey = null;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static bool IsInitialized {
			get { return IsInit; }
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static void InitOnce(IFabricClientConfig config) {
			lock ( ConfigMap ) {
				if ( IsInit ) {
					throw new Exception("FabricClient.InitOnce() has already been called.");
				}

				IsInit = true;
				AttachNewConfigGroup(config);
				DefaultConfigKey = config.ConfigKey;
				JsConfig.TreatEnumAsInteger = true;
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static void AddConfig(IFabricClientConfig config) {
			lock ( ConfigMap ) {
				if ( !IsInit ) {
					throw new Exception("FabricClient.InitOnce() has not been called yet.");
				}

				AttachNewConfigGroup(config);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void AttachNewConfigGroup(IFabricClientConfig pConfig) {
			if ( pConfig == null ) {
				throw new Exception("The provided IFabricClientConfig is null.");
			}

			if ( ConfigMap.ContainsKey(pConfig.ConfigKey) ) {
				throw new Exception("The configKey '"+pConfig.ConfigKey+"' is already in use.");
			}

			ConfigMap.Add(pConfig.ConfigKey, pConfig);

			var context = new ClientContext(pConfig);
			var services = new FabricServices(context);
			var appSess = new AppSession(pConfig, services.Oauth);
			context.AppSess = appSess;
			AppSessMap[pConfig.ConfigKey] = appSess;

			ApiVersion = services.ApiVersion;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public FabricClient() : this(DefaultConfigKey) {}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public FabricClient(IFabricPersonSession personSess) : this(personSess, DefaultConfigKey) {}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public FabricClient(IFabricPersonSession personSess, string configKey) : this(configKey) {
			Context.PersonSess = personSess;
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public FabricClient(string pConfigKey) {
			if ( !IsInit ) {
				throw new Exception("FabricClient.InitOnce() has not been called yet.");
			}

			if ( !ConfigMap.ContainsKey(pConfigKey) ) {
				throw new Exception("Configuration not found for configKey '"+pConfigKey+"'.");
			}

			IFabricClientConfig config = ConfigMap[pConfigKey];

			Context = new ClientContext(config);
			Context.AppSess = AppSessMap[pConfigKey];
			Context.LogInfo("New FabricClient");

			Services = new FabricServices(Context);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public IFabricClientConfig Config { get { return Context.Config; } }

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public IFabricPersonSession PersonSession { get { return Context.PersonSess; } }

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public IFabricAppSession AppSession { get { return Context.AppSess; } }

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public IFabricOauthSession ActiveSession { get { return Context.ActiveSess; } }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public IFabricServices Services { get; private set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public bool UseAppDataProvider {
			get {
				return Context.UseAppDataProvider;
			}
			set {
				Context.LogInfo("UseDataProviderPerson: "+value);
				Context.UseAppDataProvider = value;
			}
		}

	}

}
