<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FindAndReplace.aspx.cs"
    Inherits="RichEditDemoFindAndReplace" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRichEdit ID="DemoRichEdit" runat="server" Width="100%" Height="700px" ClientInstanceName="DemoRichEdit"
        ActiveTabIndex="0" ShowConfirmOnLosingChanges="false">
        <ClientSideEvents Init="function(s, e) { DemoRichEdit.commands.openFindPanel.execute(); }" />
    </dx:ASPxRichEdit>
</asp:Content>
