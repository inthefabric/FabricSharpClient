using System.IO;
using System.Net;

namespace Fabric.Clients.Cs.Web {
	
	/*================================================================================================*/
	internal class FabricHttpResponse : IFabricHttpResponse {

		private HttpWebResponse vResp;
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricHttpResponse(HttpWebResponse pResponse) {
			vResp = pResponse;
		}

		/*--------------------------------------------------------------------------------------------*/
		public virtual Stream GetResponseStream() {
			return vResp.GetResponseStream();
		}

	}

}