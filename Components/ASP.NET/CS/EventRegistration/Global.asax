<%@ Application Language="C#" %>
<%@ Import Namespace="System.Collections.Generic" %>

<script runat="server">
    void Application_Start(object sender, EventArgs e) 
    {
        DataHelper.LoadDataBase();
        Application["Sessions"] = DataHelper.Data.Sessions;
        DevExpress.Web.Internal.DemoUtils.RegisterDemo("EventRegistration");
    }
</script>
