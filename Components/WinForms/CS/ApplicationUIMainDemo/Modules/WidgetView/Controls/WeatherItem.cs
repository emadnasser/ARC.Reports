using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.ApplicationUI.Demos {
    public partial class WeatherItem : UserControl {
        public WeatherItem() {
            InitializeComponent();
        }
        public string Sity {
            get { return labelControl1.Text; }
            set { labelControl1.Text = value; }
        }
        public string Temperature {
            get { return labelControl2.Text; }
            set { labelControl2.Text = value; }
        }
        public string SkyConditions {
            get { return labelControl3.Text; }
            set { labelControl3.Text = value; }
        }
        public string RelativeHumidity {
            get { return labelControl4.Text; }
            set { labelControl4.Text = value; }
        }
        public Image Image {
            get { return windowsUIButtonPanel1.Buttons[0].Properties.Image; }
            set { windowsUIButtonPanel1.Buttons[0].Properties.Image = value; }
        }
    }
}
