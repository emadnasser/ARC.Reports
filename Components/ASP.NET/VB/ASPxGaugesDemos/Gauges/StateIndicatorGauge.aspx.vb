Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class StateIndicatorGaugePage
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsCallback) Then
			indicator1.StateIndex = CInt(Fix(state1.Number))
			indicator2.StateIndex = CInt(Fix(state2.Number))
			indicator3.StateIndex = CInt(Fix(state3.Number))
			indicator4.StateIndex = CInt(Fix(state4.Number))
			indicator5.StateIndex = CInt(Fix(state5.Number))
			indicator6.StateIndex = CInt(Fix(state6.Number))
		End If
	End Sub
	Protected Sub OnGauge1CustomCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		indicator1.StateIndex = CInt(Fix(state1.Number))
	End Sub
	Protected Sub OnGauge2CustomCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		indicator2.StateIndex = CInt(Fix(state2.Number))
	End Sub
	Protected Sub OnGauge3CustomCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		indicator3.StateIndex = CInt(Fix(state3.Number))
	End Sub
	Protected Sub OnGauge4CustomCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		indicator4.StateIndex = CInt(Fix(state4.Number))
	End Sub
	Protected Sub OnGauge5CustomCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		indicator5.StateIndex = CInt(Fix(state5.Number))
	End Sub
	Protected Sub OnGauge6CustomCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		indicator6.StateIndex = CInt(Fix(state6.Number))
	End Sub
End Class
