using System.Web.Mvc;
using System.Web.Routing;

namespace Fabric.Clients.Cs.Mvc {

	/*================================================================================================*/
	public class RouteConfig {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static void RegisterRoutes(RouteCollection pRoutes) {
			pRoutes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			pRoutes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}

	}

}