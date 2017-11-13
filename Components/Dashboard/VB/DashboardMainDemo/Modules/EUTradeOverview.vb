Imports Microsoft.VisualBasic
Imports DevExpress.DashboardCommon
Imports System.Linq
Imports DevExpress.DashboardWin
Imports DevExpress.XtraCharts

Namespace DashboardMainDemo.Modules
	Partial Public Class EUTradeOverview
		Inherits DashboardTutorialControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub SubscribeDashboardEvents()
			AddHandler DashboardViewer.DashboardItemControlUpdated, AddressOf DashboardViewer_DashboardItemControlUpdated
		End Sub

		Private Sub DashboardViewer_DashboardItemControlUpdated(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardItemControlEventArgs)
			If e.DashboardItemName = "pieImportVsExport" Then
				If e.ChartControl.Series.Count > 0 Then
					CType(e.ChartControl.Series(0).Label, PieSeriesLabel).Position = PieSeriesLabelPosition.Inside
				End If
			End If
		End Sub
	End Class
End Namespace
