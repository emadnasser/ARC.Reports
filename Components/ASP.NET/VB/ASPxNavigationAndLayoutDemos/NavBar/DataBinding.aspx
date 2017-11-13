<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.vb"
	Inherits="Menu_DataBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="float: left; width: 40%">
		<dx:ASPxNavBar Width="100%" DataSourceID="XmlDataSource1" EnableViewState="False"
			ID="ASPxNavBar1" runat="server" AutoCollapse="True" EncodeHtml="False" AllowSelectItem="True">
			<GroupHeaderStyle HorizontalAlign="Left" />
			<ItemStyle HorizontalAlign="Left" />
			<ItemTextTemplate>
				<span style="vertical-align: top; display: inline-block; margin: 4px 0 0 4px">
					<dx:ASPxLabel ID="lblModel" runat="server" Font-Bold="True" Text='<%#Container.EvalDataItem("Model")%>' />
					<br />
					<dx:ASPxLabel ID="lblPixels" runat="server" Text='<%#Container.EvalDataItem("Pixels")%>' />
					<dx:ASPxLabel ID="Label3" runat="server" Text="million pixels" />
				</span>
			</ItemTextTemplate>
		</dx:ASPxNavBar>
	</div>
	<div style="float: right; width: 58%">
		<table class="OptionsTable">
			<tr>
				<td >
					<dx:ASPxLabel ID="lblFilter" runat="server" Text="Filter:" />
				</td>
				<td>
					<dx:ASPxComboBox SelectedIndex="0" Width="150px" ID="ddlXPath" runat="server" AutoPostBack="True">
						<Items>
							<dx:ListEditItem Value="/Cameras/*" Text="All" />
							<dx:ListEditItem Value="/Cameras/*[@Text='Canon']" Text="Canon" />
							<dx:ListEditItem Value="/Cameras/*[@Text='Nikon']" Text="Nikon" />
							<dx:ListEditItem Value="/Cameras/*[@Text='Olympus']" Text="Olympus" />
							<dx:ListEditItem Value="/Cameras/*[@Text='Sony']" Text="Sony" />
							<dx:ListEditItem Value="/Cameras/*[@Text='Pentax']" Text="Pentax" />
						</Items>
					</dx:ASPxComboBox>
				</td>
			</tr>
			<tr>
				<td >
					XPath:
				</td>
				<td>
					<dx:ASPxLabel ID="lblXPath" CssClass="DemoInfoLabel" runat="server" Text="" />
				</td>
			</tr>
		</table>
	</div>
	<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/NavBar/Cameras.xml"
		XPath="/Cameras/*" />
</asp:Content>