<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LoadAndSave.aspx.cs"
    Inherits="RichEditDemoLoadAndSave" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <script type="text/javascript">
        function OnExceptionOccurred(s, e) {
            e.handled = true;
            alert(e.message);
            window.location.reload();
        }
    </script>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" Runat="Server">
    <div style="padding-bottom:10px;">
        <label>Click the <b>Open</b> button in the <b>Common</b> group within the <b>File</b> tab to open the document browser.</label>
    </div>
    <dx:ASPxRichEdit ID="DemoRichEdit" runat="server" Width="100%" Height="700px"
        ActiveTabIndex="0" OnPreRender="DemoRichEdit_PreRender">
        <ClientSideEvents CallbackError="OnExceptionOccurred"></ClientSideEvents>
    </dx:ASPxRichEdit>
</asp:Content>
