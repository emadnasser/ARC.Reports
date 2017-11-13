<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Customers.aspx.vb" Inherits="Customers" %>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <dx:Customers_Master ID="Customers_Master" runat="server" OnLoad="Customers_Master_Load" />
    <dx:ASPxCallbackPanel ID="DetailsCallbackPanel" ClientInstanceName="detailsCallbackPanel" runat="server" CssClass="customersCallbackPanel" Width="100%"
        OnCallback="DetailsCallbackPanel_Callback" Collapsible="true">
        <SettingsAdaptivity CollapseAtWindowInnerHeight="610" />
        <SettingsCollapsing ExpandEffect="PopupToTop" ExpandButton-Position="Far" AnimationType="Slide" />
        <Styles>
            <ExpandBar Width="100%"></ExpandBar>
            <ExpandedPanel CssClass="expanded"></ExpandedPanel>
        </Styles>
        <PanelCollection>
            <dx:PanelContent>
                <table runat="server" id="ImageSliderMenuContainer" enableviewstate="false" class="imageSliderMenuContainer">
                    <tr>
                        <td>
                            <span runat="server" id="CustomerNameText"></span>
                        </td>
                        <td>
                            <dx:ASPxMenu ID="SliderMenu" runat="server" CssClass="customersMenu" ShowPopOutImages="True">
                                <Items>
                                    <dx:MenuItem Name="Root">
                                        <Items>
                                            <dx:MenuItem Text="Stores" Name="Stores"></dx:MenuItem>
                                            <dx:MenuItem Text="Contacts" Name="Contacts"></dx:MenuItem>
                                        </Items>
                                    </dx:MenuItem>
                                </Items>
                                <ClientSideEvents ItemClick="DevAV.Page.SliderMenu_ItemClick" />
                                <HorizontalPopOutImage Url="Content/Images/Customers/PopOutIcon.png"></HorizontalPopOutImage>
                                <SubMenuStyle CssClass="customersPopupMenu" />
                            </dx:ASPxMenu>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
    <dx:RevenueAnalysisPopup ID="RevenueAnalysisPopup" runat="server" />
    <div id="EditFormsContainer">
        <dx:CustomerEmployeeEditForm ID="CustomerEmployeeEditForm" runat="server" />
    </div>
</asp:Content>