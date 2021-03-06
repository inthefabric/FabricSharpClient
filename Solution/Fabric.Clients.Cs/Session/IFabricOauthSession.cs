﻿using System;
using System.Web;
using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	/// <summary />
	public interface IFabricOauthSession {

		/// <summary />
		string OAuthRedirectUri { get; }

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
		bool RefreshTokenIfNecessary(string pApiPath);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void SaveToCookies(HttpCookieCollection pCookies);

	}

}