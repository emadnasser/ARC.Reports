﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MarketChannelsGraphs_D.ascx.cs" Inherits="ARC.Reports.Controls.MarketChannelsGraphs_D" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Xpo.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Xpo" TagPrefix="dx" %>
<div class="row">
    <div class="col-sm-12">
        <div class="widget-box transparent">
            <div class="widget-header widget-header-flat">
                <h4 class="widget-title lighter">
                    <i class="ace-icon fa fa-signal"></i>
                    Market Trades
                </h4>
                <div class="widget-toolbar">
                    <a href="#" data-action="collapse">
                        <i class="ace-icon fa fa-chevron-up"></i>
                    </a>
                </div>
            </div>
            <div class="widget-body">
                <div class="widget-main no-padding">
                    <dx:WebChartControl ID="WebChartControl" ClientInstanceName="Chart" Width="1000px" Height="480px" CssClass="AlignCenter TopLargeMargin" runat="server" CrosshairEnabled="True">
                        <SeriesSerializable>
                            <dx:Series ArgumentDataMember="Channel" Name="Channel" CrosshairLabelPattern="{S}: {V:n2}%" LabelsVisibility="True" ValueDataMembersSerializable="TradeShare">
                                <LabelSerializable>
                                    <dx:SideBySideBarSeriesLabel TextPattern="{S}: {V:n2}%">
                                    </dx:SideBySideBarSeriesLabel>
                                </LabelSerializable>
                            </dx:Series>
                        </SeriesSerializable>
                        <CrosshairOptions ArgumentLineColor="DeepSkyBlue" ArgumentLineStyle-Thickness="2"
                            ShowOnlyInFocusedPane="False">
                        </CrosshairOptions>
                        <Legend AlignmentHorizontal="Right" Direction="LeftToRight" AlignmentVertical="BottomOutside" MarkerSize="18, 35" Visibility="False" UseCheckBoxes="True">
                            <Border Visibility="True" />
                        </Legend>
                        <BorderOptions Visibility="False" />
                        <DiagramSerializable>
                            <dx:XYDiagram>
                                <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" Interlaced="True" InterlacedColor="244, 243, 237" Title-Visibility="Default" MinorCount="12" Visibility="True">
                                    <GridLines Visible="True"></GridLines>
                                    <ScaleBreakOptions Style="straight" />
                                    <Tickmarks MinorVisible="False" />
                                    <Label Staggered="True"></Label>
                                    <CrosshairAxisLabelOptions Pattern="{A}" />
                                    <DateTimeScaleOptions AutoGrid="False" WorkdaysOnly="True" AggregateFunction="None" ProcessMissingPoints="InsertZeroValues" GridAlignment="Month" MeasureUnit="Month">
                                        <WorkdaysOptions Workdays="Sunday, Monday, Tuesday, Wednesday, Thursday">
                                        </WorkdaysOptions>
                                    </DateTimeScaleOptions>
                                </AxisX>
                                <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1" Visibility="True">
                                    <Tickmarks MinorVisible="False" />
                                    <Label TextPattern="{V:G}">
                                    </Label>
                                </AxisY>
                            </dx:XYDiagram>
                        </DiagramSerializable>
                    </dx:WebChartControl>
                </div>
            </div>
        </div>
    </div>
</div>
