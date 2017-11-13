using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public static class CloudProviderHelper {
        const string AmazonLocalVersionMessage =
            "To run the demo locally, register your Amazon account using the AccountManager.RegisterAmazon() method in the global.asax file and set the SettingsAmazon.BucketName property to your bucket name value. " +
            "Or, you can see this demo online at " +
            "<a href=https://demos.devexpress.com/MVCxFileManagerAndUploadDemos/FileManager/AmazonProvider>https://demos.devexpress.com/MVCxFileManagerAndUploadDemos/FileManager/AmazonProvider</a>.";
        const string AzureLocalVersionMessage =
            "To run the demo locally, register your Azure account using the AccountManager.RegisterAzure() method in the global.asax file and set the SettingsAzure.ContainerName property to your container name value. " +
            "Or, you can see this demo online at " +
            "<a href=https://demos.devexpress.com/MVCxFileManagerAndUploadDemos/FileManager/AzureProvider>https://demos.devexpress.com/MVCxFileManagerAndUploadDemos/FileManager/AzureProvider</a>.";
        const string DropboxLocalVersionMessage =
            "To run the demo locally, register your Dropbox account using the AccountManager.RegisterDropbox() method in the global.asax file. " +
            "Or, you can see this demo online at " +
            "<a href=https://demos.devexpress.com/MVCxFileManagerAndUploadDemos/FileManager/DropboxProvider>https://demos.devexpress.com/MVCxFileManagerAndUploadDemos/FileManager/DropboxProvider</a>.";

        static bool IsAmazonAccessKeyIDDefined { get { return !string.IsNullOrEmpty(FileManagmentUtils.GetAmazonAccessKeyID()); } }
        static bool IsAmazonSecretAccessKeyDefined { get { return !string.IsNullOrEmpty(FileManagmentUtils.GetAmazonSecretAccessKey()); } }
        static bool IsAzureAccessKeyDefined { get { return !string.IsNullOrEmpty(FileManagmentUtils.GetAzureAccessKey()); } }
        static bool IsDropboxAccesTokenValueDefined { get { return !string.IsNullOrEmpty(FileManagmentUtils.GetDropboxAccessTokenValue()); } }

        public static string GetLocalVersionMessage(FileManagerProviderType type) {
            switch(type) {
                case FileManagerProviderType.Amazon:
                    return AmazonLocalVersionMessage;
                case FileManagerProviderType.Azure:
                    return AzureLocalVersionMessage;
                case FileManagerProviderType.Dropbox:
                    return DropboxLocalVersionMessage;
            }
            return string.Empty;
        }
        public static bool SettingsExists(FileManagerProviderType type) {
            switch(type) {
                case FileManagerProviderType.Amazon:
                    return IsAmazonAccessKeyIDDefined && IsAmazonSecretAccessKeyDefined;
                case FileManagerProviderType.Azure:
                    return IsAzureAccessKeyDefined;
                case FileManagerProviderType.Dropbox:
                    return IsDropboxAccesTokenValueDefined;
            }
            return false;
        }
        public static CloudFileSystemProviderBase CreateCloudProvider(FileManagerProviderType type) {
            switch(type) {
                case FileManagerProviderType.Amazon:
                    return CreateAmazonProvider();
                case FileManagerProviderType.Azure:
                    return CreateAzureProvider();
                case FileManagerProviderType.Dropbox:
                    return CreateDropboxProvider();
            }
            return null;
        }
        static DropboxFileSystemProvider CreateDropboxProvider() {
            var provider = new DropboxFileSystemProvider("/");
            provider.AccountName = "FileManagerDropboxAccount";
            provider.RequestEvent += (e) => {
                CloudProviderRequestMonitor.TraceEvent("FileManager", e, FileManagerProviderType.Dropbox);
            };
            return provider;
        }
        static AzureFileSystemProvider CreateAzureProvider() {
            var provider = new AzureFileSystemProvider("/");
            provider.AccountName = "FileManagerAzureAccount";
            provider.ContainerName = "filemanagerdemo";
            provider.RequestEvent += (e) => {
                CloudProviderRequestMonitor.TraceEvent("FileManager", e, FileManagerProviderType.Azure);
            };
            return provider;
        }
        static AmazonFileSystemProvider CreateAmazonProvider() {
            var provider = new AmazonFileSystemProvider("/");
            provider.AccountName = "FileManagerAmazonAccount";
            provider.BucketName = "dxdemobucket";
            provider.Region = "us-east-1";
            provider.RequestEvent += (e) => {
                CloudProviderRequestMonitor.TraceEvent("FileManager", e, FileManagerProviderType.Amazon);
            };
            return provider;
        }
    }
}
