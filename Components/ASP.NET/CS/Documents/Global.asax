<%@ Application Language="C#" %>

<script RunAt="server">

    DocumentsApp DXDocsApp { get { return DocumentsApp.Instance; } }
    bool IsWebPageHandler { 
        get { return Context.Handler != null && Context.Handler is Page; }
    }

    void Application_Start(object sender, EventArgs e) {
        DevExpress.Web.ASPxWebControl.CallbackError += new EventHandler(CallbackError);
        if(!DemoUtils.IsSiteMode)
            DXDocsApp.Start();
    }

    void Application_End(object sender, EventArgs e) {
        if(!DemoUtils.IsSiteMode)
            DXDocsApp.End();
    }

    void CallbackError(object sender, EventArgs e) {
        // Logging exceptions occur on callback events of DevExpress ASP.NET controls. 
        // To learn more, see http://www.devexpress.com/Support/Center/Example/Details/E2398
    }

    void Application_AcquireRequestState(object sender, EventArgs e) {
        if(IsWebPageHandler)
            DXDocsApp.User.LogUserActivity();
    }

    void Application_PostRequestHandlerExecute(object sender, EventArgs e) {
        if(IsWebPageHandler)
            DXDocsApp.Data.CloseUnitOfWork();
    }
       
</script>
