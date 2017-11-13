﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Index.ascx.cs" Inherits="UserControls_Index" %>
<%@ Register Assembly="DevExpress.Web.v16.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<div class="wrapper-relative">
    <dx:ASPxImageSlider ID="BackSlider" CssClass="index-slider" ClientInstanceName="BackSlider" runat="server" ImageSourceFolder="~\Content\Background" Width="100%" Height="100%">
        <SettingsImageArea ItemTextVisibility="None" NavigationButtonVisibility="None" ImageSizeMode="FillAndCrop" EnableLoopNavigation="true" />
        <SettingsNavigationBar Mode="Dots" Position="Bottom" />
        <SettingsAutoGeneratedImages ImageCacheFolder="~\Thumb\" />
        <SettingsSlideShow AutoPlay="True" />
        <Images>
            <Dot Url="~/Content/Images/SliderDotEmp.png" UrlSelected="~/Content/Images/SliderDotCur.png" Width="14px" Height="14px"></Dot>
        </Images>
    </dx:ASPxImageSlider>
    <div class="index-content" id="IndexContent">
        <div class="index-search">
            <h3>Search for a Hotel</h3>
            <dx:ASPxComboBox ID="SearchComboBox" ClientInstanceName="SearchComboBox" CssClass="combobox" runat="server"
                Width="510px" Height="48px" Font-Size="24px" NullText="Tap to select a location"
                DataSourceID="LocationLinqDataSource" ValueField="ID" TextField="Area_Name" ShowShadow="true">
                <ItemStyle CssClass="index-search-listbox-item" Height="40px" />
                <NullTextStyle CssClass="null-text" />
                <ClientSideEvents SelectedIndexChanged="onSearchComboBoxIndexChanged" />
                <ButtonStyle>
                    <HoverStyle BackColor="Transparent"></HoverStyle>
                </ButtonStyle>
                <DropDownButton>
                    <Image Url="~/Content/Images/SearchPopOut.png"></Image>
                </DropDownButton>
                <Paddings PaddingLeft="15px"></Paddings>
            </dx:ASPxComboBox>
            <asp:LinqDataSource ID="LocationLinqDataSource" runat="server" ContextTypeName="HotelBooking.HotelBookingDataContextExt" EntityTypeName="" TableName="Metro_Areas" OrderBy="Area_Name" Select="new (ID, Area_Name)">
            </asp:LinqDataSource>
        </div>
        <div class="index-extend">
            <dx:ASPxDockZone ID="OffersZone" ClientInstanceName="OffersZone" runat="server" CssClass="offers" ZoneUID="OffersZone" PanelSpacing="12px"
                Height="146px" Width="100%" Orientation="Horizontal">
            </dx:ASPxDockZone>
            <div class="search">
                <dx:ASPxFormLayout ID="SearchFormExFormLayout" CssClass="form-layout" runat="server" ColCount="3" ShowItemCaptionColon="False" RequiredMarkDisplayMode="None">
                    <Styles>
                        <LayoutItem>
                            <Caption ForeColor="#808080">
                            </Caption>
                        </LayoutItem>
                        <LayoutGroup Cell-Paddings-PaddingLeft="5px" Cell-Paddings-PaddingRight="5px">
                            <Cell>
                                <Paddings PaddingLeft="5px" PaddingRight="5px"></Paddings>
                            </Cell>
                        </LayoutGroup>
                        <LayoutItem>
                            <CaptionCell Paddings-PaddingBottom="0">
                                <Paddings PaddingBottom="0px"></Paddings>
                            </CaptionCell>
                        </LayoutItem>
                    </Styles>
                    <Items>
                        <dx:LayoutItem Caption="CHECK IN">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer runat="server">
                                    <dx:ASPxDateEdit ID="CheckInDateEdit" ClientInstanceName="CheckInDateEdit" runat="server" CssClass="editor" Width="250px" Height="50px" Font-Size="24px">
                                        <ClientSideEvents GotFocus="preventEditorFocus" KeyDown="onInputKeyDown" />
                                        <Paddings PaddingLeft="15px"></Paddings>
                                        <DropDownButton Width="38px">
                                            <Image Url="~/Content/Images/DateEditPopOut.png"></Image>
                                        </DropDownButton>
                                        <ButtonStyle>
                                            <HoverStyle BackColor="Transparent"></HoverStyle>
                                        </ButtonStyle>
                                        <CalendarProperties ShowWeekNumbers="false">
                                            <MonthGridPaddings PaddingLeft="30px" PaddingRight="30px" PaddingTop="15px" PaddingBottom="10px" />
                                            <Style Font-Size="14px"></Style>
                                        </CalendarProperties>
                                        <ValidationSettings ErrorDisplayMode="None" SetFocusOnError="true" ValidateOnLeave="False" ValidationGroup="DateEditors">
                                            <RequiredField IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                        <InvalidStyle>
                                            <Border BorderColor="red"></Border>
                                        </InvalidStyle>
                                    </dx:ASPxDateEdit>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption="CHECK OUT" ColSpan="2">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer runat="server">
                                    <dx:ASPxDateEdit ID="CheckOutDateEdit" ClientInstanceName="CheckOutDateEdit" runat="server"
                                        CssClass="editor" Width="250px" Height="50px" Font-Size="24px">
                                        <ClientSideEvents GotFocus="preventEditorFocus" KeyDown="onInputKeyDown" />
                                        <Paddings PaddingLeft="15px"></Paddings>
                                        <DropDownButton Width="38px">
                                            <Image Url="~/Content/Images/DateEditPopOut.png"></Image>
                                        </DropDownButton>
                                        <ButtonStyle>
                                            <HoverStyle BackColor="Transparent"></HoverStyle>
                                        </ButtonStyle>
                                        <CalendarProperties ShowWeekNumbers="false">
                                            <MonthGridPaddings PaddingLeft="30px" PaddingRight="30px" PaddingTop="15px" PaddingBottom="10px" />
                                            <Style Font-Size="14px"></Style>
                                        </CalendarProperties>
                                        <ValidationSettings ErrorDisplayMode="None" SetFocusOnError="true" ValidateOnLeave="False" ValidationGroup="DateEditors">
                                            <RequiredField IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                        <DateRangeSettings StartDateEditID="CheckInDateEdit" MinDayCount="1"></DateRangeSettings>
                                        <InvalidStyle>
                                            <Border BorderColor="red"></Border>
                                        </InvalidStyle>
                                    </dx:ASPxDateEdit>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption="ROOMS">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer runat="server">
                                    <dx:ASPxSpinEdit ID="RoomsNumberSpinEdit" ClientInstanceName="RoomsNumberSpinEdit" CssClass="editor" runat="server"
                                        Number="1" Width="250px" Height="50px" MinValue="1" MaxValue="5" LargeIncrement="1" Font-Size="24px">
                                        <ClientSideEvents GotFocus="preventEditorFocus" KeyDown="onInputKeyDown" />
                                        <Paddings PaddingLeft="15px"></Paddings>
                                        <LargeIncrementButtonStyle CssClass="large-inc-button"></LargeIncrementButtonStyle>
                                        <SpinButtons ShowLargeIncrementButtons="true" ShowIncrementButtons="false">
                                            <LargeIncrementImage Url="~/Content/Images/SpinEditPlus.png"></LargeIncrementImage>
                                            <LargeDecrementImage Url="~/Content/Images/SpinEditMinus.png"></LargeDecrementImage>
                                        </SpinButtons>
                                        <ButtonStyle>
                                            <HoverStyle BackColor="Transparent"></HoverStyle>
                                        </ButtonStyle>
                                    </dx:ASPxSpinEdit>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption="ADULTS">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer runat="server">
                                    <dx:ASPxSpinEdit ID="AdultsNumberSpinEdit" ClientInstanceName="AdultsNumberSpinEdit" CssClass="editor" runat="server"
                                        Number="1" MinValue="1" MaxValue="5" Width="120px" Height="50px" LargeIncrement="1" Font-Size="24px">
                                        <ClientSideEvents GotFocus="preventEditorFocus" KeyDown="onInputKeyDown" />
                                        <Paddings PaddingLeft="15px"></Paddings>
                                        <LargeIncrementButtonStyle CssClass="large-inc-button"></LargeIncrementButtonStyle>
                                        <SpinButtons ShowLargeIncrementButtons="true" ShowIncrementButtons="false">
                                            <LargeIncrementImage Url="~/Content/Images/SpinEditPlus.png"></LargeIncrementImage>
                                            <LargeDecrementImage Url="~/Content/Images/SpinEditMinus.png"></LargeDecrementImage>
                                        </SpinButtons>
                                        <ButtonStyle>
                                            <HoverStyle BackColor="Transparent"></HoverStyle>
                                        </ButtonStyle>
                                    </dx:ASPxSpinEdit>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption="CHILDREN">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer runat="server">
                                    <dx:ASPxSpinEdit ID="ChildrenNumberSpinEdit" ClientInstanceName="ChildrenNumberSpinEdit" CssClass="editor" runat="server"
                                        Number="0" Width="120px" Height="50px" LargeIncrement="1" Font-Size="24px" MinValue="0" MaxValue="5">
                                        <ClientSideEvents GotFocus="preventEditorFocus" KeyDown="onInputKeyDown" />
                                        <Paddings PaddingLeft="15px"></Paddings>
                                        <LargeIncrementButtonStyle CssClass="large-inc-button"></LargeIncrementButtonStyle>
                                        <SpinButtons ShowLargeIncrementButtons="true" ShowIncrementButtons="false">
                                            <LargeIncrementImage Url="~/Content/Images/SpinEditPlus.png"></LargeIncrementImage>
                                            <LargeDecrementImage Url="~/Content/Images/SpinEditMinus.png"></LargeDecrementImage>
                                        </SpinButtons>
                                        <ButtonStyle>
                                            <HoverStyle BackColor="Transparent"></HoverStyle>
                                        </ButtonStyle>
                                    </dx:ASPxSpinEdit>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption=" " ColSpan="3">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer runat="server">
                                    <dx:ASPxButton ID="SearchButton" ClientInstanceName="SearchButton" AutoPostBack="false" runat="server" Text="Search"
                                        Width="100%" Height="70px" CssClass="button button-large">
                                        <ClientSideEvents Click="onSearchButtonClick" />
                                    </dx:ASPxButton>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                    </Items>
                    <SettingsItemCaptions Location="Top" />
                </dx:ASPxFormLayout>
            </div>
        </div>
    </div>
</div>
<dx:ASPxDockPanel ID="OfferDockPanel2" ClientInstanceName="OfferDockPanel2" runat="server" ShowHeader="false" OwnerZoneUID="OffersZone" Width="248px"
    Cursor="pointer" BackColor="#bebf4e" CssClass="index-offer" AllowDragging="true" DragElement="Window" AllowedDockState="DockedOnly">
    <Border BorderColor="White" BorderWidth="9px" />
    <ContentCollection>
        <dx:PopupControlContentControl>
            <div style="text-align: right">
                <dx:ASPxImage runat="server" ID="Offer2CloseButton" ImageUrl="~/Content/Images/SpecOfferClose.png">
                    <ClientSideEvents Click="function() {
                        onIndexOfferCloseClick(2);
                        }" />
                </dx:ASPxImage>
            </div>
            <div style="text-align: center">
                <dx:ASPxImage runat="server" ID="Offer2Images" ImageUrl="~/Content/Images/SpecOffer2.png">
                    <ClientSideEvents Click="onIndexOfferClick" />
                </dx:ASPxImage>
            </div>
        </dx:PopupControlContentControl>
    </ContentCollection>
</dx:ASPxDockPanel>
<dx:ASPxDockPanel ID="OfferDockPanel1" ClientInstanceName="OfferDockPanel1" runat="server" ShowHeader="false" OwnerZoneUID="OffersZone" Width="398px"
    BackColor="#76b2c0" Cursor="pointer" CssClass="index-offer" AllowDragging="true" DragElement="Window" AllowedDockState="DockedOnly">
    <Border BorderColor="White" BorderWidth="9px" />
    <Styles>
        <Header BackColor="Transparent"></Header>
        <Content Paddings-Padding="9px"></Content>
    </Styles>
    <ContentCollection>
        <dx:PopupControlContentControl>
            <div style="text-align: right">
                <dx:ASPxImage runat="server" ID="Offer1CloseButton" ImageUrl="~/Content/Images/SpecOfferClose.png">
                    <ClientSideEvents Click="function() {
                        onIndexOfferCloseClick(1);
                        }" />
                </dx:ASPxImage>
            </div>
            <div style="text-align: center">
                <dx:ASPxImage runat="server" ID="Offer1Images" ImageUrl="~/Content/Images/SpecOffer1.png">
                    <ClientSideEvents Click="onIndexOfferClick" />
                </dx:ASPxImage>
            </div>
        </dx:PopupControlContentControl>
    </ContentCollection>
</dx:ASPxDockPanel>
<dx:ASPxPopupControl runat="server" ID="LoginPopup" ClientInstanceName="LoginPopup" CssClass="login-popup popup" PopupAnimationType="Fade"
    PopupHorizontalAlign="Center" PopupVerticalAlign="Middle" Width="538px" Height="568px" PopupAction="None" PopupElementID="BackSlider"
    Modal="true" ShowHeader="false">
    <ModalBackgroundStyle CssClass="modal-bg" />
    <ContentCollection>
        <dx:PopupControlContentControl>
            <dx:ASPxFormLayout ID="ASPxFormLayout2" CssClass="form-layout" runat="server" RequiredMarkDisplayMode="None">
                <Styles>
                    <LayoutItem CssClass="item" />
                </Styles>
                <Items>
                    <dx:LayoutItem>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="LoginEmailTextBox" NullText="Email" runat="server" Height="50px" Width="350px" CssClass="login-editor">
                                    <ClientSideEvents KeyDown="onInputKeyDown" />
                                    <ValidationSettings ValidationGroup="Login" ErrorDisplayMode="None" Display="Dynamic">
                                        <RequiredField IsRequired="true" />
                                    </ValidationSettings>
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="LoginPasswordTextBox" runat="server" Password="true" NullText="Password" Height="50px" Width="350px" CssClass="login-editor">
                                    <ClientSideEvents KeyDown="onInputKeyDown" />
                                    <ValidationSettings ValidationGroup="Login" ErrorDisplayMode="None" Display="Dynamic">
                                        <RequiredField IsRequired="true" />
                                    </ValidationSettings>
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:EmptyLayoutItem>
                    </dx:EmptyLayoutItem>
                    <dx:LayoutItem>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxCaptcha ID="LoginCaptcha" runat="server" CssClass="captcha" Width="100%" OnLoad="LoginCaptcha_Load">
                                    <ValidationSettings ValidationGroup="Login" ErrorDisplayMode="None" Display="Dynamic"></ValidationSettings>
                                    <TextBox Visible="false" />
                                    <RefreshButton Position="Right">
                                        <Image Url="~/Content/Images/captcha-refresh.png"></Image>
                                    </RefreshButton>
                                    <ChallengeImage Width="350"></ChallengeImage>
                                </dx:ASPxCaptcha>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxTextBox ID="LoginCaptchaEditor" runat="server" NullText="Enter the verification code above to proceed…"
                                    Height="50px" Width="350px" CssClass="login-editor">
                                    <ClientSideEvents KeyDown="onInputKeyDown" />
                                    <ValidationSettings ValidationGroup="Login" ErrorDisplayMode="None" Display="Dynamic">
                                        <RequiredField IsRequired="true" />
                                    </ValidationSettings>
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxButton runat="server" ID="LoginButton" Text="Login" CssClass="login-button" AutoPostBack="false"
                                    Height="70px" Width="350px" ValidationGroup="Login">
                                    <ClientSideEvents Click="function() { onLoginButtonClick(1); }" />
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
                <SettingsItems ShowCaption="False" />
            </dx:ASPxFormLayout>
        </dx:PopupControlContentControl>
    </ContentCollection>
</dx:ASPxPopupControl>