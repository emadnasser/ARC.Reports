Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.Entity
Imports System.Configuration
Imports System.Data.SQLite
Imports System.Data.Common
Imports System.ComponentModel.DataAnnotations

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class EntityBoundModeModule
		Inherits TutorialControl
		Private dataContext As DoctorScheduleContext
		Public Sub New()
			InitializeComponent()
			Me.schedulerControl1.Start = DoctorScheduleDataHelper.BaseDate
			Database.SetInitializer(Of DoctorScheduleContext)(Nothing)
			Me.dataContext = New DoctorScheduleContext()
			DoctorScheduleDataHelper.InitIfRequired(Me.dataContext)

			InitializeMappings(Me.schedulerStorage1)
			DoctorScheduleDataHelper.CustomizeLabelsAndStatuses(Me.schedulerStorage1)

			Me.dataContext.Doctors.Load()
			Me.dataContext.DoctorAppointments.Load()

			Me.schedulerStorage1.Resources.DataSource = Me.dataContext.Doctors.Local.ToBindingList()
			Me.schedulerStorage1.Appointments.DataSource = Me.dataContext.DoctorAppointments.Local.ToBindingList()

			AddHandler Me.schedulerStorage1.AppointmentsChanged, AddressOf schedulerStorage1_AppointmentsChanged
			AddHandler Me.schedulerStorage1.AppointmentsInserted, AddressOf schedulerStorage1_AppointmentsChanged
			AddHandler Me.schedulerStorage1.AppointmentsDeleted, AddressOf schedulerStorage1_AppointmentsChanged
		End Sub

		Private Sub schedulerStorage1_AppointmentsChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
			Me.dataContext.SaveChanges()
		End Sub
		Private Sub InitializeMappings(ByVal schedulerStorage As SchedulerStorage)
			Dim appointmentMapping As AppointmentMappingInfo = schedulerStorage.Appointments.Mappings
			appointmentMapping.AllDay = "AllDay"
			appointmentMapping.Description = "Note"
			appointmentMapping.Subject = "PatientName"
			appointmentMapping.Start = "StartDate"
			appointmentMapping.End = "EndDate"
			appointmentMapping.Label = "IssueId"
			appointmentMapping.Location = "Location"
			appointmentMapping.RecurrenceInfo = "RecurrenceInfo"
			appointmentMapping.ReminderInfo = "ReminderInfo"
			appointmentMapping.ResourceId = "DoctorId"
			appointmentMapping.Status = "PaymentStatusId"
			appointmentMapping.Type = "EventType"

			Dim resourceMapping As ResourceMappingInfo = schedulerStorage.Resources.Mappings
			resourceMapping.Id = "Id"
			resourceMapping.Caption = "Name"
		End Sub
	End Class

	#Region "Data model"
	Public Class DoctorAppointment
		<Key> _
		Public Property Id() As Int64
		Public Property AllDay() As Boolean
		Public Property StartDate() As DateTime
		Public Property EndDate() As DateTime
		Public Property PatientName() As String
		Public Property Note() As String
		Public Property PaymentStatusId() As Integer
		Public Property IssueId() As Integer
		Public Property EventType() As Integer
		Public Property Location() As String
		Public Property RecurrenceInfo() As String
		Public Property ReminderInfo() As String
		Private privateDoctorId? As Int64
		Public Property DoctorId() As Int64?
			Get
				Return privateDoctorId
			End Get
			Set(ByVal value? As Int64)
				privateDoctorId = value
			End Set
		End Property
	End Class
	Public Class Doctor
		<Key> _
		Public Property Id() As Int64
		Public Property Name() As String
	End Class

	Public Class DoctorScheduleContext
		Inherits DbContext
		Public Sub New()
			MyBase.New("name=DevExpress.XtraScheduler.Demos.Properties.Settings.DoctorConnectionString")

		End Sub
		Public Property DoctorAppointments() As DbSet(Of DoctorAppointment)
		Public Property Doctors() As DbSet(Of Doctor)
	End Class
	#End Region

	#Region "DoctorScheduleDataHelper"
	Public Class DoctorScheduleDataHelper
		#Region "Table Creation Script"
		Public Const TableCreationScript As String = "" & ControlChars.CrLf & "-- Table: Doctors" & ControlChars.CrLf & "CREATE TABLE Doctors ( " & ControlChars.CrLf & "Id      INTEGER PRIMARY KEY AUTOINCREMENT" & ControlChars.CrLf & "                    UNIQUE," & ControlChars.CrLf & "    Name    TEXT" & ControlChars.CrLf & ");" & ControlChars.CrLf & ControlChars.CrLf & "-- Table: DoctorAppointments" & ControlChars.CrLf & "CREATE TABLE DoctorAppointments ( " & ControlChars.CrLf & "    Id             INTEGER  PRIMARY KEY AUTOINCREMENT" & ControlChars.CrLf & "                            UNIQUE," & ControlChars.CrLf & "    AllDay          BOOLEAN," & ControlChars.CrLf & "    StartDate           DATETIME," & ControlChars.CrLf & "    EndDate           DATETIME," & ControlChars.CrLf & "    PatientName     TEXT," & ControlChars.CrLf & "    Note            TEXT," & ControlChars.CrLf & "    IssueId         INTEGER," & ControlChars.CrLf & "    PaymentStatusId INTEGER," & ControlChars.CrLf & "    EventType       INTEGER," & ControlChars.CrLf & "    Location        TEXT," & ControlChars.CrLf & "    RecurrenceInfo  TEXT," & ControlChars.CrLf & "    ReminderInfo    TEXT," & ControlChars.CrLf & "    DoctorId        INT64 " & ControlChars.CrLf & ");" & ControlChars.CrLf & ""
		#End Region
		Public Shared BaseDate As DateTime = DateTime.Today.AddDays(-1)
		Public Shared IssueList() As String = { "Consultation", "Treatment", "X-Ray" }
		Public Shared IssueColorList() As Color = { Color.SteelBlue, Color.Pink, Color.SeaShell }
		Public Shared PatientNames() As String = { "Andrew Glover", "Mark Oliver", "Addison Davis", "Benjamin Hughes", "Lucas Smith" }
		Public Shared DoctorNames() As String = { "Isabella Carter", "Miguel Simmons", "Madeleine Russell", "Ariana Alexander" }
		Public Shared PaymentStatuses() As String = { "Paid", "Unpaid" }
		Public Shared PaymentColorStatuses() As Color = { Color.Green, Color.Red }

		Public Shared Sub InitIfRequired(ByVal dataContext As DoctorScheduleContext)
			Dim helper As New DoctorScheduleDataHelper(dataContext)
			helper.Create()
		End Sub
		Public Shared Sub CustomizeLabelsAndStatuses(ByVal storage As SchedulerStorage)
			Dim labels As AppointmentLabelCollection = storage.Appointments.Labels
			labels.Clear()
			Dim count As Integer = IssueList.Length
			For i As Integer = 0 To count - 1
				Dim label As IAppointmentLabel = labels.CreateNewLabel(IssueList(i))
				label.SetColor(IssueColorList(i))
				labels.Add(label)
			Next i
			Dim statuses As AppointmentStatusCollection = storage.Appointments.Statuses
			statuses.Clear()
			count = PaymentStatuses.Length
			For i As Integer = 0 To count - 1
				Dim status As AppointmentStatus = statuses.CreateNewStatus(PaymentStatuses(i))
				status.Type = AppointmentStatusType.Custom
				status.SetBrush(New SolidBrush(PaymentColorStatuses(i)))
				statuses.Add(status)
			Next i
		End Sub

		Private rnd As New Random()
		Private dataContext As DoctorScheduleContext
		Private isSaveRequired As Boolean = False

		Protected Sub New(ByVal dataContext As DoctorScheduleContext)
			Me.dataContext = dataContext
		End Sub

		Public Sub Create()
			CreateDBStructureIfRequired()
			Me.dataContext.Doctors.Load()
			Me.dataContext.DoctorAppointments.Load()
			If Me.dataContext.Doctors.Count() <= 0 Then
				CreateDoctors()
			End If

			If Me.dataContext.DoctorAppointments.Count() > 0 Then
				Dim appointment As DoctorAppointment = Me.dataContext.DoctorAppointments.FirstOrDefault(Function(apt) apt.EndDate >= DoctorScheduleDataHelper.BaseDate)
				If appointment Is Nothing Then
					Me.dataContext.DoctorAppointments.Local.Clear()
					Me.dataContext.SaveChanges()
				End If
			End If

			If Me.dataContext.DoctorAppointments.Count() <= 0 Then
				CreateSchedule()
			End If

			If (Not Me.isSaveRequired) Then
				Return
			End If
			Me.dataContext.SaveChanges()
			Me.isSaveRequired = False
		End Sub
		Private Sub CreateDBStructureIfRequired()
			Dim connection As SQLiteConnection = TryCast(Me.dataContext.Database.Connection, SQLiteConnection)
			If connection Is Nothing Then
				Return
			End If
			connection.Open()
			Dim a As DataTable = connection.GetSchema("Tables")
			If a.Rows.Count > 0 Then
				Return
			End If
			Dim command As New SQLiteCommand(DoctorScheduleDataHelper.TableCreationScript, connection)
			command.ExecuteNonQuery()
		End Sub
		Private Sub CreateDoctors()
			Dim doctorCount As Integer = DoctorNames.Length
			Dim doctors = Me.dataContext.Doctors
			For i As Integer = 0 To doctorCount - 1
				Dim doctor As Doctor = dataContext.Doctors.Create()
				doctor.Name = DoctorNames(i)
				doctors.Add(doctor)
			Next i
			Me.isSaveRequired = True
		End Sub
		Private Sub CreateSchedule()
			Dim rnd As New Random()
			Dim doctorAppointmentsCount As Integer = dataContext.DoctorAppointments.Count()
			If doctorAppointmentsCount > 0 Then
				Return
			End If
			Dim doctorsCount As Integer = DoctorNames.Length
			For doctorId As Integer = 1 To doctorsCount
				CreateDoctorSchedule(doctorId)
			Next doctorId
			Me.isSaveRequired = True
		End Sub
		Private Sub CreateDoctorSchedule(ByVal doctorId As Integer)
			Dim start As DateTime = BaseDate
			Do While start < BaseDate.AddDays(7)
				CreateDoctorAppointment(doctorId, start.AddHours(Me.rnd.Next(9, 12)))
				CreateDoctorAppointment(doctorId, start.AddHours(Me.rnd.Next(14, 16)))
				CreateDoctorAppointment(doctorId, start.AddHours(Me.rnd.Next(18, 20)))
				start = start + TimeSpan.FromDays(1)
			Loop
		End Sub
		Private Sub CreateDoctorAppointment(ByVal doctorId As Integer, ByVal start As DateTime)
			Dim doctorAppointment As DoctorAppointment = dataContext.DoctorAppointments.Create()
			doctorAppointment.StartDate = start
			doctorAppointment.EndDate = start.AddHours(Me.rnd.Next(1, 3))
			doctorAppointment.IssueId = Me.rnd.Next(0, 3)
			doctorAppointment.PaymentStatusId = Me.rnd.Next(0, 2)
			Dim patientNameCount As Integer = PatientNames.Length
			doctorAppointment.PatientName = PatientNames(Me.rnd.Next(0, patientNameCount - 1))
			doctorAppointment.DoctorId = doctorId
			Me.dataContext.DoctorAppointments.Add(doctorAppointment)
		End Sub
	End Class
	#End Region
End Namespace
