<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ForbiddenZones.aspx.cs" Inherits="Docking_ForbiddenZones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
    <link href="../Docking/CSS/ForbiddenZones.css" rel="Stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxDockManager runat="server" ID="ASPxDockManager">
    </dx:ASPxDockManager>
    <dx:ASPxDockPanel runat="server" ID="ASPxDockPanel1" PanelUID="panel1" HeaderText="Panel 1" OwnerZoneUID="zone1">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <dx:ASPxImage runat="server" ID="ForbiddenZone23Img" ImageUrl="~/Docking/Images/ForbiddenZones/ForbiddenZone23.png"> 
                </dx:ASPxImage>
            </dx:PopupControlContentControl>
        </ContentCollection>
        <ForbiddenZones>
            <dx:ForbiddenZoneItem ZoneUID="zone2" />
            <dx:ForbiddenZoneItem ZoneUID="zone3" />
        </ForbiddenZones>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="ASPxDockPanel2" PanelUID="panel2" HeaderText="Panel 2" OwnerZoneUID="zone2">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <dx:ASPxImage runat="server" ID="ForbiddenZone13Img" ImageUrl="~/Docking/Images/ForbiddenZones/ForbiddenZone13.png"> 
                </dx:ASPxImage>
            </dx:PopupControlContentControl>
        </ContentCollection>
        <ForbiddenZones>
            <dx:ForbiddenZoneItem ZoneUID="zone1" />
            <dx:ForbiddenZoneItem ZoneUID="zone3" />
        </ForbiddenZones>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="ASPxDockPanel3" PanelUID="panel3" HeaderText="Panel 3" OwnerZoneUID="zone3">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <dx:ASPxImage runat="server" ID="ForbiddenZone12Img" ImageUrl="~/Docking/Images/ForbiddenZones/ForbiddenZone12.png"> 
                </dx:ASPxImage>
            </dx:PopupControlContentControl>
        </ContentCollection>
        <ForbiddenZones>
            <dx:ForbiddenZoneItem ZoneUID="zone1" />
            <dx:ForbiddenZoneItem ZoneUID="zone2" />
        </ForbiddenZones>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="ASPxDockPanel4" PanelUID="panel4" HeaderText="Panel 4" OwnerZoneUID="zone2">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <dx:ASPxImage runat="server" ID="AllZonesAllowedImg" ImageUrl="~/Docking/Images/ForbiddenZones/AllZonesAllowed.png"> 
                </dx:ASPxImage>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="ASPxDockPanel5" PanelUID="panel5" HeaderText="Panel 5"
        Top="281" Left="735">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <dx:ASPxImage runat="server" ID="AllZonesForbiddenImg" ImageUrl="~/Docking/Images/ForbiddenZones/AllZonesForbidden.png"> 
                </dx:ASPxImage>
            </dx:PopupControlContentControl>
        </ContentCollection>
        <ForbiddenZones>
            <dx:ForbiddenZoneItem ZoneUID="zone1" />
            <dx:ForbiddenZoneItem ZoneUID="zone2" />
            <dx:ForbiddenZoneItem ZoneUID="zone3" />
        </ForbiddenZones>
    </dx:ASPxDockPanel>
    <div id="zoneContainer" class="zoneContainer">
        <dx:ASPxDockZone runat="server" ID="ASPxDockZone1" CssClass="verticalZone first"
            ZoneUID="zone1" PanelSpacing="3px" Width="240px" Height="463px">
            <Styles>
                <DockingAllowedStyle BackColor="#D6F0CE">
                    <Border BorderColor="#AECDA7" BorderStyle="Solid" BorderWidth="1" />
                </DockingAllowedStyle>
                <DockingForbiddenStyle BackColor="#FADADA">
                    <Border BorderColor="#EDBFBF" BorderStyle="Solid" BorderWidth="1" />
                </DockingForbiddenStyle>
            </Styles>
        </dx:ASPxDockZone>
        <dx:ASPxDockZone runat="server" ID="ASPxDockZone2" CssClass="verticalZone"
            ZoneUID="zone2" PanelSpacing="3px" Width="240px" Height="463px">
            <Styles>
                <DockingAllowedStyle BackColor="#D6F0CE">
                    <Border BorderColor="#AECDA7" BorderStyle="Solid" BorderWidth="1" />
                </DockingAllowedStyle>
                <DockingForbiddenStyle BackColor="#FADADA">
                    <Border BorderColor="#EDBFBF" BorderStyle="Solid" BorderWidth="1" />
                </DockingForbiddenStyle>
            </Styles>
        </dx:ASPxDockZone>
        <b class="Clear"></b>
        <dx:ASPxDockZone runat="server" ID="ASPxDockZone3" CssClass="horizontalZone" Orientation="Horizontal"
            ZoneUID="zone3" PanelSpacing="11px" Width="491px" Height="230px">
            <Styles>
                <DockingAllowedStyle BackColor="#D6F0CE">
                    <Border BorderColor="#AECDA7" BorderStyle="Solid" BorderWidth="1" />
                </DockingAllowedStyle>
                <DockingForbiddenStyle BackColor="#FADADA">
                    <Border BorderColor="#EDBFBF" BorderStyle="Solid" BorderWidth="1" />
                </DockingForbiddenStyle>
            </Styles>
        </dx:ASPxDockZone>
    </div>
</asp:Content>
