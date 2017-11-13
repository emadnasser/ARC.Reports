<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.cs"
    Inherits="PopupControl_Features" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <script type="text/javascript">
        function SetPCVisible(value) {
            var popupControl = GetPopupControl();
            if (value)
                popupControl.Show();
            else
                popupControl.Hide();
        }
        function SetImageState(value) {
            var img = document.getElementById('imgButton');
            var imgSrc = value ? 'Images/Buttons/pcButtonPress.gif' : 'Images/Buttons/pcButton.gif';
            img.src = imgSrc;
        }
        function GetPopupControl() {
            return ASPxPopupClientControl;
        }
    </script>
    <dx:ASPxPopupControl ClientInstanceName="ASPxPopupClientControl" Width="330px" Height="250px"
        MaxWidth="800px" MaxHeight="800px" MinHeight="150px" MinWidth="150px" ID="pcMain"
        ShowFooter="True" FooterText="Runtime: 142 min" PopupElementID="imgButton" HeaderText="Area of Countries"
        runat="server" EnableViewState="false" PopupHorizontalAlign="LeftSides" PopupVerticalAlign="Below" EnableHierarchyRecreation="True">
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
        <ClientSideEvents CloseUp="function(s, e) { SetImageState(false); }" PopUp="function(s, e) { SetImageState(true); }" />
    </dx:ASPxPopupControl>
    <div style="float: left; width: 56%; margin-right: 2%">
        <span runat="server" enableviewstate="False" id="lblCursor" style="cursor: pointer;">
            <img id="imgButton" alt="" src="Images/Buttons/pcButton.gif" style="width: 103px;
                height: 28px;" />
        </span>
    </div>
    <div style="float: left;">
        <table class="OptionsTable" style="white-space: nowrap">
            <tr>
                <td colspan="2" style="padding: 0 0 8px">
                    <b>Layout</b>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxCheckBox ID="cbShowCloseButton" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="ShowCloseButton" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxCheckBox ID="cbShowShadow" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="ShowShadow" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxCheckBox ID="cbShowHeader" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="ShowHeader" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxCheckBox ID="cbShowFooter" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="ShowFooter" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel EnableViewState="False" ID="lblPopupHorizontalAlign" runat="server"
                        Text="PopupHorizontalAlign:" AssociatedControlID="ddlPopupHorizontalAlign" />
                </td>
                <td>
                    <dx:ASPxComboBox Width="124px" SelectedIndex="2" ID="ddlPopupHorizontalAlign" runat="server"
                        AutoPostBack="True">
                        <Items>
                            <dx:ListEditItem Value="NotSet" Text="NotSet" />
                            <dx:ListEditItem Value="OutsideLeft" Text="OutsideLeft" />
                            <dx:ListEditItem Value="LeftSides" Text="LeftSides" />
                            <dx:ListEditItem Value="Center" Text="Center" />
                            <dx:ListEditItem Value="RightSides" Text="RightSides" />
                            <dx:ListEditItem Value="OutsideRight" Text="OutsideRight" />
                            <dx:ListEditItem Value="WindowCenter" Text="WindowCenter" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel EnableViewState="False" ID="lblPopupVerticalAlign" runat="server" Text="PopupVerticalAlign:"
                        AssociatedControlID="ddlPopupVerticalAlign" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="5" Width="124px" ID="ddlPopupVerticalAlign" runat="server"
                        AutoPostBack="True">
                        <Items>
                            <dx:ListEditItem Value="NotSet" Text="NotSet" />
                            <dx:ListEditItem Value="Above" Text="Above" />
                            <dx:ListEditItem Value="TopSides" Text="TopSides" />
                            <dx:ListEditItem Value="Middle" Text="Middle" />
                            <dx:ListEditItem Value="BottomSides" Text="BottomSides" />
                            <dx:ListEditItem Value="Below" Text="Below" />
                            <dx:ListEditItem Value="WindowCenter" Text="WindowCenter" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel EnableViewState="False" ID="lblPopupHorizontalOffset" runat="server"
                        Text="PopupHorizontalOffset (px):" AssociatedControlID="tbPopupHorizontalOffset" />
                </td>
                <td>
                    <dx:ASPxTextBox ID="tbPopupHorizontalOffset" runat="server" CssClass="DemoEdit" Width="50px"
                        Text="0" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel EnableViewState="False" ID="lblPopupVerticalOffset" runat="server"
                        Text="PopupVerticalOffset (px):" AssociatedControlID="tbPopupVerticalOffset" />
                </td>
                <td>
                    <dx:ASPxTextBox ID="tbPopupVerticalOffset" runat="server" CssClass="DemoEdit" Width="50px"
                        Text="0" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel EnableViewState="False" ID="lblOpacity" runat="server" Text="Opacity (%):"
                        AssociatedControlID="tbOpacity" />
                </td>
                <td>
                    <dx:ASPxTextBox ID="tbOpacity" runat="server" CssClass="DemoEdit" Width="50px" Text="100" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="padding: 12px 0 8px">
                    <b>Behavior</b>
                </td>
            </tr>
             <tr>
                <td style="padding-left: 3px;">
                    <dx:ASPxLabel ID="lblPopupAnimationType" runat="server" EnableViewState="False" Text="PopupAnimationType:"
                        AssociatedControlID="ddlPopupAnimationType" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="0" Width="124px" ID="ddlPopupAnimationType" runat="server"
                        AutoPostBack="True">
                        <Items>
                            <dx:ListEditItem Value="Slide" Text="Slide" />
                            <dx:ListEditItem Value="Fade" Text="Fade" />
                            <dx:ListEditItem Text="None" Value="None" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td style="padding-left: 3px;">
                    <dx:ASPxLabel ID="lblCloseAnimationType" runat="server" EnableViewState="False" Text="CloseAnimationType:"
                        AssociatedControlID="ddlCloseAnimationType" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="2" Width="124px" ID="ddlCloseAnimationType" runat="server"
                        AutoPostBack="True">
                        <Items>
                            <dx:ListEditItem Value="Slide" Text="Slide" />
                            <dx:ListEditItem Value="Fade" Text="Fade" />
                            <dx:ListEditItem Text="None" Value="None" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxCheckBox ID="cbAllowDragging" runat="server" AutoPostBack="True" CssClass="DemoCheckBox"
                        Text="AllowDragging" />
                </td>
            </tr>
            <tr>
                <td style="padding-left: 3px;">
                    <dx:ASPxLabel ID="lblDragElement" runat="server" EnableViewState="False" Text="DragElement:"
                        AssociatedControlID="ddlDragElement" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="0" Width="124px" ID="ddlDragElement" runat="server"
                        AutoPostBack="True">
                        <Items>
                            <dx:ListEditItem Value="Header" Text="Header" />
                            <dx:ListEditItem Value="Window" Text="Window" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxCheckBox ID="cbAllowResize" runat="server" AutoPostBack="True" CssClass="DemoCheckBox"
                        Text="AllowResize" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lbResizingMode" runat="server" EnableViewState="False" Text="ResizingMode:" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="1" Width="124px" ID="ddlResizeMode" runat="server"
                        AutoPostBack="True">
                        <Items>
                            <dx:ListEditItem Value="Postponed" Text="Postponed" />
                            <dx:ListEditItem Value="Live" Text="Live" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="Label4" runat="server" EnableViewState="False" Text="ShowSizeGrip:" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="0" Width="124px" ID="ddlShowSizeGrip" runat="server"
                        AutoPostBack="True">
                        <Items>
                            <dx:ListEditItem Value="Auto" Text="Auto" />
                            <dx:ListEditItem Value="True" Text="True" />
                            <dx:ListEditItem Value="False" Text="False" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel EnableViewState="False" ID="lbScrollBars" runat="server" Text="ScrollBars:" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="0" Width="124px" ID="ddlScrollBars" runat="server"
                        AutoPostBack="True" OnSelectedIndexChanged="ddlScrollBars_SelectedIndexChanged">
                        <Items>
                            <dx:ListEditItem Value="None" Text="None" />
                            <dx:ListEditItem Value="Horizontal" Text="Horizontal" />
                            <dx:ListEditItem Value="Vertical" Text="Vertical" />
                            <dx:ListEditItem Value="Both" Text="Both" />
                            <dx:ListEditItem Value="Auto" Text="Auto" />
                        </Items>
                    </dx:ASPxComboBox>
                    <dx:ASPxHyperLink ID="ASPxHyperLink1" runat="server" Visible="False" NavigateUrl="javascript:SetPCVisible(true);"
                        CssClass="LinkButton" Text="Show" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel EnableViewState="False" ID="lblCloseAction" runat="server" Text="CloseAction:" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="2" Width="124px" ID="ddlCloseAction" runat="server"
                        AutoPostBack="True" OnSelectedIndexChanged="ddlCloseAction_SelectedIndexChanged">
                        <Items>
                            <dx:ListEditItem Value="None" Text="None" />
                            <dx:ListEditItem Value="CloseButton" Text="CloseButton" />
                            <dx:ListEditItem Value="OuterMouseClick" Text="OuterMouseClick" />
                            <dx:ListEditItem Value="MouseOut" Text="MouseOut" />
                        </Items>
                    </dx:ASPxComboBox>
                    <dx:ASPxHyperLink ID="hlHide" runat="server" Visible="False" NavigateUrl="javascript:SetPCVisible(false);"
                        CssClass="LinkButton" Text="Hide" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxCheckBox ID="cbCloseOnEscape" runat="server" AutoPostBack="True"
                        CssClass="DemoCheckBox" Text="CloseOnEscape" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel EnableViewState="False" ID="lblPopupAction" runat="server" Text="PopupAction:" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="1" Width="124px" ID="ddlPopupAction" runat="server"
                        AutoPostBack="True" OnSelectedIndexChanged="ddlPopupAction_SelectedIndexChanged">
                        <Items>
                            <dx:ListEditItem Value="None" Text="None" />
                            <dx:ListEditItem Value="LeftMouseClick" Text="LeftMouseClick" />
                            <dx:ListEditItem Value="RightMouseClick" Text="RightMouseClick" />
                            <dx:ListEditItem Value="MouseOver" Text="MouseOver" />
                        </Items>
                    </dx:ASPxComboBox>
                    <dx:ASPxHyperLink ID="hlShow" runat="server" Visible="False" NavigateUrl="javascript:SetPCVisible(true);"
                        CssClass="LinkButton" Text="Show" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel EnableViewState="False" ID="lblAppearAfter" runat="server" Text="AppearAfter (ms):"
                        AssociatedControlID="tbAppearAfter" />
                </td>
                <td>
                    <dx:ASPxTextBox ID="tbAppearAfter" runat="server" CssClass="DemoEdit" Width="50px"
                        Text="300" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel EnableViewState="False" ID="lblDisappearAfter" runat="server" Text="DisappearAfter (ms):"
                        AssociatedControlID="tbDisappearAfter" />
                </td>
                <td>
                    <dx:ASPxTextBox ID="tbDisappearAfter" runat="server" CssClass="DemoEdit" Width="50px"
                        Text="500" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxButton ID="Button1" CssClass="DemoButton" runat="server" Text="Apply" OnClick="Button1_Click"
                        Width="70px"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxLabel EnableViewState="False" ID="lblPopupHorizontalOffsetError" runat="server"
                        Font-Size="9px" ForeColor="Red" Text="PopupHorizontalOffset value isn't valid"
                        Visible="False" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxLabel EnableViewState="False" ID="lblPopupVerticalOffsetError" runat="server"
                        Font-Size="9px" ForeColor="Red" Text="PopupVerticalOffset value isn't valid"
                        Visible="False" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxLabel EnableViewState="False" ID="lblAppearAfterError" runat="server" Font-Size="9px"
                        ForeColor="Red" Text="AppearAfter value isn't valid" Visible="False" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxLabel EnableViewState="False" ID="lblDisappearAfterError" runat="server"
                        Font-Size="9px" ForeColor="Red" Text="DisappearAfter value isn't valid" Visible="False" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxLabel EnableViewState="False" ID="lblOpacityError" runat="server" Font-Size="9px"
                        ForeColor="Red" Text="Opacity value isn't valid" Visible="False" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
