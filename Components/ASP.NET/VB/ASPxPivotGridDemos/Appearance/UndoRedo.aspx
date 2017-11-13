<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UndoRedo.aspx.vb"
	Inherits="UndoRedo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<script type="text/javascript">
		function UpdateButtonStates() {
			btnUndo.SetEnabled(!!pivot.cpIsUndoEnabled);
			btnRedo.SetEnabled(!!pivot.cpIsRedoEnabled);
		}
	</script>
	<table class="OptionsTable BottomMargin">
		<tr>
			<td>
				<dx:ASPxButton runat="server" ID="ButtonUndo" AutoPostBack="False" ClientEnabled="False"
					ClientInstanceName="btnUndo" Text="Undo">
					<ClientSideEvents Click="function(s, e) { if(pivot.InCallback()) return; pivot.PerformCallback('UNDO'); }" />
				</dx:ASPxButton>
			</td>
			<td>
				<dx:ASPxButton runat="server" ID="ButtonRedo" AutoPostBack="False" ClientEnabled="False"
					ClientInstanceName="btnRedo" Text="Redo">
					<ClientSideEvents Click="function(s, e) { if(pivot.InCallback()) return; pivot.PerformCallback('REDO'); }" />
				</dx:ASPxButton>
			</td>
		</tr>
	</table>
	<dx:ASPxPivotGrid runat="server" ID="ASPxPivotGrid1" ClientInstanceName="pivot" DataSourceID="ProductReportsDataSource"
		Width="100%" OnGridLayout="ASPxPivotGrid1_GridLayout" OnCustomCallback="ASPxPivotGrid1_CustomCallback">
		<Fields>
			<dx:PivotGridField Area="ColumnArea" AreaIndex="0" FieldName="ShippedDate" Caption="Shipped Year"
				GroupInterval="DateYear" ID="fieldYear" />
			<dx:PivotGridField Area="ColumnArea" AreaIndex="1" FieldName="ShippedDate" Caption="Shipped Quarter"
				GroupInterval="DateQuarter" ID="fieldQuarter" ValueFormat-FormatString="Qtr {0}"
				ValueFormat-FormatType="Numeric" />
			<dx:PivotGridField Area="FilterArea" AreaIndex="2" Caption="Shipped Month" FieldName="ShippedDate"
				GroupInterval="DateMonth" ID="fieldMonth" />
			<dx:PivotGridField Area="DataArea" AreaIndex="0" FieldName="ProductSales" Caption="Product Sales"
				ID="Sales" />
			<dx:PivotGridField ID="AvgSale" Area="DataArea" AreaIndex="1" Caption="Average Sale"
				FieldName="ProductSales" SummaryType="Average" />
			<dx:PivotGridField ID="MinSale" Area="DataArea" AreaIndex="2" Caption="Min Sale"
				FieldName="ProductSales" SummaryType="Min" />
			<dx:PivotGridField Area="RowArea" AreaIndex="0" FieldName="CategoryName" Caption="Category Name"
				ID="fieldCategoryName" />
			<dx:PivotGridField Area="RowArea" AreaIndex="1" FieldName="ProductName" Caption="Product Name"
				ID="fieldProductName" />
		</Fields>
		<OptionsView HorizontalScrollBarMode="Auto" />
		<OptionsFilter NativeCheckBoxes="False" />
		<OptionsLayout ResetOptions="OptionsPager" />
		<ClientSideEvents EndCallback="function(s, e) { UpdateButtonStates(); }" />
	</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="ProductReportsDataSource" ContextTypeName="NorthwindContext" CommandText="SELECT s.CategoryName, s.ProductName, s.ProductSales, i.ShippedDate FROM Sales_By_Categories as s
		INNER JOIN Invoices as i ON s.ProductName = i.ProductName WHERE i.ShippedDate IS NOT NULL" />
</asp:Content>