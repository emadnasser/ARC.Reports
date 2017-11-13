<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Tasks.aspx.vb" Inherits="Tasks" %>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <div id="MainContentContainer" runat="server" class="fullHeightContainer"></div>
    <div id="EditFormsContainer">
        <dx:TaskEditForm runat="server" ID="TaskEditForm" />
    </div>
</asp:Content>