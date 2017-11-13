<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" Width="100%"
		DataSourceID="SalesPersonsDataSource">
		<Columns>
			<dx:GridViewDataTextColumn FieldName="FirstName" Width="100" VisibleIndex="0" />
			<dx:GridViewDataTextColumn FieldName="LastName" Width="100" VisibleIndex="1" />
			<dx:GridViewDataTextColumn FieldName="ProductName" Width="200" VisibleIndex="2" />
			<dx:GridViewDataDateColumn FieldName="OrderDate" Width="100" VisibleIndex="3" />
			<dx:GridViewDataTextColumn FieldName="Quantity" Width="80" VisibleIndex="4" />
		</Columns>
		<Settings VerticalScrollBarMode="Visible" VerticalScrollBarStyle="VirtualSmooth" />
		<SettingsPager>
			<PageSizeItemSettings Visible="true" />
		</SettingsPager>
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" OrderBy="it.OrderDate"/>
</asp:Content>