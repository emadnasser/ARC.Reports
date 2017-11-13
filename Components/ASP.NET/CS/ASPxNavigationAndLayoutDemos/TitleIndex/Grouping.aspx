<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Grouping.aspx.cs"
    Inherits="TitleIndex_Grouping" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxTabControl EnableTheming="False" ID="ASPxTabControl1" runat="server" ActiveTabIndex="1"
        TabSpacing="7px" EnableHotTrack="False" Width="100%" AutoPostBack="True">
        <Tabs>
            <dx:Tab Text="Alphabetically" NavigateUrl="~/TitleIndex/Grouping.aspx?gfield=Alphabetically">
            </dx:Tab>
            <dx:Tab Text="By genre" Name="Genre" NavigateUrl="~/TitleIndex/Grouping.aspx">
            </dx:Tab>
            <dx:Tab Text="By year" Name="Year" NavigateUrl="~/TitleIndex/Grouping.aspx?gfield=Year">
            </dx:Tab>
        </Tabs>
        <ActiveTabStyle BackColor="White" ForeColor="#ED1D24" Font-Bold="False">
        </ActiveTabStyle>
        <TabStyle BackColor="#ECECED" Font-Names="Verdana" Font-Size="11px" ForeColor="#4F5557">
        </TabStyle>
    </dx:ASPxTabControl>
    <dx:ASPxTitleIndex EnableTheming="False" ID="ASPxTitleIndex1" runat="server" DataSourceID="FilmsDataSource"
        NavigateUrlField="NavigateUrl" TextField="Name" CssFilePath="~/TitleIndex/Resources/BlackRed/styles.css"
        CssPostfix="BlackRed" Width="100%">
        <Columns>
            <dx:TitleIndexColumn />
        </Columns>
        <GroupContentStyle Font-Bold="False" Font-Underline="False" ItemSpacing="">
        </GroupContentStyle>
        <ItemStyle>
            <CurrentItemStyle Font-Bold="False" Font-Underline="False">
            </CurrentItemStyle>
        </ItemStyle>
        <FilterBox HorizontalPosition="Left" InfoText="" />
        <IndexPanelStyle Font-Size="11px">
        </IndexPanelStyle>
        <IndexPanelSeparatorStyle BackColor="Black" Height="1px">
        </IndexPanelSeparatorStyle>
    </dx:ASPxTitleIndex>
    <ef:EntityDataSource ID="FilmsDataSource" runat="server" ContextTypeName="DataContext" EntitySetName="Films" />
</asp:Content>
