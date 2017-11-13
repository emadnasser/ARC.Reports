<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomDocumentManagement.aspx.cs"
    Inherits="RichEditDemoCustomDocumentManagement" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        var postponedCallbackRequired = false;
        function OnSelectedFileChanged(s, e) {
            if(e.file) {
                if(!DemoRichEdit.InCallback())
                    DemoRichEdit.PerformCallback();
                else
                    postponedCallbackRequired = true;
            }
        }
        function OnRichEditEndCallback(s, e) {
            if(postponedCallbackRequired) {
                DemoRichEdit.PerformCallback();
                postponedCallbackRequired = false;
            }
        }
        function OnExceptionOccurred(s, e) {
            e.handled = true;
            alert(e.message);
            window.location.reload();
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="server">
    <div style="padding-bottom: 10px;">
        <label>Navigate through folders and select a document to open with the RichEdit.</label>
    </div>
    <dx:ASPxFileManager ID="FileManager" runat="server" Height="200px" OnFileUploading="FileManager_FileUploading" OnLoad="FileManager_Load">
        <Settings AllowedFileExtensions=".docx,.doc,.rtf,.txt" />
        <SettingsToolbar>
            <Items>
                <dx:FileManagerToolbarRefreshButton></dx:FileManagerToolbarRefreshButton>
                <dx:FileManagerToolbarDownloadButton></dx:FileManagerToolbarDownloadButton>
            </Items>
        </SettingsToolbar>
        <SettingsEditing AllowDownload="true" />
        <SettingsUpload Enabled="false"></SettingsUpload>
        <ClientSideEvents SelectedFileChanged="OnSelectedFileChanged" CallbackError="OnExceptionOccurred"></ClientSideEvents>
    </dx:ASPxFileManager>
    <br />
    <dx:ASPxRichEdit ID="DemoRichEdit" runat="server" ClientInstanceName="DemoRichEdit" Width="100%"
        OnCallback="DemoRichEdit_Callback" ActiveTabIndex="0" RibbonMode="none"
        ShowConfirmOnLosingChanges="false" OnPreRender="DemoRichEdit_PreRender">
        <ClientSideEvents EndCallback="OnRichEditEndCallback"></ClientSideEvents>
    </dx:ASPxRichEdit>
</asp:Content>
