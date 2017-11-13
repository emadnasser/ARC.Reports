<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PagerPosition.aspx.vb"
	Inherits="PagingAndScrolling_PagerPosition" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">

	<table class="OptionsTable BottomMargin" style="float: left;">
		<tr>
			<td>
				<dx:ASPxLabel ID="lblPosition" runat="server" Text="Position:" AssociatedControlID="cbPagerPosition" Wrap="False" />
			</td>
			<td>
				<dx:ASPxComboBox SelectedIndex="2" ID="cbPagerPosition" runat="server" AutoPostBack="True"
					Width="120px">
					<Items>
						<dx:ListEditItem Value="Bottom" Text="Bottom" />
						<dx:ListEditItem Value="Top" Text="Top" />
						<dx:ListEditItem Value="TopAndBottom" Text="TopAndBottom" />
					</Items>
				</dx:ASPxComboBox>
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxLabel ID="lblPageSizeItemPosition" runat="server" Text="PageSizeItem position:" AssociatedControlID="cbPageSizeItemPosition" Wrap="False" />
			</td>
			<td>
				<dx:ASPxComboBox SelectedIndex="1" ID="cbPageSizeItemPosition" runat="server" AutoPostBack="True"
					Width="120px">
					<Items>
						<dx:ListEditItem Value="Left" Text="Left" />
						<dx:ListEditItem Value="Right" Text="Right" />
					</Items>
				</dx:ASPxComboBox>
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxLabel ID="lblShowPageSizeItem" runat="server" Text="Show PageSizeItem:"
					AssociatedControlID="cbShowPageSizeItem" Wrap="False" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="cbShowPageSizeItem" runat="server" Checked="True" AutoPostBack="True" />
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxLabel ID="lblShowSummary" runat="server" Text="Show Summary:" AssociatedControlID="cbShowSummary" Wrap="False" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="cbShowSummary" runat="server" AutoPostBack="True" Checked="True" />
			</td>
		</tr>
	</table>
	<table class="OptionsTable BottomMargin" style="float: left; margin-left: 16px;">
		<tr>
			<td>
				<dx:ASPxLabel ID="lblShowDisabledButtons" runat="server" Text="ShowDisabledButtons:"
					AssociatedControlID="cbShowDisabledButtons" Wrap="False" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="cbShowDisabledButtons" runat="server" Checked="True" AutoPostBack="True" />
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxLabel ID="lblShowNumericButtons" runat="server" Text="ShowNumericButtons:"
					AssociatedControlID="cbShowNumericButtons" Wrap="False" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="cbShowNumericButtons" runat="server" Checked="True" AutoPostBack="True" />
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxLabel ID="lblShowSeparators" runat="server" Text="ShowSeparators:" AssociatedControlID="cbShowSeparators" Wrap="False" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="cbShowSeparators" runat="server" AutoPostBack="True" />
			</td>
		</tr>
	</table>
	<b class="Clear"></b>
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource"
		KeyFieldName="CustomerID" Width="100%">
		<Columns>
			<dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="0" />
			<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="1" />
			<dx:GridViewDataColumn FieldName="City" VisibleIndex="2" />
			<dx:GridViewDataColumn FieldName="Region" VisibleIndex="3" />
			<dx:GridViewDataColumn FieldName="Country" VisibleIndex="4" />
		</Columns>
		<SettingsPager Position="TopAndBottom">
			<PageSizeItemSettings Items="10, 20, 50" />
		</SettingsPager>
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>