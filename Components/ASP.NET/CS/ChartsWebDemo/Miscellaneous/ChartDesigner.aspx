<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ChartDesigner.aspx.cs" Inherits="ChartDesigner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCallbackPanel ID="callbackPanel" runat="server" ClientInstanceName="callbackPanel">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">   
                            <dx:ASPxButton ID="ShowDesignerButton" ClientInstanceName="ShowDesignerButton" runat="server" AutoPostBack="False" Text="Show Chart Designer" OnClick="ShowDesignerButton_Click" />
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxRoundPanel>
                <dx:WebChartControl ID="chart" ClientInstanceName="chart" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin" CrosshairEnabled="True">
                    <BorderOptions Visibility="False" />
                </dx:WebChartControl>
            </dx:PanelContent>
        </PanelCollection>
     </dx:ASPxCallbackPanel>
</asp:Content>
