<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Overview.aspx.cs" Inherits="Overview"%>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="OrdersDataSource" Width="100%"
        KeyFieldName="OrderID">
        <Columns>
            <dx:GridViewDataColumn FieldName="ShipName"></dx:GridViewDataColumn>
            <dx:GridViewDataColumn FieldName="ShipCountry"></dx:GridViewDataColumn>
            <dx:GridViewDataColumn FieldName="ShipCity"></dx:GridViewDataColumn>
            <dx:GridViewDataColumn FieldName="ShipPostalCode"></dx:GridViewDataColumn>
        </Columns>
        <SettingsPager NumericButtonCount="6" />
    </dx:ASPxGridView>
    
    <ef:EntityDataSource runat="server" ID="OrdersDataSource"
        ContextTypeName="NorthwindContext"
        EntitySetName="Orders">
    </ef:EntityDataSource>
</asp:Content>
