using System;
using System.Collections;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.XtraCharts;
using DevExpress.Utils;
using DevExpress.XtraCharts.Web;

public partial class HorizontalPanes : ChartBasePage {
    Series LeftSeries { get { return WebChartControl1.Series[0]; } }
    Series RightSeries { get { return WebChartControl1.Series[1]; } }
    int LeftCategoryDefaultIndex { get { return 2; } }
    int RightCategoryDefaultIndex { get { return 3; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = LeftSeries.LabelsVisibility == DefaultBoolean.True;
            PrepareCategoriesComboBox(cbLeftCategory, LeftCategoryDefaultIndex);
            PrepareCategoriesComboBox(cbRightCategory, RightCategoryDefaultIndex);
            SelectCategory(cbLeftCategory, LeftSeries);
            SelectCategory(cbRightCategory, RightSeries);
        }
    }
    DataView RetrieveDataView() {
        const string selectCommand = "SELECT * from CATEGORIES";
        using(AccessDataSource dataSource = new AccessDataSource(AccessDataSource1.DataFile, selectCommand)) {
            dataSource.DataSourceMode = SqlDataSourceMode.DataSet;
            return (DataView)dataSource.Select(DataSourceSelectArguments.Empty);
        }
    }
    DataRowView RetrieveDataRowViewByIndex(int rowIndex) {
        DataView dataView = RetrieveDataView();
        return dataView[rowIndex];
    }
    SortedList RetrieveCategories() {
        SortedList list = new SortedList();
        DataView dataView = RetrieveDataView();
        if(dataView != null) {
            foreach(DataRowView view in dataView) {
                int categoryId = (int)view.Row["CategoryID"];
                string category = (string)view.Row["CategoryName"];
                list[category] = categoryId;
            }
        }
        return list;
    }
    void SelectCategory(ASPxComboBox cbCategories, Series series) {
        if(cbCategories.Items.Count == 0)
            return;
        int categoryId = Convert.ToInt32((string)cbCategories.SelectedItem.Value);
        string categoryName = cbCategories.SelectedItem.Text;

        series.Name = categoryName;
        series.DataFilters.Clear();
        series.DataFilters.Add(new DataFilter("CategoryID", "System.Int32", DataFilterCondition.Equal, categoryId));
        ((XYDiagramSeriesViewBase)series.View).AxisX.Title.Text = series.Name;
    }
    void PrepareCategoriesComboBox(ASPxComboBox cbCategories, int selectedIndex) {
        SortedList categories = RetrieveCategories();
        if(categories.Count == 0)
            cbCategories.Enabled = false;
        else
            ComboBoxHelper.PrepareComboBox(cbCategories, categories, selectedIndex);
    }
    void PerformShowLabelsAction() {
        LeftSeries.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        RightSeries.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void PerformLeftCategoryAction() {
        SelectCategory(cbLeftCategory, LeftSeries);
    }
    void PerformRightCategoryAction() {
        SelectCategory(cbRightCategory, RightSeries);
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if (e.Parameter == "LeftCategory")
            PerformLeftCategoryAction();
        else if (e.Parameter == "RightCategory")
            PerformRightCategoryAction();
    }
}
