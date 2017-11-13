<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FullscreenModePage.aspx.cs"
    Inherits="Splitter_SamplePages_FullscreenModePage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fullscreen Mode - ASP.NET Splitter Component</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxSplitter ID="ASPxSplitter1" runat="server" FullscreenMode="True" Width="100%" Height="100%" Orientation="Vertical">
                <panes>
                    <dx:SplitterPane Size="80px" PaneStyle-BackColor="#DBF4DE">
                        <ContentCollection>
                            <dx:SplitterContentControl runat="server">
                                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%; height: 100%;">
                                    <tr>
                                        <td align="center">
                                            <dx:ASPxLabel runat="server" Text="This pane can contain a page's header and a site menu."
                                                Font-Size="14px" ID="ASPxLabel1" />
                                        </td>
                                    </tr>
                                </table>
                            </dx:SplitterContentControl>
                        </ContentCollection>
                    </dx:SplitterPane>
                    <dx:SplitterPane>
                        <Panes>
                            <dx:SplitterPane Size="300px" PaneStyle-BackColor="#F3EAFB">
                                <ContentCollection>
                                    <dx:SplitterContentControl runat="server">
                                        <table cellpadding="0" cellspacing="0" border="0" style="width: 100%; height: 100%;">
                                            <tr>
                                                <td align="center">
                                                    <dx:ASPxLabel runat="server" Text="This pane can be used for navigation purposes."
                                                        Font-Size="14px" ID="ASPxLabel2" />
                                                </td>
                                            </tr>
                                        </table>
                                    </dx:SplitterContentControl>
                                </ContentCollection>
                            </dx:SplitterPane>
                            <dx:SplitterPane>
                                <Panes>
                                    <dx:SplitterPane PaneStyle-BackColor="#F4F0DB">
                                        <ContentCollection>
                                            <dx:SplitterContentControl runat="server">
                                                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%; height: 100%;">
                                                    <tr>
                                                        <td align="center">
                                                            <dx:ASPxLabel runat="server" Text="This is the main content pane." Font-Size="14px"
                                                                ID="ASPxLabel3" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </dx:SplitterContentControl>
                                        </ContentCollection>
                                    </dx:SplitterPane>
                                    <dx:SplitterPane Size="60px" PaneStyle-BackColor="#DBEBF4">
                                        <ContentCollection>
                                            <dx:SplitterContentControl runat="server">
                                                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%; height: 100%;">
                                                    <tr>
                                                        <td align="center">
                                                            <dx:ASPxLabel runat="server" Text="This is the footer pane." Font-Size="14px" ID="ASPxLabel4" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </dx:SplitterContentControl>
                                        </ContentCollection>
                                    </dx:SplitterPane>
                                </Panes>
                            </dx:SplitterPane>
                        </Panes>
                    </dx:SplitterPane>
                </panes>
            </dx:ASPxSplitter>
        </div>
    </form>
</body>
</html>
