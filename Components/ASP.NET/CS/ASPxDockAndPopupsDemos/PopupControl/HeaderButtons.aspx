<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HeaderButtons.aspx.cs"
    Inherits="PopupControl_HeaderButtons" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <script type="text/javascript" src="https://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=7.0&amp;s=1"></script>
    <%--start highlighted block--%>
    <script type="text/javascript">
        var map = (function () {
            var bingMap = null;
            var mapElementID = "myMap";
            function getMapElement() { return document.getElementById(mapElementID); }
            function showMap() {
                if(!bingMap) {
                    createMap();
                }
            }
            function createMap() {
                if(typeof Microsoft.Maps.Map === "undefined") return;
                var mapOptions = {
                    credentials: "As0ozajCG_1t1JtHFrJC3zbv76ESjZypBRHHuaSqM1k2sbFOMij2W4tDrPaInwjB",
                    mapTypeId: Microsoft.Maps.MapTypeId.road,
                    zoom: 4,
                    center: new Microsoft.Maps.Location(40, -100),
                    enableSearchLogo: false,
                    showScalebar: false,
                    useInertia: false,
                    disableKeyboardInput: true
                };
                bingMap = new Microsoft.Maps.Map(getMapElement(), mapOptions);
            }
            return {
                showMap: showMap,
                createMap: createMap
            };
        })();
    </script>
    <%--end highlighted block--%>
    <dx:ASPxPopupControl ID="Popup" runat="server" Width="400px" Height="400px"
        ShowPinButton="True" ShowRefreshButton="True" ShowCollapseButton="True" ShowMaximizeButton="True" 
        ClientInstanceName="popup" PopupElementID="popupArea" ShowOnPageLoad="True" 
        PopupVerticalAlign="TopSides" PopupHorizontalAlign="LeftSides"
        AllowDragging="True" AllowResize="false" CloseAction="CloseButton"  
        ScrollBars="None" HeaderText="Map" ShowFooter="true" FooterText="" PopupAnimationType="Fade">
        <ContentStyle Paddings-Padding="0">
        </ContentStyle>
        <ClientSideEvents Shown="map.showMap" EndCallback="map.createMap"></ClientSideEvents>
        <ContentCollection>
            <dx:PopupControlContentControl>
                <div id='myMap' style="position: relative; width:100%; height:100%">
                </div>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>    
    <table style="float: left; width: 400px; height:400px; margin-right: 50px; margin-bottom: 50px;" id="popupArea">
        <tr>
            <td style="cursor: pointer; text-align: center; white-space:nowrap;">
                Click here to invoke a popup window
            </td>
        </tr>
    </table>
    <div style="float: left;">
        <table class="OptionsTable" style="white-space: nowrap;">
            <tr>
                <td style="padding: 0 0 8px">
                    <b>Header buttons visibility</b>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbShowPinButton" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="Show PinButton" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbShowRefreshButton" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="Show RefreshButton" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbShowCollapseButton" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="Show CollapseButton" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbShowMaximizeButton" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="Show MaximizeButton" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbShowCloseButton" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="Show CloseButton" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
