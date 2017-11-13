Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.GroupType
	''' <summary>
	''' Summary description for Report.
	''' </summary>
	Partial Public Class Report
		Inherits XtraSchedulerReport

		Public Sub New()

			InitializeComponent()
		End Sub

		Public Property GroupType() As SchedulerGroupType
			Get
				Return reportWeekView1.GroupType
			End Get
			Set(ByVal value As SchedulerGroupType)
				reportWeekView1.GroupType = value
			End Set
		End Property

		Private Sub resourceInfo1_CustomizeText(ByVal sender As Object, ByVal e As TextCustomizingEventArgs) Handles resourceInfo1.CustomizeText
			Dim args As ResourceTextCustomizingEventArgs = CType(e, ResourceTextCustomizingEventArgs)
			If (args.Resources.Count = 1) AndAlso (args.Resources(0).Id.Equals(EmptyResourceId.Id)) Then
				args.Text = "Total Report"
			End If
		End Sub
	End Class
End Namespace
