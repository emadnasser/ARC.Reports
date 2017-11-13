<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="StackedLineSeries.aspx.cs" Inherits="StackedLineSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;"><dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="95px" ClientInstanceName="chbShowLabels">
                        <ClientSideEvents CheckedChanged="function(s, e) {
	chart.PerformCallback(&quot;ShowLabels&quot;);
}" />
                    </dx:ASPxCheckBox></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblMarkerKind" runat="server" Text="Marker Kind:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbMarkerKind" runat="server" Width="130px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerKind&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblMarkerSize" runat="server" Text="Marker Size:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td style="width: 100%;">
                        <dx:ASPxComboBox ID="cbMarkerSize" runat="server" Width="50px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MarkerSize&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
        Width="700px" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
        OnCustomCallback="WebChartControl1_CustomCallback"
        CrosshairEnabled="False" ToolTipEnabled="False"
        SeriesDataMember = "Region" DataSourceID="chartDataSource">
        <Legend AlignmentHorizontal="Center" AlignmentVertical="BottomOutside" Direction="LeftToRight">
        </Legend>
        <Titles>
            <dx:ChartTitle Text="DevAV Sales"></dx:ChartTitle>
        </Titles>
        <SeriesTemplate ArgumentScaleType="DateTime" ArgumentDataMember="Year" ValueDataMembersSerializable="Sales" LabelsVisibility="True">
            <ViewSerializable>
                <dx:StackedLineSeriesView></dx:StackedLineSeriesView>
            </ViewSerializable>
        </SeriesTemplate>        
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX Title-Text="Years" VisibleInPanesSerializable="-1">
                    <DateTimeScaleOptions MeasureUnit="Year" />
                </AxisX>
                <AxisY Interlaced="True" Title-Text="Millions of Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1">
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
        <BorderOptions Visibility="False" />
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetSalesByLast10Years"></asp:ObjectDataSource>
</asp:Content>
