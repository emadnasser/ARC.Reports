<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ResponsiveLayoutPage.aspx.cs" Inherits="Panel_ResponsiveLayoutPage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, user-scalable=no, maximum-scale=1.0, minimum-scale=1.0" />
    <title>Responsive Layout - ASP.NET Panel Control</title>
    <style>
        body, form
        {
            padding: 0;
            margin: 0;
        }
        .topPanel
        {
            padding-left: 0!important;
            padding-right: 0!important;
        }
        .topPanel .btn
        {
            margin-right: 12px;
        }
        .title
        {
            float: left;
            padding: 1px 4px 2px 38px;
            font-size: 2.2em;
        }
        .titleContainer,
        .dataView
        {
            margin: 0 auto;
            width: 100%;
            max-width: 960px;
        }
        .titleContainer
        {
            padding: 0 16px;
            box-sizing: border-box;
        }
        .dateViewContent
        {
            border: 0!important;
            padding: 16px!important;
        }
        .dateViewContent > table
        {
            margin: 0!important;
        }
        .dateViewItem
        {
            margin: 0!important;
            padding: 12px!important;
            width: 200px!important;
            height: 260px!important;
        }
        .dateViewItem > table
        {
            border-collapse: separate;
            border-spacing: 2px;
            width: 100%;
            white-space: nowrap;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxPanel ID="TopPanel" runat="server" FixedPosition="WindowTop" ClientInstanceName="topPanel" CssClass="topPanel">
            <PanelCollection>
                <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                    <div class="titleContainer">
                        <dx:ASPxMenu ID="mMain" runat="server" EnableAdaptivity="true" Width="100%" HorizontalAlign="Center">
                            <Items>
                                <dx:MenuItem Text="Home" NavigateUrl="javascript:void(0)" AdaptivePriority="1"></dx:MenuItem>
                                <dx:MenuItem Text="Products" NavigateUrl="javascript:void(1)"></dx:MenuItem>
                                <dx:MenuItem Text="Customers" NavigateUrl="javascript:void(2)"></dx:MenuItem>
                                <dx:MenuItem Text="Employees" NavigateUrl="javascript:void(3)"></dx:MenuItem>
                                <dx:MenuItem Text="Support" NavigateUrl="javascript:void(4)" AdaptivePriority="1"></dx:MenuItem>
                                <dx:MenuItem Text="My Account" NavigateUrl="javascript:void(5)" AdaptivePriority="1"></dx:MenuItem>
                                <dx:MenuItem Text="About Us" NavigateUrl="javascript:void(6)" AdaptivePriority="1"></dx:MenuItem>
                            </Items>
                        </dx:ASPxMenu>
                    </div>
                </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxPanel>
        <dx:ASPxDataView ID="dataView" runat="server" DataSourceID="XmlDataSource1" ClientInstanceName="dataView" CssClass="dataView" Layout="Flow">
            <SettingsFlowLayout ItemsPerPage="6"></SettingsFlowLayout>
            <PagerSettings EndlessPagingMode="OnScroll"></PagerSettings>
            <ItemStyle CssClass="dateViewItem" />
            <ContentStyle CssClass="dateViewContent" />
            <ItemTemplate>
                <dx:ASPxImage ID="imgCover" runat="server" ImageUrl='<%# Eval("PhotoUrl") %>' Width="200"
                    Height="200" ShowLoadingImage="true" />
                <table>
                    <tr>
                        <td>
                            <b>Name:</b>
                        </td>
                        <td>
                            <dx:ASPxLabel ID="lblName" runat="server" Text='<%# Eval("Name") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Address:</b>
                        </td>
                        <td>
                            <dx:ASPxLabel ID="lblAddress" runat="server" Text='<%# Eval("Address") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Phone:</b>
                        </td>
                        <td>
                            <dx:ASPxLabel ID="lblPrice" runat="server" Text='<%# Eval("Phone") %>' />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </dx:ASPxDataView>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Contacts.xml"
            XPath="//Contact" />
    </form>
</body>
</html>
