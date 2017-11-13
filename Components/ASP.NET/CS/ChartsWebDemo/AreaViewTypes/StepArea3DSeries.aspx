<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="StepArea3DSeries.aspx.cs" Inherits="StepArea3DSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table style="width: 100%;">
                <tr>
                    <td>
                        <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show&nbsp;Labels">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td style="width: 100%">
                        <dx:ASPxCheckBox ID="cbInvertStep" runat="server" Text="Inverted">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;InvertStep&quot;); }" />
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
    <dx:WebChartControl ID="WebChartControl1" runat="server" CssClass="AlignCenter TopLargeMargin"
        Height="400px" Width="700px" ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback"
        DataSourceID="chartDataSource">
        <Legend direction="BottomToTop" Visibility="False"></Legend>
        <Titles>
            <dx:ChartTitle Text="US Gasoline Prices in 2015"></dx:ChartTitle>
            <dx:ChartTitle Text="Dollars per Gallon" Font="Tahoma, 12pt"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.eia.gov" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <SeriesSerializable>
            <dx:Series ArgumentScaleType="DateTime" LabelsVisibility="True"
                ArgumentDataMember="Date" ValueDataMembersSerializable="Price">
                <ViewSerializable>
                    <dx:StepArea3DSeriesView></dx:StepArea3DSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:Area3DSeriesLabel TextPattern="{V:F2}">
                    </dx:Area3DSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <DiagramSerializable>
            <dx:XYDiagram3D RotationType="UseAngles" RotationOrder="XYZ" RotationAngleY="-30" ZoomPercent="170">
                <AxisX>
                    <Label MaxWidth="70" TextPattern="{A:MMMM}"></Label>
                    <DateTimeScaleOptions AutoGrid="False" MeasureUnit="Month" GridAlignment="Month" GridSpacing="2"/>
                </AxisX>
                <AxisY>
                    <label TextPattern="{V:N1}"/>
                    <WholeRange AlwaysShowZeroLevel="False"></WholeRange>
                </AxisY>
            </dx:XYDiagram3D>
        </DiagramSerializable>
        <BorderOptions Visibility="False"></BorderOptions>
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="SourceOfEnergy" SelectMethod="GetGasolinePrices"></asp:ObjectDataSource>
</asp:Content>
