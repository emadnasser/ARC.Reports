Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.Design
Imports System.Web.UI.WebControls

Partial Public Class UserControls_MobileEmulator
	Inherits System.Web.UI.UserControl
	Implements IMobileEmulator
	Public ReadOnly Property IsLandscape() As Boolean
		Get
			Return ReportTypeName = "XtraReportsDemos.CharacterComb.Report" OrElse ReportTypeName = "XtraReportsDemos.PivotGridAndChart.Report"
		End Get
	End Property
	Public Property ReportTypeName() As String Implements IMobileEmulator.ReportTypeName
	Public ReadOnly Property Url() As String
		Get
			Return String.Format("~/MobileViewer.aspx?reportName={0}", HttpUtility.UrlEncode(ReportTypeName))
		End Get
	End Property
	Public ReadOnly Property QRCodeSize() As Integer
		Get
			Return 124
		End Get
	End Property
	Public ReadOnly Property QRCodeUrl() As String
		Get
			Dim absoluteUri = New System.Uri(Page.Request.Url, ResolveClientUrl(Url)).AbsoluteUri
			Return String.Format("http://chart.apis.google.com/chart?cht=qr&chs={0}x{1}&chl={2}&chld=H%7C0", QRCodeSize, QRCodeSize, absoluteUri)
		End Get
	End Property
End Class
