Imports Microsoft.VisualBasic
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraScheduler.Commands
Imports System

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class TimeZonesModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			AddHandler Me.schedulerControl.PopupMenuShowing, AddressOf schedulerControl_PopupMenuShowing
			' TODO: Add any initialization after the InitializeComponent call
		End Sub
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Private Sub TimeZonesModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			CarsDataHelper.FillData(schedulerControl, schedulerStorage)
			UpdateControls()
		End Sub

		Private Sub UpdateControls()
			schedulerControl.DayView.TimeRulers(1).UseClientTimeZone = False
			schedulerControl.WorkWeekView.TimeRulers(1).UseClientTimeZone = False
			edtTimeZone.TimeZoneId = schedulerControl.OptionsBehavior.ClientTimeZoneId
		End Sub
		Private Sub edtTimeZone_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtTimeZone.EditValueChanged
			schedulerControl.OptionsBehavior.ClientTimeZoneId = edtTimeZone.TimeZoneId
			Dim caption As String = schedulerControl.OptionsBehavior.ClientTimeZoneId.ToString()
			schedulerControl.DayView.TimeRulers(2).Caption = caption
			schedulerControl.WorkWeekView.TimeRulers(2).Caption = caption
			schedulerControl.FullWeekView.TimeRulers(2).Caption = caption
		End Sub
		Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
			If e.Menu.Id = DevExpress.XtraScheduler.SchedulerMenuItemId.AppointmentMenu Then
				Dim command As New SplitAppointmentOperationCommand(schedulerControl)
				Dim menuItemCommandAdapter As New SchedulerMenuItemCommandWinAdapter(command)
				Dim menuItem As DXMenuItem = CType(menuItemCommandAdapter.CreateMenuItem(DXMenuItemPriority.Normal), DXMenuItem)
				menuItem.BeginGroup = True
				e.Menu.Items.Add(menuItem)
			End If
		End Sub
	End Class
End Namespace

