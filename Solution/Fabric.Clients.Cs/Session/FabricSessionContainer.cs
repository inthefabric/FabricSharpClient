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
		/// //TEST: FabricSessionContainer.FromCookies()
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