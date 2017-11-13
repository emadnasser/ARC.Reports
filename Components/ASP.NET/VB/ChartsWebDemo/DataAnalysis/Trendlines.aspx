<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Trendlines.aspx.vb" Inherits="Trendlines" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
		ClientInstanceName="chart" DataSourceID="chartDataSource">
		<SeriesSerializable>
			<dx:Series Name="Apple Inc." ArgumentScaleType="DateTime" LabelsVisibility="False"
				ArgumentDataMember="Date" ValueDataMembersSerializable="Low;High;Open;Close">
				<ViewSerializable>
					<dx:StockSeriesView LevelLineLength="0.3"></dx:StockSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:StockSeriesLabel ResolveOverlappingMode="Default"></dx:StockSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<BorderOptions Visibility="False"></BorderOptions>
		<Titles>
			<dx:ChartTitle Text="Stock Prices"></dx:ChartTitle>
			<dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.quandl.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX VisibleInPanesSerializable="-1" Interlaced="True">
					<GridLines Visible="True"></GridLines>
					<DateTimeScaleOptions GridAlignment="Month" WorkdaysOnly="True" AutoGrid="False" GridSpacing="0.5">
					</DateTimeScaleOptions>
				</AxisX>
				<AxisY Title-Text="US Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1">
					<WholeRange AlwaysShowZeroLevel="False" ></WholeRange>
					<GridLines MinorVisible="True"></GridLines>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="MarketPrices" SelectMethod="GetAppleStockPrices"></asp:ObjectDataSource>    
</asp:Content>