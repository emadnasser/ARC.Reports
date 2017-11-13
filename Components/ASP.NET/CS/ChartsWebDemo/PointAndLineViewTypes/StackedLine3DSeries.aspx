<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="StackedLine3DSeries.aspx.cs" Inherits="StackedLine3DSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">   
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;">
                        <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblPerspectiveAngle" runat="server" Text="Perspective Angle:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbPerspectiveAngle" runat="server" Width="70px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;PerspectiveAngle&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>                            
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblZoomPercent" runat="server" Text="Zoom Percent:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbZoomPercent" runat="server" Width="50px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;ZoomPercent&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>                                            
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback" SeriesSorting="Descending"
        SeriesDataMember = "Region" DataSourceID="chartDataSource">
        <SeriesTemplate ArgumentScaleType="DateTime" ArgumentDataMember="Year" ValueDataMembersSerializable="Sales" LabelsVisibility="False">
            <ViewSerializable>
                <dx:StackedLine3DSeriesView LineWidth="1.2"></dx:StackedLine3DSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                    <dx:StackedLine3DSeriesLabel TextPattern="${V}M">
                    </dx:StackedLine3DSeriesLabel>
             </LabelSerializable>
        </SeriesTemplate>         
        <BorderOptions Visibility="False"></BorderOptions>
        <DiagramSerializable>
            <dx:XYDiagram3D RotationType="UseAngles" RotationOrder="XYZ" RotationAngleY="-20" ZoomPercent="140">
                <AxisX>
                    <DateTimeScaleOptions MeasureUnit="Year" GridAlignment="Year" AutoGrid="False" GridSpacing="2"/>                     
                </AxisX>
                <AxisY>
                    <Label TextPattern="${S}M"/>
                </AxisY>
            </dx:XYDiagram3D>
        </DiagramSerializable>
        <Legend Direction="BottomToTop"></Legend>
        <Titles>
            <dx:ChartTitle Text="DevAV Sales"></dx:ChartTitle>
        </Titles>
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="DevAV" SelectMethod="GetSalesByLast10Years"></asp:ObjectDataSource>
</asp:Content>
