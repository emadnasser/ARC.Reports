<%@ Page Language="vb" MasterPageFile="~/Site.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.name {
			font-weight: bold;
			padding-top: 5px;
			padding-left: 10px;
		}
		.photo {
			width: 84px;
			height: 84px;
			vertical-align: middle;
		}
		.frame {
			border: 1px solid lightgray;
			padding: 4px;
		}
		.description {
			color: gray;
			padding-top: 1px;
			padding-left: 10px;
		}
		.contactInfo {
			padding-bottom: 11px;
		}
		.selectedItem .description,
		.hoveredItem .description {
			color: inherit;  /* The description section's text color is taken from the applied theme's selected and hovered styles. */
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" runat="Server" ContentPlaceHolderID="ContentHolder">
	<dx:ASPxComboBox ID="ComboBox" ClientInstanceName="ClientComboBox" EnableCallbackMode="true" SelectedIndex="0" DropDownRows="4" CallbackPageSize="5"
		ForceDataBinding="true" DataSourceID="ContactsDataSource" TextField="Name" Width="260" runat="server">
		<ItemTemplate>
			<table>
				<tr>
					<td rowspan="2">
						<div class="frame">
							<img class="photo" alt="photo" src="<%#Page.ResolveUrl(Eval("PhotoUrl").ToString())%>" />
						</div>
					</td>
					<td class="name"><%#Eval("Name")%></td>
				</tr>
				<tr>
					<td class="description">
						<div class="contactInfo">
							<%#Eval("Address")%><br />
							<%#Eval("Phone")%>
						</div>
						<%#Eval("Email")%>
					</td>
				</tr>
			</table>
		</ItemTemplate>
		<ItemStyle>
			<SelectedStyle CssClass="selectedItem" />
			<HoverStyle CssClass="hoveredItem" />
		</ItemStyle>
	</dx:ASPxComboBox>
	<!-- The selected and hovered styles are set in CSS classes defining the text color for the description section -->
	<br />
	<b>Note: </b>Open the combo box's dropdown window to see how the layout and appearance of items are customized.
	<asp:XmlDataSource ID="ContactsDataSource" runat="server" DataFile="~/App_Data/Contacts.xml" XPath="//Contact" />
</asp:Content>