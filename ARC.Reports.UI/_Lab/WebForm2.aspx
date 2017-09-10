<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ARC.Reports.Pages.WebForm2" %>

<%@ Register Src="~/Controls/MarketValueGraphs_D.ascx" TagPrefix="uc1" TagName="MarketValueGraphs_D" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:MarketValueGraphs_D runat="server" ID="MarketValueGraphs_D" />
        </div>
    </form>
</body>
</html>
