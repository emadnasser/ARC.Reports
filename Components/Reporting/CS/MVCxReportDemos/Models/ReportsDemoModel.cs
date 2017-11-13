using DevExpress.XtraReports.UI;

namespace DevExpress.Web.Demos {
    public class ReportsDemoModel {
        public string ReportID { get; set; }
        public XtraReport Report { get; set; }
        public MobileEmulatorModel EmulatorModel { get; set; }
        public string CurrentViewer { get; set; }
        public bool IsASPViewer {
            get {
                return CurrentViewer == ViewerSelectorState.ClassicViewer;
            }
        }

        public bool IsHTML5Viewer {
            get {
                return CurrentViewer == null;
            }
        }

        public bool IsMobileViewer {
            get {
                return CurrentViewer == ViewerSelectorState.MobileViewer;

            }
        }
    }
}
