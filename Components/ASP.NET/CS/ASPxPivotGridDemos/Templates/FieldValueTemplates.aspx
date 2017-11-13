<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FieldValueTemplates.aspx.cs"
    Inherits="Templates_FieldValueTemplates" %>
<asp:Content runat="server" ID="CssContent" ContentPlaceHolderID="CustomHeadHolder">
    <style type="text/css">
        div span input { margin-left: 10px; }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" ValueType="System.String" SelectedIndex="0"
        AutoPostBack="True" OnSelectedIndexChanged="ASPxComboBox1_SelectedIndexChanged" Caption="Select Template">
        <RootStyle CssClass="OptionsBottomMargin"></RootStyle>
        <Items>
            <dx:ListEditItem Text="Moon Phase" Value="Moon Phase" />
            <dx:ListEditItem Text="Chinese Calendar" Value="Chinese Calendar" />
        </Items>
    </dx:ASPxComboBox>
    <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" DataSourceID="ProductReportsDataSource"
        OnCustomGroupInterval="ASPxPivotGrid1_CustomGroupInterval" OnFieldValueDisplayText="ASPxPivotGrid1_FieldValueDisplayText"
        Width="850">
        <Fields>
            <dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Category" FieldName="CategoryName" AllowedAreas="ColumnArea,RowArea,FilterArea"
                ID="fieldCategoryName" />
            <dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Product" FieldName="ProductName" AllowedAreas="ColumnArea,RowArea,FilterArea"
                ID="fieldProductName" Visible="False" />
            <dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Sales" FieldName="ProductSales"
                ID="fieldProductSales" />
            <dx:PivotGridField Area="ColumnArea" AreaIndex="0" FieldName="ShippedDate" ID="fieldShippedDate" AllowedAreas="ColumnArea,RowArea,FilterArea"
                GroupInterval="Custom" UnboundFieldName="UnboundColumn0" />
        </Fields>
        <OptionsView ShowFilterHeaders="False" HorizontalScrollBarMode="Auto"/>
        <OptionsFilter NativeCheckBoxes="False" />
    </dx:ASPxPivotGrid>
    <ef:EntityDataSource runat="server" ID="ProductReportsDataSource" ContextTypeName="NorthwindContext" EntitySetName="ProductReports" />
</asp:Content>
