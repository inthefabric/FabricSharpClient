using Fabric.Clients.Cs.Api;
using FabOauthAccess = Fabric.Clients.Cs.Api.FabOauthAccess;

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