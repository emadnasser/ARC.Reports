using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Threading;

public partial class Features_ExternalToolbar: Page {
    const int SelectedDocumentIndex = 1;
    const string SessionKey = "DocumentsDictionary";
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            foreach(string key in DocumentsDictionary.Keys)
                ListBox.Items.Add(key);
            ListBox.SelectedIndex = SelectedDocumentIndex;
            HtmlEditor.Html = DocumentsDictionary[ListBox.SelectedItem.Text];
        }
        else if(IsCallback) {
            // Intentionally pauses server-side processing,
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(500);
        }
    }
    protected void HtmlEditor_CustomDataCallback(object sender, DevExpress.Web.CustomDataCallbackEventArgs e) {
        if(e.Parameter == "SaveChanges")
            DocumentsDictionary[ListBox.SelectedItem.Text] = HtmlEditor.Html;
        else if(e.Parameter == "CancelChanges")
            e.Result = DocumentsDictionary[ListBox.SelectedItem.Text];
    }
    public Dictionary<string, string> DocumentsDictionary {
        get {
            if(Page.Session[SessionKey] == null)
                Page.Session[SessionKey] = CreateDocumentsDictionary();
            return (Dictionary<string, string>)Page.Session[SessionKey];
        }
    }
    Dictionary<string, string> CreateDocumentsDictionary() {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("Halloween", HtmlEditorUtils.GetHtml(this, "ToolbarItems/ComboBox.html"));
        dictionary.Add("Blueberry", HtmlEditorUtils.GetHtml(this, "Overview/Blueberry.html", false));
        dictionary.Add("Fragaria", HtmlEditorUtils.GetHtml(this, "Features/General.html"));
        dictionary.Add("Mushroom", HtmlEditorUtils.GetHtml(this, "Features/CustomToolbar.html"));
        return dictionary;
    }
}
