using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;
using DevExpress.Xpf.Editors;
using System.Windows;

namespace ChartsDemo {
    [CodeFile("Modules/Interactivity/CrosshairCursorControl(.SL).xaml"),
     CodeFile("Modules/Interactivity/CrosshairCursorControl.xaml.(cs)")]
    public partial class CrosshairCursorControl : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public CrosshairCursorControl() {
            InitializeComponent();
            PrepareComboBox(cbSnapMode, "Nearest Argument", "Nearest Value");
        }
        void PrepareComboBox(ComboBoxEdit comboBox, params string[] items) {
            foreach (string item in items)
                comboBox.Items.Add(item);
            comboBox.SelectedIndex = 0;
        }

        void ChartsDemoModule_ModuleAppear(object sender, RoutedEventArgs e) {
            chart.Animate();
        }
    }
}
