<%@ Control Language="vb" AutoEventWireup="true" CodeFile="ProductsPivotGrid.ascx.vb" Inherits="UserControls_ProductsPivotGrid" %>
<dx:ASPxPivotGrid ID="PivotGrid" runat="server" DataSourceID="SalesDataSource" Width="100%" CssClass="pivot">
    <OptionsView ShowFilterHeaders="False" ShowColumnHeaders="False" />
    <OptionsPager RowsPerPage="4" PagerAlign="Right" Position="Bottom"></OptionsPager>
    <OptionsCustomization AllowPrefilter="false" AllowCustomizationForm="false" />
    <OptionsChartDataSource ProvideDataByColumns="false" ProvideRowGrandTotals="true" />
    <Fields>
        <dx:PivotGridField Area="RowArea" Caption="State" FieldName="Order.Store.Address.State" AllowedAreas="RowArea" Options-AllowFilter="False" />
        <dx:PivotGridField Area="RowArea" Caption="City" FieldName="Order.Store.Address.City" AllowedAreas="RowArea" Options-AllowFilter="False" />
        <dx:PivotGridField Area="DataArea" Caption="Sales" FieldName="Total" AllowedAreas="DataArea">
            <CellStyle CssClass="salesCell" />
        </dx:PivotGridField>
        <dx:PivotGridField Area="RowArea" Caption="Name" FieldName="Product.Name" Visible="false" />
        <dx:PivotGridField Area="RowArea" Caption="Category" FieldName="Product.Category" Visible="false" />
        <dx:PivotGridField ID="FieldPercentage" Area="DataArea" Caption="Percentage" AllowedAreas="DataArea" FieldName="Total" SummaryDisplayType="PercentOfColumn" />
    </Fields>
    <Styles>
        <RowAreaStyle CssClass="rowArea"></RowAreaStyle>
        <ColumnAreaStyle CssClass="columnArea"></ColumnAreaStyle>
        <DataAreaStyle CssClass="dataArea"></DataAreaStyle>
        <HeaderStyle CssClass="header" />
    </Styles>
</dx:ASPxPivotGrid>
<dx:EntityServerModeDataSource ID="SalesDataSource" runat="server" OnSelecting="SalesDataSource_Selecting" />