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
	Partial Public Class ChampionsLeagueStatistics
		Inherits Dashboard
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub ChampionsLeagueStatistics_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
			e.Data = ChampionsLeagueStatisticsDataHelper.Generate(DataLoader.LoadChampionsLeagueStatistics())
		End Sub
	End Class
End Namespace
