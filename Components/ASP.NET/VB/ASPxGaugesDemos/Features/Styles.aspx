<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Styles.aspx.vb" Inherits="StylesPage" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		var isDirty;
		function PerformCallbackCore() {
			var gauge = window["gauge"];
			isDirty = gauge.InCallback();
			if (!isDirty)
				gauge.PerformCallback();
		}
		function OnChanged() {
			PerformCallbackCore();
		}
		function OnEndCallback() {
			if (isDirty)
				window.setTimeout(PerformCallbackCore, 0);
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentHolder">
	<dx:ASPxGaugeControl runat="server" Width="350px" Height="350px" BackColor="Transparent" ID="gaugeControl" ClientInstanceName="gauge"
		SaveStateOnCallbacks="false">
		<ClientSideEvents EndCallback="OnEndCallback" />
		<Gauges>
			<dx:CircularGauge ID="cGauge1" Bounds="0, 0, 350, 350">
				<backgroundlayers>
								<dx:ArcScaleBackgroundLayerComponent Name="bg1" ScaleID="scale1" ZOrder="1000" ShapeType="CircularFull_Style11">
								</dx:ArcScaleBackgroundLayerComponent>
							</backgroundlayers>
				<needles>
								<dx:ArcScaleNeedleComponent EndOffset="5" StartOffset="-9.5" ScaleID="scale1" Name="needle1"
									ZOrder="-50" ShapeType="CircularFull_Style11"></dx:ArcScaleNeedleComponent>
							</needles>
				<scales>
								<dx:ArcScaleComponent Name="scale1" MaxValue="100" MinorTickmark-ShapeType="Circular_Style11_3"
									MinorTickmark-ShapeScale="0.6, 1" MinorTickmark-ShapeOffset="-2.5" Center="125, 125"
									EndAngle="60" MinorTickCount="4" MajorTickmark-TextOffset="-17" MajorTickmark-TextOrientation="LeftToRight"
									MajorTickmark-FormatString="{0:F0}" MajorTickmark-ShapeType="Circular_Style11_4"
									MajorTickmark-ShapeScale="0.6, 0.8" MajorTickmark-ShapeOffset="-5" StartAngle="-240"
									RadiusX="107" RadiusY="107" AppearanceTickmarkText-Font="Tahoma, 12pt" AppearanceTickmarkText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;">
								</dx:ArcScaleComponent>
								<dx:ArcScaleComponent ZOrder="-1" Name="scale2" MaxValue="700" MinorTickmark-ShapeType="Circular_Style11_1"
									Center="125, 125" EndAngle="-30" MajorTickCount="8" MinorTickCount="4" MajorTickmark-TextOffset="-15"
									MajorTickmark-TextOrientation="LeftToRight" MajorTickmark-FormatString="{0:F0}"
									MajorTickmark-ShapeType="Circular_Style11_2" StartAngle="-240" RadiusX="70" RadiusY="70"
									AppearanceTickmarkText-Font="Microsoft Sans Serif, 8pt, style=Bold" AppearanceTickmarkText-TextBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;">
								</dx:ArcScaleComponent>
							</scales>
			</dx:CircularGauge>
		</Gauges>
	</dx:ASPxGaugeControl>
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" ShowHeader="False" style="float: right">
		<PanelCollection>
			<dx:PanelContent runat="server">
				<table class="OptionsTable">
					<tr>
						<td>
							Style:
						</td>
						<td>
							<dx:ASPxComboBox ID="style" runat="server" SelectedIndex="22" ValueType="System.String" Width="120px">
								<ClientSideEvents SelectedIndexChanged="OnChanged" />
								<Items>
									<dx:ListEditItem Text="Africa Sunset" Value="AfricaSunset.xml" />
									<dx:ListEditItem Text="Clean White" Value="CleanWhite.xml" />
									<dx:ListEditItem Text="Dark Night" Value="DarkNight.xml" />
									<dx:ListEditItem Text="Deep Fire" Value="DeepFire.xml" />
									<dx:ListEditItem Text="Gothic Mat" Value="GothicMat.xml" />
									<dx:ListEditItem Text="Ice Cold Zone" Value="IceColdZone.xml" />
									<dx:ListEditItem Text="Mechanical" Value="Mechanical.xml" />
									<dx:ListEditItem Text="Pure Dark" Value="PureDark.xml" />
									<dx:ListEditItem Text="Shining Dark" Value="ShiningDark.xml" />
									<dx:ListEditItem Text="Silver Blur" Value="SilverBlur.xml" />
									<dx:ListEditItem Text="White" Value="White.xml" />
									<dx:ListEditItem Text="Sport Car" Value="SportCar.xml" />
									<dx:ListEditItem Text="Military" Value="Military.xml" />
									<dx:ListEditItem Text="Retro" Value="Retro.xml" />
									<dx:ListEditItem Text="Disco" Value="Disco.xml" />
									<dx:ListEditItem Text="Clever" Value="Clever.xml" />
									<dx:ListEditItem Text="Cosmic" Value="Cosmic.xml"/>
									<dx:ListEditItem Text="Smart" Value="Smart.xml"/>
									<dx:ListEditItem Text="Progressive" Value="Progressive.xml"/>
									<dx:ListEditItem Text="Eco" Value="Eco.xml"/>
									<dx:ListEditItem Text="Magic Light" Value="MagicLight.xml"/>
									<dx:ListEditItem Text="iStyle" Value="iStyle.xml"/>
									<dx:ListEditItem Text="Future" Value="Future.xml"/>
									<dx:ListEditItem Text="Yellow Submarine" Value="YellowSubmarine.xml"/>
									<dx:ListEditItem Text="Classic" Value="Classic.xml"/>
									<dx:ListEditItem Text="Red" Value="Red.xml"/>
								</Items>
							</dx:ASPxComboBox>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
</asp:Content>