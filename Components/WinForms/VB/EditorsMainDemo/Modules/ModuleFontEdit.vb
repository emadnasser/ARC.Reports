Imports System.Collections
Imports System.ComponentModel
' <ceShowCustomButtons>
Imports DevExpress.XtraEditors.Controls
' </ceShowCustomButtons>
Imports DevExpress.Tutorials


Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleFontEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleFontEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "fontEdit.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleCalcEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(fontEditSample)
			InitValues()
			fontEditSample.EditValue = Me.Font.FontFamily.GetName(0)
			cbFontSize.EditValue = fontEditSample.Properties.AppearanceDropDown.Font.Size.ToString()
		End Sub

		Private Sub InitValues()
			updateValues = True
			seRUItemCount.Value = fontEditSample.Properties.RecentlyUsedItemCount
			ceShowSymbolPreview.Checked = fontEditSample.Properties.ShowSymbolFontPreview
			updateValues = False
		End Sub

		'<seRUItemCount>
		Private Sub seRUItemCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seRUItemCount.EditValueChanged
			If updateValues Then
				Return
			End If
			fontEditSample.Properties.RecentlyUsedItemCount = Convert.ToInt32(seRUItemCount.Value)
		End Sub
		'</seRUItemCount>

		'<ceShowSymbolPreview>
		Private Sub ceShowSymbolPreview_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowSymbolPreview.CheckedChanged
			If updateValues Then
				Return
			End If
			fontEditSample.Properties.ShowSymbolFontPreview = ceShowSymbolPreview.Checked
		End Sub

		Private Sub cbFontSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFontSize.SelectedIndexChanged
			If updateValues Then
				Return
			End If
			fontEditSample.Properties.AppearanceDropDown.Font = New Font(DefaultFont.Name, Convert.ToInt32(cbFontSize.EditValue))
		End Sub
		'</ceShowSymbolPreview>
	End Class
End Namespace

