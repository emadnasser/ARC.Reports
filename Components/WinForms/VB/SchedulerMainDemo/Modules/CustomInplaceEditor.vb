Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Demos.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class CustomInplaceEditorModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
		End Sub
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Private Sub CustomInplaceEditorModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			CarsDataHelper.FillData(schedulerControl, schedulerStorage)
		End Sub
		Private Sub schedulerControl_InplaceEditorShowing(ByVal sender As Object, ByVal e As InplaceEditorEventArgs) Handles schedulerControl.InplaceEditorShowing
			Dim inplaceEditor As New MyInplaceEditorControl(e.SchedulerInplaceEditorEventArgs)
			inplaceEditor.SetMenuManager(Me.schedulerControl.MenuManager)
			e.InplaceEditorEx = inplaceEditor
		End Sub
	End Class
	Public Class MyInplaceEditorControl
		Implements ISchedulerInplaceEditorEx
		Private editor_Renamed As MyInplaceEditor
		Private appointment_Renamed As Appointment
		Private control_Renamed As SchedulerControl
		Public Sub New(ByVal inplaceEditorArgs As SchedulerInplaceEditorEventArgs)
			Me.appointment_Renamed = inplaceEditorArgs.ViewInfo.Appointment
			Me.control_Renamed = inplaceEditorArgs.Control
			CreateEditor(inplaceEditorArgs)
		End Sub

		Private Custom Event CommitChanges As EventHandler Implements ISchedulerInplaceEditorEx.CommitChanges
			AddHandler(ByVal value As EventHandler)
				AddHandler CommitChangesEvent, value
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				RemoveHandler CommitChangesEvent, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event

		Private Custom Event RollbackChanges As EventHandler Implements ISchedulerInplaceEditorEx.RollbackChanges
			AddHandler(ByVal value As EventHandler)
				AddHandler RollbackChangesEvent, value
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				RemoveHandler RollbackChangesEvent, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event

		Private ReadOnly Property Editor() As MyInplaceEditor
			Get
				Return editor_Renamed
			End Get
		End Property
		Private ReadOnly Property Appointment() As Appointment
			Get
				Return appointment_Renamed
			End Get
		End Property
		Private ReadOnly Property Control() As SchedulerControl
			Get
				Return control_Renamed
			End Get
		End Property

		Private Event CommitChangesEvent As EventHandler
		Private Event RollbackChangesEvent As EventHandler

		Private Sub CreateEditor(ByVal inplaceEditorArgs As SchedulerInplaceEditorEventArgs)
			Me.editor_Renamed = New MyInplaceEditor()
			Editor.Bounds = AdjustEditorBounds(inplaceEditorArgs.Control, inplaceEditorArgs.Bounds)
		End Sub

		Public Sub SetMenuManager(ByVal menuManager As IDXMenuManager)
			SetMenuManagerCore(Editor.Controls, menuManager)
		End Sub
		Private Sub SetMenuManagerCore(ByVal controls As Control.ControlCollection, ByVal menuManager As IDXMenuManager)
			Dim count As Integer = controls.Count
			For i As Integer = 0 To count - 1
				Dim control As Control = controls(i)
				SetMenuManagerCore(control.Controls, menuManager)
				Dim baseEdit As BaseEdit = TryCast(control, BaseEdit)
				If baseEdit Is Nothing Then
					Continue For
				End If
				baseEdit.MenuManager = menuManager
			Next i
		End Sub
		Private Function AdjustEditorBounds(ByVal control As SchedulerControl, ByVal editorBounds As Rectangle) As Rectangle
			Dim screenControlBounds As Rectangle = control.Parent.RectangleToScreen(control.Bounds)
			editorBounds.Offset(0, -3)
			Dim screenEditorBounds As Rectangle = control.RectangleToScreen(editorBounds)

			Dim preferredSize As Size = editor_Renamed.GetPreferredSize(editorBounds.Size)
			Dim height As Integer = Math.Max(preferredSize.Height, editorBounds.Height)
			Dim width As Integer = preferredSize.Width

			Dim rect As Rectangle = screenEditorBounds
			rect.Offset(editorBounds.Width + 6, 0)

			Dim maxBottom As Integer = Math.Min(screenControlBounds.Bottom, rect.Top + height)
			Dim top As Integer = maxBottom - height

			Dim result As New Rectangle(rect.Left, top, width, height)
			If screenControlBounds.Right < rect.Right Then
				Dim horzOffset As Integer = If(TypeOf control.ActiveView Is DayView, 12, 8)
				result = New Rectangle(screenEditorBounds.Left - width - horzOffset, top, width, height)
			End If
			Return result
		End Function
		Private Sub DisposeInplaceEditor()
			DisposeInplaceEditor(True)
			GC.SuppressFinalize(Me)
		End Sub
		Protected Overrides Sub Finalize()
			DisposeInplaceEditor(False)
		End Sub
		Protected Overridable Sub DisposeInplaceEditor(ByVal disposing As Boolean)
			If disposing Then
				If Editor IsNot Nothing Then
					Editor.Dispose()
					Me.editor_Renamed = Nothing
				End If
				Me.appointment_Renamed = Nothing
			End If
		End Sub
		Private Sub ActivateInplaceEditor()
			Editor.FillForm(control_Renamed, appointment_Renamed)
			SubscribeEditorEvents()
			Editor.Show(Control.FindForm())
		End Sub
		Private Sub DeactivateInplaceEditor()
			UnsibscribeEditorEvents()
			Editor.Close()
		End Sub
		Private Sub ApplyChangesInplaceEditor()
			Editor.ApplyChanges()
		End Sub
		Protected Friend Overridable Sub SubscribeEditorEvents()
			AddHandler Editor.FormClosed, AddressOf Editor_FormClosed
			AddHandler Editor.Deactivate, AddressOf Editor_Deactivate
			AddHandler Editor.CommitChanges, AddressOf Editor_CommitChanges
			AddHandler Editor.RollbackChanges, AddressOf Editor_RollbackChanges
		End Sub

		Protected Friend Overridable Sub UnsibscribeEditorEvents()
			RemoveHandler Editor.FormClosed, AddressOf Editor_FormClosed
			RemoveHandler Editor.Deactivate, AddressOf Editor_Deactivate
			RemoveHandler Editor.CommitChanges, AddressOf Editor_CommitChanges
			RemoveHandler Editor.RollbackChanges, AddressOf Editor_RollbackChanges
		End Sub
		Private Sub Editor_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			OnCommitChanges()
		End Sub

		Private Sub Editor_Deactivate(ByVal sender As Object, ByVal e As EventArgs)
			OnCommitChanges()
		End Sub


		Private Sub Editor_RollbackChanges(ByVal sender As Object, ByVal e As EventArgs)
			OnRollbackChanges()
		End Sub

		Private Sub Editor_CommitChanges(ByVal sender As Object, ByVal e As EventArgs)
			OnCommitChanges()
		End Sub
		Protected Friend Overridable Sub TextBox_LostFocus(ByVal sender As Object, ByVal e As EventArgs)
			Editor.Close()
			OnCommitChanges()
		End Sub

		Protected Friend Overridable Sub OnRollbackChanges()
			RaiseEvent RollbackChangesEvent(Me, EventArgs.Empty)
		End Sub
		Protected Friend Overridable Sub OnCommitChanges()
			RaiseCommitChanges()
		End Sub
		Protected Friend Overridable Sub RaiseCommitChanges()
			RaiseEvent CommitChangesEvent(Me, EventArgs.Empty)
		End Sub

		Private Sub Activate() Implements ISchedulerInplaceEditorEx.Activate
			ActivateInplaceEditor()
		End Sub
		Private Sub Deactivate() Implements ISchedulerInplaceEditorEx.Deactivate
			DeactivateInplaceEditor()
		End Sub
		Private Sub ApplyChanges() Implements ISchedulerInplaceEditorEx.ApplyChanges
			ApplyChangesInplaceEditor()
		End Sub

		Private Sub Dispose() Implements IDisposable.Dispose
			DisposeInplaceEditor()
		End Sub
	End Class
End Namespace
