<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FilterExpression.aspx.cs"
    Inherits="ASPxFilterControl_FilterExpression" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        b.label
        {
            font-size: 11px;
        }
    </style>
    <%--start highlighted block--%>
    <script type="text/javascript">
        function UpdateInfoPanelText() {
            var text = filter.IsFilterExpressionValid() ? filter.cpFilterExpression : "Filter expression is not valid";
            if (text == "")
                text = "Filter expression is empty";
            filterExpressionLabel.SetText(text);
        }
        function onApplied() {
            if (filter.IsFilterExpressionValid())
                dataView.PerformCallback();
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="BottomMargin" style="width: 100%;">
        <tr>
            <td style="vertical-align: top; padding-top:53px">
                <table>
                    <tr>
                        <td>
                            <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" HeaderText="Filter" Width="200px" View="GroupBox">
                                <PanelCollection>
                                    <dx:PanelContent runat="server">
                                        <dx:ASPxFilterControl ID="ASPxFilterControl1" runat="server"
                                            ClientInstanceName="filter"
                                            OnCustomJSProperties="ASPxFilterControl1_CustomJSProperties">
                                            <Columns>
                                                <dx:FilterControlTextColumn PropertyName="Price" DisplayName="Price"
                                                    ColumnType="Integer">
                                                    <PropertiesTextEdit DisplayFormatString="${0}" />
                                                </dx:FilterControlTextColumn>
                                                <dx:FilterControlTextColumn PropertyName="YearBuilt" DisplayName="YearBuilt"
                                                    ColumnType="Integer">
                                                </dx:FilterControlTextColumn>
                                                <dx:FilterControlTextColumn PropertyName="HouseSize" DisplayName="House Size"
                                                    ColumnType="Integer">
                                                </dx:FilterControlTextColumn>
                                                <dx:FilterControlTextColumn PropertyName="Beds" DisplayName="Beds"
                                                    ColumnType="Integer">
                                                </dx:FilterControlTextColumn>
                                                <dx:FilterControlTextColumn PropertyName="Baths" DisplayName="Baths"
                                                    ColumnType="Integer">
                                                </dx:FilterControlTextColumn>
                                            </Columns>
                                            <ClientSideEvents EndCallback="function(s, e) { UpdateInfoPanelText(); }"
                                                Applied="onApplied" />
                                        </dx:ASPxFilterControl>
                                        <table class="OptionsTable" style="margin: 12px auto 0;">
                                            <tr>
                                                <td>
                                                    <dx:ASPxButton runat="server" ID="ASPxButton1" Text="Apply" AutoPostBack="False"
                                                        UseSubmitBehavior="False">
                                                        <ClientSideEvents Click="function() { filter.Apply(); }" />
                                                    </dx:ASPxButton>
                                                </td>
                                                <td>
                                                    <dx:ASPxButton runat="server" ID="ASPxButton2" Text="Clear" AutoPostBack="False"
                                                        UseSubmitBehavior="False">
                                                        <ClientSideEvents Click="function() { filter.Clear();  }" />
                                                    </dx:ASPxButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </dx:PanelContent>
                                </PanelCollection>
                            </dx:ASPxRoundPanel>
                        </td>
                    </tr>
                    <tr>
                        <td style="padding-top: 20px; text-align: justify;">
                            <span>The currently composed filter expression:</span>
                            <dx:ASPxLabel ID="ASPxLabel1" runat="server" Width="100%" Font-Size="Medium" ClientInstanceName="filterExpressionLabel" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <div style="width: 20px;">
                </div>
            </td>
            <td style="width: 100%; vertical-align: top; ">
                <dx:ASPxDataView ID="ASPxDataView1" runat="server" DataSourceID="HomesDataSource" Width="100%"
                    ClientInstanceName="dataView" OnCustomCallback="ASPxDataView1_CustomCallback" >
                    <SettingsTableLayout ColumnCount="2" RowsPerPage="2" />
                    <ItemTemplate>
                        <dx:ASPxBinaryImage ID="ASPxBinaryImage1" runat="server" Value='<%# Eval("Photo") %>'
                            EnableServerResize="true" ImageSizeMode="FillAndCrop"
                            Width="240px" Height="130px" />
                        <div style="padding: 6px 0;">
                            <dx:ASPxLabel ID="ASPxLabel7" runat="server" Font-Size="12px" Text='<%# Eval("Address")  %>' />
                            <table style="margin: 0 auto; width: 100%">
                                <tr>
                                    <td>
                                        <b class="label">Price:</b>
                                        <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text='<%# String.Format("{0:c}", Eval("Price")) %>' />
                                        <br />
                                        <b class="label">House Size:</b>
                                        <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text='<%# Eval("HouseSize") %>' />
                                        <br />
                                        <b class="label">YearBuilt:</b>
                                        <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text='<%# Eval("YearBuilt") %>' />
                                    </td>
                                    <td>
                                        <b class="label">Beds:</b>
                                        <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text='<%# Eval("Beds") %>' />
                                        <br />
                                        <b class="label">Baths:</b>
                                        <dx:ASPxLabel ID="ASPxLabel6" runat="server" Text='<%# Eval("Baths") %>' />
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                    <PagerSettings AllButton-Visible="true" />
                </dx:ASPxDataView>
            </td>
        </tr>
    </table>
    <asp:ObjectDataSource ID="HomesDataSource" runat="server" SelectMethod="GetHomes" TypeName="HomesDataProvider" />
</asp:Content>
