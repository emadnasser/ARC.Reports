<%@ Page Language="vb" MasterPageFile="~/Root.master" AutoEventWireup="true" CodeFile="DocumentViewer.aspx.vb" Inherits="DocumentViewer" %>
<asp:Content ID="Content2" ContentPlaceHolderID="RootPlaceHolder" Runat="Server">
<div class="reportContainer">
    <dx:ASPxDocumentViewer ID="DocumentViewerControl" runat="server" ClientInstanceName="documentViewer" Height="800">
        <toolbaritems>
            <dx:ReportToolbarButton ItemKind="Search" />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton ItemKind="PrintReport" />
            <dx:ReportToolbarButton ItemKind="PrintPage" />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton ItemKind="FirstPage" />
            <dx:ReportToolbarButton ItemKind="PreviousPage" />
            <dx:ReportToolbarLabel ItemKind="PageLabel" />
            <dx:ReportToolbarComboBox ItemKind="PageNumber" Width="80px">
            </dx:ReportToolbarComboBox>
            <dx:ReportToolbarLabel ItemKind="OfLabel" />
            <dx:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
            <dx:ReportToolbarButton ItemKind="NextPage" />
            <dx:ReportToolbarButton ItemKind="LastPage" />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton ItemKind="SaveToDisk" />
            <dx:ReportToolbarButton ItemKind="SaveToWindow" />
            <dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="80px">
                <elements>
                    <dx:ListElement Value="pdf" />
                    <dx:ListElement Value="xls" />
                    <dx:ListElement Value="xlsx" />
                    <dx:ListElement Value="rtf" />
                    <dx:ListElement Value="mht" />
                    <dx:ListElement Value="html" />
                    <dx:ListElement Value="txt" />
                    <dx:ListElement Value="csv" />
                </elements>
            </dx:ReportToolbarComboBox>
        </toolbaritems>
        <SettingsReportViewer EnableReportMargins="True" />
    </dx:ASPxDocumentViewer>
</div>
</asp:Content>