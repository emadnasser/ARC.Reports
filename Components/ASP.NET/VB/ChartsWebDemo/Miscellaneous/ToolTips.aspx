<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ToolTips.aspx.vb" Inherits="ToolTips" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">            
			<table style="width: 38%;">
				<tr style="height: 25px;">
					<td class="NoWrap"><dx:ASPxLabel ID="lblOpenMode" runat="server" Text="Open Mode:" ClientInstanceName="lblOpenMode"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td style="width: 100%;">
						<dx:ASPxComboBox ID="cbOpenMode" runat="server" ValueType="System.String" Width="80px" ClientInstanceName="cbOpenMode" >
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;OpenMode&quot;); }" />
						</dx:ASPxComboBox>
					</td>
					<td style="width: 100%;"><dx:ASPxLabel ID="lblPosition" runat="server" Text="Position:" ClientInstanceName="lblPosition"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbPosition" runat="server" ValueType="System.String" Width="80px" ClientInstanceName="cbPosition" >
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Position&quot;); }" />
						</dx:ASPxComboBox>
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="480px"
		Width="700px" ClientInstanceName="chart" SeriesDataMember="LastName" CssClass="AlignCenter TopLargeMargin"
		DataSourceID="AccessDataSource1"
		OnBoundDataChanged="WebChartControl1_BoundDataChanged"
		OnCustomCallback="WebChartControl1_CustomCallback"
		CrosshairEnabled="False" ToolTipEnabled="True">
		<SeriesTemplate ArgumentDataMember="OrderDate" ArgumentScaleType="DateTime" SummaryFunction="SUM([Freight])" ToolTipHintDataMember="FirstName" ToolTipPointPattern="Name: {HINT} {S}&lt;br /&gt;&lt;br /&gt;Year: {A:yyyy}&lt;br /&gt;Total sales: {V}">
			<ViewSerializable>
				<dx:SideBySideBarSeriesView></dx:SideBySideBarSeriesView>
			</ViewSerializable>
			<LabelSerializable>
				<dx:SideBySideBarSeriesLabel ResolveOverlappingMode="Default"></dx:SideBySideBarSeriesLabel>
			</LabelSerializable>
		</SeriesTemplate>
		<Legend Visibility="False"></Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Sales Volume by Year"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="Date" VisibleInPanesSerializable="-1">
					<DateTimeScaleOptions MeasureUnit="Year" GridAlignment="Year" />                     
					<Label TextPattern="{A:yyyy}">
					</Label>
				</AxisX>
				<AxisY Title-Text="Thousands of Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1">
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
	<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
		SelectCommand="SELECT Orders.OrderDate, Orders.Freight, Employees.LastName, Employees.FirstName, Employees.Photo FROM (Orders INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID)">
	</asp:AccessDataSource>
</asp:Content>