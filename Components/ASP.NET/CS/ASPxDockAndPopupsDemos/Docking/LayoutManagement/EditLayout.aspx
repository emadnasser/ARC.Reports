<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditLayout.aspx.cs" Inherits="Docking_LayoutManagement_EditLayout" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/Content/Site.css" rel="Stylesheet" />
    <title></title>
    <style type="text/css">
        .panelNum
        {
            width: 100%;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-top: 15px; margin-bottom: 10px;">
        <div style="float: left; padding-left: 15px;">
            <dx:ASPxButton ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click">
            </dx:ASPxButton>
        </div>
        <div style="float: left; padding-left: 15px;">
            <dx:ASPxButton ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click">
            </dx:ASPxButton>
        </div>
        <div style="float: left; padding-left: 15px;">
            <dx:ASPxButton ID="btnRestore" runat="server" Text="Restore layout to initial" OnClick="btnRestore_Click">
            </dx:ASPxButton>
        </div>
        <b class="Clear"></b>
    </div>
    <dx:ASPxDockPanel runat="server" ID="panel1" PanelUID="panel1" VisibleIndex="0" HeaderText="Panel1"
        Width="400px" Height="560px" OwnerZoneUID="leftZone" AllowedDockState="DockedOnly">
        <Styles>
            <Content BackColor="#DBEBF4" Paddings-Padding="0">
            </Content>
        </Styles>
        <ContentCollection>
            <dx:PopupControlContentControl>
                <div class="panelNum" style="margin-top: 185px;">
                    <dx:ASPxImage ID="imgNum1" runat="server" ImageUrl="~/Docking/Images/LayoutManagement/n1.png">
                    </dx:ASPxImage>
                </div>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="panel2" PanelUID="panel2" HeaderText="Panel2"
        Width="350px" Height="300px" OwnerZoneUID="rightZone" VisibleIndex="0"
        AllowedDockState="DockedOnly">
        <Styles>
            <Content BackColor="#DBF4DE" Paddings-Padding="0">
            </Content>
        </Styles>
        <ContentCollection>
            <dx:PopupControlContentControl>
                <div class="panelNum" style="margin-top: 65px;">
                    <dx:ASPxImage ID="imgNum2" runat="server" ImageUrl="~/Docking/Images/LayoutManagement/n2.png">
                    </dx:ASPxImage>
                </div>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="panel3" PanelUID="panel3" HeaderText="Panel3"
        Width="300px" Height="250px" Left="700" Top="190" OwnerZoneUID="rightZone"
        VisibleIndex="1" AllowedDockState="DockedOnly">
        <Styles>
            <Content BackColor="#F3EAFB" Paddings-Padding="0">
            </Content>
        </Styles>
        <ContentCollection>
            <dx:PopupControlContentControl>
                <div class="panelNum" style="margin-top: 37px;">
                    <dx:ASPxImage ID="imgNum3" runat="server" ImageUrl="~/Docking/Images/LayoutManagement/n3.png">
                    </dx:ASPxImage>
                </div>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <div style="float: left; margin-left: 15px;">
        <dx:ASPxDockZone runat="server" ID="LeftZone" ZoneUID="leftZone" Width="288px" PanelSpacing="12">
        </dx:ASPxDockZone>
    </div>
    <div style="float: left; margin-left: 10px;">
        <dx:ASPxDockZone runat="server" ID="RightZone" ZoneUID="rightZone" Width="400px"
            PanelSpacing="12">
        </dx:ASPxDockZone>
    </div>
    <dx:ASPxDockManager ID="dockManager" runat="server" FreezeLayout="false" OnClientLayout="dockManager_ClientLayout">
    </dx:ASPxDockManager>
    </form>
</body>
</html>
