Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class DragDropDataModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Private downHitInfo As GridHitInfo

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			' TODO: Add any initialization after the InitializeComponent call
		End Sub
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Private Sub DragDropDataModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			schedulerControl.GroupType = SchedulerGroupType.Resource
			schedulerStorage.Appointments.ResourceSharing = True
			DemoUtils.FillResources(schedulerStorage, 5)
			grdTasks.DataSource = DemoUtils.GenerateScheduleTasks()
		End Sub
		Private Sub grdTasks_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseDown
			Dim view As GridView = TryCast(sender, GridView)
			downHitInfo = Nothing

			Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
			If Control.ModifierKeys <> Keys.None Then
				Return
			End If
			If e.Button = MouseButtons.Left AndAlso hitInfo.InRow AndAlso hitInfo.HitTest <> GridHitTest.RowIndicator Then
				downHitInfo = hitInfo
			End If
		End Sub

		Private Sub grdTasks_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseMove
			Dim view As GridView = TryCast(sender, GridView)
			If e.Button = MouseButtons.Left AndAlso downHitInfo IsNot Nothing Then
				Dim dragSize As Size = SystemInformation.DragSize
				Dim dragRect As New Rectangle(New Point(CInt(Fix(downHitInfo.HitPoint.X - dragSize.Width / 2)), CInt(Fix(downHitInfo.HitPoint.Y - dragSize.Height / 2))), dragSize)

				If (Not dragRect.Contains(New Point(e.X, e.Y))) Then
					view.GridControl.DoDragDrop(GetDragData(view), DragDropEffects.All)
					downHitInfo = Nothing
				End If
			End If
		End Sub

		Private Sub AddAppointmentLabel(ByVal displayName As String, ByVal menuCaption As String, ByVal color As Color)
			Dim label As IAppointmentLabel = Me.schedulerStorage.Appointments.Labels.CreateNewLabel(displayName)
			label.MenuCaption = menuCaption
			label.SetColor(color)
			Me.schedulerStorage.Appointments.Labels.Add(label)
		End Sub
		Private Sub AddAppointmentStatus(ByVal displayName As String, ByVal menuCaption As String, ByVal type As AppointmentStatusType, ByVal color As Color)
			Dim status As AppointmentStatus = Me.schedulerStorage.Appointments.Statuses.CreateNewStatus("Low")
			status.MenuCaption = menuCaption
			status.Type = type
			status.SetBrush(New SolidBrush(color))
			Me.schedulerStorage.Appointments.Statuses.Add(status)
		End Sub
		Private Function GetDragData(ByVal view As GridView) As SchedulerDragData
			Dim selection() As Integer = view.GetSelectedRows()
			If selection Is Nothing Then
				Return Nothing
			End If

			Dim appointments As New AppointmentBaseCollection()
			Dim count As Integer = selection.Length
			For i As Integer = 0 To count - 1
				Dim rowIndex As Integer = selection(i)
				Dim apt As Appointment = schedulerStorage.CreateAppointment(AppointmentType.Normal)
				apt.Subject = CStr(view.GetRowCellValue(rowIndex, "Subject"))
				apt.LabelKey = CInt(Fix(view.GetRowCellValue(rowIndex, "Severity")))
				apt.StatusKey = CInt(Fix(view.GetRowCellValue(rowIndex, "Priority")))
				apt.Start = DateTime.MinValue
				apt.Duration = TimeSpan.FromHours(CInt(Fix(view.GetRowCellValue(rowIndex, "Duration"))))
				apt.Description = CStr(view.GetRowCellValue(rowIndex, "Description"))
				appointments.Add(apt)
			Next i

			Return New SchedulerDragData(appointments, 0)
		End Function

		Private Sub schedulerControl_AppointmentDrop(ByVal sender As Object, ByVal e As AppointmentDragEventArgs) Handles schedulerControl.AppointmentDrop
			Dim createEventMsg As String = "Creating an event at {0} on {1}."
			Dim moveEventMsg As String = "Moving the event from {0} on {1} to {2} on {3}."

			Dim srcStart As DateTime = e.SourceAppointment.Start
			Dim newStart As DateTime = e.EditedAppointment.Start
			Dim isNewAppointment As Boolean = srcStart = DateTime.MinValue

			Dim msg As String = If(isNewAppointment, String.Format(createEventMsg, newStart.ToShortTimeString(), newStart.ToShortDateString()), String.Format(moveEventMsg, srcStart.ToShortTimeString(), srcStart.ToShortDateString(), newStart.ToShortTimeString(), newStart.ToShortDateString()))

			If XtraMessageBox.Show(msg & Constants.vbCrLf & "Proceed?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
				e.Allow = False
			ElseIf isNewAppointment Then
				Me.schedulerControl.SelectedAppointments.Clear()
				Me.schedulerControl.SelectedAppointments.Add(e.EditedAppointment)
			End If
		End Sub
	End Class
End Namespace
