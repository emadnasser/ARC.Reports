<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SeriesBinding.aspx.cs" Inherits="SeriesBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;">
                        <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels">
                            <ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblFilterByCategory" runat="server" Text="Filter By Category:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbFilterByCategory" runat="server" Width="110px">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;FilterByCategory&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblSortBy" runat="server" Text="Sort By:" ClientInstanceName="labelSortBy"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbSortBy" runat="server" Width="80px" ClientInstanceName="cmbSortBy">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;SortBy&quot;); }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap"><dx:ASPxLabel ID="lblSortOrder" runat="server" Text="Sort Order:"/></td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td><dx:ASPxComboBox ID="cbSortOrder" runat="server" Width="95px" ClientInstanceName="cmbSortOrder">
                        <ClientSideEvents SelectedIndexChanged="function(s, e) {
	var enableSorting = cmbSortOrder.GetSelectedIndex() != 0;
	labelSortBy.SetEnabled(enableSorting);
	cmbSortBy.SetEnabled(enableSorting);
	chart.PerformCallback(&quot;SortOrder&quot;);
}" />
                    </dx:ASPxComboBox></td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
        DataSourceID="AccessDataSource1" OnBoundDataChanged="WebChartControl1_BoundDataChanged" ClientInstanceName="chart"
        OnCustomCallback="WebChartControl1_CustomCallback" AlternateText="The Northwind Traders chart showing Products series.">
        <SeriesSerializable>
            <dx:Series Name="Products" ArgumentDataMember="ProductName" ValueDataMembersSerializable="UnitPrice" SeriesPointsSorting="Ascending" SeriesPointsSortingKey="Value_1">
                <DataFilters>
                    <dx:DataFilter ColumnName="CategoryID" DataType="System.Int32"></dx:DataFilter>
                </DataFilters>
                <ViewSerializable>
                    <dx:SideBySideBarSeriesView></dx:SideBySideBarSeriesView>
                </ViewSerializable>
            </dx:Series>
        </SeriesSerializable>
        <BorderOptions Visibility="False" />
        <Titles>
            <dx:ChartTitle Alignment="Near" Text="" Font="Tahoma, 10pt"></dx:ChartTitle>
            <dx:ChartTitle Text="Northwind Traders"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:XYDiagram>
                <AxisX VisibleInPanesSerializable="-1">
                    <Label Angle="-30"></Label>                    
                </AxisX>
                <AxisY Title-Text="Price, Millions of Dollars" Title-Visibility="True" VisibleInPanesSerializable="-1" Interlaced="True">                    
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
    </dx:WebChartControl>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
        SelectCommand="SELECT * FROM [Products]">
    </asp:AccessDataSource>
</asp:Content>
