<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ScrollingPage.aspx.cs" Inherits="Menu_ScrollingPage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" href="~/Content/ComponentList/Styles.css" rel="Stylesheet" />
    <style type="text/css">
        body {
            margin: 0;
            padding: 8px;
        }
        .FrameInfo {
            font: 8pt Tahoma;
            line-height: 150%;
            color: Gray;
            text-align: center;
            margin-top: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxMenu ID="menu" runat="server" DataSourceID="menuDataSource" Orientation="Horizontal"
            AllowSelectItem="True" EnableViewState="False" ShowPopOutImages="True" OnItemDataBound="menu_ItemDataBound">
        </dx:ASPxMenu>
        <asp:XmlDataSource ID="menuDataSource" runat="server" DataFile="~/App_Data/Components.xml"
            XPath="/Groups/Group[@Text!='Reporting']" />
        <div class="FrameInfo">
            This element represents a new document. If a menu doesn't fit into the visible area<br />
            of this element, the submenu displays scroll buttons.
        </div>
    </form>
</body>
</html>
