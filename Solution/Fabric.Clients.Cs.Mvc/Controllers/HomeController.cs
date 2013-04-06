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
		public ActionResult Class(long? id) {
			if ( id == null ) { return View("404"); }
			FabArtifact model;

			try {
				model = vFab.Services.Traversal.GetRootStep
					.ContainsClassList.WhereId((long)id).Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult DescriptorTypes(long? id) {
			if ( id == null ) {
				return DescriptorTypeListView();
			}

			FabDescriptorType model;

			try {
				model = vFab.Services.Traversal.GetRootStep
					.ContainsDescriptorTypeList.WhereId((long)id).Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		private ActionResult DescriptorTypeListView() {
			var model = new List<FabObject>();

			try {
				IList<FabDescriptorType> result = vFab.Services.Traversal.GetRootStep
					.ContainsDescriptorTypeList.Get().Data;

				foreach ( FabDescriptorType at in result ) {
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
		/*--------------------------------------------------------------------------------------------*/
		public ActionResult Version() {
			FabMetaVersion model;

			try {
				model = vFab.Services.Meta.GetVersion.Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult Time() {
			FabMetaTime model;

			try {
				model = vFab.Services.Meta.GetTime.Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult Spec() {
			FabSpec model;

			try {
				model = vFab.Services.Meta.GetSpecification.Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

	}

}