using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class FileUploadToAmazonDemoBinder : DevExpressEditorsBinder {
        public FileUploadToAmazonDemoBinder() {
            UploadControlBinderSettings.ValidationSettings.Assign(UploadControlDemosHelper.UploadValidationSettings);
            UploadControlBinderSettings.UploadStorage = UploadControlUploadStorage.Amazon;
            UploadControlBinderSettings.AmazonSettings.Assign(UploadControlDemosHelper.CreateUploadControlAmazonSettings());
            UploadControlBinderSettings.FileUploadCompleteHandler = UploadControlDemosHelper.ucAmazonUploader_FileUploadComplete;
        }
    }

    public partial class UploadControlController: DemoController {
        public ActionResult UploadToAmazon() {
            AmazonConnectionInfo connInfo = UploadControlDemosHelper.GetAmazonConnectionInfo();
            return DemoView("UploadToAmazon", connInfo);
        }
        public ActionResult AmazonUpload([ModelBinder(typeof(FileUploadToAmazonDemoBinder))]IEnumerable<UploadedFile> ucAmazonUploader) {
            return null;
        }
    }
}
