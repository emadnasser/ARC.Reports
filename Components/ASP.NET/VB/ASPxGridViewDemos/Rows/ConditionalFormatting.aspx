<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConditionalFormatting.aspx.vb"
	Inherits="Rows_ConditionalFormatting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="Grid" runat="server" DataSourceID="InvoicesDataSource" Width="100%" KeyFieldName="OrderID;ProductID" EnableRowsCache="false">
		<Columns>
			<dx:GridViewDataColumn FieldName="CustomerName" Width="260px" />
			<dx:GridViewDataColumn FieldName="Freight" SortOrder="Descending" />
			<dx:GridViewDataTextColumn FieldName="UnitPrice" >
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
			<dx:GridViewDataSpinEditColumn FieldName="Discount" Settings-FilterMode="Value">
				<PropertiesSpinEdit DisplayFormatString="p0" />
			</dx:GridViewDataSpinEditColumn >
			<dx:GridViewDataColumn FieldName="Quantity" />
			<dx:GridViewDataTextColumn FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitPrice * Quantity * (1 - Discount)">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
		</Columns>
		<FormatConditions>
			<dx:GridViewFormatConditionTopBottom FieldName="Freight" Rule="TopPercent" Threshold="20" Format="RedText" />
			<dx:GridViewFormatConditionTopBottom FieldName="Freight" Rule="TopPercent" Threshold="20" Format="BoldText" />
			<dx:GridViewFormatConditionTopBottom FieldName="Freight" Rule="BottomPercent" Threshold="20" Format="GreenText" />
			<dx:GridViewFormatConditionTopBottom FieldName="Freight" Rule="BottomPercent" Threshold="20" Format="BoldText" />
			<dx:GridViewFormatConditionHighlight FieldName="Discount" Expression="[Discount] > 0" Format="GreenFillWithDarkGreenText" />
			<dx:GridViewFormatConditionTopBottom FieldName="Discount" Rule="TopItems" Threshold="15" Format="BoldText" />
			<dx:GridViewFormatConditionTopBottom FieldName="UnitPrice" Rule="AboveAverage" Format="ItalicText" />
			<dx:GridViewFormatConditionTopBottom FieldName="UnitPrice" Rule="AboveAverage" Format="RedText" />
			<dx:GridViewFormatConditionColorScale FieldName="Quantity" Format="BlueWhiteRed" />
			<dx:GridViewFormatConditionIconSet FieldName="Quantity" Format="Ratings4" />
			<dx:GridViewFormatConditionIconSet FieldName="Total" Format="Arrows5Colored" />
		</FormatConditions>
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Invoices" />
</asp:Content>