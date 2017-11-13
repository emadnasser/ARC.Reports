<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ContentUrl.aspx.cs"
    Inherits="Splitter_ContentUrl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxSplitter ID="ASPxSplitter1" ClientInstanceName="splitter" runat="server"
        Height="400px" Width="100%">
        <Panes>
            <dx:SplitterPane Size="180px" MinSize="180px" ShowCollapseBackwardButton="True">
                <ContentCollection>
                    <dx:SplitterContentControl runat="server">
                        <dx:ASPxNavBar runat="server" AllowSelectItem="True" Target="contentUrlPane" Width="100%"
                            ID="ASPxNavBar1">
                            <Groups>
                                <dx:NavBarGroup Text="Sample Pages">
                                    <Items>
                                        <dx:NavBarItem NavigateUrl="SamplePages/Page1.aspx" Text="Page 1">
                                        </dx:NavBarItem>
                                        <dx:NavBarItem NavigateUrl="SamplePages/Page2.aspx" Selected="True" Text="Page 2">
                                        </dx:NavBarItem>
                                        <dx:NavBarItem NavigateUrl="SamplePages/Page3.aspx" Text="Page 3">
                                        </dx:NavBarItem>
                                    </Items>
                                </dx:NavBarGroup>
                            </Groups>
                            <Paddings Padding="0px"></Paddings>
                        </dx:ASPxNavBar>
                    </dx:SplitterContentControl>
                </ContentCollection>
            </dx:SplitterPane>
            <dx:SplitterPane Name="ContentUrlPane" ScrollBars="Auto" ContentUrlIFrameName="contentUrlPane">
                <ContentCollection>
                    <dx:SplitterContentControl runat="server">
                    </dx:SplitterContentControl>
                </ContentCollection>
            </dx:SplitterPane>
        </Panes>
    </dx:ASPxSplitter>
</asp:Content>
