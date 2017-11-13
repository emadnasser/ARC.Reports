using System.Drawing;
using DevExpress.Tutorials;
using DevExpress.Utils.About;

namespace DevExpress.XtraMap.Demos {
    public partial class About : ucOverviewPage {
        public About() {
            InitializeComponent();
        }
        protected override string Line1Text { get { return "The XtraMap Suite"; } }
        protected override string Line2Text { get { return "Take your users where they want to go."; } }
        protected override string Line3Text { get { return "DevExpress Desktop Controls"; } }
        protected override string Line4Text { get { return votedVSM; } }
    }
}

