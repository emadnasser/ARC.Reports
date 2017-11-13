using System.Web.UI.WebControls;
using DevExpress.Utils;
using DevExpress.Web.Mvc;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Customization;

namespace DevExpress.Web.Demos {
    public class PivotGridLayoutDemosHelper {
        static PivotGridSettings compactLayoutPivotGridSettings;
        public static PivotGridSettings CompactLayoutPivotGridSettings {
            get {
                if(compactLayoutPivotGridSettings == null)
                    compactLayoutPivotGridSettings = CreateCompactLayoutPivotGridSettings();
                return compactLayoutPivotGridSettings;
            }
        }
        static PivotGridSettings CreateCompactLayoutPivotGridSettings() {
            PivotGridSettings settings = new PivotGridSettings();
            settings.Name = "pivotGrid";
            settings.CallbackRouteValues = new { Controller = "Layout", Action = "CompactLayoutPartial" };
            settings.OptionsPager.NumericButtonCount = 7;
            settings.OptionsPager.RowsPerPage = 15;
            settings.OptionsView.HorizontalScrollBarMode = ScrollBarMode.Auto;
            settings.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Tree;
            settings.OptionsView.ShowTotalsForSingleValues = true;
            settings.OptionsView.ShowColumnHeaders = false;
            settings.OptionsView.ShowDataHeaders = false;
            settings.OptionsView.ShowFilterHeaders = false;
            settings.OptionsView.ShowRowHeaders = false;
            settings.Width = Unit.Pixel(400);


            settings.PivotCustomizationExtensionSettings.Name = "pivotCustomization";
            settings.PivotCustomizationExtensionSettings.AllowedLayouts = CustomizationFormAllowedLayouts.BottomPanelOnly1by4 | CustomizationFormAllowedLayouts.BottomPanelOnly2by2 |
                CustomizationFormAllowedLayouts.StackedDefault | CustomizationFormAllowedLayouts.StackedSideBySide;
            settings.PivotCustomizationExtensionSettings.Layout = CustomizationFormLayout.BottomPanelOnly2by2;
            settings.PivotCustomizationExtensionSettings.AllowSort = true;
            settings.PivotCustomizationExtensionSettings.AllowFilter = true;
            settings.PivotCustomizationExtensionSettings.Height = Unit.Pixel(480);
            settings.PivotCustomizationExtensionSettings.Width = Unit.Pixel(400);

            settings.Fields.Add(field => {
                field.FieldName = "Country";
                field.Area = PivotArea.RowArea;
                field.AreaIndex = 0;
            });
            settings.Fields.Add(field => {
                field.Caption = "Category Name";
                field.FieldName = "CategoryName";
                field.Area = PivotArea.RowArea;
                field.AreaIndex = 1;
            });
            settings.Fields.Add(field => {
                field.Caption = "Product Name";
                field.FieldName = "ProductName";
                field.Area = PivotArea.RowArea;
                field.AreaIndex = 2;
            });
            settings.Fields.Add(field => {
                field.Caption = "Customer";
                field.FieldName = "Sales_Person";
                field.Area = PivotArea.RowArea;
                field.AreaIndex = 3;
            });
            settings.Fields.Add(field => {
                field.Caption = "Order Year";
                field.FieldName = "OrderDate";
                field.Area = PivotArea.RowArea;
                field.AreaIndex = 4;
                field.GroupInterval = PivotGroupInterval.DateYear;
            });
            settings.Fields.Add(field => {
                field.Caption = "Order Quarter";
                field.FieldName = "OrderDate";
                field.Area = PivotArea.RowArea;
                field.AreaIndex = 5;
                field.GroupInterval = PivotGroupInterval.DateQuarter;
                field.ValueFormat.FormatString = "Qtr {0}";
                field.ValueFormat.FormatType = FormatType.Numeric;
            });
            settings.Fields.Add("Quantity", PivotArea.DataArea);
            settings.Fields.Add("UnitPrice", PivotArea.FilterArea);

            settings.PreRender = (sender, e) => {
                MVCxPivotGrid pivotGrid = (MVCxPivotGrid)sender;
                pivotGrid.CollapseAll();
                pivotGrid.ExpandValue(false, new object[] { "UK" });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments" });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments", "Chef Anton's Cajun Seasoning" });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments", "Chef Anton's Cajun Seasoning", "Robert King" });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments", "Chef Anton's Cajun Seasoning", "Robert King", 1996 });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments", "Chef Anton's Cajun Seasoning", "Robert King", 1997 });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments", "Genen Shouyu" });
                pivotGrid.ExpandValue(false, new object[] { "UK", "Condiments", "Genen Shouyu", "Michael Suyama" });
            };
            return settings;
        }
    }
}
