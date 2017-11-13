<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSideAPI.aspx.vb"
	Inherits="TabControl_ClientSideAPI" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function InitPageControl() {
			var tab = PageControl.GetActiveTab();
			cbTabs.SetValue(tab.name);
			ShowProperty();
			ShowTabContent(tab);
		}
		function ActiveTabChanged(e) {
			var tab = GetTabByValue();
			if (e.tab.name == tab.name)
				chbActive.SetChecked(true);
			else
				chbActive.SetChecked(false);
			ShowTabContent(e.tab)
		}
		function TabClick(e) {
			cbTabs.SetValue(e.tab.name);
			ShowProperty();
			ShowTabContent(e.tab)
		}
		function ShowTabContent(tab) {
			mContent.SetText(ASPxClientUtils.Trim(PageControl.GetTabContentHTML(tab)));
		}
		function ApplyActiveTabContent() {
			var tab = PageControl.GetActiveTab();
			PageControl.SetTabContentHTML(tab, mContent.GetText());
		}
		function ChangeListTab() {
			ShowProperty();
		}
		function ShowProperty() {
			var tab = GetTabByValue();
			var activeTab = PageControl.GetActiveTab();
			chbEnabled.SetChecked(tab.GetEnabled());
			chbVisible.SetChecked(tab.GetVisible());
			if (!activeTab)
				chbActive.SetChecked(false);
			else if (activeTab.name == tab.name)
				chbActive.SetChecked(true);
			else
				chbActive.SetChecked(false);
		}
		function ToggleEnabled() {
			GetTabByValue().SetEnabled(chbEnabled.GetChecked());
			ShowProperty();
		}
		function ToggleVisible() {
			GetTabByValue().SetVisible(chbVisible.GetChecked());
			ShowProperty();
		}
		function ToggleActive() {
			PageControl.SetActiveTab(GetTabByValue());
			ShowProperty();
		}
		function GetTabByValue() {
			return PageControl.GetTabByName(cbTabs.GetValue());
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxPageControl ClientInstanceName="PageControl" Width="100%" ID="PageControl"
		runat="server" ActiveTabIndex="0" EnableViewState="False" EnableHierarchyRecreation="True">
		<ClientSideEvents Init="function(s, e) { InitPageControl(); }" ActiveTabChanged="function(s, e) { ActiveTabChanged(e); }"
			TabClick="function(s, e) { TabClick(e); }"></ClientSideEvents>
		<TabPages>
			<dx:TabPage Name="page1" Text="Page 1">
				<ContentCollection>
					<dx:ContentControl runat="server">
						<div style="padding-top: 24px; font: 18pt Trebuchet MS;">
							<b>Page Content</b> <span style="color: red;">Sample</span></div>
					</dx:ContentControl>
				</ContentCollection>
			</dx:TabPage>
			<dx:TabPage Name="page2" Text="Page 2">
				<ContentCollection>
					<dx:ContentControl runat="server">
						<div style="padding-top: 24px; font: 24pt Trebuchet MS;">
							<b>Page Content</b> <span style="color: green;">Sample</span></div>
					</dx:ContentControl>
				</ContentCollection>
			</dx:TabPage>
			<dx:TabPage Name="page3" Text="Page 3">
				<ContentCollection>
					<dx:ContentControl runat="server">
						<div style="padding-top: 24px; font: 32pt Trebuchet MS;">
							<b>Page Content</b> <span style="color: blue;">Sample</span></div>
					</dx:ContentControl>
				</ContentCollection>
			</dx:TabPage>
		</TabPages>
	</dx:ASPxPageControl>
	<table class="OptionsTable" style="margin-top: 20px">
		<tr>
			<td>
				<dx:ASPxLabel runat="server" Text="Choose page:" ID="lblTabs" AssociatedControlID="cbTabs">
				</dx:ASPxLabel>
			</td>
			<td>
				<dx:ASPxComboBox EnableViewState="False" Width="120px" ID="cbTabs" ClientInstanceName="cbTabs"
					runat="server">
					<ClientSideEvents SelectedIndexChanged="function(s, e) { ChangeListTab(); }"></ClientSideEvents>
				</dx:ASPxComboBox>
			</td>
		</tr>
		<tr>
			<td>
			</td>
			<td>
				<dx:ASPxCheckBox ID="chbEnabled" ClientInstanceName="chbEnabled" Checked="true" runat="server"
					Text="Enabled">
					<ClientSideEvents CheckedChanged="function(s, e) { ToggleEnabled(); }"></ClientSideEvents>
				</dx:ASPxCheckBox>
			</td>
		</tr>
		<tr>
			<td>
			</td>
			<td>
				<dx:ASPxCheckBox CssClass="CodeLabel" ID="chbVisible" ClientInstanceName="chbVisible"
					Checked="true" runat="server" Text="Visible">
					<ClientSideEvents CheckedChanged="function(s, e) { ToggleVisible(); }"></ClientSideEvents>
				</dx:ASPxCheckBox>
			</td>
		</tr>
		<tr>
			<td>
			</td>
			<td>
				<dx:ASPxCheckBox CssClass="CodeLabel" ID="chbActive" Checked="true" ClientInstanceName="chbActive"
					Text="Active" runat="server">
					<ClientSideEvents CheckedChanged="function(s, e) { ToggleActive(); }"></ClientSideEvents>
				</dx:ASPxCheckBox>
			</td>
		</tr>
		<tr>
			<td>
			</td>
			<td>
				<div class="TopPadding">HTML code to be used as the active page's content:</div>
				<dx:ASPxMemo ID="mContent" runat="server" Height="130px" Width="617px" ClientInstanceName="mContent" style="margin:4px 0">
				</dx:ASPxMemo>
				<dx:ASPxButton ID="btnApply" Text="Apply" runat="server" CssClass="DemoButton" AutoPostBack="False"
					ClientInstanceName="btnApply">
					<ClientSideEvents Click="function(s, e) { ApplyActiveTabContent(); }"></ClientSideEvents>
				</dx:ASPxButton>
			</td>
		</tr>
	</table>
</asp:Content>