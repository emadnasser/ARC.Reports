<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ServerMode.aspx.vb"
	Inherits="ServerModeDemo" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:CreateDatabaseControl runat="server" ID="CreateDatabaseControl" TableKey="GeneratedServerModeTable" />
	<div runat="server" id="Demo">
		<script type="text/javascript">
		// <![CDATA[
			var start;
			function pivotGrid_Init(s, e) {
				pivotGrid.PerformCallback("Reload");
			}
			function pivotGrid_BeginCallback(s, e) {
				start = new Date();
				ClientTimeLabel.SetText("working...");
			}
			function pivotGrid_EndCallback(s, e) {
				ClientTimeLabel.SetText(new Date() - start);
			}            
		// ]]>         
		</script>
		<div style="float: left;">
			<div class="TopPadding">
					<dx:ASPxLabel runat="server" ID="ASPxLabel3" Text="Time taken (ms):" />
					<b>
						<dx:ASPxLabel runat="server" ID="ASPxLabel4" ClientInstanceName="ClientTimeLabel"
							Text="..." />
					</b>
			</div>
		</div>
		<b class="Clear"></b>
		<br />
		 <dx:ASPxPivotGrid ID="ASPxPivotGrid1" DataSourceID="LinqServerModeDataSource" runat="server" ClientInstanceName="pivotGrid"  CustomCallback="ASPxPivotGrid1_CustomCallback"  Width="100%" >
			 <Fields>
					<dx:PivotGridField ID="fieldOrderID" FieldName="OrderID" Visible="False" Caption="OrderID" DisplayFolder="Order" />
					<dx:PivotGridField ID="fieldQuantity" FieldName="Quantity" Area="DataArea" Caption="Quantity" DisplayFolder="Order" />
					<dx:PivotGridField ID="fieldUnitPrice" FieldName="UnitPrice" Area="DataArea" Caption="Unit Price" DisplayFolder="Order" />
					<dx:PivotGridField ID="fieldRevenue" Area="DataArea" Caption="Revenue" UnboundExpression="[UnitPrice]*[Quantity]" UnboundType="Object" DisplayFolder="Order"  CellFormat-FormatType="Numeric" CellFormat-FormatString="c" />                
					<dx:PivotGridField ID="fieldCustomer" FieldName="PgdOrder.PgdCustomer.CustomerName" Visible="False" Caption="Customer" DisplayFolder="Customer" />
					<dx:PivotGridField ID="fieldCustomerID" FieldName="PgdOrder.CustomerID" Visible="False" Caption="CustomerID" DisplayFolder="Customer" />
					<dx:PivotGridField ID="fieldOrderDate" FieldName="PgdOrder.OrderDate" Visible="False" Caption="Order Date" DisplayFolder="Order Date" />
					<dx:PivotGridField ID="fieldOrderYear" FieldName="PgdOrder.OrderDate" Area="ColumnArea" Caption="Order Year" GroupInterval="DateYear" DisplayFolder="Order Date" />
					<dx:PivotGridField ID="fieldOrderQuarter" FieldName="PgdOrder.OrderDate" Visible="False" Area="ColumnArea" Caption="Order Quarter" GroupInterval="DateQuarter" DisplayFolder="Order Date" />
					<dx:PivotGridField ID="fieldOrderMonth" FieldName="PgdOrder.OrderDate" Visible="False" Area="ColumnArea" Caption="Order Month" GroupInterval="DateMonth" DisplayFolder="Order Date" />
					<dx:PivotGridField ID="fieldProduct" FieldName="PgdProduct.ProductName" Area="RowArea" Caption="Product" DisplayFolder="Product" />
					<dx:PivotGridField ID="fieldProductID" FieldName="ProductID" Visible="False" Caption="ProductID" DisplayFolder="Product" />
					<dx:PivotGridField ID="fieldCategoryName" FieldName="PgdProduct.PgdCategory.CategoryName"  Visible="False" Caption="Category Name" DisplayFolder="Product" />
					<dx:PivotGridField ID="fieldCategoryID" FieldName="PgdProduct.CategoryID"  Visible="False" Caption="CategoryID" DisplayFolder="Product" />
					<dx:PivotGridField ID="fieldSalesPerson" FieldName="PgdOrder.PgdSalesPerson.SalesPersonName" Area="RowArea" Caption="Sales Person" DisplayFolder="Sales Person" />
					<dx:PivotGridField ID="fieldSalesPersonID" FieldName="PgdOrder.SalesPersonID" Visible="False" Caption="SalesPersonID" DisplayFolder="Sales Person" />
			 </Fields>
			 <ClientSideEvents Init="pivotGrid_Init" BeginCallback="pivotGrid_BeginCallback" EndCallback="pivotGrid_EndCallback" />
			 <OptionsView HorizontalScrollBarMode="Visible" />            
			 <OptionsCustomization CustomizationFormStyle="Excel2007" />
			 <OptionsPager RowsPerPage="15" ColumnsPerPage="10" />
		 </dx:ASPxPivotGrid>
		<dx:LinqServerModeDataSource ID="LinqServerModeDataSource" runat="server" ContextTypeName="PivotGridDemoDBDataContextExt"
			TableName="PgdSales" />
	</div>
</asp:Content>