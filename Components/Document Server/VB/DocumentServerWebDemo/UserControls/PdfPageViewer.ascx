<%@ Control Language="vb" AutoEventWireup="true" CodeFile="PdfPageViewer.ascx.vb" Inherits="UserControls_PdfPageViewer" %>
<script type="text/javascript">
	function aspxPagerOnClick(name, value) {
		CallbackPanel.PerformCallback(value);
	}
</script>
<dx:ASPxCallbackPanel ID="ASPxCallbackPanel" ClientInstanceName="CallbackPanel" runat="server" OnCallback="OnCallback">
	<panelcollection>
		<dx:PanelContent ID="PanelContent1" runat="server">
			<div style="min-height:500px">
				<dx:PdfPager id="pager" runat="server" ItemsPerPage="1" Width="100%" ItemCount="0"/>
				<br />
				<table style="border:solid; border-width:1px; margin-left:auto; margin-right:auto">
					<tr>
						<td>
							<img runat="server" alt="Page" ID="pageImage" style="vertical-align:middle" />
						</td>
					</tr>
				</table>
			</div>
		</dx:PanelContent>
	</panelcollection>
</dx:ASPxCallbackPanel>