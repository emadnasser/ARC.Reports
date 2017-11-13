<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PopupMenu.aspx.cs"
    Inherits="PopupMenu" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function InitPopupMenuHandler(s, e) {
            var gridCell = document.getElementById('gridCell');
            ASPxClientUtils.AttachEventToElement(gridCell, 'contextmenu', OnGridContextMenu);
            var imgButton = document.getElementById('ImgButton1');
            ASPxClientUtils.AttachEventToElement(imgButton, 'contextmenu', OnPreventContextMenu);
        }
        function OnGridContextMenu(evt) {
            ASPxPopupMenuClientControl.ShowAtPos(evt.clientX + ASPxClientUtils.GetDocumentScrollLeft(), evt.clientY + ASPxClientUtils.GetDocumentScrollTop());
            return OnPreventContextMenu(evt);
        }
        function OnPreventContextMenu(evt) {
            return ASPxClientUtils.PreventEventAndBubble(evt);
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; width: 68%">
        <table style="width:100%" id="ImageTable">
            <tr>
                <td style="text-align:right; padding-bottom: 1px;">
                    <img alt="" title="" style="border: 0px; margin-bottom: 2px; width:77px; height:19px; cursor: pointer"
                        src="Images/ArrangeBy.gif" id="ImgButton1" />
                </td>
            </tr>
            <tr>
                <td id="gridCell">
                    <dx:ASPxGridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="CountriesDataSource"
                        KeyFieldName="ID" Width="100%" OnBeforeGetCallbackResult="GridView1_PreRender"
                        OnPreRender="GridView1_PreRender">
                        <Columns>
                            <dx:GridViewDataColumn FieldName="ID" Caption="ID" ReadOnly="True" />
                            <dx:GridViewDataColumn FieldName="Name" Caption="Country Name" />
                            <dx:GridViewDataColumn FieldName="Capital" Caption="Capital" Visible="False" />
                            <dx:GridViewDataColumn FieldName="Continent" Caption="Continent" Visible="False" />
                            <dx:GridViewDataColumn FieldName="Area" Caption="Area" />
                            <dx:GridViewDataColumn FieldName="Population" Caption="Population" />
                        </Columns>
                    </dx:ASPxGridView>
                </td>
            </tr>
        </table>
    </div>
    <div style="float: right; width: 30%">
        <table class="OptionsTable">
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblPopupAction" runat="server" Text="PopupAction:" AssociatedControlID="ddlPopupAction" />
                </td>
                <td>
                    <dx:ASPxComboBox ID="ddlPopupAction" runat="server" CssClass="DemoEdit" AutoPostBack="True"
                        OnSelectedIndexChanged="ddlPopupAction_SelectedIndexChanged" Width="120px">
                        <Items>
                            <dx:ListEditItem Text="LeftMouseClick" Value="LeftMouseClick" />
                            <dx:ListEditItem Text="RightMouseClick" Value="RightMouseClick" />
                            <dx:ListEditItem Text="MouseOver" Value="MouseOver" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblHorizontalAlign" runat="server" Text="HorizontalAlign:" AssociatedControlID="ddlHorizontalAlign" />
                </td>
                <td style="width: 130px">
                    <dx:ASPxComboBox SelectedIndex="4" ID="ddlHorizontalAlign" runat="server" CssClass="DemoEdit"
                        AutoPostBack="True" OnSelectedIndexChanged="ddlHorizontalAlign_SelectedIndexChanged"
                        Width="120px">
                        <Items>
                            <dx:ListEditItem Text="NotSet" Value="NotSet" />
                            <dx:ListEditItem Text="OutsideLeft" Value="OutsideLeft" />
                            <dx:ListEditItem Text="LeftSides" Value="LeftSides" />
                            <dx:ListEditItem Text="RightSides" Value="RightSides" />
                            <dx:ListEditItem Text="OutsideRight" Value="OutsideRight" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblVerticalAlign" runat="server" Text="VerticalAlign:" AssociatedControlID="ddlVerticalAlign" />
                </td>
                <td style="width: 130px">
                    <dx:ASPxComboBox SelectedIndex="2" ID="ddlVerticalAlign" runat="server" CssClass="DemoEdit"
                        AutoPostBack="True" OnSelectedIndexChanged="ddlVerticalAlign_SelectedIndexChanged"
                        Width="120px">
                        <Items>
                            <dx:ListEditItem Text="NotSet" Value="NotSet" />
                            <dx:ListEditItem Text="Above" Value="Above" />
                            <dx:ListEditItem Text="TopSides" Value="TopSides" />
                            <dx:ListEditItem Text="BottomSides" Value="BottomSides" />
                            <dx:ListEditItem Text="Below" Value="Below" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
        </table>
    </div>
    <ef:EntityDataSource runat="server" ID="CountriesDataSource" ContextTypeName="DataContext" EntitySetName="countries" />
    <dx:ASPxPopupMenu ID="ASPxPopupMenu1" runat="server" ClientInstanceName="ASPxPopupMenuClientControl"
        PopupElementID="ImgButton1" ShowPopOutImages="True" AutoPostBack="True" OnItemClick="ASPxPopupMenu1_ItemClick"
        PopupHorizontalAlign="OutsideRight" PopupVerticalAlign="TopSides" PopupAction="LeftMouseClick">
        <Items>
            <dx:MenuItem GroupName="Sort" Text="Country Name" Name="Name">
            </dx:MenuItem>
            <dx:MenuItem Visible="False" GroupName="Sort" Text="Capital" Name="Capital">
            </dx:MenuItem>
            <dx:MenuItem Visible="False" GroupName="Sort" Text="Continent" Name="Continent">
            </dx:MenuItem>
            <dx:MenuItem GroupName="Sort" Text="Area" Name="Area">
            </dx:MenuItem>
            <dx:MenuItem GroupName="Sort" Text="Population" Name="Population">
            </dx:MenuItem>
        </Items>
        <ClientSideEvents Init="InitPopupMenuHandler" />
        <ItemStyle Width="143px"></ItemStyle>
    </dx:ASPxPopupMenu>
</asp:Content>
