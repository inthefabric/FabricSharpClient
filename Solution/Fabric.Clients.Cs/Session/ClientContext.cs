namespace Fabric.Clients.Cs.Session {
	
	/*================================================================================================*/
	internal class ClientContext : IClientContext {

		public IFabricClientConfig Config { get; private set; }
		public IFabricAppSession AppSess { get; private set; }
		public bool UseAppDataProvider { get; set; }

		private IFabricPersonSession vPersonSess;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ClientContext(IFabricClientConfig pConfig, IFabricAppSession pAppSess) {
			Config = pConfig;
			AppSess = pAppSess;
		}

		/*--------------------------------------------------------------------------------------------*/
		public IFabricOauthSession ActiveSess {
			get {
				if ( UseAppDataProvider ) {
					return AppSess;
				}

				return PersonSess;
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IFabricPersonSession PersonSess {
			get {
				if ( vPersonSess != null ) {
					return vPersonSess;
				}

				IFabricSessionContainer contain = Config.GetSessionContainer();
				vPersonSess = contain.Person;

				if ( vPersonSess == null ) {
					vPersonSess = new PersonSession(Config,
						new FabricClient(Config.ConfigKey).Services.Oauth);
					contain.Person = vPersonSess;
					LogInfo("New PersonSess: "+vPersonSess.SessionId);
				}

				return vPersonSess;
			}
			internal set {
				vPersonSess = value;
			}
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public void LogInfo(string pText) { Config.Logger.Info(GetSessId(), pText); }

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public void LogDebug(string pText) { Config.Logger.Debug(GetSessId(), pText); }

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public void LogError(string pText) { Config.Logger.Error(GetSessId(), pText); }

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public void LogFatal(string pText) { Config.Logger.Fatal(GetSessId(), pText); }

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public void LogWarn(string pText) { Config.Logger.Warn(GetSessId(), pText); }

		/*--------------------------------------------------------------------------------------------*/
		private string GetSessId() {
			return (ActiveSess == null ? null : ActiveSess.SessionId);
		}

	}

}