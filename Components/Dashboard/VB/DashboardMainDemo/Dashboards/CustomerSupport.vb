Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DataAccess
Imports DevExpress.DashboardCommon

Namespace DashboardMainDemo.Dashboards
	Partial Public Class CustomerSupport
		Inherits Dashboard
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub CustomerSupport_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
			Dim data As New CustomerSupportData(DataLoader.LoadCustomerSupport(), DataLoader.LoadEmployees())
			e.Data = data.CustomerSupport
		End Sub
	End Class
End Namespace
