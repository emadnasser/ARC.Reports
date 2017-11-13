<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MovingItems.aspx.vb"
	Inherits="ASPxListBox_MovingItems" Title="Untitled Page" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function AddSelectedItems() {
			MoveSelectedItems(lbAvailable, lbChoosen);
			UpdateButtonState();
		}
		function AddAllItems() {
			MoveAllItems(lbAvailable, lbChoosen);
			UpdateButtonState();
		}
		function RemoveSelectedItems() {
			MoveSelectedItems(lbChoosen, lbAvailable);
			UpdateButtonState();
		}
		function RemoveAllItems() {
			MoveAllItems(lbChoosen, lbAvailable);
			UpdateButtonState();
		}
		function MoveSelectedItems(srcListBox, dstListBox) {
			srcListBox.BeginUpdate();
			dstListBox.BeginUpdate();
			var items = srcListBox.GetSelectedItems();
			for(var i = items.length - 1; i >= 0; i = i - 1) {
				dstListBox.AddItem(items[i].text, items[i].value);
				srcListBox.RemoveItem(items[i].index);
			}
			srcListBox.EndUpdate();
			dstListBox.EndUpdate();
		}
		function MoveAllItems(srcListBox, dstListBox) {
			srcListBox.BeginUpdate();
			var count = srcListBox.GetItemCount();
			for(var i = 0; i < count; i++) {
				var item = srcListBox.GetItem(i);
				dstListBox.AddItem(item.text, item.value);
			}
			srcListBox.EndUpdate();
			srcListBox.ClearItems();
		}
		function UpdateButtonState() {
			btnMoveAllItemsToRight.SetEnabled(lbAvailable.GetItemCount() > 0);
			btnMoveAllItemsToLeft.SetEnabled(lbChoosen.GetItemCount() > 0);
			btnMoveSelectedItemsToRight.SetEnabled(lbAvailable.GetSelectedItems().length > 0);
			btnMoveSelectedItemsToLeft.SetEnabled(lbChoosen.GetSelectedItems().length > 0);
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGlobalEvents ID="GlobalEvents" runat="server">
		<ClientSideEvents ControlsInitialized="function(s, e) { UpdateButtonState(); }" />
	</dx:ASPxGlobalEvents>
	<table style="width: 100%">
		<tr>
			<td style="width: 35%">
				<dx:ASPxListBox ID="lbAvailable" runat="server" ClientInstanceName="lbAvailable"
					Width="100%" Height="240px" SelectionMode="CheckColumn" Caption="Available">
					<CaptionSettings Position="Top" />
					<Items>
						<dx:ListEditItem Text="ASPxEditors Library" Value="ASPxEditors" />
						<dx:ListEditItem Text="ASPxGauges Suite" Value="ASPxGauges" />
						<dx:ListEditItem Text="ASPxGridView and Editors Suite" Value="ASPxGridView and Editors" />
						<dx:ListEditItem Text="ASPxHTMLEditor Suite" Value="ASPxHTMLEditor" />
						<dx:ListEditItem Text="ASPxperience Suite" Value="ASPxperience" />
						<dx:ListEditItem Text="ASPxPivotGrid Suite" Value="ASPxPivotGrid" />
						<dx:ListEditItem Text="ASPxScheduler Suite" Value="ASPxScheduler" />
						<dx:ListEditItem Text="ASPxSpellChecker" Value="ASPxSpellChecker" />
						<dx:ListEditItem Text="ASPxTreeList Suite" Value="ASPxTreeList" />
						<dx:ListEditItem Text="XtraReports Suite" Value="XtraReports" />
						<dx:ListEditItem Text="XtraCharts Suite" Value="XtraCharts" />
					</Items>
					<ClientSideEvents SelectedIndexChanged="function(s, e) { UpdateButtonState(); }" />
				</dx:ASPxListBox>
			</td>
			<td style="padding: 100px 60px;">
				<div>
					<dx:ASPxButton ID="btnMoveSelectedItemsToRight" runat="server" ClientInstanceName="btnMoveSelectedItemsToRight"
						AutoPostBack="False" Text="Add >" Width="130px" ClientEnabled="False"
						ToolTip="Add selected items">
						<ClientSideEvents Click="function(s, e) { AddSelectedItems(); }" />
					</dx:ASPxButton>
				</div>
				<div class="TopPadding">
					<dx:ASPxButton ID="btnMoveAllItemsToRight" runat="server" ClientInstanceName="btnMoveAllItemsToRight"
						AutoPostBack="False" Text="Add All >>" Width="130px" ToolTip="Add all items">
						<ClientSideEvents Click="function(s, e) { AddAllItems(); }" />
					</dx:ASPxButton>
				</div>
				<div style="height: 32px">
				</div>
				<div>
					<dx:ASPxButton ID="btnMoveSelectedItemsToLeft" runat="server" ClientInstanceName="btnMoveSelectedItemsToLeft"
						AutoPostBack="False" Text="< Remove" Width="130px" ClientEnabled="False"
						ToolTip="Remove selected items">
						<ClientSideEvents Click="function(s, e) { RemoveSelectedItems(); }" />
					</dx:ASPxButton>
				</div>
				<div class="TopPadding">
					<dx:ASPxButton ID="btnMoveAllItemsToLeft" runat="server" ClientInstanceName="btnMoveAllItemsToLeft"
						AutoPostBack="False" Text="<< Remove All" Width="130px" ClientEnabled="False"
						ToolTip="Remove all items">
						<ClientSideEvents Click="function(s, e) { RemoveAllItems(); }" />
					</dx:ASPxButton>
				</div>
			</td>
			<td style="width: 35%">
				<dx:ASPxListBox ID="lbChoosen" runat="server" ClientInstanceName="lbChoosen" Width="100%"
					Height="240px" SelectionMode="CheckColumn" Caption="Chosen">
					<CaptionSettings Position="Top" />
					<ClientSideEvents SelectedIndexChanged="function(s, e) { UpdateButtonState(); }">
					</ClientSideEvents>
				</dx:ASPxListBox>
			</td>
		</tr>
	</table>
</asp:Content>