using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARC.ControlPanel.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        //[HttpPost]
        public ActionResult Index(string txtAmount)
        {
            using (PrincipalContext ctx = new PrincipalContext(ContextType.Domain, "alrajhi.bank", "0100589", "uVZd0456"))
            {
                string strName = "";
                if (Request["txtAmount"] != null )
                    strName = Request["txtAmount"].ToString();

                //string strName2 = form["txtId"].ToString();
                //string strName3 = Convert.ToString(txtId);

                UserPrincipal user = UserPrincipal.FindByIdentity(ctx, "0100589");

                if (user != null)
                {
                    // do something here....
                }


                // or alternatively: get the currently logged in user
                //UserPrincipal current = UserPrincipal.Current;


                //return user.Surname;
                return View();

            }

            //EmployeeContext employeeContext = new EmployeeContext();
            //Employee employee = employeeContext.Employees.Single(x => x.EmployeeId == id);

            //return View(employee);

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
