Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.XtraGauges.Base

Partial Public Class StylesPage
	Inherits Page
	Protected ReadOnly Property GaugeContainer() As IGaugeContainer
		Get
			Return TryCast(gaugeControl, IGaugeContainer)
		End Get
	End Property
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		GaugeContainer.ForceClearOnRestore = True
		GaugeContainer.RestoreLayoutFromXml(MapPath("~/App_Data/Styles/" & CStr(style.Value)))
	End Sub
End Class
