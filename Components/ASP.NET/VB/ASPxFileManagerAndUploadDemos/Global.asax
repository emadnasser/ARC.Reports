<%@ Application Language="vb" %>
<%@ Import Namespace="DevExpress.Web" %>

<script runat="server">

	Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
		RegisterAccounts()
		Utils.EnsureRequestValidationMode()
		AddHandler ASPxWebControl.CallbackError, AddressOf CallbackError
	End Sub

	Sub RegisterAccounts()
		AccountManager.RegisterAmazon("FileManagerAmazonAccount", FileManagmentUtils.GetAmazonAccessKeyID(), FileManagmentUtils.GetAmazonSecretAccessKey())
		AccountManager.RegisterAmazon("UploadAmazonAccount", UploadingUtils.GetAmazonAccessKeyID(), UploadingUtils.GetAmazonSecretAccessKey())
		AccountManager.RegisterAzure("FileManagerAzureAccount", FileManagmentUtils.GetAzureStorageAccountName(), FileManagmentUtils.GetAzureAccessKey())
		AccountManager.RegisterAzure("UploadAzureAccount", UploadingUtils.GetAzureStorageAccountName(), UploadingUtils.GetAzureAccessKey())
		AccountManager.RegisterDropbox("FileManagerDropboxAccount", FileManagmentUtils.GetDropboxAccessTokenValue())
		AccountManager.RegisterDropbox("UploadDropboxAccount", UploadingUtils.GetDropboxAccessTokenValue())
	End Sub

	Sub CallbackError(ByVal sender As Object, ByVal e As EventArgs)
		' Logging exceptions occur on callback events of DevExpress ASP.NET controls. 
		' To learn more, see http://www.devexpress.com/Support/Center/Example/Details/E2398

		Dim exception = HttpContext.Current.Server.GetLastError()
		If TypeOf exception Is DemoException Then
			ASPxWebControl.SetCallbackErrorMessage(exception.Message)
		End If
		If exception.GetType().FullName = "System.Data.Entity.Core.UpdateException" Then
			If exception.InnerException IsNot Nothing Then
				Dim errorText As String = ProcessEntityUpdateExceptionMessage(exception.InnerException.Message)
				ASPxWebControl.SetCallbackErrorMessage(errorText)
			End If
		End If
	End Sub

	Function ProcessEntityUpdateExceptionMessage(ByVal message As String) As String
		Dim pattern As String = "'(?<path>[^']*mdf\.)([^']*)'"
		Dim match = Regex.Match(message, pattern, RegexOptions.IgnoreCase)
		Dim group = match.Groups("path")
		If group.Success Then
			Return message.Replace(group.ToString(), String.Empty)
		End If
		Return message
	End Function

	Sub Application_PreRequestHandlerExecute(ByVal sender As Object, ByVal e As EventArgs)
		If CurrentPage IsNot Nothing Then
			AddHandler CurrentPage.PreInit, AddressOf Page_PreInit
		End If

		If (Not Utils.IsIntro) Then
			DevExpress.Web.ASPxWebControl.GlobalTheme = Utils.CurrentTheme
			Utils.ResolveThemeParametes()
		End If

		If Utils.IsAccessibilityDemo Then
			ASPxWebControl.GlobalAccessibilityCompliant = True
		End If
	End Sub

	Shared ReadOnly Property CurrentPage() As Page
		Get
			Return TryCast(HttpContext.Current.CurrentHandler, Page)
		End Get
	End Property

	Shared Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCurrentWebFormsDemo(CurrentPage)
		Utils.InjectDescriptionMeta(CurrentPage.Master)
	End Sub

</script>