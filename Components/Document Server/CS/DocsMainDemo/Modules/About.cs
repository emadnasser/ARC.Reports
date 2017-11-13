using System.Drawing;
using DevExpress.Tutorials;
using DevExpress.Utils.About;

namespace DevExpress.Docs.Demos {
    public partial class About : ucOverviewPage {
		public About() {
			InitializeComponent();
		}

        protected override string Line1Text { get { return ".NET Document Server"; } }
        protected override string Line2Text { get { return "Read and Write XLSx, XLS, DOCx, DOC and PDF files"; } }
        protected override string Line3Text { get { return "Create Snap Reports, Generate Barcodes and Compressed Archives"; } }
        protected override string Line4Text { get { return votedVSM; } }
	}
}

