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
		public ActionResult Artifact(uint? id) {
			if ( id == null ) { return View("404"); }
			IFabArtifact model;

			try {
				model = null;//vFab.Services.Traversal.GetRoot.Get().Artifacts.ArtifactId((uint)id).Get();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult ArtifactTypes(uint? id) {
			if ( id == null ) {
				return ArtifactTypeListView();
			}

			IFabArtifactType model;

			try {
				model = null;//vFab.Core.Artifacts.Types.ArtifactTypeId((uint)id).Get();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		private ActionResult ArtifactTypeListView() {
			List<IFabArtifactType> result;
			var model = new List<IFabObject>();

			try {
				result = null;//vFab.Core.Artifacts.Types.Get();
				foreach ( IFabObject t in result ) { model.Add(t); }
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("ItemList", model);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ActionResult MyApp() {
			IFabApp model;

			try {
				model = null;//vFab.Core.Myapp.Get();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult MyAppDataProv() {
			IFabUser model;

			try {
				vFab.UseDataProviderPerson = true;
				model = null;//vFab.Core.Me.Get();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult Me() {
			IFabUser model;

			try {
				model = null;//vFab.Core.Me.Get();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ActionResult ApiVersion() {
			string model;

			try {
				model = vFab.Services.ApiVersion;
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

	}

}