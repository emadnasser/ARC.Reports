<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ServerSide.aspx.cs" Inherits="Docking_ServerSide" Debug="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
    <link href="../Docking/CSS/ServerSide.css" rel="Stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxDockManager runat="server" ID="dockManager" ClientSideEvents-AfterDock="true"
        OnAfterDock="dockManager_AfterDock" OnBeforeDock="dockManager_BeforeDock"
        OnAfterFloat="dockManager_AfterFloat" OnBeforeFloat="dockManager_BeforeFloat">
    </dx:ASPxDockManager>
    <dx:ASPxDockPanel runat="server" ID="panel1" PanelUID="panel1"
        OwnerZoneUID="zone1" VisibleIndex="0"
        OnAfterDock="panel1_AfterDock" OnBeforeDock="panel1_BeforeDock"
        OnAfterFloat="panel1_AfterFloat" OnBeforeFloat="panel1_BeforeFloat"
        HeaderText="2D Bubble" FooterText="Model: Ring">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <dx:ASPxImage runat="server" ID="Bubble2DImage" ImageUrl="~/Docking/Images/Charts/2DBubble.png" ShowLoadingImage="true" Height="125px">
                </dx:ASPxImage>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="panel2" OwnerZoneUID="zone1"
        PanelUID="panel2" VisibleIndex="1"
        OnAfterDock="panel2_AfterDock" OnBeforeDock="panel2_BeforeDock"
        OnAfterFloat="panel2_AfterFloat" OnBeforeFloat="panel2_BeforeFloat"
        HeaderText="3D Bubble" FooterText="Model: Sphere">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <dx:ASPxImage runat="server" ID="Bubble3DImage" ImageUrl="~/Docking/Images/Charts/3DBubble.png" ShowLoadingImage="true" Height="125px">
                </dx:ASPxImage>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="panel3" OwnerZoneUID="zone2"
        PanelUID="panel3" VisibleIndex="2"
        OnAfterDock="panel3_AfterDock" OnBeforeDock="panel3_BeforeDock"
        OnAfterFloat="panel3_AfterFloat" OnBeforeFloat="panel3_BeforeFloat"
        HeaderText="2D Pie" FooterText="Model: Simple">
        <ContentCollection>
            <dx:PopupControlContentControl>
               <dx:ASPxImage runat="server" ID="Pie" ImageUrl="~/Docking/Images/Charts/2DPie.png" ShowLoadingImage="true" Height="125px">
               </dx:ASPxImage>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="ASPxDockPanel1"
        OwnerZoneUID="zone2" PanelUID="panel4" VisibleIndex="4"
        OnAfterDock="panel4_AfterDock" OnBeforeDock="panel4_BeforeDock"
        OnAfterFloat="panel4_AfterFloat" OnBeforeFloat="panel4_BeforeFloat"
        HeaderText="3D Bar" FooterText="Model: Box">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <dx:ASPxImage runat="server" ID="Bar" ImageUrl="~/Docking/Images/Charts/3DManhattanBar.png" ShowLoadingImage="true" Height="125px">
               </dx:ASPxImage>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <div style="float: left; margin-bottom: 50px;">
        <div style="width: 511px; float: left;">
            <dx:ASPxDockZone runat="server" ID="dockZone1" CssClass="zone left"
                ZoneUID="zone1" OnAfterDock="dockZone1_AfterDock" OnBeforeDock="dockZone1_BeforeDock">
            </dx:ASPxDockZone>
            <dx:ASPxDockZone runat="server" ID="ASPxDockZone1" CssClass="zone"
                ZoneUID="zone2" OnAfterDock="dockZone2_AfterDock" OnBeforeDock="dockZone2_BeforeDock">
            </dx:ASPxDockZone>
        </div>
        <div style="padding-left: 11px; float: right;">
            <table class="OptionsTable">
                <tr>
                    <td>
                        <dx:ASPxLabel runat="server" Text="Choose panel:" ID="lblDockPanels" AssociatedControlID="cbDockPanels">
                        </dx:ASPxLabel>
                    </td>
                    <td>
                        <dx:ASPxComboBox runat="server" AutoPostBack="true" ID="cbDockPanels" SelectedIndex="0"
                            Width="100px" OnValueChanged="cbDockPanels_SelectedIndexChanged">
                            <Items>
                                <dx:ListEditItem Text="2D Bubble" Value="panel1" />
                                <dx:ListEditItem Text="3D Bubble" Value="panel2" />
                                <dx:ListEditItem Text="2D Pie" Value="panel3" />
                                <dx:ListEditItem Text="3D Bar" Value="panel4" />
                            </Items>
                        </dx:ASPxComboBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <dx:ASPxCheckBox runat="server" AutoPostBack="true" Text="Visible" ID="cbPanelVisibility">
                        </dx:ASPxCheckBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <dx:ASPxLabel runat="server" Text="Dock to:" ID="lblDockZone" AssociatedControlID="cbZones">
                        </dx:ASPxLabel>
                    </td>
                    <td>
                        <dx:ASPxComboBox runat="server" ID="cbZones" Width="100px" AutoPostBack="true"
                            SelectedIndex="0" OnValueChanged="cbZones_ValueChanged" ClientInstanceName="cbZones">
                            <Items>
                                <dx:ListEditItem Text="None" Value="none"/>
                                <dx:ListEditItem Text="Left zone" Value="zone1"/>
                                <dx:ListEditItem Text="Right zone" Value="zone2"/>
                            </Items>
                        </dx:ASPxComboBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Visible index:">
                        </dx:ASPxLabel>
                    </td>
                    <td>
                        <dx:ASPxSpinEdit runat="server" AutoPostBack="true" ID="seVisibleIndex"
                            MinValue="0" MaxValue="3" Width="100px" 
                            onvaluechanged="seVisibleIndex_ValueChanged">
                        </dx:ASPxSpinEdit>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <b>Layout</b>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <dx:ASPxCheckBox ID="cbShowCloseButton" runat="server" AutoPostBack="True" Checked="True"
                            Text="ShowCloseButton" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <dx:ASPxCheckBox ID="cbShowShadow" runat="server" AutoPostBack="True" Checked="True"
                            Text="ShowShadow" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <dx:ASPxCheckBox ID="cbShowHeader" runat="server" AutoPostBack="True" Checked="True"
                            Text="ShowHeader" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <dx:ASPxCheckBox ID="cbShowFooter" runat="server" AutoPostBack="True" Checked="True"
                            Text="ShowFooter" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <b>Behaviour</b>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <dx:ASPxCheckBox ID="cbAllowResize" runat="server" AutoPostBack="True" Text="AllowResize" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <dx:ASPxLabel ID="Label4" runat="server" EnableViewState="False" Text="ShowSizeGrip:" />
                    </td>
                    <td>
                        <dx:ASPxComboBox SelectedIndex="0" Width="100px" ID="ddlShowSizeGrip" runat="server"
                            AutoPostBack="True">
                            <Items>
                                <dx:ListEditItem Value="Auto" Text="Auto" />
                                <dx:ListEditItem Value="True" Text="True" />
                                <dx:ListEditItem Value="False" Text="False" />
                            </Items>
                        </dx:ASPxComboBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <dx:ASPxLabel ID="ASPxLabel2" runat="server" EnableViewState="False" Text="AllowedDockState:" />
                    </td>
                    <td>
                        <dx:ASPxComboBox SelectedIndex="0" Width="100px" ID="ddlAllowedDockState" runat="server"
                            AutoPostBack="True">
                            <Items>
                                <dx:ListEditItem Value="All" Text="All" />
                                <dx:ListEditItem Value="DockedOnly" Text="DockedOnly" />
                                <dx:ListEditItem Value="FloatOnly" Text="FloatOnly" />
                            </Items>
                        </dx:ASPxComboBox>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <b class="Clear"></b>
    <dx:ServerEventMonitor ID="EventMonitor" runat="server" EventNames="AfterDock_for_Panels BeforeDock_for_Panels AfterFloat_for_Panels BeforeFloat_for_Panels AfterDock_for_Zones BeforeDock_for_Zones AfterDock_for_Manager BeforeDock_for_Manager AfterFloat_for_Manager BeforeFloat_for_Manager"
        EventLogWidth="500" />
</asp:Content>
