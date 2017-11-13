<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="InsertMediaContent.aspx.vb"
	Inherits="Features_MediaSelector" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="float: left; padding-right: 20px;">
		<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Width="645px" Height="360px">
			<SettingsHtmlEditing AllowHTML5MediaElements="true" AllowObjectAndEmbedElements="true" AllowYouTubeVideoIFrames="true" />
			<Toolbars>
				<dx:HtmlEditorToolbar Name="Toolbar">
					<Items>
						<dx:ToolbarUndoButton>
						</dx:ToolbarUndoButton>
						<dx:ToolbarRedoButton>
						</dx:ToolbarRedoButton>
						<dx:ToolbarBoldButton BeginGroup="True">
						</dx:ToolbarBoldButton>
						<dx:ToolbarItalicButton>
						</dx:ToolbarItalicButton>
						<dx:ToolbarUnderlineButton>
						</dx:ToolbarUnderlineButton>
						<dx:ToolbarStrikethroughButton>
						</dx:ToolbarStrikethroughButton>
						<dx:ToolbarInsertFlashDialogButton BeginGroup="true">
						</dx:ToolbarInsertFlashDialogButton>
						<dx:ToolbarInsertVideoDialogButton>
						</dx:ToolbarInsertVideoDialogButton>
						<dx:ToolbarInsertAudioDialogButton>
						</dx:ToolbarInsertAudioDialogButton>
						<dx:ToolbarInsertYouTubeVideoDialogButton>
						</dx:ToolbarInsertYouTubeVideoDialogButton>
						<dx:ToolbarFullscreenButton BeginGroup="true">
						</dx:ToolbarFullscreenButton>
					</Items>
				</dx:HtmlEditorToolbar>
			</Toolbars>
			<SettingsDialogs>
				<InsertFlashDialog>
					<SettingsFlashUpload UploadFolder="~/UploadFiles/FlashFiles">
						<ValidationSettings AllowedFileExtensions=".swf" MaxFileSize="500000">
						</ValidationSettings>
					</SettingsFlashUpload>
					<SettingsFlashSelector Enabled="True">
						<CommonSettings RootFolder="~/Content/FileManager/FlashFiles" ThumbnailFolder="~/Content/FileManager/Thumbnails"
							InitialFolder="" />
					</SettingsFlashSelector>
				</InsertFlashDialog>
				<InsertVideoDialog>
					<SettingsVideoUpload UploadFolder="~/UploadFiles/VideoFiles">
						<ValidationSettings AllowedFileExtensions=".mp4, .ogg" MaxFileSize="1000000">
						</ValidationSettings>
					</SettingsVideoUpload>
					<SettingsVideoSelector Enabled="True">
						<CommonSettings RootFolder="~/Content/FileManager/VideoFiles" ThumbnailFolder="~/Content/FileManager/Thumbnails"
							InitialFolder="" />
					</SettingsVideoSelector>
				</InsertVideoDialog>
				<InsertAudioDialog>
					<SettingsAudioUpload UploadFolder="~/UploadFiles/AudioFiles">
						<ValidationSettings AllowedFileExtensions=".mp3, .ogg" MaxFileSize="500000">
						</ValidationSettings>
					</SettingsAudioUpload>
					<SettingsAudioSelector Enabled="True">
						<CommonSettings RootFolder="~/Content/FileManager/AudioFiles" ThumbnailFolder="~/Content/FileManager/Thumbnails"
							InitialFolder="" />
					</SettingsAudioSelector>
				</InsertAudioDialog>
			</SettingsDialogs>
		</dx:ASPxHtmlEditor>
	</div>
	<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ShowItemCaptionColon="False" Width="200px" AlignItemCaptionsInAllGroups="true">
		<Items>
			<dx:LayoutGroup Caption="Content Filtering" GroupBoxDecoration="HeadingLine">
				<ParentContainerStyle>
					<Paddings PaddingRight="20px"  />
				</ParentContainerStyle>
				<Items>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
								<dx:ASPxCheckBox ID="cbAllowHTML5MediaElements" runat="server" AutoPostBack="True" Text="AllowHTML5MediaElements"  OnCheckedChanged="cbAllowHTML5MediaElements_CheckedChanged" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
								<dx:ASPxCheckBox ID="cbAllowObjectAndEmbedElements" runat="server" AutoPostBack="True" Text="AllowObjectAndEmbedElements"  OnCheckedChanged="cbAllowObjectAndEmbedElements_CheckedChanged" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
								<dx:ASPxCheckBox ID="cbAllowYouTubeVideoIFrames" runat="server" AutoPostBack="True" Text="AllowYouTubeVideoIFrames"  OnCheckedChanged="cbAllowYouTubeVideoIFrames_CheckedChanged" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
		</Items>
	</dx:ASPxFormLayout>
	<div class="Clear"></div>
	<br />
	<div class="Note">
		<b>Allowed  Extensions</b><br/>
		<b>Flash</b>: .swf;<br/>
		<b>Video</b>: .mp4, .ogg;<br/>
		<b>Audio</b>: .mp3, .ogg.
	</div>
</asp:Content>