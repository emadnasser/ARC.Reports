<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DemoViewer.aspx.cs" Inherits="DemoViewer" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>DevExpress Bootstrap Controls Demo</title>
    <link rel="stylesheet" type="text/css" id="containerLink" href="<%# Page.ResolveClientUrl("~/Content/container.css") %>" />
    <link rel="stylesheet" type="text/css" id="themeContainerLink" href="<%# Page.ResolveClientUrl("~/Content/" + DemoUtils.CurrentTheme + "/container.css") %>" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="demoContainer <%# DemoUtils.CurrentResolution %>">
            <iframe runat="server" id="DemoFrame" class="demoFrame" name="demoFrame" src="<%# DemoUtils.FrameUrl %>"></iframe>
        </div>
    </form>
</body>
</html>
