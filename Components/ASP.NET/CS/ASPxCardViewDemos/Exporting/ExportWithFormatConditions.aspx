<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ExportWithFormatConditions.aspx.cs" Inherits="Exporting_ExportWithFormatConditions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ToolbarExport runat="server" ID="ToolbarExport" ExportItemTypes="Pdf,Xls,Xlsx,Rtf" IsDataAwareXls="true" IsDataAwareXlsx="true" OnItemClick="ToolbarExport_ItemClick" />
    <dx:ASPxCardView ID="cardView" runat="server" DataSourceID="HomesDataSource" EnableCardsCache="false" Width="100%">
        <Columns>
            <dx:CardViewColumn FieldName="Address" />
            <dx:CardViewColumn FieldName="Baths" />
            <dx:CardViewColumn FieldName="Beds" />
            <dx:CardViewColumn FieldName="HouseSize" />
            <dx:CardViewTextColumn FieldName="Price">
                <PropertiesTextEdit DisplayFormatString="c" />
            </dx:CardViewTextColumn>
            <dx:CardViewColumn FieldName="Status" />
            <dx:CardViewImageColumn FieldName="PhotoUrl">
                <PropertiesImage ImageWidth="200">
                    <ExportImageSettings Width="200" Height="133" />
                </PropertiesImage>
            </dx:CardViewImageColumn>
        </Columns>
        <Settings ShowSummaryPanel="true" />
        <CardLayoutProperties ColCount="2">
            <Items>
                <dx:CardViewColumnLayoutItem ColumnName="PhotoUrl" ShowCaption="False" RowSpan="6" VerticalAlign="Top" />
                <dx:CardViewColumnLayoutItem ColumnName="Baths" />
                <dx:CardViewColumnLayoutItem ColumnName="Beds" />
                <dx:CardViewColumnLayoutItem ColumnName="HouseSize" />
                <dx:CardViewColumnLayoutItem ColumnName="Price" />
                <dx:CardViewColumnLayoutItem ColumnName="Address" />
            </Items>
        </CardLayoutProperties>
        <FormatConditions>
            <dx:CardViewFormatConditionTopBottom Rule="BottomItems" Threshold="10" FieldName="Price" Format="BoldText" />
            <dx:CardViewFormatConditionTopBottom Rule="BottomItems" Threshold="10" FieldName="Price" Format="GreenText" />
            <dx:CardViewFormatConditionTopBottom Rule="TopItems" Threshold="10" FieldName="Price" Format="BoldText" />
            <dx:CardViewFormatConditionTopBottom Rule="TopItems" Threshold="10" FieldName="Price" Format="RedText" />
            <dx:CardViewFormatConditionIconSet FieldName="Baths" Format="Arrows3Colored" />
            <dx:CardViewFormatConditionIconSet FieldName="Beds" Format="Arrows3Colored" />
            <dx:CardViewFormatConditionTopBottom FieldName="HouseSize" Rule="TopItems" Threshold="5" Format="GreenText" />
            <dx:CardViewFormatConditionTopBottom FieldName="HouseSize" Rule="BottomItems" Threshold="5" Format="RedText" />
        </FormatConditions>
        <SettingsPager SettingsTableLayout-ColumnCount="2" />
        <Styles>
            <Card Width="450" />
        </Styles>
        <TotalSummary>
            <dx:ASPxCardViewSummaryItem FieldName="Price" SummaryType="Min" />
            <dx:ASPxCardViewSummaryItem FieldName="Price" SummaryType="Max" />
        </TotalSummary>
    </dx:ASPxCardView>
    <dx:ASPxCardViewExporter ID="cardViewExport" runat="server" CardViewID="cardView" CardWidth="430" OnRenderBrick="cardViewExport_RenderBrick" />
    <asp:ObjectDataSource ID="HomesDataSource" runat="server" SelectMethod="SelectHomes" TypeName="HomesDataProvider" />
</asp:Content>
