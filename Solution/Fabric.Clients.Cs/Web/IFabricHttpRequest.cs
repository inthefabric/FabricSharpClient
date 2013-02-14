using System.IO;
using System.Net;

namespace Fabric.Clients.Cs.Web {
	
	/*================================================================================================*/
	internal interface IFabricHttpRequest {

		/*--------------------------------------------------------------------------------------------*/
		string Accept { get; set; }
		string Method { get; set; }
		WebHeaderCollection Headers { get; set; }
		string ContentType { get; set; }
		long ContentLength { get; set; }

		/*--------------------------------------------------------------------------------------------*/
		Stream GetRequestStream();
		HttpWebResponse GetResponse();

	}

}