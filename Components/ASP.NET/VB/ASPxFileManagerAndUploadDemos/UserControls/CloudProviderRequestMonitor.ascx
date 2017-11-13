<%@ Control Language="vb" %>
<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<script runat="server">
	Dim logHtmlKey As String = "ASPxCloudProviderEventMonitorLogKey"
	Property PropertyNameCellWidth() As Integer
	Property LogHtml() As String
		Get
			If Session(logHtmlKey) Is Nothing Then
				Session(logHtmlKey) = String.Empty
			End If
			Return Session(logHtmlKey).ToString()
		End Get
		Set(ByVal value As String)
			Session(logHtmlKey) = value
		End Set
	End Property
	Public Sub TraceEvent(ByVal sender As Object, ByVal e As FileManagerCloudProviderRequestEventArgs, ByVal type As FileManagerProviderType)
		Dim request = e.Request
		Dim builder As New StringBuilder()
		builder.Append("<table cellspacing=""0"" cellpadding=""0"" border=""0"">")
		AppendRow(builder, "Sender", (TryCast(sender, Control)).ID)
		AppendRow(builder, "Method", request.Method)
		AppendRow(builder, "Date", DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss.FFF"))
		Select Case type
			Case FileManagerProviderType.Dropbox
				PropertyNameCellWidth = 120
				AppendRow(builder, "Url", request.RequestUri.ToString())
				If request.Headers("Dropbox-API-Arg") IsNot Nothing Then
					AppendRow(builder, "Dropbox-API-Arg", request.Headers("Dropbox-API-Arg"))
				End If
				AppendRow(builder, "ContentType", request.ContentType)
				AppendRow(builder, "ContentLength", request.ContentLength.ToString())
			Case FileManagerProviderType.Azure
				PropertyNameCellWidth = 150
				AppendRow(builder, "Url header", request.RequestUri.ToString())
				AppendRow(builder, "x-ms-date header", request.Headers("x-ms-date"))
			Case FileManagerProviderType.Amazon
				PropertyNameCellWidth = 200
				AppendRow(builder, "Url", request.RequestUri.ToString())
				AppendRow(builder, "X-Amz-Date header", request.Headers("X-Amz-Date"))
				AppendRow(builder, "X-Amz-Content-SHA256 header", request.Headers("X-Amz-Content-SHA256"))
		End Select

		builder.Append("</table><br />")
		LogHtml = builder.ToString() & LogHtml
	End Sub
	Sub AppendRow(ByVal builder As StringBuilder, ByVal name As String, ByVal content As String)
		builder.Append("<tr valign=""top""><td style=""width: " & PropertyNameCellWidth.ToString() & "px"">")
		If (Not String.IsNullOrEmpty(name)) Then
			builder.AppendFormat("<b>{0}:</b>", HttpUtility.HtmlEncode(name))
		End If
		builder.AppendFormat("<td>{0}</td></tr>", HttpUtility.HtmlEncode(content))
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not LogHiddenField.Contains(logHtmlKey)) Then
			LogHiddenField(logHtmlKey) = String.Empty
		End If

		LogHiddenField(logHtmlKey) = LogHtml + LogHiddenField(logHtmlKey)
		LogHtml = String.Empty
		EventLog.InnerHtml = LogHiddenField(logHtmlKey).ToString()
	End Sub
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