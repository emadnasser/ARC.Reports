using System;

namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
    public partial class RadarDemoBase : RadarPolarDemoBase {
        public RadarDemoBase() {
            InitializeComponent();
        }

        void comboBoxEditTextDirection_SelectedIndexChanged(object sender, EventArgs e) {
            RadarAxisXLabelTextDirection textDirection = (RadarAxisXLabelTextDirection)comboBoxEditTextDirection.EditValue;
            RadarDiagram diagram = ChartControl.Diagram as RadarDiagram;
            if (diagram != null)
                diagram.AxisX.Label.TextDirection = textDirection;
        }

        protected override void InitControls() {
            base.InitControls();
            Array directions = Enum.GetValues(typeof(RadarAxisXLabelTextDirection));
            foreach (RadarAxisXLabelTextDirection direction in directions)
                comboBoxEditTextDirection.Properties.Items.Add(direction);
            RadarDiagram diagram = ChartControl.Diagram as RadarDiagram;
            if (diagram != null)
                comboBoxEditTextDirection.EditValue = diagram.AxisX.Label.TextDirection;
        }
    }
}
