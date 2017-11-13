using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController : DemoController {
        public ActionResult AmazonProvider() {
            CloudProviderRequestMonitor.ClearLog(FileManagerProviderType.Amazon);
            return DemoView("AmazonProvider");
        }
        public ActionResult AzureProvider() {
            CloudProviderRequestMonitor.ClearLog(FileManagerProviderType.Azure);
            return DemoView("AzureProvider");
        }
        public ActionResult DropboxProvider() {
            CloudProviderRequestMonitor.ClearLog(FileManagerProviderType.Dropbox);
            return DemoView("DropboxProvider");
        }

        public ActionResult CloudProviderPartial(FileManagerProviderType type) {
            if(!CloudProviderHelper.SettingsExists(type))
                return Content(CloudProviderHelper.GetLocalVersionMessage(type));
            return PartialView("CloudProviderPartial", type);
        }
        public RedirectResult CloudProviderDownload(FileManagerProviderType type) {
            var settings = new DevExpress.Web.Mvc.FileManagerSettings() { Name = "fileManager" };
            settings.SettingsEditing.AllowDownload = true;
            var url = FileManagerExtension.GetCloudDownloadUrl(settings, CloudProviderHelper.CreateCloudProvider(type));
            return new RedirectResult(url);
        }
        public ActionResult CloudProviderLog(FileManagerProviderType type) {
            if(!CloudProviderHelper.SettingsExists(type))
                return Content(string.Empty);
            return Content(CloudProviderRequestMonitor.GetLogHtml(type));
        }
        public ActionResult CloudProviderLogPartial(FileManagerProviderType type) {
            return Content(CloudProviderRequestMonitor.GetLogPartialHtml(type));
        }
    }
}
