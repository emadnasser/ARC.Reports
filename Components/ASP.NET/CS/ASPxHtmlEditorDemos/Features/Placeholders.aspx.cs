using System;
using System.Web.UI;
using System.Collections.Generic;
using System.Data;
using DevExpress.Internal;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using DevExpress.Web;
using DevExpress.Web.ASPxHtmlEditor;
using System.Linq;

public partial class Features_Placeholders: Page {
    const int SelectedIndex = 1;
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditor.Html = HtmlEditorUtils.GetHtml(this, "Features/TemplateHtml.html");
            HtmlEditor.Settings.AllowPreview = false;
            InitListBox(ListBox);
        }
    }
    protected void RoundPanel_ContentCallback(object source, RoundPanelContentCallbackEventArgs e) {
        var context = new NorthwindContext();
        Employee employee = context.Employees.First(s=> s.FirstName == e.Parameter);
        var html = ASPxHtmlEditor.ReplacePlaceholders(HtmlEditor.Html, employee);
        RoundPanel.Controls.Add(new LiteralControl(html));
    }

    void InitListBox(ASPxListBox ListBox) {
        var context = new NorthwindContext();
        foreach(Employee employee in context.Employees)
            ListBox.Items.Add(string.Format("{0}: {1}", employee.FirstName, employee.HomePhone), employee.FirstName);
        ListBox.ClientEnabled = false;
        ListBox.SelectedIndex = SelectedIndex;
    }
}
