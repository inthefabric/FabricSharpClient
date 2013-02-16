using System.Collections.Generic;
using System.Web.Mvc;
using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs.Mvc.Controllers {

	/*================================================================================================*/
	public class HomeController : Controller {

		private readonly IFabricClient vFab;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public HomeController() {
			//Ideally, an IFabricClient instance would be injected into the controller via "Inversion
			//of Control" container, such as Castle.Windsor.
			vFab = new FabricClient();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ActionResult Index() {
			return View();
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult Artifact(long? id) {
			if ( id == null ) { return View("404"); }
			FabArtifact model;

			try {
				model = vFab.Services.Traversal.GetRootStep
					.ContainsArtifactList.WhereId((long)id).Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult ArtifactTypes(long? id) {
			if ( id == null ) {
				return ArtifactTypeListView();
			}

			FabArtifactType model;

			try {
				model = vFab.Services.Traversal.GetRootStep
					.ContainsArtifactTypeList.WhereId((long)id).Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		private ActionResult ArtifactTypeListView() {
			var model = new List<FabObject>();

			try {
				IList<FabArtifactType> result = vFab.Services.Traversal.GetRootStep
					.ContainsArtifactTypeList.Get().Data;

				foreach ( FabArtifactType at in result ) {
					model.Add(at);
				}
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("ItemList", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult DescriptorTypes() {
			var model = new List<FabObject>();

			try {
				IList<FabDescriptorType> result = vFab.Services.Traversal.GetRootStep
					.ContainsDescriptorTypeList.Get().Data;

				foreach ( FabDescriptorType dt in result ) {
					model.Add(dt);
				}
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("ItemList", model);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ActionResult MyApp() {
			FabApp model;

			try {
				model = vFab.Services.Traversal.GetActiveApp.Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult MyAppDataProv() {
			FabUser model;

			try {
				vFab.UseDataProviderPerson = true;
				model = vFab.Services.Traversal.GetActiveUser.Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult Me() {
			FabUser model;

			try {
				model = vFab.Services.Traversal.GetActiveUser.Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------* /
		public ActionResult ApiVersion() {
			string model;

			try {
				model = vFab.Services.ApiVersion;
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}*/

	}

}