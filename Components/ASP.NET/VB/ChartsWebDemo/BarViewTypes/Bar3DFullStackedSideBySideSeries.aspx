<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Bar3DFullStackedSideBySideSeries.aspx.vb"
	Inherits="Bar3DFullStackedSideBySideSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">
				<table style="width: 100%;">
					<tr>
						<td style="width: 100%;">
							<dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" ClientInstanceName="cbShowLabels">
								<ClientSideEvents CheckedChanged="function(s, e) { 
					chart.PerformCallback(&quot;ShowLabels&quot;); 
					cbValueAsPercent.SetEnabled(cbShowLabels.GetChecked());
				}" />
							</dx:ASPxCheckBox>
						</td>
						<td class="NoWrap">
							<dx:ASPxLabel ID="lblGroup" runat="server" Text="Group Series by:" />
						</td>
						<td>
							<div class="Spacer" style="width: 5px;">
							</div>
						</td>
						<td>
							<dx:ASPxRadioButton ID="rbSex" runat="server" Text="Sex" GroupName="GroupBy" ClientInstanceName="rbSex">
								<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;&quot;); }" />
							</dx:ASPxRadioButton>
						</td>
						<td>
							<div class="Spacer" style="width: 5px;">
							</div>
						</td>
						<td>
							<dx:ASPxRadioButton ID="rbAge" runat="server" GroupName="GroupBy" Text="Age" ClientInstanceName="rbAge">
								<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;&quot;); }" />
							</dx:ASPxRadioButton>
						</td>
						<td>
							<div class="Spacer" style="width: 20px;">
							</div>
						</td>
						<td class="NoWrap">
							<dx:ASPxLabel ID="lblPerspectiveAngle" runat="server" Text="Perspective Angle:" />
						</td>
						<td>
							<div class="Spacer" style="width: 5px;">
							</div>
						</td>
						<td>
							<dx:ASPxComboBox ID="cbPerspectiveAngle" runat="server" Width="70px">
								<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;PerspectiveAngle&quot;); }" />
							</dx:ASPxComboBox>
						</td>
					</tr>
					<tr>
						<td>
							<div class="Spacer" style="width: 100%; height: 5px;">
							</div>
						</td>
					</tr>
					<tr>
						<td class="NoWrap" style="width: 100%;">
							<dx:ASPxCheckBox ID="cbValueAsPercent" runat="server" Text="Value As Percent" ClientInstanceName="cbValueAsPercent">
								<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ValueAsPercent&quot;); }" />
							</dx:ASPxCheckBox>
						</td>
						<td colspan="6">
						</td>
						<td class="NoWrap">
							<dx:ASPxLabel ID="lblZoomPercent" runat="server" Text="Zoom Percent:" />
						</td>
						<td>
							<div class="Spacer" style="width: 5px;">
							</div>
						</td>
						<td>
							<dx:ASPxComboBox ID="cbZoomPercent" runat="server" Width="70px">
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
		SeriesDataMember="GenderAge" OnBoundDataChanged="WebChartControl1_BoundDataChanged"
		DataSourceID="chartDataSource">
		<Titles>
			<dx:ChartTitle Text="Population: Age Structure"></dx:ChartTitle>
			<dx:ChartTitle Text="Data estimate for end-2016" Font="Tahoma, 12pt"></dx:ChartTitle>
			<dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.cia.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
		</Titles>
		<SeriesTemplate  ArgumentDataMember="Country" ValueDataMembersSerializable="Population" LabelsVisibility="False">
			<ViewSerializable>
				<dx:SideBySideFullStackedBar3DSeriesView></dx:SideBySideFullStackedBar3DSeriesView>
			</ViewSerializable>
			<LabelSerializable>
				<dx:Bar3DSeriesLabel TextPattern="{VP:P0}">
				</dx:Bar3DSeriesLabel>
			</LabelSerializable>
		</SeriesTemplate>
		<DiagramSerializable>
			<dx:XYDiagram3D RotationMatrixSerializable="0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.342020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;1" ZoomPercent="140" VerticalScrollPercent="6" RuntimeRotation="True" RuntimeZooming="True" RuntimeScrolling="True">
				<AxisX>
					<Label MaxWidth="60"></Label>
				</AxisX>
				<AxisY>
					<Label TextPattern="{VP:P0}">
					</Label>
				</AxisY>
			</dx:XYDiagram3D>
		</DiagramSerializable>
		<BorderOptions Visibility="False" />
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="AgeStructure" SelectMethod="GetDataByAgeAndGender"></asp:ObjectDataSource>
</asp:Content>