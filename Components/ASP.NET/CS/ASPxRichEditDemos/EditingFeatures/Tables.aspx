<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Tables.aspx.cs"
    Inherits="RichEditDemoTables" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRichEdit ID="DemoRichEdit" runat="server" Width="100%" Height="700px"
        ActiveTabIndex="1" ShowConfirmOnLosingChanges="false" OnPreRender="DemoRichEdit_PreRender">
    </dx:ASPxRichEdit>
</asp:Content>
