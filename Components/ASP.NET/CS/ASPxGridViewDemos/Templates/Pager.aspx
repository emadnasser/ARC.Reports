<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Pager.aspx.cs"
    Inherits="Templates_Pager" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        var CustomPager = {
            gotoBox_Init: function (s, e) {
                s.SetText(1 + grid.GetPageIndex());
            },
            gotoBox_KeyPress: function (s, e) {
                if(e.htmlEvent.keyCode != 13)
                    return;
                ASPxClientUtils.PreventEventAndBubble(e.htmlEvent);
                CustomPager.applyGotoBoxValue(s);
            },
            gotoBox_ValueChanged: function (s, e) {
                CustomPager.applyGotoBoxValue(s);
            },
            applyGotoBoxValue: function (textBox) {
                if(grid.InCallback())
                    return;
                var pageIndex = parseInt(textBox.GetText()) - 1;
                if(pageIndex < 0)
                    pageIndex = 0;
                grid.GotoPage(pageIndex);
            },
            combo_SelectedIndexChanged: function (s, e) {
                grid.PerformCallback(s.GetSelectedItem().text);
            }
        };
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxGridView ID="Grid" runat="server" AutoGenerateColumns="False" DataSourceID="CustomersDataSource"
        Width="100%" KeyFieldName="CustomerID" OnCustomCallback="Grid_CustomCallback"
        ClientInstanceName="grid">
        <Columns>
            <dx:GridViewDataTextColumn FieldName="ContactName" VisibleIndex="0" />
            <dx:GridViewDataTextColumn FieldName="CompanyName" VisibleIndex="1" />
            <dx:GridViewDataTextColumn FieldName="City" VisibleIndex="2" />
            <dx:GridViewDataTextColumn FieldName="Region" VisibleIndex="3" />
            <dx:GridViewDataTextColumn FieldName="Country" VisibleIndex="4" />
        </Columns>
        <Templates>
            <PagerBar>
                <table class="OptionsTable" style="width: 100%">
                    <tr>
                        <td style="padding-left: 8px;">
                            <dx:ASPxButton runat="server" ID="FirstButton" Text="First" Enabled="<%# Container.Grid.PageIndex > 0 %>"
                                AutoPostBack="false" UseSubmitBehavior="false">
                                <ClientSideEvents Click="function() { grid.GotoPage(0) }" />
                            </dx:ASPxButton>
                        </td>
                        <td>
                            <dx:ASPxButton runat="server" ID="PrevButton" Text="Prev" Enabled="<%# Container.Grid.PageIndex > 0 %>"
                                AutoPostBack="false" UseSubmitBehavior="false">
                                <ClientSideEvents Click="function() { grid.PrevPage() }" />
                            </dx:ASPxButton>
                        </td>
                        <td>
                            <dx:ASPxTextBox runat="server" ID="GotoBox" Width="30">
                                <ClientSideEvents Init="CustomPager.gotoBox_Init" ValueChanged="CustomPager.gotoBox_ValueChanged"
                                    KeyPress="CustomPager.gotoBox_KeyPress" />
                            </dx:ASPxTextBox>
                        </td>
                        <td>
                            <span style="white-space: nowrap">
                                of <%# Container.Grid.PageCount %>
                            </span>
                        </td>
                        <td>
                            <dx:ASPxButton runat="server" ID="NextButton" Text="Next" Enabled="<%# Container.Grid.PageIndex < Container.Grid.PageCount - 1 %>"
                                AutoPostBack="false" UseSubmitBehavior="false">
                                <ClientSideEvents Click="function() { grid.NextPage() }" />
                            </dx:ASPxButton>
                        </td>
                        <td>
                            <dx:ASPxButton runat="server" ID="LastButton" Text="Last" Enabled="<%# Container.Grid.PageIndex < Container.Grid.PageCount - 1 %>"
                                AutoPostBack="false" UseSubmitBehavior="false">
                                <ClientSideEvents Click="function() { grid.GotoPage(grid.GetPageCount() - 1); }" />
                            </dx:ASPxButton>
                        </td>
                        <td style="width: 100%"></td>
                        <td style="white-space: nowrap">
                            <span style="white-space: nowrap">
                                Records per page:
                            </span>
                        </td>
                        <td>
                            <dx:ASPxComboBox runat="server" ID="Combo" Width="70px" DropDownWidth="70px" ValueType="System.Int32"
                                OnLoad="PagerCombo_Load">
                                <Items>
                                    <dx:ListEditItem Value="5" />
                                    <dx:ListEditItem Value="10" />
                                    <dx:ListEditItem Value="15" />
                                </Items>
                                <ClientSideEvents SelectedIndexChanged="CustomPager.combo_SelectedIndexChanged" />
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                </table>
            </PagerBar>
        </Templates>
    </dx:ASPxGridView>
    <ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>
