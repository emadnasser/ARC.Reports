Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports System
Imports System.Web.UI

Partial Public Class Editing_EditModes
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		CardView.SettingsEditing.Mode = CType(System.Enum.Parse(GetType(CardViewEditingMode), EditModeComboBox.Text, True), CardViewEditingMode)

		If (Not IsPostBack) Then
			CardView.StartEdit(1)
		End If
	End Sub
End Class
