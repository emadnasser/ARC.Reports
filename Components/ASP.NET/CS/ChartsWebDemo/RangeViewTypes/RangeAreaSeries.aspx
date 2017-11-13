<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RangeAreaSeries.aspx.cs" Inherits="RangeAreaSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;"><dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" ClientInstanceName="chbShowLabels">
                        <ClientSideEvents CheckedChanged="function(s, e) {
	                            chart.PerformCallback(&quot;ShowLabels&quot;);
	                            labelLabelKind.SetEnabled(chbShowLabels.GetChecked());
	                            cboxLabelKind.SetEnabled(chbShowLabels.GetChecked());
                            }" />
                    </dx:ASPxCheckBox></td>
                    <td class="NoWrap">
                    <dx:ASPxCheckBox ID="cbShowMarker2" runat="server" Text="Show Value2 Markers" Width="110px" ClientInstanceName="chbShowMarker2">
                        <ClientSideEvents CheckedChanged="function(s, e) {
                                labelMarker2Kind.SetEnabled(chbShowMarker2.GetChecked());
                                labelMarker2Size.SetEnabled(chbShowMarker2.GetChecked());
                                cmbMarker2Kind.SetEnabled(chbShowMarker2.GetChecked());
                                cmbMarker2Size.SetEnabled(chbShowMarker2.GetChecked());
                                chart.PerformCallback(&quot;ShowMarker2&quot;);
                            }" />
                    </dx:ASPxCheckBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblMarker2Kind" runat="server" Text="Kind:" ClientInstanceName="labelMarker2Kind"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbMarker2Kind" runat="server" Width="130px" ClientInstanceName="cmbMarker2Kind">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Marker2Kind&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblMarker2Size" runat="server" Text="Size:" ClientInstanceName="labelMarker2Size"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td style="width: 100%;">
                        <dx:ASPxComboBox ID="cbMarker2Size" runat="server" Width="50px" ClientInstanceName="cmbMarker2Size">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Marker2Size&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                </tr>
                <tr>
                    <td><div class="Spacer" style="width: 100%;height: 5px"></div></td>
                </tr>
                <tr>
                    <td>
                    <table>
                        <tr>
                        <td class="NoWrap">
                            <dx:ASPxLabel ID="lblLabelKind" runat="server" Text="Label Kind:" ClientInstanceName="labelLabelKind"/>
                        </td>
                        <td style="width: 100%;">
                            <dx:ASPxComboBox ID="cbLabelKind" runat="server" ClientInstanceName="cboxLabelKind" ValueType="System.String" Width="120px">
                                <ClientSideEvents  SelectedIndexChanged="function(s, e) {
	                                chart.PerformCallback(&quot;LabelKind&quot;); 
                                }" />
                            </dx:ASPxComboBox>
                        </td>
                        </tr>
                    </table>
                    </td>
                    <td class="NoWrap">
                        <dx:ASPxCheckBox ID="cbShowMarker1" runat="server" Text="Show Value1 Markers" Width="110px" ClientInstanceName="chbShowMarker1">
                            <ClientSideEvents CheckedChanged="function(s, e) {
	                                labelMarker1Kind.SetEnabled(chbShowMarker1.GetChecked());
	                                labelMarker1Size.SetEnabled(chbShowMarker1.GetChecked());
	                                cmbMarker1Kind.SetEnabled(chbShowMarker1.GetChecked());
	                                cmbMarker1Size.SetEnabled(chbShowMarker1.GetChecked());
	                                chart.PerformCallback(&quot;ShowMarker1&quot;);
                                }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblMarker1Kind" runat="server" Text="Kind:" ClientInstanceName="labelMarker1Kind"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbMarker1Kind" runat="server" Width="130px" ClientInstanceName="cmbMarker1Kind">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Marker1Kind&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblMarker1Size" runat="server" Text="Size:" ClientInstanceName="labelMarker1Size"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td style="width: 100%;">
                        <dx:ASPxComboBox ID="cbMarker1Size" runat="server" Width="50px" ClientInstanceName="cmbMarker1Size">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Marker1Size&quot;); }" />
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
        <Legend AlignmentHorizontal="Right" AlignmentVertical="Top" Direction="LeftToRight"></Legend>
        <Titles>
            <dx:ChartTitle Text="Crude Oil Prices in 2015"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.eia.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <SeriesSerializable>
            <dx:Series Name="Europe Brent" ArgumentScaleType="DateTime"
                ArgumentDataMember="Date" ValueDataMembersSerializable="Min;Max"
                CrosshairLabelPattern="Min Price: ${V1:0.00}<br/>Max Price: ${V2:0.00}">
                <ViewSerializable>
                    <dx:RangeAreaSeriesView>
                        <Border1 Color="27, 174, 73" Thickness="2"></Border1>
                        <Border2 Color="216, 0, 121" Thickness="2"></Border2>
                    </dx:RangeAreaSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:RangeAreaSeriesLabel TextPattern="{V:F2}">
                    </dx:RangeAreaSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX Title-Text="Date" VisibleInPanesSerializable="-1">
                    <DateTimeScaleOptions MeasureUnit="Month" GridAlignment="Month" AutoGrid="False"/>
                    <WholeRange AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                    <Label TextPattern="{A:MMMM}">
                    </Label>
                </AxisX>
                <AxisY Title-Text="$ per barrel" Title-Visibility="True" VisibleInPanesSerializable="-1" Interlaced="True">
                    <WholeRange  AlwaysShowZeroLevel="False"></WholeRange>
                    <GridLines MinorVisible="True"></GridLines>
                    <Label TextPattern="{V:N0}">
                    </Label>
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
        <BorderOptions Visibility="False"></BorderOptions>
        <CrosshairOptions GroupHeaderPattern="Month: {A:MMMM}"/>
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="SourceOfEnergy" SelectMethod="GetEuropeBrentPrices"></asp:ObjectDataSource>    
</asp:Content>
