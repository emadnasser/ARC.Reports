<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.vb"
	Inherits="CloudControl_DataBinding" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
	   .OptionsTable.CellPaddingRight > tbody > tr > td 
	   {
		   padding-right:16px;
	   }
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable CellPaddingRight">
		<tr>
			<td>
				<dx:ASPxComboBox ID="ddlFilter" SelectedIndex="0" runat="server" AutoPostBack="True"
					Width="200px" Caption="Filter">
					<Items>
						<dx:ListEditItem Value="" Text="All" />
						<dx:ListEditItem Value="c.Continent='North America'" Text="North America" />
						<dx:ListEditItem Value="c.Continent='South America'" Text="South America" />
					</Items>
				</dx:ASPxComboBox>
			</td>
			<td>
				<dx:ASPxComboBox ID="ddlValueField" SelectedIndex="0" runat="server" AutoPostBack="True"
					Width="200px" Caption="ValueField">
					<Items>
						<dx:ListEditItem Text="Area" Value="Area" />
						<dx:ListEditItem Text="Population" Value="Population" />
					</Items>
				</dx:ASPxComboBox>
			</td>
		</tr>
	</table>
	<dx:ASPxCloudControl ID="ASPxCloudControl1" runat="server" DataSourceID="CountriesDataSource"
		Width="100%" NavigateUrlField="Name" NavigateUrlFormatString="javascript:void('{0}')"
		TextField="Name" ValueField="Area" EnableViewState="False" OnItemDataBound="ASPxCloudControl1_ItemDataBound">
	</dx:ASPxCloudControl>
	<ef:EntityDataSource runat="server" ID="CountriesDataSource" ContextTypeName="DataContext" />
</asp:Content>