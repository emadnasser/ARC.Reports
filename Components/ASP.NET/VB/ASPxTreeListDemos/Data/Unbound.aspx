<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Unbound.aspx.vb"
	Inherits="Data_Unbound" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxTreeList ID="treeList" runat="server">
		<Columns>
			<dx:TreeListTextColumn FieldName="Name">
				<PropertiesTextEdit EncodeHtml="false" />
			</dx:TreeListTextColumn>
		</Columns>
		<Settings ShowColumnHeaders="False" />
		<Styles>
			<Cell>
				<Paddings PaddingLeft="1px" />
			</Cell>
		</Styles>
		<Templates>
			<DataCell>
				<table>
					<tr>
						<td>
							<dx:ASPxImage ID="ASPxImage1" runat="server" ImageUrl='<%#GetIconUrl(Container)%>'
								Width="16" Height="16" />
						</td>
						<td>
							&nbsp;
						</td>
						<td style="padding-bottom: 1px;">
							<%#Container.Text%>
						</td>
					</tr>
				</table>
			</DataCell>
		</Templates>
		<Border BorderWidth="0" />
		<SettingsBehavior ExpandCollapseAction="NodeDblClick" />
	</dx:ASPxTreeList>
</asp:Content>