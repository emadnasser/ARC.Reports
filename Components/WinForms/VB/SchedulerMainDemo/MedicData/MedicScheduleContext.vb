Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.Entity
Imports System.Data.SQLite
Imports System.Linq

Namespace DevExpress.XtraScheduler.Demos
	Public Class MedicScheduleContext
		Inherits DbContext
		#Region "tableCreationScript"
		Private tableCreationScript_Renamed As String = "" & ControlChars.CrLf & "-- Table: Medics" & ControlChars.CrLf & "CREATE TABLE Medics ( " & ControlChars.CrLf & "Id      INTEGER PRIMARY KEY AUTOINCREMENT" & ControlChars.CrLf & "                    UNIQUE," & ControlChars.CrLf & "    Name    TEXT," & ControlChars.CrLf & "    Phone TEXT," & ControlChars.CrLf & "    PhotoBytes BLOB," & ControlChars.CrLf & "    DepartmentId        INT64 " & ControlChars.CrLf & ");" & ControlChars.CrLf & ControlChars.CrLf & "-- Table: HospitalDepartments" & ControlChars.CrLf & "CREATE TABLE HospitalDepartments ( " & ControlChars.CrLf & "Id      INTEGER PRIMARY KEY AUTOINCREMENT" & ControlChars.CrLf & "                    UNIQUE," & ControlChars.CrLf & "    Name    TEXT" & ControlChars.CrLf & ");" & ControlChars.CrLf & ControlChars.CrLf & "-- Table: Patients" & ControlChars.CrLf & "CREATE TABLE Patients ( " & ControlChars.CrLf & "Id      INTEGER PRIMARY KEY AUTOINCREMENT" & ControlChars.CrLf & "                    UNIQUE," & ControlChars.CrLf & "    Name    TEXT,    " & ControlChars.CrLf & "    Birthday DATE," & ControlChars.CrLf & "    Phone TEXT" & ControlChars.CrLf & ");" & ControlChars.CrLf & ControlChars.CrLf & "-- Table: MedicalAppointments" & ControlChars.CrLf & "CREATE TABLE MedicalAppointments ( " & ControlChars.CrLf & "    Id             INTEGER  PRIMARY KEY AUTOINCREMENT" & ControlChars.CrLf & "                            UNIQUE," & ControlChars.CrLf & "    AllDay          BOOLEAN," & ControlChars.CrLf & "    StartTime           DATETIME," & ControlChars.CrLf & "    [EndTime]           DATETIME," & ControlChars.CrLf & "    PatientId       INT64," & ControlChars.CrLf & "    Note            TEXT," & ControlChars.CrLf & "    IssueId         INTEGER," & ControlChars.CrLf & "    PaymentStatusId INTEGER," & ControlChars.CrLf & "    EventType       INTEGER," & ControlChars.CrLf & "    Location        TEXT," & ControlChars.CrLf & "    RecurrenceInfo  TEXT," & ControlChars.CrLf & "    ReminderInfo    TEXT," & ControlChars.CrLf & "    MedicId        INT64 " & ControlChars.CrLf & ");" & ControlChars.CrLf & ""
		#End Region


		Public Sub New()
			MyBase.New("name=DevExpress.XtraScheduler.Demos.Properties.Settings.MedicConnectionString")
			CreateDBStructureIfRequired()
		End Sub

		Public Property Medics() As DbSet(Of Medic)
		Public Property MedicalAppointments() As DbSet(Of MedicalAppointment)
		Public Property HospitalDepartments() As DbSet(Of HospitalDepartment)
		Public Property Patients() As DbSet(Of Patient)

		Private ReadOnly Property TableCreationScript() As String
			Get
				Return String.Format(tableCreationScript_Renamed)
			End Get
		End Property

		Public Sub LoadData()
			LoadPatients()
			LoadHospitalDepartments()
			LoadMedics()
			LoadMedicalAppointments()
		End Sub

		Private Sub CreateDBStructureIfRequired()
			Dim connection As SQLiteConnection = TryCast(Database.Connection, SQLiteConnection)
			If connection Is Nothing Then
				Return
			End If
			connection.Open()
			Dim a As DataTable = connection.GetSchema("Tables")
			If a.Rows.Count > 0 Then
				Return
			End If
			Dim command As New SQLiteCommand(TableCreationScript, connection)
			command.ExecuteNonQuery()
		End Sub

		Private Sub LoadMedics()
			Medics.Load()
			If Medics.Count() > 0 Then
				Return
			End If
			Medics.AddRange(MedicScheduleDataHelper.CreateMedics(HospitalDepartments.ToList()))
			SaveChanges()
		End Sub

		Private Sub LoadHospitalDepartments()
			HospitalDepartments.Load()
			If HospitalDepartments.Count() > 0 Then
				Return
			End If
			HospitalDepartments.AddRange(MedicScheduleDataHelper.CreateHospitalDepartments())
			SaveChanges()
		End Sub

		Private Sub LoadPatients()
			Patients.Load()
			If Patients.Count() > 0 Then
				Return
			End If
			Patients.AddRange(MedicScheduleDataHelper.CreatePatients())
			SaveChanges()
		End Sub

		Private Sub LoadMedicalAppointments()
			MedicalAppointments.Load()
			Dim medicalAppointmentsCount As Integer = MedicalAppointments.Count()
			If medicalAppointmentsCount > 0 Then
				Dim appointment As MedicalAppointment = MedicalAppointments.FirstOrDefault(Function(apt) apt.EndTime >= MedicScheduleDataHelper.BaseDate)
				If appointment IsNot Nothing Then
					Return
				End If
				MedicalAppointments.Local.Clear()
				SaveChanges()
			End If
			MedicalAppointments.AddRange(MedicScheduleDataHelper.CreateMedicalAppointments(Medics.ToList()))
			SaveChanges()
		End Sub
	End Class
End Namespace
