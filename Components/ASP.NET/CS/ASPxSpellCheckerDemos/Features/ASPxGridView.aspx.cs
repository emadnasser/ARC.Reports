using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class Modules_ASPxGridView : Page {
    const string SessionID = "SCDemo.UpdatedRowMarker";

    protected void Page_Load(object sender, EventArgs e) {
        ASPxWebControl.RegisterBaseScript(Page);
        if(!IsPostBack && !IsCallback)
            ASPxGridView1.StartEdit(1);
    }
    protected void ASPxGridView1_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e) {
        if(CheckSessionUpdateRowMarker(e.KeyValue) &&  (e.Editor is ASPxTextBox || e.Editor is ASPxMemo) && e.Value != null) {
            string text = e.Value.ToString();
            string[] words = text.Split(new char[] { ' ' });
            for(int i = 0; i < words.Length; i++) {
                if(words[i].Length > 5)
                    words[i] += "a";
            }
            e.Editor.Value = string.Join(" ", words);
        }
    }
    protected void SetSessionUpdateRowMarker(object id) {
        string marker = (string)Session[SessionID];
        string newMarker = string.Format("[{0}]", id);
        if(string.IsNullOrEmpty(marker) || !marker.Contains(newMarker)) {
            marker += newMarker;
            Session[SessionID] = marker;
        }
    }
    protected bool CheckSessionUpdateRowMarker(object id) {
        string marker = (string)Session[SessionID];
        return string.IsNullOrEmpty(marker) || !marker.Contains(string.Format("[{0}]", id));
    }
    protected void EmployeesDataSource_Updating(object sender, Microsoft.AspNet.EntityDataSource.EntityDataSourceChangingEventArgs e) {
        SetSessionUpdateRowMarker((e.Entity as Employee).EmployeeID);
    }
}
