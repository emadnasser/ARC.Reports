<%@ Control Language="vb" AutoEventWireup="true" CodeFile="ProductsOpportunitiesChart.ascx.vb" Inherits="UserControls_Charts_ProductsOpportunitiesChart" %>
<dx:WebChartControl ID="OpportunitiesChart" runat="server" ClientInstanceName="opportunitiesChart" Height="300"
    CrosshairEnabled="True" PaletteName="DevAV" SettingsLoadingPanel-Enabled="false" 
    OnCustomCallback="OpportunitiesChart_CustomCallback" OnCustomDrawSeriesPoint="OpportunitiesChart_CustomDrawSeriesPoint">
    <BorderOptions visibility="False" />
    <DiagramSerializable>
        <dx:SimpleDiagram EqualPieSize="False" />
    </DiagramSerializable>
    <Legend alignmenthorizontal="Right" alignmentvertical="Center" enableantialiasing="True" font="Tahoma, 10pt">
        <Border visibility="False" />
    </Legend>
    <SeriesSerializable>
    <dx:Series Name="Series 1" ArgumentDataMember="Name" ValueDataMembersSerializable="Value">
        <ViewSerializable>
            <dx:FunnelSeriesView AlignToCenter="True">
                <border visibility="False" />
            </dx:FunnelSeriesView>
        </ViewSerializable>
        <LabelSerializable>
            <dx:FunnelSeriesLabel EnableAntialiasing="True" BackColor="Transparent" Font="Tahoma, 11pt" Position="Center" TextColor="255, 255, 255" TextPattern="${V:#,#}">
                <Border visibility="False" />
            </dx:FunnelSeriesLabel>
        </LabelSerializable>
    </dx:Series>
    </SeriesSerializable>
    <SeriesTemplate>
        <ViewSerializable>
            <dx:FunnelSeriesView>
            </dx:FunnelSeriesView>
        </ViewSerializable>
    </SeriesTemplate>
    <PaletteWrappers>
        <dx:PaletteWrapper Name="DevAV" ScaleMode="Repeat">
            <palette>
                <dx:PaletteEntry Color="191, 78, 106" Color2="191, 78, 106" />
                <dx:PaletteEntry Color="94, 109, 157" Color2="94, 109, 157" />
                <dx:PaletteEntry Color="87, 154, 163" Color2="87, 154, 163" />
                <dx:PaletteEntry Color="168, 121, 162" Color2="168, 121, 162" />
            </palette>
        </dx:PaletteWrapper>
    </PaletteWrappers>
</dx:WebChartControl>