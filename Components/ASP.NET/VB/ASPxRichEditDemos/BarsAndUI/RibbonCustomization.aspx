<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RibbonCustomization.aspx.vb"
	Inherits="RichEditDemoRibbonCustomization" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRibbon ID="ExternalRibbon" runat="server" ShowFileTab="False" Visible="false">
		<tabs>
			<dx:RERHomeTab>
				<Groups>
					<dx:RERFileCommonGroup>
						<Items>
							<dx:RERNewCommand Size="Small" Text="New Document" ToolTip="Ctrl + N" />
							<dx:RERPrintCommand Size="Small" Text="Print Document" ToolTip="Ctrl + P" />
						</Items>
					</dx:RERFileCommonGroup>
					<dx:RERFontGroup ShowDialogBoxLauncher="true">
						<Items>
							<dx:RERFontNameCommand PropertiesComboBox-Width="100px" />
							<dx:RERFontSizeCommand PropertiesComboBox-Width="100px" />
							<dx:RERFontBoldCommand Size="Large" Text="Bold" ToolTip="Ctrl + B" />
							<dx:RERFontItalicCommand Size="Large" Text="Italic" ToolTip="Ctrl + I" />
						</Items>
					</dx:RERFontGroup>
					<dx:RERViewGroup>
						<Items>
							<dx:RERToggleShowHorizontalRulerCommand />
							<dx:RERToggleFullScreenCommand ToolTip="F11" />
						</Items>
					</dx:RERViewGroup>
				</Groups>
			</dx:RERHomeTab>
		</tabs>
	</dx:ASPxRibbon>
	<div style="padding: 10px;">
		<table class="OptionsTable">
			<tr>
				<td>
					<dx:ASPxLabel ID="lblRibbonMode" runat="server" Text="Ribbon mode:" />
				</td>
				<td>
					<dx:ASPxComboBox SelectedIndex="1" ID="ddlRibbonMode" runat="server"
						Width="120px" AutoPostBack="True">
						<Items>
							<dx:ListEditItem Value="None" Text="None" />
							<dx:ListEditItem Value="Ribbon" Text="Ribbon" />
							<dx:ListEditItem Value="ExternalRibbon" Text="External Ribbon" />
							<dx:ListEditItem Value="OneLineRibbon" Text="One Line Ribbon" />
							<dx:ListEditItem Value="Auto" Text="Auto" />

						</Items>
					</dx:ASPxComboBox>
				</td>
				<td>
					<dx:ASPxCheckBox ID="cbShowStatusBar" runat="server" AutoPostBack="True"
						Text="Show StatusBar" Checked="true">
					</dx:ASPxCheckBox>
				</td>
			</tr>
		</table>
	</div>
	<dx:ASPxRichEdit ID="DemoRichEdit" runat="server" ClientInstanceName="DemoRichEdit"
		Width="100%" ShowConfirmOnLosingChanges="false" OnPreRender="DemoRichEdit_PreRender">
		<RibbonTabs>
			<dx:RERHomeTab>
				<Groups>
					<dx:RERFileCommonGroup>
						<Items>
							<dx:RERNewCommand Size="Small" Text="New Document" ToolTip="Ctrl + N" />
							<dx:RERPrintCommand Size="Small" Text="Print Document" ToolTip="Ctrl + P" />
						</Items>
					</dx:RERFileCommonGroup>
					<dx:RERUndoGroup>
						<Items>
							<dx:RERUndoCommand Size="Large" Text="Undo" ToolTip="Ctrl + Z" />
							<dx:RERRedoCommand Size="Large" Text="Redo" ToolTip="Ctrl + Y" />
						</Items>
					</dx:RERUndoGroup>
					<dx:RERFontGroup ShowDialogBoxLauncher="false">
						<Items>
							<dx:RERFontNameCommand PropertiesComboBox-Width="100px" />
							<dx:RERFontSizeCommand PropertiesComboBox-Width="100px" />
							<dx:RERFontBoldCommand Size="Large" Text="Bold" ToolTip="Ctrl + B" />
							<dx:RERFontItalicCommand Size="Large" Text="Italic" ToolTip="Ctrl + I" />
						</Items>
					</dx:RERFontGroup>
					<dx:RERPagesGroup>
						<Items>
							<dx:RERPageMarginsCommand />
							<dx:RERChangeSectionPageOrientationCommand />
							<dx:RERChangeSectionPaperKindCommand />
						</Items>
					</dx:RERPagesGroup>
					<dx:RERViewGroup>
						<Items>
							<dx:RERToggleShowHorizontalRulerCommand />
							<dx:RERToggleFullScreenCommand ToolTip="F11" />
						</Items>
					</dx:RERViewGroup>
				</Groups>
			</dx:RERHomeTab>
		</RibbonTabs>
	</dx:ASPxRichEdit>
</asp:Content>