<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
    <dx:ASPxTreeView ID="ASPxTreeView1" runat="server">
        <Nodes>
            <dx:TreeViewNode Text="Music" Expanded="True">
                <Image Url="~/TreeView/Images/MediaContent/music.png"/>
                <Nodes>
                    <dx:TreeViewNode Text="Andy McKee">
                        <Nodes>
                            <dx:TreeViewNode Text="Rylynn"/>
                            <dx:TreeViewNode Text="Drifting"/>
                        </Nodes>
                    </dx:TreeViewNode>
                    <dx:TreeViewNode Text="Antoine Dufour">
                        <Nodes>
                            <dx:TreeViewNode Text="Reality"/>
                        </Nodes>
                    </dx:TreeViewNode>
                </Nodes>
            </dx:TreeViewNode>
            <dx:TreeViewNode Text="Video">
                <Image Url="~/TreeView/Images/MediaContent/video.png"/>
                <Nodes>
                    <dx:TreeViewNode Text="Inception - Official trailer"/>
                    <dx:TreeViewNode Text="MythBusters Top 25 Moments"/>
                    <dx:TreeViewNode Text="Richard Feynman - Ode on a Flower"/>
                </Nodes>
            </dx:TreeViewNode>
            <dx:TreeViewNode Text="Pictures" Expanded="True">
                <Image Url="~/TreeView/Images/MediaContent/pictures.png"/>
                <Nodes>
                    <dx:TreeViewNode Text="Desert"/>
                    <dx:TreeViewNode Text="Me & Kate"/>
                    <dx:TreeViewNode Text="Party 03.08"/>
                </Nodes>
            </dx:TreeViewNode>
        </Nodes>
    </dx:ASPxTreeView>
</asp:Content>
