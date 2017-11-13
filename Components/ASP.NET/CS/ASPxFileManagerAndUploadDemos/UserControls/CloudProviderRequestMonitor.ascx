<%@ Control Language="C#" %>
<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<script runat="server">
    string logHtmlKey = "ASPxCloudProviderEventMonitorLogKey";
    int PropertyNameCellWidth { get; set; }
    string LogHtml {
        get {
            if(Session[logHtmlKey] == null)
                Session[logHtmlKey] = string.Empty;
            return Session[logHtmlKey].ToString();
        }
        set {
            Session[logHtmlKey] = value;
        }
    }
    public void TraceEvent(object sender, FileManagerCloudProviderRequestEventArgs e, FileManagerProviderType type) {
        var request = e.Request;
        StringBuilder builder = new StringBuilder();
        builder.Append("<table cellspacing=\"0\" cellpadding=\"0\" border=\"0\">");
        AppendRow(builder, "Sender", (sender as Control).ID);
        AppendRow(builder, "Method", request.Method);
        AppendRow(builder, "Date", DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss.FFF"));
        switch(type) {
            case FileManagerProviderType.Dropbox:
                PropertyNameCellWidth = 120;
                AppendRow(builder, "Url", request.RequestUri.ToString());
                if(request.Headers["Dropbox-API-Arg"] != null)
                    AppendRow(builder, "Dropbox-API-Arg", request.Headers["Dropbox-API-Arg"]);
                AppendRow(builder, "ContentType", request.ContentType);
                AppendRow(builder, "ContentLength", request.ContentLength.ToString());
                break;
            case FileManagerProviderType.Azure:
                PropertyNameCellWidth = 150;
                AppendRow(builder, "Url header", request.RequestUri.ToString());
                AppendRow(builder, "x-ms-date header", request.Headers["x-ms-date"]);
                break;
            case FileManagerProviderType.Amazon:
                PropertyNameCellWidth = 200;
                AppendRow(builder, "Url", request.RequestUri.ToString());
                AppendRow(builder, "X-Amz-Date header", request.Headers["X-Amz-Date"]);
                AppendRow(builder, "X-Amz-Content-SHA256 header", request.Headers["X-Amz-Content-SHA256"]);
                break;                
        }
        
        builder.Append("</table><br />");
        LogHtml = builder.ToString() + LogHtml;
    }
    void AppendRow(StringBuilder builder, string name, string content) {
        builder.Append("<tr valign=\"top\"><td style=\"width: " + PropertyNameCellWidth.ToString() + "px\">");
        if(!String.IsNullOrEmpty(name))
            builder.AppendFormat("<b>{0}:</b>", HttpUtility.HtmlEncode(name));
        builder.AppendFormat("<td>{0}</td></tr>", HttpUtility.HtmlEncode(content));
    }
    
    protected void Page_Load(object sender, EventArgs e) {
        if(!LogHiddenField.Contains(logHtmlKey))
            LogHiddenField[logHtmlKey] = string.Empty;
        
        LogHiddenField[logHtmlKey] = LogHtml + LogHiddenField[logHtmlKey];
        LogHtml = string.Empty;
        EventLog.InnerHtml = LogHiddenField[logHtmlKey].ToString();
    } 
</script>
<script type="text/javascript">
    function OnClearButtonClick(s, e) {
        logHiddenField.Clear();
        document.getElementById("<%=EventLog.ClientID%>").innerHTML = "";
    }
</script>
    
<div class="EventLogPanel" style="width: 100%">
    <dx:ASPxHiddenField ID="LogHiddenField" ClientInstanceName="logHiddenField" runat="server" />
    <div runat="server" id="EventLog" class="EventLog" style="width: 100%; height: 250px;"></div>
    <dx:ASPxButton runat="server" ID="ClearButton" Text="Clear" AutoPostBack="false">
        <ClientSideEvents Click="OnClearButtonClick"></ClientSideEvents>
    </dx:ASPxButton>    
</div>
