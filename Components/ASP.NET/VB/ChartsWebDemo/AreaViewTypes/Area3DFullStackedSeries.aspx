<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Area3DFullStackedSeries.aspx.vb" Inherits="Area3DFullStackedSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">  
			<table style="width: 100%;">
				<tr>
					<td style="width: 100%;">
						<dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblTransparency" runat="server" Text="Transparency:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbTransparency" runat="server" Width="50px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Transparency&quot;); }" />
						</dx:ASPxComboBox>
					</td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
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
				<dx:FullStackedArea3DSeriesView></dx:FullStackedArea3DSeriesView>
			</ViewSerializable>
			<LabelSerializable>
				<dx:FullStackedArea3DSeriesLabel TextPattern="{VP:P0}">
				</dx:FullStackedArea3DSeriesLabel>
			</LabelSerializable>
		</SeriesTemplate>
		<Legend Direction="BottomToTop"></Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Market Share Over Time"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram3D RotationMatrixSerializable="0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.342020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;1" ZoomPercent="140" VerticalScrollPercent="4">
				<AxisX>
					<Label Position="Left"></Label>                    
					<GridLines Visible="True"></GridLines>
					<DateTimeScaleOptions MeasureUnit="Year" GridAlignment="Year" GridSpacing="2"/>
				</AxisX>
				<AxisY>
					<Label TextPattern="{V:P0}">
					</Label>
					<WholeRange AlwaysShowZeroLevel="False" AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
				</AxisY>
			</dx:XYDiagram3D>
		</DiagramSerializable>
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetBranchesSales"></asp:ObjectDataSource>
</asp:Content>