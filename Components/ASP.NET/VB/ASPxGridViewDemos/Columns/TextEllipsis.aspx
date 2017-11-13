<%@ Page Language="vb"  MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<style>
		.dxgv {
			transition: background 1s ;
		}
		.dxgv[title]{
			background-color: #FFF2C0;
		}
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource"
		KeyFieldName="CustomerID" Width="550">
		<Columns>
			<dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="1" Width="100" />
			<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="2" Width="200" />
			<dx:GridViewDataColumn FieldName="City" VisibleIndex="3" Width="100" />
			<dx:GridViewDataColumn FieldName="Region" VisibleIndex="4" Width="50" />
			<dx:GridViewDataColumn FieldName="Country" VisibleIndex="5" />
		</Columns>
		<SettingsBehavior AllowEllipsisInText="True"/>
		<SettingsResizing ColumnResizeMode="NextColumn" />
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>