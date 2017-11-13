<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomDrawLegend.aspx.vb" Inherits="CustomDrawLegend" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="480px"
		Width="700px" ClientInstanceName="chart" SeriesDataMember="LastName" CssClass="AlignCenter TopLargeMargin"
		DataSourceID="AccessDataSource1"
		OnCustomDrawSeries="WebChartControl1_CustomDrawSeries" CrosshairEnabled="False"
		ToolTipEnabled="False">
		<SeriesTemplate ArgumentDataMember="OrderDate" ArgumentScaleType="DateTime" SummaryFunction="SUM([Freight])">
			<ViewSerializable>
				<dx:SideBySideBarSeriesView></dx:SideBySideBarSeriesView>
			</ViewSerializable>
		</SeriesTemplate>
		<Legend BackColor="Transparent" HorizontalIndent="5" TextVisible="False" VerticalIndent="5">
			<Border Visibility="False" />
			<Padding Bottom="0" Left="0" Right="0" Top="0" />
		</Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Sales Volume by Year"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="Date" VisibleInPanesSerializable="-1">
					<DateTimeScaleOptions MeasureUnit="Year" GridAlignment="Year"/>                    
					<Label TextPattern="{A:yyyy}">
					</Label>
				</AxisX>
				<AxisY Title-Text="Thousands of Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1">                    
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
	<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
		SelectCommand="SELECT Orders.OrderDate, Orders.Freight, Employees.LastName, Employees.Photo FROM (Orders INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID)">
	</asp:AccessDataSource>
</asp:Content>