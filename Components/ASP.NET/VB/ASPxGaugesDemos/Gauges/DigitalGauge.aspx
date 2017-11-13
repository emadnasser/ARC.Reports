<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DigitalGauge.aspx.vb" Inherits="DigitalGaugePage" %>
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
	<dx:ASPxGaugeControl runat="server" Width="350px" Height="145px" BackColor="Transparent" ClientInstanceName="gauge" ID="gControl_Page1"
		SaveStateOnCallbacks="false">
		<ClientSideEvents EndCallback="OnEndCallback" />
		<Gauges>
			<dx:DigitalGauge ID="dGauge1" AppearanceOff-ContentBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:#34000000&quot;/&gt;"
				AppearanceOn-ContentBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:Black&quot;/&gt;" Bounds="0, 0, 350, 145"
				DigitCount="6" Padding="20, 20, 20, 20" Text="12,345">
				<backgroundlayers>
					<dx:DigitalBackgroundLayerComponent BottomRight="259.8125, 99.9625" Name="digitalBackgroundLayerComponent4"
						ShapeType="Style4" TopLeft="20, 0" ZOrder="1000" />
				</backgroundlayers>
			</dx:DigitalGauge>
		</Gauges>
	</dx:ASPxGaugeControl>
		<dx:ASPxRoundPanel runat="server" ID="ASPxRoundPanel_1" ShowHeader="false" style="float: right">
			<PanelCollection>
				<dx:PanelContent runat="server">
					<table class="OptionsTable">
						<tr>
							<td>
								Digit Count:
							</td>
							<td>
								<dx:ASPxSpinEdit ID="digitCount" runat="server" MaxValue="10" MinValue="5" Number="6" Width="150px" NumberType="Integer" AllowNull="False">
									<ClientSideEvents NumberChanged="OnChanged" />
								</dx:ASPxSpinEdit>
							</td>
						</tr>
						<tr>
							<td>
								Display Mode:
							</td>
							<td>
								<dx:ASPxComboBox ID="displayMode" runat="server" Width="150px" ValueType="System.Int32" SelectedIndex="1">
									<Items>
										<dx:ListEditItem Text="Seven Segments" Value="0" />
										<dx:ListEditItem Text="Fourteen Segments" Value="1" />
										<dx:ListEditItem Text="Matrix 5x8" Value="2" />
										<dx:ListEditItem Text="Matrix 8x14" Value="3" />
									</Items>
									<ClientSideEvents SelectedIndexChanged="OnChanged" />
								</dx:ASPxComboBox>
							</td>
						</tr>
					</table>
				</dx:PanelContent>
			</PanelCollection>
		</dx:ASPxRoundPanel>
</asp:Content>