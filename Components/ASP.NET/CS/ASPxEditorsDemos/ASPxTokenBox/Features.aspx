<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.cs" Inherits="ASPxTokenBox_Features" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; width: 58%; padding-top: 3px;">
        <dx:ASPxTokenBox ID="ASPxTokenBox1" runat="server" Width="100%" DataSourceID="AddressBookXml" TextField="Name" ValueField="Email">
        </dx:ASPxTokenBox>
        <asp:XmlDataSource ID="AddressBookXml" runat="server" DataFile="~/App_Data/Contacts.xml" XPath="//Contacts/*" TransformFile="Contacts.xsl" />
    </div>
    <div style="float: right; width: 35%">
        <table class="OptionsTable">
            <tr>
                <td>
                    <dx:ASPxLabel runat="server" ID="lbl" Text="AllowCustomTokens:" AssociatedControlID="ddlShowDropDownOnFocus"></dx:ASPxLabel>
                </td>
                <td>
                    <dx:ASPxCheckBox ID="chAllowCustomTokens" runat="server" Checked="true" AutoPostBack="true"></dx:ASPxCheckBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel runat="server" ID="lblShowDropDownOnFocus" Text="ShowDropDownOnFocus:" AssociatedControlID="ddlShowDropDownOnFocus"></dx:ASPxLabel>
                </td>
                <td>
                    <dx:ASPxComboBox ID="ddlShowDropDownOnFocus" runat="server" AutoPostBack="True" Width="100"
                        ValueType="System.Int32" SelectedIndex="0">
                        <Items>
                            <dx:ListEditItem Value="0" Text="Always" />
                            <dx:ListEditItem Value="1" Text="Never" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel runat="server" ID="lblIncrementalFilteringMode" Text="IncrementalFilteringMode:" AssociatedControlID="ddlIncrementalFilteringMode"></dx:ASPxLabel>
                </td>
                <td>
                    <dx:ASPxComboBox ID="ddlIncrementalFilteringMode" runat="server" AutoPostBack="True" Width="100"
                        ValueType="System.Int32" SelectedIndex="0">
                        <Items>
                            <dx:ListEditItem Value="0" Text="Contains" />
                            <dx:ListEditItem Value="1" Text="StartsWith" />
                            <dx:ListEditItem Value="2" Text="None" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
