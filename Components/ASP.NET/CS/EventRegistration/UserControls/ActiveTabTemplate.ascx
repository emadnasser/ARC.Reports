<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ActiveTabTemplate.ascx.cs" Inherits="UserControls_ActiveTabTemplate" %>
<table class="selectedTab tabTemplate">
    <tr>
        <td class="sideTab">
            <asp:Image ID="imgTabLeft" runat="server" ImageUrl="~/Images/tab/active_left.png" AlternateText="seletedTabLeft" />
        </td>
        <td class="tabCenter">
            <dx:ASPxLabel ID="lblTabText" runat="server" Text="" CssClass="tabText" />
        </td>
        <td class="sideTab">
            <asp:Image ID="imgTabRight" runat="server" ImageUrl="~/Images/tab/active_right.png" AlternateText="seletedTabRight" />
        </td>
    </tr>
</table>
