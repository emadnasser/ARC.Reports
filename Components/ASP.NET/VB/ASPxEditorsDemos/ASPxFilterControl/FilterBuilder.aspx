<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FilterBuilder.aspx.vb"
	Inherits="ASPxFilterControl_FilterBuilder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxCheckBox runat="server" ID="cbEnableTextTab" Text="Enable text tab" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
	<dx:ASPxCheckBox runat="server" ID="cbAllowHierarchicalColumns" Text="Allow hierarchical columns" AutoPostBack="true" Checked="true" 
		OnCheckedChanged="cbAllowHierarchycalColumns_CheckedChanged" />
	<br />
	<dx:ASPxRoundPanel ID="fp" runat="server" HeaderText="Filter">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">
				<dx:ASPxFilterControl ID="filter" runat="server" Width="350" ClientInstanceName="filter" ViewMode="VisualAndText">
					<ClientSideEvents Applied="function(s, e) { grid.ApplyFilter(e.filterExpression);}" />
				</dx:ASPxFilterControl>
				<div style="text-align: right">
					<dx:ASPxButton runat="server" ID="btnApply" Text="Apply" AutoPostBack="false" UseSubmitBehavior="false" Width="80px" style="margin: 12px 1em auto auto;">
						<ClientSideEvents Click="function() { filter.Apply(); }" />
					</dx:ASPxButton>
				</div>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<div class="TopPadding">
	<br />
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="ProductsDataSource" Width="100%">
		<Columns>
			<dx:GridViewDataTextColumn FieldName="ProductName" VisibleIndex="0" />
			<dx:GridViewDataComboBoxColumn FieldName="Category.CategoryName" VisibleIndex="1">
				<PropertiesComboBox DataSourceID="CategoriesDataSource" TextField="CategoryName" ValueField="CategoryName" ValueType="System.String" />
			</dx:GridViewDataComboBoxColumn>
			<dx:GridViewDataTextColumn FieldName="Supplier.CompanyName" VisibleIndex="2" />
			<dx:GridViewDataTextColumn FieldName="Supplier.ContactName" VisibleIndex="3" />
			<dx:GridViewDataSpinEditColumn FieldName="UnitPrice" VisibleIndex="4">
				<PropertiesSpinEdit DisplayFormatString="c" />
			</dx:GridViewDataSpinEditColumn>
			<dx:GridViewDataSpinEditColumn FieldName="UnitsInStock" VisibleIndex="5" />
			<dx:GridViewDataTextColumn FieldName="Total" VisibleIndex="6" UnboundType="Decimal" UnboundExpression="UnitPrice*UnitsInStock">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:GridViewDataTextColumn>
		</Columns>
	</dx:ASPxGridView>
	</div>
	<ef:EntityDataSource runat="server" ID="ProductsDataSource" Include="Category, Supplier" ContextTypeName="NorthwindContext" EntitySetName="Products"></ef:EntityDataSource>
	<ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" Select="DISTINCT it.CategoryName" OrderBy="it.CategoryName" />
</asp:Content>