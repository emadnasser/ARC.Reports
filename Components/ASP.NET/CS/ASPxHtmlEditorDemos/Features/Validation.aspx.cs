using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxHtmlEditor;

public partial class Features_Validation : Page {
    public const int MaxLength = 50;
    public string CustomErrorText = string.Format("Custom validation fails because the HTML content's length exceeds {0} characters.", MaxLength);

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            DemoHtmlEditor.Html = HtmlEditorUtils.GetHtml(Page, "Features/Validation.html");
        DemoHtmlEditor.SettingsValidation.RequiredField.IsRequired = chbIsRequired.Checked;
        lblContentLength.Text = DemoHtmlEditor.Html.Length.ToString();
    }

    protected void DemoHtmlEditor_Validation(object sender, HtmlEditorValidationEventArgs e) {
        if(chbValidateOnServer.Checked && e.Html.Length > MaxLength) {
            e.IsValid = false;
            e.ErrorText = CustomErrorText;
        }
    }
}
