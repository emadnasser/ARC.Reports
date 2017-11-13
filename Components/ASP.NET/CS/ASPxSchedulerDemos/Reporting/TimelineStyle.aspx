<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TimelineStyle.aspx.cs"
    Inherits="Reporting_TimelineStyle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <demo:ReportsDataSource runat="server" ID="ReportsDataSource1" />
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Timeline Style Options" Theme="Metropolis">
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">
                <table class="OptionsTable">
                    <tr>
                        <td>
                            <dx:ASPxLabel ID="lblResourceCount" runat="server" Text="Resource Count:" AssociatedControlID="cbResourceCount" Theme="Metropolis" />
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbResourceCount" runat="server" ValueType="System.Int32" SelectedIndex="1" Theme="Metropolis"
                                Width="50px">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
                                <Items>
                                    <dx:ListEditItem Text="1" Value="1"></dx:ListEditItem>
                                    <dx:ListEditItem Text="2" Value="2"></dx:ListEditItem>
                                    <dx:ListEditItem Text="3" Value="3"></dx:ListEditItem>
                                    <dx:ListEditItem Text="4" Value="4"></dx:ListEditItem>
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                        <td>
                            <dx:ASPxLabel ID="lblStart" runat="server" Text="Start:" AssociatedControlID="edtStart" Theme="Metropolis" />
                        </td>
                        <td class="edit">
                            <dx:ASPxDateEdit ID="edtStart" runat="server" Width="120px" ClientInstanceName="clientEdtStart" Theme="Metropolis">
                                <ClientSideEvents DateChanged="function(s, e) { ValidateDates(); ClientReportViewer.Refresh(); }">
                                </ClientSideEvents>
                            </dx:ASPxDateEdit>
                        </td>
                        <td>
                            <dx:ASPxLabel ID="lblTimeScale" runat="server" Text="Time scale:" AssociatedControlID="cbTimeScale" Theme="Metropolis" />
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbTimeScale" runat="server" ValueType="System.Int32" SelectedIndex="3" Theme="Metropolis"
                                Width="120px">
                                <Items>
                                    <dx:ListEditItem Text="Year/Month" Value="0"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Month/Week" Value="1"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Week/Day" Value="2"></dx:ListEditItem>
                                </Items>
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxLabel ID="lblIntervalCount" runat="server" Text="Interval Count:" AssociatedControlID="cbIntervalCount" Theme="Metropolis" />
                        </td>
                        <td>
                            <dx:ASPxComboBox ID="cbIntervalCount" runat="server" ValueType="System.Int32" SelectedIndex="2" Theme="Metropolis"
                                Width="50px">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
                                <Items>
                                    <dx:ListEditItem Text="1" Value="1"></dx:ListEditItem>
                                    <dx:ListEditItem Text="2" Value="2"></dx:ListEditItem>
                                    <dx:ListEditItem Text="3" Value="3"></dx:ListEditItem>
                                    <dx:ListEditItem Text="4" Value="4"></dx:ListEditItem>
                                    <dx:ListEditItem Text="5" Value="5"></dx:ListEditItem>
                                    <dx:ListEditItem Text="6" Value="6"></dx:ListEditItem>
                                    <dx:ListEditItem Text="7" Value="7"></dx:ListEditItem>
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                        <td>
                            <dx:ASPxLabel ID="lblEnd" runat="server" Text="End:" AssociatedControlID="edtEnd" Theme="Metropolis" />
                        </td>
                        <td colspan="3">
                            <dx:ASPxDateEdit ID="edtEnd" runat="server" Width="120px" ClientInstanceName="clientEdtEnd" Theme="Metropolis">
                                <ClientSideEvents DateChanged="function(s, e) { ValidateDates(); ClientReportViewer.Refresh(); }">
                                </ClientSideEvents>
                            </dx:ASPxDateEdit>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <br /><br />
    <dx:ReportToolbar ID="ReportToolbar1" runat="server" ReportViewer="<%# ReportViewer %>"
        ShowDefaultButtons="False">
        <Items>
            <dx:ReportToolbarButton ItemKind="PrintReport" ToolTip="Print the report" />
            <dx:ReportToolbarButton ItemKind="PrintPage" ToolTip="Print the current page" />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton ItemKind="FirstPage" ToolTip="First Page" />
            <dx:ReportToolbarButton ItemKind="PreviousPage" ToolTip="Previous Page" />
            <dx:ReportToolbarLabel ItemKind="PageLabel" />
            <dx:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
            </dx:ReportToolbarComboBox>
            <dx:ReportToolbarLabel ItemKind="OfLabel"/>
            <dx:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
            <dx:ReportToolbarButton ItemKind="NextPage" ToolTip="Next Page" />
            <dx:ReportToolbarButton ItemKind="LastPage" ToolTip="Last Page" />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton ItemKind="SaveToDisk" ToolTip="Export a report and save it to the disk" />
            <dx:ReportToolbarButton ItemKind="SaveToWindow" ToolTip="Export a report and show it in a new window" />
            <dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                <Elements>
                    <dx:ListElement Text="Pdf" Value="pdf" />
                    <dx:ListElement Text="Mht" Value="mht" />
                    <dx:ListElement Text="Image" Value="png" />
                </Elements>
            </dx:ReportToolbarComboBox>
        </Items>
    </dx:ReportToolbar>
    <dx:ReportViewer ID="ReportViewer" runat="server" ClientInstanceName="ClientReportViewer">
    </dx:ReportViewer>
    <script type="text/javascript">
    // <![CDATA[
        function ValidateDates() {
            var startDate = clientEdtStart.GetDate();
            var endDate = clientEdtEnd.GetDate();
            if(endDate < startDate)
                clientEdtEnd.SetDate(startDate);
        }
    // ]]> 
    </script>
</asp:Content>