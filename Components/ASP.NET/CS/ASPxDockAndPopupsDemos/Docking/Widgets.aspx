<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Widgets.aspx.cs" Inherits="Docking_Widgets" %>
<%@ Register Src="~/Docking/Widgets/DateTimeWidget.ascx" TagName="DateTime" TagPrefix="widget" %>
<%@ Register Src="~/Docking/Widgets/WeatherWidget/WeatherWidget.ascx" TagName="Weather" TagPrefix="widget" %>
<%@ Register Src="~/Docking/Widgets/MailWidget.ascx" TagName="Mail" TagPrefix="widget" %>
<%@ Register Src="~/Docking/Widgets/CalendarWidget.ascx" TagName="Calendar" TagPrefix="widget" %>
<%@ Register Src="~/Docking/Widgets/TradingWidget/TradingWidget.ascx" TagName="Trading" TagPrefix="widget" %>
<%@ Register Src="~/Docking/Widgets/NewsWidget.ascx" TagName="News" TagPrefix="widget" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
    <link href="../Docking/CSS/Widgets.css" rel="Stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function ShowWidgetPanel(widgetPanelUID) {
            var panel = dockManager.GetPanelByUID(widgetPanelUID);
            panel.Show();
        }
        function SetWidgetButtonVisible(widgetName, visible) {
            var button = ASPxClientControl.GetControlCollection().GetByName('widgetButton_' + widgetName);
            var currentClass = button.GetMainElement().className;
            var newClass = ASPxClientUtils.Trim(visible ? currentClass.replace('disabled', '') : currentClass + ' disabled');
            button.GetMainElement().className = newClass;
        }
    </script>
    <%--end highlighted block--%>
    <dx:ASPxDockManager runat="server" ID="ASPxDockManager" ClientInstanceName="dockManager">
        <ClientSideEvents
            PanelShown="function(s, e) { SetWidgetButtonVisible(e.panel.panelUID, false) }"
            PanelCloseUp="function(s, e) { SetWidgetButtonVisible(e.panel.panelUID, true) }"/>
    </dx:ASPxDockManager>
    <dx:ASPxDockPanel runat="server" ID="DateTimePanel" PanelUID="DateTime" HeaderText="Date & Time"
        Left="820" Top="220" ClientInstanceName="dateTimePanel" Width="230px">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <widget:DateTime ID="DateTimeWidget" runat="server" />
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="WeatherPanel" PanelUID="Weather" HeaderText="Weather"
        Width="275px" OwnerZoneUID="RightZone" VisibleIndex="0" ClientInstanceName="weatherPanel"
            ShowOnPageLoad="false">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <widget:Weather runat="server" ID="WeatherWidget" />
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="MailPanel" PanelUID="Mail" HeaderText="Mail"
        OwnerZoneUID="LeftZone" VisibleIndex="0" ClientInstanceName="mailPanel">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <widget:Mail runat="server" ID="MailWidget" />
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="CalendarPanel" PanelUID="Calendar" HeaderText="Calendar"
        Width="280px" OwnerZoneUID="LeftZone" VisibleIndex="1" ClientInstanceName="calendarPanel">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <widget:Calendar runat="server" ID="CalendarWidget" />
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="TradingPanel" PanelUID="Trading" HeaderText="Trading"
        Width="400px" AllowResize="true" OwnerZoneUID="LeftZone" ClientInstanceName="tradingPanel"
            ShowOnPageLoad="false">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <widget:Trading runat="server" ID="TradingWidget" />
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <dx:ASPxDockPanel runat="server" ID="NewsPanel" PanelUID="News" HeaderText="News"
        Width="400px" AllowResize="true" OwnerZoneUID="RightZone" VisibleIndex="1" ClientInstanceName="newsPanel"
            ShowOnPageLoad="false">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <widget:News runat="server" ID="NewsWidget" />
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxDockPanel>
    <div class="widgetPanel">
        <asp:Repeater runat="server" ID="repeater">
            <ItemTemplate>
                <dx:ASPxImage runat="server" ImageUrl='<%# string.Format("~/Docking/Images/Widgets/{0}.png", Container.DataItem) %>' Cursor="pointer"
                    ClientInstanceName='<%# "widgetButton_" + Container.DataItem %>' ToolTip='<%# "Show " + Container.DataItem %>'
                    ClientSideEvents-Click='<%# GetClientButtonClickHandler(Container) %>'>
                </dx:ASPxImage>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <dx:ASPxDockZone runat="server" ID="ASPxDockZone1" ZoneUID="LeftZone" CssClass="leftZone"
        Width="340px" PanelSpacing="3">
    </dx:ASPxDockZone>
    <dx:ASPxDockZone runat="server" ID="ASPxDockZone2" ZoneUID="RightZone" CssClass="rightZone"
        Width="400px" PanelSpacing="3">
    </dx:ASPxDockZone>
</asp:Content>
