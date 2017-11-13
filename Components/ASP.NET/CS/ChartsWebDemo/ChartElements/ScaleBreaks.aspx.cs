using System;
using System.Drawing;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;
using DevExpress.Utils;
using DevExpress.XtraCharts.Web;

public partial class ScaleBreaks : ChartBasePage {
    Axis AxisY { get { return ((XYDiagram)WebChartControl1.Diagram).AxisY; } }
    ScaleBreakCollection Breaks { get { return AxisY.ScaleBreaks; } }
    ScaleBreakOptions Options { get { return AxisY.ScaleBreakOptions; } }
    SeriesLabelBase Label { get { return WebChartControl1.Series[0].Label; } }
    AutoScaleBreaks AutoScaleBreaks { get { return AxisY.AutoScaleBreaks; } }
    Series Series { get { return WebChartControl1.Series[0]; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            chbShowLabels.Checked = Series.LabelsVisibility == DefaultBoolean.True;
            chbShowScaleBreaks.Checked = AutoScaleBreaks.Enabled;
            ComboBoxHelper.PrepareComboBox(cbStyle, Options.Style);
            spnSize.Value = Options.SizeInPixels;
            spnMaxCount.Value = AutoScaleBreaks.MaxCount;
            ceColor.Color = Options.Color;
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if(e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if(e.Parameter == "ShowScaleBreaks")
            PerformShowScaleBreaksAction();
        else if(e.Parameter == "ChangeStyle")
            PerformChangeStyleAction();
        else if(e.Parameter == "ChangeSize")
            PerformChangeSizeAction();
        else if(e.Parameter == "ChangeColor")
            PerformChangeColorAction();
        else if(e.Parameter == "ResetColor")
            PerformResetColorAction();
        else if(e.Parameter == "ChangeMaxCount")
            PerformChangeMaxCountAction();
    }
    void PerformShowLabelsAction() {
        Series.LabelsVisibility = chbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = chbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void PerformShowScaleBreaksAction() {
        AutoScaleBreaks.Enabled = chbShowScaleBreaks.Checked;
    }
    void PerformChangeStyleAction() {
        Options.Style = (ScaleBreakStyle)ComboBoxHelper.GetSelectedItem(cbStyle, typeof(ScaleBreakStyle));
    }
    void PerformChangeSizeAction() {
        Options.SizeInPixels = Convert.ToInt32(spnSize.Value);
    }
    void PerformChangeColorAction() {
        Options.Color = ceColor.Color;
    }
    void PerformResetColorAction() {
        Options.Color = Color.Empty;
    }
    void PerformChangeMaxCountAction() {
        AutoScaleBreaks.MaxCount = Convert.ToInt32(spnMaxCount.Value);
    }
}
