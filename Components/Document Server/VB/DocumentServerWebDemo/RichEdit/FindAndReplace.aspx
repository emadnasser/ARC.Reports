<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FindAndReplace.aspx.vb"
	Inherits="RichEdit_FindAndReplace" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.OptionsTable > tbody > tr > td
		{
			height: 45px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<script type="text/javascript">
		// <![CDATA[
		function UpdatePreview(action, e) {
			var txbFindValue = tbFind.GetValue();
			var txbReplaceValue = tbReplace.GetValue();
			var previewFrame = document.getElementById("previewFrame");
			previewFrame.src = "FindAndReplace.aspx?preview" +
													"&find=" + encodeURIComponent(txbFindValue) +
													"&replace=" + encodeURIComponent(txbReplaceValue) +
													"&action=" + encodeURIComponent(action);
			e.processOnServer = false;
		}
		// ]]> 
	</script>
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Demo Options">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">
				<table class="OptionsTable" style="width:100%;">
					<tr>
						<td>
							<table style="height: 40px; float: left;">
					<tr>
						<td style="height: 26px;">
							<dx:ASPxLabel ID="lblFind" runat="server" Text="Find: " AssociatedControlID="tbFind">
							</dx:ASPxLabel>
						</td>
						<td colspan="2">
							<dx:ASPxTextBox ID="tbFind" ClientInstanceName="tbFind"
								runat="server" Width="230px" />
						</td>
						<td style="text-align:right;">
						</td>
					</tr>
					<tr>
						<td style="height: 26px; width: 80px;">
							<dx:ASPxLabel ID="lblReplace" runat="server" Text="Replace with:" AssociatedControlID="tbReplace"
								Style="margin-right: 7px;">
							</dx:ASPxLabel>
						</td>
						<td colspan="2">
							<dx:ASPxTextBox ID="tbReplace" ClientInstanceName="tbReplace"
								runat="server" Width="230px" />
						</td>
						<td style="text-align:right;">
						</td>
					</tr>
					<tr>
						<td>
						</td>
						<td>
							<dx:ASPxButton ID="btnFindAll" runat="server" Text="Find All">
								<ClientSideEvents Click="function(s, e) { UpdatePreview('find',e); }" />
							</dx:ASPxButton>
						</td>
						<td style="text-align:right;">
							<dx:ASPxButton ID="btnReplaceAll" runat="server" Text="Replace All">
								<ClientSideEvents Click="function(s, e) { UpdatePreview('replace',e); }" />
							</dx:ASPxButton>
						</td>
					</tr>
				</table>
				<table style="height: 40px; float: right">
					<tr>
						<td style="height: 26px;" colspan="3"></td>
					</tr>
					<tr>
						<td style="height: 26px;" colspan="3"></td>
					</tr>
					<tr>
						<td>
							<dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="File&nbsp;Type: " AssociatedControlID="cbDownloadType"
								Style="margin-right: 7px;">
							</dx:ASPxLabel>
						</td>
						<td>
							<dx:ASPxComboBox ID="cbDownloadType" runat="server" ValueType="System.Int32" SelectedIndex="0"
								ClientInstanceName="cbDownloadType" Width="215px" Style="margin-right: 9px;">
								<Items>
									<dx:ListEditItem Text="Rich Text Format (*.rtf)" Value="1" />
									<dx:ListEditItem Text="Microsoft Word Document (*.doc)" Value="2" />
									<dx:ListEditItem Text="Word 2007 Document (*.docx)" Value="3" />
									<dx:ListEditItem Text="Portable Document Format (*.pdf)" Value="4" />
									<dx:ListEditItem Text="Text Files (*.txt)" Value="5" />
									<dx:ListEditItem Text="Web Archive, single file (*.mht)" Value="6" />
									<dx:ListEditItem Text="OpenDocument Text Document (*.odt)" Value="7" />
									<dx:ListEditItem Text="Word XML Document (*.xml)" Value="8" />
									<dx:ListEditItem Text="Electronic Publication (*.epub)" Value="9" />
								</Items>
							</dx:ASPxComboBox>
						</td>
						<td>
							<dx:ASPxButton ID="ASPxButton1" runat="server" Text="Download" OnClick="OnBtnExportClick" />
						</td>
					</tr>
				</table>
						</td>
					</tr>
				</table>      

			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<br />
	<iframe id="previewFrame" src="FindAndReplace.aspx?preview"
		style="width: 100%; height: 400px; border: 2px solid rgb(224, 224, 224);" class="PreviewArea"></iframe>
</asp:Content>