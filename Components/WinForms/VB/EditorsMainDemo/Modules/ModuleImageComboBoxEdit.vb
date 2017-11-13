Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors
' <icbAlignment>
' <icbShowDropDown>
' <imageComboBoxEdit1>
Imports DevExpress.XtraEditors.Controls
' </imageComboBoxEdit1>
' </icbShowDropDown>
Imports DevExpress.Utils
' </icbAlignment>


Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleImageComboBoxEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleImageComboBoxEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "imagecomboboxedit.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleImageComboBoxEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DevExpress.Tutorials.ControlUtils.CenterControlInParent(imageComboBoxEditSample)
			InitSamples()
			InitComboBoxes()
			InitValues()
		End Sub

		Private Sub InitSamples()
			imageComboBoxEdit2.Properties.Items.AddEnum(GetType(ButtonPredefines))
		End Sub

		Private Sub InitComboBoxes()
			' <icbShowDropDown>
			icbShowDropDown.Properties.Items.AddEnum(GetType(ShowDropDown))
			' </icbShowDropDown>
			' <icbAlignment>
			icbAlignment.Properties.Items.AddEnum(GetType(HorzAlignment))
			' </icbAlignment>
			' <icbHighlightedItemStyle>
			icbHighlightedItemStyle.Properties.Items.AddEnum(GetType(HighlightStyle))
			' </icbHighlightedItemStyle>
		End Sub


		Private Sub InitValues()
			updateValues = True
			imageComboBoxEditSample.SelectedIndex = 0
			imageComboBoxEdit1.SelectedIndex = 2
			imageComboBoxEdit2.SelectedIndex = 0
			imageComboBoxEdit3.SelectedIndex = 0
			icbShowDropDown.EditValue = imageComboBoxEditSample.Properties.ShowDropDown
			icbHighlightedItemStyle.EditValue = imageComboBoxEditSample.Properties.HighlightedItemStyle
			seDropDownRows.Value = imageComboBoxEditSample.Properties.DropDownRows
			ceAutoComplete.Checked = imageComboBoxEditSample.Properties.AutoComplete
			ceCycleOnDblClick.Checked = imageComboBoxEditSample.Properties.CycleOnDblClick
			ceHotTrackItems.Checked = imageComboBoxEditSample.Properties.HotTrackItems
			ceImmediatePopup.Checked = imageComboBoxEditSample.Properties.ImmediatePopup
			cePopupSizeable.Checked = imageComboBoxEditSample.Properties.PopupSizeable
			ceCTRLScroll.Checked = imageComboBoxEditSample.Properties.UseCtrlScroll
			icbAlignment.EditValue = imageComboBoxEditSample.Properties.GlyphAlignment
			seDropDownRows.Enabled = Not imageComboBoxEditSample.Properties.PopupSizeable
			ceCycleOnDblClick.Enabled = imageComboBoxEditSample.Properties.ShowDropDown = ShowDropDown.Never
			updateValues = False
		End Sub

		' <icbShowDropDown>
		Private Sub icbShowDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbShowDropDown.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageComboBoxEditSample.Properties.ShowDropDown = CType(icbShowDropDown.EditValue, ShowDropDown)
			' <ceCycleOnDblClick>
			ceCycleOnDblClick.Enabled = imageComboBoxEditSample.Properties.ShowDropDown = ShowDropDown.Never
			' </ceCycleOnDblClick>
		End Sub
		' </icbShowDropDown>
		' <seDropDownRows>
		Private Sub seDropDownRows_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seDropDownRows.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageComboBoxEditSample.Properties.DropDownRows = Convert.ToInt32(seDropDownRows.Value)
		End Sub
		' </seDropDownRows>

		' <ceAutoComplete>
		Private Sub ceAutoComplete_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceAutoComplete.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageComboBoxEditSample.Properties.AutoComplete = ceAutoComplete.Checked
		End Sub
		' </ceAutoComplete>

		' <ceCycleOnDblClick>
		Private Sub ceCycleOnDblClick_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceCycleOnDblClick.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageComboBoxEditSample.Properties.CycleOnDblClick = ceCycleOnDblClick.Checked
		End Sub
		' </ceCycleOnDblClick>

		' <ceHotTrackItems>
		Private Sub ceHotTrackItems_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceHotTrackItems.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageComboBoxEditSample.Properties.HotTrackItems = ceHotTrackItems.Checked
		End Sub
		' </ceHotTrackItems>

		' <ceImmediatePopup>
		Private Sub ceImmediatePopup_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceImmediatePopup.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageComboBoxEditSample.Properties.ImmediatePopup = ceImmediatePopup.Checked
		End Sub
		' </ceImmediatePopup>

		' <cePopupSizeable>
		Private Sub cePopupSizeable_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cePopupSizeable.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageComboBoxEditSample.Properties.PopupSizeable = cePopupSizeable.Checked
			' <seDropDownRows>
			seDropDownRows.Enabled = Not cePopupSizeable.Checked
			' </seDropDownRows>
		End Sub
		' </cePopupSizeable>

		' <ceCTRLScroll>
		Private Sub ceCTRLScroll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceCTRLScroll.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageComboBoxEditSample.Properties.UseCtrlScroll = ceCTRLScroll.Checked
		End Sub
		' </ceCTRLScroll>

		' <icbAlignment>
		Private Sub icbAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbAlignment.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageComboBoxEditSample.Properties.GlyphAlignment = CType(icbAlignment.EditValue, HorzAlignment)
		End Sub
		' </icbAlignment>

		' <ceLargeImages>
		Private Sub ceLargeImages_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceLargeImages.CheckedChanged
			imageComboBoxEditSample.Properties.LargeImages = If(ceLargeImages.Checked, imcLarge, Nothing)
		End Sub
		' </ceLargeImages>

		' <imageComboBoxEdit1>
		Private Sub ShowValues(ByVal edit As TextEdit, ByVal comboBox As ImageComboBoxEdit)
			If comboBox Is Nothing Then
				Return
			End If
			Dim item As ImageComboBoxItem = TryCast(comboBox.SelectedItem, ImageComboBoxItem)
			If item IsNot Nothing Then
				edit.Text = String.Format("{0} / {1} / ""{2}""", comboBox.SelectedIndex, item.Value, item.Description)
			Else
				edit.Text = "Item is null"
			End If
		End Sub

		Private Sub imageComboBoxEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles imageComboBoxEdit1.EditValueChanged
			ShowValues(teImageComboBoxEdit1, TryCast(sender, ImageComboBoxEdit))
		End Sub
		' </imageComboBoxEdit1>

		Private Sub imageComboBoxEdit2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles imageComboBoxEdit2.EditValueChanged
			ShowValues(teImageComboBoxEdit2, TryCast(sender, ImageComboBoxEdit))
		End Sub

		Private Sub imageComboBoxEdit3_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles imageComboBoxEdit3.EditValueChanged
			ShowValues(teImageComboBoxEdit3, TryCast(sender, ImageComboBoxEdit))
		End Sub

		' <icbHighlightedItemStyle>
		Private Sub icbHighlightedItemStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbHighlightedItemStyle.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageComboBoxEditSample.Properties.HighlightedItemStyle = CType(icbHighlightedItemStyle.EditValue, HighlightStyle)
		End Sub
		' </icbHighlightedItemStyle>
	End Class
End Namespace

