using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Tutorials;
using System.Drawing;

namespace SnapDemos.Modules {
    public partial class About : ucOverviewPage {
    
        public About() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
        }

        protected override string Line1Text { get { return "Snap Reports Suite"; } }
        protected override string Line2Text { get { return "Word® inspired WYSIWYG reporting for the WinForms platform."; } }
        protected override string Line3Text { get { return "DevExpress Desktop Controls"; } }
        protected override string Line4Text { get { return votedVSM; } }

        protected override DevExpress.Utils.About.ProductKind ProductKind {
            get {
                return DevExpress.Utils.About.ProductKind.Snap;
            }
        }
    }
}
