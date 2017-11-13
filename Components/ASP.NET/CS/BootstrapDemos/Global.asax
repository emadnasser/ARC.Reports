<%@ Application Language="C#" %>

<script RunAt="server">
    void Application_BeginRequest(object sender, EventArgs e) {
        string relativePath = Request.Path.Substring(Request.ApplicationPath.Length).Trim('/');
        if(relativePath.EndsWith("axd"))
            return;
        if(DemoUtils.CurrentResolution == Resolution.Default)
            return;
        if(DemoUtils.IsFrame || DemoUtils.IsFrameContainer)
            return;
        Server.Transfer("~/Shared/DemoViewer.aspx?url=" + Request.Url.LocalPath + "&resolution=" + DemoUtils.CurrentResolution.ToString(), false);
    }
</script>
