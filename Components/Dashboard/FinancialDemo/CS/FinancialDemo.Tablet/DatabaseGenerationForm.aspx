<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatabaseGenerationForm.aspx.cs" Inherits="FinancialDemo.Web.DatabaseGenerationForm" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <span  id = "Content" runat="server"  >    
        <dx:CreateDatabaseControl runat="server" ID="CreateDatabaseControl"/>        
    </span>
    </form>
</body>
</html>
