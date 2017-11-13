<%@ Control Language="vb" AutoEventWireup="true" CodeFile="ViewerSelector.ascx.vb" Inherits="UserControls_ViewerSelectorControl" %>
<a href="javascript:void(0)" class="ThemeButton" title="Current Viewer: <%=CurrentViewer%>" id="ViewerSelectorPopupButton" style="margin-right: 34px">
	<dx:ASPxImage runat="server" ID="tViewerSelectorPic" SpriteCssClass="Icon ViewerSelectorIcon"></dx:ASPxImage>
	VIEWER
	<dx:ASPxImage runat="server" ID="tViewerSelectorGlyph" SpriteCssClass="Glyph"></dx:ASPxImage>
</a>
<script type="text/javascript" src="<%=Page.ResolveClientUrl("~/Scripts/Viewer.js")%>"></script>
<dx:ASPxPopupControl ID="ViewerSelectorPopup" CssClass="ThemeSelectorPopup ViewerSelectorPopup" runat="server"
	EnableTheming="False" ShowHeader="False" ShowShadow="False" PopupAnimationType="None"
	PopupElementID="ViewerSelectorPopupButton" PopupHorizontalAlign="RightSides" PopupVerticalAlign="TopSides"
	PopupHorizontalOffset="24" PopupVerticalOffset="-19" PopupAlignCorrection="Disabled">
	<ClientSideEvents Init="DXSelectorPopupContainer_Init" />
	<contentcollection>
		<dx:PopupControlContentControl runat="server">
			<div class="ButtonWrapper">
				<div class="ThemeButtonBorder">
				</div>
			</div>
			<div class="ButtonWrapperBtmBorder"></div>
			<b class="Clear"></b>
			<div class="ContainerWrapper ViewerSelectorContainerWrapper">
				<div class="ThemeContainer ViewerSelectorContainer">
					<dx:ASPxMenu ID="ViewerSelectorMenu" CssClass="ThemeGroupMenu" runat="server" EnableTheming="false"
						EnableViewState="false" Orientation="Vertical" ItemImagePosition="Left" ItemSpacing="0px">
						<ItemTextTemplate>
							<div class="ThemeIco <%#ViewerSelectorState.GetByName(CStr(Eval("Name"))).CssClass%>"></div>
							<%#ViewerSelectorState.GetByName(CStr(Eval("Name"))).Text%>
						</ItemTextTemplate>
					</dx:ASPxMenu>
					<b class="Clear"></b>
				</div>
			</div>
		</dx:PopupControlContentControl>
	</contentcollection>
</dx:ASPxPopupControl>
<%
   If (Not IsASPViewer) Then
%>
<script>
	(function() {
		var themeButton = document.getElementById("ThemeButton");
		if(themeButton) {
			themeButton.parentElement.removeChild(themeButton);
			document.getElementById('ViewerSelectorPopupButton').style.marginRight = '0';
		}
	})();
</script>
<%
   End If
%>