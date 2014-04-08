using System.Linq;
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
			FabClass model;

			try {
				model = vFab.Services.Traversal.Classes
					.WithId((long)id).Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult ClassNameContains(string id) {
			if ( id == null ) { return View("404"); }
			FabClass model;

			try {
				model = vFab.Services.Traversal.Classes
					.WhereNameContains(id).Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult UserName(string id) {
			if ( id == null ) { return View("404"); }
			FabUser model;

			try {
				model = vFab.Services.Traversal.Users.WithName(id).Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult DescriptorTypes(byte? id) {
			if ( id == null ) {
				return View("ItemList", FabEnumsData.GetDescriptorTypeItems().ToList<object>());
			}

			DescriptorType model;

			try {
				model = FabEnumsData.GetDescriptorType((byte)id);
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ActionResult MyApp() {
			FabApp model;

			try {
				vFab.UseAppDataProvider = true;
				model = vFab.Services.Traversal.Members.Active().DefinedByApp().Get().FirstDataItem();
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
				vFab.UseAppDataProvider = true;
				model = vFab.Services.Traversal.Members.Active().DefinedByUser().Get().FirstDataItem();
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
				model = vFab.Services.Traversal.Members.Active().DefinedByUser().Get().FirstDataItem();
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
				model = vFab.Services.Meta.Version.Get().FirstDataItem();
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
				model = vFab.Services.Meta.Time.Get().FirstDataItem();
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
				model = vFab.Services.Meta.Spec.Get().FirstDataItem();
			}
			catch ( FabricErrorException e ) {
				return View("Error", e);
			}

			return View("Item", model);
		}

	}

}