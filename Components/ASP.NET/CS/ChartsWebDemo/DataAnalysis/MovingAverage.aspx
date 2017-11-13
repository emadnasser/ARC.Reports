<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MovingAverage.aspx.cs" Inherits="MovingAveragePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table class="OptionsTable" style="width: 100%;">
                <tr>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblType" runat="server" Text="Type:"/></td>
                    <td>
                        <dx:ASPxComboBox ID="cmbType" runat="server" ValueType="System.String" Width="202px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
	                            chart.PerformCallback(&quot;Type&quot;);
                            }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td style="width:100%"></td>
                    <td class="NoWrap">
                        <dx:ASPxLabel ID="lblDaysCount" runat="server" Text="Days Count:"></dx:ASPxLabel>
                    </td>
                    <td>
                        <dx:ASPxSpinEdit ID="spnPointsCount" runat="server" Height="21px" Number="0" MaxValue="15" MinValue="2" Width="53px">
                            <ClientSideEvents NumberChanged="function(s, e) {
	                            chart.PerformCallback(&quot;PointsCount&quot;);
                            }" />
                        </dx:ASPxSpinEdit>
                    </td>
                </tr>
                <tr>
                    <td class="NoWrap">
                        <dx:ASPxLabel ID="lblKind" runat="server" Text="Kind:"/>
                    </td>
                    <td>
                        <dx:ASPxComboBox ID="cmbKind" runat="server" ValueType="System.String" ClientInstanceName="cmbbKind" Width="202px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
    	                        if (cmbbKind.GetValue() == &quot;Envelope&quot; || cmbbKind.GetValue() == &quot;Moving Average And Envelope&quot;){
	                                labelEnvelopePercent.SetEnabled(true);
	                                spinEnvelopePercent.SetEnabled(true);
	                            }
	                            else {
	                                labelEnvelopePercent.SetEnabled(false);
	                                spinEnvelopePercent.SetEnabled(false);
	                            }
	                            chart.PerformCallback(&quot;Kind&quot;);
                            }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td style="width:100%"></td>
                    <td class="NoWrap">
                        <dx:ASPxLabel ID="lblEnvelopePercent" runat="server" ClientInstanceName="labelEnvelopePercent"
                            Text="Envelope Percent:">
                        </dx:ASPxLabel>
                    </td>
                    <td>
                        <dx:ASPxSpinEdit ID="spnEnvelopePercent" runat="server" Height="21px" Number="0" ClientInstanceName="spinEnvelopePercent" MaxValue="100" MinValue="1" Width="53px">
                            <ClientSideEvents NumberChanged="function(s, e) {
	                            chart.PerformCallback(&quot;EnvelopePercent&quot;);
                            }" />
                        </dx:ASPxSpinEdit>
                    </td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="True"
        DataSourceID="chartDataSource">
        <Titles>
            <dx:ChartTitle Text="Stock Prices"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.quandl.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <Legend AlignmentHorizontal="Left" AlignmentVertical="Top"></Legend>
        <SeriesSerializable>
            <dx:Series Name="Google Inc." ArgumentScaleType="DateTime" LabelsVisibility="False"
                ArgumentDataMember="Date" ValueDataMembersSerializable="Low;High;Open;Close">
                <ViewSerializable>
                    <dx:StockSeriesView Color="Black">
                        <Indicators>
                            <dx:SimpleMovingAverage EnvelopeColor="Green" ValueLevel="Close" Name="Simple Moving Average"></dx:SimpleMovingAverage>
                            <dx:ExponentialMovingAverage EnvelopeColor="Green" ValueLevel="Close" Name="Exponential Moving Average"></dx:ExponentialMovingAverage>
                            <dx:WeightedMovingAverage EnvelopeColor="Green" ValueLevel="Close" Name="Weighted Moving Average"></dx:WeightedMovingAverage>
                            <dx:TriangularMovingAverage EnvelopeColor="Green" ValueLevel="Close" Name="Triangular Moving Average"></dx:TriangularMovingAverage>
                        <dx:TripleExponentialMovingAverageTema Name="TripleExponentialMovingAverageTema" ValueLevel="Close"></dx:TripleExponentialMovingAverageTema></Indicators>
                    </dx:StockSeriesView>
                </ViewSerializable>
            </dx:Series>
        </SeriesSerializable>
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" Interlaced="True">
                    <DateTimeScaleOptions  WorkdaysOnly="True" GridAlignment="Month"/>
                    <Label Staggered="True"></Label>                    
                    <GridLines Visible="True"></GridLines>
                </AxisX>
                <AxisY Title-Text="US Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1">
                    <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                    <GridLines MinorVisible="True"></GridLines>
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
        <BorderOptions Visibility="False" />
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="MarketPrices" SelectMethod="GetGoogleStockPrices"></asp:ObjectDataSource>    
</asp:Content>
