﻿namespace Fabric.Clients.Cs.Daemon {

	/*================================================================================================*/
	/// <summary />
	public interface IExportForClient {

		/// <summary />
		IFabricClient Client { get; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void StartExport();
	
	}

}