using DevExpress.XtraEditors;

namespace PhotoViewer {
    public partial class ProgressControl : XtraUserControl {
        public ProgressControl() {
            InitializeComponent();
        }
        public int Maximum {
            get { return progressBar.Properties.Maximum; }
            set { progressBar.Properties.Maximum = value; }
        }
        public int Value {
            get { return (int)progressBar.EditValue; }
            set { progressBar.EditValue = value; }
        }
        public string ProgressText {
            get { return label.Text; }
            set { label.Text = value; }
        }
    }
}
