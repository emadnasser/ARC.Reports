using System;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class ResolveOverlappingLine : ChartBasePage {
    PointSeriesLabel Label { get { return (PointSeriesLabel)WebChartControl.Series[0].Label; } }
    
    public override WebChartControl FindWebChartControl() {
        return WebChartControl;
    }
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            spnIndent.MinValue = -10;
            spnIndent.MaxValue = 10;
            spnIndent.Value = Label.ResolveOverlappingMinIndent;
            string[] strings = {"None", "Default", "Hide Overlapped", "Justify Around Point", "Justify All Around Point"};
            ComboBoxHelper.PrepareComboBox(cbMode, strings);
            cbMode.SelectedIndex = (int)Label.ResolveOverlappingMode;
            spnLineLength.MaxValue = 30;
            spnLineLength.MinValue = 0;
            spnLineLength.Value = Label.LineLength;
            spnAngle.MaxValue = 360;
            spnAngle.MinValue = -360;
            spnAngle.Increment = 5;
            spnAngle.Value = Label.Angle;
        }
    }
    protected void WebChartControl_CustomCallback(object sender, CustomCallbackEventArgs e) {
        Label.ResolveOverlappingMinIndent = Convert.ToInt32(spnIndent.Number);
        Label.ResolveOverlappingMode = (ResolveOverlappingMode)cbMode.SelectedIndex;
        Label.LineLength = Convert.ToInt32(spnLineLength.Number);
        Label.Angle = Convert.ToInt32(spnAngle.Number);
    }
}

