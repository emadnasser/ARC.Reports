<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BarFullStackedSideBySideSeries.aspx.cs" Inherits="BarFullStackedSideBySideSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">   
            <table style="width: 100%;">
                <tr>
                    <td><dx:ASPxCheckBox ID="cbShowLabels" runat="server" text="Show&nbsp;Labels" ClientInstanceName="chbShowLabels">
                        <ClientSideEvents CheckedChanged="function(s, e) {
	chbValueAsPercent.SetEnabled(chbShowLabels.GetChecked());
	chart.PerformCallback(&quot;&quot;);
}" />
                    </dx:ASPxCheckBox></td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td style="width: 100%;">
                        <dx:ASPxCheckBox ID="cbValueAsPercent" runat="server" Text="Value As Percent" ClientInstanceName="chbValueAsPercent">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;&quot;); }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblLabelPosition" runat="server" Text="Group Series by:" /></td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td>
                        <dx:ASPxRadioButton ID="rbSex" runat="server" Text="Sex" GroupName="GroupBy" ClientInstanceName="rbSex">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;&quot;); }" />
                        </dx:ASPxRadioButton>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td>
                        <dx:ASPxRadioButton ID="rbAge" runat="server" GroupName="GroupBy" Text="Age" ClientInstanceName="rbAge">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;&quot;); }" />
                        </dx:ASPxRadioButton>
                    </td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
        Width="700px" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
        OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="False"
        EnableClientSideAPI="True" ToolTipEnabled="False"
        SeriesDataMember="GenderAge"
        OnBoundDataChanged="WebChartControl1_BoundDataChanged" DataSourceID="chartDataSource">
        <SeriesTemplate  ArgumentDataMember="Country" ValueDataMembersSerializable="Population" LabelsVisibility="True"
            CrosshairLabelPattern="{S}<br/>{V:0,,.00} million">
            <ViewSerializable>
                <dx:SideBySideFullStackedBarSeriesView></dx:SideBySideFullStackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:FullStackedBarSeriesLabel TextPattern="{VP:P0}">
                </dx:FullStackedBarSeriesLabel>
            </LabelSerializable>
        </SeriesTemplate>
        <Legend AlignmentHorizontal="Center" AlignmentVertical="BottomOutside" BackColor="Transparent" Direction="LeftToRight" MaxHorizontalPercentage="70">
            <Border Visibility="False" />
        </Legend>
        <BorderOptions Visibility="False" />
        <Titles>
            <dx:ChartTitle Text="Population: Age Structure"></dx:ChartTitle>
            <dx:ChartTitle Text="Data estimate for mid-2016" Font="Tahoma, 12pt"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.cia.gov" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX Title-Text="Countries" VisibleInPanesSerializable="-1">
                </AxisX>
                <AxisY Title-Text="Percent" VisibleInPanesSerializable="-1" Interlaced="True">
                    <WholeRange Auto="False" MinValueSerializable="0" MaxValueSerializable="1" AutoSideMargins="False" SideMarginsValue="0" ></WholeRange>
                    <Label TextPattern="{V:P0}">
                    </Label>
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="AgeStructure" SelectMethod="GetDataByAgeAndGender"></asp:ObjectDataSource>
</asp:Content>
