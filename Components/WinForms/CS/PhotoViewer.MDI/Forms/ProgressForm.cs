using System;
using System.Windows.Forms;

namespace PhotoViewer {
    public partial class ProgressForm : Form {
        public ProgressForm() {
            InitializeComponent();
        }
        public ProgressControl ProgressControl { 
            get { return progressControl1; } 
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            CenterToParent();
        }
    }
}
