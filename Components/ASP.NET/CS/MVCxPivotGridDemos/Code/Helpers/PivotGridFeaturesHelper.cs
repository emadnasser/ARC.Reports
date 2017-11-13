using System.Web.UI.WebControls;
using DevExpress.Utils;
using DevExpress.Web.Mvc;
using DevExpress.XtraPivotGrid;

namespace DevExpress.Web.Demos {
    public class PivotGridFeaturesDemosHelper {
        static PivotGridSettings drillDownPivotGridSettings;
        public static PivotGridSettings DrillDownPivotGridSettings {
            get {
                if(drillDownPivotGridSettings == null)
                    drillDownPivotGridSettings = CreateDrillDownPivotGridSettings();
                return drillDownPivotGridSettings;
            }
        }
        static PivotGridSettings CreateDrillDownPivotGridSettings() {
            var settings = new PivotGridSettings();
            settings.Name = "pivotGrid";
            settings.CallbackRouteValues = new { Controller = "Features", Action = "DrillDownPivotGridPartial" };
            settings.Width = Unit.Percentage(100);

            settings.Fields.Add(field => {
                field.Area = PivotArea.FilterArea;
                field.AreaIndex = 0;
                field.Caption = "Product";
                field.FieldName = "ProductName";
            });
            settings.Fields.Add(field => {
                field.Area = PivotArea.RowArea;
                field.AreaIndex = 0;
                field.Caption = "Customer";
                field.FieldName = "CompanyName";
            });
            settings.Fields.Add(field => {
                field.Area = PivotArea.ColumnArea;
                field.AreaIndex = 0;
                field.Caption = "Year";
                field.FieldName = "OrderDate";
                field.GroupInterval = PivotGroupInterval.DateYear;
            });
            settings.Fields.Add(field => {
                field.Area = PivotArea.DataArea;
                field.AreaIndex = 0;
                field.Caption = "Product Amount";
                field.FieldName = "ProductAmount";
                field.CellFormat.FormatString = "c";
                field.CellFormat.FormatType = FormatType.Custom;
            });
            settings.Fields.Add(field => {
                field.Area = PivotArea.FilterArea;
                field.AreaIndex = 1;
                field.Caption = "Quarter";
                field.FieldName = "OrderDate";
                field.GroupInterval = PivotGroupInterval.DateQuarter;
            });

            settings.Styles.CellStyle.Cursor = "pointer";
            settings.OptionsView.ShowFilterHeaders = false;
            settings.ClientSideEvents.CellClick = "OnPivotGridCellClick";

            settings.Fields["Year"].UnboundFieldName = "Year";
            settings.Fields["Product"].Area = PivotArea.RowArea;
            return settings;
        }
    }
}
