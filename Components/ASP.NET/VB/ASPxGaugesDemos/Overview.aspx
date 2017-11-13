<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<dx:ASPxGaugeControl ID="ASPxGaugeControl1" runat="server"
		 Height="160px" Width="290px" AutoLayout="False">
		<Gauges>
			<dx:DigitalGauge Bounds="7, 0, 275, 160" DigitCount="6" 
				Name="Gauge0" Text="22.453">
				<AppearanceOff ContentBrush="&lt;BrushObject Type=&quot;Solid&quot; Data=&quot;Color:#34000000&quot;/&gt;" />
				<backgroundlayers>
					<dx:DigitalBackgroundLayerComponent
						Name="Gauge0_BackgroundLayer1" 
						ShapeType="Style22" />
				</backgroundlayers>
			</dx:DigitalGauge>
		</Gauges>
	</dx:ASPxGaugeControl>
</asp:Content>