<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MarketChannelsGraphs_Y.ascx.cs" Inherits="ARC.Reports.Controls.MarketChannelsGraphs_Y" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Xpo.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Xpo" TagPrefix="dx" %>

<dx:WebChartControl ID="WebChartControl" ClientInstanceName="Chart" Width="1000px" Height="480px" CssClass="AlignCenter TopLargeMargin" runat="server" CrosshairEnabled="True">
    <SeriesSerializable>
        <dx:Series ArgumentDataMember="Month" Name="Internet" CrosshairLabelPattern="{S}: {V:n2}%" LabelsVisibility="True" ValueDataMembersSerializable="MarketShare">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="Internet" />
            </DataFilters>
            <ViewSerializable>
                <dx:StackedBarSeriesView>
                </dx:StackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:StackedBarSeriesLabel TextPattern="{S}: {V:n2}%">
                </dx:StackedBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="Month" Name="Mobile" CrosshairLabelPattern="{S}: {V:n2}%" LabelsVisibility="True" ValueDataMembersSerializable="MarketShare">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="Mobile" />
            </DataFilters>
            <ViewSerializable>
                <dx:StackedBarSeriesView>
                </dx:StackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:StackedBarSeriesLabel TextPattern="{S}: {V:n2}%">
                </dx:StackedBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="Month" Name="CTF" CrosshairLabelPattern="{S}: {V:n2}%" LabelsVisibility="True" ValueDataMembersSerializable="MarketShare">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="CTF" />
            </DataFilters>
            <ViewSerializable>
                <dx:StackedBarSeriesView>
                </dx:StackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:StackedBarSeriesLabel TextPattern="{S}: {V:n2}%">
                </dx:StackedBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="Month" Name="PTC" CrosshairLabelPattern="{S}: {V:n2}%" LabelsVisibility="True" ValueDataMembersSerializable="MarketShare">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="PTC" />
            </DataFilters>
            <ViewSerializable>
                <dx:StackedBarSeriesView>
                </dx:StackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:StackedBarSeriesLabel TextPattern="{S}: {V:n2}%">
                </dx:StackedBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="Month" Name="CTU" CrosshairLabelPattern="{S}: {V:n2}%" LabelsVisibility="True" ValueDataMembersSerializable="MarketShare">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="CTU" />
            </DataFilters>
            <ViewSerializable>
                <dx:StackedBarSeriesView>
                </dx:StackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:StackedBarSeriesLabel TextPattern="{S}: {V:n2}">
                </dx:StackedBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="Month" Name="ETS" CrosshairLabelPattern="{S}: {V:n2}%" LabelsVisibility="True" ValueDataMembersSerializable="MarketShare">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="ETS" />
            </DataFilters>
            <ViewSerializable>
                <dx:StackedBarSeriesView>
                </dx:StackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:StackedBarSeriesLabel TextPattern="{S}: {V:n2}%">
                </dx:StackedBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="Month" Name="APT" CrosshairLabelPattern="{S}: {V:n2}%" LabelsVisibility="True" ValueDataMembersSerializable="MarketShare">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="APT" />
            </DataFilters>
            <ViewSerializable>
                <dx:StackedBarSeriesView>
                </dx:StackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:StackedBarSeriesLabel TextPattern="{S}: {V:n2}%">
                </dx:StackedBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="Month" Name="AMS" CrosshairLabelPattern="{S}: {V:n2}%" LabelsVisibility="True" ValueDataMembersSerializable="MarketShare">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="AMS" />
            </DataFilters>
            <ViewSerializable>
                <dx:StackedBarSeriesView>
                </dx:StackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:StackedBarSeriesLabel TextPattern="{S}: {V:n2}%">
                </dx:StackedBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="Month" Name="Branches" CrosshairLabelPattern="{S}: {V:n2}%" LabelsVisibility="True" ValueDataMembersSerializable="MarketShare">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="Branches" />
            </DataFilters>
            <ViewSerializable>
                <dx:StackedBarSeriesView>
                </dx:StackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:StackedBarSeriesLabel TextPattern="{S}: {V:n2}%">
                </dx:StackedBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="Month" Name="IPO" CrosshairLabelPattern="{S}: {V:n2}%" LabelsVisibility="True" ValueDataMembersSerializable="MarketShare">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="IPO" />
            </DataFilters>
            <ViewSerializable>
                <dx:StackedBarSeriesView>
                </dx:StackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:StackedBarSeriesLabel TextPattern="{S}: {V:n2}%">
                </dx:StackedBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="Month" Name="ORM" CrosshairLabelPattern="{S}: {V:n2}%" LabelsVisibility="True" ValueDataMembersSerializable="MarketShare">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="ORM" />
            </DataFilters>
            <ViewSerializable>
                <dx:StackedBarSeriesView>
                </dx:StackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:StackedBarSeriesLabel TextPattern="{S}: {V:n2}%">
                </dx:StackedBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="Month" Name="OPR" CrosshairLabelPattern="{S}: {V:n2}%" LabelsVisibility="True" ValueDataMembersSerializable="MarketShare">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="OPR" />
            </DataFilters>
            <ViewSerializable>
                <dx:StackedBarSeriesView>
                </dx:StackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:StackedBarSeriesLabel TextPattern="{S}: {V:n2}%">
                </dx:StackedBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
    </SeriesSerializable>
    <CrosshairOptions ArgumentLineColor="DeepSkyBlue" ArgumentLineStyle-Thickness="2"
        ShowOnlyInFocusedPane="False">
    </CrosshairOptions>
    <Legend AlignmentHorizontal="Right" Direction="LeftToRight" AlignmentVertical="BottomOutside" MarkerSize="18, 35" Visibility="True" UseCheckBoxes="True">
        <Border Visibility="True" />
    </Legend>
    <BorderOptions Visibility="False" />
    <DiagramSerializable>
        <dx:XYDiagram>
            <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" Interlaced="True" InterlacedColor="244, 243, 237" Title-Visibility="Default" MinorCount="12" Visibility="True">
                <GridLines Visible="True"></GridLines>
                <ScaleBreakOptions Style="Straight" />
                <Tickmarks MinorVisible="False" />
                <Label Staggered="True"></Label>
                <CrosshairAxisLabelOptions Pattern="{A}" />
                <DateTimeScaleOptions AutoGrid="False" WorkdaysOnly="True" AggregateFunction="None" ProcessMissingPoints="InsertZeroValues" GridAlignment="Month" MeasureUnit="Month" >
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



