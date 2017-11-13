<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.cs"
    Inherits="SiteMap_DataBinding" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
       .OptionsTable.CellPaddingRight > tbody > tr > td 
       {
           padding-right:16px;
       }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable CellPaddingRight">
        <tr>
            <td>
                <dx:ASPxComboBox SelectedIndex="0" Width="170px" ID="ddlSiteMapProvider" runat="server"
                    AutoPostBack="True" Caption="SiteMapProvider">
                    <Items>
                        <dx:ListEditItem Text="ProductsSiteMapProvider" Value="ProductsSiteMapProvider" />
                        <dx:ListEditItem Text="MenuSiteMapProvider" Value="MenuSiteMapProvider" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
            <td>
                <dx:ASPxComboBox SelectedIndex="0" Width="170px" ID="ddlStartingNodeUrl" runat="server"
                    AutoPostBack="True" Caption="StartingNodeUrl">
                    <Items>
                        <dx:ListEditItem Value="" Text=" " />
                    </Items>
                </dx:ASPxComboBox>
            </td>
            <td>
                <dx:ASPxCheckBox ID="cbShowStartingNode" runat="server" AutoPostBack="true" Checked="True"
                    Text="ShowStartingNode" />
            </td>
        </tr>
    </table>
    <dx:ASPxSiteMapControl EnableViewState="False" Width="100%" ID="ASPxSiteMapControl1"
        runat="server" DataSourceID="ASPxSiteMapDataSource1">
    </dx:ASPxSiteMapControl>
    <dx:ASPxSiteMapDataSource ID="ASPxSiteMapDataSource1" runat="server" SiteMapProvider="ProductsSiteMapProvider" />
</asp:Content>
