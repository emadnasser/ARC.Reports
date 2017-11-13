<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomToolbar.aspx.vb" Inherits="BarsAndUI_CustomToolbar" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		var commandsTable = {
			"bold": function (rich) { return rich.commands.changeFontBold },
			"italic": function (rich) { return rich.commands.changeFontItalic },
			"underline": function (rich) { return rich.commands.changeFontUnderline },
			"strikeout": function (rich) { return rich.commands.changeFontStrikeout },
			"alignleft": function (rich) { return rich.commands.toggleParagraphAlignmentLeft },
			"aligncenter": function (rich) { return rich.commands.toggleParagraphAlignmentCenter },
			"alignright": function (rich) { return rich.commands.toggleParagraphAlignmentRight },
			"listbullets": function (rich) { return rich.commands.toggleBulletedList },
			"listnumbers": function (rich) { return rich.commands.toggleNumberingList },
			"insertlink": function (rich) { return rich.commands.openInsertHyperlinkDialog },
			"insertpicture": function (rich) { return rich.commands.openInsertPictureDialog }
		};
		function onToolbarItemClick(s, e) {
			var command = commandsTable[e.item.name].call(this, DemoRichEdit);
			command.execute();
		}
		function updateToolbar() {
			for (var key in commandsTable) {
				if (!commandsTable.hasOwnProperty(key)) continue;
				updateToolbarItem(key, commandsTable[key].call(this, DemoRichEdit));
			}
		}
		function updateToolbarItem(itemName, command) {
			var item = DemoToolbar.GetItemByName(itemName);
			var state = command.getState();
			item.SetEnabled(state.enabled);
			item.SetChecked(state.value);
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxMenu runat="server" ID="DemoToolbar" ClientInstanceName="DemoToolbar" ShowAsToolbar="true">
		<ClientSideEvents ItemClick="onToolbarItemClick" />
		<Items>
			<dx:MenuItem Name="bold" GroupName="bold">
				<Image IconID="format_bold_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem Name="italic" GroupName="italic">
				<Image IconID="format_italic_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem Name="underline" GroupName="underline">
				<Image IconID="format_underline_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem Name="strikeout" GroupName="strikeout">
				<Image IconID="format_strikeout_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem BeginGroup="true" Name="alignleft" GroupName="align">
				<Image IconID="format_alignleft_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem Name="aligncenter" GroupName="align">
				<Image IconID="format_aligncenter_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem Name="alignright" GroupName="align">
				<Image IconID="format_alignright_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem Name="listbullets" GroupName="list">
				<Image IconID="format_listbullets_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem Name="listnumbers" GroupName="list">
				<Image IconID="format_listnumbers_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem BeginGroup="true" Name="insertlink">
				<Image IconID="businessobjects_bolocalization_16x16"></Image>
			</dx:MenuItem>
			<dx:MenuItem Name="insertpicture">
				<Image IconID="content_image_16x16"></Image>
			</dx:MenuItem>
		</Items>
	</dx:ASPxMenu>
	<dx:ASPxRichEdit ID="DemoRichEdit" runat="server" ClientInstanceName="DemoRichEdit"
		Width="100%" ShowConfirmOnLosingChanges="false" RibbonMode="None">
		<ClientSideEvents SelectionChanged="updateToolbar" DocumentChanged="updateToolbar" EndCallback="updateToolbar" />
	</dx:ASPxRichEdit>
</asp:Content>