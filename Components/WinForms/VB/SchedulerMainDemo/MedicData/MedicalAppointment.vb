Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace DevExpress.XtraScheduler.Demos
	Public Class MedicalAppointment
		<Key> _
		Public Property Id() As Int64
		Public Property AllDay() As Boolean
		Public Property StartTime() As DateTime
		Public Property EndTime() As DateTime
		Private privatePatientId? As Int64
		Public Property PatientId() As Int64?
			Get
				Return privatePatientId
			End Get
			Set(ByVal value? As Int64)
				privatePatientId = value
			End Set
		End Property
		<ForeignKey("PatientId")> _
		Public Property Patient() As Patient
		Public Property Note() As String
		Public Property PaymentStatusId() As Integer
		Public Property IssueId() As Integer
		Public Property EventType() As Integer
		Public Property Location() As String
		Public Property RecurrenceInfo() As String
		Public Property ReminderInfo() As String
		Private privateMedicId? As Int64
		Public Property MedicId() As Int64?
			Get
				Return privateMedicId
			End Get
			Set(ByVal value? As Int64)
				privateMedicId = value
			End Set
		End Property
	End Class
End Namespace
