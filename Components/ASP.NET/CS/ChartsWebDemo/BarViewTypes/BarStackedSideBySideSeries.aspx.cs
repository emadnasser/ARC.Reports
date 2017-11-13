using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class BarStackedSideBySideSeries : ChartBasePage {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            checkBoxShowLabel.Checked = WebChartControl1.SeriesTemplate.LabelsVisibility == DefaultBoolean.True;
            rbSex.Checked = true;
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        WebChartControl1.SeriesTemplate.LabelsVisibility = checkBoxShowLabel.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = checkBoxShowLabel.Checked ? DefaultBoolean.False : DefaultBoolean.True;
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
