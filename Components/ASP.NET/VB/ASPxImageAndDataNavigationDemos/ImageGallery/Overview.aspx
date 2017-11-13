<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<dx:ASPxImageGallery ID="ASPxImageGallery" runat="server" ThumbnailHeight="178px" ThumbnailWidth="178px" >
		<Paddings Padding="0" />

		<SettingsFolder ImageSourceFolder="~/Content/Images/photo_gallery/" ImageCacheFolder="~/Thumb/ImageGalleryThumb/" />
		<SettingsTableLayout ColumnCount="3" RowsPerPage="1" />
	</dx:ASPxImageGallery>
</asp:Content>