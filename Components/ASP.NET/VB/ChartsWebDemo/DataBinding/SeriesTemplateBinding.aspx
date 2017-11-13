<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SeriesTemplateBinding.aspx.vb" Inherits="SeriesTemplateBinding" %>
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
					<td class="NoWrap"><dx:ASPxLabel ID="lblSeriesDataMember" runat="server" Text="Series Data Member:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbSeriesDataMember" runat="server" Width="80px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;SeriesDataMember&quot;); }" />
						</dx:ASPxComboBox>
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin" CrosshairEnabled="False"
		DataSourceID="chartDataSource" SeriesDataMember="Year"
		ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback" AlternateText="The US Regions Gross State Product chart.">
		<Titles>
			<dx:ChartTitle Text="G7 GDP, billions of US$"></dx:ChartTitle>
			<dx:ChartTitle Dock="Bottom" Alignment="Far" Text="The World Bank: GDP (current US$)" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
		</Titles>
		<SeriesTemplate LabelsVisibility="False"
			ArgumentDataMember="Country" ValueDataMembersSerializable="Product"
			CrosshairLabelPattern = "{S} : {V:F3}">
			<ViewSerializable>
				<dx:SideBySideBarSeriesView></dx:SideBySideBarSeriesView>
			</ViewSerializable>
			<LabelSerializable>
				<dx:SideBySideBarSeriesLabel TextPattern="{V:N2}">
				</dx:SideBySideBarSeriesLabel>
			</LabelSerializable>
		</SeriesTemplate>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX VisibleInPanesSerializable="-1">
					<Label Staggered="True"></Label>                    
				</AxisX>
				<AxisY VisibleInPanesSerializable="-1">                    
					<GridLines MinorVisible="True"></GridLines>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
		<BorderOptions Visibility="False" />
		<CrosshairOptions>
			<CrosshairLabelTextOptions Font="Tahoma, 10pt" />
			<GroupHeaderTextOptions Font="Tahoma, 10pt, style=Bold"/>
		</CrosshairOptions>
	</dx:WebChartControl>
	<asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="GDPofG7" SelectMethod="GetData"></asp:ObjectDataSource>
</asp:Content>