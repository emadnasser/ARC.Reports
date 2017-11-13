<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataValidation.aspx.cs"
    Inherits="Reporting_DataValidation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <demo:ReportsDataSource runat="server" ID="ReportsDataSource1" />
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Data Validation Options" Theme="Metropolis">
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">
                <table class="OptionsTable">
                    <tr>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbResources" runat="server" ValueType="System.Int32" SelectedIndex="0" Theme="Metropolis"
                                Width="135px" Caption="Resources">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
                                <Items>
                                    <dx:ListEditItem Text="All" Value="1"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Top 3" Value="2"></dx:ListEditItem>
                                    <dx:ListEditItem Text="A-Z Order" Value="3"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Z-A Order" Value="4"></dx:ListEditItem>
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbAppointments" runat="server" ValueType="System.Int32" SelectedIndex="0" Theme="Metropolis"
                                Width="135px" Caption="Appointments">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
                                <Items>
                                    <dx:ListEditItem Text="All" Value="4"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Recurring" Value="1"></dx:ListEditItem>
                                    <dx:ListEditItem Text="NonRecurring" Value="2"></dx:ListEditItem>
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbDays" runat="server" ValueType="System.Int32" SelectedIndex="0" Theme="Metropolis"
                                Width="135px" Caption="Days">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
                                <Items>
                                    <dx:ListEditItem Text="Every day" Value="127"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Work Days" Value="62"></dx:ListEditItem>
                                    <dx:ListEditItem Text="Weekend Days" Value="65"></dx:ListEditItem>
                                </Items>
                            </dx:ASPxComboBox>
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
</asp:Content>
