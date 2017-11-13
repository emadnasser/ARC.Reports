using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public class MultiFileSelectionDemoBinder : DevExpressEditorsBinder {
        public MultiFileSelectionDemoBinder() {
            UploadControlBinderSettings.ValidationSettings.Assign(UploadControlDemosHelper.UploadValidationSettings);
            UploadControlBinderSettings.FileUploadCompleteHandler = UploadControlDemosHelper.ucMultiSelection_FileUploadComplete;
        }
    }

    public partial class UploadControlController : DemoController {
        public ActionResult MultiFileSelection() {
            return DemoView("MultiFileSelection");
        }
        public ActionResult MultiSelectionImageUpload([ModelBinder(typeof(MultiFileSelectionDemoBinder))]IEnumerable<UploadedFile> ucMultiSelection) {
            return null;
        }
    }
}
