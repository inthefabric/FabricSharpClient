using Fabric.Clients.Cs.Api;
using FabError = Fabric.Clients.Cs.Api.FabError;
using FabOauthError = Fabric.Clients.Cs.Api.FabOauthError;

namespace Fabric.Clients.Cs.Web {
	
	/*================================================================================================*/
	internal class FabricResponse<T> {

		public T Data { get; private set; }
		public FabError Error { get; private set; }
		public FabOauthError OauthError { get; private set; }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricResponse(T pData) {
			Data = pData;
		}

		/*--------------------------------------------------------------------------------------------*/
		public FabricResponse(FabError pError) {
			Error = pError;
		}

		/*--------------------------------------------------------------------------------------------*/
		public FabricResponse(FabOauthError pOauthError) {
			OauthError = pOauthError;
		}

	}

}