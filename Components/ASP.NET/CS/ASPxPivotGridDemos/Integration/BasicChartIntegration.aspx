<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BasicChartIntegration.aspx.cs"
    Inherits="ChartsIntegration_GeneralOptions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <asp:UpdatePanel runat="server" ID="updatePanel1">
        <ContentTemplate>
            <table class="OptionsTable OptionsBottomMargin">
                <tr>
                    <td colspan="2">
                        <dx:ASPxComboBox ID="ChartType" runat="server" OnValueChanged="ChartType_ValueChanged"
                            AutoPostBack="True" ValueType="System.String" Caption="Chart Type">
                        </dx:ASPxComboBox>
                    </td>
                    <td>
                        <dx:ASPxCheckBox runat="server" Text="Show Column Grand Totals" AutoPostBack="True"
                            ID="ShowColumnGrandTotals" OnCheckedChanged="ShowColumnGrandTotals_CheckedChanged"
                            Wrap="False" />
                    </td>
                    <td>
                        <dx:ASPxCheckBox runat="server" Text="Generate Series from Columns" AutoPostBack="True"
                            ID="ChartDataVertical" OnCheckedChanged="ChartDataVertical_CheckedChanged" Wrap="False" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>
                        <dx:ASPxCheckBox ID="PointLabels" runat="server" Text="Show Point Labels" OnCheckedChanged="PointLabels_CheckedChanged"
                            AutoPostBack="True" Wrap="False" />
                    </td>
                    <td>
                        <dx:ASPxCheckBox runat="server" Checked="True" Text="Show Row Grand Totals" AutoPostBack="True"
                            ID="ShowRowGrandTotals" OnCheckedChanged="ShowRowGrandTotals_CheckedChanged"
                            Wrap="False" />
                    </td>
                </tr>
            </table>
            <dx:ASPxPivotGrid ID="ASPxPivotGrid" runat="server" DataSourceID="SalesPersonsDataSource"
                EnableCallBacks="false" OnPreRender="ASPxPivotGrid_PreRender" Width="830px">
                <Fields>
                    <dx:PivotGridField FieldName="Extended_Price" ID="fieldExtendedPrice" Area="DataArea"
                        AreaIndex="0" Caption="Extended Price" />
                    <dx:PivotGridField FieldName="CategoryName" ID="fieldCategoryName" Area="RowArea"
                        AreaIndex="0" Caption="Category Name" />
                    <dx:PivotGridField FieldName="OrderDate" ID="fieldOrderMonth" Area="ColumnArea" AreaIndex="0"
                        GroupInterval="DateMonth" UnboundFieldName="fieldOrderDateMonth" Caption="Order Month" />
                    <dx:PivotGridField FieldName="OrderDate" ID="fieldOrderYear" Area="FilterArea" AreaIndex="0"
                        GroupInterval="DateYear" UnboundFieldName="fieldOrderDateYear" Caption="Order Year" />
                </Fields>
                <OptionsView HorizontalScrollBarMode="Auto" />
                <OptionsFilter NativeCheckBoxes="False" />
                <OptionsChartDataSource DataProvideMode="UseCustomSettings" />
            </dx:ASPxPivotGrid>
            <dxcharts:WebChartControl ID="WebChart" runat="server" DataSourceID="ASPxPivotGrid"
                Width="830px" Height="300px" SeriesDataMember="Series" CssClass="TopMargin">
                <Legend MaxHorizontalPercentage="30"></Legend>
                <SeriesTemplate ArgumentDataMember="Arguments" ValueDataMembersSerializable="Values">
                    <ViewSerializable>
                        <dxcharts:SideBySideBarSeriesView />
                    </ViewSerializable>
                    <LabelSerializable>
                        <dxcharts:SideBySideBarSeriesLabel>
                            <FillStyle>
                                <OptionsSerializable>
                                    <dxcharts:SolidFillOptions />
                                </OptionsSerializable>
                            </FillStyle>
                            <PointOptionsSerializable>
                                <dxcharts:PointOptions />
                            </PointOptionsSerializable>
                        </dxcharts:SideBySideBarSeriesLabel>
                    </LabelSerializable>
                </SeriesTemplate>
                <DiagramSerializable>
                    <dxcharts:XYDiagram>
                        <AxisX VisibleInPanesSerializable="-1">
                            <Label Staggered="True" />
                        </AxisX>
                        <AxisY VisibleInPanesSerializable="-1">
                        </AxisY>
                    </dxcharts:XYDiagram>
                </DiagramSerializable>
                <FillStyle>
                    <OptionsSerializable>
                        <dxcharts:SolidFillOptions />
                    </OptionsSerializable>
                </FillStyle>
                <Legend MaxHorizontalPercentage="30" />
                <BorderOptions Visibility="False"></BorderOptions>
            </dxcharts:WebChartControl>
        </ContentTemplate>
    </asp:UpdatePanel>
    <ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" />
</asp:Content>
