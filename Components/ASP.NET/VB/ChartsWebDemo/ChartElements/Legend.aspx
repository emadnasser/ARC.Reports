<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Legend.aspx.vb" Inherits="LegendDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">  
			<table style="width: 100%;">
				<tr>
					<td class="NoWrap"><dx:ASPxLabel ID="lblHorAlignment" runat="server" Text="Horizontal Alignment:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>                                        
					<td>                    
						<dx:ASPxComboBox ID="cbHorAlignment" runat="server" Width="100px" ValueType="System.String">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;HorAligment&quot;); }" />
						</dx:ASPxComboBox>                        
					</td>
					<td><div class="Spacer" style="width: 20px;"></div></td>                    
					<td class="NoWrap CheckBoxLeftIndentCorrect"><dx:ASPxLabel ID="lblDirection" runat="server" Text="Direction:"/></td>                    
					<td><div class="Spacer" style="width: 5px;"></div></td>                    
					<td>
						<dx:ASPxComboBox ID="cbDirection" runat="server" ValueType="System.String" Width="110px" ClientInstanceName="cmbDirection">
							<ClientSideEvents SelectedIndexChanged="function(s, e) {
	chbEquallySpacedItems.SetEnabled(cmbDirection.GetSelectedIndex() &gt; 1);
	chart.PerformCallback(&quot;Direction&quot;);
}" />
						</dx:ASPxComboBox>                        
					</td>                    
					<td style="width: 100%;"><div class="Spacer"></div></td>                    
					<td class="NoWrap">
						<dx:ASPxLabel ID="lblHorizontalPercentage" runat="server" Text="Max Horizontal Percentage:"/>                        
					</td>                    
					<td><div class="Spacer" style="width: 5px;"></div></td>                    
					<td>
						<dx:ASPxComboBox ID="cbMaxHorPercentage" runat="server" ValueType="System.String" Width="65px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MaxHorPrctg&quot;); }" />
						</dx:ASPxComboBox>                        
					</td>
				</tr>
				<tr>
					<td><div class="Spacer" style="height: 10px;"></div></td>
				</tr>
				<tr>
					<td class="NoWrap"><dx:ASPxLabel ID="lblVertAlignment" runat="server" Text="Vertical Alignment:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>

					<td>
						<dx:ASPxComboBox ID="cbVertAlignment" runat="server" Width="100px" ValueType="System.String">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;VerAligment&quot;); }" />
						</dx:ASPxComboBox>
					</td>
					<td><div class="Spacer" style="width: 20px;"></div></td>
					<td colspan="3">
						<table>
							<tr>
								<td>
									<dx:ASPxCheckBox ID="chbEquallySpaced" runat="server" Text="Equally Spaced Items" ClientInstanceName="chbEquallySpacedItems">
										<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;EqSpaced&quot;); }" Init="function(s, e) { chbEquallySpacedItems.SetEnabled(cmbDirection.GetSelectedIndex() &gt; 1); }" />
									</dx:ASPxCheckBox>                                    
								</td>                                
							</tr>
						</table>
					</td>
					<td><div class="Spacer"></div></td>
					<td><dx:ASPxLabel ID="lblVerticalPercentage" runat="server" Text="Max Vertical Percentage:"/></td>
					<td><div class="Spacer" style="width: 5px;"></div></td>
					<td>
						<dx:ASPxComboBox ID="cbMaxVertPercentage" runat="server" ValueType="System.String" Width="65px">
							<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MaxVerPrctg&quot;); }" />
						</dx:ASPxComboBox>                        
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
		Width="700px" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
		OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="False"
		ToolTipEnabled="False">
		<SeriesSerializable>
			<dx:Series Name="Series Name 1" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Long Series Name 1" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Very Long Series Name 1" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Very Long Series Name 2" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Long Series Name 2" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Series Name 2" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Series Name 3" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Long Series Name 3" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Very Long Series Name 3" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Very Long Series Name 4" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Long Series Name 4" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
			</dx:Series>
			<dx:Series Name="Series Name 4" ArgumentScaleType="Numerical">
				<ViewSerializable>
					<dx:PointSeriesView></dx:PointSeriesView>
				</ViewSerializable>
			</dx:Series>
		</SeriesSerializable>
		<Legend MaxHorizontalPercentage="50" MaxVerticalPercentage="50"></Legend>
		<BorderOptions Visibility="False" />
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="" VisibleInPanesSerializable="-1" Interlaced="True">
					<GridLines Visible="True"></GridLines>
					<Label/>
				</AxisX>
				<AxisY Title-Text="" Title-Visibility="True" VisibleInPanesSerializable="-1" MinorCount="4">                    
					<GridLines Visible="False"></GridLines>
				</AxisY>
			</dx:XYDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
</asp:Content>