<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManualPasteFormatting.aspx.vb"
	Inherits="ClientSideAPI_ManualPasteFormatting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function GetStyleAttributes(commandName) {
			var result = [];
			result.push({ attrName: "font-weight", value: (cbBold.GetValue() ? "bold" : "") });
			result.push({ attrName: "font-style", value: (cbItalic.GetValue() ? "italic" : "") });
			result.push({ attrName: "text-decoration", value: (cbUnderline.GetValue() ? "underline" : "") });
			return result;
		}
		function BeforePasteHandler(s, e) {
			DXEventMonitor.Trace(s, e, 'BeforePaste', true);
			if (e.commandName != ASPxClientCommandConsts.PASTEHTMLPLAINTEXT_COMMAND) {
				var styleAttributes = GetStyleAttributes();
				var cssText = "";
				for (var i = 0, attr; attr = styleAttributes[i]; i++) {
					if (attr.value)
						cssText += attr.attrName + ": " + attr.value + ";";
				}
				if (cssText) {
					var array = e.html.match(/<(div|p|table|ol|ul|dl|h[1-6]|address|blockquote|center|pre)(?![^>]*display\s*:\s*inline)[^>]*/gi);
					var element = document.createElement(array && array.length > 0 ? "DIV" : "SPAN");
					element.innerHTML = e.html;
					element.style.cssText = cssText;
					e.html = element.outerHTML;
				}
			}
		}
	</script>
	<%--end highlighted block--%>
	<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Width="900px" Height="380px">
		<SettingsHtmlEditing EnablePasteOptions="true" />
		<Toolbars>
			<dx:HtmlEditorToolbar Name="Toolbar">
				<Items>
					<dx:ToolbarUndoButton>
					</dx:ToolbarUndoButton>
					<dx:ToolbarRedoButton>
					</dx:ToolbarRedoButton>
					<dx:ToolbarFontNameEdit BeginGroup="true">
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
					<dx:ToolbarBoldButton BeginGroup="true">
					</dx:ToolbarBoldButton>
					<dx:ToolbarItalicButton>
					</dx:ToolbarItalicButton>
					<dx:ToolbarUnderlineButton>
					</dx:ToolbarUnderlineButton>
					<dx:ToolbarStrikethroughButton>
					</dx:ToolbarStrikethroughButton>
					<dx:ToolbarJustifyLeftButton BeginGroup="true">
					</dx:ToolbarJustifyLeftButton>
					<dx:ToolbarJustifyCenterButton>
					</dx:ToolbarJustifyCenterButton>
					<dx:ToolbarJustifyRightButton>
					</dx:ToolbarJustifyRightButton>
					<dx:ToolbarInsertImageDialogButton BeginGroup="True">
					</dx:ToolbarInsertImageDialogButton>
				</Items>
			</dx:HtmlEditorToolbar>
		</Toolbars>
	</dx:ASPxHtmlEditor>
	<div class="Note">
		Copy a part of the editor content and paste it with the specified formatting.
	</div>
	<div style="margin-left: -14px; padding-top: 20px;">
		<dx:ASPxFormLayout ID="demoOptions" runat="server" ShowItemCaptionColon="False"  AlignItemCaptionsInAllGroups="true" ColCount="2">
			<Items>
				<dx:LayoutGroup Caption="Trace BeforePaste Event" GroupBoxDecoration="HeadingLine">
					<Items>
						<dx:LayoutItem ShowCaption="False">
							<layoutitemnestedcontrolcollection>
								<dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
									<dx:EventMonitor runat="server" ID="EventMonitor1"  EventNames="BeforePaste" ShowEventListPanel="false" />
								</dx:LayoutItemNestedControlContainer>
							</layoutitemnestedcontrolcollection>
						</dx:LayoutItem>
					</Items>
				</dx:LayoutGroup>
				<dx:LayoutGroup Caption="Formatting Settings" GroupBoxDecoration="HeadingLine" ColCount="3">
					<Items>
						<dx:LayoutItem ShowCaption="False">
							<layoutitemnestedcontrolcollection>
								<dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
									<dx:ASPxCheckBox ID="cbBold" runat="server"  Text="Bold" ClientInstanceName="cbBold" />
								</dx:LayoutItemNestedControlContainer>
							</layoutitemnestedcontrolcollection>
						</dx:LayoutItem>
						<dx:LayoutItem ShowCaption="False">
							<layoutitemnestedcontrolcollection>
								<dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
									<dx:ASPxCheckBox ID="cbItalic" runat="server"  Text="Italic" ClientInstanceName="cbItalic" />
								</dx:LayoutItemNestedControlContainer>
							</layoutitemnestedcontrolcollection>
						</dx:LayoutItem>
						<dx:LayoutItem ShowCaption="False">
							<layoutitemnestedcontrolcollection>
								<dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
									<dx:ASPxCheckBox ID="cbUnderline" runat="server" Text="Underline" ClientInstanceName="cbUnderline" />
								</dx:LayoutItemNestedControlContainer>
							</layoutitemnestedcontrolcollection>
						</dx:LayoutItem>
					</Items>
				</dx:LayoutGroup>
			</Items>
		</dx:ASPxFormLayout>
	</div>
</asp:Content>