<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Appearance.aspx.cs"
    Inherits="CloudControl_Appearance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; width: 75%">
        <asp:PlaceHolder ID="phAppearances" runat="server" />
    </div>
    <div style="float: right; width: 23%">
        <div class="BottomPadding">
            <dx:ASPxLabel ID="Label1" runat="server" Text="Select Appearance:" />
        </div>
        <dx:ASPxMenu ID="mSelector" EnableViewState="False" runat="server" DataSourceID="XmlDataSource1"
            EncodeHtml="False" Orientation="Vertical" Width="100%">
        </dx:ASPxMenu>
    </div>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Appearances.xml"
        XPath="/Appearances/AppearanceGroup[@Component='CloudControl']/*" />
</asp:Content>
