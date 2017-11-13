<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="XPOLargeDB.aspx.vb"
	Inherits="DataBinding_XPOLargeDB" EnableSessionState="ReadOnly" %>
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
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:CreateDatabaseControl runat="server" ID="CreateDatabaseControl" TableKey="GeneratedEmailTable" />

	<div runat="server" id="GridContainer">
		<div class="BottomPadding">
			<dx:ASPxLabel runat="server" ID="ASPxLabel1" Text="Command:" />
			<b><dx:ASPxLabel runat="server" ID="ASPxLabel2" ClientInstanceName="ClientCommandLabel" Text="..." /></b>
		</div>            

		<div style="padding-bottom: 32px">
			<dx:ASPxLabel runat="server" ID="ASPxLabel3" Text="Time taken (ms):" />
			<b><dx:ASPxLabel runat="server" ID="ASPxLabel4" ClientInstanceName="ClientTimeLabel" Text="..." /></b>
		</div>                

		<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="XpoDataSource1"
			KeyFieldName="ID" Width="100%" AutoGenerateColumns="False" OnCustomColumnDisplayText="grid_CustomColumnDisplayText" OnSummaryDisplayText="grid_SummaryDisplayText">
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
	</div>

	<dx:XpoDataSource ID="XpoDataSource1" runat="server" ServerMode="true" TypeName="XpoEmailEntity" />

</asp:Content>