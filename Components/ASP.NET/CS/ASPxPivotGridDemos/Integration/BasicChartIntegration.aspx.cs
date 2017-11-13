using System;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraCharts;

public partial class ChartsIntegration_GeneralOptions : Page {
    void SetFilter(PivotGridField field, int selectNumber) {
        object[] values = field.GetUniqueValues();
        List<object> includedValues = new List<object>(values.Length / selectNumber);
        for (int i = 0; i < values.Length; i++)
            if (i % selectNumber == 0)
                includedValues.Add(values[i]);
        field.FilterValues.ValuesIncluded = includedValues.ToArray();
    }
    void SetChartType(string text) {
        WebChart.SeriesTemplate.ChangeView((ViewType)Enum.Parse(typeof(ViewType), text));
        if (WebChart.SeriesTemplate.Label != null) {
            PointLabels.Enabled = true;
            WebChart.SeriesTemplate.LabelsVisibility = PointLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        }
        else
            PointLabels.Enabled = false;
    }
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            ViewType[] restrictedTypes = new ViewType[] { ViewType.PolarArea, ViewType.PolarLine, ViewType.ScatterPolarLine, ViewType.SideBySideGantt,
				ViewType.SideBySideRangeBar, ViewType.RangeBar, ViewType.Gantt, ViewType.PolarPoint, ViewType.Stock, ViewType.CandleStick,
				ViewType.Bubble };
            foreach(ViewType type in Enum.GetValues(typeof(ViewType))) {
                if(Array.IndexOf<ViewType>(restrictedTypes, type) >= 0) continue;
                ChartType.Items.Add(type.ToString());
            }
            ChartType.SelectedItem = ChartType.Items.FindByText(ViewType.Line.ToString());
            SetChartType(ChartType.SelectedItem.Text);
            PointLabels.Checked = WebChart.SeriesTemplate.LabelsVisibility == DevExpress.Utils.DefaultBoolean.True;
            ASPxPivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = ShowColumnGrandTotals.Checked;
            ASPxPivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = ShowRowGrandTotals.Checked;
            ASPxPivotGrid.OptionsChartDataSource.ProvideDataByColumns = ChartDataVertical.Checked;
        }
    }
    protected void ASPxPivotGrid_PreRender(object sender, EventArgs e) {
        if(!IsPostBack) {
            SetFilter(fieldCategoryName, 4);
            fieldOrderYear.FilterValues.SetValues(new object[] { 1996 }, DevExpress.XtraPivotGrid.PivotFilterType.Included, false);
        }
    }
    protected void PointLabels_CheckedChanged(object sender, EventArgs e) {
        WebChart.SeriesTemplate.LabelsVisibility = PointLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
    protected void ChartType_ValueChanged(object sender, EventArgs e) {
        SetChartType(ChartType.SelectedItem.Text);
    }
    protected void ShowColumnGrandTotals_CheckedChanged(object sender, EventArgs e) {
        ASPxPivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = ShowColumnGrandTotals.Checked;
    }
    protected void ShowRowGrandTotals_CheckedChanged(object sender, EventArgs e) {
        ASPxPivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = ShowRowGrandTotals.Checked;
    }
    protected void ChartDataVertical_CheckedChanged(object sender, EventArgs e) {
        ASPxPivotGrid.OptionsChartDataSource.ProvideDataByColumns = ChartDataVertical.Checked;
    }
}
