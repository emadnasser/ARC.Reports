<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TextAnnotation.aspx.cs" Inherits="TextAnnotationDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <table class="OptionsTable">
                    <tr>
                        <td><dx:ASPxLabel ID="lbShape" Text="Shape:" runat="server" /></td>
                        <td>
                            <dx:ASPxComboBox ID="cbShape" runat="server" Width="140px" ValueType="System.String" SelectedIndex="1">
                                <ClientSideEvents ValueChanged="function(s, e) { chart.PerformCallback(); }" />
                                <Items>
                                    <dx:ListEditItem Text="Rectangle" Value="0" />
                                    <dx:ListEditItem Selected="True" Text="Rounded Rectangle" Value="1" />
                                    <dx:ListEditItem Text="Ellipse" Value="2" />
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                        <td><dx:ASPxLabel ID="lbAngle" Text="Angle:" runat="server" /></td>
                        <td>
                            <dx:ASPxComboBox ID="cbAngle" runat="server" Width="50px" ValueType="System.String">
                                <ClientSideEvents ValueChanged="function(s, e) { chart.PerformCallback(); }" />
                            </dx:ASPxComboBox>
                        </td>
                        <td>
                            <dx:ASPxButton ID="btnGeneratePoints" runat="server" Text="Generate Points" AutoPostBack="False">
                                <ClientSideEvents Click="function(s, e) { chart.PerformCallback(&quot;Points&quot;); }" />
                            </dx:ASPxButton>
                        </td>
                    </tr>
                    <tr>
                        <td><dx:ASPxLabel ID="lbConnector" Text="Connector:" runat="server" /></td>
                        <td>
                            <dx:ASPxComboBox ID="cbConnector" runat="server" Width="140px" ValueType="System.String">
                                <ClientSideEvents ValueChanged="function(s, e) { chart.PerformCallback(); }" />
                                <Items>
                                    <dx:ListEditItem Text="None" Value="0" />
                                    <dx:ListEditItem Selected="True" Text="Tail" Value="1" />
                                    <dx:ListEditItem Text="Arrow" Value="2" />
                                    <dx:ListEditItem Text="Notched Arrow" Value="3" />
                                    <dx:ListEditItem Text="Line" Value="4" />
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                        <td colspan="3">
                            <dx:ASPxCheckBox ID="chbShowLabels" Text="Show&nbsp;Labels" runat="server" Checked="True">
                                <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(); }" />
                            </dx:ASPxCheckBox>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px"
        ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
        OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="False"
        ToolTipEnabled="False">
        <SeriesSerializable>
            <dx:Series Name="Random Series" ArgumentScaleType="Numerical">
                <ViewSerializable>
                    <dx:SideBySideBarSeriesView></dx:SideBySideBarSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:SideBySideBarSeriesLabel Position="Center">
                    </dx:SideBySideBarSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <Legend Visibility="False"></Legend>
        <BorderOptions Visibility="False"></BorderOptions>
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX VisibleInPanesSerializable="-1">                    
                </AxisX>
                <AxisY VisibleInPanesSerializable="-1">
                    <WholeRange Auto="False" MinValueSerializable="0" MaxValueSerializable="13" AutoSideMargins="False" SideMarginsValue="0" ></WholeRange>
                </AxisY>
                <DefaultPane EnableAxisXScrolling="False" EnableAxisYScrolling="False" EnableAxisXZooming="False" EnableAxisYZooming="False"></DefaultPane>
            </dx:XYDiagram>
        </DiagramSerializable>
    </dx:WebChartControl>
</asp:Content>
