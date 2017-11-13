<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DateTimeMeasureUnits.aspx.cs" Inherits="DateTimeMeasureUnits" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCallbackPanel ID="callbackPanel" runat="server" ClientInstanceName="callbackPanel" OnCallback="callbackPanel_Callback">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">            
                            <table style="width: 100%;">
                                <tr>
                                    <td class="NoWrap">
                                        <dx:ASPxLabel ID="lbScaleMode" runat="server" Text="Scale Mode:"/>
                                    </td>
                                    <td>
                                        <div class="Spacer" style="width: 5px;"></div>
                                    </td>
                                    <td >
                                        <dx:ASPxComboBox ID="cbScaleMode" Width="95px" runat="server" SelectedIndex="0">
                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {callbackPanel.PerformCallback(&quot;SelectScaleMode&quot;);}" />
                                            <Items>
                                                <dx:ListEditItem Text="Automatic" Value="Automatic" />
                                                <dx:ListEditItem Text="Manual" Value="Manual" />
                                                <dx:ListEditItem Text="Continuous" Value="Continuous" />
                                            </Items>                        
                                        </dx:ASPxComboBox>
                                    </td>
                                    <td><div class="Spacer" style="width: 10px;"></div></td>
                                    <td class="NoWrap">
                                        <dx:ASPxLabel ID="labelGridStart" Text="Grid Alignment:" runat="server" style="text-align: right;" />
                                    </td>
                                    <td>
                                        <div class="spacer" style="width: 5px"></div>
                                    </td>
                                    <td>
                                        <dx:ASPxComboBox ID="cbGridAlignment" Width="80px" runat="server" ClientInstanceName="cbGridAlignment">
                                            <ClientSideEvents SelectedIndexChanged="function(s, e) { callbackPanel.PerformCallback(&quot;SelectGridAlignment&quot;); }" />               
                                        </dx:ASPxComboBox>
                                    </td>
                                    <td><div class="Spacer" style="width: 10px;"></div></td>
                                    <td class="NoWrap">
                                        <dx:ASPxCheckBox ID="chbAutoGrid" runat="server" Checked="True" Text="Auto Grid">
                                            <ClientSideEvents CheckedChanged="function(s, e) { callbackPanel.PerformCallback(&quot;SetAutoGrid&quot;); }" />               
                                        </dx:ASPxCheckBox>
                                    </td>
                                    <td style="width: 100%;"><div class="Spacer" ></div></td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="spacer" style="height: 5px"></div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="NoWrap"><dx:ASPxLabel ID="lblViewType" runat="server" Text="Measure Unit:"/></td>
                                    <td><div class="Spacer" style="width: 5px;"></div></td>
                                    <td>
                                        <dx:ASPxComboBox ID="cbMeasureUnits" Width="95px" runat="server" SelectedIndex="0">
                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {callbackPanel.PerformCallback(&quot;SelectMeasureUnits&quot;);}" />
                                                <Items>
                                                    <dx:ListEditItem Text="Week" Value="Week" />
                                                    <dx:ListEditItem Text="Month" Value="Month" />
                                                    <dx:ListEditItem Text="Quarter" Value="Quarter" />
                                                    <dx:ListEditItem Text="Year" Value="Year" />
                                                </Items>                        
                                        </dx:ASPxComboBox>
                                    </td>
                                    <td><div class="Spacer" style="width: 10px;"></div></td>
                                    <td class="NoWrap">
                                        <dx:ASPxLabel ID="lblAggregateFunction" runat="server" Text="Aggregate Function:"/>
                                    </td>
                                    <td>
                                        <div class="Spacer" style="width: 5px;"></div>
                                    </td>
                                    <td>
                                        <dx:ASPxComboBox ID="cbAggregateFunction" Width="80px" runat="server" SelectedIndex="3">
                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {callbackPanel.PerformCallback(&quot;SelectAggregateFunction&quot;);}" />
                                            <Items>
                                                <dx:ListEditItem Text="Average" Value="Average" />
                                                <dx:ListEditItem Text="Minimum" Value="Minimum" />
                                                <dx:ListEditItem Text="Maximum" Value="Maximum" />
                                                <dx:ListEditItem Text="Sum" Value="Sum" />
                                                <dx:ListEditItem Text="Count" Value="Count" />
                                            </Items>                        
                                        </dx:ASPxComboBox>
                                    </td>
                                </tr>
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxRoundPanel>
                <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
                        ClientInstanceName="chart" CrosshairEnabled="True">
                    <SeriesSerializable>
                        <dx:Series Name="Orders" ArgumentScaleType="DateTime" LabelsVisibility="False">
                            <ViewSerializable>
                                <dx:SideBySideBarSeriesView></dx:SideBySideBarSeriesView>
                            </ViewSerializable>
                        </dx:Series>
                    </SeriesSerializable>
                    <Legend Visibility="False"></Legend>
                    <BorderOptions Visibility="False" />
                    <Titles>
                        <dx:ChartTitle Text="Orders"></dx:ChartTitle>
                    </Titles>
                    <DiagramSerializable>
                        <dx:XYDiagram>
                            <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" MinorCount="3">                                 
                                <GridLines Visible="True"></GridLines>
                                <DateTimeScaleOptions ScaleMode="Automatic" AutoGrid="False" AggregateFunction="Sum"></DateTimeScaleOptions>
                            </AxisX>
                            <AxisY Title-Text="Thousands of Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1">
                                <GridLines MinorVisible="True"></GridLines>
                            </AxisY>
                        </dx:XYDiagram>
                    </DiagramSerializable>
                </dx:WebChartControl>
                <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
                    SelectCommand="SELECT [Freight], [OrderDate] FROM [Orders]">
                </asp:AccessDataSource>
            </dx:PanelContent>
        </PanelCollection>
     </dx:ASPxCallbackPanel>
</asp:Content>
