<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomCSS.aspx.vb"
	Inherits="ToolbarItems_CustomCSS" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<link type="text/css" rel="Stylesheet" href="../Content/Demo/Css/CustomCss_Preview.css" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" ClientInstanceName="HtmlEditor"
		Height="500px" Width="800px">
		<SettingsDialogs>
			<InsertImageDialog>
				<SettingsImageUpload UploadFolder="~/UploadFiles/Images/">
					<ValidationSettings AllowedFileExtensions=".jpe,.jpeg,.jpg,.gif,.png" MaxFileSize="500000">
					</ValidationSettings>
				</SettingsImageUpload>
			</InsertImageDialog>
		</SettingsDialogs>
		<Toolbars>
			<dx:HtmlEditorToolbar>
				<Items>
					<dx:ToolbarCutButton />
					<dx:ToolbarCopyButton />
					<dx:ToolbarPasteButton />
					<dx:ToolbarUndoButton BeginGroup="True" />
					<dx:ToolbarRedoButton />
					<dx:ToolbarRemoveFormatButton BeginGroup="True" />
					<dx:ToolbarSuperscriptButton BeginGroup="True" />
					<dx:ToolbarSubscriptButton />
					<dx:ToolbarInsertOrderedListButton BeginGroup="True" />
					<dx:ToolbarInsertUnorderedListButton />
					<dx:ToolbarIndentButton BeginGroup="True" />
					<dx:ToolbarOutdentButton />
					<dx:ToolbarInsertLinkDialogButton BeginGroup="True" />
					<dx:ToolbarUnlinkButton />
					<dx:ToolbarInsertImageDialogButton />
					<dx:ToolbarTableOperationsDropDownButton BeginGroup="True">
						<Items>
							<dx:ToolbarInsertTableDialogButton BeginGroup="True" ViewStyle="ImageAndText">
							</dx:ToolbarInsertTableDialogButton>
							<dx:ToolbarTablePropertiesDialogButton BeginGroup="True">
							</dx:ToolbarTablePropertiesDialogButton>
							<dx:ToolbarTableRowPropertiesDialogButton>
							</dx:ToolbarTableRowPropertiesDialogButton>
							<dx:ToolbarTableColumnPropertiesDialogButton>
							</dx:ToolbarTableColumnPropertiesDialogButton>
							<dx:ToolbarTableCellPropertiesDialogButton>
							</dx:ToolbarTableCellPropertiesDialogButton>
							<dx:ToolbarInsertTableRowAboveButton BeginGroup="True">
							</dx:ToolbarInsertTableRowAboveButton>
							<dx:ToolbarInsertTableRowBelowButton>
							</dx:ToolbarInsertTableRowBelowButton>
							<dx:ToolbarInsertTableColumnToLeftButton>
							</dx:ToolbarInsertTableColumnToLeftButton>
							<dx:ToolbarInsertTableColumnToRightButton>
							</dx:ToolbarInsertTableColumnToRightButton>
							<dx:ToolbarSplitTableCellHorizontallyButton BeginGroup="True">
							</dx:ToolbarSplitTableCellHorizontallyButton>
							<dx:ToolbarSplitTableCellVerticallyButton>
							</dx:ToolbarSplitTableCellVerticallyButton>
							<dx:ToolbarMergeTableCellRightButton>
							</dx:ToolbarMergeTableCellRightButton>
							<dx:ToolbarMergeTableCellDownButton>
							</dx:ToolbarMergeTableCellDownButton>
							<dx:ToolbarDeleteTableButton BeginGroup="True">
							</dx:ToolbarDeleteTableButton>
							<dx:ToolbarDeleteTableRowButton>
							</dx:ToolbarDeleteTableRowButton>
							<dx:ToolbarDeleteTableColumnButton>
							</dx:ToolbarDeleteTableColumnButton>
						</Items>
					</dx:ToolbarTableOperationsDropDownButton>
				</Items>
			</dx:HtmlEditorToolbar>
			<dx:HtmlEditorToolbar>
				<Items>
					<dx:ToolbarCustomCssEdit Width="120px">
						<Items>
							<dx:ToolbarCustomCssListEditItem TagName="" Text="Clear Style" CssClass="" />
							<dx:ToolbarCustomCssListEditItem TagName="H1" Text="Title" CssClass="CommonTitle">
								<PreviewStyle CssClass="CommonTitlePreview" />
							</dx:ToolbarCustomCssListEditItem>
							<dx:ToolbarCustomCssListEditItem TagName="H3" Text="Header1" CssClass="CommonHeader1">
								<PreviewStyle CssClass="CommonHeader1Preview" />
							</dx:ToolbarCustomCssListEditItem>
							<dx:ToolbarCustomCssListEditItem TagName="H4" Text="Header2" CssClass="CommonHeader2">
								<PreviewStyle CssClass="CommonHeader2Preview" />
							</dx:ToolbarCustomCssListEditItem>
							<dx:ToolbarCustomCssListEditItem TagName="Div" Text="Content" CssClass="CommonContent">
								<PreviewStyle CssClass="CommonContentPreview" />
							</dx:ToolbarCustomCssListEditItem>
							<dx:ToolbarCustomCssListEditItem TagName="Strong" Text="Features" CssClass="CommonFeatures">
								<PreviewStyle CssClass="CommonFeaturesPreview" />
							</dx:ToolbarCustomCssListEditItem>
							<dx:ToolbarCustomCssListEditItem TagName="Div" Text="Footer" CssClass="CommonFooter">
								<PreviewStyle CssClass="CommonFooterPreview" />
							</dx:ToolbarCustomCssListEditItem>
							<dx:ToolbarCustomCssListEditItem TagName="" Text="Link" CssClass="Link">
								<PreviewStyle CssClass="LinkPreview" />
							</dx:ToolbarCustomCssListEditItem>
							<dx:ToolbarCustomCssListEditItem TagName="EM" Text="ImageTitle" CssClass="ImageTitle">
								<PreviewStyle CssClass="ImageTitlePreview" />
							</dx:ToolbarCustomCssListEditItem>
							<dx:ToolbarCustomCssListEditItem TagName="" Text="ImageMargin" CssClass="ImageMargin">
								<PreviewStyle CssClass="ImageMarginPreview" />
							</dx:ToolbarCustomCssListEditItem>
						</Items>
					</dx:ToolbarCustomCssEdit>
					<dx:ToolbarFontNameEdit>
						<Items>
							<dx:ToolbarListEditItem Value="Times New Roman" Text="Times New Roman"></dx:ToolbarListEditItem>
							<dx:ToolbarListEditItem Value="Tahoma" Text="Tahoma"></dx:ToolbarListEditItem>
							<dx:ToolbarListEditItem Value="Verdana" Text="Verdana"></dx:ToolbarListEditItem>
							<dx:ToolbarListEditItem Value="Arial" Text="Arial"></dx:ToolbarListEditItem>
							<dx:ToolbarListEditItem Value="MS Sans Serif" Text="MS Sans Serif"></dx:ToolbarListEditItem>
							<dx:ToolbarListEditItem Value="Courier" Text="Courier"></dx:ToolbarListEditItem>
						</Items>
					</dx:ToolbarFontNameEdit>
					<dx:ToolbarFontSizeEdit>
						<Items>
							<dx:ToolbarListEditItem Value="1" Text="1 (8pt)"></dx:ToolbarListEditItem>
							<dx:ToolbarListEditItem Value="2" Text="2 (10pt)"></dx:ToolbarListEditItem>
							<dx:ToolbarListEditItem Value="3" Text="3 (12pt)"></dx:ToolbarListEditItem>
							<dx:ToolbarListEditItem Value="4" Text="4 (14pt)"></dx:ToolbarListEditItem>
							<dx:ToolbarListEditItem Value="5" Text="5 (18pt)"></dx:ToolbarListEditItem>
							<dx:ToolbarListEditItem Value="6" Text="6 (24pt)"></dx:ToolbarListEditItem>
							<dx:ToolbarListEditItem Value="7" Text="7 (36pt)"></dx:ToolbarListEditItem>
						</Items>
					</dx:ToolbarFontSizeEdit>
					<dx:ToolbarBoldButton BeginGroup="True" />
					<dx:ToolbarItalicButton />
					<dx:ToolbarUnderlineButton />
					<dx:ToolbarStrikethroughButton />
					<dx:ToolbarJustifyLeftButton BeginGroup="True" />
					<dx:ToolbarJustifyCenterButton />
					<dx:ToolbarJustifyRightButton />
					<dx:ToolbarJustifyFullButton />
					<dx:ToolbarBackColorButton BeginGroup="True" />
					<dx:ToolbarFontColorButton />
				</Items>
			</dx:HtmlEditorToolbar>
		</Toolbars>
		<CssFiles>
			<dx:HtmlEditorCssFile FilePath="~/Content/Demo/Css/CustomCss.css"></dx:HtmlEditorCssFile>
		</CssFiles>
		<Styles>
			<ViewArea Font-Names="Tahoma">
			</ViewArea>
		</Styles>
	</dx:ASPxHtmlEditor>
</asp:Content>