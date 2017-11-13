using System;
using System.Web.UI;
using DevExpress.Web;

public partial class TitleIndex_Filtering : Page {
    FilterBoxPosition CurrentFilterBoxHorizontalPosition {
        get {
            return (FilterBoxPosition)Enum.Parse(typeof(FilterBoxPosition), 
                ddlHorizontalPosition.SelectedItem.Value.ToString());
        }
    }
    FilterBoxVerticalPosition CurrentFilterBoxVerticalPosition {
        get {
            return (FilterBoxVerticalPosition)Enum.Parse(typeof(FilterBoxVerticalPosition), 
                ddlVerticalPosition.SelectedItem.Value.ToString());    
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            return;
        titleIndex.SoftFiltering = cbSoftFiltering.Checked;
        titleIndex.FilterBox.HorizontalPosition = CurrentFilterBoxHorizontalPosition;
        titleIndex.FilterBox.VerticalPosition = CurrentFilterBoxVerticalPosition;
    }
    
    protected void btnApply_Click(object sender, EventArgs e) {
        titleIndex.FilterBox.Delay = (int)seDelay.Number;
    }
}
