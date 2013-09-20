namespace Fabric.Clients.Cs.Session {
	
	/*================================================================================================*/
	internal interface IClientContext {

		IFabricClientConfig Config { get; }
		IFabricAppSession AppSess { get; }
		IFabricAppDataProvSession AppDataProvSess { get; }
		bool UseDataProvPerson { get; set; }
		IFabricPersonSession PersonSess { get; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogInfo(string text);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogDebug(string text);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogError(string text);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogFatal(string text);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogWarn(string text);

	}

}