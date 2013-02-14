using System;
using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs {
	
	/*================================================================================================*/
	/// <summary />
	public class FabricErrorException : Exception {

		/// <summary />
		public FabError Error { get; private set; }

		/// <summary />
		public FabOauthError OauthError { get; private set; }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public FabricErrorException(FabError pError) : base(pError.Name) {
			Error = pError;
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public FabricErrorException(FabOauthError pOauthError) : base(pOauthError.error) {
			OauthError = pOauthError;
		}

	}

}