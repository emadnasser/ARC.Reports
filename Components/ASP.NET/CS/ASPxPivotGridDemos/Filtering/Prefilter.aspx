<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Prefilter.aspx.cs"
    Inherits="Prefilter" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxPivotGrid ID="pivotGrid" runat="server" DataSourceID="CustomerReportsDataSource"
        Width="100%">
        <Fields>
            <dx:PivotGridField Area="RowArea" AreaIndex="0" FieldName="CompanyName" ID="fieldCompanyName"
                Caption="Customer" />
            <dx:PivotGridField Area="ColumnArea" AreaIndex="0" FieldName="OrderDate" ID="fieldOrderDate0"
                Caption="Year" GroupInterval="DateYear" />
            <dx:PivotGridField Area="ColumnArea" AreaIndex="1" FieldName="OrderDate" ID="fieldOrderDate1"
                Caption="Quarter" GroupInterval="DateQuarter" ValueFormat-FormatString="Qtr {0}" ValueFormat-FormatType="Numeric" />
            <dx:PivotGridField Area="DataArea" AreaIndex="0" FieldName="ProductAmount" ID="fieldProductAmount"
                Caption="Product Amount" />
            <dx:PivotGridField Area="FilterArea" AreaIndex="0" FieldName="ProductName" ID="fieldProductName"
                Caption="Product Name" />
        </Fields>
        <OptionsView HorizontalScrollBarMode="Auto" />
        <OptionsFilter NativeCheckBoxes="False" />
        <Prefilter CriteriaString="[fieldOrderDate0] = 1997" />
    </dx:ASPxPivotGrid>
    <ef:EntityDataSource runat="server" ID="CustomerReportsDataSource" ContextTypeName="NorthwindContext" EntitySetName="CustomerReports" />
</asp:Content>
