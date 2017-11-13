using System;
using System.Web.UI;

public partial class DateTime_DateEditor : Page {
    protected void Page_Load(object sender, EventArgs e) {
        dateEdit.TimeSectionProperties.Visible = chkShowTimeSection.Checked;
        dateEdit.UseMaskBehavior = chkMaskBehavior.Checked;
        dateEdit.EditFormatString = GetFormatString(cbDateEditFormatString.Value);
        dateEdit.DisplayFormatString = GetFormatString(cbDateDisplayFormatString.Value);
    }
    protected string GetFormatString(object value) {
        return value == null ? string.Empty : value.ToString();
    }
}
