Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal

Public Class MyInplaceEditorSaveCallbackCommand
	Inherits AppointmentInplaceEditorSaveCallbackCommand
	Public Sub New(ByVal control As ASPxScheduler)
		MyBase.New(control)
	End Sub
	Protected Overrides Sub AssignControllerValues()
		Dim txSubject As TextBox = CType(FindControlByID("txSubject"), TextBox)
		If txSubject IsNot Nothing Then
			Controller.Subject = txSubject.Text
		End If
	End Sub
End Class
