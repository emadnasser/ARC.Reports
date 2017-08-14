<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MarketValueGraphs_D.ascx.cs" Inherits="ARC.Reports.Controls.MarketValueGraphs_D" %>

<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>

<dx:WebChartControl ID="WebChartControl1" runat="server" Height="480px" CssClass="AlignCenter TopLargeMargin"
    Width="500px" ClientInstanceName="Chart_1" CrosshairEnabled="True" DataSourceID="SqlDataSource1">
<Legend Name="Default Legend"></Legend>
    <SeriesSerializable>
        <dx:Series ArgumentDataMember="s0" LegendTextPattern="{A}" Name="Series 1" ValueDataMembersSerializable="s1">
            <ViewSerializable>
                <dx:PieSeriesView>
                </dx:PieSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:PieSeriesLabel Position="Inside" TextPattern="{A}: {V:n2}">
                </dx:PieSeriesLabel>
            </LabelSerializable>
        </dx:Series>
    </SeriesSerializable>
</dx:WebChartControl>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RepConnection %>" SelectCommand="SELECT Channel s0, SUM(Amount) AS s1, SUM(Transactions) AS s2, SUM(Percentage) AS s3, SUM(TradeShare) AS s4 FROM [dbo].[Rep_001]
WHERE convert(datetime, InsertedDate, 103) = CONVERT(DATE, GETDATE()-1) AND MarketType = 'SAM' GROUP BY Channel"></asp:SqlDataSource>

<p style="direction: ltr">
    &nbsp;</p>


