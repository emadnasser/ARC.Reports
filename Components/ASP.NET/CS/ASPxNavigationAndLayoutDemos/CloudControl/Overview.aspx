<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"%>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
    <dx:ASPxCloudControl ID="ASPxCloudControl1" runat="server" DataSourceID="CountriesDataSource" ValueField="Area" TextField="Name"
    NavigateUrlField="Name" NavigateUrlFormatString="javascript:void('{0}')">
    </dx:ASPxCloudControl>
    <ef:EntityDataSource runat="server" ID="CountriesDataSource" ContextTypeName="DataContext" EntitySetName="countries" />
</asp:Content>
