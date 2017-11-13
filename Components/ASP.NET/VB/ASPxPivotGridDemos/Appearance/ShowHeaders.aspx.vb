Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxPivotGrid

Partial Public Class Appearance_ShowHeaders
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) AndAlso (Not IsCallback) Then
			SetAreasOptions()
		Else
			ChangeAreasOptions(ASPxPivotGrid1)
		End If
	End Sub

	Private Sub SetAreasOptions()
		cbShowFilterHeaders.Checked = ASPxPivotGrid1.OptionsView.ShowFilterHeaders
		cbShowDataHeaders.Checked = ASPxPivotGrid1.OptionsView.ShowDataHeaders
		cbShowColumnHeaders.Checked = ASPxPivotGrid1.OptionsView.ShowColumnHeaders
		cbShowRowHeaders.Checked = ASPxPivotGrid1.OptionsView.ShowRowHeaders
	End Sub

	Private Sub ChangeAreasOptions(ByVal ASPxPivotGrid1 As ASPxPivotGrid)
		ASPxPivotGrid1.OptionsView.ShowFilterHeaders = cbShowFilterHeaders.Checked
		ASPxPivotGrid1.OptionsView.ShowDataHeaders = cbShowDataHeaders.Checked
		ASPxPivotGrid1.OptionsView.ShowColumnHeaders = cbShowColumnHeaders.Checked
		ASPxPivotGrid1.OptionsView.ShowRowHeaders = cbShowRowHeaders.Checked
	End Sub
End Class
