Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.Appearance
	''' <summary>
	''' Summary description for Report.
	''' </summary>
	Partial Public Class Report
		Inherits XtraSchedulerReport

		Public Sub New()

			InitializeComponent()
		End Sub
		Public ReadOnly Property Appearances() As ReportDayViewAppearance
			Get
				Return reportDayView1.Appearance
			End Get
		End Property

		Public Property AppointmentsColorSchema() As PrintColorSchema
			Get
				Return dayViewTimeCells1.PrintColorSchemas.Appointment
			End Get
			Set(ByVal value As PrintColorSchema)
				dayViewTimeCells1.PrintColorSchemas.Appointment = value
			End Set
		End Property
		Public Property ReportColorSchema() As PrintColorSchema
			Get
				Return Me.PrintColorSchema
			End Get
			Set(ByVal value As PrintColorSchema)
				Me.PrintColorSchema = value
			End Set
		End Property
	End Class
End Namespace
