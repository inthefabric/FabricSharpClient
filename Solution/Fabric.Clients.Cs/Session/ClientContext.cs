namespace Fabric.Clients.Cs.Session {
	
	/*================================================================================================*/
	internal class ClientContext : IClientContext {

		public IFabricClientConfig Config { get; private set; }
		public IFabricAppSession AppSess { get; private set; }
		public IFabricAppDataProvSession AppDataProvSess { get; private set; }
		public bool UseDataProvPerson { get; set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ClientContext(IFabricClientConfig pConfig, IFabricAppSession pAppSess,
														IFabricAppDataProvSession pAppDataProvSess) {
			Config = pConfig;
			AppSess = pAppSess;
			AppDataProvSess = pAppDataProvSess;
		}

		/*--------------------------------------------------------------------------------------------*/
		public IFabricPersonSession PersonSess {
			get {
				if ( UseDataProvPerson ) {
					return AppDataProvSess;
				}

				IFabricSessionContainer contain = Config.GetSessionContainer();
				IFabricPersonSession p = contain.Person;
				
				if ( p == null ) {
					p = new PersonSession(Config, new FabricClient(Config.ConfigKey).Services.Oauth);
					contain.Person = p;
					Config.LogInfo("New PersonSess: "+p.SessionId);
				}

				return p;
			}
		}

	}

}