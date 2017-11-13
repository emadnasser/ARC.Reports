using System;
using System.Web.UI;
using DevExpress.Data;
using DevExpress.Web;

public partial class Columns_ContextMenu : Page {
    protected void Page_Load(object sender, EventArgs args) {
        if(!IsPostBack) {
            Grid.DataBind();
            Grid.ExpandRow(1);
        }
    }
    protected void Grid_FillContextMenuItems(object sender, ASPxGridViewContextMenuEventArgs e) {
        if(e.MenuType == GridViewContextMenuType.Rows) {
            var item = e.CreateItem("Export", "Export");
            item.BeginGroup = true;
            e.Items.Insert(e.Items.IndexOfCommand(GridViewContextMenuCommand.Refresh), item);

            AddMenuSubItem(item, "PDF", "ExportToPDF", @"Images/ExportToPdf.png", true);
            AddMenuSubItem(item, "XLS", "ExportToXLS", @"Images/ExportToXls.png", true);
        }
    }
    private static void AddMenuSubItem(GridViewContextMenuItem parentItem, string text, string name, string imageUrl, bool isPostBack) {
        var exportToXlsItem = parentItem.Items.Add(text, name);
        exportToXlsItem.Image.Url = imageUrl;
    }
    protected void Grid_ContextMenuItemClick(object sender, ASPxGridViewContextMenuItemClickEventArgs e) {
        switch(e.Item.Name) {
            case "ExportToPDF":
                GridExporter.WritePdfToResponse();
                break;
            case "ExportToXLS":
                GridExporter.WriteXlsToResponse();
                break;
        }
    }
    protected void Grid_AddSummaryItemViaContextMenu(object sender, ASPxGridViewAddSummaryItemViaContextMenuEventArgs e) {
        if(e.SummaryItem.FieldName == "UnitsInStock" && e.SummaryItem.SummaryType == SummaryItemType.Average)
            e.SummaryItem.ValueDisplayFormat = "{0:0.00}";
    }

    int totalSum;
    protected void Grid_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e) {
        if(e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            totalSum = 0;
        if(e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            if(Grid.Selection.IsRowSelectedByKey(e.GetValue(Grid.KeyFieldName)))
                totalSum += Convert.ToInt32(e.FieldValue);
        if(e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            e.TotalValue = totalSum;
    }
}
