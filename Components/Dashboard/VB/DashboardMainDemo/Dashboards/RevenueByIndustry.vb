Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DashboardCommon

Namespace DashboardMainDemo.Dashboards
	Partial Public Class RevenueByIndustry
		Inherits Dashboard
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub RevenueByIndustry_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
			e.Data = RevenueByIndustryDataHelper.Generate(DataLoader.LoadRevenueByIndustry())

		End Sub
	End Class
End Namespace
