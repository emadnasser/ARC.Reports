using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Web.Mvc;
using DevExpress.XtraPrinting;

namespace DevExpress.Web.Demos {
    public enum VerticalGridExportFormat { None, Pdf, Xls, Xlsx, Rtf }
    public delegate ActionResult VerticalGridExportMethod(VerticalGridSettings settings, object dataObject);

    public class VerticalGridExportDemoHelper {
        static Dictionary<VerticalGridExportFormat, VerticalGridExportMethod> exportFormatsInfo;
        public static Dictionary<VerticalGridExportFormat, VerticalGridExportMethod> ExportFormatsInfo {
            get {
                if(exportFormatsInfo == null)
                    exportFormatsInfo = CreateExportFormatsInfo();
                return exportFormatsInfo;
            }
        }

        static Dictionary<VerticalGridExportFormat, VerticalGridExportMethod> CreateExportFormatsInfo() {
            return new Dictionary<VerticalGridExportFormat, VerticalGridExportMethod> {
                { VerticalGridExportFormat.Pdf, VerticalGridExtension.ExportToPdf },
                { VerticalGridExportFormat.Xls, VerticalGridExtension.ExportToXls },
                { VerticalGridExportFormat.Xlsx, VerticalGridExtension.ExportToXlsx },
                { VerticalGridExportFormat.Rtf, VerticalGridExtension.ExportToRtf }
            };
        }

        static VerticalGridSettings exportVerticalGridSettings;
        public static VerticalGridSettings ExportVerticalGridSettings {
            get {
                if(exportVerticalGridSettings == null)
                    exportVerticalGridSettings = CreateExportVerticalGridSettings();
                return exportVerticalGridSettings;
            }
        }

        public static ButtonSettings GetExportButtonProperties(VerticalGridExportFormat format) {
            return new ButtonSettings() {
                Name = format.ToString(),
                Text = GetExportButtonTitle(format),
                RenderMode = ButtonRenderMode.Button,
                UseSubmitBehavior = true,
            };
        }
        static string GetExportButtonTitle(VerticalGridExportFormat format) {
            if(format == VerticalGridExportFormat.None)
                return string.Empty;
            var result = string.Format("Export to {0}", format.ToString().ToUpper());
            return result;
        }
        static VerticalGridSettings CreateExportVerticalGridSettings() {
            var settings = new VerticalGridSettings();
            settings.Name = "VerticalGrid";
            settings.Width = Unit.Percentage(100);
            settings.CallbackRouteValues = new { Controller = "Exporting", Action = "ExportingPartial" };
            settings.SettingsBehavior.AllowRowExpanding = false;
            settings.Settings.HorizontalScrollBarMode = ScrollBarMode.Visible;
            settings.Settings.RecordWidth = 250;
            settings.Settings.ShowCategoryIndents = false;

            var c1 = settings.Rows.AddCategory("Product Info");
            c1.Rows.Add("ProductName");
            c1.Rows.Add("Category.CategoryName").Visible = false;
            c1.Rows.Add(r => {
                r.FieldName = "Category.Picture";
                r.RowType = MVCxVerticalGridRowType.BinaryImage;
                r.Caption = "Category";
                r.RecordStyle.HorizontalAlign = HorizontalAlign.Center;
                var props = (BinaryImageEditProperties)r.PropertiesEdit;
                r.EditorProperties().BinaryImage(p => {
                    p.ImageHeight = 150;
                    p.ExportImageSettings.Width = 240;
                    p.ExportImageSettings.Height = 150;
                    p.ToolTipField = "Category.CategoryName";
                });
            });

            c1.Rows.Add("UnitPrice", MVCxVerticalGridRowType.SpinEdit).PropertiesEdit.DisplayFormatString = "c";
            c1.Rows.Add("UnitsInStock");
            c1.Rows.Add(r => {
                r.FieldName = "Total";
                r.UnboundType = UnboundColumnType.Decimal;
                r.UnboundExpression = "UnitsInStock*UnitPrice";
                r.PropertiesEdit.DisplayFormatString = "c";
            });

            var c2 = settings.Rows.AddCategory("Supplier Info");
            c2.Rows.Add("Supplier.CompanyName");
            c2.Rows.Add("Supplier.ContactName");

            return settings;
        }
    }
}
