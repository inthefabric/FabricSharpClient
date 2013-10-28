using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
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

			const bool LOCAL = true;
			FabricClientConfig config;

			if ( LOCAL ) {
				config = new FabricClientConfig("ClientTest", "http://localhost:9000", 6,
					"0123456789abcdefghijkLMNOPqrstuv", 5, RedirProv, SessionContainerProvider);
			}
			else {
				config = new FabricClientConfig("ClientTest", "http://api.inthefabric.com", 1,
					"abcdefghijklmnopqrstuvwxyZ012345", 1, RedirProv, SessionContainerProvider);
			}
			
			FabricClient.InitOnce(config);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private static string RedirProv(string pConfigKey) {
			return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority)+
				"/Oauth/FabricRedirect";
		}
		
		/*--------------------------------------------------------------------------------------------*/
		private static IFabricSessionContainer SessionContainerProvider(string pConfigKey) {
			return FabricSessionContainer.FromHttpContext(HttpContext.Current, pConfigKey);
		}

	}

}