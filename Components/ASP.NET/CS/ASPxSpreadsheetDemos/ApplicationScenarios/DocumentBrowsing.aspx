<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DocumentBrowsing.aspx.cs" Inherits="ApplicationScenarios_DocumentBrowsing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <script type="text/javascript">
        var postponedCallbackRequired = false;
        function OnSelectedFileChanged(s, e) {
            if(e.file) {
                if(!spreadsheet.InCallback())
                    spreadsheet.PerformCallback();
                else
                    postponedCallbackRequired = true;
            }
        }
        function OnSpreadsheetEndCallback(s, e) {
            if(postponedCallbackRequired) {
                spreadsheet.PerformCallback();
                postponedCallbackRequired = false;
            }
        }
        function OnExceptionOccurred(s, e) {
            e.handled = true;
            alert(e.message);
            window.location.reload();
        }
    </script>
    <div style="padding-bottom:5px;">
        <dx:ASPxLabel ID="info" runat="server" Text="Navigate through folders and select a document to open with the Spreadsheet." />
    </div>
    <dx:ASPxFileManager ID="FileManager" runat="server" Height="250px" OnFileUploading="FileManager_FileUploading">
        <Settings AllowedFileExtensions=".xlsx,.xls,.csv" InitialFolder="XLSX" />
        <SettingsEditing AllowDownload="true" />
        <ClientSideEvents SelectedFileChanged="OnSelectedFileChanged" CallbackError="OnExceptionOccurred"></ClientSideEvents>
    </dx:ASPxFileManager>
    <br />
    <dx:ASPxSpreadsheet ID="Spreadsheet" ClientInstanceName="spreadsheet" runat="server" ActiveTabIndex="0" ShowConfirmOnLosingChanges="false"
        Width="100%" Height="700px" OnCallback="Spreadsheet_Callback">
        <ClientSideEvents EndCallback="OnSpreadsheetEndCallback"></ClientSideEvents>
    </dx:ASPxSpreadsheet>
</asp:Content>
