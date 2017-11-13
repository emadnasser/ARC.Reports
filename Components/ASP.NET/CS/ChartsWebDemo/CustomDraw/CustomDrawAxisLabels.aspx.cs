using System;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class CustomDrawAxisLabels : ChartBasePage {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = WebChartControl1.Series[0].LabelsVisibility == DefaultBoolean.True;
            cbCustomDraw.Checked = true;
        }
    }    
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "ShowLabels")
            foreach (Series series in WebChartControl1.Series) {
                series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
                WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
            }
    }
    protected void WebChartControl1_CustomDrawAxisLabel(object sender, CustomDrawAxisLabelEventArgs e) {
        if (cbCustomDraw.Checked) {
            AxisBase axis = e.Item.Axis;
            if (axis is AxisY) {
                double axisValue = (double)e.Item.AxisValue;
                if (axisValue < 0)
                    e.Item.TextColor = Color.Red;
                else if (axisValue > 0) {
                    e.Item.Text = "+" + e.Item.Text;
                    e.Item.TextColor = Color.Green;
                }
                e.Item.Font = new Font(e.Item.Font.FontFamily, e.Item.Font.Size + (float)Math.Abs(axisValue) / 4.0f);
                e.Item.EnableAntialiasing = DefaultBoolean.True;
            }
        }
    }
}
