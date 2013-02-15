using System;
using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs {
	
	/*================================================================================================*/
	/// <summary />
	public class FabricErrorException : Exception {

		/// <summary />
		public IFabError Error { get; private set; }

		/// <summary />
		public IFabOauthError OauthError { get; private set; }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public FabricErrorException(IFabError pError) : base(pError.Name) {
			Error = pError;
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public FabricErrorException(IFabOauthError pOauthError) : base(pOauthError.error) {
			OauthError = pOauthError;
		}

	}

}