using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ReportsV2.Web;

namespace FeatureCenter.Module.Web.Reports {
    public class ReportsWithInlinePreviewActionsController : WindowController {
        public const string ListViewId = "ReportsWithInlineExportActions_ListView";

        protected override void SubscribeToViewEvents(View view) {
            base.SubscribeToViewEvents(view);
            Frame.GetController<WebReportsController>().SetFormatSpecificExportActionsVisible(view.Id == ListViewId);
        }
    }
}
