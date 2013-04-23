using System;
using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs.Web {
	
	/*================================================================================================*/
	internal class FabricResponse<T> {

		public T Data { get; private set; }
		public FabResponse RespError { get; private set; }
		public FabOauthError OauthError { get; private set; }
		public Exception Excep { get; private set; }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricResponse(T pData) {
			Data = pData;
		}

		/*--------------------------------------------------------------------------------------------*/
		public FabricResponse(FabResponse pRespError, Exception pExcep) {
			RespError = pRespError;
			Excep = pExcep;
		}

		/*--------------------------------------------------------------------------------------------*/
		public FabricResponse(FabOauthError pOauthError, Exception pExcep) {
			OauthError = pOauthError;
			Excep = pExcep;
		}

	}

}