<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" 
    CodeFile="MultipleFileSelection.aspx.cs" Inherits="FileManager_MultipleFileSelection" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <style>
        .OptionsAlignRight 
        {
            float: right;
        }
    </style>
    <%--start highlighted block--%>
    <script type="text/javascript">
        function fileManager_SelectionChanged(s, e) {
            filesList.ClearItems();
            var selectedFiles = s.GetSelectedItems();
            for(var i = 0; i < selectedFiles.length; i++) {
                filesList.AddItem(selectedFiles[i].name);
            }
            document.getElementById("filesCount").innerHTML = selectedFiles.length;
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
    <dx:ASPxComboBox ID="ddlViewMode" SelectedIndex="0" runat="server" AutoPostBack="True" Width="120px" Caption="View Mode">
        <RootStyle CssClass="OptionsBottomMargin OptionsAlignRight"></RootStyle>
        <Items>
            <dx:ListEditItem Text="Thumbnails" Value="Thumbnails" />
            <dx:ListEditItem Text="Details" Value="Details" />
        </Items>
    </dx:ASPxComboBox>
    <div style="float: left; clear:both; width: 20%">
        <dx:ASPxListBox ID="ASPxListBox1" ClientInstanceName="filesList" runat="server" Height="250px"
            Width="100%" Caption="Selected files">
            <CaptionSettings Position="Top" />
        </dx:ASPxListBox>
        <div class="TopPadding">
            <dx:ASPxLabel runat="server" Text="Selected count:"/> <strong id="filesCount">0</strong>
        </div>
    </div>
    <div style="float: right; width: 78%">
        <dx:ASPxFileManager ID="ASPxFileManager1" ClientInstanceName="fileManager" runat="server">
            <Settings EnableMultiSelect="true" RootFolder="~/Content/FileManager/Files/Images" InitialFolder="Product icons" ThumbnailFolder="~/Content/FileManager/Thumbnails"/>
            <SettingsEditing AllowDownload="true" />
            <SettingsUpload Enabled="false" />
            <ClientSideEvents SelectionChanged="fileManager_SelectionChanged" />
            <Styles FolderContainer-Width="30%" />
        </dx:ASPxFileManager>        
    </div>
</asp:Content>
