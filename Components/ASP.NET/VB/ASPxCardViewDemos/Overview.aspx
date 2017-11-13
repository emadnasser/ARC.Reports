<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Overview.aspx.vb" Inherits="Overview"%>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<dx:ASPxCardView ID="CardView" runat="server" DataSourceID="OrdersDataSource" Width="600">
		<Columns>
			<dx:CardViewColumn FieldName="ShipName" />
			<dx:CardViewColumn FieldName="ShipCountry" />
			<dx:CardViewColumn FieldName="ShipCity" />
			<dx:CardViewColumn FieldName="ShipPostalCode" />
		</Columns>
		<SettingsPager NumericButtonCount="6">
			<SettingsTableLayout ColumnCount="2" RowsPerPage="2" />
		</SettingsPager>
	</dx:ASPxCardView>

	<ef:EntityDataSource runat="server" ID="OrdersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Orders" />
</asp:Content>