<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Multiselection.aspx.vb" Inherits="Multiselection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<script type="text/javascript">
		var prm = Sys.WebForms.PageRequestManager.getInstance();
		prm.add_initializeRequest(prm_InitializeRequest);
		prm.add_endRequest(prm_EndRequest);
		function prm_InitializeRequest(sender, args) {
			lp.Show();
		}
		function prm_EndRequest(sender, args) {
			lp.Hide();
		}
	</script>
	<dx:ASPxLoadingPanel ID="lp" runat="server" Modal="True" ClientInstanceName="lp"></dx:ASPxLoadingPanel>
	<asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
	<asp:UpdatePanel ID="UpdatePanel1" runat="server">
		<ContentTemplate>
			<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
				<panelcollection>
				<dx:PanelContent ID="PanelContent1" runat="server">  
					<table style="width: 100%;">
						<tr>
							<td style="width: 100%;">
								<dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" AutoPostback="True">                            
								</dx:ASPxCheckBox>
							</td>
							<td class="NoWrap"><dx:ASPxLabel ID="lblSelectionMode" runat="server" Text="Selection Mode:"/></td>
							<td><div class="Spacer" style="width: 5px;"></div></td>
							<td>
								<dx:ASPxComboBox ID="cbSelectionMode" runat="server" Width="80px"  AutoPostback="True">
								</dx:ASPxComboBox>
							</td>
						</tr>
					</table>
				</dx:PanelContent>
			</panelcollection>
			</dx:ASPxRoundPanel>
			<dx:WebChartControl ID="WebChartControlPie" EnableCallBacks="False" runat="server" Height="250px" Width="700px" CssClass="AlignCenter TopLargeMargin" CrosshairEnabled="False"
				ClientInstanceName="chartTotal" OnObjectSelected="WebChartControlPie_ObjectSelected" DataSourceID="chartDataSource1"
				SelectionMode="Multiple" SeriesSelectionMode="Point" OnSelectedItemsChanged="WebChartControlPie_SelectedItemsChanged" > 
				<titles>
					<dx:ChartTitle Text="The DevAV Company Sales Comparison"></dx:ChartTitle>
				</titles>
				<seriesserializable>
					<dx:Series 
						labelsvisibility="False"
						ArgumentDataMember="Region" 
						ValueDataMembersSerializable="Sales" 
						SummaryFunction = "SUM([Sales])" 
						LegendTextPattern = "{A} {VP:P}">
						<ViewSerializable>
							<dx:PieSeriesView></dx:PieSeriesView>
						</ViewSerializable>
					</dx:Series>
				</seriesserializable>
				<legend visibility="True"></legend>
				<diagramserializable>
					<dx:SimpleDiagram></dx:SimpleDiagram>
				</diagramserializable>
				<borderoptions visibility="False" />
			</dx:WebChartControl>
			<dx:WebChartControl ID="WebChartControlBars" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin" CrosshairEnabled="False"
				DataSourceID="chartDataSource2" SeriesDataMember="Region" OnBoundDataChanged="WebChartControlBars_BoundDataChanged"
				ClientInstanceName="chart" SettingsLoadingPanel-Enabled="false">
				<seriestemplate labelsvisibility="False" ArgumentScaleType="Qualitative"
					argumentdatamember="Year" valuedatamembersserializable="Sales">
					<ViewSerializable>
						<dx:SideBySideBarSeriesView></dx:SideBySideBarSeriesView>
					</ViewSerializable>
					<LabelSerializable>
						<dx:SideBySideBarSeriesLabel TextPattern="{V:N2}">
						</dx:SideBySideBarSeriesLabel>
					</LabelSerializable>
				</seriestemplate>
				<legend visibility="False"></legend>
				<diagramserializable>
					<dx:XYDiagram>
						<AxisX VisibleInPanesSerializable="-1">
						</AxisX>
						<AxisY Title-Text="Millions of Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1">                    
							<GridLines MinorVisible="True"></GridLines>
						</AxisY>
					</dx:XYDiagram>
				</diagramserializable>
				<emptycharttext text="" />
				<smallcharttext text="Increase the chart's size, to view its layout." />
				<borderoptions visibility="False" />
				<SettingsLoadingPanel Enabled="False" />
			</dx:WebChartControl>
		</ContentTemplate>
	</asp:UpdatePanel>
	<asp:ObjectDataSource ID="chartDataSource1" runat="server" TypeName="DevAV" SelectMethod="GetSales"></asp:ObjectDataSource>
	<asp:ObjectDataSource ID="chartDataSource2" runat="server" TypeName="DevAV" SelectMethod="GetSales"></asp:ObjectDataSource>
</asp:Content>