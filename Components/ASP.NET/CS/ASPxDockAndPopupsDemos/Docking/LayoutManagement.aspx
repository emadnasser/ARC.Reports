<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="LayoutManagement.aspx.cs" Inherits="Docking_LayoutManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
    <style type="text/css">
        .panelNum
        {
            width: 100%;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div class="OptionsBottomMargin">
        <dx:ASPxButton ID="btnEditLayout" runat="server" Text="Edit layout" OnClick="btnEditLayout_Click">
        </dx:ASPxButton>
    </div>
    <dx:ASPxDockPanel runat="server" ID="panel1" PanelUID="panel1" VisibleIndex="0" Width="400px"
        Height="560px" ShowHeader="false" AllowResize="true" OwnerZoneUID="leftZone">
        <Styles>
            <Content Border-BorderStyle="Solid" Border-BorderWidth="1px" Border-BorderColor="#BBD7E7"
                BackColor="#DBEBF4" Paddings-Padding="0">
            </Content>
        </Styles>
        <ContentCollection>
            <dx:PopupControlContentControl>
                <div class="panelNum" style="margin-top: 205px;">
                    <dx:ASPxImage ID="imgNum1" runat="server" ImageUrl="~/Docking/Images/LayoutManagement/n1.png">
                    </dx:ASPxImage>
                </div>
            </dx:PopupControlContentControl>
        </ContentCollection>
        <Border BorderStyle="None"></Border>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="panel2" PanelUID="panel2" Width="350px" Height="300px"
        AllowResize="true" OwnerZoneUID="rightZone" ShowHeader="false" VisibleIndex="0">
        <Styles>
            <Content Border-BorderStyle="Solid" Border-BorderWidth="1px" Border-BorderColor="#BBE7BF"
                BackColor="#DBF4DE" Paddings-Padding="0">
            </Content>
        </Styles>
        <ContentCollection>
            <dx:PopupControlContentControl>
                <div class="panelNum" style="margin-top: 85px;">
                    <dx:ASPxImage ID="imgNum2" runat="server" ImageUrl="~/Docking/Images/LayoutManagement/n2.png">
                    </dx:ASPxImage>
                </div>
            </dx:PopupControlContentControl>
        </ContentCollection>
        <Border BorderStyle="None"></Border>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="panel3" PanelUID="panel3" Width="300px" Height="250px"
        AllowResize="true" OwnerZoneUID="rightZone" ShowHeader="false" VisibleIndex="1">
        <Styles>
            <Content Border-BorderStyle="Solid" Border-BorderWidth="1px" Border-BorderColor="#DBCBE9"
                BackColor="#F3EAFB" Paddings-Padding="0">
            </Content>
        </Styles>
        <ContentCollection>
            <dx:PopupControlContentControl>
                <div class="panelNum" style="margin-top: 57px;">
                    <dx:ASPxImage ID="imgNum3" runat="server" ImageUrl="~/Docking/Images/LayoutManagement/n3.png">
                    </dx:ASPxImage>
                </div>
            </dx:PopupControlContentControl>
        </ContentCollection>
        <Border BorderStyle="None"></Border>
    </dx:ASPxDockPanel>
    <div style="float: left;">
        <dx:ASPxDockZone runat="server" ID="LeftZone" ZoneUID="leftZone" Width="288px" PanelSpacing="10">
        </dx:ASPxDockZone>
    </div>
    <div style="float: left; margin-left: 10px;">
        <dx:ASPxDockZone runat="server" ID="RightZone" ZoneUID="rightZone" Width="400px"
            PanelSpacing="10">
        </dx:ASPxDockZone>
    </div>
    <dx:ASPxDockManager ID="dockManager" runat="server" FreezeLayout="true" OnClientLayout="dockManager_ClientLayout">
    </dx:ASPxDockManager>
</asp:Content>
