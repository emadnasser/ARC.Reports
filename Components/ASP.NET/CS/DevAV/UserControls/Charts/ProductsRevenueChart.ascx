<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductsRevenueChart.ascx.cs" Inherits="UserControls_Charts_ProductsRevenueChart" %>
<dx:WebChartControl ID="RevenueChart" runat="server" ClientInstanceName="revenueChart" Width="500" Height="300"
    AppearanceNameSerializable="Chameleon" PaletteName="DevAV" CrosshairEnabled="True" SettingsLoadingPanel-Enabled="false"
    OnCustomCallback="RevenueChart_CustomCallback" OnCustomDrawSeriesPoint="RevenueChart_CustomDrawSeriesPoint">
    <Padding bottom="0" left="0" right="0" top="0" />
    <BorderOptions visibility="False" />
    <Diagramserializable>
        <dx:SimpleDiagram Dimension="1" EqualPieSize="False" />
    </Diagramserializable>
    <Legend alignmentvertical="Center" enableantialiasing="True" backcolor="White" equallyspaceditems="False" font="Arial, 11pt" markersize="10, 10" verticalindent="6">
        <Margins right="15" />
        <Border visibility="False" />
    </Legend>
    <SeriesSerializable>
        <dx:Series LabelsVisibility="True" Name="Series 1" ArgumentDataMember="Name" ValueDataMembersSerializable="Value">
            <Viewserializable>
                <dx:DoughnutSeriesView HoleRadiusPercent="60" Rotation="1" RuntimeExploding="False" SweepDirection="Counterclockwise">
                    <Border visibility="False" />
                    <Fillstyle fillmode="Solid" />
                </dx:DoughnutSeriesView>
            </Viewserializable>
            <Labelserializable>
                <dx:DoughnutSeriesLabel EnableAntialiasing="True" Font="Arial, 11pt" LineColor="Black" LineVisibility="False"  TextColor="128, 128, 128">
                    <Border visibility="False" />
                    <PointOptionSserializable>
                        <dx:PiePointOptions>
                            <ValueNumericOptions format="Percent" />
                        </dx:PiePointOptions>
                    </PointOptionSserializable>
                </dx:DoughnutSeriesLabel>
            </Labelserializable>
        </dx:Series>
    </SeriesSerializable>
    <SeriesTemplate legendtextpattern="{VP:G4}">
        <Viewserializable>
            <dx:DoughnutSeriesView RuntimeExploding="False" SweepDirection="Counterclockwise" />
        </Viewserializable>
    </SeriesTemplate>
    <PaletteWrappers>
        <dx:PaletteWrapper Name="DevAV" ScaleMode="Repeat">
            <Palette>
                <dx:PaletteEntry Color="191, 78, 106" Color2="191, 78, 106" />
                <dx:PaletteEntry Color="94, 109, 157" Color2="94, 109, 157" />
                <dx:PaletteEntry Color="87, 154, 163" Color2="87, 154, 163" />
                <dx:PaletteEntry Color="168, 121, 162" Color2="168, 121, 162" />
                <dx:PaletteEntry Color="180, 50, 100" Color2="180, 50, 100" />
            </Palette>
        </dx:PaletteWrapper>
    </PaletteWrappers>
</dx:WebChartControl>
