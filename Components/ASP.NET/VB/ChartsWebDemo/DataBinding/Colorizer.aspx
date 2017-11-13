<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Colorizer.aspx.vb" Inherits="ColorizerControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div>
		<dx:WebChartControl ID="chart" ClientInstanceName="chart" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin" CrosshairEnabled="False" ToolTipEnabled="True">
			<BorderOptions Visibility="False" />
			<diagramserializable>
				<dx:XYDiagram>
					<axisx visibleinpanesserializable="-1">
						<tickmarks minorvisible="False" />
						<wholerange autosidemargins="False" sidemarginsvalue="0.5" />
					</axisx>
					<axisy title-text="GDP per capita, $" title-visibility="True" visibleinpanesserializable="-1">
						<numericscaleoptions autogrid="False" gridalignment="Thousands" gridspacing="10" />
					</axisy>
				</dx:XYDiagram>
			</diagramserializable>
			<seriesserializable>
				<dx:Series Name="Series 1" ShowInLegend="False" ToolTipPointPattern="{A}
GDP per capita: {V:n2}$
Population: {W:n2} Ml
HPI: {HINT}">
					<viewserializable>
						<dx:BubbleSeriesView MaxSize="1.4" MinSize="0.6" Transparency="90">
						</dx:BubbleSeriesView>
					</viewserializable>
					<labelserializable>
						<dx:BubbleSeriesLabel TextPattern="{W} Ml">
						</dx:BubbleSeriesLabel>
					</labelserializable>
				</dx:Series>
			</seriesserializable>
			<titles>
				<dx:ChartTitle Text="Happy Planet Index for G20" />
			</titles>
		</dx:WebChartControl>
	</div>
</asp:Content>