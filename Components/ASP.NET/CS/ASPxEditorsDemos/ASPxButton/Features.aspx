<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.cs"
    Inherits="ASPxButton_Features" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function ASPxButton4_CheckedChanged(s, e) {
            if(s.GetChecked()) {
                button.SetEnabled(false);
                s.SetText("Enable Button");
            } else {
                button.SetEnabled(true);
                s.SetText("Disable Button");
            }
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxRoundPanel ID="RadioButtonsGroupBox" runat="server" Width="100%" HeaderText="Radio buttons"
        HorizontalAlign="Center">
        <PanelCollection>
            <dx:PanelContent>
                <table style="height: 40px;">
                    <tr>
                        <td>
                            <dx:ASPxButton ID="ASPxButton1" runat="server" AutoPostBack="False" Checked="True"
                                GroupName="G" Text="Option 1" Width="110px">
                            </dx:ASPxButton>
                        </td>
                        <td>
                            <div class="Spacer" style="width: 10px;">
                            </div>
                        </td>
                        <td>
                            <dx:ASPxButton ID="ASPxButton2" runat="server" AutoPostBack="False" GroupName="G"
                                Text="Option 2" Width="110px">
                            </dx:ASPxButton>
                        </td>
                        <td>
                            <div class="Spacer" style="width: 10px;">
                            </div>
                        </td>
                        <td>
                            <dx:ASPxButton ID="ASPxButton3" runat="server" AutoPostBack="False" GroupName="G"
                                Text="Option 3" Width="110px">
                            </dx:ASPxButton>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <div class="Spacer" style="height: 14px;">
    </div>
    <dx:ASPxRoundPanel ID="ClientSideGroupBox" runat="server" Width="100%" HeaderText="Client-side functionality"
        HorizontalAlign="Center">
        <PanelCollection>
            <dx:PanelContent>
                <table style="height: 40px;">
                    <tr>
                        <td>
                            <dx:ASPxButton ID="ASPxButton4" runat="server" AutoPostBack="False" GroupName="G1"
                                Wrap="False" Text="Disable Button" Width="117px">
                                <ClientSideEvents CheckedChanged="ASPxButton4_CheckedChanged" />
                            </dx:ASPxButton>
                        </td>
                        <td>
                            <div class="Spacer" style="width: 10px;">
                            </div>
                        </td>
                        <td>
                            <dx:ASPxButton ID="ASPxButton5" runat="server" AutoPostBack="False" ClientInstanceName="button"
                                Text="Button" Width="110px">
                            </dx:ASPxButton>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
</asp:Content>
