Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.XtraGauges.Core.Model

Partial Public Class DigitalGaugePage
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		dGauge1.DigitCount = CInt(Fix(digitCount.Number))
		dGauge1.DisplayMode = CType(displayMode.Value, DigitalGaugeDisplayMode)
	End Sub
End Class
