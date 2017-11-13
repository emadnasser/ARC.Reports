Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web.UI

Partial Public Class Validation_Summary
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ApplyValidationSummarySettings()
		ApplyEditorsSettings()

		If (Not IsPostBack) AndAlso (Not IsCallback) Then
			ASPxEdit.ValidateEditorsInContainer(Me)
		End If
	End Sub

	Private Sub ApplyValidationSummarySettings()
		vsValidationSummary1.RenderMode = CType(System.Enum.Parse(GetType(ValidationSummaryRenderMode), rblRenderMode.SelectedItem.Value.ToString()), ValidationSummaryRenderMode)
		vsValidationSummary1.ShowErrorAsLink = chbShowErrorAsLink.Checked
	End Sub
	Private Sub ApplyEditorsSettings()
		Dim editors() As ASPxEdit = { tbName, deBirthday, cbOccupation, tbEmail }
		For Each editor As ASPxEdit In editors
			editor.ValidationSettings.SetFocusOnError = chbSetFocusOnError.Checked
		Next editor
	End Sub
End Class
