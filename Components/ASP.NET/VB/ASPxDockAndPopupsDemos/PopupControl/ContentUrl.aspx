<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ContentUrl.aspx.vb"
	Inherits="PopupControl_ContentUrl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table style="width: 100%; height:300px" id="popupArea">
		<tr>
			<td style="text-align: center; cursor: pointer">
				<dx:ASPxImage ID="Image1" runat="server" BackColor="Transparent" Height="32px" ImageUrl="~/PopupControl/Images/mail32x32.gif"
					Width="32px" style="margin: -10px 8px" />Click here to send us a message...
			</td>
		</tr>
	</table>
	<dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" AllowDragging="True" AllowResize="True"
		CloseAction="CloseButton" ContentUrl="~/PopupControl/ContentUrlFeedForm.aspx"
		EnableViewState="False" PopupElementID="popupArea" PopupHorizontalAlign="Center"
		PopupVerticalAlign="Middle" ShowFooter="True" ShowOnPageLoad="True" Width="400px"
		Height="300px" FooterText="Try to resize the control using the resize grip or the control's edges"
		HeaderText="Feedback form" ClientInstanceName="FeedPopupControl" EnableHierarchyRecreation="True">
	</dx:ASPxPopupControl>
</asp:Content>