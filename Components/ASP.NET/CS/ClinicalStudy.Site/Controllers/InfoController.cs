using System.Web.Mvc;
using System.Net;

namespace ClinicalStudy.Site.Controllers {
	public class InfoController : Controller {
        public ActionResult OldBrowser() {
            return View();
        }
        public ActionResult Error() {
            Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return View();
        }
        public ActionResult NotFound() {
            Response.StatusCode = (int)HttpStatusCode.NotFound;
            return View();
        }
	}
}
