using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataBindingController: ReportDemoController {
        public ActionResult IListDataSourceReport() {
            var model = ReportDemoHelper.CreateModel("IListDataSource", Session, Request);
            return DemoView("IListDataSourceReport", "IListDataSource", model);
        }

        public ActionResult IListDataSourceViewerPartial(string reportID) {
            return PartialView("IListDataSourceViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
