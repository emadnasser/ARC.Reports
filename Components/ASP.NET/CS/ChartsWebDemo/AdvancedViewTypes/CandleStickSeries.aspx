<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CandleStickSeries.aspx.cs" Inherits="CandleStickSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table class="OptionsTable" style="width: 100%;">
                <tr>
                    <td style="width: 100%">
                        <dx:ASPxCheckBox ID="cbWorkdaysOnly" runat="server" Text="Workdays Only" ClientInstanceName="chbWokdaysOnly">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;WorkdaysOnly&quot;); }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblReductionLevel" runat="server" Text="Reduction Level:"/></td>
                    <td>
                        <dx:ASPxComboBox ID="cbReductionLevel" runat="server" Width="80px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;ReductionLevel&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>                            
                </tr>
                <tr>
                    <td style="width: 100%;">
                        <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" ClientInstanceName="chbShowLabels">
                            <ClientSideEvents CheckedChanged="function(s, e) {
	labelLabelLevel.SetEnabled(chbShowLabels.GetChecked());
	cmbLabelLevel.SetEnabled(chbShowLabels.GetChecked());
	chart.PerformCallback(&quot;ShowLabels&quot;);
}" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td class="NoWrap">
                        <dx:ASPxLabel ID="lblLabelLevel" runat="server" Text="Label Level:" ClientInstanceName="labelLabelLevel"/>
                    </td>
                    <td>
                        <dx:ASPxComboBox ID="cbLabelLevel" runat="server" Width="80px" ClientInstanceName="cmbLabelLevel">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;LabelLevel&quot;); }" 
                                              Init="function(s, e) { cmbLabelLevel.SetEnabled(chbShowLabels.GetChecked()); }" />
                        </dx:ASPxComboBox>
                    </td>                            
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback"
        DataSourceID="chartDataSource">
        <Legend AlignmentHorizontal="Left" AlignmentVertical="Top"></Legend>
        <Titles>
            <dx:ChartTitle Text="Stock Prices"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.quandl.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <SeriesSerializable>
            <dx:Series Name="Google Inc" ArgumentScaleType="DateTime" LabelsVisibility="False"
                ArgumentDataMember="Date" ValueDataMembersSerializable="Low;High;Open;Close"
                CrosshairLabelPattern="High: {HV}<br/>Low: {LV}<br/>Open: {OV}<br/>Close: {CV}">
                <ViewSerializable>
                    <dx:CandleStickSeriesView Color="Black" LineThickness="1"></dx:CandleStickSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:StockSeriesLabel TextPattern="{CV:F2}" ResolveOverlappingMode="HideOverlapped">
                    </dx:StockSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" Interlaced="True">
                    <DateTimeScaleOptions  WorkdaysOnly="True" />
                    <Label Staggered="True"></Label>                    
                    <GridLines Visible="True"></GridLines>
                </AxisX>
                <AxisY Title-Text="US Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1">
                    <WholeRange Auto="False" MinValueSerializable="665" MaxValueSerializable="855"
                        AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                    <GridLines MinorVisible="True"></GridLines>
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
        <BorderOptions Visibility="False" />
        <CrosshairOptions GroupHeaderPattern="{A:d}"/>
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="MarketPrices" SelectMethod="GetGoogleStockPrices"></asp:ObjectDataSource>    
</asp:Content>
