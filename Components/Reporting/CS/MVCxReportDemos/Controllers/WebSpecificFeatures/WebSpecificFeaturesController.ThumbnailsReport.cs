using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class WebSpecificFeaturesController: ReportDemoController {
        public ActionResult ThumbnailsReport() {
            var model = ReportDemoHelper.CreateModel("Thumbnails", Session, Request);
            model.CurrentViewer = ViewerSelectorState.ClassicViewer;
            return DemoView("ThumbnailsReport", "ThumbnailsViewer", model);
        }

        public ActionResult ThumbnailsViewerPartial(string reportID) {
            return PartialView("ThumbnailsViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }

        public FileResult ThumbnailsImageHandler(string img) {
            return File(Server.MapPath("~/App_Data/Thumbnails/" + img), "image/png");
        }
    }
}
