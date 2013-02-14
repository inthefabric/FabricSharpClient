using System;
using Fabric.Clients.Cs.Api;
using FabOauthLogout = Fabric.Clients.Cs.Api.FabOauthLogout;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	/// <summary />
	public interface IFabricOauthSession {

		/// <summary />
		string GrantCode { get; }
		/// <summary />
		string BearerToken { get; }
		/// <summary />
		string RefreshToken { get; }
		/// <summary />
		bool IsAuthenticated { get; }
		/// <summary />
		DateTime Expiration { get; }
		/// <summary />
		string SessionId { get; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		FabOauthLogout Logout();

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		bool RefreshTokenIfNecessary();

	}

}