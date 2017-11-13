Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DataAccess
Imports DevExpress.DashboardCommon

Namespace DashboardMainDemo.Dashboards
	Partial Public Class SalesDetails
		Inherits Dashboard
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub SalesDetails_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
			Dim dataGenerator As New SalesDetailsDataGenerator(DataLoader.LoadSales())
			dataGenerator.Generate()
			e.Data = dataGenerator.Data
		End Sub
	End Class
End Namespace