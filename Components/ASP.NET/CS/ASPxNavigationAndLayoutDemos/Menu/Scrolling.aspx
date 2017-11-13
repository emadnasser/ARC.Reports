<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Scrolling.aspx.cs" Inherits="Menu_Scrolling" Title="Scrolling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
<style type="text/css">
    .MenuFrame {
        border: solid 1px #d5d7dc;
        width: 100%;
        height: 300px;
        overflow: hidden;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCheckBox ID="enableScrolling" runat="server" AutoPostBack="true" Checked="true" Text="EnableSubMenuScrolling" />
    <br />
    <%--start highlighted block--%>
    <iframe class="MenuFrame" src="ScrollingPage.aspx"></iframe>
    <%--end highlighted block--%>
</asp:Content>
