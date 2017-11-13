using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.XtraCharts;

public partial class Bar3DFullStackedSideBySideSeries : ChartBasePage {
    Diagram3D Diagram { get { return (Diagram3D)WebChartControl1.Diagram; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            SeriesBase series = WebChartControl1.SeriesTemplate;
            cbShowLabels.Checked = series.LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
            if (series != null && series.Label != null && !string.IsNullOrEmpty(series.Label.TextPattern))
                cbValueAsPercent.Checked = series.Label.TextPattern.Contains("VP");
            ComboBoxHelper.PreparePerspectiveAngleComboBox(cbPerspectiveAngle);
            ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent);
            rbSex.Checked = true;
        }

        cbValueAsPercent.ClientEnabled = cbShowLabels.Checked;
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if (e.Parameter == "ValueAsPercent")
            PerformValueAsPercentAction();
        else if (e.Parameter == "PerspectiveAngle")
            PerformPerspectiveAngleAction();
        else if (e.Parameter == "ZoomPercent")
            PerformZoomPercentAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
    }
    void PerformValueAsPercentAction() {
        string labeltextPattern = cbValueAsPercent.Checked ? "{VP:P0}" : "{V:0,,.00}";
        WebChartControl1.SeriesTemplate.Label.TextPattern = labeltextPattern;
    }
    void PerformPerspectiveAngleAction() {
        Diagram.PerspectiveAngle = ComboBoxHelper.GetSelectedPerspectiveAngle(cbPerspectiveAngle);
    }
    void PerformShowLabelsAction() {
        WebChartControl1.SeriesTemplate.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
    void PerformZoomPercentAction() {
        Diagram.ZoomPercent = Convert.ToInt32(cbZoomPercent.SelectedItem.Text);
    }
    protected void WebChartControl1_BoundDataChanged(object sender, EventArgs e) {
        foreach (Series series in WebChartControl1.Series) {
            ISupportStackedGroup view = series.View as ISupportStackedGroup;
            GenderAgeInfo genderAge = (GenderAgeInfo)series.Tag;
            if (view != null)
                view.StackedGroup = rbSex.Checked ? genderAge.Gender : genderAge.Age;
        }
    }
}
