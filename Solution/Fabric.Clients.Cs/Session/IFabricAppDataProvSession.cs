using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	/// <summary />
	public interface IFabricAppDataProvSession : IFabricPersonSession {

		/// <summary />
		IFabricAppSession AppSess { get; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		FabOauthAccess RequestAuthentication();

	}

}