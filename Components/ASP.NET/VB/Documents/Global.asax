<%@ Application Language="vb" %>

<script RunAt="server">

    ReadOnly Property DXDocsApp() As DocumentsApp
        Get
            Return DocumentsApp.Instance
        End Get
    End Property
    ReadOnly Property IsWebPageHandler() As Boolean
        Get
            Return Context.Handler IsNot Nothing AndAlso TypeOf Context.Handler Is Page
        End Get
    End Property

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf CallbackError
        If Not DemoUtils.IsSiteMode Then
            DXDocsApp.Start()
        End If
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        If Not DemoUtils.IsSiteMode Then
            DXDocsApp.End()
        End If
    End Sub

    Sub CallbackError(ByVal sender As Object, ByVal e As EventArgs)
        ' Logging exceptions occur on callback events of DevExpress ASP.NET controls. 
        ' To learn more, see http://www.devexpress.com/Support/Center/Example/Details/E2398
    End Sub

    Sub Application_AcquireRequestState(ByVal sender As Object, ByVal e As EventArgs)
        If IsWebPageHandler Then
            DXDocsApp.User.LogUserActivity()
        End If
    End Sub

    Sub Application_PostRequestHandlerExecute(ByVal sender As Object, ByVal e As EventArgs)
        If IsWebPageHandler Then
            DXDocsApp.Data.CloseUnitOfWork()
        End If
    End Sub

</script>