using System;
using System.Windows.Forms;

namespace DevExpress.ApplicationUI.Demos {
    public partial class Calendar : UserControl {
        public Calendar() {
            InitializeComponent();
            dateNavigator1.DateTime = DateTime.Now;
            dateNavigator1.CalendarIndent = 10;
        }
        protected override void OnResize(System.EventArgs e) {
            base.OnResize(e);
            dateNavigator1.CalcBestSize();
        }
    }
}
