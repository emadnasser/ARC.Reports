<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FullStackedLine3DSeries.aspx.vb" Inherits="FullStackedLine3DSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">   
			<table style="width: 100%;">
				<tr>
					<td>
						<dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show&nbsp;Labels" ClientInstanceName="chbShowLabels">
						<ClientSideEvents CheckedChanged="function(s, e) {
							chart.PerformCallback(&quot;ShowLabels&quot;);
							chbValueAsPercent.SetEnabled(chbShowLabels.GetChecked());
						}" />
						</dx:ASPxCheckBox>
					</td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td style="width: 100%">
						<dx:ASPxCheckBox ID="cbValueAsPercent" runat="server" Text="Value As Percent" Width="120px" ClientInstanceName="chbValueAsPercent">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ValueAsPercent&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblPerspectiveAngle" runat="server" Text="Perspective Angle:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbPerspectiveAngle" runat="server" Width="70px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;PerspectiveAngle&quot;); }" />
						</dx:ASPxComboBox>
					</td>                            
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblZoomPercent" runat="server" Text="Zoom Percent:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbZoomPercent" runat="server" Width="50px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;ZoomPercent&quot;); }" />
						</dx:ASPxComboBox>
					</td>                                            
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
		ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback"
		DataSourceID="chartDataSource" SeriesDataMember="Company">
		<SeriesTemplate  ArgumentDataMember="Year" ValueDataMembersSerializable="Sales" LabelsVisibility="False">
			<ViewSerializable>
				<dx:FullStackedLine3DSeriesView></dx:FullStackedLine3DSeriesView>
			</ViewSerializable>
			<LabelSerializable>
				<dx:StackedLine3DSeriesLabel TextPattern="{VP:P0}">
				</dx:StackedLine3DSeriesLabel>
			</LabelSerializable>
		</SeriesTemplate>
		<BorderOptions Visibility="False"></BorderOptions>
		<DiagramSerializable>
			<dx:XYDiagram3D RotationType="UseAngles" RotationOrder="XYZ" RotationAngleY="-20" ZoomPercent="140">
				<AxisX>
					<DateTimeScaleOptions MeasureUnit="Year" GridAlignment="Year"  GridSpacing="2"/>                     
				</AxisX>
				<AxisY>
					<Label TextPattern="{V:P0}">
					</Label>
					<WholeRange AlwaysShowZeroLevel="False" AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
				</AxisY>
			</dx:XYDiagram3D>
		</DiagramSerializable>
		<Legend Direction="BottomToTop"></Legend>
		<Titles>
			<dx:ChartTitle Text="Market Share Over Time"></dx:ChartTitle>
		</Titles>
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetBranchesSales"></asp:ObjectDataSource>
</asp:Content>