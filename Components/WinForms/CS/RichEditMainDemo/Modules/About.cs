using System;
using DevExpress.Tutorials;
using System.Drawing;
using DevExpress.Utils.About;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class About : ucOverviewPage {
		public About() {
			InitializeComponent();
		}

        protected override string Line1Text { get { return "The XtraRichEdit Suite"; } }
        protected override string Line2Text { get { return "Office® inspired WYSIWYG word processing for the WinForms platform."; } }
        protected override string Line3Text { get { return "DevExpress Desktop Controls"; } }
        protected override string Line4Text { get { return votedVSM; } }
	}
}

