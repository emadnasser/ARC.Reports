<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MultiRow.aspx.cs"
    Inherits="TabControl_MultiRow" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <link type="text/css" href="../Content/ComponentList/Styles.css" rel="Stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" Width="705px" Height="350px"
        TabAlign="Justify" ActiveTabIndex="5">
        <ContentStyle>
            <Paddings PaddingLeft="40px"/>
        </ContentStyle>
        <TabPages>
            <dx:TabPage Text="Scheduling">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ComponentView runat="server" ComponentGroupName="Scheduling" />
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Reporting">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl1" runat="server">
                        <dx:ComponentView ID="ComponentsView1" runat="server" ComponentGroupName="Reporting" />
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Navigation &amp; Layout">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl2" runat="server">
                        <dx:ComponentView ID="ComponentsView2" runat="server" ComponentGroupName="Navigation &amp; Layout" />
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Data" NewLine="True">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl3" runat="server">
                        <dx:ComponentView ID="ComponentsView3" runat="server" ComponentGroupName="Data" />
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Components">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl4" runat="server">
                        <dx:ComponentView ID="ComponentsView4" runat="server" ComponentGroupName="Components" />
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Common Controls">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl5" runat="server">
                        <dx:ComponentView ID="ComponentsView5" runat="server" ComponentGroupName="Common Controls" />
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
        </TabPages>
    </dx:ASPxPageControl>
</asp:Content>
