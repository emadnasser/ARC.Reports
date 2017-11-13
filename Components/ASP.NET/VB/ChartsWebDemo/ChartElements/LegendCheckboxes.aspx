<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LegendCheckboxes.aspx.vb" Inherits="LegendCheckboxesDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel
		ID="ASPxRoundPanel1"
		runat="server"
		Width="100%"
		ShowHeader="False">
		<panelcollection>
			<dx:PanelContent 
				ID="PanelContent1" 
				runat="server">  
				<table style="width: 100%;">
					<tr>
						<td class="auto-style1">
							<dx:ASPxCheckBox 
								ID="chbUseCheckboxes" 
								runat="server" 
								CheckState="Checked" 
								ClientInstanceName="chbUseCheckboxes" 
								Text="Use Check Boxes in Legend" 
								Width="200px">
								<ClientSideEvents CheckedChanged="function(s, e) {
								chbCheckableIndicators.SetEnabled(chbUseCheckboxes.GetChecked());
								chart.PerformCallback(&quot;ChangeUseCheckboxes&quot;);
								}" />
							</dx:ASPxCheckBox>
						</td>
					</tr>
					<tr>
						<td class="auto-style1">
							<dx:ASPxCheckBox 
								ID="chbCheckableIndicators" 
								runat="server" 
								CheckState="Checked" 
								ClientInstanceName="chbCheckableIndicators" 
								Text="Checkable Indicators" 
								Width="200px">
								<ClientSideEvents CheckedChanged="function(s, e) {chart.PerformCallback(&quot;ChangeIndicatorsCheckability&quot;);}" />
							</dx:ASPxCheckBox>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</panelcollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl
		ID="WebChartControl1"
		runat="server"
		Height="400px"
		Width="700px"
		ClientInstanceName="chart"
		CssClass="AlignCenter TopLargeMargin" CrosshairEnabled="True" OnCustomCallback="WebChartControl1_CustomCallback">
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Interlaced="True" Title-Text="" 
					VisibleInPanesSerializable="-1">
					<Label/>
					<GridLines Visible="True"></GridLines>
					<DatetimeScaleOptions GridAlignment="Month" MeasureUnit="Month"></DatetimeScaleOptions>
				</AxisX>
				<AxisY MinorCount="4" Title-Text="" Title-Visibility="True" 
					VisibleInPanesSerializable="-1">
					<GridLines Visible="False"></GridLines>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
		<Legend UseCheckboxes="True"></Legend>
		<Titles>
			<dx:ChartTitle Text="Goods Sales by Years"></dx:ChartTitle>
		</Titles>
		<BorderOptions Visibility="False" />
		<SeriesSerializable>
			<dx:Series Name="Beverages">
				<Points>
					<dx:SeriesPoint ArgumentSerializable="2011" Values="46900"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2012" Values="43658"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2013" Values="42658"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2014" Values="41235"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2015" Values="42568"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2016" Values="41888"></dx:SeriesPoint>
				</Points>
			</dx:Series>
			<dx:Series Name="Dairy Products">
				<Points>
					<dx:SeriesPoint ArgumentSerializable="2011" Values="68953"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2012" Values="67456"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2013" Values="67986"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2014" Values="65326"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2015" Values="63255"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2016" Values="60223"></dx:SeriesPoint>
				</Points>
			</dx:Series>
			<dx:Series Name="Ice Cream">
				<Points>
					<dx:SeriesPoint ArgumentSerializable="2011" Values="10569"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2012" Values="15786"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2013" Values="19300"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2014" Values="18756"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2015" Values="18749"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2016" Values="20112"></dx:SeriesPoint>
				</Points>
			</dx:Series>
			<dx:Series Name="Refrigerated Meat">
				<Points>
					<dx:SeriesPoint ArgumentSerializable="2011" Values="65897"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2012" Values="62102"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2013" Values="61325"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2014" Values="55400"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2015" Values="62359"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2016" Values="65212"></dx:SeriesPoint>
				</Points>
			</dx:Series>
			<dx:Series Name="Sausage">
				<Points>
					<dx:SeriesPoint ArgumentSerializable="2011" Values="45356"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2012" Values="46893"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2013" Values="50326"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2014" Values="43268"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2015" Values="43265"></dx:SeriesPoint>
					<dx:SeriesPoint ArgumentSerializable="2016" Values="63262"></dx:SeriesPoint>
				</Points>
			</dx:Series>
		</SeriesSerializable>
	</dx:WebChartControl>
</asp:Content>
<asp:Content
	ID="Content2"
	runat="server"
	ContentPlaceHolderID="CustomHeadHolder">
	<style type="text/css">
		.auto-style1
		{
			width: 92px;
		}
	</style>
</asp:Content>