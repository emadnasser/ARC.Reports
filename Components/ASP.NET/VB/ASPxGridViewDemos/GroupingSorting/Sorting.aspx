<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Sorting.aspx.vb"
	Inherits="GroupingSorting_Sorting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource"
		KeyFieldName="CustomerID" Width="100%">
		<Columns>
			<dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="1" SortOrder="Ascending" />
			<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="2" />
			<dx:GridViewDataColumn FieldName="City" VisibleIndex="3" />
			<dx:GridViewDataColumn FieldName="Region" VisibleIndex="4" />
			<dx:GridViewDataColumn FieldName="Country" VisibleIndex="5" />
		</Columns>
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers"/>
</asp:Content>