<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Grouping.aspx.vb"
	Inherits="GroupingSorting_Grouping" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable OptionsBottomMargin">
		<tr>
			<td style="padding-right: 16px">
				<dx:ASPxComboBox runat="server" ID="cbFields" ValueType="System.Int32" SelectedIndex="0" Caption="Group by">
					<Items>
						<dx:ListEditItem Text="Country" Value="0" />
						<dx:ListEditItem Text="Country, City" Value="1" />
						<dx:ListEditItem Text="Company Name" Value="2" />
					</Items>
					<ClientSideEvents SelectedIndexChanged="function(s) { grid.PerformCallback(s.GetValue()) }" />
				</dx:ASPxComboBox>
			</td>
			<td>
				<dx:ASPxButton runat="server" ID="btnCollapse" Text="Collapse All Rows" UseSubmitBehavior="false"
					AutoPostBack="false">
					<ClientSideEvents Click="function() { grid.CollapseAll() }" />
				</dx:ASPxButton>
			</td>
			<td>
				<dx:ASPxButton runat="server" ID="btnExpand" Text="Expand All Rows" UseSubmitBehavior="false"
					AutoPostBack="false">
					<ClientSideEvents Click="function() { grid.ExpandAll() }" />
				</dx:ASPxButton>
			</td>
		</tr>
	</table>
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource"
		KeyFieldName="CustomerID" OnCustomCallback="grid_CustomCallback" Width="100%">
		<Columns>
			<dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="1" />
			<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="2" />
			<dx:GridViewDataColumn FieldName="City" VisibleIndex="3" />
			<dx:GridViewDataColumn FieldName="Region" VisibleIndex="4" />
			<dx:GridViewDataColumn FieldName="Country" VisibleIndex="5" />
		</Columns>
		<Settings ShowGroupPanel="True" />
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers"/>
</asp:Content>