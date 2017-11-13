<%@ Control Language="vb" AutoEventWireup="true" CodeFile="TabTemplate.ascx.vb" Inherits="UserControls_TabTemplate" %>
<table class="unselectedTab tabTemplate" >
	<tr>
		<td class="sideTab">
			<asp:Image ID="imgTabLeft" runat="server" ImageUrl="~/Images/tab/left.png" AlternateText="tabLeft" />
		</td>
		<td class="tabCenter">
			<dx:ASPxLabel ID="lblTabText" runat="server" Text="" CssClass="tabText" />
		</td>
		<td class="sideTab">
			<asp:Image ID="imgTabRight" runat="server" ImageUrl="~/Images/tab/right.png" AlternateText="tabRight" />
		</td>
	</tr>
</table>