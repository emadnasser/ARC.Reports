<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Summarization.aspx.vb" Inherits="Summarization" %>
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
					<td class="NoWrap"><dx:ASPxLabel ID="lblSummaryFunction" runat="server" Text="Summary Function:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbSummaryFunction" runat="server" Width="130px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;SummaryFunction&quot;); }" />
						</dx:ASPxComboBox>
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
		DataSourceID="AccessDataSource1" ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback" OnCallbackStateLoad="WebChartControl1_CallbackStateLoad">
		<SeriesSerializable>
			<dx:Series Name="Quantity" ArgumentDataMember="CategoryName" SummaryFunction="SUM([Sum])" LegendTextPattern="{A:F2}">
				<ViewSerializable>
					<dx:SideBySideBarSeriesView ColorEach="True"></dx:SideBySideBarSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:SideBySideBarSeriesLabel LineLength="20" TextPattern="{V:N0}">
					</dx:SideBySideBarSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="" Font="Tahoma, 14pt"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="Categories" VisibleInPanesSerializable="-1">
					<Label Staggered="True"></Label>                    
				</AxisX>
				<AxisY Title-Text="Volume (USD)" Title-Visibility="True" VisibleInPanesSerializable="-1" Interlaced="True">                    
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
	<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
		SelectCommand="SELECT  Categories.CategoryName, [Order Details].Quantity, [Order Details].UnitPrice, [Order Details].Quantity * [Order Details].UnitPrice AS [Sum]&#13;&#10;FROM  ((Categories INNER JOIN&#13;&#10; Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN&#13;&#10;  [Order Details] ON Products.ProductID = [Order Details].ProductID)">
	</asp:AccessDataSource>
</asp:Content>