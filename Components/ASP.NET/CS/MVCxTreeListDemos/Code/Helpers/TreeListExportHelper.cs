using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxTreeList;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public delegate ActionResult TreeListExportMethod(DevExpress.Web.Mvc.TreeListSettings settings, object dataObject);
    public class TreeListExportType {
        public string Title { get; set; }
        public TreeListExportMethod Method { get; set; }
    }

    public class TreeListExportDemoHelper {
        static Dictionary<string, TreeListExportType> exportTypes;
        public static Dictionary<string, TreeListExportType> ExportTypes {
            get {
                if(exportTypes == null)
                    exportTypes = CreateExportTypes();
                return exportTypes;
            }
        }
        static Dictionary<string, TreeListExportType> CreateExportTypes() {
            Dictionary<string, TreeListExportType> types = new Dictionary<string, TreeListExportType>();
            types.Add("PDF", new TreeListExportType { Title = "Export to PDF", Method = TreeListExtension.ExportToPdf });
            types.Add("XLS", new TreeListExportType { Title = "Export to XLS", Method = TreeListExtension.ExportToXls });
            types.Add("XLSX", new TreeListExportType { Title = "Export to XLSX", Method = TreeListExtension.ExportToXlsx });
            types.Add("RTF", new TreeListExportType { Title = "Export to RTF", Method = TreeListExtension.ExportToRtf });
            return types;
        }

        static DevExpress.Web.Mvc.TreeListSettings exportTreeListSettings;
        public static DevExpress.Web.Mvc.TreeListSettings CreateExportTreeListSettings(TreeListExportDemoOptions options) {
            if(exportTreeListSettings == null)
                exportTreeListSettings = CreateTreeListSettings();
            exportTreeListSettings.SettingsExport.PrintSettings.AutoWidth = options.EnableAutoWidth;
            exportTreeListSettings.SettingsExport.PrintSettings.ExpandAllNodes = options.ExpandAllNodes;
            exportTreeListSettings.SettingsExport.PrintSettings.ShowTreeButtons = options.ShowTreeButtons;
            return exportTreeListSettings;
        }
        static DevExpress.Web.Mvc.TreeListSettings CreateTreeListSettings() {
            DevExpress.Web.Mvc.TreeListSettings settings = new DevExpress.Web.Mvc.TreeListSettings();

            settings.Name = "treeList";
            settings.CallbackRouteValues = new { Controller = "Exporting", Action = "ExportPartial" };
            settings.Width = Unit.Percentage(100);
            settings.AutoGenerateColumns = false;

            settings.KeyFieldName = "ID";
            settings.ParentFieldName = "ParentID";
            settings.RootValue = 0;

            settings.Columns.Add("Name", "Department");
            settings.Columns.Add(
                column => {
                    column.FieldName = "Budget";
                    column.PropertiesEdit.DisplayFormatString = "{0:C}";
                }
            );
            settings.Columns.Add("Location");
            settings.Columns.Add("Phone1", "Phone");

            settings.Summary.Add(DevExpress.Data.SummaryItemType.Count, "Name");
            settings.Summary.Add(
                item => {
                    item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    item.FieldName = "Budget";
                    item.ShowInColumn = "Budget";
                    item.DisplayFormat = "{0:C}";
                }
            );

            settings.Settings.ShowFooter = true;
            settings.Settings.ShowGroupFooter = true;
            settings.Settings.GridLines = GridLines.Both;
            settings.SettingsBehavior.ExpandCollapseAction = TreeListExpandCollapseAction.NodeDblClick;
            settings.SettingsExport.Styles.Header.HorizontalAlign = HorizontalAlign.Left;

            settings.PreRender = (sender, e) => {
                ((MVCxTreeList)sender).ExpandToLevel(2);
            };

            return settings;
        }
    }
}
