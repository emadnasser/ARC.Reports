<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HorizontalPanes.aspx.vb" Inherits="HorizontalPanes" %>
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
					<td class="NoWrap"><dx:ASPxLabel ID="lblLeftCategory" runat="server" Text="Left Category:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbLeftCategory" runat="server" Width="110px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;LeftCategory&quot;); }" />
						</dx:ASPxComboBox>
					</td>
					<td><div class="Spacer" style="width: 10px;"></div></td>
					<td class="NoWrap"><dx:ASPxLabel ID="lblRightCategory" runat="server" Text="Right Category:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbRightCategory" runat="server" Width="110px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;RightCategory&quot;); }" />
						</dx:ASPxComboBox>
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="480px"
		Width="700px" DataSourceID="AccessDataSource1" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
		OnCustomCallback="WebChartControl1_CustomCallback">
		<SeriesSerializable>
			<dx:Series Name="Series 1" ArgumentDataMember="ProductName" ValueDataMembersSerializable="UnitPrice" SeriesPointsSorting="Ascending" SeriesPointsSortingKey="Value_1">
				<DataFilters>
					<dx:DataFilter ColumnName="CategoryID" DataType="System.Int32"></dx:DataFilter>
				</DataFilters>
				<ViewSerializable>
					<dx:SideBySideBarSeriesView></dx:SideBySideBarSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Series 2" ArgumentDataMember="ProductName" ValueDataMembersSerializable="UnitPrice" SeriesPointsSorting="Ascending" SeriesPointsSortingKey="Value_1">
				<DataFilters>
					<dx:DataFilter ColumnName="CategoryID" DataType="System.Int32"></dx:DataFilter>
				</DataFilters>
				<ViewSerializable>
					<dx:SideBySideBarSeriesView PaneName="Pane 1" AxisXName="secondaryAxisX1"></dx:SideBySideBarSeriesView>
				</ViewSerializable>
			</dx:Series>
		</SeriesSerializable>
		<Legend AlignmentHorizontal="Right" AlignmentVertical="TopOutside" Direction="LeftToRight"></Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Northwind Traders: Comparative Categories Chart" Font="Tahoma, 16pt"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram PaneLayoutDirection="Horizontal">
				<AxisX Title-Visibility="True" VisibleInPanesSerializable="-1">
					<Label Angle="-90"></Label>                    
				</AxisX>
				<AxisY Title-Text="Price, USD" Title-Visibility="True" VisibleInPanesSerializable="-1;0" Interlaced="True">                    
				</AxisY>
				<SecondaryAxesX>
					<dx:SecondaryAxisX AxisID="0" Alignment="Near" Title-Visibility="True" VisibleInPanesSerializable="0" Name="secondaryAxisX1">
						<Label Angle="-90"></Label>                        
					</dx:SecondaryAxisX>
				</SecondaryAxesX>
				<Panes>
					<dx:XYDiagramPane PaneID="0" Name="Pane 1"></dx:XYDiagramPane>
				</Panes>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
	<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
		SelectCommand="SELECT * FROM [Products]">
	</asp:AccessDataSource>
</asp:Content>