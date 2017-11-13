using System;
using System.Drawing;
using System.Web.UI.WebControls;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class NestedDoughnutSeries : ChartBasePage {
    SeriesBase SeriesTemplate { get { return WebChartControl1.SeriesTemplate; }}
    NestedDoughnutSeriesView SeriesTemplateView { get { return ((NestedDoughnutSeriesView)SeriesTemplate.View); } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            ComboBoxHelper.PrepareNestedDoughnutHolePercentComboBox(cbHoleRadius);
            ComboBoxHelper.PrepareInnerIndentComboBox(cbInnerIndent);
            ComboBoxHelper.PrepareNestedDoughnutSeriesArgumentComboBox(cbSeriesArgument);
        }
    }
    void PerformSeriesArgumentAction() {
        bool showAgeSeriesArgument = cbSeriesArgument.SelectedIndex == 1;
        WebChartControl1.SeriesDataMember = showAgeSeriesArgument ? "CountryGenderKey" : "CountryAgeKey";
        string argumentDataMember = showAgeSeriesArgument ? "Age" : "Gender";
        WebChartControl1.Titles[0].Text = "Population: " + argumentDataMember + " Structure";
        SeriesTemplate.ToolTipHintDataMember = showAgeSeriesArgument ? "Gender" : "Age";
        SeriesTemplate.ArgumentDataMember = argumentDataMember;
    }
    void PerformHoleRadiusAction() {
        SeriesTemplateView.HoleRadiusPercent = ComboBoxHelper.GetSelectedNestedDoughnutHolePercent(cbHoleRadius);
    }
    void PerformInnerIndentAction() {
        SeriesTemplateView.InnerIndent = ComboBoxHelper.GetSelectedInnerIndent(cbInnerIndent);
    }
    protected void WebChartControl1_BoundDataChanged(object sender, EventArgs e) {
        WebChartControl chart = (WebChartControl)sender;
        if (chart.Series.Count > 0) {
            chart.Series[0].ShowInLegend = true;
            foreach (Series series in chart.Series) {
                NestedDoughnutSeriesView nestedView = series.View as NestedDoughnutSeriesView;
                AgePopulation population = series.Points[0].Tag as AgePopulation;
                if (population != null && nestedView != null) {
                    string name = population.Name;
                    nestedView.Group = name;
                    nestedView.Titles.Clear();
                    nestedView.Titles.Add(new SeriesTitle() { Text = name });
                }
            }
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "SeriesArgument")
            PerformSeriesArgumentAction();
        else if (e.Parameter == "HoleRadius")
            PerformHoleRadiusAction();
        else if (e.Parameter == "InnerIndent")
            PerformInnerIndentAction();
    }
}
