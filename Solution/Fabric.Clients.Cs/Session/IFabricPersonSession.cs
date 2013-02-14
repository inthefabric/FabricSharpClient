﻿using System.Web;
using Fabric.Clients.Cs.Api;
using FabOauthAccess = Fabric.Clients.Cs.Api.FabOauthAccess;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	/// <summary />
	public interface IFabricPersonSession : IFabricOauthSession {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		string GetGrantCodeUrl(bool pSwitchUser=false);
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		string GetGrantWindowOpenScript(string pGrantCodeUrl=null);
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		FabOauthAccess HandleGrantCodeRedirect(HttpRequestBase pRedirectRequest);

	}

}