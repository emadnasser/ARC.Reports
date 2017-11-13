using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Web.Mvc;
using DevExpress.XtraPrinting;

namespace DevExpress.Web.Demos {
    public enum CardViewExportFormat { None, Pdf, Xls, Xlsx, Rtf, Csv }
    public delegate ActionResult CardViewExportMethod(CardViewSettings settings, object dataObject);

    public class CardViewExportDemoHelper {
        static string FormatConditionsExportCardViewSettingsKey = "98F2A245-5D2B-4362-A68B-BAC389D7473F";
        static string ExportSelectedCardViewSettingsKey = "8373C34A-1E62-4082-8712-D7B626C05D79";

        static Dictionary<CardViewExportFormat, CardViewExportMethod> exportFormatsInfo;
        public static Dictionary<CardViewExportFormat, CardViewExportMethod> ExportFormatsInfo {
            get {
                if(exportFormatsInfo == null)
                    exportFormatsInfo = CreateExportFormatsInfo();
                return exportFormatsInfo;
            }
        }

        static IDictionary Context { get { return System.Web.HttpContext.Current.Items; } }

        static Dictionary<CardViewExportFormat, CardViewExportMethod> CreateExportFormatsInfo() {
            return new Dictionary<CardViewExportFormat, CardViewExportMethod> {
                { CardViewExportFormat.Pdf, CardViewExtension.ExportToPdf },
                {
                    CardViewExportFormat.Xls,
                    (settings, data) => CardViewExtension.ExportToXls(settings, data, new XlsExportOptionsEx { ExportType = DevExpress.Export.ExportType.DataAware })
                },
                { 
                    CardViewExportFormat.Xlsx,
                    (settings, data) => CardViewExtension.ExportToXlsx(settings, data, new XlsxExportOptionsEx { ExportType = DevExpress.Export.ExportType.DataAware })
                },
                { CardViewExportFormat.Rtf, CardViewExtension.ExportToRtf }
            };
        }

        static Dictionary<CardViewExportFormat, CardViewExportMethod> formatConditionsExportFormatsInfo;
        public static Dictionary<CardViewExportFormat, CardViewExportMethod> FormatConditionsExportFormatsInfo {
            get {
                if(formatConditionsExportFormatsInfo == null)
                    formatConditionsExportFormatsInfo = CreateAllExportFormatsInfo();
                return formatConditionsExportFormatsInfo;
            }
        }
        static Dictionary<CardViewExportFormat, CardViewExportMethod> exportSelectedFormatsInfo;
        public static Dictionary<CardViewExportFormat, CardViewExportMethod> ExportSelectedFormatsInfo {
            get {
                if(exportSelectedFormatsInfo == null)
                    exportSelectedFormatsInfo = CreateAllExportFormatsInfo();
                return exportSelectedFormatsInfo;
            }
        }
        static Dictionary<CardViewExportFormat, CardViewExportMethod> CreateAllExportFormatsInfo() {
            return new Dictionary<CardViewExportFormat, CardViewExportMethod>() {
                { CardViewExportFormat.Pdf, CardViewExtension.ExportToPdf },
                { CardViewExportFormat.Xls, (settings, data) => CardViewExtension.ExportToXls(settings, data, new XlsExportOptionsEx {ExportType = DevExpress.Export.ExportType.DataAware}) },
                { CardViewExportFormat.Xlsx, (settings, data) => CardViewExtension.ExportToXlsx(settings, data, new XlsxExportOptionsEx {ExportType = DevExpress.Export.ExportType.DataAware}) },
                { CardViewExportFormat.Rtf, CardViewExtension.ExportToRtf }
            };
        }


        static CardViewSettings exportCardViewSettings;
        public static CardViewSettings ExportCardViewSettings {
            get {
                if(exportCardViewSettings == null)
                    exportCardViewSettings = CreateExportCardViewSettings();
                return exportCardViewSettings;
            }
        }

        public static ButtonSettings GetExportButtonProperties(CardViewExportFormat format) {
            return new ButtonSettings() {
                Name = format.ToString(),
                Text = GetExportButtonTitle(format),
                RenderMode = ButtonRenderMode.Button,
                UseSubmitBehavior = true,
            };
        }
        static string GetExportButtonTitle(CardViewExportFormat format) {
            if(format == CardViewExportFormat.None)
                return string.Empty;
            var result = string.Format("Export to {0}", format.ToString().ToUpper());
            if(format == CardViewExportFormat.Xls || format == CardViewExportFormat.Xlsx)
                result += " (DataAware)";
            return result;
        }
        static CardViewSettings CreateExportCardViewSettings() {
            var settings = new CardViewSettings();

            settings.Name = "cardView";
            settings.CallbackRouteValues = new { Controller = "Exporting", Action = "ExportPartial" };
            settings.SettingsExport.CardWidth = 300;

            settings.Columns.Add("ProductName");
            settings.Columns.Add(column => {
                column.FieldName = "UnitPrice";
                column.PropertiesEdit.DisplayFormatString = "c";
            });
            settings.Columns.Add("QuantityPerUnit");
            settings.Columns.Add(column => {
                column.FieldName = "CategoryID";
                column.Caption = "Category Name";

                column.ColumnType = MVCxCardViewColumnType.ComboBox;
                var comboBoxProperties = column.PropertiesEdit as ComboBoxProperties;
                comboBoxProperties.DataSource = NorthwindDataProvider.GetCategories();
                comboBoxProperties.TextField = "CategoryName";
                comboBoxProperties.ValueField = "CategoryID";
                comboBoxProperties.ValueType = typeof(int);
            });
            settings.Columns.Add(column => {
                column.FieldName = "Discontinued";
                column.ColumnType = MVCxCardViewColumnType.CheckBox;
            });
            var productGroup = settings.CardLayoutProperties.Items.AddGroupItem(group => {
                group.Caption = "Product";
                group.GroupBoxDecoration = GroupBoxDecoration.HeadingLine;
            });
            productGroup.Items.Add(item => {
                item.ColumnName = "ProductName";
                item.Caption = "Name";
            });
            productGroup.Items.Add("CategoryID");
            var detailsGroup = settings.CardLayoutProperties.Items.AddGroupItem(group => {
                group.Caption = "Details";
                group.GroupBoxDecoration = GroupBoxDecoration.HeadingLine;
            });
            detailsGroup.Items.Add("UnitPrice");
            detailsGroup.Items.Add("QuantityPerUnit");
            detailsGroup.Items.Add("Discontinued");

            settings.SettingsPager.SettingsTableLayout.ColumnCount = 2;
            settings.SettingsPager.SettingsTableLayout.RowsPerPage = 2;

            settings.Styles.Card.Height = 1;
            return settings;
        }

        public static CardViewSettings ExportSelectedCardViewSettings {
            get {
                var settings = Context[ExportSelectedCardViewSettingsKey] as CardViewSettings;
                if(settings == null)
                    Context[ExportSelectedCardViewSettingsKey] = settings = CreateExportSelectedCardViewSettings();
                return settings;
            }
        }
        static CardViewSettings CreateExportSelectedCardViewSettings() {
            var settings = new CardViewSettings();
            settings.Name = "cardView";
            settings.CallbackRouteValues = new { Controller = "Exporting", Action = "ExportSelectedPartial" };
            settings.Width = Unit.Percentage(100);
            settings.Settings.ShowSummaryPanel = true;
            settings.SettingsExport.CardWidth = 430;
            settings.SettingsExport.ExportSelectedCardsOnly = true;

            settings.KeyFieldName = "ID";
            settings.EnableCardsCache = false;
            settings.Columns.Add("Address");
            settings.Columns.Add("Baths");
            settings.Columns.Add("Beds");
            settings.Columns.Add("HouseSize");
            settings.Columns.Add(column => {
                column.FieldName = "Price";
                column.PropertiesEdit.DisplayFormatString = "c";
            });
            settings.Columns.Add(column => {
                column.FieldName = "PhotoUrl";
                column.ColumnType = MVCxCardViewColumnType.Image;
                var properties = (ImageEditProperties)column.PropertiesEdit;
                properties.ImageWidth = 200;
                properties.ExportImageSettings.Width = 200;
                properties.ExportImageSettings.Height = 133;
            });

            settings.CardLayoutProperties.ColCount = 2;
            settings.CardLayoutProperties.Items.Add(layoutItem => {
                layoutItem.ColumnName = "PhotoUrl";
                layoutItem.ShowCaption = DefaultBoolean.False;
                layoutItem.RowSpan = 6;
                layoutItem.VerticalAlign = FormLayoutVerticalAlign.Top;
            });

            settings.CardLayoutProperties.Items.Add(new CardViewCommandLayoutItem() {
                ShowSelectCheckbox = true,
                HorizontalAlign = FormLayoutHorizontalAlign.Right
            });
            settings.CardLayoutProperties.Items.Add("Baths");
            settings.CardLayoutProperties.Items.Add("Beds");
            settings.CardLayoutProperties.Items.Add("HouseSize");
            settings.CardLayoutProperties.Items.Add("Price");
            settings.CardLayoutProperties.Items.Add("Address");

            var summary = settings.TotalSummary.Add(SummaryItemType.Min, "Price");
            summary.ValueDisplayFormat = "c0";
            summary = settings.TotalSummary.Add(SummaryItemType.Max, "Price");
            summary.ValueDisplayFormat = "c0";

            settings.SettingsPager.SettingsTableLayout.ColumnCount = 2;
            settings.SettingsPager.SettingsTableLayout.RowsPerPage = 2;

            settings.SettingsBehavior.AllowSelectByCardClick = true;

            settings.Styles.Card.Width = 450;

            settings.SettingsExport.RenderBrick += (s, e) => {
                if(e.Column.FieldName == "PhotoUrl") {
                    var path = HostingEnvironment.MapPath(e.Value.ToString());
                    if(File.Exists(path))
                        e.ImageValue = File.ReadAllBytes(path);
                }
            };

            return settings;
        }

        public static CardViewSettings FormatConditionsExportCardViewSettings {
            get {
                var settings = Context[FormatConditionsExportCardViewSettingsKey] as CardViewSettings;
                if(settings == null)
                    Context[FormatConditionsExportCardViewSettingsKey] = settings = CreateFormatConditionsExportCardViewSettings();
                return settings;
            }
        }
        static CardViewSettings CreateFormatConditionsExportCardViewSettings() {
            var settings = new CardViewSettings();
            settings.Name = "cardView";
            settings.CallbackRouteValues = new { Controller = "Exporting", Action = "ExportWithFormatConditionsPartial" };
            settings.Width = Unit.Percentage(100);
            settings.SettingsExport.CardWidth = 430;
            settings.EnableCardsCache = false;

            settings.Columns.Add("Address");
            settings.Columns.Add("Baths");
            settings.Columns.Add("Beds");
            settings.Columns.Add("HouseSize");
            settings.Columns.Add(column => {
                column.FieldName = "Price";
                column.PropertiesEdit.DisplayFormatString = "c";
            });
            settings.Columns.Add(column => {
                column.FieldName = "Photo";
                column.ColumnType = MVCxCardViewColumnType.BinaryImage;
                var properties = (BinaryImageEditProperties)column.PropertiesEdit;
                properties.ImageWidth = 200;
                properties.ExportImageSettings.Width = 200;
                properties.ExportImageSettings.Height = 133;
            });

            settings.CardLayoutProperties.ColCount = 2;
            settings.CardLayoutProperties.Items.Add(layoutItem => { 
                layoutItem.ColumnName = "Photo";
                layoutItem.ShowCaption = DefaultBoolean.False;
                layoutItem.RowSpan = 6;
                layoutItem.VerticalAlign = FormLayoutVerticalAlign.Top;
            });
            settings.CardLayoutProperties.Items.Add("Baths");
            settings.CardLayoutProperties.Items.Add("Beds");
            settings.CardLayoutProperties.Items.Add("HouseSize");
            settings.CardLayoutProperties.Items.Add("Price");
            settings.CardLayoutProperties.Items.Add("Address");

            settings.FormatConditions.AddTopBottom(item => {
                item.FieldName = "Price";
                item.Threshold = 10;
                item.Rule = GridTopBottomRule.BottomItems;
                item.Format = GridConditionHighlightFormat.BoldText | GridConditionHighlightFormat.GreenText;
            });
            settings.FormatConditions.AddTopBottom(item => {
                item.FieldName = "TopItems";
                item.Threshold = 10;
                item.Rule = GridTopBottomRule.BottomItems;
                item.Format = GridConditionHighlightFormat.BoldText | GridConditionHighlightFormat.RedText;
            });
            settings.FormatConditions.AddIconSet(item => {
                item.FieldName = "Baths";
                item.Format = GridConditionIconSetFormat.Arrows3Colored;
            });
            settings.FormatConditions.AddIconSet(item => {
                item.FieldName = "Beds";
                item.Format = GridConditionIconSetFormat.Arrows3Colored;
            });
            settings.FormatConditions.AddTopBottom(item => {
                item.FieldName = "HouseSize";
                item.Rule = GridTopBottomRule.TopItems;
                item.Threshold = 5;
                item.Format = GridConditionHighlightFormat.GreenText;
            });
            settings.FormatConditions.AddTopBottom(item => {
                item.FieldName = "HouseSize";
                item.Rule = GridTopBottomRule.BottomItems;
                item.Threshold = 5;
                item.Format = GridConditionHighlightFormat.RedText;
            });

            settings.TotalSummary.Add(SummaryItemType.Min, "Price");
            settings.TotalSummary.Add(SummaryItemType.Max, "Price");

            settings.SettingsPager.SettingsTableLayout.ColumnCount = 2;
            settings.SettingsPager.SettingsTableLayout.RowsPerPage = 2;

            settings.Styles.Card.Width = 450;

            return settings;
        }

        public static void SetImageColumnExportVisibility(CardViewSettings settings, CardViewExportFormat format, string fieldName) {
            settings.SettingsExport.BeforeExport += (s, e) => ((MVCxCardView)s).Columns[fieldName].Visible = format != CardViewExportFormat.Xls && format != CardViewExportFormat.Xlsx;
        }
    }
}
