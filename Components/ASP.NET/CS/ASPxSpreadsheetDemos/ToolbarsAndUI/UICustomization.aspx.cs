using System;
using System.IO;
using System.Web.UI;
using DevExpress.Spreadsheet;
using DevExpress.Web;
using DevExpress.Web.ASPxSpreadsheet;
using DevExpress.Web.Demos;

public partial class ToolbarsAndUI_UICustomization : System.Web.UI.Page {
    SpreadsheetRibbonMode CurrentRibbonMode {
        get {
            return (SpreadsheetRibbonMode)Enum.Parse(typeof(SpreadsheetRibbonMode),
                RibbonMode.SelectedItem.Value.ToString());
        }
    }
    Worksheet CurrentWorksheet {
        get {
            return Spreadsheet.Document.Worksheets.ActiveWorksheet;
        }
    }
    protected void Page_Load(object sender, EventArgs e) {
        if (!Page.IsPostBack) {
            SpreadsheetDemoUtils.HideFileTab(Spreadsheet);
            var filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "DietAndExersiseJournal.xlsx");
            Spreadsheet.Open(filePath);
        } else
            ApplySpreadsheetSettings();
    }

    protected void CallbackPanel_Callback(object sender, CallbackEventArgsBase e) {
        if (!string.IsNullOrEmpty(e.Parameter))
            ApplyDocumentSettings(e.Parameter);
        ApplySpreadsheetSettings();
    }

    private void ApplyDocumentSettings(string parameter) {
        if (parameter == "headings")
            CurrentWorksheet.ActiveView.ShowHeadings = !CurrentWorksheet.ActiveView.ShowHeadings;
        else if (parameter == "grid")
            CurrentWorksheet.ActiveView.ShowGridlines = !CurrentWorksheet.ActiveView.ShowGridlines;
    }

    private void ApplySpreadsheetSettings() {
        Spreadsheet.RibbonMode = CurrentRibbonMode;
        Spreadsheet.ShowFormulaBar = ShowFormulaBar.Checked;
        Spreadsheet.ShowSheetTabs = ShowSheetTabs.Checked;

        if (CurrentRibbonMode.Equals(SpreadsheetRibbonMode.ExternalRibbon)) {
            ExternalRibbon.Visible = true;
            AttachExternalRibbonToSpreadsheet();
        } else {
            ExternalRibbon.Visible = false;
            Spreadsheet.Height = System.Web.UI.WebControls.Unit.Pixel(550);
        }
    }

    private void AttachExternalRibbonToSpreadsheet() {
        Spreadsheet.AssociatedRibbonID = ExternalRibbon.ID;
        Spreadsheet.CreateDefaultRibbonTabs(true);
        ExternalRibbon.Tabs[0].Visible = false;
        Spreadsheet.Height = System.Web.UI.WebControls.Unit.Pixel(350);
    }

}
