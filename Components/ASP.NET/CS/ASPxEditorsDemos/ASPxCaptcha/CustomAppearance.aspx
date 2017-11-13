<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomAppearance.aspx.cs"
    Inherits="ASPxCaptcha_CustomAppearance" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <link rel="stylesheet" type="text/css" href="Css/CustomAppearance.css">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function getRefreshButton() {
            return document.getElementById("refreshButton");
        }
        function onCaptchaBeginCallback(s,e) {
            var refreshButton = getRefreshButton();
            refreshButton.src="Images/refreshButtonAnimated.gif";
        }
        function onCaptchaEndCallback(s,e) {
            var refreshButton = getRefreshButton();
            refreshButton.src="Images/refreshButton.gif";
            document.getElementById("tbCode").value = "";
            if(typeof (lblCorrectCodeMessage) != "undefined")
                lblCorrectCodeMessage.SetVisible(false);
            if(typeof (lblIncorrectCodeMessage) != "undefined")
                lblIncorrectCodeMessage.SetVisible(false);
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <%--start highlighted block--%>
    <table style="margin: 0 auto">
        <tr>
            <td>
                <table class="mainTable">
                    <tr>
                        <td style="font-size: 0;">
                            <img id="refreshButton" src="Images/refreshButton.gif" alt="Show another code" title="" class="refreshButton" onclick="captcha.Refresh();" />
                            <div class="captchaDiv">
                                <dx:ASPxCaptcha ID="Captcha" runat="server" SkinID="dummy" ClientInstanceName="captcha" CodeLength="6">
                                    <ChallengeImage BackgroundColor="Transparent" ForegroundColor="#676767" BorderWidth="0" Height="72" />
                                    <ValidationSettings EnableValidation="False"></ValidationSettings>
                                    <TextBox Visible="False" />
                                    <RefreshButton Visible="False"></RefreshButton>
                                    <LoadingPanel Enabled="False" />
                                    <ClientSideEvents BeginCallback="onCaptchaBeginCallback" EndCallback="onCaptchaEndCallback" />
                                </dx:ASPxCaptcha>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td class="labelCell">
                            <label for="tbCode">Type the code</label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textBoxCell">
                            <input type="text" id="tbCode" name="tbCode" autocomplete="off" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="padding-top: 10px;">
                <dx:ASPxButton ID="btnSubmit" runat="server" Text="Submit" UseSubmitBehavior="true" AutoPostBack="true" Width="175px" CssClass="submitButton" />
            </td>
        </tr>
        <tr>
            <td style="margin-top: 5px; height: 20px; vertical-align: middle; text-align: center">
                <dx:ASPxLabel ID="lblIncorrectCodeMessage" runat="server" ForeColor="Red" Visible="False" Text="The submitted code is incorrect" ClientInstanceName="lblIncorrectCodeMessage" />
                <dx:ASPxLabel ID="lblCorrectCodeMessage" runat="server" ForeColor="Green" Visible="False" Text="The submitted code is correct" ClientInstanceName="lblCorrectCodeMessage" />
            </td>
        </tr>
    </table>
    <%--end highlighted block--%>
</asp:Content>
