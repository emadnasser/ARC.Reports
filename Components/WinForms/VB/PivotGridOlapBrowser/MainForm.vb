Imports Microsoft.VisualBasic
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports PivotGridOlapBrowser.Commands.UI
Imports System
Imports System.Collections.Generic

Namespace PivotGridOlapBrowser
	Partial Public Class MainForm
		Inherits XtraForm
        Public Sub New()
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, Me) 'DEMO_REMOVE
            InitializeComponent()
            InitializeToolBar()
            InitializeControls()
        End Sub
		Private Sub InitializeControls()
			Me.Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("PivotGridOlapBrowser.AppIcon.ico", GetType(MainForm).Assembly)
			AddHandler Me.pivotGridBrowser1.CommandsUpdate, AddressOf pivotGridBrowser1_CommandsUpdate
			AddHandler Me.pivotGridBrowser1.CommandFailed, AddressOf pivotGridBrowser1_CommandFailed
		End Sub
		Private Sub InitializeToolBar()
			Dim biConnectTo As New ConnectToItem(Me.barManager1, Me.pivotGridBrowser1)
			Dim biReport As New CreateReportItem(Me.barManager1, Me.pivotGridBrowser1)
			Dim biShowChartFromPivot As New ShowChartFromPivotItem(Me.barManager1, Me.pivotGridBrowser1)
			Dim biShowTotals As New ShowTotalsItem(Me.barManager1, Me.pivotGridBrowser1)
			Dim biShowSelection As New ShowSelectionItem(Me.barManager1, Me.pivotGridBrowser1)
			Dim biChartViewSet As New ChartViewSetSubItem(Me.barManager1, Me.pivotGridBrowser1)
			Me.barToolbar.LinksPersistInfo.AddRange(New LinkPersistInfo() { New LinkPersistInfo(biConnectTo), New LinkPersistInfo(biReport), New LinkPersistInfo(biShowChartFromPivot, True), New LinkPersistInfo(biShowTotals, True), New LinkPersistInfo(biShowSelection), New LinkPersistInfo(biChartViewSet, True) })
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			If (Not pivotGridBrowser1.LoadSampleConfiguration()) Then
				bsiStatus.Caption = "Failed to connect to the datasource."
				panelError.Visible = True
				barManager1.Items.Clear()
			Else
				bsiStatus.Caption = "Ready. Sample cube has been loaded."
				panelError.Visible = False
			End If
		End Sub
		Private Sub pivotGridBrowser1_CommandFailed(ByVal sender As Object, ByVal e As CommandFailedEventArgs)
			bsiStatus.Caption = e.Message
		End Sub
		Private Sub pivotGridBrowser1_CommandsUpdate(ByVal sender As Object, ByVal e As CommandsUpdateEventArgs)
			For Each item As BarItem In Me.barManager1.Items
				Dim browserBarItem As IPivotGridBrowserBarItem = TryCast(item, IPivotGridBrowserBarItem)
				If browserBarItem IsNot Nothing Then
					browserBarItem.Update()
				End If
			Next item
		End Sub
		Private Sub pivotGridBrowser1_IsBusyChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pivotGridBrowser1.IsBusyChanged
			SetIsBusy(pivotGridBrowser1.IsBusy)
		End Sub
		Private Sub SetIsBusy(ByVal isBusy As Boolean)
			bsiStatus.Caption = If(isBusy, "Working...", "Ready.")
			bsiStatus.Refresh()
		End Sub
	End Class
End Namespace
