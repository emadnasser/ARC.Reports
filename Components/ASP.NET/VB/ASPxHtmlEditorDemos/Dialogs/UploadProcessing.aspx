<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UploadProcessing.aspx.vb"
	Inherits="Dialogs_UploadProcessing" %>
<asp:Content ID="CustomHeadContent" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.htmlEditorContainer,
		.htmlEditorContainer > tbody > tr > td:first-child 
		{
			width: 100%;
		}
		.htmlEditorContainer > tbody > tr > td 
		{
			vertical-align: top;
		}
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="htmlEditorContainer">
		<tr>
			<td>
				<dx:ASPxHtmlEditor ID="DemoHtmlEditor" Width="100%" Height="520px" runat="server" OnImageFileSaving="DemoHtmlEditor_ImageFileSaving">
					<Toolbars>
						<dx:HtmlEditorToolbar Caption="DemoToolbar" Name="DemoToolbar">
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
						<InsertImageDialog ShowMoreOptionsButton="false">
							<SettingsImageUpload>
								<FileSystemSettings UploadFolder="~/UploadFiles/Images/" />
							</SettingsImageUpload>
						</InsertImageDialog>
					</SettingsDialogs>
					<Settings AllowInsertDirectImageUrls="false"></Settings>
				</dx:ASPxHtmlEditor>
			</td>
			<td style="padding-left: 20px;">
				<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
					<SettingsItemCaptions Location="Top" />
					<Items>
						<dx:LayoutGroup Caption="Uploaded Image Settings" GroupBoxDecoration="HeadingLine">
							<Items>
								<dx:LayoutItem Caption="File name prefix">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox ID="FileNamePrefixTextBox" runat="server" NullText="Without prefix">
												<ValidationSettings Display="Dynamic" ErrorTextPosition="Bottom">
													<RegularExpression ValidationExpression='[^|"]*' ErrorText="The prefix contains invalid characters" />
												</ValidationSettings>
											</dx:ASPxTextBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Watermark text">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxTextBox ID="WatermarkTextBox" runat="server" Text="ASPxHtmlEditor">
											</dx:ASPxTextBox>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Max width">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxSpinEdit ID="MaxWidthSpinEdit" runat="server" MaxValue="1000" MinValue="100" Number="480"></dx:ASPxSpinEdit>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Max height">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxSpinEdit ID="MaxHeightSpinEdit" runat="server" MaxValue="1000" MinValue="100" Number="320"></dx:ASPxSpinEdit>
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
							</Items>
						</dx:LayoutGroup>
					</Items>
				</dx:ASPxFormLayout>
			</td>
		</tr>
	</table>
</asp:Content>