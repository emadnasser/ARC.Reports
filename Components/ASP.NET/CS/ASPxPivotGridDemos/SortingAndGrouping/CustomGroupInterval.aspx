<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomGroupInterval.aspx.cs"
    Inherits="Features_CustomGroupInterval" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" ValueType="System.String" SelectedIndex="0"
        AutoPostBack="True" OnSelectedIndexChanged="ASPxComboBox1_SelectedIndexChanged" Caption="Select Group Interval">
        <RootStyle CssClass="OptionsBottomMargin"></RootStyle>
        <Items>
            <dx:ListEditItem Text="Group Products by First Characters" Value="0" />
            <dx:ListEditItem Text="Group Sales by Year and Quarter" Value="1" />
        </Items>
    </dx:ASPxComboBox>
    <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" DataSourceID="ProductReportsDataSource"
        CssClass="" OnCustomGroupInterval="ASPxPivotGrid1_CustomGroupInterval" OnDataBound="ASPxPivotGrid1_DataBound"
        Width="100%">
        <Fields>
            <dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Product Group" FieldName="ProductName"
                ID="fieldProductName0" Visible="True" GroupInterval="Custom" />
            <dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Product" FieldName="ProductName"
                ID="fieldProductName1" />
            <dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Sales" FieldName="ProductSales"
                ID="fieldProductSales" />
            <dx:PivotGridField Area="ColumnArea" AreaIndex="0" Caption="Year - Quarter" FieldName="ShippedDate"
                ID="fieldShippedDate0" Visible="False" />
            <dx:PivotGridField Area="ColumnArea" AreaIndex="1" Caption="Shipped Date" FieldName="ShippedDate"
                ID="fieldShippedDate1" GroupInterval="DateYear" />
        </Fields>
        <OptionsView ShowFilterHeaders="False" HorizontalScrollBarMode="Auto" />
        <OptionsFilter NativeCheckBoxes="False" />
    </dx:ASPxPivotGrid>
    <ef:EntityDataSource runat="server" ID="ProductReportsDataSource" ContextTypeName="NorthwindContext" EntitySetName="ProductReports" />
</asp:Content>
