using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;
using DevExpress.Web;
using DevExpress.XtraCharts.Web;

public partial class DateTimeMeasureUnits : ChartBasePage {
    const string orderDateColumn = "OrderDate";
    const string freightColumn = "Freight";
    const string selectQuery = "SELECT OrderDate, Freight FROM Orders";
    const string chartTitle = "Sales Volume by ";
    const DateTimeMeasureUnit minMeasureUnit = DateTimeMeasureUnit.Week;

    Series Series { get { return WebChartControl1.Series[0]; } }
    DateTimeScaleOptions Options { get { return ((XYDiagram)WebChartControl1.Diagram).AxisX.DateTimeScaleOptions; } }
    bool IsAutoGrid { get { return chbAutoGrid.Checked; } }
    bool IsAutoScale { get { return scaleMode.Equals(ScaleMode.Automatic); } }
    bool IsManualScale { get { return scaleMode.Equals(ScaleMode.Manual); } }
    bool IsContinuousScale { get { return scaleMode.Equals(ScaleMode.Continuous); } }
    bool AllowGridAlignment { get { return !IsAutoScale && !IsAutoGrid; } }
    ScaleMode scaleMode;

    protected void Page_Load(object sender, EventArgs e) {
        scaleMode = GetScaleMode();
        if (!IsPostBack) {
            FillDefaultGridAlignmentCombo();
            UpdateScaleOptions();
            UpdateClientControls();
        }
        Series.ArgumentDataMember = orderDateColumn;
        Series.ValueDataMembers.AddRange(freightColumn);
        Series.DataSource = GetDataTable();
        if (!IsPostBack) {
            UpdateMeasureUnitSelectedIndex(Options.MeasureUnit);
            UpdateGridAlignmentSelectedIndex(Options.GridAlignment, minMeasureUnit);
            
        }
    }
    protected void callbackPanel_Callback(object source, CallbackEventArgsBase e) {
        bool measureUnitChanged = e.Parameter == "SelectMeasureUnits" || e.Parameter == "SelectScaleMode";
        if (measureUnitChanged)
            chbAutoGrid.Checked = true;
        UpdateScaleOptions();
        UpdateClientControls();
        PerformSelectMeasureUnits();
        PerformSelectGridAlignment();
        PerformSelectAggregateFuntion();
        if (IsContinuousScale)
            FillDefaultGridAlignmentCombo();
        else
            FillGridAlignmentCombo(Options.MeasureUnit);
        if (measureUnitChanged || e.Parameter == "SetAutoGrid")
            UpdateGridAlignmentSelectedIndex(Options.GridAlignment, Options.MeasureUnit);
        if (!IsContinuousScale && e.Parameter == "SelectScaleMode")
            UpdateMeasureUnitSelectedIndex(Options.MeasureUnit);
    }
    void UpdateGridAlignmentSelectedIndex(DateTimeGridAlignment gridAlignment, DateTimeMeasureUnit measureUnit) {
        cbGridAlignment.SelectedIndex = (int)gridAlignment - (int)measureUnit;
    }
    void UpdateMeasureUnitSelectedIndex(DateTimeMeasureUnit measureUnit) {
        cbMeasureUnits.SelectedIndex = (int)measureUnit - (int)minMeasureUnit;
    }
    protected void FillGridAlignmentCombo(DateTimeMeasureUnit measureUnit) {
        cbGridAlignment.Items.Clear();
        switch (measureUnit) {
            case DateTimeMeasureUnit.Week:
                cbGridAlignment.Items.AddRange(new ListEditItem[] { GetWeekItem(), GetMonthItem(), GetQuarterItem(), GetYearItem() });
                break;
            case DateTimeMeasureUnit.Month:
                cbGridAlignment.Items.AddRange(new ListEditItem[] { GetMonthItem(), GetQuarterItem(), GetYearItem() });
                break;
            case DateTimeMeasureUnit.Quarter:
                cbGridAlignment.Items.AddRange(new ListEditItem[] { GetQuarterItem(), GetYearItem() });
                break;
            case DateTimeMeasureUnit.Year:
                cbGridAlignment.Items.Add(GetYearItem());
                break;
        }
    }
    void FillDefaultGridAlignmentCombo() {
        FillGridAlignmentCombo(minMeasureUnit);
    }
    ListEditItem GetGridAlignmentItem(DateTimeGridAlignment alignment) {
        return new ListEditItem(alignment.ToString(), alignment);
    }
    ListEditItem GetYearItem() {
        return GetGridAlignmentItem(DateTimeGridAlignment.Year);
    }
    ListEditItem GetMonthItem() {
        return GetGridAlignmentItem(DateTimeGridAlignment.Month);
    }
    ListEditItem GetQuarterItem() {
        return GetGridAlignmentItem(DateTimeGridAlignment.Quarter);
    }
    ListEditItem GetWeekItem() {
        return GetGridAlignmentItem(DateTimeGridAlignment.Week);
    }
    object GetSelectedComboBoxValue<TResult>(ASPxComboBox source) where TResult : struct {
        TResult result;
        if (Enum.TryParse<TResult>(source.SelectedItem.Value.ToString(), out result))
            return result;
        return null;
    }
    void PerformSelectGridAlignment() {
        object alignment = GetSelectedComboBoxValue<DateTimeGridAlignment>(cbGridAlignment);
        if (AllowGridAlignment && alignment != null)
            Options.GridAlignment = (DateTimeGridAlignment)alignment;
    }
    void PerformSelectMeasureUnits() {
        object measureUnit = GetSelectedComboBoxValue<DateTimeMeasureUnit>(cbMeasureUnits);
        if (IsManualScale && measureUnit != null)
            Options.MeasureUnit = (DateTimeMeasureUnit)measureUnit;
    }
    void PerformSelectAggregateFuntion() {
        object function = GetSelectedComboBoxValue<AggregateFunction>(cbAggregateFunction);
        if (function != null)
            Options.AggregateFunction = (AggregateFunction)function;
    }
    ScaleMode GetScaleMode() {
        object scaleMode = GetSelectedComboBoxValue<ScaleMode>(cbScaleMode);
        return scaleMode != null ? (ScaleMode)scaleMode : ScaleMode.Automatic;
    }
    void UpdateScaleOptions() {
        Options.ScaleMode = scaleMode;
        Options.AutoGrid = IsAutoScale ? true : IsAutoGrid;
        if (!Options.AutoGrid)
            Options.GridSpacing = 1;
    }
    void UpdateClientControls() {
        cbGridAlignment.ClientEnabled = AllowGridAlignment;
        cbMeasureUnits.ClientEnabled = IsManualScale;
        cbAggregateFunction.ClientEnabled = !IsContinuousScale;
        chbAutoGrid.ClientEnabled = !IsAutoScale;
    }
    DataTable GetDataTable() {
        using (AccessDataSource dataSource = new AccessDataSource(AccessDataSource1.DataFile, selectQuery)) {
            dataSource.DataSourceMode = SqlDataSourceMode.DataSet;
            return ((DataView)dataSource.Select(DataSourceSelectArguments.Empty)).ToTable();
        }
    }

    public override WebChartControl FindWebChartControl() {
        return WebChartControl1;
    }
}
