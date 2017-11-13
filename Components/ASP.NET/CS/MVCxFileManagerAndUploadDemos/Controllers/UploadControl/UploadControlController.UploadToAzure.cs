using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class FileUploadToAzureDemoBinder : DevExpressEditorsBinder {
        public FileUploadToAzureDemoBinder() {
            UploadControlBinderSettings.ValidationSettings.Assign(UploadControlDemosHelper.UploadValidationSettings);
            UploadControlBinderSettings.UploadStorage = UploadControlUploadStorage.Azure;
            UploadControlBinderSettings.AzureSettings.Assign(UploadControlDemosHelper.CreateUploadControlAzureSettings());
            UploadControlBinderSettings.FileUploadCompleteHandler = UploadControlDemosHelper.ucAzureUploader_FileUploadComplete;
        }
    }

    public partial class UploadControlController: DemoController {
        public ActionResult UploadToAzure() {
            AzureConnectionInfo connInfo = UploadControlDemosHelper.GetAzureConnectionInfo();
            return DemoView("UploadToAzure", connInfo);
        }
        public ActionResult AzureUpload([ModelBinder(typeof(FileUploadToAzureDemoBinder))]IEnumerable<UploadedFile> ucAzureUploader) {
            return null;
        }
    }
}
