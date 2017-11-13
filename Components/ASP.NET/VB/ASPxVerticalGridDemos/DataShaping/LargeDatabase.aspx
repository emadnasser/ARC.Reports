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
		<dx:ASPxVerticalGrid ID="VerticalGrid" ClientInstanceName="grid" runat="server" KeyFieldName="ID" Width="100%" OnCustomRowDisplayText="grid_CustomRowDisplayText">
			<Rows>
				<dx:VerticalGridTextRow FieldName="From">
					<RecordStyle Font-Size="Large" Font-Bold="true" />
				</dx:VerticalGridTextRow>
				<dx:VerticalGridTextRow FieldName="Subject" />
				<dx:VerticalGridTextRow FieldName="Size" />
				<dx:VerticalGridDateRow FieldName="Sent" />
				<dx:VerticalGridCheckRow Caption="Attachment?" FieldName="HasAttachment">
					<PropertiesCheckEdit>
						<DisplayImageChecked IconID="mail_attachment_32x32" ToolTip="Has attachment" />
						<DisplayImageUnchecked IconID="mail_attachmentobject_32x32gray" ToolTip="Doesn't have attachment" />
					</PropertiesCheckEdit>
				</dx:VerticalGridCheckRow>
			</Rows>
			<Settings RecordWidth="200" HeaderAreaWidth="100" HorizontalScrollBarMode="Visible" />
			<SettingsPager PageSize="10" />
			<ClientSideEvents Init="grid_Init" BeginCallback="grid_BeginCallback" EndCallback="grid_EndCallback" />
			<Styles>
				<Record HorizontalAlign="Center" />
			</Styles>
		</dx:ASPxVerticalGrid>
		<ef:EntityDataSource ID="EntityDataSource" runat="server" ContextTypeName="LargeDatabaseContext"
			EntitySetName="Emails" />
		<dx:EntityServerModeDataSource ID="EntityServerModeDataSource" runat="server" ContextTypeName="LargeDatabaseContext"
			TableName="Emails" />
	</div>
</asp:Content>