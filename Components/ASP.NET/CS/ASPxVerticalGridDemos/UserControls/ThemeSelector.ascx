<%@ Control Language="C#" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e) {
        if(Utils.CanChangeTheme) {
            ThemesContainerRepeaterLeft.DataBind();
            ThemesContainerRepeaterRight.DataBind();
        }
        else {
            ThemeSelectorPopup.Visible = false;
        }
    }
    protected void Menu_DataBinding(object sender, EventArgs e) {
        ASPxMenu menu = (ASPxMenu)sender;
        RepeaterItem item = menu.NamingContainer as RepeaterItem;
        if(item != null) {
            ThemeGroupModel group = item.DataItem as ThemeGroupModel;
            foreach(ThemeModel theme in group.Themes) {
                DevExpress.Web.MenuItem menuItem = menu.Items.Add(theme.Title, theme.Name);
                menuItem.Selected = (theme.Name == Utils.CurrentTheme);
                menuItem.ToolTip = theme.Title;
            }
        }
    }
</script>
<a href="javascript:void(0)" class="ThemeButton" title="Current Theme: <%= Utils.CurrentThemeTitle %>" id="ThemeButton">
    <dx:ASPxImage runat="server" ID="tPic" SpriteCssClass="Icon"></dx:ASPxImage>
    THEMES
    <dx:ASPxImage runat="server" ID="tGlyph" SpriteCssClass="Glyph"></dx:ASPxImage>
</a>
<dx:ASPxPopupControl ID="ThemeSelectorPopup" ClientInstanceName="ThemeSelectorPopup" CssClass="ThemeSelectorPopup" runat="server"
    EnableTheming="false" ShowHeader="False" ShowShadow="false" PopupAnimationType="None"
    PopupElementID="ThemeButton" PopupHorizontalAlign="RightSides" PopupVerticalAlign="TopSides"
    PopupHorizontalOffset="24" PopupVerticalOffset="-19" PopupAlignCorrection="Disabled"
    PopupAction="LeftMouseClick" Width="450px">
    <ClientSideEvents Init="DXSelectorPopupContainer_Init" />
    <ContentCollection>
        <dx:PopupControlContentControl runat="server">
            <div class="ButtonWrapper">
                <div class="ThemeButtonBorder">
                </div>
            </div>
            <div class="ButtonWrapperBtmBorder"></div>
            <b class="Clear"></b>
            <div class="ContainerWrapper">
                <div class="ThemeContainer">
                    <div class="ThemeColumnLeft">
                        <asp:Repeater runat="server" ID="ThemesContainerRepeaterLeft" EnableViewState="false" DataSource="<%# ThemesModel.Current.LeftGroups %>">
                            <ItemTemplate>
                                <div class="ThemeGroupItem">
                                    <div class="ThemeGroup">
                                        <%# ((string)Eval("Title")).ToUpper() %>
                                    </div>
                                    <dx:ASPxMenu ID="ThemeGroupMenu" CssClass="ThemeGroupMenu" runat="server" EnableTheming="false"
                                        EnableViewState="false" Orientation="Vertical" ItemImagePosition="Left" ItemSpacing="0px"
                                        OnDataBinding="Menu_DataBinding">
                                        <ClientSideEvents ItemClick="function(s,e){ DXDemo.SetCurrentTheme(e.item.name); }" />
                                        <ItemTextTemplate>
                                            <div class="ThemeIco"><span class="Theme<%# Eval("Name") %>"></span></div>
                                            <%# Eval("Text") %>
                                        </ItemTextTemplate>
                                    </dx:ASPxMenu>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <div class="ThemeColumnRight">
                        <asp:Repeater runat="server" ID="ThemesContainerRepeaterRight" EnableViewState="false" DataSource="<%# ThemesModel.Current.RightGroups %>">
                            <ItemTemplate>
                                <div class="ThemeGroupItem">
                                    <div class="ThemeGroup">
                                        <%# ((string)Eval("Title")).ToUpper() %>
                                    </div>
                                    <dx:ASPxMenu ID="ThemeGroupMenu" CssClass="ThemeGroupMenu" runat="server" EnableTheming="false"
                                        EnableViewState="false" Orientation="Vertical" ItemImagePosition="Left" ItemSpacing="0px"
                                        OnDataBinding="Menu_DataBinding">
                                        <ClientSideEvents ItemClick="function(s,e){ DXDemo.SetCurrentTheme(e.item.name); }" />
                                        <ItemTextTemplate>
                                            <div class="ThemeIco"><span class="Theme<%# Eval("Name") %>"></span></div>
                                            <%# Eval("Text") %>
                                        </ItemTextTemplate>
                                    </dx:ASPxMenu>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <b class="Clear"></b>
                </div>
            </div>
        </dx:PopupControlContentControl>
    </ContentCollection>
</dx:ASPxPopupControl>
