using System.Web.Optimization;

namespace Fabric.Clients.Cs.Mvc {

	/*================================================================================================*/
	public class BundleConfig {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static void RegisterBundles(BundleCollection pBundles) {
			pBundles.Add(
				new StyleBundle("~/Content/css")
					.Include("~/Content/Site.css")
					.Include("~/Content/FabricDataGrid.css")
			);
		}

	}

}