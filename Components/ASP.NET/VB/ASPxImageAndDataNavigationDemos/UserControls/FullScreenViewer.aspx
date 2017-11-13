<%@ Page Language="vb" AutoEventWireup="true" EnableTheming="false" %>
<script runat="server">
	Public Const DocumentFrameWidth As Integer = 40

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim currentResolution As New FullScreenModeResolution()
		Dim url As String = Request.QueryString("url")
		If (Not String.IsNullOrEmpty(url)) Then
			Document.Attributes("src") = ResolveClientUrl(url)
		End If
		Dim width As String = Request.QueryString("width")
		If (Not String.IsNullOrEmpty(width)) Then
			Dim widthValue As Integer
			If Integer.TryParse(width, widthValue) Then
				DocumentContainer.Style("width") = (widthValue + DocumentFrameWidth) & "px"
				QrcodeContainer.Style("width") = (widthValue + DocumentFrameWidth) & "px"
				currentResolution.Width = widthValue
			End If
		End If
		Dim height As String = Request.QueryString("height")
		If (Not String.IsNullOrEmpty(height)) Then
			Dim heightValue As Integer
			If Integer.TryParse(height, heightValue) Then
				DocumentContainer.Style("height") = (heightValue + DocumentFrameWidth) & "px"
				currentResolution.Height = heightValue
			End If
		End If
		If (Not String.IsNullOrEmpty(width)) AndAlso (Not String.IsNullOrEmpty(height)) Then
			form1.Attributes("class") = "viewer"
		End If
		If (Not String.IsNullOrEmpty(url)) Then
			QrcodeLink.Attributes("href") = url
			QrcodeImg.Attributes("src") = FullScreenModeUtils.GetQRCodeImageUrl(Me, url)
		End If

		Repeater.DataSource = FullScreenModeUtils.Resolutions
		Repeater.DataBind()

		Dim currentIndex As Integer = FullScreenModeUtils.Resolutions.FindIndex(Function(r) currentResolution.Width = r.Width AndAlso currentResolution.Height = r.Height)
		If currentIndex > -1 Then
			Dim link As ASPxHyperLink = TryCast(Repeater.Items(currentIndex).FindControl("resolutionLink"), ASPxHyperLink)
			If link IsNot Nothing Then
				link.CssClass = "currentResolution"
			End If
		End If
	End Sub
	Public Function GetResolutionUrl(ByVal dataItem As Object) As String
		Dim resolution As FullScreenModeResolution = CType(dataItem, FullScreenModeResolution)
		Return FullScreenModeUtils.GetUrl(Page, Request.QueryString("url"), resolution.Width, resolution.Height)
	End Function
</script>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>FullScreen Mode Viewer</title>
	<style>
		html, body, form
		{
			padding: 0;
			margin: 0;
			width: 100%;
			height: 100%;
			overflow: hidden;
			box-sizing: border-box;
			font: 14px Tahoma;
		}
		.viewer 
		{
			overflow: auto;
		}
		.topPanel
		{
			background-color: white!important;
			border-color: #c3c3c3!important;
			padding: 12px 0!important;
		}
		.topPanel a,
		.topPanel a:hover,
		.topPanel a:visited
		{
			color: #646464;
		}
		.topPanel a.currentResolution {
			font-weight: bold;
			text-decoration: none;
		}
		.resolutionSelector
		{
			width: 400px;
			margin: 0 auto;
		}
		.resolutionSelector a
		{
			margin-right: 12px;
		}
		.documentContainer,
		.documentFrame,
		.document
		{
			width: 100%;
			height: 100%;
		}
		.viewer .documentContainer,
		.documentFrame,
		.document
		{
			box-sizing: border-box;
		}
		.documentContainer
		{
			margin-top: -30px;
			padding-top: 30px;
			display: block;
		}
		.viewer .documentContainer
		{
			border: 2px solid #c3c3c3;
			border-radius: 30px;
			margin: 30px auto;
			padding: 2px;
		}
		.viewer .documentFrame
		{
			border: 1px solid #dbdbdb;
			border-radius: 26px;
			padding: 32px;
		}
		.document
		{
			border: 0;
			padding: 1px 0 0;
		}
		.viewer .document
		{
			border: 2px solid #c3c3c3;
			padding: 1px;
		}
		.qrcodeContainer
		{
			margin: 0 auto;
			padding: 40px 0;
			height: 140px;
			margin-bottom: -230px;
			display: none;
		}
		.viewer .qrcodeContainer
		{
			display: block;
		}
		.qrcode
		{
			background-color: white;
			margin-right: -160px;
			float: right;
		}
		.qrcode img
		{
			border: 1px solid #c3c3c3;
			padding: 1px;
			width:120px;
			height:120px;
		}
		.qrcodeHint
		{
			padding: 10px 0 0;
			margin: 0 -10px;
			color:#a6a6a6;
			font: 12px Tahoma;
			text-align: center;
		}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<dx:ASPxPanel ID="TopPanel" CssClass="topPanel" runat="server" FixedPosition="WindowTop" Height="14px">
			<PanelCollection>
				<dx:PanelContent runat="server" SupportsDisabledAttribute="True">
					<div class="resolutionSelector">
						<asp:Repeater ID="Repeater" runat="server">
							<ItemTemplate>
								<dx:ASPxHyperLink ID="resolutionLink" runat="server" NavigateUrl='<%#GetResolutionUrl(Container.DataItem)%>' Text='<%#Eval("Name")%>'></dx:ASPxHyperLink>
							</ItemTemplate>
						</asp:Repeater>
					</div>
				</dx:PanelContent>
			</PanelCollection>
		</dx:ASPxPanel>
		<div class="qrcodeContainer" runat="server" id="QrcodeContainer">
			<div class="qrcode" runat="server" id="Qrcode">
				<div>
					<a id="QrcodeLink" runat="server" href="#" target="_blank"><img id="QrcodeImg" runat="server" src="" alt="QRCode" /></a>
				</div>
				<div class="qrcodeHint">View on a Tablet</div>
			</div>
		</div>
		<div class="documentContainer" runat="server" id="DocumentContainer">
			<div class="documentFrame">
				<iframe class="document" runat="server" id="Document"></iframe>
			</div>
		</div>
	</form>
</body>
</html>