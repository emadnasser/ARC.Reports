using System;
using DevExpress.Xpf.Core;
using ProductsDemo.Modules;

namespace ProductsDemo.Controls {
    public partial class EditTaskWindow : DXWindow {
        public EditTaskWindow() {
            InitializeComponent();
        }

        void DXRibbonWindow_Closed(object sender, EventArgs e) {
            ((EditTaskViewModel)DataContext).Close();;
        }
    }
}
