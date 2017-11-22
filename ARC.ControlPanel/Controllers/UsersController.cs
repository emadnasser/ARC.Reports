using ARC.ControlPanel.Models;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace ARC.ControlPanel.Controllers
{
    public class UsersController : Controller
    {
        //public ActionResult Index(int appId = 1)
        //{
        //    GetUserInfo();

        //    return View();
        //}

        [HttpPost]
        public ActionResult Get(int appId = 1)
        {
            GetUserInfo();

            //IsExist();

            User user = new User();
            string txtId = "";

            //string strName = form["txtName"].ToString();

            try
            {
                if (Request["txtId"] != null)
                {
                    txtId = Request["txtId"].ToString().Trim();

                    using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, "alrajhi.bank", "0100589", "uVZd0456"))
                    {
                        //string txtName = Request["txtName"].ToString();

                        UserPrincipal _userPrincipal = UserPrincipal.FindByIdentity(principalContext, "0100589");
                        UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(principalContext, txtId);

                        if (userPrincipal != null && !_userPrincipal.IsAccountLockedOut() && !userPrincipal.IsAccountLockedOut())
                        {
                            DirectoryEntry directoryEntry = userPrincipal.GetUnderlyingObject() as DirectoryEntry;

                            if (directoryEntry.Properties["samAccountName"].Value != null)
                                user.UserId = directoryEntry.Properties["samAccountName"].Value.ToString();

                            if (directoryEntry.Properties["givenName"].Value != null)
                                user.FirstName = directoryEntry.Properties["givenName"].Value.ToString();

                            if (directoryEntry.Properties["sn"].Value != null)
                                user.LastName = directoryEntry.Properties["sn"].Value.ToString();

                            if (directoryEntry.Properties["mail"].Value != null)
                                user.Email = directoryEntry.Properties["mail"].Value.ToString();

                            if (directoryEntry.Properties["TelephoneNumber"].Value != null)
                                user.Phone = directoryEntry.Properties["TelephoneNumber"].Value.ToString();

                            if (directoryEntry.Properties["mobile"].Value != null)
                                user.Mobile = directoryEntry.Properties["mobile"].Value.ToString();

                            if (directoryEntry.Properties["department"].Value != null)
                                user.Department = directoryEntry.Properties["department"].Value.ToString();

                            if (directoryEntry.Properties["title"].Value != null)
                                user.JobTitle = directoryEntry.Properties["title"].Value.ToString();

                            //var xxx = Membership.ApplicationName;

                            //Membership.

                            if (Membership.GetUser(user.UserId) != null)
                            {
                                var roles = Roles.GetRolesForUser(user.UserId);
                                foreach (var r in roles)
                                {
                                    user.Roles += r + ", ";
                                }

                                if (user.Roles != null)
                                    user.Roles = user.Roles.Remove(user.Roles.Length - 2);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
             
            return View(user);
            //return RedirectToAction("Index?appId=1", user);
            //return Redirect("http://localhost/ARC.ControlPanel/Users/Index" + "?appId=" + 1);
        }

        private void IsExist()
        {
            try
            {
                if (Request.LogonUserIdentity?.User != null)
                {
                    string id = Request.LogonUserIdentity.Name.Trim();

                    if (Membership.GetUser(id) == null || !Roles.GetRolesForUser(id).Contains("Admins"))
                    {
                        Server.Transfer("~/Public/Unauthorized.aspx");
                        RedirectToAction("Index", "dfds");
                    }
                }
            }
            catch
            {
            }
        }

        private void GetUserInfo()
        {
            try
            {
                var adminUser = Membership.GetUser();

                if (adminUser != null || !Roles.GetRolesForUser(adminUser.UserName).Contains("Admins"))
                {
                    TipContext reportContext = new TipContext();

                    Account account = reportContext.Accounts.Single(x => x.UserName == adminUser.UserName);

                    ViewData["UserName"] = account.FirstName + " " + account.LastName;
                }
                else
                {
                    //Server.Transfer("~/Public/Unauthorized.aspx");
                    //return View("Emad");
                }
            }
            catch
            {
            }
        }

        //public ActionResult Seacrh(FormCollection form)
    }
}