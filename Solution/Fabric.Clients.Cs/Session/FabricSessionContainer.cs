using System;
using System.Web;
using System.Web.SessionState;

namespace Fabric.Clients.Cs.Session {

	/*================================================================================================*/
	/// <summary />
	public class FabricSessionContainer : IFabricSessionContainer {
		
		/// <summary />
		public IFabricPersonSession Person { get; set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static IFabricSessionContainer FromValues(IFabricClient pClient, string pSessionId,
				string pGrantCode, string pBearerToken, string pRefreshToken, DateTime pExpriration) {
			var ps = new PersonSession(pClient.Config, pClient.Services.Oauth);
			ps.SessionId = pSessionId;
			ps.GrantCode = pGrantCode;
			ps.BearerToken = pBearerToken;
			ps.RefreshToken = pRefreshToken;
			ps.Expiration = pExpriration;

			return new FabricSessionContainer { Person = ps };
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static IFabricSessionContainer FromCookies(
												IFabricClient pClient, HttpCookieCollection pCookies) {
			var ps = new PersonSession(pClient.Config, pClient.Services.Oauth);
			
			if ( !ps.LoadFromCookies(pCookies) ) {
				return null;
			}

			return new FabricSessionContainer { Person = ps };
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		//TEST: FabricSessionContainer.FromHttpContext()
		public static IFabricSessionContainer FromHttpContext(HttpContext pContext, string pConfigKey) {
			HttpSessionState sess = pContext.Session;

			if ( sess == null ) {
				return null;
			}

			string key = "Fabric_"+pConfigKey;
			IFabricSessionContainer sc = (sess[key] as IFabricSessionContainer);

			if ( sc != null ) {
				return sc;
			}

			sc = FromCookies(new FabricClient(pConfigKey), pContext.Request.Cookies);

			if ( sc == null ) {
				sc = new FabricSessionContainer();
			}

			sess[key] = sc;
			return sc;
		}

	}

}