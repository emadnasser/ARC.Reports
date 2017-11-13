using System;
using System.Web.UI;
using DevExpress.Web.Internal;
using DevExpress.Web;

public partial class Validation_Inplace : Page {
    protected void Page_Load(object sender, EventArgs e) {
        ApplySettings();
    }

    private ErrorDisplayMode ErrorDisplayMode {
        get { return (ErrorDisplayMode)Enum.Parse(typeof(ErrorDisplayMode), rblErrorDisplayMode.Value.ToString()); }
    }
    private bool ValidateOnLeave {
        get { return chbValidateOnLeave.Checked; }
    }
    private bool SetFocusOnError {
        get { return chbSetFocusOnError.Checked; }
    }

    protected void OnSettingsChanged(object sender, EventArgs e) {
        ApplySettings();
    }
    private void ApplySettings() {
        ApplySettingsInContainer(serverContainer);
    }
    private void ApplySettingsInContainer(Control container) {
        foreach(Control child in container.Controls) {
            ASPxEdit edit = child as ASPxEdit;
            if(edit != null) {
                edit.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode;
                edit.ValidationSettings.ValidateOnLeave = ValidateOnLeave;
                edit.ValidationSettings.SetFocusOnError = SetFocusOnError;
            } else
                ApplySettingsInContainer(child);
        }
    }    

    protected void NameTextBox_Validation(object sender, ValidationEventArgs e) {
        if((e.Value as string).Length < 2)
            e.IsValid = false;
    }
    protected void AgeTextBox_Validation(object sender, ValidationEventArgs e) {
        if(CommonUtils.IsNullValue(e.Value) || ((string)e.Value == ""))
            return;
        string strAge = ((string)e.Value).TrimStart('0');
        if(strAge.Length == 0)
            return;
        UInt32 age = 0;
        if(!UInt32.TryParse(strAge, out age) || age < 18)
            e.IsValid = false;
    }
    protected void ArrivalDateEdit_Validation(object sender, ValidationEventArgs e) {
        if(!(e.Value is DateTime))
            return;
        DateTime selectedDate = (DateTime)e.Value;
        DateTime currentDate = DateTime.Now;
        if(selectedDate.Year != currentDate.Year || selectedDate.Month != currentDate.Month)
            e.IsValid = false;
    }

}
