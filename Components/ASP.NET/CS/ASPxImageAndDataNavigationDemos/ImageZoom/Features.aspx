<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.cs" Inherits="ImageZoom_Features" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <link href="css/Styles.css" rel="Stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div class="controlContainer">
        <dx:ASPxImageZoom ID="zoom" runat="server" ImageUrl="~/Content/Images/ZoomImages/headphones_124696717_small.jpg" 
            LargeImageUrl="~/Content/Images/ZoomImages/headphones_124696717.jpg"
            ExpandWindowText="Expand window text" ZoomWindowText="Zoom window text">
        </dx:ASPxImageZoom>
    </div>
    <div class="formLayoutWrapper">
        <dx:ASPxFormLayout ID="formLayout" runat="server" ColCount="2">
            <Items>
                <dx:LayoutGroup GroupBoxDecoration="None">
                    <Items>
                        <dx:LayoutItem Caption="ShowHint">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer>
                                    <dx:ASPxCheckBox ID="chShowHint" runat="server" Checked="true" AutoPostBack="true"></dx:ASPxCheckBox>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption="EnableExpandMode">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer>
                                    <dx:ASPxCheckBox ID="chEnableExpandMode" runat="server" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption="ZoomWindowPosition">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer>
                                    <dx:ASPxComboBox ID="ddlZoomWindowPosition" runat="server" AutoPostBack="True" Width="134px"
                                        ValueType="System.Int32" SelectedIndex="0">
                                        <Items>
                                            <dx:ListEditItem Value="0" Text="Right" />
                                            <dx:ListEditItem Value="1" Text="Bottom" />
                                            <dx:ListEditItem Value="2" Text="Left" />
                                            <dx:ListEditItem Value="3" Text="Top" />
                                            <dx:ListEditItem Value="4" Text="Inside" />
                                        </Items>
                                    </dx:ASPxComboBox>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption="MouseBoxOpacityMode">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer>
                                    <dx:ASPxComboBox ID="ddlMouseBoxOpacityMode" runat="server" AutoPostBack="True" Width="134px"
                                        ValueType="System.Int32" SelectedIndex="0">
                                        <Items>
                                            <dx:ListEditItem Value="0" Text="Inside" />
                                            <dx:ListEditItem Value="1" Text="Outside" />
                                        </Items>
                                    </dx:ASPxComboBox>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption="LargeImageLoadMode">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer>
                                    <dx:ASPxComboBox ID="ddlLargeImageLoadMode" runat="server" AutoPostBack="True" Width="134px"
                                        ValueType="System.Int32" SelectedIndex="0">
                                        <Items>
                                            <dx:ListEditItem Value="0" Text="Direct" />
                                            <dx:ListEditItem Value="1" Text="OnPageLoad" />
                                            <dx:ListEditItem Value="2" Text="OnFirstShow" />
                                        </Items>
                                    </dx:ASPxComboBox>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                    </Items>
                </dx:LayoutGroup>
            </Items>
        </dx:ASPxFormLayout>
    </div>
</asp:Content>
