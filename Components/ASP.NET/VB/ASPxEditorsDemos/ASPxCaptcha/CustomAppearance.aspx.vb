Imports Microsoft.VisualBasic
Imports System
Imports System.Threading
Imports System.Web.UI

Partial Public Class ASPxCaptcha_CustomAppearance
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			Dim captchaValid As Boolean = Captcha.Code = Request.Params("tbCode")
			lblIncorrectCodeMessage.Visible = Not captchaValid
			lblCorrectCodeMessage.Visible = captchaValid
		End If
		If IsCallback Then
			Thread.Sleep(500) ' Intentionally pauses server-side processing, to demonstrate the RefreshButton animation.
		End If
	End Sub
End Class
