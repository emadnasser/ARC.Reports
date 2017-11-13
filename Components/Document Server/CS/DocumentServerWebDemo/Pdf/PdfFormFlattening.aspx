<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PdfFormFlattening.aspx.cs" Inherits="PdfFormFlattening" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
    <script type="text/javascript">
        function UploaderFileUploadComplete(e) {
            if (e.isValid)
                CallbackPanel.PerformCallback();
            else
                alert("File size exceeds the maximum allowed size.");
        }
    </script>
    <dx:ASPxRoundPanel runat="server" ShowHeader="true" HeaderText="Demo options" Width="100%">
        <PanelCollection>
            <dx:PanelContent>
                <table class="OptionsTable">
                    <tr>
                        <td>
                            <dx:ASPxLabel ID="lblSelectDocument" runat="server" Text="Select document: " />
                        </td>
                        <td>
                            <div style="vertical-align:middle;">
                                <dx:ASPxUploadControl ID="uploadControl" ClientInstanceName="uploader" runat="server" FileInputSpacing="0" 
                                                      UploadMode="Standard" OnFileUploadComplete="OnFileUploadComplete" ShowClearFileSelectionButton="false" Height="25px">
                                    <ValidationSettings MaxFileSize="10485760" AllowedFileExtensions=".pdf" MaxFileSizeErrorText="" />
                                    <TextBoxStyle CssClass="CustomTextBox" />
                                    <BrowseButton Text="Open..." />
                                    <ClientSideEvents TextChanged="function(s, e) { uploader.UploadFile(); }" FileUploadComplete="function(s, e) { UploaderFileUploadComplete(e); }"/>
                                </dx:ASPxUploadControl>
                            </div>
                        </td>
                        <td class="middle">
                            <dx:ASPxButton ID="btnExtractText" runat="server" Text="Flatten And Download..." AutoPostBack="true" Height="25px" OnClick="OnDownloadButtonClick"/>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" style="text-align:center">
                            <dx:ASPxLabel ID="lblMaxFileSize" runat="server" Text="Maximum file size: 10 MB" Font-Size="8pt" />
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <br/>
    <dx:PdfPageViewer id="pdfPageViewer" runat="server"/>
</asp:Content>
