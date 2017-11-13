<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Templates.aspx.cs"
    Inherits="TabControl_Templates" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .tabContent {
            background-color: #FDFEFF;
            background-image: url(Images/Templates/ContentCenter.gif);
            background-repeat: repeat-x;
            background-position: left top;
            color: #333333;
            width: 100%;
            padding: 10px;
            height: 240px;
        }
        .tabContent td
        {
            vertical-align: top;
            padding: 18px 8px 8px 18px;
        }
        .tabTemplate,
        .tabTemplate .label
        {
            border-collapse: collapse;
            font: 12px Tahoma;
            color: #333333;
        }
        .tabTemplate img
        {
            margin: 0;
            display: block;
        }
        .tabTemplate td
        {
        	padding: 0;
        }
        .pcTemplates .dxtc-leftIndent,
        .pcTemplates .dxtc-tab,
        .pcTemplates .dxtc-activeTab,
        .pcTemplates .dxtc-rightIndent
        {
            border-width: 0px!important;
            background-color: white!important;
        }
        .pcTemplates .dxtc-leftIndent,
        .pcTemplates .dxtc-tab,
        .pcTemplates .dxtc-rightIndent
        {
            border-bottom-width: 1px!important;
        }
        .dxpc-tabImage {
            border-radius: 20px; 
            height: 24px; 
            width: 24px; 
            box-sizing: border-box;
        }
        .dxpc-tabImage.active {
            height: 25px; 
            width: 25px; 
            border: 1px solid #6DA0E7; 
        }
        .tabTemplate .unSelectedcenter {
            background: url(Images/Templates/UnSelectedCenter.gif) repeat-x;
            padding: 1px;
        }
        .tabTemplate .selectedcenter {
            background: url(Images/Templates/SelectedCenter.gif) repeat-x;
            padding: 1px;
        }
        .pcTemplates .dxtc-activeTab {
            padding-bottom: 0 !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxPageControl SkinID="None" Width="100%" EnableViewState="false" ID="ASPxPageControl2"
        runat="server" ActiveTabIndex="0" TabSpacing="0px" CssClass="pcTemplates"
        EnableHierarchyRecreation="True" >
        <TabPages>
            <dx:TabPage Text="Ganymede" Name="Ganymede" >
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <% = GetHtml("Ganymede.html") %>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Io" Name="Io" >
                <ContentCollection>
                    <dx:ContentControl runat="server" >
                        <% = GetHtml("Io.html") %>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Callisto" Name="Callisto"  >
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <% = GetHtml("Callisto.html") %>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Europa" Name="Europa"  >
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <% = GetHtml("Europa.html") %>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
        </TabPages>
        <TabTemplate>
            <table class="tabTemplate">
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" GenerateEmptyAlternateText="true"
                            ImageUrl="Images/Templates/UnSelectedLeft.gif" /></td>
                    <td class="unSelectedcenter">
                        <img alt="tabImage"  src="<%# GetImageUrl(Container.TabPage.Text)  %>" class="dxpc-tabImage" /></td>
                    <td class="unSelectedcenter">
                        <%# Container.TabPage.Text %>
                    <td>
                        <asp:Image ID="Image2" runat="server" GenerateEmptyAlternateText="true"
                            ImageUrl="Images/Templates/UnSelectedRight.gif" /></td>
                </tr>
            </table>
        </TabTemplate>
        <ActiveTabTemplate>
            <table class="tabTemplate">
                <tr>
                    <td>
                        <asp:Image ID="Image3" runat="server" GenerateEmptyAlternateText="true"
                            ImageUrl="Images/Templates/SelectedLeft.gif" /></td>
                    <td class="selectedcenter">
                        <img alt="tabImage" src="<%# GetImageUrl(Container.TabPage.Text)  %>" class="dxpc-tabImage active" /></td>
                    <td class="selectedcenter">
                        <%# Container.TabPage.Text %>
                    <td>
                        <asp:Image ID="Image4" runat="server" GenerateEmptyAlternateText="true"
                            ImageUrl="Images/Templates/SelectedRight.gif" /></td>
                </tr>
            </table>
        </ActiveTabTemplate>
        <Paddings Padding="0px" PaddingLeft="12px" />
        <ContentStyle Font-Names="Tahoma" Font-Overline="False" Font-Size="11px">
            <Paddings Padding="0px" />
            <Border BorderColor="#6DA0E7" BorderStyle="Solid" BorderWidth="1px" />
        </ContentStyle>
    </dx:ASPxPageControl>
</asp:Content>
