<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ExportSelected.aspx.cs"
    Inherits="Exporting_ExportSelected" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ToolbarExport runat="server" ID="ToolbarExport" ExportItemTypes="Pdf,Xls,Xlsx,Rtf,Csv" OnItemClick="ToolbarExport_ItemClick" />
    <table class="OptionsBottomMargin">
        <tr>
            <td style="padding-right: 4px">
                <dx:ASPxButton ID="btnRefreshSummaries" runat="server" Text="Refresh Summaries" UseSubmitBehavior="False"
                    AutoPostBack="false">
                    <ClientSideEvents Click="function(s, e) { grid.PerformCallback('Refresh'); }" />
                </dx:ASPxButton>
            </td>
            <td style="padding-right: 4px">
                <dx:ASPxButton ID="btnSelectAll" runat="server" Text="Select All" UseSubmitBehavior="False"
                    AutoPostBack="false">
                    <ClientSideEvents Click="function(s, e) { grid.SelectRows(); }" />
                </dx:ASPxButton>
            </td>
            <td style="padding-right: 4px">
                <dx:ASPxButton ID="btnUnselectAll" runat="server" Text="Unselect All" UseSubmitBehavior="False"
                    AutoPostBack="false">
                    <ClientSideEvents Click="function(s, e) { grid.UnselectRows(); }" />
                </dx:ASPxButton>
            </td>
            <td style="padding-right: 4px">
                <dx:ASPxButton ID="btnSelectAllOnPage" runat="server" Text="Select all on the page"
                    UseSubmitBehavior="False" AutoPostBack="false">
                    <ClientSideEvents Click="function(s, e) { grid.SelectAllRowsOnPage(); }" />
                </dx:ASPxButton>
            </td>
            <td>
                <dx:ASPxButton ID="btnUnselectAllOnPage" runat="server" Text="Unselect all on the page"
                    UseSubmitBehavior="False" AutoPostBack="false">
                    <ClientSideEvents Click="function(s, e) { grid.UnselectAllRowsOnPage(); }" />
                </dx:ASPxButton>
            </td>
        </tr>
    </table>
    
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="ProductsDataSource"
        Width="100%" AutoGenerateColumns="False" KeyFieldName="ProductID" OnCustomUnboundColumnData="grid_CustomUnboundColumnData"
        OnCustomSummaryCalculate="grid_CustomSummaryCalculate" OnCustomCallback="grid_CustomCallback">
        <Columns>
            <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" />
            <dx:GridViewDataTextColumn FieldName="ProductName" VisibleIndex="1" />
            <dx:GridViewDataTextColumn FieldName="QuantityPerUnit" VisibleIndex="2" />
            <dx:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="3">
                <PropertiesTextEdit DisplayFormatString="c" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="UnitsInStock" VisibleIndex="4" />
            <dx:GridViewDataTextColumn FieldName="Total" VisibleIndex="5" UnboundType="Decimal">
                <PropertiesTextEdit DisplayFormatString="c" />
            </dx:GridViewDataTextColumn>
        </Columns>
        <TotalSummary>
            <dx:ASPxSummaryItem FieldName="ProductName" SummaryType="Custom" />
            <dx:ASPxSummaryItem FieldName="Total" SummaryType="Custom" />
        </TotalSummary>
        <Settings ShowGroupPanel="True" ShowFooter="True" ShowFilterRow="True" />
    </dx:ASPxGridView>
    <div class="Note">
        <b>Note:</b>
        If you export grouped data to RTF, be sure to open the resulting file with an editor that fully supports RTF, including tables. 
        For instance, Microsoft WordPad does not support this feature, and thus the file may appear corrupt.
    </div>
    <dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="grid" ExportSelectedRowsOnly="true" />
    <ef:EntityDataSource runat="server" ID="ProductsDataSource" ContextTypeName="NorthwindContext" EntitySetName="Products" />
</asp:Content>
