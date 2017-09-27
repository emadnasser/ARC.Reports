<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ARC.Reports.Pages.WebForm1" %>

<%@ Register Src="~/Controls/MarketChannelsGraphs_Y.ascx" TagPrefix="uc1" TagName="MarketChannelsGraphs_Y" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <uc1:MarketChannelsGraphs_Y runat="server" ID="MarketChannelsGraphs_Y" />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
