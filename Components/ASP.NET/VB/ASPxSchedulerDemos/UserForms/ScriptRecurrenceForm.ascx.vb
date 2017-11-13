Imports Microsoft.VisualBasic
Imports System.Web.UI
Imports DevExpress.Web.ASPxScheduler

Partial Public Class UserForms_ScriptRecurrenceForm
	Inherits ASPxSchedulerClientFormBase
	Public Overrides ReadOnly Property ClassName() As String
		Get
			Return "ASPxClientRecurrenceAppointmentForm"
		End Get
	End Property

	Protected Overrides Function GetChildControls() As Control()
		Dim controls() As Control = { edtDailyRecurrenceControl, edtWeeklyRecurrenceControl, edtMonthlyRecurrenceControl, edtYearlyRecurrenceControl, edtRecurrenceTypeEdit, edtRecurrenceRangeControl}
		Return controls
	End Function
End Class
