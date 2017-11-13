using DevExpress.Tutorials;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class About : ucOverviewPage {
        public About() {
            InitializeComponent();
        }
        protected override string Line1Text { get { return "The XtraTreeMap Suite"; } }
        protected override string Line2Text { get { return "Take your users where they want to go."; } }
        protected override string Line3Text { get { return "DevExpress Desktop Controls"; } }
        protected override string Line4Text { get { return votedVSM; } }
    }
}
