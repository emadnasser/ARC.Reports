<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RadioButtonList.aspx.cs"
    Inherits="ListEditors_RadioButtonList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <table>
        <tr>
            <td style="width: 900px; padding-right: 20px">
                <dx:ASPxRadioButtonList ID="radioButtonList" runat="server" DataSourceID="ProgLanguages"
                    ValueField="ID" TextField="Name" RepeatColumns="4" RepeatLayout="Table" Caption="Choose language">
                    <CaptionSettings Position="Top" />
                </dx:ASPxRadioButtonList>
                <asp:XmlDataSource ID="ProgLanguages" DataFile="~/App_Data/Languages.xml" XPath="//Language"
                    runat="server" />
            </td>
            <td style="vertical-align: top">
                <table class="OptionsTable">
                    <tr>
                        <td>
                            <dx:ASPxLabel runat="server" ID="layoutLabel" AssociatedControlID="cmbRepeatLayout" Text="RepeatLayout:" />
                        </td>
                        <td>
                            <dx:ASPxComboBox ID="cmbRepeatLayout" runat="server" SelectedIndex="0" Width="100px" AutoPostBack="true">
                                <Items>
                                    <dx:ListEditItem Value="Table" Text="Table" />
                                    <dx:ListEditItem Value="Flow" Text="Flow" />
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <dx:ASPxLabel runat="server" ID="repeatLabel" AssociatedControlID="cmbDirection"
                                Text="RepeatDirection:" />
                        </td>
                        <td>
                            <dx:ASPxComboBox ID="cmbDirection" runat="server" SelectedIndex="1" Width="100px" AutoPostBack="true">
                                <Items>
                                    <dx:ListEditItem Value="Horizontal" Text="Horizontal" />
                                    <dx:ListEditItem Value="Vertical" Text="Vertical" />
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxLabel runat="server" ID="columnsLabel" AssociatedControlID="spnColumnCount"
                                Text="RepeatColumns:" />
                        </td>
                        <td>
                            <dx:ASPxSpinEdit ID="spnColumnCount" runat="server" Width="100px" 
                                AutoPostBack="true" ValueChangedDelay="500"
                                Number="5" MinValue="1" MaxValue="6" AllowNull="false">
                            </dx:ASPxSpinEdit>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>    
</asp:Content>
