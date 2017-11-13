<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomChartIntegration.aspx.cs"
    Inherits="ChartsIntegration_CustomChartData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <asp:UpdatePanel runat="server" ID="updatePanel1">
        <ContentTemplate>
            <table class="OptionsTable BottomMargin">
                <tr>
                    <td>
                        <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" ShowHeader="True" HeaderText="Pivot Grid Settings">
                            <PanelCollection>
                                <dx:PanelContent runat="server">
                                    <table class="OptionsTable">
                                        <tr>
                                            <td>
                                                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Row Field Value Export Rule:" />
                                            </td>
                                            <td colspan="2">
                                                <dx:ASPxComboBox ID="RowValueExport" runat="server" AutoPostBack="True" Width="100%"
                                                    ValueType="System.String" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Export Cell Values less than:" />
                                            </td>
                                            <td>
                                                <dx:ASPxSpinEdit ID="CellValueThreshold" runat="server" AutoPostBack="True" />
                                            </td>
                                            <td>
                                                <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="as zero values" />
                                            </td>
                                        </tr>
                                    </table>
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxRoundPanel>
                    </td>
                    <td>
                        <dx:ASPxRoundPanel ID="ASPxRoundPanel2" runat="server" ShowHeader="True" HeaderText="Chart Settings">
                            <PanelCollection>
                                <dx:PanelContent runat="server">
                                    <table class="OptionsTable">
                                        <tr>
                                            <td>
                                                <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Chart Type:" />
                                            </td>
                                            <td>
                                                <dx:ASPxComboBox ID="ChartType" runat="server" OnValueChanged="ChartType_ValueChanged"
                                                    AutoPostBack="True" ValueType="System.String" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <dx:ASPxCheckBox ID="PointLabels" runat="server" Text="Show Point Labels" OnCheckedChanged="PointLabels_CheckedChanged"
                                                    AutoPostBack="True" />
                                            </td>
                                        </tr>
                                    </table>
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxRoundPanel>
                    </td>
                </tr>
            </table>
            <dx:ASPxPivotGrid ID="ASPxPivotGrid" runat="server" DataSourceID="SalesPersonsDataSource"
                EnableCallBacks="False" Width="830px" OnCustomChartDataSourceData="ASPxPivotGrid_CustomChartDataSourceData"
                OptionsView-ShowFilterHeaders="False">
                <Fields>
                    <dx:PivotGridField FieldName="Extended_Price" ID="fieldExtendedPrice" Area="DataArea"
                        AreaIndex="0" Caption="Extended Price" Options-AllowDrag="False" />
                    <dx:PivotGridField FieldName="CategoryName" ID="fieldCategoryName" Area="RowArea"
                        AreaIndex="0" Caption="Category Name" Options-AllowDrag="False" />
                    <dx:PivotGridField FieldName="ProductName" ID="fieldProductName" Area="RowArea" AreaIndex="1"
                        Caption="Product Name" Options-AllowDrag="False" />
                    <dx:PivotGridField FieldName="OrderDate" ID="fieldYear" Area="ColumnArea" AreaIndex="0"
                        GroupInterval="DateYear" UnboundFieldName="fieldOrderYear" Caption="Year" Options-AllowDrag="False"
                        GroupIndex="0" InnerGroupIndex="0" Options-ShowCustomTotals="False" Options-ShowGrandTotal="False"
                        Options-ShowTotals="False" AllowedAreas="ColumnArea" />
                    <dx:PivotGridField FieldName="OrderDate" ID="fieldQuarter" Area="ColumnArea" AreaIndex="1"
                        GroupInterval="DateQuarter" UnboundFieldName="fieldOrderQuarter" Caption="Quarter"
                        Options-AllowDrag="False" GroupIndex="0" InnerGroupIndex="1" Options-ShowCustomTotals="False"
                        Options-ShowGrandTotal="False" Options-ShowTotals="False" AllowedAreas="ColumnArea" />
                    <dx:PivotGridField FieldName="OrderDate" ID="fieldMonth" Area="ColumnArea" AreaIndex="2"
                        GroupInterval="DateMonth" UnboundFieldName="fieldOrderMonth" Caption="Month"
                        Options-AllowDrag="False" GroupIndex="0" InnerGroupIndex="2" Options-ShowCustomTotals="False"
                        Options-ShowGrandTotal="False" Options-ShowTotals="False" AllowedAreas="ColumnArea" />
                </Fields>
                <OptionsView HorizontalScrollBarMode="Auto" />
                <OptionsFilter NativeCheckBoxes="False" />
                <Groups>
                    <dx:PivotGridWebGroup />
                </Groups>
                <OptionsChartDataSource FieldValuesProvideMode="Value" ProvideColumnCustomTotals="False"
                    ProvideColumnGrandTotals="False" ProvideColumnTotals="False" ProvideRowTotals="false"
                    ProvideRowGrandTotals="False" ProvideDataByColumns="False" DataProvideMode="UseCustomSettings" />
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
