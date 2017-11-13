<%@ Page Language="C#" MasterPageFile="~/Root.master" AutoEventWireup="true" CodeFile="PivotGrid.aspx.cs" Inherits="PivotGrid" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="HeaderHolder">
    <style type="text/css">
        body
        {
            min-height: 200px !important;
            background-color: #fafafa !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RootPlaceHolder" Runat="Server">
    <div class="pivotGridContainer">
        <dx:ProductsPivotGrid ID="ProductsPivotGrid" runat="server" />
    </div>
</asp:Content>
