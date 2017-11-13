<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SeriesTitles.aspx.vb" Inherits="SeriesTitles" %>
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
					<td class="NoWrap"><dx:ASPxLabel ID="lblShowLabels" runat="server" Text="View Type:"/></td>                    
					<td><div class="Spacer" style="width: 5px;"></div></td>                    
					<td>
						<dx:ASPxComboBox ID="cbViewType" runat="server" Width="110px">
							<ClientSideEvents ValueChanged="function(s, e) { chart.PerformCallback(&quot;ViewType&quot;); }" />
						</dx:ASPxComboBox>
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
		Width="700px" CssClass="AlignCenter TopLargeMargin"
		OnCustomDrawSeriesPoint="WebChartControl1_CustomDrawSeriesPoint"
		ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback"
		AlternateText="DevAV Sales Mix by Region chart."
		ToolTipEnabled="False"
		SeriesDataMember="Region" DataSourceID="chartDataSource">
		<SeriesTemplate  ArgumentDataMember="ProductCategory" ValueDataMembersSerializable="Sales" DataFiltersConjunctionMode="Or" LegendTextPattern="{A}"
			LabelsVisibility="False">
			<ViewSerializable>
				<dx:PieSeriesView RuntimeExploding="False">
					<Titles>
						<dx:SeriesTitle></dx:SeriesTitle>
					</Titles>
				</dx:PieSeriesView>
			</ViewSerializable>
			<LabelSerializable>
				<dx:PieSeriesLabel Font="Tahoma, 8.25pt" TextPattern="${V:F1}M">
				</dx:PieSeriesLabel>
			</LabelSerializable>
		</SeriesTemplate>
		<Legend AlignmentHorizontal="Center" AlignmentVertical="BottomOutside" Direction="LeftToRight" MaxHorizontalPercentage="70"></Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="DevAV Sales Mix by Region"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:SimpleDiagram></dx:SimpleDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetSalesMixByRegion"></asp:ObjectDataSource>
</asp:Content>