using System;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class MobileEmulatorModel {
        public MobileEmulatorModel(string reportName, HttpRequestBase request) {
            this.ReportName = reportName;
            this.CurrentRequest = request;
        }
        public string ReportName { get; set; }
        public bool IsLandscape {
            get {
                return ReportName == "CharacterComb" || ReportName == "PivotGridAndChart";
            }
        }
        public HttpRequestBase CurrentRequest { get; set; }
        public string Url {
            get {
                return string.Format("~/MobileViewer?reportName={0}", HttpUtility.UrlEncode(ReportName));
            }
        }
        public int QRCodeSize {
            get { return 124; }
        }
        public string QRCodeUrl {
            get {
                var absoluteUri = new Uri(CurrentRequest.Url, VirtualPathUtility.ToAbsolute(Url)).AbsoluteUri;
                return string.Format("http://chart.apis.google.com/chart?cht=qr&chs={0}x{1}&chl={2}&chld=H%7C0", QRCodeSize, QRCodeSize, absoluteUri);
            }
        }
    }
}
