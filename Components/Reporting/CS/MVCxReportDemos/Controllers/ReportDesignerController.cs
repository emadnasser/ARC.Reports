using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DevExpress.Web.Demos.Code.Designer;
using DevExpress.Web.Mvc;
using DevExpress.XtraReports.Native;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.ReportDesigner;

namespace DevExpress.Web.Demos.Controllers {
    public class ReportDesignerController : Controller {
        public ActionResult Index(string reportID, string redirectUrl) {
            if(string.Equals(Request.HttpMethod, "POST", StringComparison.OrdinalIgnoreCase)) {
                return RedirectToAction("Index", new { reportID = reportID, redirectUrl = redirectUrl });
            }
            if(string.IsNullOrEmpty(reportID) && string.IsNullOrEmpty(redirectUrl)) {
                return RedirectToAction("Index", new { reportID = "MasterDetail", redirectUrl = "ReportTypes/MasterDetailReport" });
            }
            var report = ReportStorageHelper.LoadReport(reportID, Session);
            if(report == null) {
                return Redirect(redirectUrl);
            }
            var model = new ReportDesignerDemoModel {
                ReportID = reportID,
                RedirectUrl = redirectUrl
            };
            return View(model);
        }
    }
}
