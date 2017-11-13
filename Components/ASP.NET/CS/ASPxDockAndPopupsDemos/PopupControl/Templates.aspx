<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Templates.aspx.cs"
    Inherits="PopupControl_Templates" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <script type="text/javascript">
        function SetPCVisible(doShow) {
            var popupControl = GetPopupControl();
            if (doShow) {
                popupControl.Show();
            }
            else {
                popupControl.Hide();
            }
        }
        function SetHelpVisible(doShow) {
            var pHelp = document.getElementById('pHelp');
            pHelp.style.display = doShow ? "" : "none";
        }
        function SetColor(colorName) {
            var link = document.getElementById('lColorCSS');
            var linkSrc = link.href.substring(0, link.href.lastIndexOf('/'));
            link.href = linkSrc + '/' + colorName + 'Color.css';
        }
        function AddHover(element) {
            element.className = element.className + ' Hover';
        }
        function RemoveHover(element) {
            element.className = element.className.replace(' Hover', '');
        }
        function GetPopupControl() {
            return ASPxPopupClientControl;
        }        
    </script>
    <dx:ASPxPopupControl ClientInstanceName="ASPxPopupClientControl" SkinID="None" ShowFooter="True" Width="240px"
        ShowOnPageLoad="True" PopupHorizontalAlign="Center" PopupVerticalAlign="TopSides"
        CssClass="PopupControlTemplate" AllowDragging="True" CloseAction="None" PopupElementID="popupArea"
        ID="ASPxPopupControl1" EnableViewState="False" runat="server" PopupHorizontalOffset="0"
        PopupVerticalOffset="0" EnableHierarchyRecreation="True">
        <HeaderTemplate>
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%;">
                        Templates
                    </td>
                    <td>
                        <img class="HideBorder" onclick="SetHelpVisible(true);" onmousedown="event.cancelBubble = true;"
                            alt="" src="Images/Buttons/pcHelp.gif" style="width: 15px; height: 14px; cursor: pointer;" />
                    </td>
                    <td>
                        <img class="HideBorder" onclick="SetPCVisible(false);" onmousedown="event.cancelBubble = true;"
                            alt="" src="Images/Buttons/pcClose.gif" style="width: 15px; height: 14px; cursor: pointer;" />
                    </td>
                </tr>
            </table>
        </HeaderTemplate>
        <FooterTemplate>
            <table style="width: 100%;">
                <tr>
                    <th style="width: 100%; font-weight: normal; text-align: right">
                        Color:
                    </th>
                    <td style="padding: 4px;">
                        <img class="SelectedGray" onmouseover="AddHover(this);" onmouseout="RemoveHover(this);"
                            onclick="SetColor('Gray');" alt="" src="Images/Colors/GrayColor.gif" style="width: 12px;
                            height: 12px; cursor: pointer" />
                    </td>
                    <td style="padding: 4px;">
                        <img class="SelectedYellow" onmouseover="AddHover(this);" onmouseout="RemoveHover(this);"
                            onclick="SetColor('Yellow');" alt="" src="Images/Colors/YellowColor.gif" style="width: 12px;
                            height: 12px; cursor: pointer" />
                    </td>
                    <td style="padding: 4px;">
                        <img class="SelectedBlue" onmouseover="AddHover(this);" onmouseout="RemoveHover(this);"
                            onclick="SetColor('Blue');" alt="" src="Images/Colors/BlueColor.gif" style="width: 12px;
                            height: 12px; cursor: pointer" />
                    </td>
                    <td style="padding: 4px;">
                        <img class="SelectedGreen" onmouseover="AddHover(this);" onmouseout="RemoveHover(this);"
                            onclick="SetColor('Green');" alt="" src="Images/Colors/GreenColor.gif" style="width: 12px;
                            height: 12px; cursor: pointer" />
                    </td>
                    <td style="padding: 4px;">
                        <img class="SelectedPink" onmouseover="AddHover(this);" onmouseout="RemoveHover(this);"
                            onclick="SetColor('Pink');" alt="" src="Images/Colors/PinkColor.gif" style="width: 12px;
                            height: 12px; cursor: pointer" />
                    </td>
                </tr>
            </table>
            <p id="pHelp" style="background-color: #FFFBBA; border: 1px solid #BAAE6D; margin: 4px;
                color: #9E8A4F; padding: 4px; display: none">
                Click a colored box above to select the background color for the window's content.</p>
        </FooterTemplate>
        <ContentStyle>
            <Paddings Padding="0px" />
        </ContentStyle>
        <ContentCollection>
            <dx:PopupControlContentControl runat="server">
                <asp:Panel ID="Panel1" runat="server" CssClass="PopupContentControls">
                    <p style="margin: 0px; padding: 0px;">
                        This sample demonstrates the use of template technology within the
                        <br />
                        <b>ASPxPopupControl</b>. The look of each element of a popup window can be completely
                        modified by creating a specific template which defines how the element will be rendered
                        by a client browser.</p>
                </asp:Panel>
            </dx:PopupControlContentControl>
        </ContentCollection>
        <FooterStyle Wrap="True">
            <Paddings PaddingLeft="6px" PaddingBottom="6px" PaddingRight="6px" PaddingTop="6px" />
        </FooterStyle>
        <HeaderStyle>
            <Paddings PaddingLeft="9px" />
        </HeaderStyle>
    </dx:ASPxPopupControl>
    <table style="width: 100%; height:278px" id="popupArea">
        <tr>
            <td style="text-align: center; vertical-align: middle;">
                Click here to invoke a popup window
            </td>
        </tr>
    </table>
</asp:Content>
