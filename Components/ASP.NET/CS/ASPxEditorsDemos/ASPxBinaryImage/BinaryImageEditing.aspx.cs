using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class ASPxBinaryImage_Editing : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        PopulateWithEnumValues<ElementVisibilityMode>(ButtonPanelVisibility);
        PopulateWithEnumValues<BinaryImageButtonPanelPosition>(ButtonPanelPos);
        PopulateWithEnumValues<BinaryImageButtonPosition>(ButtonPosition);
        if(IsPostBack && !string.IsNullOrEmpty(Request.Params.Get("__EVENTTARGET"))) {
            BinaryImage.EditingSettings.AllowDropOnPreview = AllowDropOnPreview.Checked;
            BinaryImage.EditingSettings.ButtonPanelSettings.Position = GetComboBoxEnumValue<BinaryImageButtonPanelPosition>(ButtonPanelPos);
            BinaryImage.EditingSettings.ButtonPanelSettings.Visibility = GetComboBoxEnumValue<ElementVisibilityMode>(ButtonPanelVisibility);
            BinaryImage.EditingSettings.ButtonPanelSettings.ButtonPosition = GetComboBoxEnumValue<BinaryImageButtonPosition>(ButtonPosition);
        }
        EnsureSettingsEditors();
    }
    void EnsureSettingsEditors() {
        ButtonPanelVisibility.SelectedIndex = (int)BinaryImage.EditingSettings.ButtonPanelSettings.Visibility;
        ButtonPanelPos.SelectedIndex = (int)BinaryImage.EditingSettings.ButtonPanelSettings.Position;
        ButtonPanelPos.Enabled = BinaryImage.EditingSettings.ButtonPanelSettings.Visibility != ElementVisibilityMode.None;
        ButtonPosition.SelectedIndex = (int)BinaryImage.EditingSettings.ButtonPanelSettings.ButtonPosition;
        ButtonPosition.Enabled = BinaryImage.EditingSettings.ButtonPanelSettings.Visibility != ElementVisibilityMode.None;
        AllowDropOnPreview.Value = BinaryImage.EditingSettings.AllowDropOnPreview;
    }
    static T GetComboBoxEnumValue<T>(ASPxComboBox comboBox) {
        if(comboBox.SelectedIndex < 0)
            comboBox.SelectedIndex = 1;
        var value = (string)comboBox.Value;
        return (T)Enum.Parse(typeof(T), value);
    }
    static void PopulateWithEnumValues<T>(ASPxComboBox comboBox) {
        comboBox.DataSource = Enum.GetValues(typeof(T));
        comboBox.DataBind();
    }
}
