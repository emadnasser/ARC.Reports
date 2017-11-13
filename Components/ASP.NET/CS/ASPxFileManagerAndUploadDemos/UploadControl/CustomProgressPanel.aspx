<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomProgressPanel.aspx.cs"
    Inherits="UploadControl_CustomProgressPanel" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <%--start highlighted block--%>
    <script type="text/javascript">
        var fileNumber = 0;
        var fileName = "";
        var startDate = null;
        function UploadControl_OnFileUploadStart() {
            startDate = new Date();
            ClearProgressInfo();
            pcProgress.Show();
        }
        function UploadControl_OnFilesUploadComplete(e) {
            pcProgress.Hide();
            if(e.errorText)
                ShowMessage(e.errorText);
            else if(e.callbackData == "success")
                ShowMessage("File uploading has been successfully completed.");
        }
        function ShowMessage(message) {
            window.setTimeout(function() { window.alert(message); }, 0);
        }
        // Progress Dialog
        function UploadControl_OnUploadingProgressChanged(args) {
            if(!pcProgress.IsVisible())
                return;
            if(args.currentFileName != fileName) {
                fileName = args.currentFileName;
                fileNumber++;
            }
            SetCurrentFileUploadingProgress(args.currentFileName, args.currentFileUploadedContentLength, args.currentFileContentLength);
            progress1.SetPosition(args.currentFileProgress);
            SetTotalUploadingProgress(fileNumber, args.fileCount, args.uploadedContentLength, args.totalContentLength);
            progress2.SetPosition(args.progress);
            UpdateProgressStatus(args.uploadedContentLength, args.totalContentLength);
        }
        function SetCurrentFileUploadingProgress(fileName, uploadedLength, fileLength) {
            lblFileName.SetText("Current File Progress: " + fileName);
            lblFileName.GetMainElement().title = fileName;
            lblCurrentUploadedFileLength.SetText( GetContentLengthString(uploadedLength) + " / " + GetContentLengthString(fileLength) );
        }
        function SetTotalUploadingProgress(number, count, uploadedLength, totalLength) {
            lblUploadedFiles.SetText("Total Progress: " + number + ' of ' + count + " file(s)");
            lblUploadedFileLength.SetText(GetContentLengthString(uploadedLength) + " / " + GetContentLengthString(totalLength));
        }
        function ClearProgressInfo() {
            SetCurrentFileUploadingProgress("", 0, 0);
            progress1.SetPosition(0);
            SetTotalUploadingProgress(0, 0, 0, 0);
            progress2.SetPosition(0);
            lblProgressStatus.SetText('Elapsed time: 00:00:00 &ensp; Estimated time: 00:00:00 &ensp; Speed: ' + GetContentLengthString(0) + '/s');
            fileNumber = 0;
            fileName = "";
        }
        function UpdateProgressStatus(uploadedLength, totalLength) {
            var currentDate = new Date();
            var elapsedDateMilliseconds = currentDate - startDate;
            var speed = uploadedLength / (elapsedDateMilliseconds / 1000);
            var elapsedDate = new Date(elapsedDateMilliseconds);
            var elapsedTime = GetTimeString(elapsedDate);
            var estimatedMilliseconds = Math.floor((totalLength - uploadedLength) / speed) * 1000;
            var estimatedDate = new Date(estimatedMilliseconds);
            var estimatedTime = GetTimeString(estimatedDate);
            var speed = uploadedLength / (elapsedDateMilliseconds / 1000);
            lblProgressStatus.SetText('Elapsed time: ' + elapsedTime + ' &ensp; Estimated time: ' + estimatedTime + ' &ensp; Speed: ' + GetContentLengthString(speed) + '/s');
        }
        function GetContentLengthString(contentLength) {
            var sizeDimensions = [ 'bytes', 'KB', 'MB', 'GB', 'TB' ];
            var index = 0;
            var length = contentLength;
            var postfix = sizeDimensions[index];
            while(length > 1024) {
                length = length / 1024;
                postfix = sizeDimensions[++index];
            }
            var numberRegExpPattern = /[-+]?[0-9]*(?:\.|\,)[0-9]{0,2}|[0-9]{0,2}/;
            var results = numberRegExpPattern.exec(length);
            length = results ? results[0] : Math.floor(length);
            return length.toString() + ' ' + postfix;
        }
        function GetTimeString(date) {
            var timeRegExpPattern = /\d{1,2}:\d{1,2}:\d{1,2}/;
            var results = timeRegExpPattern.exec(date.toUTCString());
            return results ? results[0] : "00:00:00";
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxUploadControl ID="UploadControl" runat="server" ClientInstanceName="UploadControl" Width="330" Height="50"
        NullText="Click here to browse files..." UploadMode="Advanced" AutoStartUpload="True"
        OnFilesUploadComplete="UploadControl_FilesUploadComplete">
        <AdvancedModeSettings EnableMultiSelect="True" EnableDragAndDrop="True" />
        <ValidationSettings MaxFileSize="10000000" ShowErrors="false"></ValidationSettings>
        <ClientSideEvents FilesUploadStart="function(s, e) { UploadControl_OnFileUploadStart(); }"
                          FilesUploadComplete="function(s, e) { UploadControl_OnFilesUploadComplete(e); }"
                          UploadingProgressChanged="function(s, e) { UploadControl_OnUploadingProgressChanged(e); }" />
    </dx:ASPxUploadControl>
    <p class="Note">
        <b>Note</b>: The size of each file selected for upload is limited to 10 MB in this demo.
    </p>
    <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" ClientInstanceName="pcProgress" Modal="True" HeaderText="Uploading"
        PopupAnimationType="None" CloseAction="None" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Width="460px"
        AllowDragging="true" ShowPageScrollbarWhenModal="True" ShowCloseButton="False" ShowFooter="True">
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" SupportsDisabledAttribute="True">
                <table style="width: 100%;">
                    <tr><td style="width: 100%;">
                        <div style="overflow: hidden; width: 280px;">
                            <dx:ASPxLabel ID="lblFileName" runat="server" ClientInstanceName="lblFileName" Text=""
                                Wrap="False"></dx:ASPxLabel>
                        </div>
                    </td><td class="NoWrap" style="text-align: right">
                        <dx:ASPxLabel ID="lblCurrentUploadedFileLength" runat="server" ClientInstanceName="lblCurrentUploadedFileLength"
                            Text="" Wrap="False"></dx:ASPxLabel>
                    </td></tr>
                    <tr><td colspan="2" class="TopPadding" >
                        <dx:ASPxProgressBar ID="ASPxProgressBar1" runat="server" Height="21px" Width="100%"
                            ClientInstanceName="progress1"></dx:ASPxProgressBar>
                    </td></tr>
                    <tr><td colspan="2">
                        <div class="Spacer" style="height: 12px;"></div>
                    </td></tr>
                    <tr><td style="width: 100%;">
                        <dx:ASPxLabel ID="lblUploadedFiles" runat="server" ClientInstanceName="lblUploadedFiles" Text=""
                            Wrap="False"></dx:ASPxLabel>
                    </td><td class="NoWrap" style="text-align: right">
                        <dx:ASPxLabel ID="lblUploadedFileLength" runat="server" ClientInstanceName="lblUploadedFileLength"
                            Text="" Wrap="False"></dx:ASPxLabel>
                    </td></tr>
                    <tr><td colspan="2" class="TopPadding" >
                        <dx:ASPxProgressBar ID="ASPxProgressBar2" runat="server" CssClass="BottomMargin" Height="21px" Width="100%"
                            ClientInstanceName="progress2"></dx:ASPxProgressBar>
                    </td></tr>
                    <tr><td colspan="2">
                        <div class="Spacer" style="height: 12px;"></div>
                    </td></tr>
                    <tr><td colspan="2">
                        <dx:ASPxLabel ID="lblProgressStatus" runat="server" ClientInstanceName="lblProgressStatus" Text=""
                            Wrap="False"></dx:ASPxLabel>
                    </td></tr>
                </table>
            </dx:PopupControlContentControl>
        </ContentCollection>
        <FooterTemplate>
            <div style="overflow: hidden;">
                <dx:ASPxButton ID="btnCancel" runat="server" AutoPostBack="False" Text="Cancel" ClientInstanceName="btnCancel" Width="100px" style="float: right">
                    <ClientSideEvents Click="function(s, e) { UploadControl.Cancel(); }" />
                </dx:ASPxButton>
            </div>
        </FooterTemplate>
        <FooterStyle><Paddings Padding="5px" PaddingRight="10px" /></FooterStyle>
    </dx:ASPxPopupControl>
</asp:Content>
