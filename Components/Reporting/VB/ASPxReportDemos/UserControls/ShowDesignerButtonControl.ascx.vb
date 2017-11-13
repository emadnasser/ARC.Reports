Imports Microsoft.VisualBasic
Imports System.Web
Imports System.Web.UI

Partial Public Class UserControls_ShowDesignerButtonControl
	Inherits UserControl
	Implements IShowDesignerButtonControl
	Public Property ReportTypeName() As String Implements IShowDesignerButtonControl.ReportTypeName

	Protected ReadOnly Property RunDesignerUrl() As String
		Get
			Dim reportName = HttpUtility.UrlEncode(ReportTypeName)
			Dim redirectUrl = Request.RawUrl
			redirectUrl = HttpUtility.UrlEncode(redirectUrl)
			redirectUrl = ReportDesignerUrlLogic.CleanUrl(redirectUrl, True)
			Return String.Format("~/Designer.aspx?reportName={0}&amp;redirectUrl={1}", reportName, redirectUrl)
		End Get
	End Property
End Class
