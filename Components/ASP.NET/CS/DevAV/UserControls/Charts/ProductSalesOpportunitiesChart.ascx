<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductSalesOpportunitiesChart.ascx.cs" Inherits="UserControls_Charts_ProductSalesOpportunitiesChart" %>
<dx:WebChartControl ID="SalesOpportunitiesChart" runat="server" Width="500" Height="310" CrosshairEnabled="True" PaletteName="Products" CssClass="salesChart">
    <Padding bottom="12" left="12" right="12" top="12" />
    <BorderOptions visibility="False" />
    <DiagramSerializable>
        <dx:XYDiagram>
            <Axisx color="223, 223, 223" visibleinpanesserializable="-1">
                <TickMarks minorvisible="False" visible="False" />
                <Label enableantialiasing="True" />
                <VisualRange autosidemargins="True" />
                <WholeRange autosidemargins="True" />
            </Axisx>
            <Axisy color="255, 255, 255" visibleinpanesserializable="-1">
                <TickMarks minorvisible="False" visible="False" />
                <Label enableantialiasing="True" textpattern="$ {V}" />
                <VisualRange autosidemargins="True" />
                <WholeRange autosidemargins="True" />
            </Axisy>
            <DefaultPane backcolor="255, 255, 255" bordervisible="False" />
        </dx:XYDiagram>
    </DiagramSerializable>
    <Legend alignmenthorizontal="Right" alignmentvertical="TopOutside" enableantialiasing="True" direction="RightToLeft" equallyspaceditems="False" font="Tahoma, 9pt">
        <Border visibility="False" />
    </Legend>
    <SeriesSerializable>
        <dx:Series LabelsVisibility="False" Name="Opportunities" ArgumentDataMember="Name" ValueDataMembersSerializable="Value" CrosshairLabelPattern="{S} : ${V}">
            <ViewSerializable>
                <dx:SideBySideBarSeriesView>
                    <Border visibility="False" />
                </dx:SideBySideBarSeriesView>
            </ViewSerializable>
        </dx:Series>
        <dx:Series Name="Sales" ArgumentDataMember="Name" ValueDataMembersSerializable="Value" CrosshairLabelPattern="{S} : ${V}">
            <ViewSerializable>
                <dx:SideBySideBarSeriesView>
                    <Border visibility="False" />
                </dx:SideBySideBarSeriesView>
            </ViewSerializable>
        </dx:Series>
    </SeriesSerializable>
    <SeriesTemplate SynchronizePointOptions="False" />
    <PaletteWrappers>
        <dx:PaletteWrapper Name="Products" ScaleMode="Repeat">
            <Palette>
                <dx:PaletteEntry Color="94, 109, 157" Color2="94, 109, 157" />
                <dx:PaletteEntry Color="191, 78, 106" Color2="191, 78, 106" />
            </Palette>
        </dx:PaletteWrapper>
    </PaletteWrappers>
</dx:WebChartControl>
