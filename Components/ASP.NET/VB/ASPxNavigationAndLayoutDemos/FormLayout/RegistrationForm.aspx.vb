Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class FormLayout_RegistrationForm
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack AndAlso captcha.IsValid AndAlso ASPxEdit.ValidateEditorsInContainer(Me) Then
			Page.ClientScript.RegisterStartupScript(Me.GetType(), "alert", "<script type=""text/javascript"">alert('You have successfully registered');</script>")
		End If
	End Sub
End Class
