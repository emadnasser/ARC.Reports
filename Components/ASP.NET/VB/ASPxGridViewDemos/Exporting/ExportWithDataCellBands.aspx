<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="ExportWithDataCellBands.aspx.vb" Inherits="Exporting_ExportWithDataCellBands" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.price-cell
		{
			font-size: 1.6em;
		}
		.address-cell
		{
			font-size: 1.3em;
			font-weight: 600;
			border-bottom: 0 !important;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ToolbarExport runat="server" ID="ToolbarExport" ExportItemTypes="Pdf,Xls,Xlsx,Rtf" IsDataAwareXls="false" IsDataAwareXlsx="false" OnItemClick="ToolbarExport_ItemClick" />
	<dx:ASPxGridView ID="Grid" runat="server" DataSourceID="HomesDataSource" Width="100%">
		<Columns>
			<dx:GridViewDataSpinEditColumn FieldName="Price">
				<PropertiesSpinEdit DisplayFormatString="c0" />
				<CellStyle CssClass="price-cell" />
			</dx:GridViewDataSpinEditColumn>
			<dx:GridViewDataColumn FieldName="Address">
				<Columns>
					<dx:GridViewDataColumn FieldName="Features">
						<Columns>
							<dx:GridViewDataColumn FieldName="Beds" ExportWidth="80" />
							<dx:GridViewDataColumn FieldName="Baths" ExportWidth="80" />
							<dx:GridViewDataColumn FieldName="HouseSize" ExportWidth="80" />
							<dx:GridViewDataColumn FieldName="YearBuilt" CellStyle-HorizontalAlign="Right" ExportWidth="80" />
						</Columns>
					</dx:GridViewDataColumn>
				</Columns>
				<CellStyle CssClass="address-cell" />
			</dx:GridViewDataColumn>
			<dx:GridViewDataImageColumn FieldName="PhotoUrl" Caption="Photo" CellStyle-CssClass="photo-cell">
				<PropertiesImage ImageWidth="200" />
			</dx:GridViewDataImageColumn>
		</Columns>
		<SettingsPager PageSize="3" />
		<Styles>
			<Header HorizontalAlign="Center" />
		</Styles>
	</dx:ASPxGridView>
	<asp:ObjectDataSource ID="HomesDataSource" runat="server" SelectMethod="SelectHomes" TypeName="HomesDataProvider" />
	<dx:ASPxGridViewExporter runat="server" ID="gridExporter" GridViewID="Grid" OnRenderBrick="gridExporter_RenderBrick" />
</asp:Content>