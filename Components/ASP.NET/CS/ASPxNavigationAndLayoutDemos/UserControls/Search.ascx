<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Search.ascx.cs" Inherits="UserControls_Search" %>
<div class="Search" id="SearchPanel" <%= Utils.GetAccessibilityRoleAttribute("search") %>>
    <dx:ASPxImage runat="server" ID="PicSearch" SpriteCssClass="Pic">
        <ClientSideEvents Click="DXDemo.focusSearch" />
    </dx:ASPxImage>
    <dx:ASPxTextBox Height="23px" runat="server" ID="TbSearch" Width="241px" CssClass="SearchBox"
        EnableTheming="false" ClientInstanceName="SearchBox" AutoCompleteType="Disabled" MaxLength="50">
        <ClientSideEvents KeyUp="DXDemo.Search.onSearchBoxKeyPress" KeyDown="DXDemo.Search.onSearchBoxKeyDown" GotFocus="DXDemo.Search.onSearchBoxGotFocus" />
    </dx:ASPxTextBox>
    <b class="Clear"></b>
</div>
<dx:ASPxPopupControl runat="server" ID="SearchPopup" ClientInstanceName="SearchPopup" OnWindowCallback="SearchPopup_WindowCallback"
    EnableTheming="false" ShowHeader="false" PopupAlignCorrection="Disabled"
    PopupVerticalAlign="Below" PopupHorizontalAlign="LeftSides" CssClass="SearchPopup">
	<SettingsLoadingPanel Text="SEARCHING..." />
    <ClientSideEvents BeginCallback="DXDemo.Search.onSearchPopupBeginCallback" EndCallback="DXDemo.Search.onSearchPopupEndCallback" />
    <ContentCollection>
        <dx:PopupControlContentControl>
            <div runat="server" id="ResultsPanel" visible="false" class="ResultsPanel">
                <dx:ASPxNavBar runat="server" ID="SearchResultsNavBar" ClientInstanceName="SearchResultsNavBar" CssClass="ResultsNavBar" EnableTheming="false" 
                    EnableViewState="false" EnableClientSideAPI="true" AllowSelectItem="true" AllowExpanding="false"
                    Width="100%" ShowExpandButtons="false" AccessibilityCompliant="true" EncodeHtml="false">
                    <ItemTextTemplate>
                        <div id="sr_<%# Container.Item.Group.Index %>_<%# Container.Item.Index %>"><%# Container.Item.Text %></div>
                    </ItemTextTemplate>
                </dx:ASPxNavBar>
            </div>
            <div runat="server" id="NoResultsPanel" class="NoResultsPanel" visible="false">
                No results found for <b runat="server" id="RequestText"></b>.
            </div>
        </dx:PopupControlContentControl>
    </ContentCollection>
    <LoadingDivStyle CssClass="LoadingDiv"></LoadingDivStyle>
    <LoadingPanelStyle CssClass="SearchLoadingPanel"></LoadingPanelStyle>
    <LoadingPanelImage Url="~/Content/Loading.gif"></LoadingPanelImage>
</dx:ASPxPopupControl>
