Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal

Partial Public Class Templates_MyAppointmentForm
	Inherits SchedulerFormControl
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		PrepareChildControls()
		tbSubject.Focus()
	End Sub
	Public Overrides Sub DataBind()
		MyBase.DataBind()
		Dim container As MyAppointmentFormTemplateContainer = CType(Parent, MyAppointmentFormTemplateContainer)
		AppointmentRecurrenceForm1.Visible = container.ShouldShowRecurrence

		btnOk.ClientSideEvents.Click = container.SaveHandler
		btnCancel.ClientSideEvents.Click = container.CancelHandler
		btnDelete.ClientSideEvents.Click = container.DeleteHandler
	End Sub
	Protected Overrides Sub PrepareChildControls()
		Dim container As AppointmentFormTemplateContainer = CType(Parent, AppointmentFormTemplateContainer)
		Dim control As ASPxScheduler = container.Control

		AppointmentRecurrenceForm1.EditorsInfo = New EditorsInfo(control, control.Styles.FormEditors, control.Images.FormEditors, control.Styles.Buttons)
		MyBase.PrepareChildControls()
	End Sub
	Protected Overrides Function GetChildEditors() As ASPxEditBase()
		Dim edits() As ASPxEditBase = { lblDemoShortDescription, lblDemoLongDescription, lblSubject, tbSubject, lblLocation, tbLocation, lblStartTime, edtStartDate, lblEndTime, edtEndDate, lblDescription, memDescription, lblContactInfo }
		Return edits
	End Function
	Protected Overrides Function GetChildButtons() As ASPxButton()
		Dim buttons() As ASPxButton = { btnOk, btnCancel, btnDelete }
		Return buttons
	End Function
End Class
