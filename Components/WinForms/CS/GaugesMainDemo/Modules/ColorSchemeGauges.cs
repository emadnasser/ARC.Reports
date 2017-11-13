using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Win;

namespace DevExpress.XtraGauges.Demos {
    public partial class ColorSchemeGauges : TutorialControl {
        public ColorSchemeGauges() {
            InitializeComponent();
            gaugesDashboard1.ColorPicker = colorPickControl;
        }
        void ColorPickControlResultColorChanged(object sender, XtraEditors.InnerColorPickControlSelectedColorChangedEventArgs e) {
            var activeGauge = GetActiveGauge();
            if(activeGauge != null) {
                activeGauge.ColorScheme.Color = e.NewColor;
                gaugesDashboard1.UpdateColor(e.NewColor);
            }
        }
        GaugeControl GetActiveGauge() {
            if(ActiveControl is GaugesDashboard) {
                return (ActiveControl as GaugesDashboard).ActiveGauge;
            }
            return null;
        }
    }
}
