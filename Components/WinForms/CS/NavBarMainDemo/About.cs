using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Tutorials;

namespace DevExpress.XtraNavBar.Demos {
    public partial class About : ucOverviewPage {
        protected override string Line1Text { get { return "The XtraNavBar Suite"; } }
        //protected override string Line2Text { get { return "The most comprehensive collection of editors for the WinForms platform."; } }
        protected override string Line2Text { get { return string.Empty; } }
        protected override string Line3Text { get { return "DevExpress Desktop Controls"; } }
        protected override string Line4Text { get { return votedVSM; } }
    }
}
