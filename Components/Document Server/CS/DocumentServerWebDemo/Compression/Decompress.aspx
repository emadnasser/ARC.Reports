<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Decompress.aspx.cs" Inherits="Compression_Decompress" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .groupBox
        {
            margin: 5px 0px;
            border: solid 1px gray;
            width: 480px;
        }
        .groupBox legend
        {
            margin-left: 20px;
        }
        .groupBox .fileContainer
        {
            height: 200px;
            padding: 5px 10px;
            overflow: auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <script type="text/javascript">
        // <![CDATA[
        function Uploader_OnFileUploadComplete(e) {
            if (e.callbackData != "") {
                var data = e.callbackData.substring(1).split('#');
                var length = data.length;
                for(var i = 0; i < length; i++) {
                    AddFileToContainer(data[i]);
                }
            }
        }        
        function AddFileToContainer(callbackData) {
            var data = callbackData.split('|');
            var file = data[0];
            var url = data[1];
            var link = document.createElement('A');
            ASPx.Attr.SetAttribute(link, "target", "_blank");
            ASPx.Attr.SetAttribute(link, "href", url);
            link.innerHTML = file;
            var fileContainer = document.getElementById("fileContainer");
            fileContainer.appendChild(link);
            fileContainer.appendChild(document.createElement('BR'));
        }
        // ]]>
    </script>
    <table style="width: 480px;">
        <tr>
            <td class="NoWrap">
                <dx:ASPxLabel ID="lblSelectMultipleFiles" runat="server" Text="Select File:&nbsp;"></dx:ASPxLabel>
            </td><td style="width: 100%;">
                <dx:ASPxUploadControl ID="ASPxUploadControl1" runat="server" ClientInstanceName="uploader" Width="100%" ShowUploadButton="false"
                    NullText="Click here to browse files..." UploadMode="Advanced" OnFileUploadComplete="UploadControl_FileUploadComplete">
                    <AdvancedModeSettings EnableMultiSelect="False" />
                    <ClientSideEvents FileUploadComplete="function(s, e) { Uploader_OnFileUploadComplete(e); }"                                                                            
                                      TextChanged="function(s, e) { uploader.UploadFile(); }" />
                    <ValidationSettings MaxFileSize="4194304" AllowedFileExtensions=".zip">
                    </ValidationSettings>
                </dx:ASPxUploadControl>
            </td>
        </tr><tr>
            <td></td>
            <td class="note">
                <dx:ASPxLabel ID="lblAllowebMimeType" runat="server" Text="Allowed archive type: zip"
                    Font-Size="8pt">
                </dx:ASPxLabel>
                <br />
                <dx:ASPxLabel ID="lblMaxFileSize" runat="server" Text="Maximum file size: 4 MB" Font-Size="8pt">
                </dx:ASPxLabel>
            </td>
        </tr><tr>
            <td colspan="2" class="TopPadding" style="text-align: center;">
                <dx:ASPxButton ID="btnUpload" runat="server" AutoPostBack="False" Text="Upload&nbsp;Zip&nbsp;File" ClientInstanceName="btnUpload"
                    Width="100px" ClientEnabled="False">
                    <ClientSideEvents Click="function(s, e) { uploader.Upload(); }" />
                </dx:ASPxButton>
            </td>
        </tr>
    </table>
    <fieldset class="groupBox">
        <legend>Archive Content</legend>
        <div id="fileContainer" class="fileContainer"></div>
    </fieldset>
    <p class="Note">
        <b>Note</b>: All files uploaded to this demo will be automatically deleted in 5 minutes.
    </p>
    <br/>
</asp:Content>
