<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="RightToLeft.aspx.cs" Inherits="Common_RightToLeft" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div dir="rtl" style="text-align: right">
        <dx:ASPxPopupControl ClientInstanceName="ASPxPopupClientControl" Width="330px" Height="250px" RightToLeft="True" CloseAction="CloseButton"
            MaxWidth="800px" MaxHeight="800px" MinHeight="150px" MinWidth="150px" ID="pcMain" AllowDragging="True" AllowResize="true"
            ShowFooter="True" FooterText="Runtime: 142 min" PopupElementID="popupArea" HeaderText="Area of Countries" PopupAnimationType="Fade"
            runat="server" ShowOnPageLoad="True" PopupHorizontalAlign="Center" PopupVerticalAlign="TopSides" EnableHierarchyRecreation="True">
            <ContentCollection>
                <dx:PopupControlContentControl runat="server">
                    <asp:Panel ID="Panel1" runat="server">
                        <table>
                            <tr>
                                <td>
                                    <dx:ASPxImage ImageUrl="~/PopupControl/Images/CountriesArea.png" ID="ASPxImage1" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td style="color: #666666;font-family: Tahoma; font-size: 10px;">
                                       This is the Pie 3D series view, which is useful when it's necessary to compare the percentage 
                                       values of different point arguments in the same series, and to show these values as easy 
                                       to understand pie slices.
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </dx:PopupControlContentControl>
            </ContentCollection>
        </dx:ASPxPopupControl>
        <table style="width: 100%; height:350px" id="popupArea">
            <tr>
                <td style="text-align: center; vertical-align: middle">
                    Click here to invoke a popup window
                </td>
            </tr>
        </table>
    </div>
    <script type="text/javascript">
        if(ASPxClientUtils.ie && ASPxClientUtils.browserVersion > 7 && document.body.offsetWidth % 2 > 0)
            document.body.style.width = (document.body.offsetWidth - 1) + "px";
    </script>
</asp:Content>
