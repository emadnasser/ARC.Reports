Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.ASPxGauges
Imports DevExpress.Web.ASPxGauges.Base
Imports DevExpress.XtraGauges.Core.Model

Partial Public Class Gadgets_WorldTime
	Inherits Page
	Private timeShifts As Dictionary(Of String, Integer)
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		timeShifts = New Dictionary(Of String, Integer)()
		timeShifts.Add("Washington", -4)
		timeShifts.Add("Paris", +1)
		timeShifts.Add("Moscow", +4)
		timeShifts.Add("London", +0)
		timeShifts.Add("Tokyo", +9)
		timeShifts.Add("Rome", +1)
		UpdateWorldTime()
	End Sub
	Protected Sub OnTimerCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		UpdateWorldTime()
	End Sub
	Protected Sub UpdateWorldTime()
		UpdateClock(Washington)
		UpdateClock(Paris)
		UpdateClock(Moscow)
		UpdateClock(London)
		UpdateClock(Tokyo)
		UpdateClock(Rome)
	End Sub
	'
	Protected Sub UpdateClock(ByVal gaugeControl As ASPxGaugeControl)
		Dim time As DateTime = DateTime.UtcNow.AddHours(timeShifts(gaugeControl.ID))
		Dim cGauge As ICircularGauge = TryCast(gaugeControl.Gauges(0), ICircularGauge)
		If cGauge IsNot Nothing Then
			UpdateScales(time, cGauge.Scales(0), cGauge.Scales(1))
		End If
	End Sub
	Protected Sub UpdateScales(ByVal dt As DateTime, ByVal h As IArcScale, ByVal m As IArcScale)
		Dim hour As Integer = If(dt.Hour < 12, dt.Hour, dt.Hour - 12)
		Dim min As Integer = dt.Minute
		Dim sec As Integer = dt.Second
		h.Value = CSng(hour) + CSng(min) / 60.0f
		m.Value = (CSng(min) + CSng(sec) / 60.0f) / 5f
	End Sub
End Class
