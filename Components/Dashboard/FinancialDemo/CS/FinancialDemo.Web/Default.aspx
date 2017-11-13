<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FinancialDemo.Web.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/Demo.css" type="text/css" rel="Stylesheet" />
    <link href="Content/DemoContent.css" type="text/css" rel="Stylesheet" />
    <title>Financial Dashboard - Dashboard Demo | DevExpress</title>
</head>
<body>
    <form runat="server">
        <div>
            <dx:ASPxSplitter ID="ASPxSplitter1" runat="server" FullscreenMode="True" 
                Orientation="Vertical" Height="100%" Width="100%" style="margin-top: 0; background-color:#EFEFEF" 
                AllowResize="False" SeparatorSize="0px" SeparatorVisible="False" 
                ShowSeparatorImage="False">
                <Styles>
                    <Pane Border-BorderWidth="0">
<Border BorderWidth="0px"></Border>
                    </Pane>
                </Styles>
                <Panes>
                    <dx:SplitterPane Name="Content">
                        <ContentCollection>
                            <dx:SplitterContentControl runat="server" >
                                <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" RegisterJQuery="True"
                                    onconfiguredataconnection="ASPxDashboardViewer1_ConfigureDataConnection" 
                                    ondashboardloading="ASPxDashboardViewer1_DashboardLoading" 
                                    AllowExportDashboardItems="True" RedrawOnResize="True"
                                    ClientInstanceName="dash" Width="100%" Height="100%">
                                </dx:ASPxDashboardViewer>    
                            </dx:SplitterContentControl>
                        </ContentCollection>
                    </dx:SplitterPane>
                    <dx:SplitterPane Name="Footer" Size="80px">
                        <ContentCollection>
                            <dx:SplitterContentControl ID="SplitterContentControl1" runat="server"> 
                                <div style="float:left; margin-top:8px; margin-left:15px">
                                    <a href="http://devexpress.com"><img src="Content/Logo.png" alt="DevExpress"/></a>
                                </div>
                                <div class="Footer" style="float:right; text-align:right">
                                    The DevExpress Dashboard ships as part of the Universal Subscription.<br />
                                    Got a question about this demo or need more information? We are here to help.<br />
                                    <a href="mailto:info@devexpress.com">info@devexpress.com</a>
                                </div>
                            </dx:SplitterContentControl>
                        </ContentCollection> 
                    </dx:SplitterPane>
                </Panes>
            </dx:ASPxSplitter>
        </div>
    </form>
</body>
</html>
