using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Tutorials;


namespace DevExpress.XtraTreeList.Demos {
    public partial class About : ucOverviewPage {
        public About() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
        }
        protected override string Line1Text {
            get {
                return "The XtraTreeList Suite";
            }
        }
        protected override string Line2Text {
            get {
                return "A hybrid treeview-listview control for the WinForms platform.";
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

