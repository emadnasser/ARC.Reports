<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EncodingDetection.aspx.cs"
    Inherits="Miscellaneous_EncodingDetection" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        #OptionsTable > tbody > tr > td
        {
            height: 30px;
        }
        #ContentHolder_CallbackPanel > .dxeBase
        {
            font-weight: bold;
        }
        .CustomTextBox, .CustomTextBox input[type='text']
        {
            padding: 0px;
            border-width: 0px;
        }
        .CustomTextBox input[type='text']
        {
            opacity: 0;
            filter: alpha(opacity=0);
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <script type="text/javascript">
        // <![CDATA[
        window.onload = function () {
            cbLanguage.SetSelectedIndex(0);
        }
        function Uploader_TextChanged() {
            uploader.UploadFile();
        }
        function Uploader_FileUploadComplete(s, e) {
            cbLanguage.SetSelectedIndex(-1);
            CallbackPanel.PerformCallback();
        }
        function OnComobBoxIndexChanged(s, e) {
            CallbackPanel.PerformCallback();
        }   
        // ]]> 
    </script>
    <table id="OptionsTable">
        <tr>
            <td colspan="3" style="height:2px;padding-bottom:3px;">
                <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Load file:&nbsp;" />
            </td>
        </tr>
        <tr style="text-align: right;">
            <td>
                <dx:ASPxComboBox ID="cbLanguage" ClientInstanceName="cbLanguage" runat="server" ValueType="System.String"
                    Height="25px" Width="165px" OnSelectedIndexChanged="cbLanguage_SelectedIndexChanged">
                    <ClientSideEvents SelectedIndexChanged="OnComobBoxIndexChanged" />
                </dx:ASPxComboBox>
            </td>
            <td style="padding:0 9px 0 10px;">
                <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="or"/>
            </td>
            <td>
                <dx:ASPxUploadControl ID="ASPxUploadControl1" runat="server" UploadMode="Advanced"
                    OnFileUploadComplete="ASPxUploadControl1_FileUploadComplete" ClientInstanceName="uploader"
                    NullText="Click here to browse files..." ShowUploadButton="false" Width="250px">
                    <ValidationSettings MaxFileSize="1048576" AllowedFileExtensions=".txt">
                    </ValidationSettings>
                    <ClientSideEvents TextChanged="function(s, e) { Uploader_TextChanged(); }" FileUploadComplete="function(s, e) {Uploader_FileUploadComplete(s,e); }" />
                </dx:ASPxUploadControl>
            </td>
        </tr>
    </table>
    <dx:ASPxCallbackPanel ID="CallbackPanel" ClientInstanceName="CallbackPanel" runat="server" 
        OnCallback="CallbackPanel_Callback">
        <PanelCollection>
            <dx:PanelContent>
                <div style="margin-bottom: 16px;padding-top:20px">
                    <dx:ASPxLabel runat="server" ID="lblCurrentFile" Text="English.txt" Font-Size="X-Large">
                    </dx:ASPxLabel>
                    <br />
                </div>
                <table style="width: 100%;">
                    <tr>
                        <td style="padding-right: 15px;">
                            <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="No Encoding Detection">
                            </dx:ASPxLabel>
                        </td>
                        <td style="padding-left: 15px;">
                            <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Encoding:">
                            </dx:ASPxLabel>
                            <dx:ASPxLabel ID="lblEncoding" runat="server" Text="">
                            </dx:ASPxLabel>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 50%; padding-right: 15px; padding-top:5px;">
                            <dx:ASPxMemo ID="memoNoEncoding" ClientInstanceName="memoNoEncoding" runat="server"
                                Width="100%" ReadOnly="true" Height="290px">
                                <ClientSideEvents Init="function(s, e) {
                                                s.GetInputElement().style.overflowY='auto';
                                                }"
                                 />
                            </dx:ASPxMemo>
                        </td>
                        <td style="width: 50%; padding-left: 15px; padding-top:5px;">
                            <dx:ASPxMemo ID="memoEncoding" ClientInstanceName="memoEncoding" runat="server" Height="290px"
                                Width="100%" ReadOnly="true">
                                <ClientSideEvents Init="function(s, e) {
                                                s.GetInputElement().style.overflowY='auto';
                                                }"
                                 />
                            </dx:ASPxMemo>
                        </td>
                    </tr>
                </table>
                 
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
</asp:Content>
