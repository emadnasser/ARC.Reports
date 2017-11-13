Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Threading

Partial Public Class Docking_Callbacks
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsCallback Then
			' Intentionally pauses server-side processing,
			' to demonstrate the Loading Panel functionality.
			Thread.Sleep(500)
		End If
	End Sub

	Protected Sub employeesPanel_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim controlUrl As String = "~/Docking/Callbacks/FloatModeContent.ascx"
		If employeesPanel.OwnerZone IsNot Nothing Then
			If employeesPanel.OwnerZone.Equals(designDepartmentZone) Then
				controlUrl = "~/Docking/Callbacks/DesignDepartmentEmployees.ascx"
			ElseIf employeesPanel.OwnerZone.Equals(developmentDepartmentZone) Then
				controlUrl = "~/Docking/Callbacks/DevelopmentDepartmentEmployees.ascx"
			End If
		End If

		employeesPanel.Controls.Clear()
		employeesPanel.Controls.Add(LoadControl(controlUrl))
	End Sub
End Class
