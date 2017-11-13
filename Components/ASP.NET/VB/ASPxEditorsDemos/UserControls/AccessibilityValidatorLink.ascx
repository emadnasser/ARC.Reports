<%@ Control Language="vb" %>
<script runat="server">
	Protected Sub hlValidateWAVE_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim hyperLink As ASPxHyperLink = CType(sender, ASPxHyperLink)
		hyperLink.Visible = Utils.IsSiteMode
		hyperLink.NavigateUrl = "http://wave.webaim.org/report?url=" & Page.Request.Url.AbsoluteUri
	End Sub
</script>
<div style="margin-top: 36px; margin-right: 2px; float: right;">
	<dx:ASPxHyperLink ID="hlValidateWAVE" runat="server" Target="_blank" Text="Validate with WAVE"
		ImageUrl="~/Content/WAVE.png" OnInit="hlValidateWAVE_Init">
	</dx:ASPxHyperLink>
</div>