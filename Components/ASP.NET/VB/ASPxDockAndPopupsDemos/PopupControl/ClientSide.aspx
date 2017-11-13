<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSide.aspx.vb"
	Inherits="PopupControl_ClientSide" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxPopupControl SkinID="None" EncodeHtml="False" ID="ASPxPopupControl1" runat="server"
		EnableViewState="False" EnableHotTrack="False" Width="200px" PopupHorizontalAlign="RightSides"
		PopupVerticalAlign="Above" PopupHorizontalOffset="1" PopupVerticalOffset="-4"
		EnableHierarchyRecreation="True">
		<ClientSideEvents CloseUp="function(s, e) { DXEventMonitor.Trace(s, e, 'CloseUp') }"
			PopUp="function(s, e) { DXEventMonitor.Trace(s, e, 'PopUp') }" Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init') }" />
		<Windows>
			<dx:PopupWindow PopupElementID="imgASPxDocking" HeaderText="ASPxDocking suite" Name="docking" Text="The &lt;b&gt;ASPxDocking suite&lt;/b&gt; uses three components to manage dock panels, so that end-users can move these panels in an application and customize their view.">
			</dx:PopupWindow>
			<dx:PopupWindow PopupElementID="imgASPxLoadingPanel" HeaderText="ASPxLoadingPanel" Name="loadingpanel" Text="The &lt;b&gt;ASPxLoadingPanel&lt;/b&gt; notifies users that a callback is currently processing, and displays a &quot;loading&quot; text and image.">
			</dx:PopupWindow>
			<dx:PopupWindow PopupElementID="imgASPxPopupControl" HeaderText="ASPxPopupControl" Name="popupControl"
				Text="The &lt;b&gt;ASPxPopupControl&lt;/b&gt; allows you to enhance the presentation of extra data in web pages using popup windows.">
			</dx:PopupWindow>
		</Windows>
		<FooterStyle BackColor="#FFFBBA">
			<Border BorderWidth="0px" />
		</FooterStyle>
		<Border BorderColor="#BAAE6D" BorderStyle="Solid" BorderWidth="1px" />
		<CloseButtonImage Height="15px" Url="~/PopupControl/Images/Hint/pcClose.gif" Width="15px" />
		<HeaderStyle BackColor="#FCFADD" Font-Bold="True" ForeColor="#9E8A4F" Font-Size="9pt">
			<Border BorderWidth="0px" />
			<BorderBottom BorderWidth="1px" BorderColor="#DCD9B0" BorderStyle="Solid" />
			<Paddings PaddingBottom="6px" PaddingLeft="13px" PaddingRight="8px" PaddingTop="6px" />
		</HeaderStyle>
		<ContentStyle BackColor="#FFFBBA" ForeColor="#9E8A4F">
			<Border BorderWidth="0px" />
			<Paddings PaddingBottom="10px" PaddingLeft="13px" PaddingRight="13px" PaddingTop="9px" />
		</ContentStyle>
		<CloseButtonStyle>
			<Paddings Padding="0px" PaddingLeft="3px" />
		</CloseButtonStyle>
	</dx:ASPxPopupControl>
	<p class="WhiteControlArea">
		<b>Dock and Modal Popups</b> is a collection of controls allowing you to create interactive, touch-enabled web applications such as web dashboards. The collection contains the
			<span style="white-space: nowrap"><b>ASPxDocking suite</b><img src="Images/Help.gif" alt="" id="imgASPxDocking" />,</span>
			<span style="white-space: nowrap"><b>ASPxLoadingPanel</b><img src="Images/Help.gif" alt="" id="imgASPxLoadingPanel" /> and</span>
			<span style="white-space: nowrap"><b>ASPxPopupControl</b><img src="Images/Help.gif" alt="" id="imgASPxPopupControl" />.</span>
	</p>
	<dx:EventMonitor runat="server" ID="EventMonitor" EventNames="Init PopUp CloseUp" EventLogWidth="580" />
</asp:Content>