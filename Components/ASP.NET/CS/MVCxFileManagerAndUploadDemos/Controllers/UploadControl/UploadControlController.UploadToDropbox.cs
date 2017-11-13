using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class FileUploadToDropboxDemoBinder : DevExpressEditorsBinder {
        public FileUploadToDropboxDemoBinder() {
            UploadControlBinderSettings.ValidationSettings.Assign(UploadControlDemosHelper.UploadValidationSettings);
            UploadControlBinderSettings.UploadStorage = UploadControlUploadStorage.Dropbox;
            UploadControlBinderSettings.DropboxSettings.Assign(UploadControlDemosHelper.CreateUploadControlDropboxSettings());
            UploadControlBinderSettings.FileUploadCompleteHandler = UploadControlDemosHelper.ucDropboxUploader_FileUploadComplete;
        }
    }

    public partial class UploadControlController: DemoController {
        public ActionResult UploadToDropbox() {
            DropboxConnectionInfo connInfo = UploadControlDemosHelper.GetDropboxConnectionInfo();
            return DemoView("UploadToDropbox", connInfo);
        }
        public ActionResult DropboxUpload([ModelBinder(typeof(FileUploadToDropboxDemoBinder))]IEnumerable<UploadedFile> ucDropboxUploader) {
            return null;
        }
    }
}
