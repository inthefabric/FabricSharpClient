﻿namespace Fabric.Clients.Cs.Daemon {

	/*================================================================================================*/
	/// <summary />
	public interface IExportService {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		bool StartDataProvExport();

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		int StartNewUserExports();

	}

}