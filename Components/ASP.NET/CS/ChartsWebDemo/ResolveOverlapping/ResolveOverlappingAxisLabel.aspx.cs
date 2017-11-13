using System;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class ResolveOverlappingAxisLabel : ChartBasePage {
    AxisLabel AxisLabel { get { return ((XYDiagram)WebChartControl.Diagram).AxisX.Label; } }
    bool ResolveOverlappingEnabled {
        get {
            if (AxisLabel != null)
                return AxisLabel.ResolveOverlappingOptions.AllowHide && AxisLabel.ResolveOverlappingOptions.AllowRotate && AxisLabel.ResolveOverlappingOptions.AllowStagger;
            return false;
        }
        set {
            AxisLabel.ResolveOverlappingOptions.AllowHide = value;
            AxisLabel.ResolveOverlappingOptions.AllowRotate = value; 
            AxisLabel.ResolveOverlappingOptions.AllowStagger = value;
        }
    }

    public override WebChartControl FindWebChartControl() {
        return WebChartControl;
    }
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            ASPxCheckBoxResolveOverlapping.Checked = ResolveOverlappingEnabled;
            ASPxSpinEditIndent.MinValue = -10;
            ASPxSpinEditIndent.MaxValue = 30;
            ASPxSpinEditIndent.Value = AxisLabel.ResolveOverlappingOptions.MinIndent;
        }
        lblIndent.ClientEnabled = ASPxCheckBoxResolveOverlapping.Checked;
        ASPxSpinEditIndent.ClientEnabled = ASPxCheckBoxResolveOverlapping.Checked;
    }
    protected void WebChartControl_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "custom") {
            if (ASPxCheckBoxResolveOverlapping.Checked)
                ResolveOverlappingEnabled = true;
            else
                ResolveOverlappingEnabled = false;
            AxisLabel.ResolveOverlappingOptions.MinIndent = Convert.ToInt32(ASPxSpinEditIndent.Number);
        }
    }
}

