using System.Collections.Generic;

namespace Fabric.Clients.Cs.Daemon {

	/*================================================================================================*/
	/// <summary />
	public interface IExportServiceDelegate {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		IFabricClient GetDataProvClient();

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		IList<IFabricClient> GetUserClients();

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void HandleExpiredUserClient(IFabricClient pClient);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		IExportForClientDelegate GetExportForClientDelegate(IFabricClient pClient);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		IExportForClient GetExportForClient(IExportForClientDelegate pDelegate);

	}

}