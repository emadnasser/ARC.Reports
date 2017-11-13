<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PdfDocumentCreationAPI.aspx.cs" Inherits="PdfDocumentCreationAPI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCallbackPanel ID="callbackPanel" ClientInstanceName="callbackPanel" runat="server">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <div style="text-align: center; width: 100%; margin-top:150px; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">
                    <div style="margin-top: 20px; margin-bottom: 20px; font-size: 30px">
                        This demo illustrates the capability to programmatically generate a document layout and bookmarks using PDF document creation API.
                    </div>
                    <div style="margin-top: 40px; font-size: 16px; color:GrayText">
                        Click the button below to create a sample document with a 
                    </div>
                    <div style="margin-bottom: 20px; font-size: 16px; color:GrayText">
                        dynamically generated layout and bookmarks.
                    </div>
                    <div style="margin-bottom: 200px">
                        <dx:ASPxButton Style="height: 60px; width: 270px; color: #EF810C; font-size: 16px; font-weight: 700" runat="server" ID="btnDownload" 
                                       Text="CREATE AND DOWNLOAD" AutoPostBack="True" ClientInstanceName="btnDownload" HoverStyle-BackColor="White" OnClick="OnDownloadButtonClick"/>
                    </div>
                </div>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
</asp:Content>
