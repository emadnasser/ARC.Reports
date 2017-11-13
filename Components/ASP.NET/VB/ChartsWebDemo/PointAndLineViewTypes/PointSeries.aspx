<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PointSeries.aspx.vb" Inherits="PointSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">    
			<table style="width: 100%;">
				<tr>
					<td><dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="95px" ClientInstanceName="chbShowLabels">
						<ClientSideEvents CheckedChanged="function(s, e) {
	chart.PerformCallback(&quot;ShowLabels&quot;);
	var enableLabelAngle = chbShowLabels.GetChecked() && cmbLabelPosition.GetCurrentValue() == 'Outside';
	labelLabelAngle.SetEnabled(enableLabelAngle);
	cmbLabelAngle.SetEnabled(enableLabelAngle);
	labelLabelPosition.SetEnabled(chbShowLabels.GetChecked());
	cmbLabelPosition.SetEnabled(chbShowLabels.GetChecked());
}" />
					</dx:ASPxCheckBox></td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblLabelAngle" runat="server" Text="Label Angle:" ClientInstanceName="labelLabelAngle"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbLabelAngle" runat="server" Width="80px" ValueType="System.String" ClientInstanceName="cmbLabelAngle">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;LabelAngle&quot;); }" />
						</dx:ASPxComboBox>
					</td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblMarkerKind" runat="server" Text="Marker Kind:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td style="width: 100%;">
						<dx:ASPxComboBox ID="cbMarkerKind" runat="server" Width="130px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerKind&quot;); }" />
						</dx:ASPxComboBox>
					</td>
					<td>
						<dx:ASPxButton ID="btnCreatePoints" runat="server" Text="Create Points" Width="140px" AutoPostBack="False">
							<ClientSideEvents Click="function(s, e) { chart.PerformCallback(&quot;CreatePoints&quot;); }" />
						</dx:ASPxButton>
					</td>
				</tr>
				<tr>
					<td><div class="Spacer" style="width: 100%;height: 5px"></div></td>
				</tr>
				<tr>
					<td><div class="Spacer"></div></td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblLabelPosition" runat="server" Text="Label Position:" ClientInstanceName="labelLabelPosition"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbLabelPosition" runat="server" Width="80px" ValueType="System.String" SelectedIndex="1" ClientInstanceName="cmbLabelPosition">
							<Items>
								<dx:ListEditItem Text="Center" Value="Center" />
								<dx:ListEditItem Text="Outside" Value="Outside" />
							</Items>
							<ClientSideEvents SelectedIndexChanged="function(s, e) {
									chart.PerformCallback(&quot;LabelPosition&quot;);
									var enableLabelAngle = chbShowLabels.GetChecked() && cmbLabelPosition.GetCurrentValue() == 'Outside';
									labelLabelAngle.SetEnabled(enableLabelAngle);
									cmbLabelAngle.SetEnabled(enableLabelAngle);
								}" />
						</dx:ASPxComboBox>
					</td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblMarkerSize" runat="server" Text="Marker Size:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td style="width: 100%;">
						<dx:ASPxComboBox ID="cbMarkerSize" runat="server" Width="130px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerSize&quot;); }" />
						</dx:ASPxComboBox>
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
		Width="700px" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
		OnCustomCallback="WebChartControl1_CustomCallback" EnableClientSideAPI="True"
		ToolTipEnabled="False">
		<SeriesSerializable>
			<dx:Series Name="Population 1" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:PointSeriesLabel Font="Tahoma, 6pt"></dx:PointSeriesLabel>
				</LabelSerializable>
			</dx:Series>
			<dx:Series Name="Population 2" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:PointSeriesLabel Font="Tahoma, 6pt"></dx:PointSeriesLabel>
				</LabelSerializable>
			</dx:Series>
			<dx:Series Name="Population 3" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:PointSeriesLabel Font="Tahoma, 6pt"></dx:PointSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Random Points Generator"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX VisibleInPanesSerializable="-1">

					<GridLines Visible="True" MinorVisible="True"></GridLines>
				</AxisX>
				<AxisY VisibleInPanesSerializable="-1" MinorCount="4">

					<GridLines MinorVisible="True"></GridLines>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
		<CrosshairOptions CrosshairLabelMode="ShowForNearestSeries"/>
	</dx:WebChartControl>
</asp:Content>