<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="Validation.aspx.vb" Inherits="Features_Validation" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function ValidationHandler(s, e) {
			if (chbValidateOnClient.GetChecked() && e.html.length > '<%=MaxLength%>') {
				e.isValid = false;
				e.errorText = "<%=CustomErrorText%>";
			}
		}
		function HtmlChangedHandler(s, e) {
			ContentLength.SetText(s.GetHtml().length);
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="margin: 8px 0;">
		<table><tr><td>
			<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Width="550px" Height="250px" OnValidation="DemoHtmlEditor_Validation">
				<ClientSideEvents HtmlChanged="HtmlChangedHandler" Validation="ValidationHandler" />
				<Toolbars>
					<dx:HtmlEditorToolbar Name="StandardToolbar2">
						<Items>
							<dx:ToolbarFontNameEdit>
								<Items>
									<dx:ToolbarListEditItem Text="Times New Roman" Value="Times New Roman" />
									<dx:ToolbarListEditItem Text="Tahoma" Value="Tahoma" />
									<dx:ToolbarListEditItem Text="Verdana" Value="Verdana" />
									<dx:ToolbarListEditItem Text="Arial" Value="Arial" />
									<dx:ToolbarListEditItem Text="MS Sans Serif" Value="MS Sans Serif" />
									<dx:ToolbarListEditItem Text="Courier" Value="Courier" />
								</Items>
							</dx:ToolbarFontNameEdit>
							<dx:ToolbarFontSizeEdit>
								<Items>
									<dx:ToolbarListEditItem Text="1 (8pt)" Value="1" />
									<dx:ToolbarListEditItem Text="2 (10pt)" Value="2" />
									<dx:ToolbarListEditItem Text="3 (12pt)" Value="3" />
									<dx:ToolbarListEditItem Text="4 (14pt)" Value="4" />
									<dx:ToolbarListEditItem Text="5 (18pt)" Value="5" />
									<dx:ToolbarListEditItem Text="6 (24pt)" Value="6" />
									<dx:ToolbarListEditItem Text="7 (36pt)" Value="7" />
								</Items>
							</dx:ToolbarFontSizeEdit>
							<dx:ToolbarBoldButton BeginGroup="True"></dx:ToolbarBoldButton>
							<dx:ToolbarItalicButton></dx:ToolbarItalicButton>
							<dx:ToolbarUnderlineButton></dx:ToolbarUnderlineButton>
							<dx:ToolbarStrikethroughButton></dx:ToolbarStrikethroughButton>
							<dx:ToolbarJustifyLeftButton BeginGroup="True"></dx:ToolbarJustifyLeftButton>
							<dx:ToolbarJustifyCenterButton></dx:ToolbarJustifyCenterButton>
							<dx:ToolbarJustifyRightButton></dx:ToolbarJustifyRightButton>
							<dx:ToolbarJustifyFullButton></dx:ToolbarJustifyFullButton>
						</Items>
					</dx:HtmlEditorToolbar>
				</Toolbars>
				<SettingsValidation>
					<RequiredField IsRequired="True" />
				</SettingsValidation>
			</dx:ASPxHtmlEditor>
		</td><td style="padding-left: 16px; vertical-align: top">
			<table class="OptionsTable">
				<tr><td style="padding: 0px 0px 8px;"><b>Built-in Validation:</b></td></tr>
				<tr><td><dx:ASPxCheckBox ID="chbIsRequired" runat="server" AutoPostBack="true" Checked="true" Text="IsRequired" /></td></tr>
			</table>
			<table class="OptionsTable">
				<tr><td style="padding: 12px 0px 8px;"><b>Custom Validation:</b></td></tr>
				<tr><td><dx:ASPxCheckBox ID="chbValidateOnServer" runat="server"  Checked="true" Text="Validate on server side" /></td></tr>
				<tr><td><dx:ASPxCheckBox ID="chbValidateOnClient" ClientInstanceName="chbValidateOnClient" runat="server" Checked="true" 
					Text="Validate on client side" /></td></tr>
			</table>
		</td></tr></table>
	</div>
	<div style="margin: 8px 0;">
		The current length of HTML code representing the editor's content (in characters): <dx:ASPxLabel ID="lblContentLength" runat="server" ClientInstanceName="ContentLength" Text="0" Font-Bold="True"></dx:ASPxLabel>
	</div>
	<dx:ASPxButton ID="DemoButton" runat="server" Text="Submit">
	</dx:ASPxButton>
</asp:Content>