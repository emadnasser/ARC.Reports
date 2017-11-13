<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CellTemplates.aspx.vb"
	Inherits="Appearance_CellTemplate" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxPivotGrid ID="pivotGrid" runat="server" DataSourceID="ProductReportsDataSource"
		ClientInstanceName="pivotGrid" Width="100%">
		<Fields>
			<dx:PivotGridField Area="RowArea" AreaIndex="0" FieldName="CategoryName" ID="fieldCategoryName" />
			<dx:PivotGridField Area="RowArea" AreaIndex="1" FieldName="ProductName" ID="fieldProductName" />
			<dx:PivotGridField Area="DataArea" AreaIndex="0" FieldName="ProductSales" ID="fieldProductSales" />
			<dx:PivotGridField ID="fieldPercents" Area="DataArea" AreaIndex="1" Caption="Percents"
				FieldName="ProductSales" SummaryDisplayType="PercentOfColumn" />
		</Fields>
		<OptionsCustomization AllowDrag="False" />
		<OptionsView ShowFilterHeaders="False" />
		<OptionsFilter NativeCheckBoxes="False" />
	</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="ProductReportsDataSource" ContextTypeName="NorthwindContext" EntitySetName="ProductReports" />
</asp:Content>