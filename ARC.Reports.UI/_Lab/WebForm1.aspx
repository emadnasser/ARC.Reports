<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ARC.Reports.Pages.WebForm1" %>

<%@ Register Src="~/Controls/MarketShareGraphs_D.ascx" TagPrefix="uc1" TagName="MarketShareGraphs_D" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:MarketShareGraphs_D runat="server" ID="MarketShareGraphs_D" />
        </div>
    </form>
</body>
</html>
