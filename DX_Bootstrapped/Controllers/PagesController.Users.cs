using System.Web.Mvc;
using DX_Bootstrapped.Models;

namespace DX_Bootstrapped.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Users(int? id)
        {
            return View();
        }
    }
}