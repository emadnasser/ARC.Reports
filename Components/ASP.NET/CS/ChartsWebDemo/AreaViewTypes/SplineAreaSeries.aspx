<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SplineAreaSeries.aspx.cs" Inherits="SplineAreaSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">            
            <table style="width: 100%;">
                <tr>
                    <td><dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="95px" ClientInstanceName="chbShowLabels">
                        <ClientSideEvents CheckedChanged="function(s, e) {
	chart.PerformCallback(&quot;ShowLabels&quot;);
	labelLabelAngle.SetEnabled(chbShowLabels.GetChecked());
	cmbLabelAngle.SetEnabled(chbShowLabels.GetChecked());
}" />
                    </dx:ASPxCheckBox></td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblLabelAngle" runat="server" Text="Label Angle:" ClientInstanceName="labelLabelAngle"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbLabelAngle" runat="server" Width="50px" ValueType="System.String" ClientInstanceName="cmbLabelAngle">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;LabelAngle&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
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
                    <td class="NoWrap"><dx:ASPxLabel ID="lblTransparency" runat="server" Text="Transparency:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbTransparency" runat="server" Width="50px">
                        <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Transparency&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback"
        SeriesDataMember = "Company" DataSourceID="chartDataSource">
        <CrosshairOptions   GroupHeaderPattern="Year: {A:yyyy}">
        </CrosshairOptions>
        <Titles>
            <dx:ChartTitle Text="Outside Vendor Costs"></dx:ChartTitle>
        </Titles>
        <Legend AlignmentHorizontal="Center" AlignmentVertical="BottomOutside" Direction="LeftToRight"></Legend>
        <SeriesTemplate  ArgumentDataMember="Year" ValueDataMembersSerializable="Costs" LabelsVisibility="False"
            CrosshairLabelPattern="{S}: ${V:0.0}K">
            <ViewSerializable>
                <dx:SplineAreaSeriesView></dx:SplineAreaSeriesView>
            </ViewSerializable>
        </SeriesTemplate>       
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX VisibleInPanesSerializable="-1">
                    <WholeRange AutoSideMargins="False" SideMarginsValue="0" />
                    <DateTimeScaleOptions MeasureUnit="Year" GridAlignment="Year" />
                </AxisX>
                <AxisY Interlaced="True" 
                    Title-Text="Thousands US$" Title-Visibility="True" 
                    VisibleInPanesSerializable="-1">
                    <WholeRange AlwaysShowZeroLevel="False" Auto="False" MaxValueSerializable="390" MinValueSerializable="125"/>
                    <Label TextPattern="{V:G}">
                    </Label>
                    <NumericScaleOptions GridSpacing="75" AutoGrid="False" />
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
        <BorderOptions Visibility="False" />
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetOutsideVendorCosts"></asp:ObjectDataSource>
</asp:Content>
