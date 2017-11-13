<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<dx:WebChartControl ID="WebChartControl1" runat="server" CrosshairEnabled="False"
		Height="300px" Width="550px">
		<titles>
			<dx:ChartTitle Text="Historic, current and future population">
			</dx:ChartTitle>
			<dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.geohive.com" Font="Tahoma, 8pt" TextColor="Gray">
			</dx:ChartTitle>
		</titles>
		<seriesserializable>
			<dx:Series Name="Africa" LabelsVisibility="True">
				<points>
					<dx:SeriesPoint ArgumentSerializable="1950" Values="227" />
					<dx:SeriesPoint ArgumentSerializable="1970" Values="361" />
					<dx:SeriesPoint ArgumentSerializable="1990" Values="623" />
					<dx:SeriesPoint ArgumentSerializable="2010" Values="982" />
					<dx:SeriesPoint ArgumentSerializable="2030" Values="1416" />
				</points>
				<ViewSerializable>
					<dx:AreaSeriesView></dx:AreaSeriesView>
				</ViewSerializable>
			</dx:Series>
		</seriesserializable>
		<diagramserializable>
			<dx:XYDiagram>
				<AxisX VisibleInPanesSerializable="-1">
					<VisualRange AutoSideMargins="False" SideMarginsValue="0"></VisualRange>
					<WholeRange AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
				</AxisX>
				<AxisY Title-Text="Population mid-year, millions" Title-Visibility="True" />
			</dx:XYDiagram>
		</diagramserializable>
	</dx:WebChartControl>
</asp:Content>