<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LargeDatabase.aspx.vb"
	Inherits="DataBinding_LargeDatabase" EnableSessionState="ReadOnly" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		var start;
		function grid_Init(s, e) {
			grid.Refresh();
		}
		function grid_BeginCallback(s, e) {
			start = new Date();
			ClientCommandLabel.SetText(e.command);
			ClientTimeLabel.SetText("working...");
		}
		function grid_EndCallback(s, e) {
			ClientTimeLabel.SetText(new Date() - start);
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:CreateDatabaseControl runat="server" ID="CreateDatabaseControl" TableKey="GeneratedEmailTable" />
	<div runat="server" id="Demo">
		<div style="float: left">
			<div>
				<b>Data Source</b>
			</div>
			<div class="TopPadding">
				<dx:ASPxRadioButton runat="server" Text="EntityServerModeDataSource (DevExpress data source)"
					AutoPostBack="True" ID="rbEntityDevExpress" GroupName="DataSource" Checked="True" />
				<dx:ASPxRadioButton runat="server" Text=" EntityDataSource (standard .NET data source)"
					AutoPostBack="True" ID="rbEntityMS2008" GroupName="DataSource" />
			</div>
		</div>
		<div style="float: left; margin-left: 4%">
			<div>
				<b>Test Results</b>
			</div>
			<div class="TopPadding LeftPadding">
				<div>
					<dx:ASPxLabel runat="server" ID="ASPxLabel1" Text="Command:" />
					<b>
						<dx:ASPxLabel runat="server" ID="ASPxLabel2" ClientInstanceName="ClientCommandLabel"
							Text="..." />
					</b>
				</div>
				<div class="TopPadding">
					<dx:ASPxLabel runat="server" ID="ASPxLabel3" Text="Time taken (ms):" />
					<b>
						<dx:ASPxLabel runat="server" ID="ASPxLabel4" ClientInstanceName="ClientTimeLabel"
							Text="..." />
					</b>
				</div>
			</div>
		</div>
		<b class="Clear"></b>
		<br /><br />
		<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" KeyFieldName="ID"
			Width="100%" AutoGenerateColumns="False" OnCustomColumnDisplayText="grid_CustomColumnDisplayText"
			OnSummaryDisplayText="grid_SummaryDisplayText">
			<Columns>
				<dx:GridViewDataTextColumn FieldName="From" VisibleIndex="0" Width="200px" />
				<dx:GridViewDataTextColumn FieldName="Subject" VisibleIndex="1" />
				<dx:GridViewDataDateColumn FieldName="Sent" VisibleIndex="2" Width="100px" />
				<dx:GridViewDataCheckColumn Caption="Attachment?" FieldName="HasAttachment" VisibleIndex="3" Width="100px" />
				<dx:GridViewDataTextColumn FieldName="Size" VisibleIndex="4" Width="80px">
					<Settings AllowAutoFilter="false" />
				</dx:GridViewDataTextColumn>
			</Columns>
			<Settings ShowFilterRow="True" ShowFilterRowMenu="true" ShowGroupPanel="True" ShowFooter="True" />
			<SettingsPager>
				<PageSizeItemSettings Visible="true" Items="10, 20, 50" />
			</SettingsPager>
			<SettingsDataSecurity AllowInsert="false" AllowEdit="false" AllowDelete="false" />
			<ClientSideEvents Init="grid_Init" BeginCallback="grid_BeginCallback" EndCallback="grid_EndCallback" />
			<TotalSummary>
				<dx:ASPxSummaryItem FieldName="Size" SummaryType="Sum" />
			</TotalSummary>
			<GroupSummary>
				<dx:ASPxSummaryItem SummaryType="Count" />
			</GroupSummary>
		</dx:ASPxGridView>
		<ef:EntityDataSource ID="EntityDataSource" runat="server" ContextTypeName="LargeDatabaseContext"
			EntitySetName="Emails" />
		<dx:EntityServerModeDataSource ID="EntityServerModeDataSource" runat="server" ContextTypeName="LargeDatabaseContext"
			TableName="Emails" />
	</div>
</asp:Content>