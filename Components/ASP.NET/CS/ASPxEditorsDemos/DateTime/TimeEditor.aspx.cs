using System;
using System.Web.UI;
using DevExpress.Web;

public partial class DateTime_TimeEditor : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            Array values = Enum.GetValues(typeof(EditFormat));
            foreach(object value in values)
                cbTimeEditFormat.Items.Add(Enum.GetName(typeof(EditFormat), (int)value));
            cbTimeEditFormat.Value = EditFormat.Custom.ToString();
        }
        EditFormat currentTimeEditFormat = (EditFormat)cbTimeEditFormat.SelectedIndex;

        if(Enum.Equals(currentTimeEditFormat, EditFormat.Custom)) {
            cbTimeEditFormatString.ClientEnabled = true;
            timeEdit.EditFormatString = GetFormatString(cbTimeEditFormatString.Value);
        } else {
            cbTimeEditFormatString.SelectedIndex = 0;
            cbTimeEditFormatString.ClientEnabled = false;
            timeEdit.EditFormatString = string.Empty;
            timeEdit.EditFormat = currentTimeEditFormat;
        }

        timeEdit.DisplayFormatString = GetFormatString(cbTimeDisplayFormatString.Value);
        timeEdit.AllowNull = chkTimeAllowNull.Checked;
    }

    protected string GetFormatString(object value) {
        return value == null ? string.Empty : value.ToString();
    }
}
