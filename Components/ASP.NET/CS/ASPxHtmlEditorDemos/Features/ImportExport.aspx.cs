using System;
using System.Web.UI;

public partial class Features_ImportExport : Page {
    const string DocumentUrl = @"~/Content/Demo/SampleImportDocument.rtf";
    const string ContentFolder = @"~/UploadFiles/Imported";

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Features/ImportExport.html");
            DocumentHyperLink.NavigateUrl = DocumentUrl;
            DocumentHyperLink.Text = DocumentUrl;
            ContentFolderLabel.Text = ContentFolder;
        }
    }
    protected void ImportButton_Click(object sender, EventArgs e) {
        DemoHtmlEditor.Import(
            DocumentUrl,
            ImportStylesComboBox.Value.ToString() == "inline",
            ContentFolder
        );
    }
}
