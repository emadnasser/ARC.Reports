<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MarketChannelsGraphs_Y.ascx.cs" Inherits="ARC.Reports.Controls.MarketChannelsGraphs_Y" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v16.2.Web, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Xpo.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Xpo" TagPrefix="dx" %>

<dx:WebChartControl ID="WebChartControl3" ClientInstanceName="Chart_3" CrosshairEnabled="True"
    Width="1000px" Height="480px" CssClass="AlignCenter TopLargeMargin" runat="server" DataSourceID="ObjectDataSource1">

    <SeriesSerializable>
        <dx:Series ArgumentDataMember="date" Name="APT" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True" CrosshairLabelVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="APT" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="AMS" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="AMS" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="Branches" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="Branches" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="CTF" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="CTF" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="CTU" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="CTU" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="ETS" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="ETS" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="Internet" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="Internet" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="IPO" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="IPO" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="Mobile" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="Mobile" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="ORM" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="ORM" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="OPR" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="OPR" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="PTC" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="PTC" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}">
                </dx:SideBySideBarSeriesLabel>
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
        <dx:XYDiagram PaneDistance="4">
            <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" Interlaced="True" InterlacedColor="244, 243, 237">
                <GridLines Visible="True"></GridLines>
                <Tickmarks MinorVisible="False" />
                <Label Staggered="True" TextPattern="{A:MM/yyyy}">
                </Label>
                <CrosshairAxisLabelOptions Pattern="MM/yyyy" />
                <DateTimeScaleOptions MeasureUnit="Month" GridAlignment="Month" AutoGrid="True" WorkdaysOnly="True" />
            </AxisX>
            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                <ScaleBreakOptions Style="waved" />
                <Tickmarks MinorVisible="False" />
                <Label TextPattern="{V:G}">
                </Label>
                <NumericScaleOptions AutoGrid="False" />
            </AxisY>
            <DefaultPane Weight="2"></DefaultPane>
        </dx:XYDiagram>
    </DiagramSerializable>
</dx:WebChartControl>

<dx:WebChartControl ID="WebChartControl1" ClientInstanceName="Chart_3" CrosshairEnabled="True"
    Width="1000px" Height="480px" CssClass="AlignCenter TopLargeMargin" runat="server" DataSourceID="ObjectDataSource1">

    <SeriesSerializable>
        <dx:Series ArgumentDataMember="date" Name="APT" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True" CrosshairLabelVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="APT" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="AMS" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="AMS" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="Branches" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="Branches" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="CTF" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="CTF" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="CTU" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="CTU" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="ETS" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="ETS" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="Internet" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="Internet" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="IPO" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="IPO" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="Mobile" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="Mobile" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="ORM" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="ORM" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="OPR" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="OPR" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}" LineLength="4" Position="Top">
                </dx:SideBySideBarSeriesLabel>
            </LabelSerializable>
        </dx:Series>
        <dx:Series ArgumentDataMember="date" Name="PTC" ValueDataMembersSerializable="Percentage" CrosshairLabelPattern="{S}: {V:n2}" LabelsVisibility="True">
            <DataFilters>
                <dx:DataFilter ColumnName="Channel" InvariantValueSerializable="PTC" />
            </DataFilters>
            <LabelSerializable>
                <dx:SideBySideBarSeriesLabel TextPattern="{V:n2}">
                </dx:SideBySideBarSeriesLabel>
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
        <dx:XYDiagram PaneDistance="4">
            <AxisX Title-Text="Date" VisibleInPanesSerializable="-1" Interlaced="True" InterlacedColor="244, 243, 237">
                <GridLines Visible="True"></GridLines>
                <Tickmarks MinorVisible="False" />
                <Label Staggered="True" TextPattern="{A:MM/yyyy}">
                </Label>
                <CrosshairAxisLabelOptions Pattern="MM/yyyy" />
                <DateTimeScaleOptions MeasureUnit="Month" GridAlignment="Month" AutoGrid="True" WorkdaysOnly="True" />
            </AxisX>
            <AxisY Title-Text="Market Share Value" Title-Font="Tahoma, 10pt" VisibleInPanesSerializable="-1">
                <ScaleBreakOptions Style="waved" />
                <Tickmarks MinorVisible="False" />
                <Label TextPattern="{V:G}">
                </Label>
                <NumericScaleOptions AutoGrid="False" />
            </AxisY>
            <DefaultPane Weight="2"></DefaultPane>
        </dx:XYDiagram>
    </DiagramSerializable>
</dx:WebChartControl>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="MarketShareGraphsChannels" TypeName="ARC.Reports.DAL.SData">
    <SelectParameters>
        <asp:Parameter DefaultValue="0" Name="pMarketType" Type="Int32" />
        <asp:Parameter DefaultValue="4" Name="pDateType" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>

