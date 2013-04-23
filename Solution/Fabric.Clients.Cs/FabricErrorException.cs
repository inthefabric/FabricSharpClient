using System;
using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs {
	
	/*================================================================================================*/
	/// <summary />
	public class FabricErrorException : Exception {

		/// <summary />
		public FabResponse RespError { get; private set; }

		/// <summary />
		public FabOauthError OauthError { get; private set; }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public FabricErrorException(FabResponse pRespError) :
				base(pRespError.Error.Name+" ("+pRespError.Error.Code+"): "+pRespError.Error.Message) {
			RespError = pRespError;
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public FabricErrorException(FabOauthError pOauthError) :
										base(pOauthError.error+" / "+pOauthError.error_description) {
			OauthError = pOauthError;
		}

	}

}