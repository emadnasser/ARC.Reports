<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ErrorBars.aspx.cs" Inherits="ErrorBars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
     <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table class="OptionsTable" style="width: 100%;">
                <tr>
                    <td style="width: 90px"><dx:ASPxLabel ID="lblSeriesView" runat="server" Text="Series View:"/></td>
                    <td class="auto-style6">
                        <dx:ASPxComboBox ID="cmbSeriesView" runat="server" ValueType="System.String" Width="202px" >
                            <ClientSideEvents SelectedIndexChanged="function(s, e) {chart.PerformCallback(&quot;ChangeSeriesView&quot;);}" />
                            <Items>
                                <dx:ListEditItem Text="Bar" Value="Bar" Selected="True" />
                                <dx:ListEditItem Text="Point" Value="Point" />
                            </Items>
                        </dx:ASPxComboBox>
                    </td>
                    
                    <td class="auto-style7"><dx:ASPxLabel ID="lblEndStyle" runat="server" Text="End Style:"/></td>
                    <td>
                        <dx:ASPxComboBox ID="cmbEndStyle" runat="server" ValueType="System.String" Width="202px" >
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;ChangeEndStyle&quot;);}" />
                            <Items>
                                <dx:ListEditItem Text="Cap" Value="Cap" Selected="True" />
                                <dx:ListEditItem Text="No Cap" Value="No Cap" />
                            </Items>
                        </dx:ASPxComboBox>
                    </td>
   
                </tr>
                <tr>
                    <td >
                        <dx:ASPxLabel ID="lblKind" runat="server" Text="Error Bars Kind:"/>
                    </td>
                    <td class="auto-style6">
                        <dx:ASPxComboBox ID="cmbKind" runat="server" ValueType="System.String" ClientInstanceName="cmbbKind" Width="202px" >
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;ChangeErrorBarsKind&quot;);}" />
                            <Items>
                                <dx:ListEditItem Text="Fixed Values" Value="Fixed Values" Selected="True" />
                                <dx:ListEditItem Text="Percentage" Value="Percentage" />
                                <dx:ListEditItem Text="Standard Deviation" Value="Standard Deviation" />
                                <dx:ListEditItem Text="Standard Error" Value="Standard Error" />
                                <dx:ListEditItem Text="Data Source" Value="Data Source" />
                            </Items>
                        </dx:ASPxComboBox>
                    </td>
                    <td class="auto-style7" >
                        <dx:ASPxLabel ID="lblDirection" runat="server" Text="Direction:"/>
                    </td>
                    <td>
                        <dx:ASPxComboBox ID="cmbDirection" runat="server" ValueType="System.String" ClientInstanceName="cmbbKind" Width="202px" >
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;ChangeErrorBarsDirection&quot;); }" />
                            <Items>
                                <dx:ListEditItem Text="Both" Value="Both" Selected="True" />
                                <dx:ListEditItem Text="Minus" Value="Minus" />
                                <dx:ListEditItem Text="Plus" Value="Plus" />
                            </Items>
                        </dx:ASPxComboBox>
                    </td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
     <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetDataSource" TypeName="DataSourceItem"></asp:ObjectDataSource>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        ClientInstanceName="chart" OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="True" DataSourceID="ObjectDataSource1" >
<DiagramSerializable>
<dx:XYDiagram>
<AxisX VisibleInPanesSerializable="-1">
    <tickmarks minorvisible="False" />
    </AxisX>
<AxisY VisibleInPanesSerializable="-1">
    <visualrange autosidemargins="False" sidemarginsvalue="0" />
    <wholerange auto="False" autosidemargins="False" maxvalueserializable="65" minvalueserializable="0" sidemarginsvalue="0" />
    </AxisY>
</dx:XYDiagram>
</DiagramSerializable>
        <Legend Name="Default Legend" visibility="False">
        </Legend>
        <SeriesSerializable>
            <dx:Series Name="Series 1" ArgumentDataMember="Argument" ValueDataMembersSerializable="Value">
            </dx:Series>
        </SeriesSerializable>
        <BorderOptions Visibility="False"></BorderOptions>
    </dx:WebChartControl>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="CustomHeadHolder">
    <style type="text/css">
        .auto-style6 {
            width: 214px;
        }
        .auto-style7 {
            width: 66px;
        }
    </style>
</asp:Content>
