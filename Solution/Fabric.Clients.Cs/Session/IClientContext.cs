namespace Fabric.Clients.Cs.Session {
	
	/*================================================================================================*/
	internal interface IClientContext {

		IFabricClientConfig Config { get; }
		IFabricAppSession AppSess { get; }
		IFabricAppDataProvSession AppDataProvSess { get; }
		bool UseDataProvPerson { get; set; }
		IFabricPersonSession PersonSess { get; }

	}

}