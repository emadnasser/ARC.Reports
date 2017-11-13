<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="VideoGallery.aspx.vb" Inherits="ImageSlider_VideoGallery" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
	<link href="css/VideoGallery.css" rel="Stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<%--start highlighted block--%>
	<script type="text/javascript">
		var videoItemHtml = null;
		function OnPlayButtonClick(itemIndex, videoId) {
			var videoItemElement = document.getElementById("videoItem" + itemIndex);
			videoItemHtml = videoItemElement.innerHTML;
			videoItemElement.innerHTML = '<iframe id="player" type="text/html" width="606" height="371" ' +
			'src="https://www.youtube.com/embed/' + videoId + '?showinfo=0&amp;enablejsapi=1&amp;wmode=transparent&amp;autoplay=1" frameborder="0"></iframe>';
			videoItemElement.appendChild(CreateCloseButton());
		}
		function StopVideo() {
			var player = document.getElementById("player");
			if (player) {
				player.src = "";
				player.parentNode.innerHTML = videoItemHtml;
			}
		}
		function CreateCloseButton() {
			var closeButton = document.createElement("DIV");
			closeButton.className = "closeButton";
			ASPxClientUtils.AttachEventToElement(closeButton, "click", function () {
				StopVideo();
			});
			return closeButton;
		}
	</script>
	<%--end highlighted block--%>
	<dx:ASPxImageSlider ID="ImageSlider" ClientInstanceName="ImageSlider" runat="server" DataSourceID="videoItems"
		EnableViewState="False" EnableTheming="False">
		<Styles>
			<ImageArea Width="640" Height="455" />
		</Styles>
		<ItemTemplate>
			<div>
				<div id="videoItem<%#Container.ItemIndex%>" class="video">
					<div class="blackPanel"></div>
					<dx:ASPxImage ID="ASPxImage1" runat="server" ImageUrl='<%#Container.EvalDataItem("ImageUrl")%>' AlternateText='<%#Container.EvalDataItem("Text")%>'></dx:ASPxImage>
					<a class="playButton" href="javascript:OnPlayButtonClick('<%#Container.ItemIndex%>', '<%#Container.EvalDataItem("Name")%>')"></a>
				</div>
				<div class="text">
					<%#Container.EvalDataItem("Product")%> - <%#Container.EvalDataItem("Text")%>
				</div>
			</div>
		</ItemTemplate>
		<ItemThumbnailTemplate>
			<div class="product"><%#Container.EvalDataItem("Product")%></div>
			<div class="productText"><%#Container.EvalDataItem("Text")%></div>
			<div class="videoLenght">
				<%#Container.EvalDataItem("Time")%>
			</div>
		</ItemThumbnailTemplate>
		<SettingsImageArea ItemTextVisibility="None" NavigationButtonVisibility="None" />
		<SettingsNavigationBar Position="Right" ThumbnailsModeNavigationButtonVisibility="None" ItemSpacing="0" />
		<ClientSideEvents ActiveItemChanged="StopVideo" />
	</dx:ASPxImageSlider>
	<asp:XmlDataSource ID="videoItems" runat="server" DataFile="~/App_Data/ImageSlider/video_gallery.xml"
		XPath="//items/*"></asp:XmlDataSource>
</asp:Content>