using System;

namespace DevExpress.XtraCharts.Demos.Miscellaneous {
    public partial class LogarithmicScaleDemo : ChartDemoBase2D {
        bool Logarithmic {
            get {
                AxisBase axis = GetAxisY();
                return axis != null ? axis.Logarithmic : false;
            }
            set {
                AxisBase axis = GetAxisY();
                if(axis != null)
                    axis.Logarithmic = value;
            }
        }
        double LogarithmicBase {
            get {
                AxisBase axis = GetAxisY();
                return axis != null ? axis.LogarithmicBase : 10.0;
            }
            set {
                AxisBase axis = GetAxisY();
                if(axis != null)
                    axis.LogarithmicBase = value;
            }
        }
        
        public override ChartControl ChartControl { get { return chart; } }

        public LogarithmicScaleDemo() {
            InitializeComponent();
        }

        void chLogarithmic_CheckedChanged(object sender, EventArgs e) {
            Logarithmic = chLogarithmic.Checked;
            UpdateControls();
            ChartControl.Animate();
        }
        void cbLogarithmicBase_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbLogarithmicBase.SelectedIndex != -1)
                LogarithmicBase = Double.Parse(cbLogarithmicBase.Text);
        }
        AxisBase GetAxisY() {
            if(chart.Diagram is XYDiagram)
                return ((XYDiagram)chart.Diagram).AxisY;
            if(chart.Diagram is XYDiagram3D)
                return ((XYDiagram3D)chart.Diagram).AxisY;
            if(chart.Diagram is RadarDiagram)
                return ((RadarDiagram)chart.Diagram).AxisY;
            return null;
        }

        protected override void InitControls() {
            base.InitControls();
            chLogarithmic.Checked = Logarithmic;
            cbLogarithmicBase.Properties.Items.AddRange(new string[] { "2", "5", "10", "20", "50", "100" });
            cbLogarithmicBase.Text = LogarithmicBase.ToString();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            lblLogarithmicBase.Enabled = Logarithmic;
            cbLogarithmicBase.Enabled = Logarithmic;
        }      
    }
}
