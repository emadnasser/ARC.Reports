<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ItemLinkMode.aspx.cs"
    Inherits="NavBar_ItemLinkMode" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; width: 50%">
        <dx:ASPxNavBar Width="240px" Height="283px" ID="ASPxNavBar1" runat="server" AllowSelectItem="True"
            EnableAnimation="True">
            <Groups>
                <dx:NavBarGroup Name="london" Text="Jack London (1876-1916)">
                    <Items>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="wild" Text="The Call of the Wild (1903)">
                        </dx:NavBarItem>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="adam" Text="Before Adam (1907)">
                        </dx:NavBarItem>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="daylight" Text="Burning Daylight (1910)">
                        </dx:NavBarItem>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="abysmal" Text="The Abysmal Brute (1911)">
                        </dx:NavBarItem>
                    </Items>
                </dx:NavBarGroup>
                <dx:NavBarGroup Name="twain" Text="Mark Twain (1835-1910)">
                    <Items>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="screamers" Text="Screamers (1871)">
                        </dx:NavBarItem>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="openers" Text="Eye Openers (1871)">
                        </dx:NavBarItem>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="sellers" Text="Colonel Sellers (1874)">
                        </dx:NavBarItem>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="tales" Text="Merry Tales (1892)">
                        </dx:NavBarItem>
                    </Items>
                </dx:NavBarGroup>
            </Groups>
            <LinkStyle>
                <Font Underline="False"></Font>
            </LinkStyle>
        </dx:ASPxNavBar>
        <div style="margin-top: 32px;">
            <b>AllowSelectItem</b>="<b>True</b>"<br />
            <b>ItemLinkMode</b>="<b>ContentBounds</b>"<br />
            <br />
            <p>
                Specific service scripts are used to apply the hovered and selected styles to menu
                items and generate the <b>ItemClick</b> events.
            </p>
        </div>
    </div>
    <div style="float: right; width: 48%">
        <dx:ASPxNavBar Width="240px" ID="ASPxNavBar2" runat="server" AllowExpanding="False"
            EnableHotTrack="False" ShowExpandButtons="False" ItemLinkMode="TextOnly">
            <Groups>
                <dx:NavBarGroup Name="tolkien" Text="John Tolkien (1892-1973)">
                    <Items>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="leaf" Text="Tree and Leaf (1964)">
                        </dx:NavBarItem>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="song" Text="Bilbo's Last Song (1974)">
                        </dx:NavBarItem>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="bliss" Text="Mr Bliss (1982)">
                        </dx:NavBarItem>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="finn" Text="Finn and Hengest (1983)">
                        </dx:NavBarItem>
                    </Items>
                </dx:NavBarGroup>
                <dx:NavBarGroup Name="dumas" Text="Alex. Dumas (1802-1870)">
                    <Items>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="napoleon" Text="Napoleon Bonaparte (1831)">
                        </dx:NavBarItem>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="margot" Text="La Reine Margot (1845)">
                        </dx:NavBarItem>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="balsamo" Text="Joseph Balsamo (1846)">
                        </dx:NavBarItem>
                        <dx:NavBarItem NavigateUrl="javascript:void(0)" Name="reine" Text="Le Collier De La Reine (1849)">
                        </dx:NavBarItem>
                    </Items>
                </dx:NavBarGroup>
            </Groups>
            <LinkStyle>
                <HoverFont Underline="True" />
                <Font Underline="False"></Font>
            </LinkStyle>
        </dx:ASPxNavBar>
        <div style="margin-top: 32px;">
            <b>ItemLinkMode</b>="<b>TextOnly</b>"<br />
            <b>ShowExpandButtons</b>="<b>False</b>"<br />
            <b>AllowExpanding</b>="<b>False</b>"<br />
            <br />
            <p>
                The hovered and selected styles are applied without using scripts. The style settings
                available via the <b>LinkStyle</b> property are used to define the appearance of
                links.
            </p>
        </div>
    </div>
</asp:Content>
