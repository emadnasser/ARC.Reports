<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QueryBuilder.aspx.cs" Inherits="DataBinding_QueryBuilder" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
</head>
<body>
    <link href="<%= Page.ResolveClientUrl("~/Content/QueryBuilder.css") %>" rel="stylesheet" />
    <script src="<%= Page.ResolveClientUrl("~/Scripts/QueryBuilder.js") %>"></script>
    <form id="form1" runat="server">
        <dx:ASPxQueryBuilder runat="server" ID="queryBuilder"
            ClientInstanceName="queryBuilder" CssClass="QueryBuilder"
            OnSaveQuery="queryBuilder_SaveQuery"
            ClientSideEvents-Init="queryBuilder_Init"
            EnableViewState="False" Height="" />
    </form>
</body>
</html>
