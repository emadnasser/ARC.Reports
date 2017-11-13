Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal
Imports DevExpress.XtraScheduler

Public Class CustomFieldNames
	Public Const ContactInfo As String = "ContactInfo"
End Class


Public Class MyAppointmentFormTemplateContainer
	Inherits AppointmentFormTemplateContainer
	Public Sub New(ByVal control As ASPxScheduler)
		MyBase.New(control)
	End Sub
	Public ReadOnly Property ContactInfo() As String
		Get
			Return Convert.ToString(Appointment.CustomFields(CustomFieldNames.ContactInfo))
		End Get
	End Property
End Class
Public Class MyAppointmentSaveCallbackCommand
	Inherits AppointmentFormSaveCallbackCommand
	Public Sub New(ByVal control As ASPxScheduler)
		MyBase.New(control)
	End Sub
	Protected Friend Shadows ReadOnly Property Controller() As MyAppointmentFormController
		Get
			Return CType(MyBase.Controller, MyAppointmentFormController)
		End Get
	End Property

	Protected Overrides Sub AssignControllerValues()
		Dim tbSubject As ASPxTextBox = CType(FindControlByID("tbSubject"), ASPxTextBox)
		Dim tbLocation As ASPxTextBox = CType(FindControlByID("tbLocation"), ASPxTextBox)
		Dim edtStartDate As ASPxDateEdit = CType(FindControlByID("edtStartDate"), ASPxDateEdit)
		Dim edtEndDate As ASPxDateEdit = CType(FindControlByID("edtEndDate"), ASPxDateEdit)
		Dim memDescription As ASPxMemo = CType(FindControlByID("memDescription"), ASPxMemo)
		Dim memContacts As ASPxMemo = CType(FindControlByID("memContacts"), ASPxMemo)

		Controller.Subject = tbSubject.Text
		Controller.Location = tbLocation.Text
		Controller.Description = memDescription.Text

		Controller.Start = edtStartDate.Date
		Controller.End = edtEndDate.Date
		' custom field 
		Controller.ContactInfo = memContacts.Text

		Dim clientStart As DateTime = FromClientTime(Controller.Start)
		AssignControllerRecurrenceValues(clientStart)
	End Sub
	Protected Overrides Function CreateAppointmentFormController(ByVal apt As Appointment) As AppointmentFormController
		Return New MyAppointmentFormController(Control, apt)
	End Function
End Class

Public Class MyAppointmentFormController
	Inherits AppointmentFormController
	Private Const ContactInfoFieldName As String = "ContactInfo"

	Public Sub New(ByVal control As ASPxScheduler, ByVal apt As Appointment)
		MyBase.New(control, apt)
	End Sub
	Public Property ContactInfo() As String
		Get
			Return CStr(EditedAppointmentCopy.CustomFields(ContactInfoFieldName))
		End Get
		Set(ByVal value As String)
			EditedAppointmentCopy.CustomFields(ContactInfoFieldName) = value
		End Set
	End Property

	Private Property SourceContactInfo() As String
		Get
			Return CStr(SourceAppointment.CustomFields(ContactInfoFieldName))
		End Get
		Set(ByVal value As String)
			SourceAppointment.CustomFields(ContactInfoFieldName) = value
		End Set
	End Property

	Public Overrides Function IsAppointmentChanged() As Boolean
		If MyBase.IsAppointmentChanged() Then
			Return True
		End If
		Return SourceContactInfo <> ContactInfo
	End Function
	Protected Overrides Sub ApplyCustomFieldsValues()
		SourceContactInfo = ContactInfo
	End Sub
End Class
