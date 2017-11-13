Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DataAccess
Imports DevExpress.DashboardCommon

Namespace DashboardMainDemo.Dashboards
	Partial Public Class SalesPerformance
		Inherits Dashboard
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub SalesPerformance_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
			Dim dataGenerator As New SalesPerformanceDataGenerator(DataLoader.LoadSales())
			dataGenerator.Generate()
			If e.DataSource Is dsMonthlySales Then
				e.Data = dataGenerator.MonthlySales
			ElseIf e.DataSource Is dsTotalSales Then
				e.Data = dataGenerator.TotalSales
			ElseIf e.DataSource Is dsKeyMetrics Then
				e.Data = dataGenerator.KeyMetrics
			End If
		End Sub
	End Class
End Namespace
