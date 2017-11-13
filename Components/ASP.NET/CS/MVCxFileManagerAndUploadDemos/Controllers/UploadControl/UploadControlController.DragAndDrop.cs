using System.Collections.Generic;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class DragAndDropSupportDemoBinder : DevExpressEditorsBinder {
        public DragAndDropSupportDemoBinder() {
            UploadControlBinderSettings.ValidationSettings.Assign(UploadControlDemosHelper.UploadValidationSettings);
            UploadControlBinderSettings.FileUploadCompleteHandler = UploadControlDemosHelper.ucDragAndDrop_FileUploadComplete;
        }
    }

    public partial class UploadControlController: DemoController {
        const string UploadDirectory = "~/Content/UploadControl/UploadFolder/";

        public ActionResult DragAndDrop() {
            return DemoView("DragAndDrop");
        }
        public ActionResult DragAndDropImageUpload([ModelBinder(typeof(DragAndDropSupportDemoBinder))]IEnumerable<UploadedFile> ucDragAndDrop) {
            return null;
        }
    }
}
