<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LinearGauge.aspx.vb" Inherits="LinearGaugePage" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function Gauge1Changed() {
			OnChanged("Gauge1");
			OnChangedLogarithmic();
		}        
		function Gauge2Changed() { OnChanged("Gauge2"); }
		function Gauge3Changed() { OnChanged("Gauge3"); }
		function Gauge1EndCallback() { OnEndCallback('Gauge1'); }
		function Gauge2EndCallback() { OnEndCallback('Gauge2'); }
		function Gauge3EndCallback() { OnEndCallback('Gauge3'); }
		function OnChangedLogarithmic() {
			if (logarithmicScale.GetCheckState() == "Checked")
				value1.SetMaxValue(100);
			else
				value1.SetMaxValue(10);
		}
		//
		var isDirty;
		function PerformCallbackCore(gaugeName) {
			var gauge = window[gaugeName];
			isDirty = gauge.InCallback();
			if (!isDirty)
				gauge.PerformCallback();
		}
		function OnChanged(gaugeName) {
			PerformCallbackCore(gaugeName);
		}
		function OnEndCallback(gaugeName) {
			if (isDirty)
				window.setTimeout(function() { PerformCallbackCore(gaugeName) }, 0);
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentHolder">
	<dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%">
		<TabPages>
			<dx:TabPage Text="Scale Features">
				<ContentCollection>
					<dx:ContentControl runat="server">
						<dx:ASPxGaugeControl runat="server" Width="300px" Height="350px" BackColor="Transparent" ClientInstanceName="Gauge1" SaveStateOnCallbacks="False"
							OnCustomCallback="OnGauge1CustomCallback" ID="gControl_Page1">
							<ClientSideEvents EndCallback="Gauge1EndCallback" />
							<Gauges>
								<dx:LinearGauge Bounds="0, 0, 300, 350" ID="lGauge1">
									<scales>
													<dx:LinearScaleComponent AppearanceTickmarkText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"
														EndPoint="62.5, 20" MajorTickCount="6" MajorTickmark-FormatString="{0:F1}" MajorTickmark-ShapeOffset="6"
														MajorTickmark-ShapeType="Linear_Style1_1" MajorTickmark-TextOffset="35" MaxValue="10"
														MinorTickCount="3" MinorTickmark-ShapeOffset="6" MinorTickmark-ShapeType="Linear_Style1_2"
														Name="linearScaleComponent1" StartPoint="62.5, 230">
													</dx:LinearScaleComponent>
												</scales>
									<levels>
													<dx:LinearScaleLevelComponent Name="linearScaleLevelComponent1" ScaleID="linearScaleComponent1"
														ShapeType="Style1" ZOrder="-50" />
												</levels>
									<backgroundlayers>
													<dx:LinearScaleBackgroundLayerComponent Name="linearScaleBackgroundLayerComponent1"
														ScaleEndPos="0.5, 0.08" ScaleID="linearScaleComponent1" ScaleStartPos="0.5, 0.92"
														ShapeType="Linear_Style1" ZOrder="1000" />
												</backgroundlayers>
								</dx:LinearGauge>
							</Gauges>
						</dx:ASPxGaugeControl>
						<dx:ASPxRoundPanel runat="server" ID="ASPxRoundPanel1" ShowHeader="false" style="float: right">
							<PanelCollection>
								<dx:PanelContent runat="server">
									<table  class="OptionsTable">
										<tr>
											<td class="ActionMainLabel">
												<dx:ASPxLabel EnableViewState="False" ID="Label1" runat="server" CssClass="DemoLabel NoLeftIndent" Text="Tickmarks" />
											</td>
										</tr>
										<tr>
											<td>
												Major Tickmark Count:
											</td>
											<td>
												<dx:ASPxSpinEdit ID="majorTickCountEdit" runat="server" MaxValue="16" MinValue="6" Number="6" Width="100px" AllowNull="False">
													<ClientSideEvents NumberChanged="Gauge1Changed" />
												</dx:ASPxSpinEdit>
											</td>
										</tr>
										<tr>
											<td>
												Minor Tickmark Count:
											</td>
											<td>
												<dx:ASPxSpinEdit ID="minorTickCountEdit" runat="server" MaxValue="10" MinValue="1" Number="3" Width="100px" AllowNull="False">
													<ClientSideEvents NumberChanged="Gauge1Changed" />
												</dx:ASPxSpinEdit>
											</td>
										</tr>
										<tr>
											<td>
												Major Tickmark Offset:
											</td>
											<td>
												<dx:ASPxSpinEdit ID="majorTickOffset" runat="server" MaxValue="25" MinValue="-50" Number="6" Width="100px" NumberType="Float"
													Increment="0.5" LargeIncrement="2.5" SpinButtons-ShowLargeIncrementButtons="true" AllowNull="False">
													<ClientSideEvents NumberChanged="Gauge1Changed" />
												</dx:ASPxSpinEdit>
											</td>
										</tr>
										<tr>
											<td>
												Minor Tickmark Offset:
											</td>
											<td>
												<dx:ASPxSpinEdit ID="minorTickOffset" runat="server" MaxValue="25" MinValue="-50" Number="6" Width="100px" NumberType="Float"
													Increment="0.5" LargeIncrement="2.5" SpinButtons-ShowLargeIncrementButtons="true" AllowNull="False">
													<ClientSideEvents NumberChanged="Gauge1Changed" />
												</dx:ASPxSpinEdit>
											</td>
										</tr>
										<tr>
											<td style="height: 12px"></td>
										</tr>
										<tr>
											<td class="ActionMainLabel">
												<dx:ASPxLabel EnableViewState="False" ID="Label2" runat="server" CssClass="DemoLabel NoLeftIndent" Text="Text" />
											</td>
										</tr>
										<tr>
											<td>
												Text Offset:
											</td>
											<td>
												<dx:ASPxSpinEdit ID="textOffset" runat="server" MaxValue="50" MinValue="-50" Number="35" Width="100px" NumberType="Float"
													Increment="0.5" LargeIncrement="2.5" SpinButtons-ShowLargeIncrementButtons="true" AllowNull="False">
													<ClientSideEvents NumberChanged="Gauge1Changed" />
												</dx:ASPxSpinEdit>
											</td>
										</tr>
										<tr>
											<td>
												Text Orientation:
											</td>
											<td>
												<dx:ASPxComboBox ID="textOrientation" runat="server" Width="100px" ValueType="System.Int32" SelectedIndex="1">
													<Items>
														<dx:ListEditItem Text="Default" Value="0" />
														<dx:ListEditItem Text="LeftToRight" Value="3" />
														<dx:ListEditItem Text="BottomToTop" Value="4" />
														<dx:ListEditItem Text="TopToBottom" Value="5" />
													</Items>
													<ClientSideEvents SelectedIndexChanged="Gauge1Changed" />
												</dx:ASPxComboBox>
											</td>
										</tr>
										<tr>
											<td style="height: 12px"></td>
										</tr>
										<tr>
											<td class="ActionMainLabel">
												<dx:ASPxLabel EnableViewState="False" ID="Label3" runat="server" CssClass="DemoLabel NoLeftIndent" Text="Scale" />
											</td>
										</tr>
										<tr>
											<td>
												Value:
											</td>
											<td>
												<dx:ASPxSpinEdit ID="value1" ClientInstanceName="value1" runat="server" MinValue="0" Number="0" Width="100px" NumberType="Float" Increment="0.25"
													LargeIncrement="1" SpinButtons-ShowLargeIncrementButtons="true" AllowNull="False">
													<ClientSideEvents NumberChanged="Gauge1Changed" />
												</dx:ASPxSpinEdit>
											</td>
										</tr>
										<tr>
											<td>
												Logarithmic Scale:
											</td>
											<td>
												<dx:ASPxCheckBox ClientInstanceName="logarithmicScale" runat="server"  ID="logarithmicScale">
												<ClientSideEvents CheckedChanged="Gauge1Changed" />
												</dx:ASPxCheckBox>
											</td>
										</tr>
									</table>
								</dx:PanelContent>
							</PanelCollection>
						</dx:ASPxRoundPanel>
					</dx:ContentControl>
				</ContentCollection>
			</dx:TabPage>
			<dx:TabPage Text="RangeBar &amp; Marker Features">
				<ContentCollection>
					<dx:ContentControl runat="server">
						<dx:ASPxGaugeControl runat="server" Width="300px" Height="350px" BackColor="Transparent" ID="gControl_Page2" ClientInstanceName="Gauge2"
							SaveStateOnCallbacks="false" OnCustomCallback="OnGauge2CustomCallback">
							<ClientSideEvents EndCallback="Gauge2EndCallback" />
							<Gauges>
								<dx:LinearGauge Bounds="0, 0, 300, 350" ID="lGauge2">
									<scales>
													<dx:LinearScaleComponent AppearanceTickmarkText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"
														EndPoint="62.5, 20" MajorTickCount="6" MajorTickmark-FormatString="{0:F1}" MajorTickmark-ShapeOffset="6"
														MajorTickmark-ShapeType="Linear_Style1_1" MajorTickmark-TextOffset="35" MaxValue="10"
														MinorTickCount="3" MinorTickmark-ShapeOffset="6" MinorTickmark-ShapeType="Linear_Style1_2"
														Name="linearScaleComponent2" StartPoint="62.5, 230" Value="4">
													</dx:LinearScaleComponent>
												</scales>
									<backgroundlayers>
													<dx:LinearScaleBackgroundLayerComponent Name="linearScaleBackgroundLayerComponent2"
														ScaleEndPos="0.5, 0.08" ScaleID="linearScaleComponent2" ScaleStartPos="0.5, 0.92"
														ShapeType="Linear_Style1" ZOrder="1000" />
												</backgroundlayers>
									<rangebars>
													<dx:LinearScaleRangeBarComponent AppearanceRangeBar-BorderBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:#8080FF&quot;/&gt;"
														AppearanceRangeBar-ContentBrush="&lt;BrushObject Type=&quot;LinearGradient&quot; Data=&quot;Geometry[Start:0, 0;End:10, 10] Colors[Start:;End:#8080FF]&quot;/&gt;"
														EndOffset="-10" Name="linearScaleRangeBarComponent2" ScaleID="linearScaleComponent2"
														StartOffset="-20" ZOrder="-100" />
												</rangebars>
									<markers>
													<dx:LinearScaleMarkerComponent Name="linearScaleMarkerComponent1" ScaleID="linearScaleComponent2"
														ShapeType="Diamond" ZOrder="-150" />
												</markers>
								</dx:LinearGauge>
							</Gauges>
						</dx:ASPxGaugeControl>
						<dx:ASPxRoundPanel ID="ASPxRoundPanel2" runat="server" ShowHeader="False" style="float: right">
							<PanelCollection>
								<dx:PanelContent runat="server">
									<table  class="OptionsTable">
										<tr>
											<td class="ActionMainLabel">
												<dx:ASPxLabel EnableViewState="False" ID="ASPxLabel3" runat="server" CssClass="DemoLabel NoLeftIndent" Text="Scale" />
											</td>
										</tr>
										<tr>
											<td>
												Value:
											</td>
											<td>
												<dx:ASPxSpinEdit ID="value2" runat="server" MaxValue="10" MinValue="0" Number="4" Width="120px" NumberType="Float" Increment="0.25"
													LargeIncrement="1" SpinButtons-ShowLargeIncrementButtons="true" AllowNull="False">
													<ClientSideEvents NumberChanged="Gauge2Changed" />
												</dx:ASPxSpinEdit>
											</td>
										</tr>
										<tr>
											<td style="height: 12px"></td>
										</tr>
										<tr>
											<td class="ActionMainLabel">
												<dx:ASPxLabel EnableViewState="False" ID="ASPxLabel4" runat="server" CssClass="DemoLabel NoLeftIndent" Text="Range Bar" />
											</td>
										</tr>
										<tr>
											<td>
												Anchor Value:
											</td>
											<td>
												<dx:ASPxSpinEdit ID="anchorValue" runat="server" MaxValue="10" MinValue="0" Number="0" Width="120px" NumberType="Float" Increment="0.25"
													LargeIncrement="1" SpinButtons-ShowLargeIncrementButtons="true" AllowNull="False">
													<ClientSideEvents NumberChanged="Gauge2Changed" />
												</dx:ASPxSpinEdit>
											</td>
										</tr>
										<tr>
											<td>
												Start Offset:
											</td>
											<td>
												<dx:ASPxSpinEdit ID="startOffset" runat="server" MaxValue="50" MinValue="-50" Number="-20" Width="120px" NumberType="Float"
													Increment="1" LargeIncrement="5" SpinButtons-ShowLargeIncrementButtons="true" AllowNull="False">
													<ClientSideEvents NumberChanged="Gauge2Changed" />
												</dx:ASPxSpinEdit>
											</td>
										</tr>
										<tr>
											<td>
												End Offset:
											</td>
											<td>
												<dx:ASPxSpinEdit ID="endOffset" runat="server" MaxValue="50" MinValue="-50" Number="-10" Width="120px" NumberType="Float"
													Increment="1" LargeIncrement="5" SpinButtons-ShowLargeIncrementButtons="true" AllowNull="False">
													<ClientSideEvents NumberChanged="Gauge2Changed" />
												</dx:ASPxSpinEdit>
											</td>
										</tr>
										<tr>
											<td style="height: 12px"></td>
										</tr>
										<tr>
											<td class="ActionMainLabel">
												<dx:ASPxLabel EnableViewState="False" ID="ASPxLabel1" runat="server" CssClass="DemoLabel NoLeftIndent" Text="Marker" />
											</td>
										</tr>
										<tr>
											<td>
												Marker Offset:
											</td>
											<td>
												<dx:ASPxSpinEdit ID="markerOffset" runat="server" MaxValue="25" MinValue="-25" Number="0" Width="120px" NumberType="Float"
													Increment="1" LargeIncrement="5" SpinButtons-ShowLargeIncrementButtons="true" AllowNull="False">
													<ClientSideEvents NumberChanged="Gauge2Changed" />
												</dx:ASPxSpinEdit>
											</td>
										</tr>
										<tr>
											<td>
												Marker Shape:
											</td>
											<td>
												<dx:ASPxComboBox ID="markerShape" runat="server" SelectedIndex="5" Width="120px" ValueType="System.Int32">
													<Items>
														<dx:ListEditItem Text="Default" Value="0" />
														<dx:ListEditItem Text="TriangleLeft" Value="1" />
														<dx:ListEditItem Text="SliderLeft" Value="2" />
														<dx:ListEditItem Text="Circle" Value="3" />
														<dx:ListEditItem Text="WedgeLeft" Value="4" />
														<dx:ListEditItem Text="Diamond" Value="5" />
														<dx:ListEditItem Text="ArrowLeft" Value="6" />
														<dx:ListEditItem Text="Box" Value="7" />
														<dx:ListEditItem Text="Star" Value="8" />
														<dx:ListEditItem Text="Button" Value="9" />
														<dx:ListEditItem Text="SnowFlake" Value="10" />
														<dx:ListEditItem Text="TriangleRight" Value="11" />
														<dx:ListEditItem Text="SliderRight" Value="12" />
														<dx:ListEditItem Text="WedgeRight" Value="13" />
														<dx:ListEditItem Text="ArrowRight" Value="14" />
													</Items>
													<ClientSideEvents SelectedIndexChanged="Gauge2Changed" />
												</dx:ASPxComboBox>
											</td>
										</tr>
									</table>
								</dx:PanelContent>
							</PanelCollection>
						</dx:ASPxRoundPanel>
					</dx:ContentControl>
				</ContentCollection>
			</dx:TabPage>
			<dx:TabPage Text="StateIndicators &amp; Labels &amp; Ranges Features">
				<ContentCollection>
					<dx:ContentControl runat="server">
						<dx:ASPxGaugeControl runat="server" Width="300px" Height="350px" BackColor="Transparent" ID="gControl_Page3" ClientInstanceName="Gauge3"
							SaveStateOnCallbacks="false" OnCustomCallback="OnGauge3CustomCallback">
							<ClientSideEvents EndCallback="Gauge3EndCallback" />
							<Gauges>
								<dx:LinearGauge Bounds="0, 0, 300, 350" ID="lGauge3">
									<scales>
													<dx:LinearScaleComponent AppearanceTickmarkText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;"
														EndPoint="62.5, 20" MajorTickCount="6" MajorTickmark-FormatString="{0:F1}" MajorTickmark-ShapeOffset="6"
														MajorTickmark-ShapeType="Linear_Style1_1" MajorTickmark-TextOffset="35" MaxValue="10"
														MinorTickCount="3" MinorTickmark-ShapeOffset="6" MinorTickmark-ShapeType="Linear_Style1_2"
														Name="linearScaleComponent3" StartPoint="62.5, 230" Value="0">
														<Labels>
															<dx:ScaleLabelWeb Name="Label0" Position="15, 125" Size="70, 20" TextOrientation="BottomToTop"
																AppearanceText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:infotext&quot;/&gt;"
																AppearanceBackground-ContentBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:infobackground&quot;/&gt;"
																AppearanceBackground-BorderBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:infotext&quot;/&gt;">
															</dx:ScaleLabelWeb>
														</Labels>
														<Ranges>
															<dx:LinearScaleRangeWeb Name="Range0" EndValue="4" StartThickness="-8" EndThickness="-15"
																ShapeOffset="-10" AppearanceRange-ContentBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Green&quot;/&gt;" />
															<dx:LinearScaleRangeWeb Name="Range1" StartValue="4" EndValue="7.25" StartThickness="-15"
																EndThickness="-20" ShapeOffset="-10" AppearanceRange-ContentBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Yellow&quot;/&gt;" />
															<dx:LinearScaleRangeWeb Name="Range2" StartValue="7.25" EndValue="10" StartThickness="-20"
																EndThickness="-25" ShapeOffset="-10" AppearanceRange-ContentBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Red&quot;/&gt;" />
														</Ranges>
													</dx:LinearScaleComponent>
												</scales>
									<levels>
													<dx:LinearScaleLevelComponent Name="linearScaleLevelComponent3" ScaleID="linearScaleComponent3"
														ShapeType="Style1" ZOrder="-50" />
												</levels>
									<backgroundlayers>
													<dx:LinearScaleBackgroundLayerComponent Name="linearScaleBackgroundLayerComponent3"
														ScaleEndPos="0.5, 0.08" ScaleID="linearScaleComponent3" ScaleStartPos="0.5, 0.92"
														ShapeType="Linear_Style1" ZOrder="1000" />
												</backgroundlayers>
									<indicators>
													<dx:LinearScaleStateIndicatorComponent Name="linearScaleStateIndicatorComponent3"
														ScaleID="linearScaleComponent3" Center="25,225" ZOrder="-100">
														<States>
															<dx:ScaleIndicatorStateWeb StartValue="0" IntervalLength="4" Name="State0" ShapeType="ElectricLight4" />
															<dx:ScaleIndicatorStateWeb StartValue="4" IntervalLength="3" Name="State1" ShapeType="ElectricLight3" />
															<dx:ScaleIndicatorStateWeb StartValue="7" IntervalLength="3" Name="State2" ShapeType="ElectricLight2" />
														</States>
													</dx:LinearScaleStateIndicatorComponent>
												</indicators>
								</dx:LinearGauge>
							</Gauges>
						</dx:ASPxGaugeControl>
						<dx:ASPxRoundPanel ID="ASPxRoundPanel3" runat="server" ShowHeader="False" style="float: right">
							<PanelCollection>
								<dx:PanelContent runat="server">
									<table  class="OptionsTable">
										<tr>
											<td class="ActionMainLabel">
												<dx:ASPxLabel EnableViewState="False" ID="ASPxLabel6" runat="server" CssClass="DemoLabel NoLeftIndent" Text="Scale" />
											</td>
										</tr>
										<tr>
											<td>
												Value:
											</td>
											<td>
												<dx:ASPxSpinEdit ID="value3" runat="server" MaxValue="10" MinValue="0" Number="0" Width="120px" NumberType="Float" Increment="0.25"
													LargeIncrement="1" SpinButtons-ShowLargeIncrementButtons="true" AllowNull="False">
													<ClientSideEvents NumberChanged="Gauge3Changed" />
												</dx:ASPxSpinEdit>
											</td>
										</tr>
									</table>
								</dx:PanelContent>
							</PanelCollection>
						</dx:ASPxRoundPanel>
					</dx:ContentControl>
				</ContentCollection>
			</dx:TabPage>
		</TabPages>
	</dx:ASPxPageControl>
</asp:Content>