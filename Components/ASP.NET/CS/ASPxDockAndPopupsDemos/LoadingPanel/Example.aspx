<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Example.aspx.cs"
    Inherits="ASPxLoadingPanel_Example" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback">
        <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel.Hide(); }" />
    </dx:ASPxCallback>
    <div class="BottomPadding">
        <dx:ASPxCheckBox ID="ASPxCheckBox1" runat="server" AutoPostBack="true" Checked="True"
            Text="Display the Loading Panel over a specific control">
        </dx:ASPxCheckBox>
    </div>
    <table id="Panel" style="border: Dashed 1px Gray; margin: 30px 20%">
        <tr>
            <td style="padding: 40px 200px">
                <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Show Loading Panel" AutoPostBack="False">
                    <ClientSideEvents Click="function(s, e) {
    Callback.PerformCallback();
    LoadingPanel.Show();
}" />
                </dx:ASPxButton>
            </td>
        </tr>
    </table>
    <dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel"
        Modal="True">
    </dx:ASPxLoadingPanel>
</asp:Content>
