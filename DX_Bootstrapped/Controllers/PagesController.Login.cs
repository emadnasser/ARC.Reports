using System.Web.Mvc;
using DX_Bootstrapped.Models;

namespace DX_Bootstrapped.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Login(int? id)
        {
            return View();
        }
    }
}