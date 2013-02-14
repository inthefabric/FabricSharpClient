namespace Fabric.Clients.Cs.Web {
	
	/*================================================================================================*/
	internal class FabricHttpProvider {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public virtual IFabricHttpRequest CreateRequest(string pRequestUri) {
			return new FabricHttpRequest(pRequestUri);
		}

		/*--------------------------------------------------------------------------------------------*/
		public virtual IFabricHttpResponse GetResponse(IFabricHttpRequest pRequest) {
			return new FabricHttpResponse(pRequest.GetResponse());
		}

	}

}
