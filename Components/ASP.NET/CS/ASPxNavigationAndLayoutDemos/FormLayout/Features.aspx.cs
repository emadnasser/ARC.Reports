using System;
using DevExpress.Web;
using DevExpress.Utils;
using System.Web.UI;

public partial class FormLayout_Features : Page
{
    protected void Page_Load(object sender, EventArgs e) {
        exampleFormLayout.RequiredMarkDisplayMode = (RequiredMarkMode)Enum.Parse(typeof(RequiredMarkMode), requiredMarkDisplayModeComboBox.Text);
        exampleFormLayout.RequiredMark = requiredMarkTextBox.Text;
        exampleFormLayout.OptionalMark = optionalMarkTextBox.Text;

        LayoutGroup rootGroup = exampleFormLayout.Items[0] as LayoutGroup;
        foreach(LayoutItem layoutItem in rootGroup.Items) {
            if(!showItemsHelpTextCheckBox.Checked)
                layoutItem.HelpText = string.Empty;
        }

        rootGroup.GroupBoxDecoration = (GroupBoxDecoration)Enum.Parse(typeof(GroupBoxDecoration), groupBoxDecorationComboBox.Text);
        rootGroup.ShowCaption = showGroupCaptionCheckBox.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        rootGroup.SettingsItems.ShowCaption = showItemsCaptionCheckBox.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        rootGroup.SettingsItemCaptions.Location = (LayoutItemCaptionLocation)Enum.Parse(typeof(LayoutItemCaptionLocation), itemsCaptionLocationComboBox.Text);
        rootGroup.SettingsItemCaptions.HorizontalAlign = (FormLayoutHorizontalAlign)Enum.Parse(typeof(FormLayoutHorizontalAlign), itemsCaptionHAlignComboBox.Text);
        rootGroup.SettingsItemCaptions.VerticalAlign = (FormLayoutVerticalAlign)Enum.Parse(typeof(FormLayoutVerticalAlign), itemsCaptionVAlignComboBox.Text);
        rootGroup.SettingsItemHelpTexts.HorizontalAlign = (HelpTextHorizontalAlign)Enum.Parse(typeof(HelpTextHorizontalAlign), helpTextsHAlignComboBox.Text);
        rootGroup.SettingsItemHelpTexts.VerticalAlign = (HelpTextVerticalAlign)Enum.Parse(typeof(HelpTextVerticalAlign), helpTextsVAlignComboBox.Text);
        rootGroup.SettingsItemHelpTexts.Position = (HelpTextPosition)Enum.Parse(typeof(HelpTextPosition), helpTextsPositionComboBox.Text);
    }
}
