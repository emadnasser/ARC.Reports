<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master"  AutoEventWireup="true"
    CodeFile="ClientSideEvents.aspx.cs" Inherits="Docking_ClientSideEvents"%>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function ShowHiddenDockPanels() {
            var panels = manager.GetPanels();
            for(var i = 0; i < panels.length; i++)
                panels[i].Show();
            SetShowHiddenPanelsButtonEnable(false);
        }
        function SetShowHiddenPanelsButtonEnable(enable) {
            btnShowHiddenPanels.SetEnabled(enable);
        }
        function OnAfterDock(panel) {
            var img = GetPanelImage(panel);
            img.SetImageUrl('Images/ClientSideEvents/Docked.png');
        }
        function OnAfterFloat(panel) {
            var img = GetPanelImage(panel);
            img.SetImageUrl('Images/ClientSideEvents/Float.png');
        }
        function OnStartPanelDraging(panel) {
            var img = GetPanelImage(panel);
            img.SetImageUrl('Images/ClientSideEvents/Undocked.png');
        }
        function OnEndPanelDraging(panel) {
            var img = GetPanelImage(panel);
            if(panel.IsDocked())
                img.SetImageUrl('Images/ClientSideEvents/Docked.png');
            else
                img.SetImageUrl('Images/ClientSideEvents/Float.png');
        }
        function GetPanelImage(panel) {
            return ASPxClientControl.GetControlCollection().GetByName(panel.panelUID + 'Image');
        }
    </script>
    <%--end highlighted block--%>
    <dx:ASPxButton runat="server" ID="btnShowHiddenPanels" ClientInstanceName="btnShowHiddenPanels"
        AutoPostBack="false" Text="Show hidden dock panels" ClientEnabled="false" CssClass="OptionsBottomMargin">
        <ClientSideEvents Click="function(s, e) { ShowHiddenDockPanels(); }" />
    </dx:ASPxButton>
    <div style="padding-bottom: 20px;">
        <dx:ASPxDockManager runat="server" ID="DockManager" ClientInstanceName="manager" ClientSideEvents-AfterDock="true">
            <ClientSideEvents
                Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init'); }"
                BeforeDock="function(s, e) { DXEventMonitor.Trace(s, e, 'BeforeDock_for_Manager'); }"
                AfterDock="function(s, e) { OnAfterDock(e.panel); DXEventMonitor.Trace(s, e, 'AfterDock_for_Manager'); }"
                BeforeFloat="function(s, e) { DXEventMonitor.Trace(s, e, 'BeforeFloat_for_Manager'); }"
                AfterFloat="function(s, e) { OnAfterFloat(e.panel); DXEventMonitor.Trace(s, e, 'AfterFloat_for_Manager'); }"                
                StartPanelDragging="function(s, e) { OnStartPanelDraging(e.panel); DXEventMonitor.Trace(s, e, 'StartPanelDragging_for_Manager'); }"
                EndPanelDragging="function(s, e) { OnEndPanelDraging(e.panel); DXEventMonitor.Trace(s, e, 'EndPanelDragging_for_Manager'); }"
                PanelCloseUp="function(s, e) { SetShowHiddenPanelsButtonEnable(true); DXEventMonitor.Trace(s, e, 'PanelCloseUp_for_Manager'); }"
                PanelPopUp="function(s, e) { DXEventMonitor.Trace(s, e, 'PanelPopUp_for_Manager'); }"
             />
        </dx:ASPxDockManager>
        <dx:ASPxDockPanel runat="server" ID="Panel1" ClientInstanceName="panel1" PanelUID="panel1"
            OwnerZoneUID="zone" HeaderText="Panel 1" VisibleIndex="0">
            <ClientSideEvents
                Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init'); }"
                BeforeDock="function(s, e) { DXEventMonitor.Trace(s, e, 'BeforeDock_for_Panel'); }"
                AfterDock="function(s, e) { DXEventMonitor.Trace(s, e, 'AfterDock_for_Panel'); }"
                BeforeFloat="function(s, e) { DXEventMonitor.Trace(s, e, 'BeforeFloat_for_Panel'); }"
                AfterFloat="function(s, e) { DXEventMonitor.Trace(s, e, 'AfterFloat_for_Panel'); }"
                StartDragging="function(s, e) { DXEventMonitor.Trace(s, e, 'StartDragging_for_Panel'); }"
                EndDragging="function(s, e) { DXEventMonitor.Trace(s, e, 'EndDragging_for_Panel'); }"
                CloseUp="function(s, e) { DXEventMonitor.Trace(s, e, 'CloseUp_for_Panel'); }"
                PopUp="function(s, e) { DXEventMonitor.Trace(s, e, 'PopUp_for_Panel'); }" />
                <ContentCollection>
                    <dx:PopupControlContentControl>
                        <dx:ASPxImage runat="server" ID="panel1Image" ClientInstanceName="panel1Image"
                            ImageUrl="~/Docking/Images/ClientSideEvents/Docked.png">
                        </dx:ASPxImage>
                    </dx:PopupControlContentControl>
                </ContentCollection>
        </dx:ASPxDockPanel>
        <dx:ASPxDockPanel runat="server" ID="panel2" ClientInstanceName="panel2" PanelUID="panel2"
            OwnerZoneUID="zone" HeaderText="Panel 2" VisibleIndex="1">
            <ClientSideEvents
                Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init'); }"
                BeforeDock="function(s, e) { DXEventMonitor.Trace(s, e, 'BeforeDock_for_Panel'); }"
                AfterDock="function(s, e) { DXEventMonitor.Trace(s, e, 'AfterDock_for_Panel'); }"
                BeforeFloat="function(s, e) { DXEventMonitor.Trace(s, e, 'BeforeFloat_for_Panel'); }"
                AfterFloat="function(s, e) { DXEventMonitor.Trace(s, e, 'AfterFloat_for_Panel'); }"
                StartDragging="function(s, e) { DXEventMonitor.Trace(s, e, 'StartDragging_for_Panel'); }"
                EndDragging="function(s, e) { DXEventMonitor.Trace(s, e, 'EndDragging_for_Panel'); }"
                CloseUp="function(s, e) { DXEventMonitor.Trace(s, e, 'CloseUp_for_Panel'); }"
                PopUp="function(s, e) { DXEventMonitor.Trace(s, e, 'PopUp_for_Panel'); }" />
                <ContentCollection>
                    <dx:PopupControlContentControl>
                        <dx:ASPxImage runat="server" ID="ASPxImage1"  ClientInstanceName="panel2Image"
                            ImageUrl="~/Docking/Images/ClientSideEvents/Docked.png" >
                        </dx:ASPxImage>
                    </dx:PopupControlContentControl>
                </ContentCollection>
        </dx:ASPxDockPanel>
        <dx:ASPxDockPanel runat="server" ID="panel3" ClientInstanceName="panel3" PanelUID="panel3"
            OwnerZoneUID="zone" HeaderText="Panel 3" VisibleIndex="2">
            <ClientSideEvents
                Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init'); }"
                BeforeDock="function(s, e) { DXEventMonitor.Trace(s, e, 'BeforeDock_for_Panel'); }"
                AfterDock="function(s, e) { DXEventMonitor.Trace(s, e, 'AfterDock_for_Panel'); }"
                BeforeFloat="function(s, e) { DXEventMonitor.Trace(s, e, 'BeforeFloat_for_Panel'); }"
                AfterFloat="function(s, e) { DXEventMonitor.Trace(s, e, 'AfterFloat_for_Panel'); }"
                StartDragging="function(s, e) { DXEventMonitor.Trace(s, e, 'StartDragging_for_Panel'); }"
                EndDragging="function(s, e) { DXEventMonitor.Trace(s, e, 'EndDragging_for_Panel'); }"
                CloseUp="function(s, e) { DXEventMonitor.Trace(s, e, 'CloseUp_for_Panel'); }"
                PopUp="function(s, e) { DXEventMonitor.Trace(s, e, 'PopUp_for_Panel'); }" />
                <ContentCollection>
                    <dx:PopupControlContentControl>
                        <dx:ASPxImage runat="server" ID="ASPxImage2"  ClientInstanceName="panel3Image"
                            ImageUrl="~/Docking/Images/ClientSideEvents/Docked.png" >
                        </dx:ASPxImage>
                    </dx:PopupControlContentControl>
                </ContentCollection>
        </dx:ASPxDockPanel>
        <dx:ASPxDockZone runat="server" ID="ASPxDockZone" CssClass="zone" Orientation="Horizontal"
            ZoneUID="zone" PanelSpacing="3px" Width="606px" Height="200px">
            <ClientSideEvents
                Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init'); }"
                AfterDock="function(s, e) { DXEventMonitor.Trace(s, e, 'AfterDock_for_Zone'); }"
                BeforeDock="function(s, e) { DXEventMonitor.Trace(s, e, 'BeforeDock_for_Zone'); }" />
        </dx:ASPxDockZone>
    </div>
    <dx:EventMonitor ID="EventMonitor" runat="server" EventLogWidth="460" EventLogHeight="270"
        EventNames="Init AfterFloat_for_Panel AfterFloat_for_Manager AfterDock_for_Panel AfterDock_for_Zone AfterDock_for_Manager BeforeFloat_for_Panel BeforeFloat_for_Manager BeforeDock_for_Panel BeforeDock_for_Zone BeforeDock_for_Manager CloseUp_for_Panel PanelCloseUp_for_Manager EndDragging_for_Panel EndPanelDragging_for_Manager PopUp_for_Panel PanelPopUp_for_Manager StartDragging_for_Panel StartPanelDragging_for_Manager"/>
</asp:Content>
