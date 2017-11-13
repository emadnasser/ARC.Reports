<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.vb"
	Inherits="CloudControl_Features" %>
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
				<dx:ASPxComboBox ID="ddlRankCount" SelectedIndex="2" runat="server" AutoPostBack="true"
					Width="70px" Caption="RankCount">
					<Items>
						<dx:ListEditItem Text="3" Value="3" />
						<dx:ListEditItem Text="5" Value="5" />
						<dx:ListEditItem Text="7" Value="7" />
						<dx:ListEditItem Text="9" Value="9" />
					</Items>
				</dx:ASPxComboBox>
			</td>
			<td>
				<dx:ASPxComboBox ID="ddlScales" SelectedIndex="1" runat="server" AutoPostBack="True"
					Width="170px" Caption="Scale">
					<Items>
						<dx:ListEditItem Text="Linear" Value="Linear" />
						<dx:ListEditItem Text="Logarithmic" Value="Logarithmic" />
					</Items>
				</dx:ASPxComboBox>
			</td>
			<td class="LeftPadding">
				<dx:ASPxCheckBox ID="cbShowValues" runat="server" AutoPostBack="True" Text="ShowValues" />
			</td>
		</tr>
	</table>
	<dx:ASPxCloudControl ID="ASPxCloudControl1" DataSourceID="XmlDataSource1" runat="server"
		NavigateUrlFormatString="javascript:void({0})">
	</dx:ASPxCloudControl>
	<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/CloudControlWords.xml" />
</asp:Content>