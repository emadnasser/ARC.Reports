using DevExpress.Tutorials;

namespace DevExpress.ApplicationUI.Demos {
    public partial class About : ucOverviewPage {
        public About() {
            InitializeComponent();
        }
        protected override string Line1Text {
            get {
                return "DevExpress Application UI Layout Controls";
            }
        }
        protected override string Line2Text {
            get {
                return "Elegant and fully customizable UI layout tools for the WinForms platform.";
            }
        }
        protected override string Line3Text {
            get {
                return "DevExpress Desktop Controls";
            }
        }
        protected override string Line4Text {
            get {
                return votedVSM;
            }
        }
    }
}
