<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BarStackedSideBySideSeries.aspx.vb" Inherits="BarStackedSideBySideSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">      
			<table style="width: 100%;">
				<tr>
					<td style="width: 100%;">
						<dx:ASPxCheckBox ID="checkBoxShowLabel" runat="server" Wrap="False" Text="Show Labels">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblLabelPosition" runat="server" Text="Group Series by:" /></td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td>
						<dx:ASPxRadioButton ID="rbSex" runat="server" Text="Sex" GroupName="GroupBy" ClientInstanceName="rbSex">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;&quot;); }" />
						</dx:ASPxRadioButton>
					</td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td>
						<dx:ASPxRadioButton ID="rbAge" runat="server" GroupName="GroupBy" Text="Age" ClientInstanceName="rbAge">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;&quot;); }" />
						</dx:ASPxRadioButton>
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
		Width="700px" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
		OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="True"
		EnableClientSideAPI="True" ToolTipEnabled="False"
		SeriesDataMember="GenderAge"
		OnBoundDataChanged="WebChartControl1_BoundDataChanged" DataSourceID="chartDataSource">
		<SeriesTemplate  ArgumentDataMember="Country" ValueDataMembersSerializable="Population" LabelsVisibility="False"
			CrosshairLabelPattern="{S}<br/>{V:0,,.0} million">
			<ViewSerializable>
				<dx:SideBySideStackedBarSeriesView></dx:SideBySideStackedBarSeriesView>
			</ViewSerializable>
			<LabelSerializable>
				<dx:FullStackedBarSeriesLabel TextPattern="{V:0,,.000}">
				</dx:FullStackedBarSeriesLabel>
			</LabelSerializable>
		</SeriesTemplate>
		<Legend AlignmentHorizontal="Right" MaxHorizontalPercentage="75">
			<Margins Bottom="10" Left="10" Right="10" Top="10" />
		</Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Population: Age Structure"></dx:ChartTitle>
			<dx:ChartTitle Text="Data estimate for end-2016" Font="Tahoma, 12pt"></dx:ChartTitle>
			<dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.cia.gov" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="Countries" VisibleInPanesSerializable="-1">

				</AxisX>
				<AxisY Title-Text="Population, millions" Title-Visibility="True" VisibleInPanesSerializable="-1" Interlaced="True">
					<Label TextPattern="{V:0,,}">
					</Label>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="AgeStructure" SelectMethod="GetDataByAgeAndGender"></asp:ObjectDataSource>
</asp:Content>