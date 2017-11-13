<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SearchPanel.aspx.vb" Inherits="Filtering_SearchPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<dx:ASPxCardView ID="CardView" runat="server" DataSourceID="CustomersDataSource" Width="100%">
		<Columns>
			<dx:CardViewColumn FieldName="ContactName" />
			<dx:CardViewColumn FieldName="CompanyName" />
			<dx:CardViewColumn FieldName="Address" />
			<dx:CardViewColumn FieldName="City" />
			<dx:CardViewColumn FieldName="PostalCode" />
			<dx:CardViewColumn FieldName="Country" />
			<dx:CardViewColumn FieldName="Phone" />
		</Columns>
		<SettingsSearchPanel Visible="true" />
	</dx:ASPxCardView>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>