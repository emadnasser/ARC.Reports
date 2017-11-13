<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Templates.aspx.cs"
    Inherits="NavBar_Templates" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
       .panelTitle 
       {
           font-family: Tahoma, Arial; 
           color: #818180; 
           font-size : 12px;	
           font-weight: bold; 
           margin: 0 0 0 8px!important; 
           padding: 0; 
       }
       .groupTitle
       {
           margin: 2px 0px; 
       }
       .groupTitle *
       {
           color: Black;
           font-weight: bold; 
       }
       .groupTitle a,
       .groupTitle img
       {
           display: block;
       }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table style="width: 920px;">
        <tr>
            <td>
                <dx:ASPxImage ID="Image2" runat="server" ImageUrl="~/NavBar/Images/Lessons/tl.gif" Width="4px" Height="32px" style="display: block" />
            </td>
            <td style="width: 100%; background: url(Images/Lessons/tbg.gif) repeat-x;">
                <p class="panelTitle">
                    ASPxGrid Interactive Lessons</p>
            </td>
            <td>
                <dx:ASPxImage ID="Image3" runat="server" ImageUrl="~/NavBar/Images/Lessons/tr.gif" Width="4px" Height="32px" style="display: block" />
            </td>
        </tr>
        <tr>
            <td style="background: url(Images/Lessons/lbg.gif) repeat-y;">
            </td>
            <td style="width: 100%;">
                <dx:ASPxNavBar SkinID="None" Width="912px" EnableViewState="false" ID="ASPxNavBar1" ShowExpandButtons="false"
                    runat="server" GroupSpacing="1px" AutoCollapse="True" EnableHotTrack="True" Target="_blank"
                    DataSourceID="XmlDataSource1" ExpandButtonPosition="Right" OnGroupDataBound="ASPxNavBar1_GroupDataBound">
                    <Border BorderColor="#BEBEBE" BorderStyle="Solid" BorderWidth="1px" />
                    <Paddings Padding="1px" />
                    <GroupContentStyle BackColor="#EBF4FC" ForeColor="#303030">
                        <Border BorderStyle="None" />
                        <BorderTop BorderColor="White" BorderStyle="Solid" BorderWidth="1px" />
                        <Paddings Padding="11px" />
                    </GroupContentStyle>
                    <GroupHeaderStyleCollapsed BackColor="#F1F1F1" ForeColor="Gray">
                        <HoverStyle BackColor="#DAEBFD">
                        </HoverStyle>
                    </GroupHeaderStyleCollapsed>
                    <GroupHeaderStyle BackColor="#C7DEF7" ImageSpacing="1px">
                        <Paddings Padding="4px" PaddingLeft="11px" />
                        <Border BorderStyle="None" />
                    </GroupHeaderStyle>
                    <ItemStyle VerticalAlign="Top" ForeColor="Black">
                        <Paddings Padding="13px" PaddingBottom="39px" />
                    </ItemStyle>
                    <GroupHeaderTemplate>
                        <table class="groupTitle">
                            <tr>
                                <td style="width: 100%">
                                    <dx:ASPxLabel ID="Label1" runat="server" Text='<%# Eval("Text") %>' />
                                </td>
                                <td>
                                    <dx:ASPxHyperLink ID="HyperLink2" runat="server" OnPreRender="Watch_OnPreRender"
                                        Target="_blank" NavigateUrl='<%# Eval("NavigateUrl") %>' ImageWidth="71px" ImageHeight="21px"
                                        ImageUrl="~/NavBar/Images/Lessons/bWatchCollapsed.gif" />
                                </td>
                                <td style="padding-left: 4px;">
                                    <dx:ASPxImage ID="ASPxImage1" runat="server" ImageUrl="~/NavBar/Images/Lessons/bCollapse.gif" Width="21px" Height="21px" />
                                </td>
                            </tr>
                        </table>
                    </GroupHeaderTemplate>
                    <GroupHeaderTemplateCollapsed>
                        <table class="groupTitle">
                            <tr>
                                <td style="width: 100%">
                                    <dx:ASPxLabel ID="Label1" ForeColor="#808080" runat="server" Text='<%# Eval("Text") %>' />
                                </td>
                                <td>
                                    <dx:ASPxHyperLink ID="HyperLink1" OnPreRender="Watch_OnPreRender" runat="server"
                                        Target="_blank" NavigateUrl='<%# Eval("NavigateUrl") %>' ImageWidth="71px" ImageHeight="21px"
                                        ImageUrl="~/NavBar/Images/Lessons/bWatchCollapsed.gif" />
                                </td>
                                <td style="padding-left: 4px;">
                                    <dx:ASPxImage ID="ASPxImage1" runat="server" ImageUrl="~/NavBar/Images/Lessons/bExpand.gif" AlternateText="Show details" Width="21px" Height="21px" />
                                </td>
                            </tr>
                        </table>
                    </GroupHeaderTemplateCollapsed>
                </dx:ASPxNavBar>
                <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/NavBar/Lessons.xml"
                    XPath="//LessonGroup"></asp:XmlDataSource>
            </td>
            <td style="background: url(Images/Lessons/rbg.gif) repeat-y;">
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxImage ID="Image4" runat="server" ImageUrl="~/NavBar/Images/Lessons/bl.gif" Width="4px" Height="15px" style="display: block" />
            </td>
            <td style="width: 100%; background: url(Images/Lessons/bbg.gif) repeat-x;">
            </td>
            <td>
                <dx:ASPxImage ID="Image5" runat="server" ImageUrl="~/NavBar/Images/Lessons/br.gif" Width="4px" Height="15px" style="display: block" />
            </td>
        </tr>
    </table>
</asp:Content>
