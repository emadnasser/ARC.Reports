using System;
using System.Web.UI;
using DevExpress.Data;
using DevExpress.Web.Demos;
using DevExpress.Web;

public partial class PopupMenu : Page {
    PopupAction CurrentPopupAction {
        get {
            return (PopupAction)Enum.Parse(typeof(PopupAction),
                ddlPopupAction.SelectedItem.Value.ToString());
        }
    }

    PopupHorizontalAlign CurrentPopupHorizontalAlign {
        get {
            return (PopupHorizontalAlign)Enum.Parse(typeof(PopupHorizontalAlign),
                ddlHorizontalAlign.SelectedItem.Value.ToString());
        }
    }

    PopupVerticalAlign CurrentPopupVerticalAlign {
        get {
            return (PopupVerticalAlign)Enum.Parse(typeof(PopupVerticalAlign),
                ddlVerticalAlign.SelectedItem.Value.ToString());
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/Menu/CSS/PopupMenu.css");
        if(!IsPostBack)
            ddlPopupAction.Value = ASPxPopupMenu1.PopupAction.ToString();
        ASPxWebControl.RegisterBaseScript(Page);
    }

    protected void ASPxPopupMenu1_ItemClick(object sender, MenuItemEventArgs e) {
        if(e.Item == null)
            return;
        GridView1.ClearSort();
        GridViewDataColumn clickedColumn = (GridViewDataColumn)GridView1.Columns[e.Item.Name];
        GridView1.SortBy(clickedColumn, ColumnSortOrder.Ascending);
    }

    protected void GridView1_PreRender(object sender, EventArgs e) {
        foreach(GridViewColumn column in GridView1.Columns) {
            GridViewDataColumn dataColumn = column as GridViewDataColumn;
            column.CellStyle.Font.Bold = dataColumn.SortOrder != ColumnSortOrder.None;
        }
    }

    protected void ddlPopupAction_SelectedIndexChanged(object sender, EventArgs e) {
        ASPxPopupMenu1.PopupAction = CurrentPopupAction;
    }

    protected void ddlHorizontalAlign_SelectedIndexChanged(object sender, EventArgs e) {
        ASPxPopupMenu1.PopupHorizontalAlign = CurrentPopupHorizontalAlign;
    }

    protected void ddlVerticalAlign_SelectedIndexChanged(object sender, EventArgs e) {
        ASPxPopupMenu1.PopupVerticalAlign = CurrentPopupVerticalAlign;
    }
}
