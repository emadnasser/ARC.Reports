<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TimeEditor.aspx.cs"
    Inherits="DateTime_TimeEditor" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function cbTimeEditFormat_SelectedIndexChanged(s, e) {
            if (s.GetText() == "Custom") {
                cbTimeEditFormatString.SetEnabled(true);
                e.processOnServer = false;
            }
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable">
        <tr>        
            <td>
                <dx:ASPxLabel ID="timeLabel" runat="server" AssociatedControlID="timeEdit" Text="ASPxTimeEdit:" />
            </td>
            <td style="width: 50%">
                <dx:ASPxTimeEdit ID="timeEdit" runat="server" DateTime="2009/11/01 15:31:34" Width="200">
                    <ClearButton DisplayMode="OnHover"></ClearButton>
                    <ValidationSettings ErrorDisplayMode="None" />
                </dx:ASPxTimeEdit>
            </td>
            <td>
                <dx:ASPxLabel ID="timeEditFormatLabel" runat="server" AssociatedControlID="cbTimeEditFormat" 
                    Text="EditFormat:" />
            </td>
            <td>
                <dx:ASPxComboBox ID="cbTimeEditFormat" runat="server" SelectedIndex="0" AutoPostBack="true">
                    <ClientSideEvents SelectedIndexChanged="cbTimeEditFormat_SelectedIndexChanged" />
                </dx:ASPxComboBox>                                
            </td>        
        </tr>
        <tr>
            <td rowspan="3"></td>
            <td rowspan="3"></td>
            <td>
                <dx:ASPxLabel ID="timeEditFormatStringLabel" runat="server" AssociatedControlID="cbTimeEditFormatString" 
                    Text="EditFormatString:" />
            </td>
            <td>
                <dx:ASPxComboBox ID="cbTimeEditFormatString" runat="server" SelectedIndex="0" AutoPostBack="true"
                    ClientInstanceName="cbTimeEditFormatString">
                    <Items>
                        <dx:ListEditItem Text="None" />
                        <dx:ListEditItem Value="h:mm:ss tt" />
                        <dx:ListEditItem Value="dd/MM/yyyy HH:mm:ss" />
                        <dx:ListEditItem Value="MMMM dd, yyyy hh:mm tt" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
    
        <tr>
            <td>
                <dx:ASPxLabel ID="timeEditDisplayFormatLabel" runat="server" AssociatedControlID="cbTimeDisplayFormatString" 
                    Text="DisplayFormatString:" />
            </td>
            <td>
                <dx:ASPxComboBox ID="cbTimeDisplayFormatString" runat="server" SelectedIndex="0"
                    AutoPostBack="true">
                    <Items>
                        <dx:ListEditItem Text="None" />
                        <dx:ListEditItem Value="h:mm tt" />
                        <dx:ListEditItem Value="h:mm:ss tt" />
                    </Items>
                </dx:ASPxComboBox>                
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="timeEditAllowNullLabel" runat="server" AssociatedControlID="chkTimeAllowNull" 
                    Text="AllowNull:" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="chkTimeAllowNull" runat="server" Checked="true" AutoPostBack="true" />                
            </td>
        </tr>
    
    </table>
</asp:Content>
