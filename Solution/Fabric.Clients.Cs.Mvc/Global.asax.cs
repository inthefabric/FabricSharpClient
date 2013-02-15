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

			var config = new FabricClientConfig("ClientTest", "http://localhost:9000", 1,
				"abcdefghijklmnopqrstuvwxyZ012345", 1, "http://localhost:55555/OAuth/FabricRedirect",
				FabricSessionContainerProvider);

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