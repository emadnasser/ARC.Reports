using System;

namespace DevExpress.Web.Demos {
    public class AzureConnectionInfo {
        public string AccountName { get; set; }
        public string ContainerName { get; set; }
    }

    public class AmazonConnectionInfo {
        public string AccountName { get; set; }
        public string BucketName { get; set; }
        public string Region { get; set; }
    }

    public class DropboxConnectionInfo {
        public string AccountName { get; set; }
    }
}
