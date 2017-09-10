<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="ARC.Reports.Pages.WebForm3" %>

<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


        <dx:WebChartControl ID="WebChartControl1" runat="server" Height="480px"
            Width="700px" ClientInstanceName="chart" SeriesDataMember="LastName" CssClass="AlignCenter TopLargeMargin"
            DataSourceID="AccessDataSource1"
            CrosshairEnabled="False" ToolTipEnabled="True">
            <SeriesTemplate ArgumentDataMember="OrderDate" ArgumentScaleType="DateTime" SummaryFunction="SUM([Freight])" ToolTipHintDataMember="FirstName" ToolTipPointPattern="<div style='margin-left:8px;'>Name: {HINT} {S}&lt;br /&gt;&lt;br /&gt;Year: {A:yyyy}&lt;br /&gt;Total sales: {V}</div>">
                <ViewSerializable>
                    <dx:SideBySideBarSeriesView></dx:SideBySideBarSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:SideBySideBarSeriesLabel ResolveOverlappingMode="Default"></dx:SideBySideBarSeriesLabel>
                </LabelSerializable>
            </SeriesTemplate>
            <Legend Visibility="True"></Legend>
            <BorderOptions Visibility="False" />
            <DiagramSerializable>
                <dx:XYDiagram>
                    <AxisX Title-Text="Date" VisibleInPanesSerializable="-1">
                        <DateTimeScaleOptions MeasureUnit="Year" GridAlignment="Year" />
                        <Label TextPattern="{A:yyyy}">
                        </Label>
                    </AxisX>
                    <AxisY Title-Text="Thousands of Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1">
                    </AxisY>
                </dx:XYDiagram>
            </DiagramSerializable>
        </dx:WebChartControl>


        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT Orders.OrderDate, Orders.Freight, Employees.LastName, Employees.FirstName, Employees.Photo FROM (Orders INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID)"></asp:AccessDataSource>



    </form>
</body>
</html>
