using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;
using DevExpress.Utils;

public partial class DrillDown : ChartBasePage {
    readonly string[] summaryKind = new string[] { "Min", "Max", "Average" };
    readonly string[] sqlSummaryCommand = new string[] { "MIN", "MAX", "AVG" };
    Series CategoriesSeries { get { return WebChartControl1.GetSeriesByName("Categories"); } }
    Series ProductsSeries { get { return WebChartControl1.GetSeriesByName("Products"); } }
    bool IsCategoriesChart { get { return CategoriesSeries.Visible; } }

    DataView RetrieveCategories() {
        string selectCommand =
            "SELECT Categories.CategoryName, Categories.CategoryID, " +
            sqlSummaryCommand[cbSummaryKind.SelectedIndex] +
            "(Products.UnitPrice) AS AvgPrice FROM Categories, Products WHERE Categories.CategoryID = Products.CategoryID GROUP BY Categories.CategoryName, Categories.CategoryID";
        using (AccessDataSource dataSource = new AccessDataSource(AccessDataSource1.DataFile, selectCommand)) {
            dataSource.DataSourceMode = SqlDataSourceMode.DataSet;
            return (DataView)dataSource.Select(DataSourceSelectArguments.Empty);
        }
    }
    void BindCategories() {
        if (IsCategoriesChart) {
            DataView categories = RetrieveCategories();
            CategoriesSeries.DataSource = categories;
            CategoriesSeries.ArgumentDataMember = "CategoryName";
            CategoriesSeries.ValueDataMembers[0] = "AvgPrice";
        }
        else {
            CategoriesSeries.ArgumentDataMember = String.Empty;
            CategoriesSeries.ValueDataMembers[0] = String.Empty;
        }
    }
    void InitProductsChart(SeriesPoint point) {
        CategoriesSeries.Visible = false;
        ProductsSeries.DataFilters[0].Value = (int)((DataRowView)point.Tag)["CategoryId"];
        ProductsSeries.LegendText = point.Argument;
        AxisXBase axisX = ((XYDiagramSeriesViewBase)ProductsSeries.View).AxisX;
        axisX.Label.Angle = 30;
        AxisYBase axisY = ((XYDiagramSeriesViewBase)ProductsSeries.View).AxisY;
        axisY.Title.Text = "Price, USD";
        axisY.Title.Visibility = DefaultBoolean.True;
        WebChartControl1.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left;
        WebChartControl1.Legend.AlignmentVertical = LegendAlignmentVertical.Top;
        WebChartControl1.Legend.Margins.All = 10;
        WebChartControl1.Titles[0].Visibility = DefaultBoolean.False;
        WebChartControl1.Titles[1].Visibility = DefaultBoolean.True;
        if (WebChartControl1.ToolTipEnabled == DefaultBoolean.True) {
            WebChartControl1.CrosshairEnabled = DefaultBoolean.True;
            WebChartControl1.ToolTipEnabled = DefaultBoolean.False;
        }
    }
    void InitCategoriesChart() {
        CategoriesSeries.Visible = true;
        WebChartControl1.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside;
        WebChartControl1.Legend.AlignmentVertical = LegendAlignmentVertical.Center;
        WebChartControl1.Legend.Margins.All = 5;
        WebChartControl1.Titles[0].Visibility = DefaultBoolean.True;
        WebChartControl1.Titles[1].Visibility = DefaultBoolean.False;
        if (WebChartControl1.CrosshairEnabled == DefaultBoolean.True) {
            WebChartControl1.ToolTipEnabled = DefaultBoolean.True;
            WebChartControl1.CrosshairEnabled = DefaultBoolean.False;
        }
        BindCategories();
    }
    void InitChartTitle() {
        WebChartControl1.Titles[0].Text = summaryKind[cbSummaryKind.SelectedIndex] + " Product Prices by Categories";
    }
    void PerformSummaryKindAction() {
        InitChartTitle();
    }
    void PerformShowLabelsAction() {
        foreach (Series series in WebChartControl1.Series)
            series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        if (WebChartControl1.Series[0].Visible) {
            WebChartControl1.ToolTipEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
            WebChartControl1.CrosshairEnabled = DefaultBoolean.False;
        }
        else {
            WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
            WebChartControl1.ToolTipEnabled = DefaultBoolean.False;
        }
    }
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = CategoriesSeries.LabelsVisibility == DefaultBoolean.True;
            ComboBoxHelper.PrepareComboBox(cbSummaryKind, summaryKind);
        }
        BindCategories();
        if (IsCategoriesChart)
            InitChartTitle();
    }
    protected void WebChartControl1_ObjectSelected(object sender, HotTrackEventArgs e) {
        if (IsCategoriesChart) {
            SeriesPoint point = e.AdditionalObject as SeriesPoint;
            if (point != null)
                InitProductsChart(point);
            e.Cancel = point == null;
        }
        else if (e.HitInfo.InChartTitle)
            InitCategoriesChart();
    }
    protected void WebChartControl1_CallbackStateLoad(object sender, CallbackStateLoadEventArgs e) {
        BindCategories();
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "SummaryKind")
            PerformSummaryKindAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
    }
}
