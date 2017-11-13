<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ImportExport.aspx.vb"
	Inherits="Features_ImportExport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="BottomMargin">
		<tr>
			<td style="padding: 0px 70px 0px 40px">
				<dx:ASPxButton ID="ASPxButton1" runat="server" Text="Import the document" OnClick="ImportButton_Click">
					<ClientSideEvents Click="function(s,e){ LoadingPanel.ShowInElement(HtmlEditor.GetMainElement()); }" />
				</dx:ASPxButton>
			</td>
			<td>
				<p>
					<dx:ASPxLabel runat="server" Text="Import settings:" Font-Bold="true" />
				</p>
				<p>
					<dx:ASPxLabel runat="server" Text="Sample document:"/>
					<dx:ASPxHyperLink ID="DocumentHyperLink" runat="server">
					</dx:ASPxHyperLink>
				</p>
				<p>
					<dx:ASPxLabel runat="server" Text="Images and css folder:" />
					<dx:ASPxLabel ID="ContentFolderLabel" runat="server">
					</dx:ASPxLabel>
				</p>
				<dx:ASPxComboBox ID="ImportStylesComboBox" runat="server" SelectedIndex="0" Caption="Import styles as">
					<RootStyle CssClass="OptionsBottomMargin"></RootStyle>
					<Items>
						<dx:ListEditItem Text="Stylesheet file" Value="file" />
						<dx:ListEditItem Text="Inline styles" Value="inline" />
					</Items>
				</dx:ASPxComboBox>

			</td>
		</tr>
	</table>
	<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel">
	</dx:ASPxLoadingPanel>
	<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" ClientInstanceName="HtmlEditor"
		Width="100%">
		<Toolbars>
			<dx:HtmlEditorToolbar>
				<Items>
					<dx:ToolbarUndoButton>
					</dx:ToolbarUndoButton>
					<dx:ToolbarRedoButton>
					</dx:ToolbarRedoButton>
					<dx:ToolbarBoldButton BeginGroup="true">
					</dx:ToolbarBoldButton>
					<dx:ToolbarItalicButton>
					</dx:ToolbarItalicButton>
					<dx:ToolbarUnderlineButton>
					</dx:ToolbarUnderlineButton>
					<dx:ToolbarStrikethroughButton>
					</dx:ToolbarStrikethroughButton>
					<dx:ToolbarInsertImageDialogButton BeginGroup="True">
					</dx:ToolbarInsertImageDialogButton>
					<dx:ToolbarExportDropDownButton BeginGroup="True">
						<Items>
							<dx:ToolbarExportDropDownItem Format="Rtf">
							</dx:ToolbarExportDropDownItem>
							<dx:ToolbarExportDropDownItem Format="Pdf">
							</dx:ToolbarExportDropDownItem>
							<dx:ToolbarExportDropDownItem Format="Txt">
							</dx:ToolbarExportDropDownItem>
							<dx:ToolbarExportDropDownItem Format="Docx">
							</dx:ToolbarExportDropDownItem>
							<dx:ToolbarExportDropDownItem Format="Odt">
							</dx:ToolbarExportDropDownItem>
							<dx:ToolbarExportDropDownItem Format="Mht">
							</dx:ToolbarExportDropDownItem>
						</Items>
					</dx:ToolbarExportDropDownButton>
				</Items>
			</dx:HtmlEditorToolbar>
		</Toolbars>
		<CssFiles>
			<dx:HtmlEditorCssFile FilePath="~/Content/Demo/Css/Export.css"></dx:HtmlEditorCssFile>
		</CssFiles>
		<SettingsDialogs>
			<InsertImageDialog>
				<SettingsImageUpload>
					<ValidationSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png">
					</ValidationSettings>
				</SettingsImageUpload>
				<SettingsImageSelector>
					<CommonSettings AllowedFileExtensions=".jpe, .jpeg, .jpg, .gif, .png"></CommonSettings>
				</SettingsImageSelector>
			</InsertImageDialog>
		</SettingsDialogs>
	</dx:ASPxHtmlEditor>
</asp:Content>