<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TopNOptions.aspx.cs" Inherits="TopNOptions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxHiddenField runat="server" ID="editValueHiddenField" ClientInstanceName="hfEditValue"></dx:ASPxHiddenField>
    <dx:ASPxCallbackPanel ID="callbackPanel" runat="server" OnCallback="callbackPanel_Callback" ClientInstanceName="callbackPanel">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent2" runat="server">
                            <table style="width: 100%;">
                                <tr>
                                    <td style="width: 100%;">
                                        <table style="width: 100%;">
                                            <tr>
                                                <td class="NoWrap">
                                                    <dx:ASPxLabel ID="lblMode" Text="Mode:" runat="server" />
                                                </td>
                                                <td>
                                                    <div class="spacer" style="width: 5px"></div>
                                                </td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbMode" runat="server" width="150px">
                                                        <Items>
                                                            <dx:ListEditItem Text="Count" Value="Count" />
                                                            <dx:ListEditItem Text="Threshold Value" Value="ThresholdValue" />
                                                            <dx:ListEditItem Text="Threshold Percent" Value="ThresholdPercent" />
                                                        </Items>
                                                        <ClientSideEvents SelectedIndexChanged="function(s, e) { callbackPanel.PerformCallback(&quot;Mode&quot;); }" />
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td>
                                                    <div class="spacer" style="width: 20px"></div>
                                                </td>
                                                <td>
                                                    <dx:ASPxCheckBox ID="cbShowOthers" runat="server" Text="Show &quot;Others&quot;" Wrap="False" >
                                                        <ClientSideEvents ValueChanged="function(s, e) { callbackPanel.PerformCallback(&quot;ShowOthers&quot;); }" />
                                                    </dx:ASPxCheckBox>
                                                </td>
                                                <td>
                                                    <div class="Spacer" style="width: 100%;"></div>
                                                </td>
                                                <td>
                                                    <div class="Spacer" style="width: 100%;"></div>
                                                </td>
                                                <td style="width: 100%;">
                                                    <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Wrap="False">
                                                        <ClientSideEvents CheckedChanged="function(s, e) { callbackPanel.PerformCallback(&quot;Label&quot;); }" />
                                                    </dx:ASPxCheckBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="Spacer" style="width: 100%;height: 5px"></div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="NoWrap">
                                                    <dx:ASPxLabel ID="lblValue" Text="Threshold Percent:" runat="server" width="110px" />
                                                </td>
                                                <td>
                                                    <div class="spacer" style="width: 5px"></div>
                                                </td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="editValue" runat="server" Height="21px" Number="0" width="150px" OnInit="seEditValueInit" ClientInstanceName="seEditValue">
                                                        <ClientSideEvents ValueChanged="function(s, e) { hfEditValue.Set('Value', s.number); callbackPanel.PerformCallback(&quot;Value&quot;);  }" />
                                                    </dx:ASPxSpinEdit>
                                                </td>
                                                <td>
                                                    <div class="spacer" style="width: 20px"></div>
                                                </td>
                                                <td class="NoWrap">
                                                    <dx:ASPxLabel ID="lblOthersArgument" runat="server" Text="&quot;Others&quot; Argument:"/>
                                                </td>
                                                <td>
                                                    <div class="Spacer" style="width: 5px;"></div>
                                                </td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtOthersArgument" runat="server" Width="170px" >
                                                        <ClientSideEvents ValueChanged="function(s, e) { callbackPanel.PerformCallback(&quot;OthersArgument&quot;); }" />
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxRoundPanel>
                <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
                    DataSourceID="AccessDataSource1"  ClientInstanceName="chart" EnableViewState="False" SaveStateOnCallbacks="False">
                    <Titles>
                        <dx:ChartTitle Text="Area of Countries"></dx:ChartTitle>
                        <dx:ChartTitle Alignment="Far" Dock="Bottom" Font="Tahoma, 8pt" Text="From www.nationmaster.com" TextColor="Gray"></dx:ChartTitle>
                    </Titles>
                    <SeriesSerializable>
                        <dx:Series Name="Area of Countries" ArgumentDataMember="Country" ValueDataMembersSerializable="Area" SeriesPointsSorting="Descending" SeriesPointsSortingKey="Value_1" LegendTextPattern="{A}">
                            <ViewSerializable>
                                <dx:Doughnut3DSeriesView></dx:Doughnut3DSeriesView>
                            </ViewSerializable>
                            <LabelSerializable>
                                <dx:Doughnut3DSeriesLabel Position="Tangent" TextPattern="{VP:P2}">
                                </dx:Doughnut3DSeriesLabel>
                            </LabelSerializable>
                            <TopNOptions Enabled="True" ThresholdValue="7000" ThresholdPercent="2.3"></TopNOptions>
                        </dx:Series>
                    </SeriesSerializable>
                    <DiagramSerializable>
                        <dx:SimpleDiagram3D RotationMatrixSerializable="0.990157351881877;-0.0243454369756547;0.13782495497091;0;0.10562840212504;0.776043051453063;-0.621771519897728;0;-0.0918207992710787;0.630209871384037;0.77097630237987;0;0;0;0;1" RuntimeRotation="True" RuntimeScrolling="True" RuntimeZooming="True">
                        </dx:SimpleDiagram3D>
                    </DiagramSerializable>
                    <BorderOptions Visibility="False" />
                </dx:WebChartControl>
                <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/countriesDB.mdb"
                    SelectCommand="SELECT [Country], [OfficialName], [Area] FROM [Countries]">
                </asp:AccessDataSource>
            </dx:PanelContent>
        </PanelCollection>
        <Styles>
            <LoadingPanel HorizontalAlign="Center" VerticalAlign="Middle"></LoadingPanel>
        </Styles>
    </dx:ASPxCallbackPanel>
</asp:Content>
