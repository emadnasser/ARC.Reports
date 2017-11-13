Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports DevExpress.Utils
Imports System.Web.UI

Partial Public Class FormLayout_Features
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		exampleFormLayout.RequiredMarkDisplayMode = CType(System.Enum.Parse(GetType(RequiredMarkMode), requiredMarkDisplayModeComboBox.Text), RequiredMarkMode)
		exampleFormLayout.RequiredMark = requiredMarkTextBox.Text
		exampleFormLayout.OptionalMark = optionalMarkTextBox.Text

		Dim rootGroup As LayoutGroup = TryCast(exampleFormLayout.Items(0), LayoutGroup)
		For Each layoutItem As LayoutItem In rootGroup.Items
			If (Not showItemsHelpTextCheckBox.Checked) Then
				layoutItem.HelpText = String.Empty
			End If
		Next layoutItem

		rootGroup.GroupBoxDecoration = CType(System.Enum.Parse(GetType(GroupBoxDecoration), groupBoxDecorationComboBox.Text), GroupBoxDecoration)
		rootGroup.ShowCaption = If(showGroupCaptionCheckBox.Checked, DefaultBoolean.True, DefaultBoolean.False)
		rootGroup.SettingsItems.ShowCaption = If(showItemsCaptionCheckBox.Checked, DefaultBoolean.True, DefaultBoolean.False)
		rootGroup.SettingsItemCaptions.Location = CType(System.Enum.Parse(GetType(LayoutItemCaptionLocation), itemsCaptionLocationComboBox.Text), LayoutItemCaptionLocation)
		rootGroup.SettingsItemCaptions.HorizontalAlign = CType(System.Enum.Parse(GetType(FormLayoutHorizontalAlign), itemsCaptionHAlignComboBox.Text), FormLayoutHorizontalAlign)
		rootGroup.SettingsItemCaptions.VerticalAlign = CType(System.Enum.Parse(GetType(FormLayoutVerticalAlign), itemsCaptionVAlignComboBox.Text), FormLayoutVerticalAlign)
		rootGroup.SettingsItemHelpTexts.HorizontalAlign = CType(System.Enum.Parse(GetType(HelpTextHorizontalAlign), helpTextsHAlignComboBox.Text), HelpTextHorizontalAlign)
		rootGroup.SettingsItemHelpTexts.VerticalAlign = CType(System.Enum.Parse(GetType(HelpTextVerticalAlign), helpTextsVAlignComboBox.Text), HelpTextVerticalAlign)
		rootGroup.SettingsItemHelpTexts.Position = CType(System.Enum.Parse(GetType(HelpTextPosition), helpTextsPositionComboBox.Text), HelpTextPosition)
	End Sub
End Class
