<%@ Page Language="C#" MasterPageFile="~/Site.master" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="panelMessage" runat="server" HeaderText="Demo Unavailable">
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">
                <table border="0" cellspacing="0">
                    <tr valign="top">
                        <td style="padding-right: 10px">
                            <asp:Image runat="server" ImageUrl="~/Content/Demo/Error.gif" AlternateText="[!]" />
                        </td>
                        <td>
                            <p>
                                Sorry, this module is unavailable in our online demo.
                            </p>
                            <p>
                                If you need to test the data binding functionality, please install the ASPxScheduler
                                Suite on your machine, and run the demo locally. To download the ASPxScheduler (as
                                a part of our DXperience Suite), please visit the following page:
                            </p>
                            <p>
                                <a href="http://www.devexpress.com/Downloads/NET/DXperience/index.xml">http://www.devexpress.com/Downloads/NET/DXperience/index.xml</a>
                            </p>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
</asp:Content>
