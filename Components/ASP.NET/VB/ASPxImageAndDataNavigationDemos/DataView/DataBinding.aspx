<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.vb" Inherits="DataViewControl_Example" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxDataView ID="ASPxDataView1" runat="server" DataSourceID="XmlDataSource1" SettingsTableLayout-RowsPerPage="2" Width="850px" PagerAlign="Justify" ItemSpacing="25px">
		<ItemTemplate>
			<table style="margin: 0 auto;">
				<tr>
					<td colspan="2">
						<dx:ASPxImage ID="imgCover" runat="server" ImageUrl='<%#Eval("PhotoUrl")%>' Width="200px" Height="200px" ShowLoadingImage="true" />                    
					</td>
				</tr>
				 <tr>
					<td><b>Name:</b></td>
					<td><dx:ASPxLabel ID="lblName" runat="server" Text='<%#Eval("Name")%>' /></td>
				</tr>
				 <tr>
					<td><b>Address:</b></td>
					<td><dx:ASPxLabel ID="lblAddress" runat="server" Text='<%#Eval("Address")%>' /></td>
				</tr>
				 <tr>
					<td><b>Phone:</b></td>
					<td><dx:ASPxLabel ID="lblPrice" runat="server" Text='<%#Eval("Phone")%>' /></td>
				</tr>
			</table>
		</ItemTemplate>
		<PagerSettings ShowNumericButtons="true">
			<AllButton Visible="False" />
			<Summary Visible="false" />
			<PageSizeItemSettings Visible="true" ShowAllItem="true" />
		</PagerSettings>
	</dx:ASPxDataView>
	 <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Contacts.xml" XPath="//Contact" />
</asp:Content>