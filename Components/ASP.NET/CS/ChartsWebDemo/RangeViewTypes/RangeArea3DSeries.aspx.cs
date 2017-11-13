using System;
using DevExpress.XtraCharts;

public partial class RangeArea3DSeries : ChartBasePage {
    Diagram3D Diagram { get { return (Diagram3D)WebChartControl1.Diagram; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = WebChartControl1.Series[0].LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
            ComboBoxHelper.PreparePerspectiveAngleComboBox(cbPerspectiveAngle);
            ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent);
            ComboBoxHelper.PrepareComboBox(cbLabelKind, new string[] { "One Label", "Two Labels", "Min Value Label", "Max Value Label" }, "Two Labels");
        }
        lblLabelKind.ClientEnabled = cbShowLabels.Checked;
        cbLabelKind.ClientEnabled = cbShowLabels.Checked;
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if(e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if(e.Parameter == "PerspectiveAngle")
            PerformPerspectiveAngleAction();
        else if(e.Parameter == "ZoomPercent")
            PerformZoomPercentAction();
        else if (e.Parameter == "LabelKind")
            PerformLabelKindAction();
    }
    void PerformShowLabelsAction() {
        foreach(Series series in WebChartControl1.Series)
            series.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
    void PerformPerspectiveAngleAction() {
        Diagram.PerspectiveAngle = ComboBoxHelper.GetSelectedPerspectiveAngle(cbPerspectiveAngle);
    }
    void PerformZoomPercentAction() {
        Diagram.ZoomPercent = Convert.ToInt32(cbZoomPercent.SelectedItem.Text);
    }
    void PerformLabelKindAction() {
        RangeAreaLabelKind kind;
        switch ((string)cbLabelKind.Value) {
            case "One Label":
                kind = RangeAreaLabelKind.OneLabel;
                break;
            case "Two Labels":
                kind = RangeAreaLabelKind.TwoLabels;
                break;
            case "Min Value Label":
                kind = RangeAreaLabelKind.MinValueLabel;
                break;
            case "Max Value Label":
                kind = RangeAreaLabelKind.MaxValueLabel;
                break;
            default:
                kind = RangeAreaLabelKind.OneLabel;
                break;
        }
        foreach (Series series in WebChartControl1.Series) {
            RangeArea3DSeriesLabel label = (RangeArea3DSeriesLabel)series.Label;
            label.Kind = kind;
            if (label.Kind == RangeAreaLabelKind.OneLabel)
                series.Label.TextPattern = "{VD:F2}";
            else
                series.Label.TextPattern = "{V:F2}";
        }
    }
}
