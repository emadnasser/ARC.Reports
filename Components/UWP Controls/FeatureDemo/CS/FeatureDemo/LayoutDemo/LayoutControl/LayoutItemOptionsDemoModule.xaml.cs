using FeatureDemo.Common;
using Windows.UI.Xaml.Controls;

namespace LayoutDemo.LayoutControl {
    public sealed partial class LayoutItemOptionsDemoModule : DemoModuleView {
        public LayoutItemOptionsDemoModule() {
            this.InitializeComponent();
            edit.EditValue = System.DateTime.Now;
        }
    }
}
