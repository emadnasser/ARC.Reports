<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SearchPanel.aspx.vb" Inherits="Filtering_SearchPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<dx:ASPxGridView ID="Grid" runat="server" DataSourceID="CustomersDataSource" Width="100%">
		<Columns>
			<dx:GridViewDataTextColumn FieldName="ContactName" />
			<dx:GridViewDataTextColumn FieldName="CompanyName" />
			<dx:GridViewDataTextColumn FieldName="Address" />
			<dx:GridViewDataTextColumn FieldName="City" />
			<dx:GridViewDataTextColumn FieldName="PostalCode" />
			<dx:GridViewDataTextColumn FieldName="Country" />
			<dx:GridViewDataTextColumn FieldName="Phone" />
		</Columns>
		<SettingsSearchPanel Visible="true" />
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers"/>
</asp:Content>