Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DataAccess
Imports DevExpress.DashboardCommon

Namespace DashboardMainDemo.Dashboards
	Partial Public Class WebsiteStatistics
		Inherits Dashboard
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub WebsiteStatistics_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
			Dim data As New WebsiteStatisticsDataGenerator()
			e.Data = data.WebsiteStatistics
		End Sub
	End Class
End Namespace
