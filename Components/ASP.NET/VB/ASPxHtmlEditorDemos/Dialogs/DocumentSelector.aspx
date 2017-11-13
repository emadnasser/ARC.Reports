<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DocumentSelector.aspx.vb"
	Inherits="Dialogs_DocumentSelector" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="float: left; padding-right: 20px;">
		<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Width="640px" Height="430px" OnDocumentSelectorFolderCreating="DemoHtmlEditor_DocumentSelectorFolderCreating"
			OnDocumentSelectorItemDeleting="DemoHtmlEditor_DocumentSelectorItemDeleting"
			OnDocumentSelectorItemMoving="DemoHtmlEditor_DocumentSelectorItemMoving" OnDocumentSelectorItemRenaming="DemoHtmlEditor_DocumentSelectorItemRenaming"
			OnDocumentSelectorFileUploading="DemoHtmlEditor_DocumentSelectorFileUploading">
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
						<dx:ToolbarInsertLinkDialogButton BeginGroup="True">
						</dx:ToolbarInsertLinkDialogButton>
					</Items>
				</dx:HtmlEditorToolbar>
			</Toolbars>
			<SettingsDialogs>
				<InsertLinkDialog>
					<SettingsDocumentSelector Enabled="True">
						<CommonSettings RootFolder="~/Content/FileManager/Documents" />
						<PermissionSettings>
							<AccessRules>
								<dx:FileManagerFolderAccessRule Role="" Upload="Deny" />
								<dx:FileManagerFolderAccessRule Role="" Path="Upload" Upload="Allow" />
							</AccessRules>
						</PermissionSettings>
					</SettingsDocumentSelector>
				</InsertLinkDialog>
				<InsertImageDialog>
					<SettingsImageUpload UploadFolder="~/UploadFiles/Images/">
						<ValidationSettings AllowedFileExtensions=".jpe,.jpeg,.jpg,.gif,.png" MaxFileSize="500000">
						</ValidationSettings>
					</SettingsImageUpload>
				</InsertImageDialog>
			</SettingsDialogs>
		</dx:ASPxHtmlEditor>
	</div>
	<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ShowItemCaptionColon="False"  Width="260px" AlignItemCaptionsInAllGroups="true">
		<Items>
			<dx:LayoutGroup Caption="Settings Document Selector" GroupBoxDecoration="HeadingLine">
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
			<dx:LayoutGroup Caption="Settings Document Dialog" GroupBoxDecoration="HeadingLine">
				<Items>
					<dx:LayoutItem ShowCaption="False">
						<layoutitemnestedcontrolcollection>
							<dx:LayoutItemNestedControlContainer ID="showOpenInNewWindowButtonLayoutItem" runat="server">
								<dx:ASPxCheckBox ID="cbShowOpenInNewWindowButton" runat="server" AutoPostBack="True" OnCheckedChanged="cbShowOpenInNewWindowButton_CheckedChanged"
									Checked="True"  Text="Show 'Open in new window' button" />
							</dx:LayoutItemNestedControlContainer>
						</layoutitemnestedcontrolcollection>
						<captionsettings location="Right" verticalalign="Middle" />
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<layoutitemnestedcontrolcollection>
							<dx:LayoutItemNestedControlContainer ID="showEmailAddressSectionLayoutItem" runat="server">
								<dx:ASPxCheckBox ID="cbShowEmailAddressSection" runat="server" AutoPostBack="True" OnCheckedChanged="cbShowEmailAddressSection_CheckedChanged"
									Checked="True" Text="Show 'E-mail address' section" />
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
		<b>Allowed Extensions</b>: .rtf, .pdf, .doc, .docx, .odt, .txt, .xls, .xlsx, .ods, .ppt, .pptx, .odp
	</p>
</asp:Content>