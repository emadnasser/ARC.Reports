<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MobileViewer.aspx.cs"
    Inherits="WebSpecificFeatures_MobileViewer" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:MobileEmulator ID="mobileEmulator" runat="server" />
    <script src="../Scripts/MobileEmulator.js" type="text/javascript"></script>
</asp:Content>
