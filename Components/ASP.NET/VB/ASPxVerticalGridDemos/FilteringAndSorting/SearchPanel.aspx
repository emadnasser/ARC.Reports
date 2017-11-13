<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SearchPanel.aspx.vb" Inherits="Filtering_SearchPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<dx:ASPxVerticalGrid ID="VerticalGrid" runat="server" DataSourceID="CustomersDataSource" Width="100%">
		<Rows>
			<dx:VerticalGridDataRow FieldName="ContactName" />
			<dx:VerticalGridDataRow FieldName="CompanyName" />

			<dx:VerticalGridDataRow FieldName="Phone" />
			<dx:VerticalGridDataRow FieldName="AddressInfo" UnboundType="String" UnboundExpression="[Address] + ', ' + [City]">
				<Rows>
					<dx:VerticalGridDataRow FieldName="Country" />
					<dx:VerticalGridDataRow FieldName="City" />
					<dx:VerticalGridDataRow FieldName="Address" />
					<dx:VerticalGridDataRow FieldName="PostalCode" />
				</Rows>
			</dx:VerticalGridDataRow>
		</Rows>
		<SettingsSearchPanel Visible="true" />
		<Settings HorizontalScrollBarMode="Visible" RecordWidth="200" />
	</dx:ASPxVerticalGrid>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>