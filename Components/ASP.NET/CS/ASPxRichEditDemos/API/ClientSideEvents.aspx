<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="ClientSideEvents.aspx.cs" Inherits="API_ClientSideEvents" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxRichEdit ID="DemoRichEdit" runat="server" ClientInstanceName="DemoRichEdit" Width="100%" ShowConfirmOnLosingChanges="false">
        <ClientSideEvents BeginSynchronization="function(s, e) { DXEventMonitor.Trace(s, e, 'BeginSynchronization') }"
            DocumentChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'DocumentChanged') }"
            EndSynchronization="function(s, e) { DXEventMonitor.Trace(s, e, 'EndSynchronization') }"
            HyperlinkClick="function(s, e) { DXEventMonitor.Trace(s, e, 'HyperlinkClick') }"
            SelectionChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'SelectionChanged') }"
            Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init') }" />
    </dx:ASPxRichEdit>
    <div class="Clear"></div>
    <dx:EventMonitor runat="server" ID="EventMonitor" EventNames="Init, SelectionChanged, DocumentChanged, BeginSynchronization, EndSynchronization, HyperlinkClick" EventLogWidth="540" />
</asp:Content>
