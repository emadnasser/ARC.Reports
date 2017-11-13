<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ImageSelector.aspx.vb"
	Inherits="Dialogs_ImageSelector" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="float: left; padding-right: 20px;">
		<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Width="680px" Height="380px" OnImageSelectorFolderCreating="DemoHtmlEditor_ImageSelectorFolderCreating"
			OnImageSelectorItemDeleting="DemoHtmlEditor_ImageSelectorItemDeleting" OnImageSelectorItemMoving="DemoHtmlEditor_ImageSelectorItemMoving"
			OnImageSelectorItemRenaming="DemoHtmlEditor_ImageSelectorItemRenaming" OnImageSelectorFileUploading="DemoHtmlEditor_ImageSelectorFileUploading">
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
						<dx:ToolbarInsertImageDialogButton BeginGroup="True">
						</dx:ToolbarInsertImageDialogButton>
					</Items>
				</dx:HtmlEditorToolbar>
			</Toolbars>
			<SettingsDialogs>
				<InsertImageDialog ShowStyleSettingsSection="true">
					<SettingsImageSelector Enabled="True">
						<CommonSettings RootFolder="~/Content/FileManager/Images" ThumbnailFolder="~/Content/FileManager/Thumbnails"
							InitialFolder="Employees" />
						<PermissionSettings>
							<AccessRules>
								<dx:FileManagerFolderAccessRule Role="" Upload="Deny" />
								<dx:FileManagerFolderAccessRule Role="" Path="Upload" Upload="Allow" />
							</AccessRules>
						</PermissionSettings>
					</SettingsImageSelector>
					<SettingsImageUpload UploadFolder="~/UploadFiles/Images/">
						<ValidationSettings AllowedFileExtensions=".jpe,.jpeg,.jpg,.gif,.png" MaxFileSize="500000">
						</ValidationSettings>
					</SettingsImageUpload>
					<CssClassItems>
						<dx:InsertImageCssClassItem Text="With border" CssClass="WithBorder" />
						<dx:InsertImageCssClassItem Text="With paddings" CssClass="WithPaddings" />
						<dx:InsertImageCssClassItem Text="Semi-transparent" CssClass="SemiTransparent" />
					</CssClassItems>
				</InsertImageDialog>
			</SettingsDialogs>
			<CssFiles>
				<dx:HtmlEditorCssFile FilePath="~/Content/Demo/Css/CustomCss.css"></dx:HtmlEditorCssFile>
			</CssFiles>
		</dx:ASPxHtmlEditor>
	</div>
	<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ShowItemCaptionColon="False"  Width="200px" AlignItemCaptionsInAllGroups="true">
		<Items>
			<dx:LayoutGroup Caption="Settings Image Selector" GroupBoxDecoration="HeadingLine">
				<Items>
					<dx:LayoutItem ShowCaption="False">
						<layoutitemnestedcontrolcollection>
							<dx:LayoutItemNestedControlContainer ID="enableEditingLayoutItem" runat="server">
								<dx:ASPxCheckBox ID="cbEnableEditing" runat="server" AutoPostBack="True" OnCheckedChanged="cbEnableEditing_CheckedChanged" 
									Checked="True"  Text="Enable Editing" />
							</dx:LayoutItemNestedControlContainer>
						</layoutitemnestedcontrolcollection>
						<captionsettings location="Right" verticalalign="Middle" />
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<layoutitemnestedcontrolcollection>
							<dx:LayoutItemNestedControlContainer ID="enableUploadLayoutItem" runat="server">
								<dx:ASPxCheckBox ID="cbEnableUpload" runat="server" AutoPostBack="True" OnCheckedChanged="cbEnableUpload_CheckedChanged"
									Checked="True"  Text="Enable Upload" />
							</dx:LayoutItemNestedControlContainer>
						</layoutitemnestedcontrolcollection>
						<captionsettings location="Right" verticalalign="Middle" />
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<layoutitemnestedcontrolcollection>
							<dx:LayoutItemNestedControlContainer ID="showToolbarLayoutItem" runat="server">
								<dx:ASPxCheckBox ID="cbShowToolbar" runat="server" AutoPostBack="True" OnCheckedChanged="cbShowToolbar_CheckedChanged"
									Checked="True"  Text="Show Toolbar" />
							</dx:LayoutItemNestedControlContainer>
						</layoutitemnestedcontrolcollection>
						<captionsettings location="Right" verticalalign="Middle" />
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<layoutitemnestedcontrolcollection>
							<dx:LayoutItemNestedControlContainer ID="showFoldersAreaLayoutItem" runat="server">
								<dx:ASPxCheckBox ID="cbShowFoldersArea" runat="server" AutoPostBack="True" OnCheckedChanged="cbShowFoldersArea_CheckedChanged"
									Checked="True"  Text="Show Folders Area" />
							</dx:LayoutItemNestedControlContainer>
						</layoutitemnestedcontrolcollection>
						<captionsettings location="Right" verticalalign="Middle" />
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<layoutitemnestedcontrolcollection>
							<dx:LayoutItemNestedControlContainer ID="showBreadcrumbsLayoutItem" runat="server">
								<dx:ASPxCheckBox ID="cbShowBreadcrumbs" runat="server" AutoPostBack="True" OnCheckedChanged="cbShowBreadcrumbs_CheckedChanged"
									Checked="True"  Text="Show Breadcrumbs" />
							</dx:LayoutItemNestedControlContainer>
						</layoutitemnestedcontrolcollection>
						<captionsettings location="Right" verticalalign="Middle" />
					</dx:LayoutItem>
					<dx:LayoutItem Caption="File List View:">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer ID="fileListViewLayoutItem" runat="server">
								<dx:ASPxComboBox ID="cbFileListView" runat="server" AutoPostBack="True" Width="90px" ValueType="System.Int32"  OnValueChanged="cbFileListView_ValueChanged">
									<Items>
										<dx:ListEditItem Text="Thumbnails" Value="0" />
										<dx:ListEditItem Text="Details" Value="1" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
			<dx:LayoutGroup Caption="Settings Image Dialog" GroupBoxDecoration="HeadingLine">
				<Items>
					<dx:LayoutItem ShowCaption="False">
						<layoutitemnestedcontrolcollection>
							<dx:LayoutItemNestedControlContainer ID="moreOptionsLayoutItem" runat="server">
								<dx:ASPxCheckBox ID="cbMoreOptions" runat="server" AutoPostBack="True" OnCheckedChanged="cbMoreOptions_CheckedChanged" 
									Checked="True" Text="Show More Options" />
							</dx:LayoutItemNestedControlContainer>
						</layoutitemnestedcontrolcollection>
						<captionsettings location="Right" verticalalign="Middle" />
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
		</Items>
	</dx:ASPxFormLayout>
	<div class="Clear"></div>
	<br />
	<p class="Note">
		<b>Allowed Extensions</b>: .jpe, .jpeg, .jpg, .gif, .png
	</p>
</asp:Content>