<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ItemBulletStyle.aspx.cs"
    Inherits="NavBar_ItemBulletStyle" Title="Untitled Page" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxNavBar EnableTheming="False" ID="ASPxNavBar1" runat="server" EnableViewState="False"
        Width="320px" EnableAnimation="True">
        <Groups>
            <dx:NavBarGroup ItemBulletStyle="UpperAlpha" Text="New features">
                <Items>
                    <dx:NavBarItem Text="Modern design">
                    </dx:NavBarItem>
                    <dx:NavBarItem Text="High technology">
                    </dx:NavBarItem>
                    <dx:NavBarItem Text="Best architecture">
                    </dx:NavBarItem>
                </Items>
            </dx:NavBarGroup>
            <dx:NavBarGroup ItemBulletStyle="UpperRoman" Text="Advantages">
                <Items>
                    <dx:NavBarItem Text="Power performanse optimization">
                    </dx:NavBarItem>
                    <dx:NavBarItem Text="Full compatibility with all modern standarts">
                    </dx:NavBarItem>
                    <dx:NavBarItem Text="Advanced usability">
                    </dx:NavBarItem>
                </Items>
            </dx:NavBarGroup>
            <dx:NavBarGroup ItemBulletStyle="Decimal" Text="Benefits">
                <Items>
                    <dx:NavBarItem Text="Low cost and flexible license management">
                    </dx:NavBarItem>
                    <dx:NavBarItem Text="Simple deployment and maintain">
                    </dx:NavBarItem>
                    <dx:NavBarItem Text="Effective around-the-clock support">
                    </dx:NavBarItem>
                </Items>
            </dx:NavBarGroup>
        </Groups>
        <ItemStyle Height="20px" HorizontalAlign="Left">
            <Paddings PaddingTop="0px" PaddingRight="12px" PaddingBottom="0px" PaddingLeft="0px">
            </Paddings>
            <HoverStyle BackColor="#E0EEFE" ForeColor="#1473D2">
                <Border BorderWidth="0px"></Border>
            </HoverStyle>
            <SelectedStyle BackColor="#51A3FD" ForeColor="White">
                <Border BorderWidth="0px"></Border>
            </SelectedStyle>
        </ItemStyle>
        <GroupHeaderStyleCollapsed HorizontalAlign="Left">
            <BorderBottom BorderStyle="Solid"></BorderBottom>
            <BackgroundImage Repeat="RepeatX" ImageUrl="~/NavBar/Images/nbHeaderBackCollapsed.gif">
            </BackgroundImage>
        </GroupHeaderStyleCollapsed>
        <GroupHeaderStyle BackColor="#8FC4FE" ForeColor="White" HorizontalAlign="Left">
            <Paddings PaddingTop="4px" PaddingRight="9px" PaddingBottom="5px" PaddingLeft="12px">
            </Paddings>
            <BorderBottom BorderStyle="None"></BorderBottom>
            <BackgroundImage Repeat="RepeatX" ImageUrl="~/NavBar/Images/nbHeaderBack.gif"></BackgroundImage>
            <Border BorderColor="#69AFFD"></Border>
        </GroupHeaderStyle>
        <BackgroundImage Repeat="RepeatX" ImageUrl="~/NavBar/Images/nbBack.gif"></BackgroundImage>
        <ExpandImage Url="~/NavBar/Images/nbExpand.gif" Height="13px" Width="13px">
        </ExpandImage>
        <CollapseImage Url="~/NavBar/Images/nbCollapse.gif" Height="13px" Width="13px">
        </CollapseImage>
        <GroupContentStyle BackColor="White" ForeColor="#1473D2" HorizontalAlign="Left">
            <Paddings PaddingTop="13px" Padding="1px" PaddingBottom="20px" PaddingLeft="15px"></Paddings>
            <Border BorderColor="#69AFFD"></Border>
        </GroupContentStyle>
    </dx:ASPxNavBar>
</asp:Content>
