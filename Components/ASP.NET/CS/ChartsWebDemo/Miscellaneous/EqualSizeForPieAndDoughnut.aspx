<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EqualSizeForPieAndDoughnut.aspx.cs" Inherits="PointSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">    
            <table class="OptionsTable">
                <tr>
                    <td><dx:ASPxCheckBox ID="chbEqualSize" runat="server" Text="Equal Size" Width="95px" ClientInstanceName="chbEqualSize">
                        <ClientSideEvents CheckedChanged="function(s, e) {chart.PerformCallback(&quot;EqualSize&quot;);}" />
                    </dx:ASPxCheckBox></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblMinAllowedSize" runat="server" Text="Minimum Allowed Size Percentage for Condiments Series:" ClientInstanceName="lblMinAllowedSize"/></td>
                    <td>
                        <dx:ASPxComboBox ID="cbMinAllowedSize" runat="server" Width="50px" ValueType="System.String" ClientInstanceName="cbMinAllowedSize">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;MinAllowedSize&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblView" runat="server" Text="View:"/></td>
                    <td style="width:100%">
                        <dx:ASPxComboBox ID="cbView" runat="server" Width="130px" ClientInstanceName="cbView">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;View&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnRestoreLayout" runat="server" Text="Restore Default Layout" Width="140px" AutoPostBack="False" Wrap="False">
                            <ClientSideEvents Click="function(s, e) {
 chbEqualSize.SetChecked(false);
 cbMinAllowedSize.SetSelectedIndex(0);
 cbView.SetSelectedIndex(0);
 chart.PerformCallback(&quot;Reset&quot;);
}" />
                        </dx:ASPxButton>
                    </td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
        Width="700px" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
        OnCustomCallback="WebChartControl1_CustomCallback"
        ToolTipEnabled="True" CrosshairEnabled="False" PaletteName="Pastel Kit">
        <borderoptions visibility="False" />
        <DiagramSerializable>
            <dx:SimpleDiagram Dimension="2" EqualPieSize="False" LabelsResolveOverlappingMinIndent="3"></dx:SimpleDiagram>
        </DiagramSerializable>
        <Legend Visibility="False"></Legend>
        <SeriesSerializable>
            <dx:Series Name="Beverages">
                <points>
                    <dx:SeriesPoint ArgumentSerializable="Chang" SeriesPointID="0" Values="304"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="Chai" SeriesPointID="1" Values="518.4"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="Steeleye Stout" SeriesPointID="2" Values="288"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="Sasquatch Ale" SeriesPointID="3" Values="224"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="Ipoh Coffee" SeriesPointID="4" Values="441.6"></dx:SeriesPoint>
                </points>
                <ViewSerializable>
                    <dx:PieSeriesView MinAllowedSizePercentage="10" RuntimeExploding="False">
                        <Titles>
                            <dx:SeriesTitle />
                        </Titles>
                    </dx:PieSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PieSeriesLabel TextPattern="{A} - {VP:P0}">
                    </dx:PieSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Condiments">
                <Points>
                    <dx:SeriesPoint ArgumentSerializable="Gula Malacca" SeriesPointID="0" Values="325.5"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="Vegie-spread" SeriesPointID="1" Values="175.5"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="Sirop d'érable" SeriesPointID="2" Values="342"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="Genen Shouyu" SeriesPointID="3" Values="400"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="Northwoods Cranberry" SeriesPointID="4" Values="100"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:PieSeriesView MinAllowedSizePercentage="0" RuntimeExploding="False">
                        <titles>
                            <dx:SeriesTitle />
                        </titles>
                    </dx:PieSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PieSeriesLabel TextPattern="{A} - {VP:P0}">
                    </dx:PieSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Dairy Products">
                <Points>
                    <dx:SeriesPoint ArgumentSerializable="Queso Cabrales" SeriesPointID="0" Values="168"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="Mozzarella di Giovanni" SeriesPointID="1" Values="112.2"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="Geitost" SeriesPointID="2" Values="47.5"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="Camembert Pierrot" SeriesPointID="3" Values="1088"></dx:SeriesPoint>
                    <dx:SeriesPoint ArgumentSerializable="Gorgonzola Telino" SeriesPointID="4" Values="200"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:PieSeriesView MinAllowedSizePercentage="10" Rotation="-30" RuntimeExploding="False">
                        <titles>
                            <dx:SeriesTitle />
                        </titles>
                    </dx:PieSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PieSeriesLabel TextPattern="{A} - {VP:P0}">
                    </dx:PieSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <Titles>
            <dx:ChartTitle Text="Company Sales Comparison by Year"></dx:ChartTitle>
        </Titles>
    </dx:WebChartControl>
</asp:Content>
