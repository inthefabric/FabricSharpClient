using System.IO;
using System.Net;

namespace Fabric.Clients.Cs.Test.Common {
	
	/*================================================================================================*/
	public class TestWebResponse : WebResponse {

		private readonly Stream vStream;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TestWebResponse(Stream pStream) {
			vStream = pStream;
		}

		/*--------------------------------------------------------------------------------------------*/
		public override Stream GetResponseStream() {
			return vStream;
		}

	}

}