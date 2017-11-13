<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Example.aspx.cs"
    Inherits="Headline_Example" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="width:500px;">
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="XmlDataSource1" EnableViewState="False">
            <ItemTemplate>
                <dx:ASPxHeadline TailText="Details" EncodeHtml="False" ID="ASPxHeadline1" EnableViewState="False"
                    runat="server" ContentText='<%# Eval("Text") %>' Date='<%# ConvertToDate(Eval("Date")) %>'
                    NavigateUrl='<%# Eval("NavigateUrl") %>' HeaderText='<%# Eval("Header") %>'>
                </dx:ASPxHeadline>
                <br />
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/WebSiteNewsRSS.xml"
        TransformFile="~/App_Data/HeadlineRSS.xslt" />
</asp:Content>
