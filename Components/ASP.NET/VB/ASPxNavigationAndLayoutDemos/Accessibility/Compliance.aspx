<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="Compliance.aspx.vb" Inherits="Common_Compliance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.layoutItemCell {
			width: 33%;
			vertical-align: top;
		}
		.menuLayoutItemCell {
			padding-bottom: 15px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="CustomTopAreaHolder">
	<dx:SkipRepetitiveNavigationLinksControl ID="SkipRepetitiveNavigationLinksControl1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" SettingsItemCaptions-Location="Top" ColCount="3" Width="100%">
		<Styles>
			<LayoutGroup>
				<Cell CssClass="layoutItemCell" />
			</LayoutGroup>
		</Styles>
		<Items>
			<dx:LayoutItem Caption="ASPxMenu" ColSpan="3">
				<ParentContainerStyle CssClass="menuLayoutItemCell" />
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer>
						<div class="dxAIFE" tabindex="0">main content</div>
						<dx:ASPxMenu ID="menu" runat="server" AccessibilityCompliant="true" 
							ShowPopOutImages="true" DataSourceID="XmlDataSource1"/>
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
			<dx:LayoutItem Caption="ASPxNavBar">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer>
						<dx:ASPxNavBar ID="navBar" runat="server" AccessibilityCompliant="true" DataSourceID="XmlDataSource2"/>
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
			<dx:LayoutItem Caption="ASPxTreeView">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer>
						<dx:ASPxTreeView ID="treeView" runat="server" AccessibilityCompliant="true" AllowCheckNodes="true"
							DataSourceID="XmlDataSource3"/>
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
			<dx:LayoutItem Caption="ASPxPopupMenu">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer>
						<dx:ASPxButton ID="ASPxButton1" runat="server" Text="Click to open popup menu" AccessibilityCompliant="true" AutoPostBack="false">
							<ClientSideEvents Click="function(s, e) { 
								popupMenu.Show();
							}" />
						</dx:ASPxButton>
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
		</Items>
	</dx:ASPxFormLayout>
	<dx:ASPxPopupMenu ID="popupMenu" runat="server" ClientInstanceName="popupMenu" AccessibilityCompliant="true"
		ShowPopOutImages="True" PopupElementID="ASPxFormLayout1$ASPxButton1" PopupAction="LeftMouseClick"
		PopupHorizontalAlign="OutsideRight" PopupVerticalAlign="TopSides" DataSourceID="XmlDataSource1" />
	<dx:AccessibilityValidatorLink ID="ValidatorLink" runat="server" />
	<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Menu/SimpleMenu.xml"
		XPath="/mainmenu/item" />
	<asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="~/App_Data/NavBar/SimpleNavBar.xml"
		XPath="/groups/group" />
	<asp:XmlDataSource ID="XmlDataSource3" runat="server" DataFile="~/App_Data/TreeView/SimpleTreeView.xml"
		XPath="/nodes/node" />
</asp:Content>