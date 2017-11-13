Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Internal
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Native
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.iCalendar
Imports DevExpress.XtraScheduler.Localization
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraScheduler.Printing
Imports DevExpress.XtraScheduler.Printing.Native
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.XtraScheduler.Services
Imports System.Data
Imports System.Data.SQLite
Imports DevExpress.XtraScheduler.Demos
Imports System.Data.Entity

Namespace Modules
	''' <summary>
	''' Summary description for AppointmentRibbonForm.
	''' </summary>
	Partial Public Class MedicalAppointmentForm
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm
		Implements IDXManagerPopupMenu
		#Region "Fields"
		Private openRecurrenceForm_Renamed As Boolean
		Private ReadOnly storage_Renamed As ISchedulerStorage
		Private ReadOnly control_Renamed As SchedulerControl
		Private recurringIcon_Renamed As Icon
		Private normalIcon_Renamed As Icon
		Private ReadOnly controller_Renamed As AppointmentFormController
		Private menuManager_Renamed As IDXMenuManager
		Private supressCancelCore As Boolean
		Private dataContext As MedicScheduleContext
		Private patient As Patient

		#End Region

		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub New(ByVal control As DevExpress.XtraScheduler.SchedulerControl, ByVal apt As Appointment)
			Me.New(control, apt, False)
		End Sub
		Public Sub New(ByVal control As DevExpress.XtraScheduler.SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
			Guard.ArgumentNotNull(control, "control")
			Guard.ArgumentNotNull(control.DataStorage, "control.DataStorage")
			Guard.ArgumentNotNull(apt, "apt")

			Me.openRecurrenceForm_Renamed = openRecurrenceForm
			Me.controller_Renamed = CreateController(control, apt)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			LoadIcons()

			Me.control_Renamed = control
			Me.storage_Renamed = control.DataStorage

			Me.edtResource.SchedulerControl = control
			Me.edtResource.Storage = storage_Renamed

			Me.riAppointmentResource.SchedulerControl = control
			Me.riAppointmentResource.Storage = storage_Renamed
			Me.riAppointmentStatus.Storage = storage_Renamed

			Me.riAppointmentLabel.Storage = storage_Renamed

			BindControllerToControls()


			AddHandler Me.cmbPatient.EditValueChanged, AddressOf cmbPatient_EditValueChanged
			AddHandler Me.cmbPatient.MouseDown, AddressOf cmbPatient_MouseDown
			Me.supressCancelCore = False
			AddHandler Me.edtResource.EditValueChanged, AddressOf edtResource_EditValueChanged
			Me.pictureEdit1.Properties.SizeMode = PictureSizeMode.Zoom
		End Sub

		Private Sub edtResource_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			RefreshMedic(Storage.Resources.GetResourceById(Me.edtResource.EditValue))
		End Sub


		#Region "Properties"
		Public Property MenuManager() As IDXMenuManager
			Get
				Return menuManager_Renamed
			End Get
			Private Set(ByVal value As IDXMenuManager)
				menuManager_Renamed = value
			End Set
		End Property
		Protected Friend ReadOnly Property Controller() As AppointmentFormController
			Get
				Return controller_Renamed
			End Get
		End Property
		Protected Friend ReadOnly Property Control() As SchedulerControl
			Get
				Return control_Renamed
			End Get
		End Property
		Protected Friend ReadOnly Property Storage() As ISchedulerStorage
			Get
				Return storage_Renamed
			End Get
		End Property
		Protected Friend ReadOnly Property IsNewAppointment() As Boolean
			Get
				Return If(controller_Renamed IsNot Nothing, controller_Renamed.IsNewAppointment, True)
			End Get
		End Property
		Protected Friend ReadOnly Property RecurringIcon() As Icon
			Get
				Return recurringIcon_Renamed
			End Get
		End Property
		Protected Friend ReadOnly Property NormalIcon() As Icon
			Get
				Return normalIcon_Renamed
			End Get
		End Property
		Protected Friend ReadOnly Property OpenRecurrenceForm() As Boolean
			Get
				Return openRecurrenceForm_Renamed
			End Get
		End Property
		Public Property [ReadOnly]() As Boolean
			Get
				Return Controller.ReadOnly
			End Get
			Set(ByVal value As Boolean)
				If Controller.ReadOnly = value Then
					Return
				End If
				Controller.ReadOnly = value
			End Set
		End Property
		Protected Overrides ReadOnly Property ShowMode() As FormShowMode
			Get
				Return DevExpress.XtraEditors.FormShowMode.AfterInitialization
			End Get
		End Property
		#End Region

		Public Sub SetDataContext(ByVal dataContext As MedicScheduleContext)
			Me.dataContext = dataContext
		End Sub

		Public Overridable Sub LoadFormData(ByVal appointment As Appointment)
			Me.patient = CType(appointment.CustomFields("Patient"), Patient)
			RefreshPatient(patient)
			If Me.patient IsNot Nothing Then
				Me.cmbPatient.Properties.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem(patient.Name, patient.Id))
			End If
		End Sub

		Private Sub RefreshPatient(ByVal patient As Patient)
			Me.tbPhone.DataBindings.Clear()
			Me.edtBirthday.DataBindings.Clear()
			Me.cmbPatient.DataBindings.Clear()
			If patient Is Nothing Then
				Return
			End If
			Me.tbPhone.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", patient, "Phone", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
			Me.edtBirthday.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", patient, "Birthday", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
			Me.cmbPatient.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", patient, "Id", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		End Sub

		Private Sub RefreshMedic(ByVal resource As Resource)
			Me.pictureEdit1.Image = Nothing
			Me.edtPhoneMedic.Text = ""
			If resource Is Nothing Then
				Return
			End If
			Dim medic As Medic = TryCast(resource.GetRow(Storage), Medic)
			If medic Is Nothing Then
				Return
			End If
			Me.pictureEdit1.Image = resource.GetImage()
			Me.edtPhoneMedic.Text = medic.Phone
			Me.lbMedic.Text = medic.Name
			Dim hospitalDepartment As HospitalDepartment = Me.dataContext.HospitalDepartments.Find(medic.DepartmentId)
			If hospitalDepartment Is Nothing Then
				Return
			End If
			Me.lbDepartment.Text = hospitalDepartment.Name
		End Sub

		Private Sub cmbPatient_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			If Me.cmbPatient.Properties.Items.Count > 1 Then
				Return
			End If
			Me.cmbPatient.Properties.Items.Clear()
			Dim patients As BindingList(Of Patient) = Me.dataContext.Patients.Local.ToBindingList()
			For Each patient As Patient In patients
				Me.cmbPatient.Properties.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem(patient.Name, patient.Id))
			Next patient
		End Sub

		Private Sub cmbPatient_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			RefreshPatient(Me.dataContext.Patients.Find(Me.cmbPatient.EditValue))
		End Sub

		Public Overridable Function SaveFormData(ByVal appointment As Appointment) As Boolean
			appointment.CustomFields("Patient") = Me.dataContext.Patients.Find(Me.cmbPatient.EditValue)
			Return True
		End Function
		Public Overridable Function IsAppointmentChanged(ByVal appointment As Appointment) As Boolean
			If Me.patient Is Nothing Then
				Return True
			End If
			If Me.patient.Id.Equals(Me.cmbPatient.EditValue) Then
				Return False
			End If
			Return True
		End Function
		Public Overridable Sub SetMenuManager(ByVal menuManager As DevExpress.Utils.Menu.IDXMenuManager)
			MenuManagerUtils.SetMenuManager(Controls, menuManager)
			Me.menuManager_Renamed = menuManager
		End Sub

		Protected Overridable Sub BindControllerToControls()
			BindControllerToIcon()
			BindProperties(Me.tbLocation, "Text", "Location")
			BindProperties(Me.tbDescription, "Text", "Description")
			BindProperties(Me.edtStartDate, "EditValue", "DisplayStartDate")
			BindProperties(Me.edtStartDate, "Enabled", "IsDateTimeEditable")
			BindProperties(Me.edtStartTime, "EditValue", "DisplayStartTime")
			BindProperties(Me.edtStartTime, "Enabled", "IsTimeEnabled")
			BindProperties(Me.edtEndDate, "EditValue", "DisplayEndDate", DataSourceUpdateMode.Never)
			BindProperties(Me.edtEndDate, "Enabled", "IsDateTimeEditable", DataSourceUpdateMode.Never)
			BindProperties(Me.edtEndTime, "EditValue", "DisplayEndTime", DataSourceUpdateMode.Never)
			BindProperties(Me.edtEndTime, "Enabled", "IsTimeEnabled", DataSourceUpdateMode.Never)

			BindProperties(Me.edtResource, "ResourceId", "ResourceId")
			BindProperties(Me.edtResource, "Enabled", "CanEditResource")
			BindToBoolPropertyAndInvert(Me.edtResource, "Visible", "ResourceSharing")

			BindProperties(Me.barLabel, "EditValue", "Label")

			BindProperties(Me.barStatus, "EditValue", "Status")

			BindBoolToVisibility(Me.barReminder, "Visibility", "ReminderVisible")
			BindProperties(Me.barReminder, "Editvalue", "ReminderTimeBeforeStart")

			BindProperties(Me.btnDelete, "Enabled", "CanDeleteAppointment")

			BindBoolToVisibility(Me.btnRecurrence, "Visibility", "ShouldShowRecurrenceButton")
			BindProperties(Me.btnRecurrence, "Down", "IsRecurrentAppointment")


			BindToBoolPropertyAndInvert(Me.ribbonControl1, "Enabled", "ReadOnly")

			BindBoolToVisibility(Me.btnTimeZones, "Visibility", "TimeZonesEnabled")
			BindProperties(Me.btnTimeZones, "Down", "TimeZoneVisible")
		End Sub

		Protected Overridable Sub BindControllerToIcon()
			Dim binding As New Binding("Icon", Controller, "AppointmentType")
			AddHandler binding.Format, AddressOf AppointmentTypeToIconConverter
			DataBindings.Add(binding)
		End Sub
		Protected Overridable Sub ObjectToStringConverter(ByVal o As Object, ByVal e As ConvertEventArgs)
			e.Value = e.Value.ToString()
		End Sub
		Protected Overridable Sub AppointmentTypeToIconConverter(ByVal o As Object, ByVal e As ConvertEventArgs)
			Dim type As AppointmentType = CType(e.Value, AppointmentType)
			If type.Equals(AppointmentType.Pattern) Then
				e.Value = RecurringIcon
			Else
				e.Value = NormalIcon
			End If
		End Sub
		Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String)
			BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged)
		End Sub
		Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal updateMode As DataSourceUpdateMode)
			target.DataBindings.Add(targetProperty, Controller, sourceProperty, True, updateMode)
			BindToIsReadOnly(target, updateMode)
		End Sub
		Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal objectToStringConverter As ConvertEventHandler)
			Dim binding As New Binding(targetProperty, Controller, sourceProperty, True)
			AddHandler binding.Format, objectToStringConverter
			target.DataBindings.Add(binding)
		End Sub
		Protected Overridable Sub BindToBoolPropertyAndInvert(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String)
			target.DataBindings.Add(New BoolInvertBinding(targetProperty, Controller, sourceProperty))
			BindToIsReadOnly(target)
		End Sub
		Protected Overridable Sub BindToIsReadOnly(ByVal control As Control)
			BindToIsReadOnly(control, DataSourceUpdateMode.OnPropertyChanged)
		End Sub
		Protected Overridable Sub BindToIsReadOnly(ByVal control As Control, ByVal updateMode As DataSourceUpdateMode)
			If (Not(TypeOf control Is BaseEdit)) OrElse control.DataBindings("ReadOnly") IsNot Nothing Then
				Return
			End If
			control.DataBindings.Add("ReadOnly", Controller, "ReadOnly", True, updateMode)
		End Sub

		Protected Overridable Sub BindProperties(ByVal target As DevExpress.XtraBars.BarItem, ByVal targetProperty As String, ByVal sourceProperty As String)
			BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged)
		End Sub
		Protected Overridable Sub BindProperties(ByVal target As DevExpress.XtraBars.BarItem, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal updateMode As DataSourceUpdateMode)
			target.DataBindings.Add(targetProperty, Controller, sourceProperty, True, updateMode)
		End Sub
		Protected Overridable Sub BindProperties(ByVal target As DevExpress.XtraBars.BarItem, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal objectToStringConverter As ConvertEventHandler)
			Dim binding As New Binding(targetProperty, Controller, sourceProperty, True)
			AddHandler binding.Format, objectToStringConverter
			target.DataBindings.Add(binding)
		End Sub
		Protected Overridable Sub BindToBoolPropertyAndInvert(ByVal target As DevExpress.XtraBars.BarItem, ByVal targetProperty As String, ByVal sourceProperty As String)
			target.DataBindings.Add(New BoolInvertBinding(targetProperty, Controller, sourceProperty))
		End Sub
		Protected Overridable Sub BindBoolToVisibility(ByVal target As DevExpress.XtraBars.BarItem, ByVal targetProperty As String, ByVal sourceProperty As String)
			target.DataBindings.Add(New BoolToVisibilityBinding(targetProperty, Controller, sourceProperty, False))
		End Sub
		Protected Overridable Sub BindBoolToVisibility(ByVal target As DevExpress.XtraBars.BarItem, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal invert As Boolean)
			target.DataBindings.Add(New BoolToVisibilityBinding(targetProperty, Controller, sourceProperty, invert))
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			If Controller Is Nothing Then
				Return
			End If
			SubscribeControlsEvents()
			LoadFormData(Controller.EditedAppointmentCopy)
		End Sub
		Protected Overridable Function CreateController(ByVal control As SchedulerControl, ByVal apt As Appointment) As AppointmentFormController
			Return New AppointmentFormController(control, apt)
		End Function
		Protected Friend Overridable Sub LoadIcons()
			Dim asm As System.Reflection.Assembly = GetType(SchedulerControl).Assembly
			Me.recurringIcon_Renamed = ResourceImageHelper.CreateIconFromResources(SchedulerIconNames.RecurringAppointment, asm)
			Me.normalIcon_Renamed = ResourceImageHelper.CreateIconFromResources(SchedulerIconNames.Appointment, asm)
		End Sub
		Protected Friend Overridable Sub SubscribeControlsEvents()
			AddHandler edtEndDate.Validating, AddressOf OnEdtEndDateValidating
			AddHandler edtEndDate.InvalidValue, AddressOf OnEdtEndDateInvalidValue
			AddHandler edtEndTime.Validating, AddressOf OnEdtEndTimeValidating
			AddHandler edtEndTime.InvalidValue, AddressOf OnEdtEndTimeInvalidValue
			AddHandler riDuration.Validating, AddressOf OnCbReminderValidating
		End Sub
		Protected Friend Overridable Sub UnsubscribeControlsEvents()
			RemoveHandler edtEndDate.Validating, AddressOf OnEdtEndDateValidating
			RemoveHandler edtEndDate.InvalidValue, AddressOf OnEdtEndDateInvalidValue
			RemoveHandler edtEndTime.Validating, AddressOf OnEdtEndTimeValidating
			RemoveHandler edtEndTime.InvalidValue, AddressOf OnEdtEndTimeInvalidValue
			RemoveHandler riDuration.Validating, AddressOf OnCbReminderValidating
		End Sub
		Protected Friend Overridable Sub OnEdtEndDateValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
			e.Cancel = Not IsValidInterval()
			If (Not e.Cancel) Then
				Me.edtEndDate.DataBindings("EditValue").WriteValue()
			End If
		End Sub
		Protected Friend Overridable Sub OnEdtEndDateInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
			e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
		End Sub
		Protected Friend Overridable Sub OnEdtEndTimeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
			e.Cancel = Not IsValidInterval()
			If (Not e.Cancel) Then
				Me.edtEndTime.DataBindings("EditValue").WriteValue()
			End If
		End Sub
		Protected Friend Overridable Sub OnEdtEndTimeInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
			e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
		End Sub
		Protected Friend Overridable Function IsValidInterval() As Boolean
			Return AppointmentFormControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay)
		End Function
		Protected Friend Overridable Sub OnOkButton()
			Save(True)
		End Sub
		Protected Overridable Sub OnSaveButton()
			Save(False)
		End Sub
		Private Sub Save(ByVal closeAfterSave As Boolean)
			If (Not ValidateEndDateAndTime()) Then
				Return
			End If
			If (Not SaveFormData(Controller.EditedAppointmentCopy)) Then
				Return
			End If
			If (Not Controller.IsConflictResolved()) Then
				ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_Conflict), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_Conflict), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If

			If Controller.IsAppointmentChanged() OrElse Controller.IsNewAppointment OrElse IsAppointmentChanged(Controller.EditedAppointmentCopy) Then
				Controller.ApplyChanges()
			End If
			If closeAfterSave Then
				Me.supressCancelCore = True
				DialogResult = System.Windows.Forms.DialogResult.OK
			End If
		End Sub
		Private Function ValidateEndDateAndTime() As Boolean
			Me.edtEndDate.DoValidate()
			Me.edtEndTime.DoValidate()

			Return String.IsNullOrEmpty(Me.edtEndTime.ErrorText) AndAlso String.IsNullOrEmpty(Me.edtEndDate.ErrorText)
		End Function
		Protected Overridable Sub OnSaveAsButton()
			Dim fileDialog As New SaveFileDialog()
			fileDialog.Filter = "iCalendar files (*.ics)|*.ics"
			fileDialog.FilterIndex = 1
			If fileDialog.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
				Return
			End If
			Try
				Using stream As Stream = fileDialog.OpenFile()
					ExportAppointment(stream)
				End Using
			Catch
				ShowMessageBox("Error: could not export appointments", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub
		Private Sub ExportAppointment(ByVal stream As Stream)
			If stream Is Nothing Then
				Return
			End If

			Dim aptsToExport As New AppointmentBaseCollection()
			aptsToExport.Add(Controller.EditedAppointmentCopy)
			Dim exporter As New iCalendarExporter(Me.storage_Renamed, aptsToExport)

			exporter.ProductIdentifier = "-//Developer Express Inc."
			exporter.Export(stream)
		End Sub
		Protected Friend Overridable Function ShowMessageBox(ByVal text As String, ByVal caption As String, ByVal buttons As MessageBoxButtons, ByVal icon As MessageBoxIcon) As DialogResult
			Return XtraMessageBox.Show(Me, text, caption, buttons, icon)
		End Function
		Protected Friend Overridable Sub OnDeleteButton()
			If IsNewAppointment Then
				Return
			End If

			Controller.DeleteAppointment()

			DialogResult = System.Windows.Forms.DialogResult.Abort
			Close()
		End Sub
		Protected Friend Overridable Sub OnRecurrenceButton()
			If (Not Controller.ShouldShowRecurrenceButton) Then
				Return
			End If

			Dim patternCopy As Appointment = Controller.PrepareToRecurrenceEdit()

			Dim result As DialogResult
			Using form As Form = CreateAppointmentRecurrenceForm(patternCopy, Control.OptionsView.FirstDayOfWeek)
				result = ShowRecurrenceForm(form)
			End Using

			If result = System.Windows.Forms.DialogResult.Abort Then
				Controller.RemoveRecurrence()
			ElseIf result = System.Windows.Forms.DialogResult.OK Then
				Controller.ApplyRecurrence(patternCopy)
			End If

			Me.btnRecurrence.Down = Controller.IsRecurrentAppointment
		End Sub
		Protected Overridable Sub OnCloseButton()
			Me.Close()
		End Sub

		Private Function CancelCore() As Boolean
			Dim result As Boolean = True

			If DialogResult <> System.Windows.Forms.DialogResult.Abort AndAlso Controller IsNot Nothing AndAlso Controller.IsAppointmentChanged() AndAlso (Not Me.supressCancelCore) Then
				Dim dialogResult As DialogResult = ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_SaveBeforeClose), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_SaveBeforeClose), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

				If dialogResult = System.Windows.Forms.DialogResult.Cancel Then
					result = False
				ElseIf dialogResult = System.Windows.Forms.DialogResult.Yes Then
					Save(True)
				End If
			End If

			Return result
		End Function

		Protected Overridable Function ShowRecurrenceForm(ByVal form As Form) As DialogResult
			Return FormTouchUIAdapter.ShowDialog(form, Me)
		End Function
		Protected Friend Overridable Function CreateAppointmentRecurrenceForm(ByVal patternCopy As Appointment, ByVal firstDayOfWeek As DevExpress.XtraScheduler.FirstDayOfWeek) As Form
			Dim form As New AppointmentRecurrenceForm(patternCopy, firstDayOfWeek, Controller)
			form.SetMenuManager(MenuManager)
			form.LookAndFeel.ParentLookAndFeel = LookAndFeel
			form.ShowExceptionsRemoveMsgBox = controller_Renamed.AreExceptionsPresent()
			Return form
		End Function
		Friend Sub OnAppointmentFormActivated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
			If openRecurrenceForm_Renamed Then
				openRecurrenceForm_Renamed = False
				OnRecurrenceButton()
			End If
		End Sub
		Protected Friend Overridable Sub OnCbReminderValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
			Dim span As TimeSpan = CType(barReminder.EditValue, TimeSpan)
			e.Cancel = span.Ticks < 0 AndAlso span <> TimeSpan.MinValue
			If (Not e.Cancel) Then
				Me.barReminder.DataBindings("EditValue").WriteValue()
			End If
		End Sub

		Protected Friend Overridable Sub OnNextButton()
			If CancelCore() Then
				Me.supressCancelCore = True
				Dim command As New OpenNextAppointmentCommand(Control)
				command.Execute()
				Me.Close()
			End If
		End Sub

		Protected Friend Overridable Sub OnPreviousButton()
			If CancelCore() Then
				Me.supressCancelCore = True
				Dim command As New OpenPrevAppointmentCommand(Control)
				command.Execute()
				Me.Close()
			End If
		End Sub

		Protected Friend Overridable Sub OnTimeZonesButton()
			Controller.TimeZoneVisible = Not Controller.TimeZoneVisible
		End Sub

		Protected Overridable Sub OnApplicationButtonClick()
			Me.dvInfo.Document = Control.GetPrintPreviewDocument(New MemoPrintStyle())
			Me.dvInfo.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage)
		End Sub

		Private Sub btnSaveAndClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
			OnOkButton()
		End Sub

		Private Sub barButtonDelete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
			OnDeleteButton()
		End Sub

		Private Sub barRecurrence_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnRecurrence.ItemClick
			OnRecurrenceButton()
		End Sub

		Private Sub bvbSave_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles bvbSave.ItemClick
			OnSaveButton()
		End Sub

		Private Sub bvbSaveAs_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles bvbSaveAs.ItemClick
			OnSaveAsButton()
		End Sub

		Private Sub bvbClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles bvbClose.ItemClick
			OnCloseButton()
		End Sub

		Private Sub btnSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnSave.ItemClick
			OnSaveButton()
		End Sub

		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			e.Cancel = Not CancelCore()
			MyBase.OnClosing(e)
		End Sub

		Private Sub btnNext_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnNext.ItemClick
			OnNextButton()
		End Sub

		Private Sub btnPrevious_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnPrevious.ItemClick
			OnPreviousButton()
		End Sub

		Private Sub btnTimeZones_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnTimeZones.ItemClick
			OnTimeZonesButton()
		End Sub

		Private Sub ribbonControl1_ApplicationButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonControl1.ApplicationButtonClick
			OnApplicationButtonClick()
		End Sub

		Private Sub OutlookAppointmentForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace
