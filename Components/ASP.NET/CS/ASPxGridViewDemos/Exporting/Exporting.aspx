<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Exporting.aspx.cs" Inherits="Exporting_Exporting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
    <dx:ToolbarExport runat="server" ID="ToolbarExport" ExportItemTypes="Pdf,Xls,Xlsx,Rtf,Csv" OnItemClick="ToolbarExport_ItemClick" />
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomerReportsDataSource" 
        Width="100%" AutoGenerateColumns="False">
        <Columns>
            <dx:GridViewDataColumn Caption="Product Name" FieldName="ProductName" VisibleIndex="0" GroupIndex="0">
            </dx:GridViewDataColumn>
            <dx:GridViewDataColumn Caption="Company Name" FieldName="CompanyName" VisibleIndex="1">
            </dx:GridViewDataColumn>
            <dx:GridViewDataColumn Caption="Order Date" FieldName="OrderDate" VisibleIndex="2">
            </dx:GridViewDataColumn>
            <dx:GridViewDataTextColumn Caption="Product Amount" FieldName="ProductAmount" ReadOnly="True"
                VisibleIndex="3">
                <PropertiesTextEdit DisplayFormatString="c"></PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
        </Columns>
        <Settings ShowGroupPanel="True" ShowFooter="True" ShowFilterRow="True"/>
        <GroupSummary>
            <dx:ASPxSummaryItem FieldName="ProductAmount" SummaryType="Sum" />
            <dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" />
        </GroupSummary>
        <TotalSummary>
            <dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" />
            <dx:ASPxSummaryItem FieldName="ProductAmount" SummaryType="Sum" />
        </TotalSummary>
    </dx:ASPxGridView>
    <div class="Note">
		<b>Note:</b>
		If you export grouped data to RTF, be sure to open the resulting file with an editor that fully supports RTF, including tables. 
        For instance, Microsoft WordPad does not support this feature, and thus the file may appear corrupt.
    </div>
    <dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="grid"></dx:ASPxGridViewExporter>
    <ef:EntityDataSource runat="server" ID="CustomerReportsDataSource" ContextTypeName="NorthwindContext" EntitySetName="CustomerReports" />
</asp:Content>
