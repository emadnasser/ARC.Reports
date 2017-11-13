<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SplineArea3DSeries.aspx.vb" Inherits="SplineArea3DSeries" %>
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
		SeriesDataMember = "Company" DataSourceID="chartDataSource">
		<Legend Direction="BottomToTop"></Legend>
		<Titles>
			<dx:ChartTitle Text="Outside Vendor Costs"></dx:ChartTitle>
		</Titles>
		<SeriesTemplate  ArgumentDataMember="Year" ValueDataMembersSerializable="Costs" LabelsVisibility="True">
			<ViewSerializable>
				<dx:SplineArea3DSeriesView></dx:SplineArea3DSeriesView>
			</ViewSerializable>
		</SeriesTemplate>     
		<DiagramSerializable>
			<dx:XYDiagram3D RotationMatrixSerializable="0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.342020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;1" ZoomPercent="140" VerticalScrollPercent="8" RuntimeRotation="True" RuntimeZooming="True" RuntimeScrolling="True">
				<AxisX>
					<Label MaxWidth="70"></Label>                    
					<GridLines Visible="True"></GridLines>
					<DateTimeScaleOptions MeasureUnit="Year"/>
					<WholeRange AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
				</AxisX>
				<AxisY>
					<WholeRange AlwaysShowZeroLevel="False"></WholeRange>
					<NumericScaleOptions GridSpacing="100" AutoGrid="False"/>
					<Label TextPattern="${V}K"/>
				</AxisY>
			</dx:XYDiagram3D>
		</DiagramSerializable>
		<BorderOptions Visibility="False" />
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetOutsideVendorCosts"></asp:ObjectDataSource>
</asp:Content>