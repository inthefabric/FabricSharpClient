using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs.Web {
	
	/*================================================================================================*/
	internal class FabricResponse<T> {

		public T Data { get; private set; }
		public FabResponse RespError { get; private set; }
		public FabOauthError OauthError { get; private set; }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricResponse(T pData) {
			Data = pData;
		}

		/*--------------------------------------------------------------------------------------------*/
		public FabricResponse(FabResponse pRespError) {
			RespError = pRespError;
		}

		/*--------------------------------------------------------------------------------------------*/
		public FabricResponse(FabOauthError pOauthError) {
			OauthError = pOauthError;
		}

	}

}