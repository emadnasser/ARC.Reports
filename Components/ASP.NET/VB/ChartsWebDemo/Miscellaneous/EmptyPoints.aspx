<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EmptyPoints.aspx.vb" Inherits="EmptyPoints" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">            
			<table style="width: 100%;">
				<tr>
					<td class="NoWrap"><dx:ASPxLabel ID="lblViewType" runat="server" Text="View Type:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td style="width: 100%;">
						<dx:ASPxComboBox ID="cbViewType" runat="server" Width="150px" ValueType="System.String">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;ViewType&quot;); }" />
						</dx:ASPxComboBox>
					</td>                    
					<td>
						<dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="100px">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
		ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback">
		<Titles>
			<dx:ChartTitle Text="News Website Popularity "></dx:ChartTitle>
		</Titles>
		<SeriesSerializable>
			<dx:Series Name="Politics" ArgumentScaleType="DateTime">
				<Points>
					<dx:SeriesPoint Values="65" ArgumentSerializable="11/01/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="78" ArgumentSerializable="11/02/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="95" ArgumentSerializable="11/03/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="110" ArgumentSerializable="11/04/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="108" ArgumentSerializable="11/05/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="52" ArgumentSerializable="11/06/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="46" ArgumentSerializable="11/07/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="70" ArgumentSerializable="11/08/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="86" ArgumentSerializable="11/09/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="92" ArgumentSerializable="11/10/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="108" ArgumentSerializable="11/11/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="115" ArgumentSerializable="11/12/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="75" ArgumentSerializable="11/13/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="65" ArgumentSerializable="11/14/2016 00:00:00.000"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:LineSeriesView></dx:LineSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Entertainment" ArgumentScaleType="DateTime">
				<Points>
					<dx:SeriesPoint Values="56" ArgumentSerializable="11/01/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="45" ArgumentSerializable="11/02/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="70" ArgumentSerializable="11/03/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="82" ArgumentSerializable="11/04/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="80" ArgumentSerializable="11/05/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="20" ArgumentSerializable="11/06/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="10" ArgumentSerializable="11/07/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="11/08/2016 00:00:00.000" IsEmpty="True"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="11/09/2016 00:00:00.000" IsEmpty="True"></dx:SeriesPoint>
					<dx:SeriesPoint Values="65" ArgumentSerializable="11/10/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="45" ArgumentSerializable="11/11/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="56" ArgumentSerializable="11/12/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="10" ArgumentSerializable="11/13/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="0" ArgumentSerializable="11/14/2016 00:00:00.000"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:LineSeriesView></dx:LineSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Travel" ArgumentScaleType="DateTime">
				<Points>
					<dx:SeriesPoint Values="45" ArgumentSerializable="11/01/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="40" ArgumentSerializable="11/02/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="56" ArgumentSerializable="11/03/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="47" ArgumentSerializable="11/04/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="38" ArgumentSerializable="11/05/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="31" ArgumentSerializable="11/06/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="27" ArgumentSerializable="11/07/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="37" ArgumentSerializable="11/08/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="42" ArgumentSerializable="11/09/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="11/10/2016 00:00:00.000" IsEmpty="True"></dx:SeriesPoint>
					<dx:SeriesPoint Values="37" ArgumentSerializable="11/11/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="21" ArgumentSerializable="11/12/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="10" ArgumentSerializable="11/13/2016 00:00:00.000"></dx:SeriesPoint>
					<dx:SeriesPoint Values="5" ArgumentSerializable="11/14/2016 00:00:00.000"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:LineSeriesView></dx:LineSeriesView>
				</ViewSerializable>
			</dx:Series>
		</SeriesSerializable>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="Date" VisibleInPanesSerializable="-1">                     
					<GridLines Visible="True"></GridLines>
					<Label TextPattern="{A:m}">
					</Label>
				</AxisX>
				<AxisY Title-Text="Number of visitors" Title-Visibility="True" VisibleInPanesSerializable="-1" Interlaced="True">                     
					<GridLines MinorVisible="True"></GridLines>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
		<BorderOptions Visibility="False" />
	</dx:WebChartControl>
</asp:Content>