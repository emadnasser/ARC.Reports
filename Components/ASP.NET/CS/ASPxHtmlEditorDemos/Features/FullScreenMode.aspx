<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FullScreenMode.aspx.cs" Inherits="Features_FullScreenMode" MasterPageFile="~/Site.master" %>
<asp:Content ID="Head" ContentPlaceHolderID="CustomHeadHolder" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table style="width: 100%; text-align: center;">
        <tr>
            <td colspan="2">
                <p style="text-align: center;">Please click one of the following links to open the demonstration page in the corresponding mode:</p>
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <a href="FullScreenModeStandardUI.aspx" target="_blank">
                    <img src="../Content/standardUIDemoLinkImage.png" alt="standard ui" style="width: 400px; border: 1px solid #ccc;" />
                    <br />
                    <span>Full-Screen Mode (Standard UI)</span></a>
            </td>
            <td>
                <a href="FullScreenModeRibbonUI.aspx" target="_blank">
                    <img src="../Content/ribbonUIDemoLinkImage.png" alt="ribbon ui" style="width: 400px; border: 1px solid #ccc;" />
                    <br />
                    <span>Full-Screen Mode (Ribbon UI)</span></a>
            </td>
        </tr>
    </table>
</asp:Content>
