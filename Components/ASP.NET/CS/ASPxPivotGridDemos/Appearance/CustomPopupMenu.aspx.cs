using System;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.ASPxPivotGrid;

public partial class Appearance_CustomPopupMenu : Page {
    protected void Page_Load(object sender, EventArgs e) {

    }
    protected void pivotGrid_PopupMenuCreated(object sender, DevExpress.Web.ASPxPivotGrid.PivotPopupMenuCreatedEventArgs e) {
        if(e.MenuType == DevExpress.Web.ASPxPivotGrid.PivotGridPopupMenuType.FieldValueMenu) {
            MenuItem item = e.Menu.Items.Add("Filter By This Value", "Filter");
            item.BeginGroup = true;
            e.Menu.ClientSideEvents.PopUp =
                @"function ASPxClientMenuItemEventHandler(s, e){
					//MyCode
					if(pivotGrid.fieldMenuFieldValueIndex == -1)
						s.Hide();
				}";
        }
    }
    protected void pivotGrid_CustomCallback(object sender, DevExpress.Web.ASPxPivotGrid.PivotGridCustomCallbackEventArgs e) {
        if(string.IsNullOrEmpty(e.Parameters)) return;
        string[] args = e.Parameters.Split('|');
        switch(args[0]) {
            case "F":
                PivotGridField field = pivotGrid.Fields[args[1]];
                int itemIndex = Int32.Parse(args[2]);
                object filterValue = pivotGrid.GetFieldValueByIndex(field, itemIndex);
                field.FilterValues.ValuesIncluded = new object[] { filterValue };
                break;
        }
    }
}
