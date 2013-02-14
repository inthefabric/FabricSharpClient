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

			FabricClientInit();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private static void FabricClientInit() {
			var config = new FabricClientConfig(
				"App2", //ConfigKey
				"http://inthefabric.com/api", /* local testing: http://localhost:53109/ */
				4, //AppId
				"73602b8dc62541e39884312cd8b80090", //App Secret
				2, //App DataProvider PersonId
				"http://localhost:44444/OAuth/FabricRedirect",
				FabricSessionContainerProvider);

			FabricClient.InitOnce(config);
		}

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