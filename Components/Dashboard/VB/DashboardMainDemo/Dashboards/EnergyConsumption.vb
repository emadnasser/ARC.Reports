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
	Partial Public Class EnergyConsumption
		Inherits Dashboard
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub EnergyConsumption_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
			If e.DataSource Is dsConsumptionTotal Then
				e.Data = EnergyConsumptionDataHelper.GenerateTotal(DataLoader.LoadEnergyConsumptionTotal())
			ElseIf e.DataSource Is dsConsumptionBySector Then
				e.Data = EnergyConsumptionDataHelper.GenerateBySector(DataLoader.LoadEnergyConsumptionBySector())
			End If
		End Sub
	End Class
End Namespace
