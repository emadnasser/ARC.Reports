<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Tables.aspx.vb"
	Inherits="Features_SpellChecking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable OptionsBottomMargin">
		<tr>
			<td>
				<dx:ASPxRadioButton ID="rbTableToolbar" runat="server" Text="Show Table toolbar"
					Checked="true" GroupName="table" AutoPostBack="true" OnCheckedChanged="rbTable_CheckedChanged">
				</dx:ASPxRadioButton>
			</td>
			<td style="padding-left: 40px;">
				<dx:ASPxRadioButton ID="rbTableOperationsBtn" runat="server" Text="Show TableOperations button"
					GroupName="table" AutoPostBack="true" OnCheckedChanged="rbTable_CheckedChanged">
				</dx:ASPxRadioButton>
			</td>
		</tr>
	</table>
	<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" ClientInstanceName="HtmlEditor" Width="100%"
		Height="480px">
		<SettingsDialogs>
			<InsertImageDialog>
				<SettingsImageUpload UploadFolder="~/UploadFiles/Images/">
					<ValidationSettings AllowedFileExtensions=".jpe,.jpeg,.jpg,.gif,.png" MaxFileSize="500000">
					</ValidationSettings>
				</SettingsImageUpload>
			</InsertImageDialog>
		</SettingsDialogs>
		<CssFiles>
			<dx:HtmlEditorCssFile FilePath="~/Content/Demo/Css/TableSupport.css" />
		</CssFiles>
	</dx:ASPxHtmlEditor>
</asp:Content>