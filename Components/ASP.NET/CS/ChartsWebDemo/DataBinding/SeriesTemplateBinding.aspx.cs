using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class SeriesTemplateBinding : ChartBasePage {
    const string YearDataMember = "Year";
    const string RegionDataMember = "Country";
    
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = WebChartControl1.SeriesTemplate.LabelsVisibility == DefaultBoolean.True;
            WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
            ComboBoxHelper.PrepareComboBox(cbSeriesDataMember, new string[] { YearDataMember, RegionDataMember }, WebChartControl1.SeriesDataMember);
        }
    }
    void PerformShowLabelsAction() {
        WebChartControl1.SeriesTemplate.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void PerformSeriesDataMemberAction() {
        string seriesDataMember;
        string argumentDataMember;
        if(cbSeriesDataMember.SelectedItem.Text == YearDataMember) {
            seriesDataMember = YearDataMember;
            argumentDataMember = RegionDataMember;
            ((XYDiagram)WebChartControl1.Diagram).AxisX.Label.Staggered = true;
        }
        else {
            seriesDataMember = RegionDataMember;
            argumentDataMember = YearDataMember;
            ((XYDiagram)WebChartControl1.Diagram).AxisX.Label.Staggered = false;
            ((XYDiagram)WebChartControl1.Diagram).AxisX.NumericScaleOptions.AutoGrid = false;
            ((XYDiagram)WebChartControl1.Diagram).AxisX.NumericScaleOptions.GridSpacing = 1;
        }
        WebChartControl1.SeriesDataMember = seriesDataMember;
        WebChartControl1.SeriesTemplate.ArgumentDataMember = argumentDataMember;
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if (e.Parameter == "SeriesDataMember")
            PerformSeriesDataMemberAction();
    }
}
