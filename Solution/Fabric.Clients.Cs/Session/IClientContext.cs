namespace Fabric.Clients.Cs.Session {
	
	/*================================================================================================*/
	internal interface IClientContext {

		IFabricClientConfig Config { get; }
		IFabricAppSession AppSess { get; }
		IFabricPersonSession PersonSess { get; }
		IFabricOauthSession ActiveSess { get; }
		bool UseAppDataProvider { get; set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogInfo(string pText);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogDebug(string pText);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogError(string pText);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogFatal(string pText);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogWarn(string pText);

	}

}