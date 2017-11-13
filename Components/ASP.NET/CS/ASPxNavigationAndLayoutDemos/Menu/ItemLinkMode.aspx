<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ItemLinkMode.aspx.cs"
    Inherits="Menu_ItemLinkMode" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
       .linkMenu 
       {
           background: none!important;
           border: 0!important; 
           color: #162436!important;
           padding: 0!important;
           text-decoration: none!important;
       }
       .linkMenu a:hover,
       .linkMenu a:hover *
       {
           text-decoration: underline!important;
       }
       .linkMenuItem,
       .linkMenuItem > div
       {
           padding: 0!important;
           font: 11px Tahoma!important;
       }
       .linkMenuSeparator
       {
           padding: 0 14px!important;
       }
       .linkMenuSeparator > *
       {
           background: #5386CB!important;
           margin: 4px 0!important;
           height: 10px!important;
           width: 1px!important;
       }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; clear: both; margin-bottom: 16px; width: 100%">
        <div style="float: left; width: 50%">
            <dx:ASPxMenu ID="ASPxMenu1" runat="server" AllowSelectItem="True" ShowPopOutImages="True">
                <Items>
                    <dx:MenuItem Name="home" Text="Home">
                    </dx:MenuItem>
                    <dx:MenuItem Name="products" Text="Products">
                        <Items>
                            <dx:MenuItem Name="asp" Text="ASP.NET Components">
                            </dx:MenuItem>
                            <dx:MenuItem Name="win" Text=".NET Windows Forms Components">
                            </dx:MenuItem>
                            <dx:MenuItem Name="vcl" Text="VCL Components-Tools">
                            </dx:MenuItem>
                        </Items>
                    </dx:MenuItem>
                    <dx:MenuItem Name="downloads" Text="Downloads">
                    </dx:MenuItem>
                    <dx:MenuItem Name="support" Text="Support">
                    </dx:MenuItem>
                </Items>
            </dx:ASPxMenu>
        </div>
        <div style="float: right; width: 48%">
            <b>ItemLinkMode</b>="<b>ContentBounds</b>"<br /><br />
            <p>
                Specific service scripts are used to apply the hovered and selected styles to menu
                items and generate <b>ItemClick</b> events.</p>
        </div>
    </div>
    <div style="float: left; clear: both; width: 100%">
        <div style="float: left; width: 50%">
            <dx:ASPxMenu ID="ASPxMenu2" SkinID="None" runat="server" AutoSeparators="RootOnly" CssClass="linkMenu"
                ItemLinkMode="TextOnly" SeparatorCssClass="linkMenuSeparator">
                <Items>
                    <dx:MenuItem NavigateUrl="javascript:void(0)" Name="home" Text="Home">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="javascript:void(0)" Name="products" Text="Products">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="javascript:void(0)" Name="downloads" Text="Downloads">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="javascript:void(0)" Name="support" Text="Support">
                    </dx:MenuItem>
                    <dx:MenuItem NavigateUrl="javascript:void(0)" Name="order" Text="Order">
                    </dx:MenuItem>
                </Items>
                <ItemStyle CssClass="linkMenuItem" />
            </dx:ASPxMenu>
        </div>
        <div style="float: right; width: 48%">
            <b>ItemLinkMode</b>="<b>TextOnly</b>"<br /><br />
            <p>
                The hovered and selected styles are applied without using scripts. Style settings
                available via the <b>LinkStyle</b> property are used to define link appearance.</p>
        </div>
    </div>
</asp:Content>
