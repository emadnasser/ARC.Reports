Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Commands

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class SchedulerRibbonBarsModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			schedulerControl.DayView.ShowWorkTimeOnly = True
			schedulerControl.WorkWeekView.ShowWorkTimeOnly = True
			' TODO: Add any initialization after the InitializeComponent call
		End Sub
		Public Overrides Property AutoMergeRibbon() As Boolean
			Get
				Return False
			End Get
			Set(ByVal value As Boolean)
			End Set
		End Property
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Private Sub SchedulerBarsModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			CarsDataHelper.FillData(schedulerControl, schedulerStorage)
		End Sub

		Private Sub ribbonControl1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
			Dim command As New CommitAndCloseInplaceEditorCommand(schedulerControl)
			command.Execute()
		End Sub
	End Class
End Namespace

