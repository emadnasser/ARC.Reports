using System;
using DevExpress.XtraCharts;
using DevExpress.Utils;
using DevExpress.XtraCharts.Web;

public partial class LogarithmicScale : ChartBasePage {
    AxisY AxisY { get { return ((XYDiagram)WebChartControl1.Diagram).AxisY; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = WebChartControl1.Series[0].LabelsVisibility == DefaultBoolean.True;
            cbLogarithmic.Checked = AxisY.Logarithmic;
            cbLogarithmicBase.Enabled = AxisY.Logarithmic;
            ComboBoxHelper.PrepareLogarithmicBaseComboBox(cbLogarithmicBase, AxisY.LogarithmicBase);
        }
        lblLogarithmicBase.ClientEnabled = cbLogarithmic.Checked;
        cbLogarithmicBase.ClientEnabled = cbLogarithmic.Checked;
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        AxisY.Logarithmic = cbLogarithmic.Checked;
        AxisY.LogarithmicBase = Double.Parse(cbLogarithmicBase.SelectedItem.Text);
        foreach(Series series in WebChartControl1.Series)
            series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
}
