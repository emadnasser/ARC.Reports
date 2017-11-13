<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="StepLine3DSeries.aspx.cs" Inherits="StepLine3DSeries" %>
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
        Height="400px" Width="700px" ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="True"
        DataSourceID="chartDataSource">
        <Titles>
            <dx:ChartTitle Text="US Gasoline in 2015"></dx:ChartTitle>
            <dx:ChartTitle Text="Dollars per Gallon" Font="Tahoma, 12pt"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.eia.gov" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <SeriesSerializable>
            <dx:Series Name="Gasoline Prices" ArgumentScaleType="DateTime" LabelsVisibility="False"
                ArgumentDataMember="Date" ValueDataMembersSerializable="Price">
                <ViewSerializable>
                    <dx:StepLine3DSeriesView LineWidth="1.2"></dx:StepLine3DSeriesView>
                </ViewSerializable>
            </dx:Series>
        </SeriesSerializable>
        <DiagramSerializable>
            <dx:XYDiagram3D RotationMatrixSerializable="0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.342020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;1" ZoomPercent="140" VerticalScrollPercent="5">
                <AxisX>
                    <DateTimeScaleOptions MeasureUnit="Month" GridAlignment="Month" GridSpacing="2" AutoGrid="False" />
                     
                    <Label TextPattern="{A:MMMM}">
                    </Label>
                </AxisX>
                <AxisY>
                    <WholeRange AlwaysShowZeroLevel="False" ></WholeRange>
                    <Label TextPattern="{V:N1}">
                    </Label>
                </AxisY>
            </dx:XYDiagram3D>
        </DiagramSerializable>
        <BorderOptions Visibility="False" />
        <Legend Visibility="False"></Legend>
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="SourceOfEnergy" SelectMethod="GetGasolinePrices"></asp:ObjectDataSource>
</asp:Content>
