Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxScheduler
Imports SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType
Imports TimeScaleCollection = DevExpress.XtraScheduler.TimeScaleCollection
Imports TimeScaleWeek = DevExpress.XtraScheduler.TimeScaleWeek
Imports TimeScaleMonth = DevExpress.XtraScheduler.TimeScaleMonth

Partial Public Class Miscellaneous_CellAutoHeight
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SchedulerDemoUtils.ApplyDefaults(Me, ASPxScheduler1)
		DataHelper.SetupDefaultMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource)
		DataHelper.SetupStatuses(ASPxScheduler1)
		DataHelper.SetupLabels(ASPxScheduler1)
		ApplyCellAutoHeightMode()
		ASPxScheduler1.DataBind()
	End Sub
	Private Sub SetUpTimelineTimescale()
		Dim scales As TimeScaleCollection = ASPxScheduler1.TimelineView.Scales
		scales.BeginUpdate()
		scales.Clear()
		Dim week As New TimeScaleWeek()
		week.Visible = False
		scales.Add(week)
		Dim month As New TimeScaleMonth()
		scales.Add(month)
		scales.EndUpdate()
	End Sub
	Private Sub ApplyCellAutoHeightMode()
		ASPxScheduler1.BeginUpdate()
		Try
			Dim typeAsString As String = TryCast(rbCellAutoHeghtMode.Value, String)
			Dim viewTypes() As SchedulerViewType = { SchedulerViewType.Week, SchedulerViewType.Month, SchedulerViewType.Timeline}
			Dim mode As AutoHeightMode = CType(System.Enum.Parse(GetType(AutoHeightMode), typeAsString), AutoHeightMode)

			For Each viewType As SchedulerViewType In viewTypes
				Dim view As DevExpress.Web.ASPxScheduler.SchedulerViewBase = ASPxScheduler1.Views(viewType)
				Dim options As ASPxSchedulerOptionsCellAutoHeight = GetCellAutoHeightOptions(view)
				If options Is Nothing Then
					Continue For
				End If
				SetCellAutoHeightOptions(mode, options)
			Next viewType
		Finally
			ASPxScheduler1.EndUpdate()
		End Try
		ASPxScheduler1.ApplyChanges(ASPxSchedulerChangeAction.All)
	End Sub

	Private Function GetCellAutoHeightOptions(ByVal view As SchedulerViewBase) As ASPxSchedulerOptionsCellAutoHeight
		Dim weekView As WeekView = TryCast(view, WeekView)
		If weekView IsNot Nothing Then
			Return weekView.CellAutoHeightOptions
		End If
		Dim monthView As MonthView = TryCast(view, MonthView)
		If monthView IsNot Nothing Then
			Return monthView.CellAutoHeightOptions
		End If
		Dim timelineView As TimelineView = TryCast(view, TimelineView)
		If timelineView IsNot Nothing Then
			Return timelineView.CellAutoHeightOptions
		End If
		Return Nothing
	End Function
	Private Sub SetCellAutoHeightOptions(ByVal mode As AutoHeightMode, ByVal options As ASPxSchedulerOptionsCellAutoHeight)
		options.Mode = mode
		options.MinHeight = 100
		options.MaxHeight = 230
	End Sub

End Class
