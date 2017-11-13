<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DateFormatting.aspx.cs"
    Inherits="Reporting_DateFormatting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <demo:ReportsDataSource runat="server" ID="ReportsDataSource1" />
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Formating Options" Theme="Metropolis">
        <PanelCollection>
            <dx:PanelContent ID="Panelcontent1" runat="server">
                <table class="OptionsTable">
                    <tr>
                        <td colspan="2" style="font-weight: bold; color: #B2B2B2; padding: 6px 0;">
                            Horizontal Appointments Format:
                        </td>
                        <td colspan="2" style="font-weight: bold; color: #B2B2B2; padding: 6px 0;">
                            Vertical Appointments Format:
                        </td>
                        <td colspan="2" style="font-weight: bold; color: #B2B2B2; padding: 6px 0;">
                            Day Headers Format:
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxLabel ID="lblHorzAptStart" runat="server" Text="Start:" AssociatedControlID="cbHorzAptStart" Theme="Metropolis" />
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbHorzAptStart" runat="server" ValueType="System.String" Width="100%" Theme="Metropolis">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
                            </dx:ASPxComboBox>
                        </td>
                        <td>
                            <dx:ASPxLabel ID="lblVertAptStart" runat="server" Text="Start:" AssociatedControlID="cbVertAptStart" Theme="Metropolis" />
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbVertAptStart" runat="server" ValueType="System.String" Width="100%" Theme="Metropolis">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
                            </dx:ASPxComboBox>
                        </td>
                        <td>
                            <dx:ASPxLabel ID="lblHeader" runat="server" Text="Format:" AssociatedControlID="cbHeaderCaptions" Theme="Metropolis" />
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbHeaderCaptions" runat="server" ValueType="System.String" Width="100%" Theme="Metropolis">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxLabel ID="lblHorzAptEnd" runat="server" Text="End:" AssociatedControlID="cbHorzAptEnd" Theme="Metropolis" />
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbHorzAptEnd" runat="server" ValueType="System.Int32" Width="100%" Theme="Metropolis">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
                            </dx:ASPxComboBox>
                        </td>
                        <td>
                            <dx:ASPxLabel ID="lblVertAptEnd" runat="server" Text="End:" AssociatedControlID="cbVertAptEnd" Theme="Metropolis" />
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbVertAptEnd" runat="server" ValueType="System.String" Width="100%" Theme="Metropolis">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
                            </dx:ASPxComboBox>
                        </td>
                        <td></td>
                        <td></td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <br /><br />
    <dx:ReportToolbar ID="ReportToolbar1" runat="server" ReportViewer="<%# ReportViewer %>"
        ShowDefaultButtons="False" Width="100%">
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
