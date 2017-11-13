<%@ Control Language="vb" AutoEventWireup="true" CodeFile="ContentTemplate.ascx.vb"
	Inherits="NavBar_HeaderTemplate" %>
<table style="width: 100%; height: 110px;">
	<tr>
		<td style="vertical-align: top; padding-right: 10px;">
			<dx:ASPxHyperLink runat="server" ID="htImage" />
		</td>
		<td style="width: 100%; vertical-align: top">
			<dx:ASPxLabel ForeColor="#303030" ID="htText" runat="server" EncodeHtml="False" />
		</td>
	</tr>
</table>