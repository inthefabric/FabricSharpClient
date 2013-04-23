using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.SessionState;
using Fabric.Clients.Cs.Session;

namespace Fabric.Clients.Cs.Mvc {

	/*================================================================================================*/
	public class MvcApplication : HttpApplication {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected void Application_Start() {
			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			const bool LOCAL = false;
			FabricClientConfig config = null;

			if ( LOCAL ) {
				config = new FabricClientConfig("ClientTest", "http://localhost:9000", 2,
					"0123456789abcdefghijkLMNOPqrstuv", 4, "http://localhost:49316/OAuth/FabricRedirect",
					FabricSessionContainerProvider);
			}
			else {
				config = new FabricClientConfig("ClientTest", "http://api.inthefabric.com", 1,
					"abcdefghijklmnopqrstuvwxyZ012345", 1, "http://localhost:49316/OAuth/FabricRedirect",
					FabricSessionContainerProvider);
			}
			
			FabricClient.InitOnce(config);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private static IFabricSessionContainer FabricSessionContainerProvider(string pConfigKey) {
			string key = "Fabric_"+pConfigKey;
			HttpSessionState sess = HttpContext.Current.Session;

			if ( sess == null ) {
				return null;
			}

			IFabricSessionContainer contain = (sess[key] as IFabricSessionContainer);

			if ( contain == null ) {
				sess[key] = (contain = new FabricSessionContainer());
			}

			return contain;
		}

	}

}