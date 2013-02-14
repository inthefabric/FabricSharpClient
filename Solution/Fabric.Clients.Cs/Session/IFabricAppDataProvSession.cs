using Fabric.Clients.Cs.Api;
using FabOauthAccess = Fabric.Clients.Cs.Api.FabOauthAccess;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	/// <summary />
	public interface IFabricAppDataProvSession : IFabricOauthSession, IFabricPersonSession {

		/// <summary />
		IFabricAppSession AppSess { get; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		FabOauthAccess RequestAuthentication();

	}

}