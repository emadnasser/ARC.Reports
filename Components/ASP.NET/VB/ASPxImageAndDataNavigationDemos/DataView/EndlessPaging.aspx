<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EndlessPaging.aspx.vb"
	Inherits="DataView_EndlessPaging" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxComboBox ID="cmbEndlessPagingMode" OnSelectedIndexChanged="cmbEndlessPagingMode_SelectedIndexChanged"
		runat="server" AutoPostBack="true" Caption="Endless Paging mode">
	<RootStyle CssClass="OptionsBottomMargin"></RootStyle>
	</dx:ASPxComboBox>
	<dx:ASPxDataView ID="dataView" runat="server" DataSourceID="XmlDataSource1" Width="850px" ClientInstanceName="dataView">
		<SettingsTableLayout ColumnCount="3" RowsPerPage="2" />
		<ItemTemplate>
			<table style="margin: 0 auto;">
				<tr>
					<td colspan="2">
						<dx:ASPxImage ID="imgCover" runat="server" ImageUrl='<%#Eval("PhotoUrl")%>' Width="200"
							Height="200" ShowLoadingImage="true" />
					</td>
				</tr>
				<tr>
					<td>
						<b>Name:</b>
					</td>
					<td>
						<dx:ASPxLabel ID="lblName" runat="server" Text='<%#Eval("Name")%>' />
					</td>
				</tr>
				<tr>
					<td>
						<b>Address:</b>
					</td>
					<td>
						<dx:ASPxLabel ID="lblAddress" runat="server" Text='<%#Eval("Address")%>' />
					</td>
				</tr>
				<tr>
					<td>
						<b>Phone:</b>
					</td>
					<td>
						<dx:ASPxLabel ID="lblPrice" runat="server" Text='<%#Eval("Phone")%>' />
					</td>
				</tr>
			</table>
		</ItemTemplate>
	</dx:ASPxDataView>
	<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Contacts.xml"
		XPath="//Contact" />
</asp:Content>