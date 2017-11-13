<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="CustomCallback.aspx.vb"
	Inherits="DataView_EnableCallback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table style="float: right" class="OptionsTable BottomMargin">
		<tr>
			<td>
				Sort by:
			</td>
			<td>
				<dx:ASPxComboBox ID="cbSortField" runat="server" ClientInstanceName="cbSortField"
					SelectedIndex="0" Width="90px">
					<Items>
						<dx:ListEditItem Text="(none)" Value="" />
						<dx:ListEditItem Text="Model" Value="Model" />
						<dx:ListEditItem Text="Pixels" Value="Pixels" />
					</Items>
					<ClientSideEvents SelectedIndexChanged="function(s, e) { dvCameras.PerformCallback(); }" />
				</dx:ASPxComboBox>
			</td>
			<td>
				<dx:ASPxComboBox ID="cbSortOrder" runat="server" ClientInstanceName="cbSortOrder"
					SelectedIndex="0" Width="120px">
					<Items>
						<dx:ListEditItem Text="Ascending" Value="" />
						<dx:ListEditItem Text="Descending" Value="DESC" />
					</Items>
					<ClientSideEvents SelectedIndexChanged="function(s, e) { if(cbSortField.GetValue() != '') dvCameras.PerformCallback(); }" />
				</dx:ASPxComboBox>
			</td>
		</tr>
	</table>
	<dx:ASPxDataView ID="dvCameras" runat="server" Width="100%"
		ClientInstanceName="dvCameras" DataSourceID="CamerasDataSource" style="clear: both">
		<SettingsTableLayout ColumnCount="2" RowsPerPage="5" />
		<ItemStyle Height="50px">
			<Paddings PaddingTop="5px" PaddingBottom="5px"></Paddings>
		</ItemStyle>
		<ItemTemplate>
			<table>
				<tbody>
					<tr>
						<td>
							<dx:ASPxImage ID="ModelImage" runat="server" ImageUrl='<%#ImagePath + Eval("ImageFileName")%>'>
							</dx:ASPxImage>
						</td>
						<td>
							<div style="width: 5px" class="Spacer">
							</div>
						</td>
						<td>
							<dx:ASPxLabel ID="ModelLabel" runat="server" Text='<%#Eval("Model")%>' Font-Bold="True"
								CssClass='<%#SortColor("Model")%>'>
							</dx:ASPxLabel>
							<br />
							<dx:ASPxLabel ID="PixelsLabel" runat="server" Text='<%#Eval("Pixels") & " million pixels"%>'
								CssClass='<%#SortColor("Pixels")%>'>
							</dx:ASPxLabel>
						</td>
					</tr>
				</tbody>
			</table>
		</ItemTemplate>
	</dx:ASPxDataView>
	<ef:EntityDataSource ID="CamerasDataSource" runat="server" ContextTypeName="DataContext" EntitySetName="Cameras" />
</asp:Content>