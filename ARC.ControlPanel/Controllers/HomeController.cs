using ARC.ControlPanel.Models;
using ARC.Reports.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ARC.ControlPanel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //try
            //{

            var adminUser = Membership.GetUser();

            if (adminUser != null || !Roles.GetRolesForUser(adminUser.UserName).Contains("Admins"))
            {
                TipContext reportContext = new TipContext();

                Account account = reportContext.Accounts.Single(x => x.UserName == adminUser.UserName);

                ViewData["UserName"] = account.FirstName + " " + account.LastName;

                return View();


                //}
                //catch
                //{
                //}
            }
            else
            {
                //Server.Transfer("~/Public/Unauthorized.aspx");
                return View("Emad");
            }
        }
    }
}