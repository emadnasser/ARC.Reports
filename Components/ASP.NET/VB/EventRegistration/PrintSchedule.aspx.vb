Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports EventRegistration

Partial Public Class PrintSchedule
	Inherits System.Web.UI.Page
	Public ReadOnly Property AllSessions() As List(Of Session)
		Get
			Return CurrentData.Sessions.ToList()
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsCallback) Then
			CurrentData.PrintingStatus = Nothing
		End If
		ReportViewer1.Report = New ScheduleReport(SelectAppointments(CurrentData.PrintingStatus))
	End Sub

	Private Function SelectAppointments(ByVal print As String) As List(Of Session)
		If print = "All" Then
			Return AllSessions
		End If

		Dim selectedSessions As New List(Of Session)()
		selectedSessions = AllSessions.FindAll(Function(s) s.Interest >= 1)
		Return If(selectedSessions.Count = 0, AllSessions, selectedSessions)
	End Function
	Protected Sub cbChangePrintingStatus_Callback(ByVal source As Object, ByVal e As DevExpress.Web.CallbackEventArgs)
		CurrentData.PrintingStatus = e.Parameter
	End Sub
End Class
