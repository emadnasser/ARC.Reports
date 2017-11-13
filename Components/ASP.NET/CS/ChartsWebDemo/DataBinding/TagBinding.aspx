<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TagBinding.aspx.cs" Inherits="TagBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;">
                        <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" ClientInstanceName="chart">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;&quot;); }" />
                        </dx:ASPxCheckBox>
                    </td>
                </tr>
            </table>
    </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        SaveStateOnCallbacks="False" DataSourceID="AccessDataSource1"
        OnCustomDrawSeriesPoint="WebChartControl1_CustomDrawSeriesPoint" ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback">
        <SeriesSerializable>
            <dx:Series Name="Area of Countries" ArgumentDataMember="Country" ValueDataMembersSerializable="Area" SeriesPointsSorting="Descending" SeriesPointsSortingKey="Value_1">
                <DataFilters>
                    <dx:DataFilter ColumnName="Area" DataType="System.Single" Condition="GreaterThan" InvariantValueSerializable="5000"></dx:DataFilter>
                </DataFilters>
                <ViewSerializable>
                    <dx:SideBySideBarSeriesView ColorEach="True"></dx:SideBySideBarSeriesView>
                </ViewSerializable>
            </dx:Series>
        </SeriesSerializable>
        <BorderOptions Visibility="False" />
        <Titles>
            <dx:ChartTitle Text="Area of Countries"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.nationmaster.com" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX VisibleInPanesSerializable="-1">                    
                </AxisX>
                <AxisY VisibleInPanesSerializable="-1" Title-Text="Millions of Square Kilometers" Title-Visibility="True">                    
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
    </dx:WebChartControl>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/countriesDB.mdb"
        SelectCommand="SELECT [Country], [OfficialName], [Area] FROM [Countries]">
    </asp:AccessDataSource>
</asp:Content>
