<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.cs"
    Inherits="RatingControl_DataBinding" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="ratingPanel" runat="server" Width="100%" ShowHeader="false">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <dx:ASPxDataView ID="ASPxDataView1" runat="server" Width="100%" SkinID="EmptySkin" 
                    DataSourceID="XmlDataSource1" SettingsTableLayout-ColumnCount="1" AllowPaging="false" ItemSpacing="25">
                    <ItemTemplate>
                        <table style="width:100%">
                            <tr>
                                <td style="width: 100%">
                                    <dx:ASPxLabel ID="lbName" runat="server" Text='<%# Eval("Name") %>' Font-Size="18pt" />
                                </td>
                                <td>
                                    <dx:ASPxRatingControl ID="rating" runat="server" ReadOnly="true" Value='<%# GetRatingValue(Eval("Value")) %>' />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" style="padding: 5px 5px 0 0">
                                    <dx:ASPxLabel ID="lbDescription" runat="server" Text='<%# Eval("Description") %>' />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <Paddings Padding="5" />
                    <ItemStyle Width="100%" CssClass="NoStyle"/>
                </dx:ASPxDataView>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/ControlRatings.xml"
        XPath="/Controls/*" />
</asp:Content>
