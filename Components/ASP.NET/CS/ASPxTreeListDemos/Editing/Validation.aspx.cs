using System;
using DevExpress.Web.ASPxTreeList;
using System.Web.UI;

public partial class Editing_Validation : Page {
    const string StringEmptyError = "The value cannot be empty.";

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            NewsGroupDataProvider.Restore();
            NewsGroupDataProvider.Corrupt();
            treeList.DataBind();
            treeList.ExpandToLevel(2);
            treeList.StartEdit("1");
        }
    }

    protected void treeList_NodeValidating(object sender, TreeListNodeValidationEventArgs e) {
        if(!IsStringValueNotEmpty(e.NewValues["From"]))
            e.Errors["From"] = StringEmptyError;
        if(!IsStringValueNotEmpty(e.NewValues["Subject"]))
            e.Errors["Subject"] = StringEmptyError;
        if(!IsDateValid(e.NewValues["DateCreated"]))
            e.Errors["Date"] = "The date must be after 1980 year.";
        if(e.HasErrors)
            e.NodeError = "Please, correct all errors.";
    }
    protected void treeList_StartNodeEditing(object sender, TreeListNodeEditingEventArgs e) {
        treeList.DoNodeValidation();
    }
    protected void treeList_HtmlRowPrepared(object sender, TreeListHtmlRowEventArgs e) {
        if(object.Equals(e.RowKind, TreeListRowKind.Data)) {
            if(!IsStringValueNotEmpty(e.GetValue("From")) || !IsStringValueNotEmpty(e.GetValue("Subject")) || !IsDateValid(e.GetValue("DateCreated")))
                e.Row.ForeColor = System.Drawing.Color.Red;
        }
    }

    bool IsStringValueNotEmpty(object value) {
        return value != null && value.ToString().Trim().Length > 0;
    }
    bool IsDateValid(object value) {
        if(value is DateTime)
            return ((DateTime)value).Year >= 1980;
        return false;
    }
}
