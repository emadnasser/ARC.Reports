using System;
using DevExpress.Web;
using System.Web.UI;

public partial class Features_DateTimeEditing : Page {
    protected void Page_Load(object sender, EventArgs e)  {
        dateEdit.TimeSectionProperties.Visible = chkShowTimeSection.Checked;
        dateEdit.UseMaskBehavior = chkMaskBehavior.Checked;
        dateEdit.EditFormatString = GetFormatString(cbDateEditFormatString.Value);
        dateEdit.DisplayFormatString = GetFormatString(cbDateDisplayFormatString.Value);

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
    }

    protected string GetFormatString(object value) {
        return value == null ? string.Empty : value.ToString();
    }
}
