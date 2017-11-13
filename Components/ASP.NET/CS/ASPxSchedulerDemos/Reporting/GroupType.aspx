<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="GroupType.aspx.cs"
    Inherits="Reporting_GroupType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <demo:ReportsDataSource runat="server" ID="ReportsDataSource1" />
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Group Type Options" Theme="Metropolis">
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">
                <dx:ASPxRadioButtonList ID="rbGroupType" runat="server" ValueType="System.Int32" Theme="Metropolis"
                    SelectedIndex="1" RepeatDirection="Horizontal" TextWrap="False" Width="40px"
                    ItemSpacing="2px" EnableClientSideAPI="True">
                    <Border BorderStyle="None" />
                    <Items>
                        <dx:ListEditItem Text="None" Value="0" />
                        <dx:ListEditItem Text="Date" Value="1" />
                        <dx:ListEditItem Text="Resource" Value="2" />
                    </Items>
                    <Paddings Padding="0px" />
                    <ClientSideEvents SelectedIndexChanged="function(s, e) { ClientReportViewer.Refresh(); }" />
                </dx:ASPxRadioButtonList>
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
