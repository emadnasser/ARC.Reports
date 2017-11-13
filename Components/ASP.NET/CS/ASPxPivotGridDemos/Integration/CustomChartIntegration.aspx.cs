using System;
using System.Web.UI;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraCharts;

public partial class ChartsIntegration_CustomChartData : Page {
    enum RowFieldValueExportRule {
        ProductName = 0,
        CategoryAndProduct = 1,
        CategoryEncoded = 2
    };

    static string[] categories = new string[] { "Beverages", "Condiments", "Confections", "Dairy Products", "Grains/Cereals", "Meat/Poultry", "Produce", "Seafood" };

    Type ExportRowFieldValuesAsType {
        get {
            switch(RowExportRule) {
                case RowFieldValueExportRule.ProductName:
                case RowFieldValueExportRule.CategoryAndProduct:
                    return typeof(string);
                case RowFieldValueExportRule.CategoryEncoded:
                    return typeof(char);
            }
            return null;
        }
    }
    RowFieldValueExportRule RowExportRule { get { return (RowFieldValueExportRule)(RowValueExport.SelectedIndex); } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            ChartType.Items.AddRange(new ViewType[] {
                ViewType.Bar, ViewType.StackedBar, ViewType.FullStackedBar,
                ViewType.SideBySideStackedBar, ViewType.SideBySideFullStackedBar,
                ViewType.Point, ViewType.Line, ViewType.StepLine, ViewType.Spline, 
                ViewType.Area, ViewType.SplineArea, ViewType.StackedArea, ViewType.StackedSplineArea,
                ViewType.FullStackedArea, ViewType.FullStackedSplineArea
            });
            RowValueExport.Items.AddRange(new string[] { "ProductName", "Category/ProductName", "Encoded Product Category" });
            PointLabels.Checked = false;
            WebChart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            ASPxPivotGrid.OptionsChartDataSource.ProvideRowFieldValuesAsType = ExportRowFieldValuesAsType;
            if (!IsCallback) {
                ChartType.SelectedItem = ChartType.Items.FindByText(ViewType.Line.ToString());
                RowValueExport.SelectedIndex = 0;
                CellValueThreshold.Value = "100";
                SetChartType("Line");
                ASPxPivotGrid.OptionsPager.PageIndex = 4;
            }
        }
    }
	void SetChartType(string text) {
		WebChart.SeriesTemplate.ChangeView((ViewType)Enum.Parse(typeof(ViewType), text));
	}
    protected void PointLabels_CheckedChanged(object sender, EventArgs e) {
        WebChart.SeriesTemplate.LabelsVisibility = PointLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
    protected void ChartType_ValueChanged(object sender, EventArgs e) {
        SetChartType(ChartType.SelectedItem.Text);
    }
    protected void ASPxPivotGrid_CustomChartDataSourceData(object sender, PivotCustomChartDataSourceDataEventArgs e) {
        if(e.ItemType == DevExpress.XtraPivotGrid.PivotChartItemType.CellItem) {
            if(e.Value == DBNull.Value || (decimal)e.Value < Convert.ToDecimal(CellValueThreshold.Value))
                e.Value = 0;
        }
        if(e.ItemType == DevExpress.XtraPivotGrid.PivotChartItemType.RowItem) {
            bool isCategoryField = object.Equals(e.FieldValueInfo.Field, fieldCategoryName);
            switch(RowExportRule) {
                case RowFieldValueExportRule.ProductName:
                    if(isCategoryField)
                        e.Value = e.FieldValueInfo.Value.ToString() + " Category";
                    else
                        e.Value = e.FieldValueInfo.Value;
                    break;
                case RowFieldValueExportRule.CategoryAndProduct:
                    if(isCategoryField)
                        e.Value = e.FieldValueInfo.Value.ToString() + '/' + "Total";
                    else
                        e.Value = e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName).ToString() + '/' + e.FieldValueInfo.Value.ToString();
                    break;
                case RowFieldValueExportRule.CategoryEncoded:
                    string categoryName = (isCategoryField) ? e.FieldValueInfo.Value.ToString() :
                              e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName).ToString();
                    e.Value = EncodeCategoryName(categoryName);
                    break;
            }
        }
    }
    Char EncodeCategoryName(string categoryName) {
        for(int i = 0; i < categories.Length; i++) {
            if(categories[i] == categoryName)
                return Convert.ToChar(Convert.ToInt32('A') + i);
        }
        return 'Z';
    }
}
