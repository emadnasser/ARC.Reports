<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EndlessPaging.aspx.vb"
	Inherits="PagingAndScrolling_EndlessPaging" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="GridView" runat="server" DataSourceID="OrdersDataSource" Width="100%"
		KeyFieldName="OrderID">
		<Columns>
			<dx:GridViewDataTextColumn FieldName="ShipName" Width="200" />
			<dx:GridViewDataTextColumn FieldName="ShipCity" />
			<dx:GridViewDataTextColumn FieldName="ShipPostalCode" />
			<dx:GridViewDataTextColumn FieldName="ShipCountry" />
			<dx:GridViewDataTextColumn FieldName="Freight" />
			<dx:GridViewDataDateColumn FieldName="OrderDate" />
			<dx:GridViewDataDateColumn FieldName="ShippedDate" />
		</Columns>
		<Settings ShowGroupPanel="true" VerticalScrollBarMode="Visible"  VerticalScrollableHeight="400" />
		<SettingsPager Mode="EndlessPaging" PageSize="20" />
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="OrdersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Orders" />
</asp:Content>