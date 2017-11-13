<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EmployeeInformation.aspx.cs"
    Inherits="Spreadsheet_EmployeeInformation" %>
<%@ Register Src="~/UserControls/WorkbookPreviewControl.ascx" TagPrefix="dx" TagName="Preview" %>
<%@ Register Src="~/UserControls/SpreadsheetDocumentDownloader.ascx" TagPrefix="dx" TagName="DocumentDownloader" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:DocumentDownloader runat="server" ID="DocumentDownloader" OnRequestWorkbook="OnDocumentDownloaderRequestWorkbook"/>
    <dx:Preview runat="server" ID="previewControl" ClientInstanceName="clientPreviewControl" />
</asp:Content>
