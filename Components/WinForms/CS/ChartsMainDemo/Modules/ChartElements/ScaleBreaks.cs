using System;
using System.Drawing;

namespace DevExpress.XtraCharts.Demos.ChartElements {
    public partial class ScaleBreaksDemo : ChartDemoBase2D {
        Axis Axis { 
            get {
                XYDiagram diagram = chart.Diagram as XYDiagram;
                return diagram != null ? diagram.AxisY : null;
            } 
        }        
        AutoScaleBreaks AutoScaleBreaks { get { return Axis != null ? Axis.AutoScaleBreaks : null; } }
        ScaleBreakOptions Options { get { return Axis != null ? Axis.ScaleBreakOptions : null; } }

        public override ChartControl ChartControl { get { return chart; } }

        public ScaleBreaksDemo() {
            InitializeComponent();
        }

        void UpdateControlsState() {
            if(Options == null || AutoScaleBreaks == null)
                return;
            lblMaxCount.Enabled = AutoScaleBreaks.Enabled;
            spnMaxCount.Enabled = AutoScaleBreaks.Enabled;
            cbStyle.Enabled = AutoScaleBreaks.Enabled;
            spnSize.Enabled = AutoScaleBreaks.Enabled;
            ceColor.Enabled = AutoScaleBreaks.Enabled;
            lblStyle.Enabled = AutoScaleBreaks.Enabled;
            lblSize.Enabled = AutoScaleBreaks.Enabled;
            lblColor.Enabled = AutoScaleBreaks.Enabled;
            btnResetColor.Enabled = AutoScaleBreaks.Enabled && Options.Color != Color.Empty;
        }
        void chEnableScaleBreaks_CheckedChanged(object sender, EventArgs e) {
            if(AutoScaleBreaks != null)
                AutoScaleBreaks.Enabled = chEnableScaleBreaks.Checked;
            UpdateControlsState();
        }
        void cbStyle_SelectedIndexChanged(object sender, EventArgs e) {
            if(Options != null)
                Options.Style = (ScaleBreakStyle)cbStyle.SelectedIndex;
        }
        void spnSize_EditValueChanged(object sender, EventArgs e) {
            if(Options != null)
                Options.SizeInPixels = Convert.ToInt32(spnSize.EditValue);
        }
        void ceColor_EditValueChanged(object sender, EventArgs e) {
            if(Options != null)
                Options.Color = (Color)ceColor.EditValue;
            UpdateControlsState();
        }
        void btnResetColor_Click(object sender, EventArgs e) {
            if(Options != null) {
                Options.Color = Color.Empty;
                ceColor.EditValue = Options.Color;
            }
        }
        void spnMaxCount_EditValueChanged(object sender, EventArgs e) {
            if(AutoScaleBreaks != null)
                AutoScaleBreaks.MaxCount = Convert.ToInt32(spnMaxCount.EditValue);
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (AutoScaleBreaks != null) {
                chEnableScaleBreaks.Checked = AutoScaleBreaks.Enabled;
                spnMaxCount.EditValue = AutoScaleBreaks.MaxCount;
            }
            if (Options != null) {
                cbStyle.SelectedIndex = (int)Options.Style;
                spnSize.EditValue = Options.SizeInPixels;
                ceColor.EditValue = Options.Color;
            }
            UpdateControlsState();
        }
    }
}

