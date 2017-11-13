<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Designer.aspx.cs" Inherits="Designer" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
    <link href="Content/Designer.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxReportDesigner runat="server" ID="reportDesigner"
            ClientInstanceName="reportDesigner" CssClass="fullscreen"
            EnableViewState="False" Height="" />
            <asp:hiddenField runat="server" id="redirectValue" />
    </form>
    <script src="Scripts/Designer.js"></script>
</body>
</html>
