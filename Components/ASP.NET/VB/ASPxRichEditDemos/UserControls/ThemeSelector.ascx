<%@ Control Language="vb" %>
<script runat="server">
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If Utils.CanChangeTheme Then
			ThemesContainerRepeaterLeft.DataBind()
			ThemesContainerRepeaterRight.DataBind()
		Else
			ThemeSelectorPopup.Visible = False
		End If
	End Sub
	Protected Sub Menu_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
		Dim menu As ASPxMenu = CType(sender, ASPxMenu)
		Dim item As RepeaterItem = TryCast(menu.NamingContainer, RepeaterItem)
		If item IsNot Nothing Then
			Dim group As ThemeGroupModel = TryCast(item.DataItem, ThemeGroupModel)
			For Each theme As ThemeModel In group.Themes
				Dim menuItem As DevExpress.Web.MenuItem = menu.Items.Add(theme.Title, theme.Name)
				menuItem.Selected = (theme.Name Is Utils.CurrentTheme)
				menuItem.ToolTip = theme.Title
			Next theme
		End If
	End Sub
</script>
<a href="javascript:void(0)" class="ThemeButton" title="Current Theme: <%=Utils.CurrentThemeTitle%>" id="ThemeButton">
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
						<asp:Repeater runat="server" ID="ThemesContainerRepeaterLeft" EnableViewState="false" DataSource="<%#ThemesModel.Current.LeftGroups%>">
							<ItemTemplate>
								<div class="ThemeGroupItem">
									<div class="ThemeGroup">
										<%#(CStr(Eval("Title"))).ToUpper()%>
									</div>
									<dx:ASPxMenu ID="ThemeGroupMenu" CssClass="ThemeGroupMenu" runat="server" EnableTheming="false"
										EnableViewState="false" Orientation="Vertical" ItemImagePosition="Left" ItemSpacing="0px"
										OnDataBinding="Menu_DataBinding">
										<ClientSideEvents ItemClick="function(s,e){ DXDemo.SetCurrentTheme(e.item.name); }" />
										<ItemTextTemplate>
											<div class="ThemeIco"><span class="Theme<%#Eval("Name")%>"></span></div>
											<%#Eval("Text")%>
										</ItemTextTemplate>
									</dx:ASPxMenu>
								</div>
							</ItemTemplate>
						</asp:Repeater>
					</div>
					<div class="ThemeColumnRight">
						<asp:Repeater runat="server" ID="ThemesContainerRepeaterRight" EnableViewState="false" DataSource="<%#ThemesModel.Current.RightGroups%>">
							<ItemTemplate>
								<div class="ThemeGroupItem">
									<div class="ThemeGroup">
										<%#(CStr(Eval("Title"))).ToUpper()%>
									</div>
									<dx:ASPxMenu ID="ThemeGroupMenu" CssClass="ThemeGroupMenu" runat="server" EnableTheming="false"
										EnableViewState="false" Orientation="Vertical" ItemImagePosition="Left" ItemSpacing="0px"
										OnDataBinding="Menu_DataBinding">
										<ClientSideEvents ItemClick="function(s,e){ DXDemo.SetCurrentTheme(e.item.name); }" />
										<ItemTextTemplate>
											<div class="ThemeIco"><span class="Theme<%#Eval("Name")%>"></span></div>
											<%#Eval("Text")%>
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