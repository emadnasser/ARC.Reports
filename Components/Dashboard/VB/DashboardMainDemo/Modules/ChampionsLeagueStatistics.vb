Imports Microsoft.VisualBasic
Imports DevExpress.DashboardCommon
Imports System.Linq

Namespace DashboardMainDemo.Modules
	Partial Public Class ChampionsLeagueStatistics
		Inherits DashboardTutorialControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub SubscribeDashboardEvents()
			AddHandler DashboardViewer.MasterFilterDefaultValues, AddressOf OnDashboardViewerMasterFilterDefaultValues
		End Sub

		Private Sub OnDashboardViewerMasterFilterDefaultValues(ByVal sender As Object, ByVal e As MasterFilterDefaultValuesEventArgs)
			If e.ItemComponentName = "scatterChartLeagueStatistics" Then
				Dim selRow As DashboardDataRow = e.AvailableFilterValues.FirstOrDefault(Function(row) Object.Equals(row(0), "Spain"))
				If selRow IsNot Nothing Then
					e.FilterValues = New DashboardDataRow() { selRow }
				End If
			End If
		End Sub
	End Class
End Namespace
