<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"%>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
    <div style="height: 150px;">
        <dx:ASPxNavBar ID="ASPxNavBar1" runat="server">
            <Groups>
                <dx:NavBarGroup Text="Charts">
                    <Items>
                        <dx:NavBarItem Text="Stacked Bar">
                            <Image Url="~/NavBar/Images/Charts/BarStacked.png" />
                        </dx:NavBarItem>
                        <dx:NavBarItem Text="3D Pie">
                            <Image Url="~/NavBar/Images/Charts/Pie.png" />
                        </dx:NavBarItem>
                        <dx:NavBarItem Text="Overlapped Gantt">
                            <Image Url="~/NavBar/Images/Charts/Gantt.png" />
                        </dx:NavBarItem>
                    </Items>
                </dx:NavBarGroup>
            </Groups>
        </dx:ASPxNavBar>
    </div>
</asp:Content>
