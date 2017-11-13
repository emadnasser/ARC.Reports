<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSideSelection.aspx.vb"
	Inherits="ClientSideAPI_ClientSideSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<%--start highlighted block--%>
	<script type="text/javascript">
	// <![CDATA[
		// Event handler
		function OnCustomCommand(s, e) {
			if (e.commandName == "ChangeCase")
				ChangeCase(e.parameter);
		}
		// Change case functionality
		function ChangeCase(value) {
			var selection = HtmlEditor.GetSelection();
			var selectedElements = selection.GetElements();
			var textNodes = findAllTextNodes(selectedElements);
			for (var i = 0; i < textNodes.length; i++) {
				switch (value) {
					case "capitalize":
						var sentenceEndExp = /\.+\s*$/;
						var emptyStringExp = /^\s*$/;
						var prevText = getPreviousText(textNodes[i]);
						var capitalizeFirstLetter = emptyStringExp.test(prevText) || sentenceEndExp.test(prevText);
						textNodes[i].nodeValue = capitalize(textNodes[i].nodeValue.toLowerCase(), capitalizeFirstLetter);
						break;
					case "lowercase":
						textNodes[i].nodeValue = textNodes[i].nodeValue.toLowerCase();
						break;
					case "uppercase":
						textNodes[i].nodeValue = textNodes[i].nodeValue.toUpperCase();
						break;
					case "camelize":
						textNodes[i].nodeValue = camelize(textNodes[i].nodeValue.toLowerCase());
						break;
				}
			}
			HtmlEditor.SaveToUndoHistory();
		}
		function findAllTextNodes(elements) {
			var nodes = [];
			if (elements) {
				for (var i = 0; i < elements.length; i++) {
					if (elements[i].nodeType == 3)
						nodes.push(elements[i]);
					else
						nodes = nodes.concat(findAllTextNodes(elements[i].childNodes));
				}
			}
			return nodes;
		}
		function getPreviousText(element) {
			var prevElement = element.previousSibling;
			return (prevElement && prevElement.nodeType == 3) ? getPreviousText(prevElement) + prevElement.nodeValue : "";
		}
		function capitalize(text, capitalizeFirstLetter) {
			var text = text.replace(/(\.|\?|\!)+\s+\S+/g, function (word) {
				return word.charAt(0) + " " + word.charAt(2).toUpperCase() + word.substring(3).toLowerCase();
			});
			if (capitalizeFirstLetter)
				text = text.replace(/\S+/, function (word) {
					return word.charAt(0).toUpperCase() + word.substring(1).toLowerCase();
				});
			return text;
		}
		function camelize(text) {
			return text.replace(/\S+/g, function (word) {
				return word.charAt(0).toUpperCase() + word.substring(1).toLowerCase();
			});
		}
	// ]]> 
	</script>
	<%--end highlighted block--%>
	<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Height="300px" ClientInstanceName="HtmlEditor">
		<ClientSideEvents CustomCommand="OnCustomCommand" />
		<Toolbars>
			<dx:HtmlEditorToolbar>
				<Items>
					<dx:ToolbarUndoButton>
					</dx:ToolbarUndoButton>
					<dx:ToolbarRedoButton>
					</dx:ToolbarRedoButton>
					<dx:ToolbarJustifyLeftButton BeginGroup="True">
					</dx:ToolbarJustifyLeftButton>
					<dx:ToolbarJustifyCenterButton>
					</dx:ToolbarJustifyCenterButton>
					<dx:ToolbarJustifyRightButton>
					</dx:ToolbarJustifyRightButton>
					<dx:ToolbarJustifyFullButton>
					</dx:ToolbarJustifyFullButton>
					<dx:ToolbarDropDownMenu CommandName="ChangeCase" ToolTip="Change Case" BeginGroup="true">
						<Image Height="16px" Width="16px">
						</Image>
						<Items>
							<dx:ToolbarMenuItem Text="Sentence case" Value="capitalize" ToolTip="Sentence case">
							</dx:ToolbarMenuItem>
							<dx:ToolbarMenuItem Text="lowercase" Value="lowercase" ToolTip="lowercase">
							</dx:ToolbarMenuItem>
							<dx:ToolbarMenuItem Text="UPPERCASE" Value="uppercase" ToolTip="UPPERCASE">
							</dx:ToolbarMenuItem>
							<dx:ToolbarMenuItem Text="Capitalize Each Word" Value="camelize" ToolTip="Capitalize Each Word">
							</dx:ToolbarMenuItem>
						</Items>
					</dx:ToolbarDropDownMenu>
				</Items>
			</dx:HtmlEditorToolbar>
		</Toolbars>
	</dx:ASPxHtmlEditor>
</asp:Content>