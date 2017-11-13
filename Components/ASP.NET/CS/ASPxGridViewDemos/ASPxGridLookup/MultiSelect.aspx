<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MultiSelect.aspx.cs" Inherits="ASPxGridLookup_MultiSelect" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function CloseGridLookup() {
            gridLookup.ConfirmCurrentSelection();
            gridLookup.HideDropDown();
            gridLookup.Focus();
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxGridLookup ID="GridLookup" runat="server" SelectionMode="Multiple" DataSourceID="XmlDataSource" ClientInstanceName="gridLookup"
        KeyFieldName="TagName" Width="250px" TextFormatString="{0}" MultiTextSeparator=", " Caption="Select tags">
        <Columns>
            <dx:GridViewCommandColumn ShowSelectCheckbox="True" />
            <dx:GridViewDataColumn FieldName="TagName" />
            <dx:GridViewDataColumn FieldName="Rank" Settings-AllowAutoFilter="False" />
        </Columns>
        <GridViewProperties>
            <Templates>
                <StatusBar>
                    <table class="OptionsTable" style="float: right">
                        <tr>
                            <td>
                                <dx:ASPxButton ID="Close" runat="server" AutoPostBack="false" Text="Close" ClientSideEvents-Click="CloseGridLookup" />
                            </td>
                        </tr>
                    </table>
                </StatusBar>
            </Templates>
            <Settings ShowFilterRow="True" ShowStatusBar="Visible" />
        </GridViewProperties>
    </dx:ASPxGridLookup>
    <asp:XmlDataSource ID="XmlDataSource" runat="server" DataFile="~/App_Data/GridLookupData.xml" XPath="//Tags/*" />
</asp:Content>
