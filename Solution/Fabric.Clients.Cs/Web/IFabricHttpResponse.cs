using System.IO;

namespace Fabric.Clients.Cs.Web {
	
	/*================================================================================================*/
	internal interface IFabricHttpResponse {

		/*--------------------------------------------------------------------------------------------*/
		Stream GetResponseStream();

	}

}