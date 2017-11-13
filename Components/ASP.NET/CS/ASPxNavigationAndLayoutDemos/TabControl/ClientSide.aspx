<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSide.aspx.cs"
    Inherits="TabControl_ClientSide" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="height: 140px;">
        <dx:ASPxPageControl Width="100%" ID="ASPxPageControl1" runat="server" ActiveTabIndex="0"
            EnableViewState="False" EnableHierarchyRecreation="True">
            <ClientSideEvents ActiveTabChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'ActiveTabChanged') }"
                ActiveTabChanging="function(s, e) { DXEventMonitor.Trace(s, e, 'ActiveTabChanging') }"
                Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init') }" TabClick="function(s, e) { DXEventMonitor.Trace(s, e, 'TabClick') }" />
            <TabPages>
                <dx:TabPage Name="C#" Text="C#">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <code runat="server" id="CSharpCodeHolder"></code>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Name="VB" Text="VB">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <code runat="server" id="VBCodeHolder"></code>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
            </TabPages>
        </dx:ASPxPageControl>
    </div>
    <dx:EventMonitor runat="server" ID="EventMonitor" EventNames="Init ActiveTabChanging ActiveTabChanged TabClick" EventLogWidth="540" />
</asp:Content>
