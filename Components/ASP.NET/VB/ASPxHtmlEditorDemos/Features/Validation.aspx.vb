Imports Microsoft.VisualBasic
Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxHtmlEditor

Partial Public Class Features_Validation
	Inherits Page
	Public Const MaxLength As Integer = 50
	Public CustomErrorText As String = String.Format("Custom validation fails because the HTML content's length exceeds {0} characters.", MaxLength)

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			DemoHtmlEditor.Html = HtmlEditorUtils.GetHtml(Page, "Features/Validation.html")
		End If
		DemoHtmlEditor.SettingsValidation.RequiredField.IsRequired = chbIsRequired.Checked
		lblContentLength.Text = DemoHtmlEditor.Html.Length.ToString()
	End Sub

	Protected Sub DemoHtmlEditor_Validation(ByVal sender As Object, ByVal e As HtmlEditorValidationEventArgs)
		If chbValidateOnServer.Checked AndAlso e.Html.Length > MaxLength Then
			e.IsValid = False
			e.ErrorText = CustomErrorText
		End If
	End Sub
End Class
