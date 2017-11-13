using DevExpress.XtraEditors;

namespace DevExpress.ApplicationUI.Demos {
    public partial class ButtonPropertyGrid : XtraUserControl {
        public ButtonPropertyGrid() {
            InitializeComponent();
        }
        public object SelectObject {
            get { return xtraPropertyGrid1.PropertyGrid.SelectedObject; }
            set { xtraPropertyGrid1.PropertyGrid.SelectedObject = value; }
        }
        public void RefreshPropertyGrid() {
            xtraPropertyGrid1.PropertyGrid.Refresh();
        }
    }
}
