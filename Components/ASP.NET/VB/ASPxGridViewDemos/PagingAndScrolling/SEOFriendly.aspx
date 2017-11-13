<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SEOFriendly.aspx.vb"
	Inherits="PagingAndScrolling_SEOFriendly" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource"
		KeyFieldName="CustomerID" Width="100%">
		<Columns>
			<dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="0" SortOrder="Ascending">
			</dx:GridViewDataColumn>
			<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="1">
			</dx:GridViewDataColumn>
			<dx:GridViewDataColumn FieldName="City" VisibleIndex="2">
			</dx:GridViewDataColumn>
			<dx:GridViewDataColumn FieldName="Region" VisibleIndex="3">
			</dx:GridViewDataColumn>
			<dx:GridViewDataColumn FieldName="Country" VisibleIndex="4">
			</dx:GridViewDataColumn>
		</Columns>
		<Settings ShowGroupPanel="True" />
		<SettingsPager PageSize="10" SEOFriendly="Enabled">
			<PageSizeItemSettings Visible="true" />
		</SettingsPager>
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>