<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<dx:ASPxPivotGrid ID="pivotGrid" runat="server" DataSourceID="SalesPersonsDataSource"
		Width="100%">
		<Fields> 
			<dx:PivotGridField Area="RowArea"  FieldName="CategoryName" Caption="Category Name" />
			<dx:PivotGridField Area="ColumnArea"  FieldName="Country" Caption="Country" />
			<dx:PivotGridField Area="DataArea" FieldName="Extended_Price" Caption="Extended Price" />
			<dx:PivotGridField Area="FilterArea"  FieldName="ProductName" Caption="Product Name" />
		</Fields>
	</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" />
	</asp:Content>