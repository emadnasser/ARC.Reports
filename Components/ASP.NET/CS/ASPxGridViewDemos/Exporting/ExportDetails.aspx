<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ExportDetails.aspx.cs"
    Inherits="Exporting_ExportDetails" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ToolbarExport runat="server" ID="ToolbarExport" ExportItemTypes="Pdf,Xls,Xlsx,Rtf,Csv" OnItemClick="ToolbarExport_ItemClick" />
    <dx:ASPxComboBox runat="server" ID="ddlExportMode" Caption="Details Export Mode">
        <RootStyle CssClass="OptionsBottomMargin"></RootStyle>
        <CaptionCellStyle>
            <Paddings PaddingRight="4px" />
        </CaptionCellStyle>
    </dx:ASPxComboBox>
    <dx:ASPxGridView ID="grid" runat="server" DataSourceID="CategoriesDataSource" Width="100%" EnableRowsCache="false"
        AutoGenerateColumns="False" KeyFieldName="CategoryID">
        <Columns>
            <dx:GridViewDataTextColumn FieldName="CategoryID" />
            <dx:GridViewDataTextColumn FieldName="CategoryName" />
            <dx:GridViewDataTextColumn FieldName="Description" />
            <dx:GridViewDataBinaryImageColumn FieldName="Picture">
                <PropertiesBinaryImage ImageWidth="120" ImageHeight="80">
                    <ExportImageSettings Width="90" Height="60" />
                </PropertiesBinaryImage>
            </dx:GridViewDataBinaryImageColumn>
        </Columns>
        <SettingsDetail ShowDetailRow="True" />
        <Templates>
            <DetailRow>
                <dx:ASPxGridView ID="detailGrid" runat="server" AutoGenerateColumns="False" DataSourceID="ProductsDataSource"
                    KeyFieldName="ProductID" Width="100%" OnBeforePerformDataSelect="detailGrid_BeforePerformDataSelect">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="ProductID" />
                        <dx:GridViewDataTextColumn FieldName="ProductName" />
                        <dx:GridViewDataTextColumn FieldName="UnitPrice">
                            <PropertiesTextEdit DisplayFormatString="c" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="QuantityPerUnit" />
                    </Columns>
                </dx:ASPxGridView>
            </DetailRow>
        </Templates>
    </dx:ASPxGridView>
    <div class="Note">
        <b>Note:</b>
        If you export grouped data to RTF, be sure to open the resulting file with an editor that fully supports RTF, including tables. 
        For instance, Microsoft WordPad does not support this feature, and thus the file may appear corrupt.
    </div>
    <dx:ASPxGridViewExporter ID="exporter" runat="server" />
    <ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories" />
    <ef:EntityDataSource runat="server" ID="ProductsDataSource" ContextTypeName="NorthwindContext" EntitySetName="Products" Where="it.CategoryID = @CategoryID">
        <WhereParameters>
            <asp:SessionParameter Name="CategoryID" SessionField="CategoryID" Type="Int32" />
        </WhereParameters>
    </ef:EntityDataSource>
</asp:Content>
