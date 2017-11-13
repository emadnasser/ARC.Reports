using System;
using System.Web.UI;

public partial class Features_MaskedInput : Page {
    protected void Page_Load(object sender, EventArgs e) {
        txtZip.MaskSettings.PromptChar = cmbPromtChar.SelectedItem.Value.ToString()[0];
        dateEdit.EditFormatString = cmbDateType.SelectedItem.Value.ToString();
        dateEdit.Value = DateTime.Now;
    }
}
