<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ExportWithFormatConditions.aspx.vb" Inherits="Exporting_ExportWithFormatConditions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ToolbarExport runat="server" ID="ToolbarExport" ExportItemTypes="Pdf,Xls,Xlsx,Rtf" OnItemClick="ToolbarExport_ItemClick" />
	<dx:ASPxGridView ID="Grid" runat="server" DataSourceID="InvoicesDataSource" Width="100%" KeyFieldName="OrderID;ProductID" EnableRowsCache="false">
		<Columns>
			<dx:GridViewDataColumn FieldName="CustomerName" Width="260px" />
			<dx:GridViewDataTextColumn FieldName="UnitPrice">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
			<dx:GridViewDataSpinEditColumn FieldName="Discount" Settings-FilterMode="Value">
				<PropertiesSpinEdit DisplayFormatString="p0" />
			</dx:GridViewDataSpinEditColumn>
			<dx:GridViewDataColumn FieldName="Quantity" />
			<dx:GridViewDataTextColumn FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitPrice * Quantity * (1 - Discount)">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
		</Columns>
		<FormatConditions>
			<dx:GridViewFormatConditionTopBottom FieldName="UnitPrice" Rule="AboveAverage" Format="ItalicText" />
			<dx:GridViewFormatConditionTopBottom FieldName="UnitPrice" Rule="AboveAverage" Format="RedText" />
			<dx:GridViewFormatConditionTopBottom FieldName="Discount" Rule="TopItems" Threshold="15" Format="BoldText" />
			<dx:GridViewFormatConditionHighlight FieldName="Discount" Expression="[Discount] > 0" Format="GreenFillWithDarkGreenText" />
			<dx:GridViewFormatConditionColorScale FieldName="Quantity" Format="GreenWhite" />
			<dx:GridViewFormatConditionIconSet FieldName="Quantity" Format="Ratings4" />
			<dx:GridViewFormatConditionTopBottom FieldName="Total" Rule="TopPercent" Threshold="20" Format="Custom">
				<CellStyle Font-Bold="true" ForeColor="#9c0006" />
			</dx:GridViewFormatConditionTopBottom>
		</FormatConditions>
	</dx:ASPxGridView>
	<dx:ASPxGridViewExporter ID="Exporter" runat="server" GridViewID="Grid" />
	<ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Invoices" />
</asp:Content>