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

public partial class Features_ContentElementFiltering: Page {
    static List<string> Tags = new List<string>(new string[] { "div", "p", "h1", "h2", "h3", "h4", "h5", "h6", "span", "font", "br", "ol", "ul", "li", "table", "tbody", "thead", "td", "tr", "th", "img", "address", "a", "b", "strong", "i", "em" });
    static List<string> Attributes = new List<string>(new string[] { "align", "class", "cellspacing", "cellpadding", "colspan", "id", "scope", "style", "src", "href", "rowspan", "title", "width", "height" });
    static List<string> StyleAttributes = new List<string>(new string[] { "font-size", "font-family", "border", "padding", "margin-top", "vertical-align", "text-align", "width", "height", "color", "background-color", "box-shadow", "line-height" });

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            InitTokenBox(TagTokenBox, Tags);
            InitTokenBox(AttributeTokenBox, Attributes);
            InitTokenBox(StyleAttributeTokenBox, StyleAttributes);
            HtmlEditor.Html = GetDocumentHtml();
        }
        HtmlEditor.SettingsHtmlEditing.ContentElementFiltering.Tags = TagTokenBox.Tokens.ToArray();
        HtmlEditor.SettingsHtmlEditing.ContentElementFiltering.TagFilterMode = (HtmlEditorFilterMode)(int)TagFilterModeComboBox.Value;
        HtmlEditor.SettingsHtmlEditing.ContentElementFiltering.Attributes = AttributeTokenBox.Tokens.ToArray();
        HtmlEditor.SettingsHtmlEditing.ContentElementFiltering.AttributeFilterMode = (HtmlEditorFilterMode)(int)AttributeFilterModeComboBox.Value;
        HtmlEditor.SettingsHtmlEditing.ContentElementFiltering.StyleAttributes = StyleAttributeTokenBox.Tokens.ToArray();
        HtmlEditor.SettingsHtmlEditing.ContentElementFiltering.StyleAttributeFilterMode = (HtmlEditorFilterMode)(int)StyleAttributeFilterModeComboBox.Value;
    }
    void InitTokenBox(ASPxTokenBox tokenBox, List<string> itemCollection) {
        itemCollection.Sort();
        tokenBox.Items.AddRange(itemCollection);
        tokenBox.AllowCustomTokens = false;
        tokenBox.AllowMouseWheel = true;
    }
    string GetDocumentHtml() {
        return HtmlEditorUtils.GetHtml(this, "Overview/Blueberry.html", false);
    }
    protected void HtmlEditor_CustomDataCallback(object sender, DevExpress.Web.CustomDataCallbackEventArgs e) {
        e.Result = GetDocumentHtml();
    }
}
