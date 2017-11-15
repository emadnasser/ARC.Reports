using ARC.ControlPanel.Models;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARC.ControlPanel.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            User user = new User();

            try
            {
                using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, "alrajhi.bank", "0100589", "uVZd0456"))
                {
                    string txtId = Request["txtId"].ToString().Trim();
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
                    }
                }
            }
            catch
            {
            }

            return View(user);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
