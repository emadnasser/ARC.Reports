<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
    <dx:ASPxTitleIndex ID="ASPxTitleIndex1" runat="server" Height="380px">
        <Paddings Padding="0" />
        <Columns>
            <dx:TitleIndexColumn />
            <dx:TitleIndexColumn />
        </Columns>
        <Items>
            <dx:TitleIndexItem Text="Aqriculture" NavigateUrl="javascript:void(0);"/>
            <dx:TitleIndexItem Text="Art" NavigateUrl="javascript:void(1);"/>
            <dx:TitleIndexItem Text="Auto" NavigateUrl="javascript:void(2);"/>
            <dx:TitleIndexItem Text="Bags" NavigateUrl="javascript:void(3);"/>
            <dx:TitleIndexItem Text="Business" NavigateUrl="javascript:void(4);"/>
            <dx:TitleIndexItem Text="Canada" NavigateUrl="javascript:void(5);"/>
            <dx:TitleIndexItem Text="Cape Verde" NavigateUrl="javascript:void(6);"/>
            <dx:TitleIndexItem Text="Cayman Islands" NavigateUrl="javascript:void(7);"/>
            <dx:TitleIndexItem Text="Chad" NavigateUrl="javascript:void(8);"/>
            <dx:TitleIndexItem Text="Chile" NavigateUrl="javascript:void(9);"/>
            <dx:TitleIndexItem Text="China" NavigateUrl="javascript:void(10);"/>
        </Items>
    </dx:ASPxTitleIndex>
</asp:Content>
