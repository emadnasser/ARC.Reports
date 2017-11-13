using System;
using DevExpress.Web;
using System.Web.UI;

public partial class Validation_Summary : Page {
    protected void Page_Load(object sender, EventArgs e) {
        ApplyValidationSummarySettings();
        ApplyEditorsSettings();

        if(!IsPostBack && !IsCallback)
            ASPxEdit.ValidateEditorsInContainer(this);
    }

    private void ApplyValidationSummarySettings() {
        vsValidationSummary1.RenderMode = (ValidationSummaryRenderMode)Enum.Parse(typeof(ValidationSummaryRenderMode), rblRenderMode.SelectedItem.Value.ToString());
        vsValidationSummary1.ShowErrorAsLink = chbShowErrorAsLink.Checked;
    }
    private void ApplyEditorsSettings() {
        ASPxEdit[] editors = new ASPxEdit[] { tbName, deBirthday, cbOccupation, tbEmail };
        foreach(ASPxEdit editor in editors)
            editor.ValidationSettings.SetFocusOnError = chbSetFocusOnError.Checked;
    }
}
