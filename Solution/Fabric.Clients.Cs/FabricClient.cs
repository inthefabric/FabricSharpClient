using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Session;

[assembly:InternalsVisibleTo("Fabric.Clients.Cs.Test")]
[assembly:InternalsVisibleTo("Moq")]
[assembly:InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace Fabric.Clients.Cs {
	
	/*================================================================================================*/
	/// <summary />
	public class FabricClient : IFabricClient {

		private static bool IsInit = false;
		private static Dictionary<string, ConfigGroup> ConfigGroups =
			new Dictionary<string, ConfigGroup>();
		private static string DefaultConfigKey;

		internal IClientContext Context { get; private set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static void ResetInitialization() {
			IsInit = false;
			ConfigGroups = new Dictionary<string, ConfigGroup>();
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
			lock ( ConfigGroups ) {
				if ( IsInit ) {
					throw new Exception("FabricClient.InitOnce() has already been called.");
				}

				IsInit = true;
				AttachNewConfigGroup(config);
				DefaultConfigKey = config.ConfigKey;
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static void AddConfig(IFabricClientConfig config) {
			lock ( ConfigGroups ) {
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

			if ( ConfigGroups.ContainsKey(pConfig.ConfigKey) ) {
				throw new Exception("The configKey '"+pConfig.ConfigKey+"' is already in use.");
			}

			var cg = new ConfigGroup();
			ConfigGroups.Add(pConfig.ConfigKey, cg);

			cg.Config = pConfig;
			cg.AppSess = new AppSession(pConfig,
				new FabricClient(pConfig.ConfigKey, false).Services.Oauth);
			cg.DataProvSess = new AppDataProvSession(pConfig,
				new FabricClient(pConfig.ConfigKey).Services.Oauth, cg.AppSess);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public FabricClient() : this(DefaultConfigKey) {}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public FabricClient(string configKey) : this(configKey, true) {}

		/*--------------------------------------------------------------------------------------------*/
		internal FabricClient(string pConfigKey, bool pIncludeContextSessions) {
			if ( !IsInit ) {
				throw new Exception("FabricClient.InitOnce() has not been called yet.");
			}

			if ( !ConfigGroups.ContainsKey(pConfigKey) ) {
				throw new Exception("Configuration not found for configKey '"+pConfigKey+"'.");
			}

			ConfigGroup cg = ConfigGroups[pConfigKey];

			if ( pIncludeContextSessions ) {
				Context = new ClientContext(cg.Config, cg.AppSess, cg.DataProvSess);
			}
			else {
				Context = new ClientContext(cg.Config, null, null);
			}

			Context.Config.LogInfo("New FabricClient");
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
		public IFabricAppDataProvSession AppDataProvSession {
			get { return Context.AppDataProvSess; }
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public IFabricServices Services { get; private set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public bool UseDataProviderPerson {
			get {
				return Context.UseDataProvPerson;
			}
			set {
				Config.LogInfo("UseDataProviderPerson: "+value);
				Context.UseDataProvPerson = value;
			}
		}

	}
	

	/*================================================================================================*/
	internal class ConfigGroup {

		public IFabricClientConfig Config { get; set; }
		public AppSession AppSess { get; set; }
		public AppDataProvSession DataProvSess { get; set; }

	}

}
