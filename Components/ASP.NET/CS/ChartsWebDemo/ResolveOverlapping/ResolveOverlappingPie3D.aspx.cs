using System;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class ResolveOverlappingPie3D : ChartBasePage {
    SeriesLabelBase Label { get { return WebChartControl.Series[0].Label; } }

    public override WebChartControl FindWebChartControl() {
        return WebChartControl;
    }
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            ASPxCheckBoxResolveOverlapping.Checked = Label.ResolveOverlappingMode != ResolveOverlappingMode.None;
            ASPxSpinEditIndent.MinValue = -10;
            ASPxSpinEditIndent.MaxValue = 10;
            ASPxSpinEditIndent.Value = Label.ResolveOverlappingMinIndent;
        }
        lblIndent.ClientEnabled = ASPxCheckBoxResolveOverlapping.Checked;
        ASPxSpinEditIndent.ClientEnabled = ASPxCheckBoxResolveOverlapping.Checked;
    }
    protected void WebChartControl_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "custom") {
            if (ASPxCheckBoxResolveOverlapping.Checked)
                Label.ResolveOverlappingMode = ResolveOverlappingMode.Default;
            else
                Label.ResolveOverlappingMode = ResolveOverlappingMode.None;
            Label.ResolveOverlappingMinIndent = Convert.ToInt32(ASPxSpinEditIndent.Number);
        }
    }
}

