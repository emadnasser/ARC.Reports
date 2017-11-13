<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSideAPI.aspx.cs"
    Inherits="Menu_ClientSideAPI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <%--start highlighted block--%>
    <script type="text/javascript">
    // <![CDATA[
        function GetMenuItem() {
            return menu.GetItemByName(cbItems.GetValue());
        }
        function ShowProperties() {
            var item = GetMenuItem();
            chbVisible.SetChecked(item.GetVisible());
            chbEnabled.SetChecked(item.GetEnabled());
            chbSelect.SetChecked(menu.GetSelectedItem() == item);
        }
        function cbChangeSelection() {
            ShowProperties();
        }
        function ToggleEnabled() {
            GetMenuItem().SetEnabled(chbEnabled.GetChecked());
            ShowProperties();
        }
        function ToggleVisible() {
            GetMenuItem().SetVisible(chbVisible.GetChecked());
            ShowProperties();
        }
        function ToggleSelect() {
            var item = chbSelect.GetChecked() ? GetMenuItem() : null;
            menu.SetSelectedItem(item);
        }
        function InitMenu() {
            menu.SetSelectedItem(GetMenuItem());
            ShowProperties();
        }
        function MenuItemClick(s, e) {
            cbItems.SetValue(e.item.name);
            ShowProperties();
        }
    // ]]> 
    </script>
    <%--end highlighted block--%>
    <div style="float: left; width: 180px; padding-top: 13px">
        <dx:ASPxMenu ID="menu" ClientInstanceName="menu" runat="server" AllowSelectItem="True"
            Orientation="Vertical" EnableViewState="False" Width="100%">
            <ItemStyle HorizontalAlign="Left" />
            <ClientSideEvents Init="InitMenu" ItemClick="MenuItemClick"></ClientSideEvents>
            <Items>
                <dx:MenuItem Name="visa" Text="Visa" Image-Url="~/Menu/Images/visa.png" />
                <dx:MenuItem Name="master" Text="MasterCard" Image-Url="~/Menu/Images/master.png" />
                <dx:MenuItem Name="union" Text="Union" Image-Url="~/Menu/Images/union.png" />
                <dx:MenuItem Name="amex" Text="American Express" Image-Url="~/Menu/Images/amex.png" />
                <dx:MenuItem Name="maestro" Text="Maestro" Image-Url="~/Menu/Images/maestro.png" />
            </Items>
        </dx:ASPxMenu>
    </div>
    <div style="float: left; padding: 0px 20px 40px 60px;">
        <dx:ASPxFormLayout ID="Options" runat="server">
            <Items>
                <dx:LayoutItem ShowCaption="False">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxCheckBox ID="chbClientVisible" runat="server" Checked="true" Text="Client Visible"
                                ClientInstanceName="chbClientVisible">
                                <ClientSideEvents CheckedChanged="function(s, e) { menu.SetVisible(chbClientVisible.GetChecked()) }" />
                            </dx:ASPxCheckBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:EmptyLayoutItem />
                <dx:LayoutItem Caption="Choose item:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxComboBox Caption="" runat="server" ID="cbItems" ClientInstanceName="cbItems">
                                <ClientSideEvents SelectedIndexChanged="cbChangeSelection" />
                            </dx:ASPxComboBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxCheckBox runat="server" ID="chbEnabled" Checked="true" Text="Enabled" ClientInstanceName="chbEnabled">
                                <ClientSideEvents CheckedChanged="ToggleEnabled"></ClientSideEvents>
                            </dx:ASPxCheckBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxCheckBox runat="server" ID="chbVisible" Checked="true" Text="Visible" ClientInstanceName="chbVisible">
                                <ClientSideEvents CheckedChanged="ToggleVisible"></ClientSideEvents>
                            </dx:ASPxCheckBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer>
                            <dx:ASPxCheckBox runat="server" ID="chbSelect" Checked="true" Text="Select" ClientInstanceName="chbSelect">
                                <ClientSideEvents CheckedChanged="ToggleSelect"></ClientSideEvents>
                            </dx:ASPxCheckBox>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
            </Items>
        </dx:ASPxFormLayout>
    </div>
</asp:Content>
