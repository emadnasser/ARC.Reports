<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Dashboard.aspx.vb" Inherits="Dashboard" %>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <dx:ASPxDockManager ID="DockManager" runat="server" ClientInstanceName="dockManager">
        <ClientSideEvents 
            Init="DevAV.Page.DockManager_Init" 
            StartPanelDragging="DevAV.Page.DockManager_StartPanelDragging" 
            EndPanelDragging="DevAV.Page.DockManager_EndPanelDragging" 
            AfterDock="DevAV.Page.DockManager_AfterDock" 
            PanelCloseUp="DevAV.Page.DockManager_PanelCloseUp"  />
    </dx:ASPxDockManager>
    <div>
        <div class="dashboardTopZoneContainer">
            <dx:ASPxDockZone ID="TopDockZone" runat="server" ZoneUID="TopDockZone" Height="380px" Width="100%" />
        </div>
        <div class="dashboardLeftZoneContainer">
            <dx:ASPxDockZone ID="LeftDockZone" runat="server" ZoneUID="LeftDockZone" Height="380px" Width="100%" />
        </div>
        <div class="dashboardRightZoneContainer">
            <dx:ASPxDockZone ID="RightDockZone" runat="server" ZoneUID="RightDockZone" Height="380px" Width="100%" />
        </div>
    </div>
    <dx:ASPxDockPanel ID="PivotGridPanel" runat="server" PanelUID="PivotGrid" OwnerZoneUID="TopDockZone" Height="380" CssClass="dashboardPivotDockPanel" 
        AllowedDockState="DockedOnly" DragElement="Header" HeaderText="Revenue Analysis">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <dx:ProductsPivotGrid ID="ProductsPivotGrid" runat="server" />
            </dx:PopupControlContentControl>
        </ContentCollection>
        <ClientSideEvents CloseUp="DevAV.Page.PivotGridPanel_CloseUp" />
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel ID="RevenueChartPanel" runat="server" PanelUID="RevenueChart" OwnerZoneUID="LeftDockZone" Height="380" CssClass="chartDockPanel" 
        AllowedDockState="DockedOnly" DragElement="Window" HeaderText="Revenue Snapshot(All Products)">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <dx:ProductsRevenueChart ID="RevenueChart" runat="server" />
            </dx:PopupControlContentControl>
        </ContentCollection>
        <ClientSideEvents CloseUp="DevAV.Page.RevenueChartPanel_CloseUp" />
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel ID="OpportunitiesChartPanel" runat="server" PanelUID="OpportunitiesChart" OwnerZoneUID="RightDockZone" Height="380" CssClass="chartDockPanel"
        AllowedDockState="DockedOnly" DragElement="Window" HeaderText="Opportunities Snapshot(All Products)">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <dx:ProductsOpportunitiesChart ID="OpportunitiesChart" runat="server" />
            </dx:PopupControlContentControl>
        </ContentCollection>
        <ClientSideEvents CloseUp="DevAV.Page.OpportunitiesChartPanel_CloseUp" />
    </dx:ASPxDockPanel>
</asp:Content>