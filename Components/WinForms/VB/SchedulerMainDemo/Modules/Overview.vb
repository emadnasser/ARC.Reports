Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports System.Data.Entity
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Data
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class OverviewModule
		Inherits TutorialControl
		Private downHitInfo As GridHitInfo
		Private dataContext As MedicScheduleContext

		Public Sub New()
			InitializeComponent()
			Me.schedulerControl1.Start = MedicScheduleDataHelper.BaseDate
			MedicScheduleDataHelper.CreateLabels(Me.schedulerStorage1)
			MedicScheduleDataHelper.CreateStatuses(Me.schedulerStorage1)
			Me.dataContext = New MedicScheduleContext()
			Me.dataContext.LoadData()
			InitializeMappings()
			Me.schedulerStorage1.Resources.DataSource = Me.dataContext.Medics.Local.ToBindingList()
			Me.schedulerStorage1.Appointments.DataSource = Me.dataContext.MedicalAppointments.Local.ToBindingList()

			InitializePatinetGrid()
			InitializeGalleryControl()
			Me.gridView1.Columns("Name").SortOrder = ColumnSortOrder.Ascending

			AddHandler Me.schedulerStorage1.AppointmentsChanged, AddressOf schedulerStorage1_AppointmentsChanged
			AddHandler Me.schedulerStorage1.AppointmentsInserted, AddressOf schedulerStorage1_AppointmentsChanged
			AddHandler Me.schedulerStorage1.AppointmentsDeleted, AddressOf schedulerStorage1_AppointmentsChanged
			AddHandler Me.schedulerControl1.CustomDrawResourceHeader, AddressOf schedulerControl1_CustomDrawResourceHeader
			AddHandler Me.schedulerControl1.InitAppointmentDisplayText, AddressOf schedulerControl1_InitAppointmentDisplayText
			AddHandler Me.schedulerControl1.AllowAppointmentConflicts, AddressOf schedulerControl1_AllowAppointmentConflicts
			AddHandler Me.schedulerControl1.AppointmentDrop, AddressOf schedulerControl1_AppointmentDrop

			AddHandler Me.galleryControl1.Gallery.ItemCheckedChanged, AddressOf Gallery_ItemCheckedChanged
			AddHandler Me.Resize, AddressOf OverviewModule_Resize
			UpdateSize()
		End Sub

		Private Sub InitializeMappings()
			Dim appointmentMapping As AppointmentMappingInfo = Me.schedulerStorage1.Appointments.Mappings
			appointmentMapping.AllDay = "AllDay"
			appointmentMapping.Description = "Note"
			appointmentMapping.Subject = ""
			appointmentMapping.Start = "StartTime"
			appointmentMapping.End = "EndTime"
			appointmentMapping.Label = "IssueId"
			appointmentMapping.Location = "Location"
			appointmentMapping.RecurrenceInfo = "RecurrenceInfo"
			appointmentMapping.ReminderInfo = "ReminderInfo"
			appointmentMapping.ResourceId = "MedicId"
			appointmentMapping.Status = "PaymentStatusId"
			appointmentMapping.Type = "EventType"

			Dim сustomFieldMapping As New AppointmentCustomFieldMapping()
			сustomFieldMapping.Name = "Patient"
			сustomFieldMapping.ValueType = FieldValueType.Object
			сustomFieldMapping.Member = "Patient"
			Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(сustomFieldMapping)

			Dim resourceMapping As ResourceMappingInfo = Me.schedulerStorage1.Resources.Mappings
			resourceMapping.Id = "Id"
			resourceMapping.Caption = "Name"
			resourceMapping.Image = "PhotoBytes"
		End Sub

		Private Sub InitializeGalleryControl()
			Dim resources As ResourceCollection = schedulerStorage1.Resources.Items
			Dim groups As GalleryItemGroupCollection = Me.galleryControlClient1.Gallery.Groups
			For Each resource As Resource In resources
				Dim medic As Medic = TryCast(resource.GetRow(Me.schedulerStorage1), Medic)
				If medic Is Nothing Then
					Continue For
				End If
				Dim group As GalleryItemGroup = groups.FirstOrDefault(Function(g) Object.Equals(g.Tag, medic.DepartmentId))
				If group Is Nothing Then
					group = CreateGalleryItemGroup(medic.DepartmentId)
					groups.Add(group)
				End If
				Dim item As New GalleryItem(resource.GetImage(), medic.Name, medic.Phone)
				item.Value = medic.Id
				item.Checked = group.Caption = "Therapy"
				resource.Visible = item.Checked
				group.Items.Add(item)
			Next resource
		End Sub

		Private Function CreateGalleryItemGroup(ByVal id As Object) As GalleryItemGroup
			Dim group As New GalleryItemGroup()
			Dim department As HospitalDepartment = Me.dataContext.HospitalDepartments.Find(id)
			If department Is Nothing Then
				department = New HospitalDepartment()
			End If
			group.Caption = department.Name
			group.Tag = department.Id
			Return group
		End Function

		Private Sub InitializePatinetGrid()
			Me.gridControl1.DataSource = Me.dataContext.Patients.ToList()
		End Sub

		Private Sub Gallery_ItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
			Dim resources As ResourceStorage = schedulerStorage1.Resources
			Dim item As GalleryItem = e.Item
			Dim resource As Resource = resources.GetResourceById(item.Value)
			resource.Visible = item.Checked
		End Sub

		Private Sub schedulerControl1_CustomDrawResourceHeader(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
			Dim graphics As Graphics = e.Graphics
			Dim header As ResourceHeader = CType(e.ObjectInfo, ResourceHeader)
			Dim bounds As Rectangle = header.ImageBounds
			bounds.Y = header.Bounds.Y + 9
			header.ImageBounds = bounds
			Dim imageBounds As Rectangle = Rectangle.Intersect(header.ImageBounds, header.ContentBounds)
			Dim textBounds As New Rectangle(imageBounds.X, header.Bounds.Bottom - 40, imageBounds.Width, 15)
			header.TextBounds = textBounds
			e.DrawDefault()
			Using brush As Brush = New SolidBrush(Color.FromArgb(70, Color.Black))
				graphics.DrawRectangle(New Pen(brush), imageBounds)
			End Using
			e.Handled = True
			Dim medic As Medic = TryCast(header.Resource.GetRow(Me.schedulerStorage1), Medic)
			If medic Is Nothing Then
				Return
			End If
			Dim hospitalDepartment As HospitalDepartment = Me.dataContext.HospitalDepartments.Find(medic.DepartmentId)
			If hospitalDepartment Is Nothing Then
				Return
			End If

			Dim textOptions As New TextOptions(HorzAlignment.Center, VertAlignment.Center, WordWrap.NoWrap, Trimming.EllipsisCharacter)
			Dim additionalCaptionBounds As New Rectangle(textBounds.X, textBounds.Bottom, textBounds.Width, textBounds.Height)
			Using additionalCaptionBrush As Brush = New SolidBrush(Color.FromArgb(150, header.CaptionAppearance.ForeColor))
				graphics.DrawString(hospitalDepartment.Name, header.CaptionAppearance.Font, additionalCaptionBrush, additionalCaptionBounds, textOptions.GetStringFormat())
			End Using
		End Sub

		Private Sub OverviewModule_Resize(ByVal sender As Object, ByVal e As EventArgs)
			UpdateSize()
		End Sub

		Private Sub UpdateSize()
			Dim height As Integer = CInt(Fix((Me.splitContainerControl1.Height - Me.accordionContentContainer1.Bottom - 64) / 2))
			Me.accordionContentContainer2.Height = height
			Me.accordionContentContainer3.Height = height
			Me.splitContainerControl1.SplitterPosition = Me.splitContainerControl1.Right - 270
		End Sub

		Private Sub schedulerControl1_AllowAppointmentConflicts(ByVal sender As Object, ByVal e As AppointmentConflictEventArgs)
			e.Conflicts.Clear()
			FillConflictedAppointmentsCollection(e.Conflicts, e.Interval, schedulerStorage1.Appointments.Items, e.AppointmentClone)
		End Sub

		Private Sub FillConflictedAppointmentsCollection(ByVal conflicts As AppointmentBaseCollection, ByVal interval As TimeInterval, ByVal collection As AppointmentBaseCollection, ByVal currentAppointment As Appointment)
			Dim appointmentCount As Integer = collection.Count
			Dim currentPatient As Patient = CType(currentAppointment.CustomFields("Patient"), Patient)
			For i As Integer = 0 To appointmentCount - 1
				Dim appointment As Appointment = collection(i)
				If appointment Is currentAppointment Then
					Continue For
				End If
				Dim appointmentTimeInterval As New TimeInterval(appointment.Start, appointment.End)
				If appointmentTimeInterval.IntersectsWith(interval) And Not(appointment.Start = interval.End OrElse appointment.End = interval.Start) Then
					If appointment.ResourceId.Equals(currentAppointment.ResourceId) Then
						conflicts.Add(appointment)
					Else
						Dim patient As Patient = CType(appointment.CustomFields("Patient"), Patient)
						If patient IsNot Nothing AndAlso patient.Equals(currentPatient) Then
							conflicts.Add(appointment)
						End If
					End If

				End If
				If appointment.Type.Equals(AppointmentType.Pattern) Then
					FillConflictedAppointmentsCollection(conflicts, interval, appointment.GetExceptions(), currentAppointment)
				End If
			Next i
		End Sub

		Private Sub schedulerStorage1_AppointmentsChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
			Me.dataContext.SaveChanges()
		End Sub

		Private Sub schedulerControl1_InitAppointmentDisplayText(ByVal sender As Object, ByVal e As AppointmentDisplayTextEventArgs)
			Dim patient As Patient = CType(e.Appointment.CustomFields("Patient"), Patient)
			e.Text = If(patient Is Nothing, String.Empty, patient.Name)
		End Sub

		Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseMove
			Dim view As GridView = TryCast(sender, GridView)
			If e.Button = MouseButtons.Left AndAlso downHitInfo IsNot Nothing Then
				Dim dragSize As Size = SystemInformation.DragSize
				Dim dragRect As New Rectangle(New Point(downHitInfo.HitPoint.X - CInt(Fix(dragSize.Width / 2)), downHitInfo.HitPoint.Y - CInt(Fix(dragSize.Height / 2))), dragSize)

				If (Not dragRect.Contains(New Point(e.X, e.Y))) Then
					view.GridControl.DoDragDrop(GetDragData(view), DragDropEffects.All)
					downHitInfo = Nothing
				End If
			End If
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
				Dim apt As Appointment = schedulerStorage1.CreateAppointment(AppointmentType.Normal)
				apt.CustomFields("Patient") = view.GetRow(rowIndex)
				appointments.Add(apt)
			Next i

			Return New SchedulerDragData(appointments, 0)
		End Function

		Private Sub gridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseDown
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

		Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs) Handles schedulerControl1.EditAppointmentFormShowing
			Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = (CType(sender, DevExpress.XtraScheduler.SchedulerControl))
			Dim form As New Modules.MedicalAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm)
			form.SetDataContext(Me.dataContext)
			Try
				e.DialogResult = form.ShowDialog()
				e.Handled = True
			Finally
				form.Dispose()
			End Try
		End Sub

		Private Sub schedulerControl1_AppointmentDrop(ByVal sender As Object, ByVal e As AppointmentDragEventArgs)
			Dim createEventMsg As String = "Creating an event at {0} on {1}."
			Dim moveEventMsg As String = "Moving the event from {0} on {1} to {2} {3} on {4}."

			Dim sourceAppointment As Appointment = e.SourceAppointment
			Dim editedAppointment As Appointment = e.EditedAppointment
			Dim srcStart As DateTime = sourceAppointment.Start
			Dim newStart As DateTime = editedAppointment.Start
			Dim isNewAppointment As Boolean = srcStart = DateTime.MinValue

			Dim resourceName As String = String.Empty
			If sourceAppointment.ResourceId IsNot editedAppointment.ResourceId Then
				resourceName = e.HitResource.Caption
			End If

			Dim msg As String = If(isNewAppointment, String.Format(createEventMsg, newStart.ToShortTimeString(), newStart.ToShortDateString()), String.Format(moveEventMsg, srcStart.ToShortTimeString(), srcStart.ToShortDateString(), resourceName, newStart.ToShortTimeString(), newStart.ToShortDateString()))

			If XtraMessageBox.Show(msg & Constants.vbCrLf & "Proceed?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
				e.Allow = False
			ElseIf isNewAppointment Then
				Me.schedulerControl1.SelectedAppointments.Clear()
				Me.schedulerControl1.SelectedAppointments.Add(e.EditedAppointment)
			End If
		End Sub
	End Class
End Namespace
