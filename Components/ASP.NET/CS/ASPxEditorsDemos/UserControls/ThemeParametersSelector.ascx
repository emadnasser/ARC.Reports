<%@ Control Language="C#" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e) {
        if(Utils.CanChangeBaseColor) {
            rpColorButtons.DataSource = Utils.CustomBaseColors;
            rpColorButtons.DataBind();
        }
        rblFonts.DataSource = Utils.GetFontFamiliesDataSource();
        rblFonts.DataBind();
        rblFonts.SelectedIndex = !string.IsNullOrEmpty(ASPxWebControl.GlobalThemeFont) ? rblFonts.Items.IndexOfValue(ASPxWebControl.GlobalThemeFont) : 0;
    }
    protected void btnColor_Load(object sender, EventArgs e) {
        var button = ((ASPxButton)sender);
        button.ClientSideEvents.Click = string.Format("function(){{ DXDemo.SetCurrentBaseColor('{0}'); }}", System.Drawing.ColorTranslator.ToHtml(button.BackColor));
        var currentColor = System.Drawing.ColorTranslator.FromHtml(!string.IsNullOrEmpty(ASPxWebControl.GlobalThemeBaseColor) ? ASPxWebControl.GlobalThemeBaseColor : Utils.CurrentThemeDefaultBaseColor);
        button.Checked = object.Equals(currentColor, button.BackColor);
    }
</script>
<%@ Register TagPrefix="dx" Namespace="DevExpress.Web" Assembly="DevExpress.Web.v16.2" %>
<a href="javascript:void(0)" class="ThemeButton" style="position: relative;" id="ThemeParametersButton">THEME SETTINGS
    <dx:ASPxImage runat="server" ID="cGlyph" SpriteCssClass="Glyph"></dx:ASPxImage>
</a>
<dx:ASPxPopupControl ID="ThemeParametersPopup" ClientInstanceName="ThemeParametersPopup" CssClass="theme-parameters-popup" runat="server"
    ShowHeader="False" ShowShadow="false" PopupAnimationType="None"
    EnableTheming="false" PopupElementID="ThemeParametersButton" PopupHorizontalAlign="RightSides" PopupVerticalAlign="TopSides"
    PopupHorizontalOffset="24" PopupVerticalOffset="-19" PopupAlignCorrection="Disabled"
    PopupAction="LeftMouseClick" Width="309px">
    <ClientSideEvents Init="DXThemeSettingsPopupContainer_Init" />
    <ContentCollection>
        <dx:PopupControlContentControl runat="server">
            <div class="themes-button-wrapper">
            </div>
            <div class="button-wrapper">
                <div class="color-button-border">
                </div>
            </div>
            <div class="button-wrapper-bottomBorder"></div>
            <b class="Clear"></b>
            <div class="parameters-container-wrapper">
                <div class="parameters-container">
                    <% if(Utils.CanChangeBaseColor) { %>
                    <div class="base-color-container">
                        <dx:ASPxLabel runat="server" ID="lblBaseColor" Text="Base Color" CssClass="caption" EnableViewState="false"></dx:ASPxLabel>
                        <asp:Repeater runat="server" ID="rpColorButtons" EnableViewState="false">
                            <ItemTemplate><!--Fix whitespace issue
                             --><div class="color-item-container">
                                    <div class="color-item-wrapper">
                                        <dx:ASPxButton runat="server" ID="btnColor" GroupName="colors" CssClass="color-item" BackColor="<%# System.Drawing.ColorTranslator.FromHtml((string)Container.DataItem) %>"
                                         UseSubmitBehavior="false" AutoPostBack="false" EnableViewState="false" EnableTheming="false" OnLoad="btnColor_Load">
                                            <CheckedStyle CssClass="selected-item"></CheckedStyle>
                                        </dx:ASPxButton>
                                    </div>
                                </div><!--Fix whitespace issue
                         --></ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <% } %>
                    <dx:ASPxLabel runat="server" ID="lblThemeFont" EnableViewState="false" Text="Font" CssClass="caption-font"></dx:ASPxLabel>
                    <dx:ASPxRadioButtonList ID="rblFonts" runat="server" ClientInstanceName="rblFonts" RepeatColumns="2" RepeatLayout="Table" EnableViewState="false" Width="100%"  EnableTheming="true" Theme="Metropolis">
                        <Border BorderStyle="none" />
                        <Paddings Padding="0" />
                        <ClientSideEvents SelectedIndexChanged="function(){{ DXDemo.SetCurrentFont(rblFonts.GetSelectedItem().value); }}" />
                    </dx:ASPxRadioButtonList>
                </div>
            </div>
        </dx:PopupControlContentControl>
    </ContentCollection>
</dx:ASPxPopupControl>
