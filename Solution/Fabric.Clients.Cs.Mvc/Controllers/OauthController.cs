using System.Web.Mvc;
using Fabric.Clients.Cs.Api;
using ServiceStack.Text;

namespace Fabric.Clients.Cs.Mvc.Controllers {

	/*================================================================================================*/
	public class OauthController : Controller {

		private readonly IFabricClient vFab;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public OauthController() {
			//Ideally, an IFabricClient instance would be injected into the controller via "Inversion
			//of Control" container, such as Castle.Windsor.
			vFab = new FabricClient();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ActionResult Index() {
			//Using IFabricClient as the model is probably not good practice, but it is useful here
			//for demonstration purposes.
			return View(vFab);
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult FabricRedirect() {
			FabOauthAccess result = vFab.PersonSession.HandleGrantCodeRedirect(Request);

			//close the login popup if authentication was successful
			if ( vFab.PersonSession.IsAuthenticated ) {
				Response.Write(
					"<script type='text/javascript'>"+
						"window.opener.location.reload();"+
						"window.close();"+
					"</script>"
				);
				Response.Write("Success!<br/><br/>"+JsonSerializer.SerializeToString(result));
				return null;
			}

			ViewBag.Message = JsonSerializer.SerializeToString(result);
			return View();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ActionResult RequestAppAuth() {
			try { vFab.AppSession.RequestAuthentication(); }
			catch ( FabricErrorException e ) { return View("Error", e); }
			return RedirectToAction("Index");
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult AppLogout() {
			try { vFab.AppSession.Logout(); }
			catch ( FabricErrorException e ) { return View("Error", e); }
			return RedirectToAction("Index");
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult AppRefresh() {
			try { vFab.AppSession.RefreshTokenIfNecessary(null); }
			catch ( FabricErrorException e ) { return View("Error", e); }
			return RedirectToAction("Index");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------* /
		public ActionResult RequestDpAuth() {
			try { vFab.AppDataProvSession.RequestAuthentication(); }
			catch ( FabricErrorException e ) { return View("Error", e); }
			return RedirectToAction("Index");
		}

		/*--------------------------------------------------------------------------------------------* /
		public ActionResult DpLogout() {
			try { vFab.AppDataProvSession.Logout(); }
			catch ( FabricErrorException e ) { return View("Error", e); }
			return RedirectToAction("Index");
		}

		/*--------------------------------------------------------------------------------------------* /
		public ActionResult DpRefresh() {
			try { vFab.AppDataProvSession.RefreshTokenIfNecessary(); }
			catch ( FabricErrorException e ) { return View("Error", e); }
			return RedirectToAction("Index");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ActionResult PersonLogout() {
			try { vFab.PersonSession.Logout(); }
			catch ( FabricErrorException e ) { return View("Error", e); }
			return null; //RedirectToAction("Index");
		}

		/*--------------------------------------------------------------------------------------------*/
		public ActionResult PersonRefresh() {
			try { vFab.PersonSession.RefreshTokenIfNecessary(null); }
			catch ( FabricErrorException e ) { return View("Error", e); }
			return RedirectToAction("Index");
		}

	}

}