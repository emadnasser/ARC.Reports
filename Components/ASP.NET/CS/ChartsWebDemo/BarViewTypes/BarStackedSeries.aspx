<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BarStackedSeries.aspx.cs" Inherits="BarStackedSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
        <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">      
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;">
                        <dx:ASPxCheckBox ID="chbShowLabels" runat="server" Wrap="False" Text="Show Labels" ClientInstanceName="chbShowLabels">
                            <ClientSideEvents CheckedChanged="function(s, e) { 
	                        labelLabelPosition.SetEnabled(chbShowLabels.GetChecked());
	                        cboxLabelPosition.SetEnabled(chbShowLabels.GetChecked());
	                        labelTextOrientation.SetEnabled(chbShowLabels.GetChecked());
	                        cboxTextOrientation.SetEnabled(chbShowLabels.GetChecked());
	                        if (cboxLabelPosition.GetValue() == &quot;Top Inside&quot; || cboxLabelPosition.GetValue() == &quot;Bottom Inside&quot;){
	                            labelLabelIndent.SetEnabled(chbShowLabels.GetChecked());
	                            spinLabelIndent.SetEnabled(chbShowLabels.GetChecked());
	                        }
                                chart.PerformCallback(&quot;ShowLabels&quot;); 
                            }" />
                        </dx:ASPxCheckBox>
                    </td>
                    <td class="NoWrap">
                        <dx:ASPxLabel ID="lblLabelPosition" runat="server" Text="Label Position:" ClientInstanceName="labelLabelPosition">
                        </dx:ASPxLabel>
                    </td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbLabelPosition" runat="server" ValueType="System.String" Width="108px" ClientInstanceName="cboxLabelPosition">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                            	if (cboxLabelPosition.GetValue() == &quot;Center&quot;){
		                            labelLabelIndent.SetEnabled(false);
		                            spinLabelIndent.SetEnabled(false);
	                            }
	                            else {
		                            labelLabelIndent.SetEnabled(true);
		                            spinLabelIndent.SetEnabled(true);
	                            }
	                            chart.PerformCallback(&quot;LabelPosition&quot;); 
                            }" />
                        </dx:ASPxComboBox>
                    </td>
                    <td><div class="Spacer" style="width: 10px;"></div></td>
                    <td class="NoWrap">
                        <dx:ASPxLabel ID="lbTextOrientation" runat="server" Text="Orientation:" ClientInstanceName="labelTextOrientation">
                        </dx:ASPxLabel>
                    </td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxComboBox ID="cbTextOrientation" runat="server" ValueType="System.String" Width="108px" ClientInstanceName="cboxTextOrientation">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
	                            chart.PerformCallback(&quot;TextOrientation&quot;);
                            }" />
                        </dx:ASPxComboBox>
                    </td>
                </tr>
                <tr>
                    <td><div class="Spacer" style="width: 100%;height: 5px"></div></td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td class="NoWrap">
                        <dx:ASPxLabel ID="lblLabelIndent" runat="server" Text="Label Indent:" ClientInstanceName="labelLabelIndent">
                        </dx:ASPxLabel>
                    </td>
                    <td><div class="Spacer" style="width: 5px;"></div></td>
                    <td>
                        <dx:ASPxSpinEdit ID="spnLabelIndent" runat="server" Height="21px" Number="0"
                            Width="108px" ClientInstanceName="spinLabelIndent" MaxValue="10000" NumberType="Integer">
                            <ClientSideEvents NumberChanged="function(s, e) {
	                            chart.PerformCallback(&quot;LabelIndent&quot;);
                            }" />
                        </dx:ASPxSpinEdit>
                    </td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
    </dx:ASPxRoundPanel>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
        Width="700px" ClientInstanceName="chart" CssClass="AlignCenter TopLargeMargin"
        OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="False"
        EnableClientSideAPI="True" ToolTipEnabled="False"
        SeriesDataMember="Age" DataSourceID="chartDataSource">
        <SeriesTemplate  ArgumentDataMember="Country" ValueDataMembersSerializable="Population" LabelsVisibility="True"
            CrosshairLabelPattern="Age: {S}<br/>Population: {V:0,,.0}M">
            <ViewSerializable>
                <dx:StackedBarSeriesView></dx:StackedBarSeriesView>
            </ViewSerializable>
            <LabelSerializable>
                <dx:StackedBarSeriesLabel Font="Tahoma, 8pt, style=Bold" TextPattern="{V:0,,.0}">
                </dx:StackedBarSeriesLabel>
            </LabelSerializable>
        </SeriesTemplate>
        <Legend Direction="BottomToTop">
        </Legend>
        <BorderOptions Visibility="False" />
        <Titles>
            <dx:ChartTitle Text="Male Age Structure"></dx:ChartTitle>
            <dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www.cia.gov" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:XYDiagram Rotated="True">
                <AxisX VisibleInPanesSerializable="-1">
                </AxisX>
                <AxisY Title-Text="Millions" Title-Visibility="True" VisibleInPanesSerializable="-1">
                    <Label TextPattern="{V:0,,}"/>
                    <GridLines MinorVisible="True"></GridLines>
                </AxisY>
            </dx:XYDiagram>
        </DiagramSerializable>
    </dx:WebChartControl>
    <asp:ObjectDataSource ID="chartDataSource" runat="server" TypeName="AgeStructure" SelectMethod="GetDataByMaleAge"></asp:ObjectDataSource>
</asp:Content>
