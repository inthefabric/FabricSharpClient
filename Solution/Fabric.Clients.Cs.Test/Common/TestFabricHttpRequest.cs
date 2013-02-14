using System.IO;
using System.Net;
using Fabric.Clients.Cs.Web;

namespace Fabric.Clients.Cs.Test.Common {
	
	/*================================================================================================*/
	public class TestFabricHttpRequest : IFabricHttpRequest {

		private readonly MemoryStream vStream;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TestFabricHttpRequest() {
			Headers = new WebHeaderCollection();
			vStream = new MemoryStream();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public virtual string RequestUri { get; set; }

		/*--------------------------------------------------------------------------------------------*/
		public virtual string Accept { get; set; }
		public virtual string Method { get; set; }
		public virtual WebHeaderCollection Headers { get; set; }
		public virtual string ContentType { get; set; }
		public virtual long ContentLength { get; set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public virtual Stream GetRequestStream() {
			return vStream;
		}

		/*--------------------------------------------------------------------------------------------*/
		public virtual HttpWebResponse GetResponse() {
			return null;
		}

	}

}