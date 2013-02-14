using System.IO;
using System.Net;

namespace Fabric.Clients.Cs.Web {
	
	/*================================================================================================*/
	internal class FabricHttpRequest : IFabricHttpRequest {

		private readonly HttpWebRequest vReq;
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricHttpRequest(string pRequestUri) {
			vReq = (HttpWebRequest)WebRequest.Create(pRequestUri);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public virtual string Accept {
			get { return vReq.Accept; }
			set { vReq.Accept = value; }
		}

		/*--------------------------------------------------------------------------------------------*/
		public virtual string Method {
			get { return vReq.Method; }
			set { vReq.Method = value; }
		}

		/*--------------------------------------------------------------------------------------------*/
		public virtual WebHeaderCollection Headers {
			get { return vReq.Headers; }
			set { vReq.Headers = value; }
		}

		/*--------------------------------------------------------------------------------------------*/
		public virtual string ContentType {
			get { return vReq.ContentType; }
			set { vReq.ContentType = value; }
		}

		/*--------------------------------------------------------------------------------------------*/
		public virtual long ContentLength {
			get { return vReq.ContentLength; }
			set { vReq.ContentLength = value; }
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public virtual Stream GetRequestStream() {
			return vReq.GetRequestStream();
		}

		/*--------------------------------------------------------------------------------------------*/
		public virtual HttpWebResponse GetResponse() {
			return (HttpWebResponse)vReq.GetResponse();
		}

	}

}