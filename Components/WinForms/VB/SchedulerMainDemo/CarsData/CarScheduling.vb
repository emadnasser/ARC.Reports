Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace DevExpress.XtraScheduler.Demos
	Public Class CarScheduling
		<Key> _
		Public Property Id() As Int64
		Public Property AllDay() As Boolean
		Public Property StartTime() As DateTime
		Public Property EndTime() As DateTime
		Public Property Description() As String
		Public Property Status() As Integer
		Public Property Label() As Integer
		Public Property EventType() As Integer
		Public Property Location() As String
		Public Property Subject() As String
		Public Property RecurrenceInfo() As String
		Public Property ReminderInfo() As String
		Private privateCarId? As Int32
		Public Property CarId() As Int32?
			Get
				Return privateCarId
			End Get
			Set(ByVal value? As Int32)
				privateCarId = value
			End Set
		End Property
		Public Property Price() As Double
	End Class
End Namespace
