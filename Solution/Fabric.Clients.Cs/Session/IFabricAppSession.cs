using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	/// <summary />
	public interface IFabricAppSession : IFabricOauthSession {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		FabOauthAccess RequestAuthentication();

	}

}