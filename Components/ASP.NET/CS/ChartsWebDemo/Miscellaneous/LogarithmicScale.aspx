<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LogarithmicScale.aspx.cs" Inherits="LogarithmicScale" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">    
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;">
                        <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(); }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td>
                        <dx:ASPxCheckBox ID="cbLogarithmic" runat="server" Text="Enabled" ClientInstanceName="chLogarithmic">
                            <ClientSideEvents CheckedChanged="function(s, e) { 
	lblLogarithmicBase.SetEnabled(chLogarithmic.GetChecked());
	cbLogarithmicBase.SetEnabled(chLogarithmic.GetChecked());
	chart.PerformCallback(); 
}" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblLogarithmicBase" runat="server" Text="Logarithmic base:" ClientInstanceName="lblLogarithmicBase"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbLogarithmicBase" runat="server" Width="50px" ClientInstanceName="cbLogarithmicBase">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(); }" />
                        </dx:ASPxComboBox>
                    </td>
                </tr>
            </table>
         </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback">
        <SeriesSerializable>
            <dx:Series Name="Asia">
                <Points>
                    <dx:SeriesPoint Values="1436" ArgumentSerializable="1950"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1718" ArgumentSerializable="1960"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="2156" ArgumentSerializable="1970"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="2644" ArgumentSerializable="1980"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="3180" ArgumentSerializable="1990"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="3678" ArgumentSerializable="2000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="4149" ArgumentSerializable="2010"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="4611" ArgumentSerializable="2020"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="4992" ArgumentSerializable="2030"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="5290" ArgumentSerializable="2040"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="5503" ArgumentSerializable="2050"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView></dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel Angle="90" BackColor="Transparent" LineLength="6" LineVisibility="False">
                        <Border Visibility="False"></Border>
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Africa">
                <Points>
                    <dx:SeriesPoint Values="227" ArgumentSerializable="1950"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="285" ArgumentSerializable="1960"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="365" ArgumentSerializable="1970"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="478" ArgumentSerializable="1980"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="633" ArgumentSerializable="1990"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="810" ArgumentSerializable="2000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1016" ArgumentSerializable="2010"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1251" ArgumentSerializable="2020"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1507" ArgumentSerializable="2030"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1783" ArgumentSerializable="2040"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="2073" ArgumentSerializable="2050"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView>
                        <LineMarkerOptions Size="8"></LineMarkerOptions>
                    </dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel Angle="-45" BackColor="Transparent" LineLength="6" LineVisibility="False" ResolveOverlappingMode="JustifyAroundPoint">
                        <Border Visibility="False"></Border>
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Americas">
                <Points>
                    <dx:SeriesPoint Values="331" ArgumentSerializable="1950"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="416" ArgumentSerializable="1960"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="512" ArgumentSerializable="1970"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="612" ArgumentSerializable="1980"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="720" ArgumentSerializable="1990"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="833" ArgumentSerializable="2000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="936" ArgumentSerializable="2010"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1036" ArgumentSerializable="2020"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1126" ArgumentSerializable="2030"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1202" ArgumentSerializable="2040"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1263" ArgumentSerializable="2050"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView>
                        <LineMarkerOptions Size="8"></LineMarkerOptions>
                    </dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel BackColor="Transparent" LineLength="6" LineVisibility="False" ResolveOverlappingMode="JustifyAroundPoint">
                        <Border Visibility="False"></Border>
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Europe">
                <Points>
                    <dx:SeriesPoint Values="547" ArgumentSerializable="1950"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="605" ArgumentSerializable="1960"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="657" ArgumentSerializable="1970"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="695" ArgumentSerializable="1980"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="722" ArgumentSerializable="1990"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="731" ArgumentSerializable="2000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="728" ArgumentSerializable="2010"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="720" ArgumentSerializable="2020"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="702" ArgumentSerializable="2030"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="678" ArgumentSerializable="2040"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="648" ArgumentSerializable="2050"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView>
                        <LineMarkerOptions Size="8"></LineMarkerOptions>
                    </dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel BackColor="Transparent" LineLength="6" LineVisibility="False" ResolveOverlappingMode="JustifyAroundPoint">
                        <Border Visibility="False"></Border>
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Oceania">
                <Points>
                    <dx:SeriesPoint Values="12" ArgumentSerializable="1950"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="15" ArgumentSerializable="1960"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="19" ArgumentSerializable="1970"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="22" ArgumentSerializable="1980"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="26" ArgumentSerializable="1990"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="30" ArgumentSerializable="2000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="35" ArgumentSerializable="2010"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="39" ArgumentSerializable="2020"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="43" ArgumentSerializable="2030"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="47" ArgumentSerializable="2040"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="50" ArgumentSerializable="2050"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:LineSeriesView></dx:LineSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel Angle="90" BackColor="Transparent" LineLength="6" LineVisibility="False">
                        <Border Visibility="False"></Border>
                    </dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <BorderOptions Visibility="False"></BorderOptions>
        <Titles>
            <dx:ChartTitle Text="Historic, current and future population "></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.geohive.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX Title-Text="Years" VisibleInPanesSerializable="-1" Interlaced="True">                     
                    <GridLines Visible="True"></GridLines>
                </AxisX>
                <AxisY Title-Text="Population mid-year, millions" Title-Visibility="True" VisibleInPanesSerializable="-1" MinorCount="4" Logarithmic="True">
                    <WholeRange AlwaysShowZeroLevel="False"  ></WholeRange>
                    <GridLines MinorVisible="True"></GridLines>
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
    </dx:WebChartControl>
</asp:Content>
