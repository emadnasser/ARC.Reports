Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleCheckedComboBoxEdit
		Inherits TutorialControl

		' <checkedComboBoxEdit1>
		<FlagsAttribute> _
		Private Enum Colors
			None = 0
			Red = 1
			Green = 2
			Blue = 4
			Yellow = 8
			Black = 16
		End Enum
		' </checkedComboBoxEdit1>
		' <checkedComboBoxEdit2>
		<Flags> _
		Private Enum Platforms
			Win98 = 16
			Win2000 = 32
			WinNT = 64
			WinXP = 128
			Vista = 256
			<Description("Windows 7")> _
			Win7 = 512
			<Description("Windows 8")> _
			Win8 = 1024
		End Enum
		' </checkedComboBoxEdit2>
		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleCheckedComboBoxEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "checkedcomboboxEdit.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleCheckedComboBoxEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(checkedComboBoxEditSample)
			InitComboBoxes()
			InitValues()
		End Sub

		Private Sub InitComboBoxes()
			Dim editValues() As String = { "Circle", "Rectangle", "Ellipse", "Triangle", "Square" }
			For Each value As String In editValues
				checkedComboBoxEditSample.Properties.Items.Add(value, CheckState.Unchecked, True)
			Next value
			' <icbHighlightedItemStyle>
			icbHighlightedItemStyle.Properties.Items.AddEnum(GetType(HighlightStyle))
			' </icbHighlightedItemStyle>
		End Sub

		Private Sub InitValues()
			updateValues = True
			icbHighlightedItemStyle.EditValue = checkedComboBoxEditSample.Properties.HighlightedItemStyle
			cmbSeparatorChar.EditValue = checkedComboBoxEditSample.Properties.SeparatorChar
			ceSelectAllItem.EditValue = checkedComboBoxEditSample.Properties.SelectAllItemVisible
			teSelectAllItemCaption.EditValue = checkedComboBoxEditSample.Properties.SelectAllItemCaption
			ceShowButtons.Checked = checkedComboBoxEditSample.Properties.ShowButtons
			ceIncrementalSearch.Checked = checkedComboBoxEditSample.Properties.IncrementalSearch
			ceAllowMultiSelect.Checked = checkedComboBoxEditSample.Properties.AllowMultiSelect
			checkedComboBoxEditSample.SetEditValue("Circle, Ellipse")
			updateValues = False
			' <checkedComboBoxEdit1>
			checkedComboBoxEdit1.Properties.SetFlags(GetType(Colors))
			checkedComboBoxEdit1.SetEditValue(Colors.Red Or Colors.Blue Or Colors.Yellow)
			' </checkedComboBoxEdit1>
			' <checkedComboBoxEdit2>
			checkedComboBoxEdit2.Properties.SetFlags(GetType(Platforms))
			checkedComboBoxEdit2.SetEditValue(Platforms.WinXP Or Platforms.Win98)
			' </checkedComboBoxEdit2>
		End Sub

		' <icbHighlightedItemStyle>
		Private Sub icbHighlightedItemStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbHighlightedItemStyle.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			checkedComboBoxEditSample.Properties.HighlightedItemStyle = CType(icbHighlightedItemStyle.EditValue, HighlightStyle)
		End Sub
		' </icbHighlightedItemStyle>

		' <cmbSeparatorChar>
		Private Sub cmbSeparatorChar_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbSeparatorChar.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			checkedComboBoxEditSample.Properties.SeparatorChar = Convert.ToChar(cmbSeparatorChar.EditValue)
		End Sub
		' </cmbSeparatorChar>

		' <ceSelectAllItem>
		Private Sub ceSelectAllItem_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceSelectAllItem.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			checkedComboBoxEditSample.Properties.SelectAllItemVisible = ceSelectAllItem.Checked
		End Sub
		' </ceSelectAllItem>

		Private Sub checkedComboBoxEditSample_CustomDisplayText(ByVal sender As Object, ByVal e As CustomDisplayTextEventArgs) Handles checkedComboBoxEditSample.CustomDisplayText
			If e.DisplayText = String.Empty Then
				e.DisplayText = "Nothing"
			End If
		End Sub

		' <teSelectAllItemCaption>
		Private Sub teSelectAllItemCaption_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles teSelectAllItemCaption.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			checkedComboBoxEditSample.Properties.SelectAllItemCaption = teSelectAllItemCaption.Text
		End Sub
		' </teSelectAllItemCaption>
		Private Sub ceShowButtons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowButtons.CheckedChanged
			If updateValues Then
				Return
			End If
			' </skip>
			checkedComboBoxEditSample.Properties.ShowButtons = ceShowButtons.Checked
		End Sub
		' <ceIncrementalSearch>
		Private Sub ceIncrementalSearch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceIncrementalSearch.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			checkedComboBoxEditSample.Properties.IncrementalSearch = ceIncrementalSearch.Checked
		End Sub
		' </ceIncrementalSearch>
		' <ceAllowMultiSelect>
		Private Sub ceAllowMultiSelect_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowMultiSelect.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			checkedComboBoxEditSample.Properties.AllowMultiSelect = ceAllowMultiSelect.Checked
		End Sub
		' </ceAllowMultiSelect>
	End Class
End Namespace

