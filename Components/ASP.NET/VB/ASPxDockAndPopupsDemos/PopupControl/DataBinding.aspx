<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.vb"
	Inherits="PopupControl_DataBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<%--start highlighted block--%>
	<script type="text/javascript">
	var windowOverName = '';
	function ShowSelectionPicture() {
		var menu = GetMenu();
		var item = menu.GetSelectedItem();
		if(item != null)
			ShowWindowByName(item.name);
	}
	function HidePictureWithDelay(name) {
		if (name == windowOverName)
			HidePictures();
	}
	function ShowPicture(e) {
		windowOverName = e.item.name;
		ASPxClientPopupControl.GetPopupControlCollection().HideAllWindows();
		ShowWindowByName(e.item.name);
	}
	function ShowWindowByName(name) {
		var popupControl = GetPopupControl();
		var window = popupControl.GetWindowByName(name);
		popupControl.ShowWindowAtElementByID(window, "tdMenu");
	}
	function HidePictures() {
		ASPxClientPopupControl.GetPopupControlCollection().HideAllWindows();
		var menu = GetMenu();
		var item = menu.GetSelectedItem();
		if (item != null)
			ShowWindowByName(item.name);
	}
	function GetMenu() {
		return ASPxMenuClientControl;
	}
	function GetPopupControl() {
		return ASPxPopupClientControl;
	} 
	</script>
	<%--end highlighted block--%>
	<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Charts.xml"
		XPath="//Chart" />
	<dx:ASPxPopupControl ClientInstanceName="ASPxPopupClientControl" SkinID="None" ShowHeader="False"
		ShowFooter="True" PopupAction="None" CloseAction="None" PopupHorizontalAlign="OutsideRight"
		PopupVerticalAlign="TopSides" EnableViewState="False" DataSourceID="XmlDataSource1"
		ID="ASPxPopupControl1" runat="server" PopupHorizontalOffset="34" PopupVerticalOffset="2"
		EnableHierarchyRecreation="True">
		<Border BorderColor="#7EACB1" BorderStyle="Solid" BorderWidth="1px" />
		<WindowContentTemplate>
			<dx:ASPxImage ID="imgChart" Width="380px" Height="240px" runat="server" ImageUrl='<%#Container.EvalDataItem("BigImageUrl")%>' />
		</WindowContentTemplate>
		<WindowFooterTemplate>
			<dx:ASPxLabel ID="Label1" runat="server" Text="View:" EnableViewState="False" />
			<dx:ASPxLabel ID="lblView" runat="server" Text='<%#Container.EvalDataItem("View")%>' />
		</WindowFooterTemplate>
		<FooterStyle ForeColor="#6896A0" BackColor="#D4E8F3">
			<Border BorderWidth="0px" />
			<BackgroundImage ImageUrl="Images/PopupFooterBackground.gif" Repeat="RepeatX" />
			<Paddings Padding="6px" />
		</FooterStyle>
		<ContentStyle>
			<Paddings Padding="0px" />
		</ContentStyle>
		<HeaderStyle>
			<Paddings PaddingLeft="10px" PaddingRight="6px" PaddingTop="1px" />
		</HeaderStyle>
	</dx:ASPxPopupControl>
	<table style="width:500px">
		<tr>
			<td id="tdMenu">
				<dx:ASPxMenu ClientInstanceName="ASPxMenuClientControl" SkinID="None" EnableViewState="False"
					DataSourceID="XmlDataSource1" ID="ASPxMenu1" runat="server" BackColor="Transparent"
					ItemImagePosition="Top" ItemSpacing="4px" Orientation="Vertical" AllowSelectItem="True" Width="85px">
					<ClientSideEvents ItemMouseOver="function(s, e) { ShowPicture(e); }" ItemMouseOut="function(s, e) { setTimeout('HidePictureWithDelay(\'' + e.item.name + '\')', 300); }"
						Init="function(s, e) { ShowSelectionPicture(); }" />
					<ItemStyle BackColor="#EDF3F4" Font-Size="10px" ForeColor="#6896A0">
						<Paddings PaddingBottom="5px" PaddingLeft="7px" PaddingRight="8px" PaddingTop="4px" />
						<HoverStyle BackColor="#D9ECED">
							<Border BorderColor="#7EACB1" BorderStyle="Solid" BorderWidth="1px" />
						</HoverStyle>
						<SelectedStyle BackColor="#9FCED6" ForeColor="#588187">
							<Border BorderColor="#7EACB1" BorderStyle="Solid" BorderWidth="1px" />
						</SelectedStyle>
						<Border BorderColor="#7EACB1" BorderStyle="Solid" BorderWidth="1px" />
					</ItemStyle>
					<Border BorderWidth="0px" />
					<ItemImage Height="24px" Width="23px" />
				</dx:ASPxMenu>
			</td>
			<td style="text-align: center" >
				To invoke a popup window move the mouse cursor<br />
				over the menu's items on the left</td>
		</tr>
	</table>
	<p class="Note">
		<b>Note</b>: The sample pictures which are used in this demo were created with our
		<a href="http://www.devexpress.com/Products/NET/WinForms/XtraCharts/" target="_blank">
			XtraCharts</a> suite.</p>
</asp:Content>