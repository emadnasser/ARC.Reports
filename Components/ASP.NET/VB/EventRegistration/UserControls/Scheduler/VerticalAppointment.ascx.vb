Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Drawing
Imports DevExpress.Web
Imports DevExpress.Web.Internal
Imports DevExpress.XtraScheduler

Partial Public Class UserControls_VerticalAppointment
	Inherits System.Web.UI.UserControl
	Private ReadOnly Property Container() As VerticalAppointmentTemplateContainer
		Get
			Return CType(Parent, VerticalAppointmentTemplateContainer)
		End Get
	End Property
	Private ReadOnly Property CurAppointment() As Appointment
		Get
			Return Container.AppointmentViewInfo.Appointment
		End Get
	End Property
	Private ReadOnly Property Items() As VerticalAppointmentTemplateItems
		Get
			Return Container.Items
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		PrepareChildControls()
	End Sub

	Private Sub PrepareChildControls()
		AppointmentDiv.Style.Value = Items.AppointmentStyle.GetStyleAttributes(Page).Value
		StatusContainer.Controls.Add(Items.StatusControl)

		Dim speaker As Object = CurAppointment.CustomFields(CustomFileldNames.Speaker)
		If speaker IsNot DBNull.Value Then
			lblSpeaker.Text = CStr(speaker)
		End If
		cmbAttendingSwitch.SelectedIndex = CInt(Fix(CurAppointment.LabelKey))
		cmbAttendingSwitch.ClientSideEvents.ValueChanged = "function(s, e) { ResizeSwitcher(s, e); ChangeAppointmentLabel('" & CurAppointment.Id.ToString() & "', s.GetValue()); }"
	End Sub
End Class
