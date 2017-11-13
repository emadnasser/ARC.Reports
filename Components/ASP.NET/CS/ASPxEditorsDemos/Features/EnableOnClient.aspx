<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EnableOnClient.aspx.cs"
    Inherits="Features_EnableOnClient" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function OnTechnologyChanged(control) {
            cbProduct.SetSelectedIndex(0);
            cbVersion.SetSelectedIndex(0);
            CheckControlsEnabled();
            if(control.GetValue()!="")
                cbProduct.PerformCallback(control.GetText());
        }
        function OnProductComboBoxEndCallback(control) {
            control.SetFocus();
        }
        function OnProductChanged(control) {
            cbVersion.SetSelectedIndex(0);
            CheckControlsEnabled();
            if(control.GetValue()!="")
                window.setTimeout(function(){
                    cbVersion.SetFocus();
                }, 100);
        }
        function CheckControlsEnabled() {
            cbProduct.SetEnabled(cbTechnology.GetSelectedIndex()>0);
            cbVersion.SetEnabled(cbProduct.GetSelectedIndex()>0);
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <table class="OptionsTable">
        <tr>
            <td style="width: 100px">
                <dx:ASPxLabel ID="lblTechnology" runat="server" Text="Technology:" AssociatedControlID="cbTechnology" />
            </td>
            <td>
                <dx:ASPxComboBox ID="cbTechnology" ClientInstanceName="cbTechnology" runat="server"
                    Width="200px" TextField="Name" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith"
                    SelectedIndex="0" DataSourceID="xmlTechnology" OnDataBound="cbTechnology_DataBound">
                    <ClientSideEvents SelectedIndexChanged="OnTechnologyChanged" />
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="lblProduct" runat="server" Text="Product:" AssociatedControlID="cbProduct" />
            </td>
            <td>
                <dx:ASPxComboBox ID="cbProduct" ClientInstanceName="cbProduct" runat="server" Width="200px"
                    TextField="Name" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith"
                    SelectedIndex="0" DataSourceID="xmlProduct" OnDataBound="cbProduct_DataBound"
                    OnCallback="cbProduct_Callback">
                    <ClientSideEvents SelectedIndexChanged="OnProductChanged" EndCallback="OnProductComboBoxEndCallback" />
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="lblVersion" runat="server" Text="Version:" AssociatedControlID="cbVersion" />
            </td>
            <td>
                <dx:ASPxComboBox ID="cbVersion" ClientInstanceName="cbVersion" runat="server" Width="200px"
                    DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" SelectedIndex="0">
                    <Items>
                        <dx:ListEditItem Text="(none)" Value="none" />
                        <dx:ListEditItem Text="v2007 vol3.0" Value="v7.3" />
                        <dx:ListEditItem Text="v2008 vol1.0" Value="v8.1" />
                        <dx:ListEditItem Text="v2008 vol2.0" Value="v8.2" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
    </table>
    <asp:XmlDataSource ID="xmlTechnology" runat="server" DataFile="~/App_Data/Products.xml"
        XPath="//Technology" />
    <asp:XmlDataSource ID="xmlProduct" runat="server" DataFile="~/App_Data/Products.xml" />
</asp:Content>
