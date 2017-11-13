Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Drawing
Imports System.Web

Partial Public Class HorizontalAlldayAreaAppointment
	Inherits System.Web.UI.UserControl
	Private ReadOnly Property Container() As HorizontalAppointmentTemplateContainer
		Get
			Return CType(Parent, HorizontalAppointmentTemplateContainer)
		End Get
	End Property
	Private ReadOnly Property Items() As HorizontalAppointmentTemplateItems
		Get
			Return Container.Items
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Me.lblSubject.Text = HttpUtility.HtmlEncode(Container.AppointmentViewInfo.Appointment.Subject)
		Me.lblLocation.Text = GetLocationText()

		startTimeClockContainer.Controls.Add(Items.StartTimeClock)
		endTimeClockContainer.Controls.Add(Items.EndTimeClock)
	End Sub
	Private Function GetLocationText() As String
		Dim location As String = HttpUtility.HtmlEncode(Container.AppointmentViewInfo.Appointment.Location)
		If String.IsNullOrEmpty(location) Then
			Return String.Empty
		Else
			Return String.Format("({0})", location)
		End If

	End Function
End Class
