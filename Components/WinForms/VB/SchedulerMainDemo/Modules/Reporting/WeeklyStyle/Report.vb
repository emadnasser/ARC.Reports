Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.WeeklyStyle
	''' <summary>
	''' Summary description for Report.
	''' </summary>
	Partial Public Class Report
		Inherits XtraSchedulerReport

		Public Sub New()

			InitializeComponent()
		End Sub

		Public Property ResourceCount() As Integer
			Get
				Return reportWeekView1.VisibleResourceCount
			End Get
			Set(ByVal value As Integer)
				reportWeekView1.VisibleResourceCount = value
			End Set
		End Property

		Public Property ColumnCount() As Integer
			Get
				Return reportWeekView1.VisibleWeekDayColumnCount
			End Get
			Set(ByVal value As Integer)
				If reportWeekView1.VisibleWeekDayColumnCount = value Then
					Return
				End If
				reportWeekView1.VisibleWeekDayColumnCount = value
				OnColumnCountChanged()
			End Set
		End Property
		Private Sub OnColumnCountChanged()
			If ColumnCount = 2 Then
				Me.timeIntervalInfo1.PrintInColumn = PrintInColumnMode.Odd
				Me.calendarControl1.PrintInColumn = PrintInColumnMode.Even
				Me.timeIntervalInfo1.PrintContentMode = PrintContentMode.AllColumns
			Else
				Me.timeIntervalInfo1.PrintInColumn = PrintInColumnMode.All
				Me.calendarControl1.PrintInColumn = PrintInColumnMode.All
				Me.timeIntervalInfo1.PrintContentMode = PrintContentMode.CurrentColumn
			End If
		End Sub

	End Class
End Namespace
