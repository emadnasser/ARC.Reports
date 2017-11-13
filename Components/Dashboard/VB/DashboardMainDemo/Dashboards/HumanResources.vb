Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DataAccess
Imports DevExpress.DashboardCommon

Namespace DashboardMainDemo.Dashboards
	Partial Public Class HumanResources
		Inherits Dashboard
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub HumanResources_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
			Dim data As New HumanResourcesData(DataLoader.LoadEmployees())
			If e.DataSource Is dsEmployees Then
				e.Data = data.EmployeeData
			ElseIf e.DataSource Is dsDepartments Then
				e.Data = data.DepartmentData
			End If
		End Sub
	End Class
End Namespace
