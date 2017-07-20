<%@ Page Title="ARC Reports - Brokerage Metrics Yearly" Language="C#" MasterPageFile="~/Pages/Admin.Master" AutoEventWireup="true" CodeBehind="BrokerageMetricsYearly.aspx.cs" Inherits="ARC.Reports.Pages.BrokerageMetricsYearly" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #MainContent_ASPxLabel1 {
            text-align: right;
            padding-top: 3px;
        }

        .tblLast {
            background-color: #808080 !important;
            font-weight: bold;
            color: white;
        }

        .highVal {
            color: green;
        }

        .lowVal {
            color: red;
        }
    </style>
    <script>
        $(document).ready(function () {
            $(function () {
                $("#sidebar > ul > li > ul:nth-child(5) > li > ul > li:nth-child(1)").addClass("active");
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h4 class="header smaller lighter blue strong">Brokerage Metrics Yearly</h4>
    <div class="row">
        <div class="col-xs-6 col-sm-4 col-md-12 col-lg-12">
            <dx:ASPxGridView ID="ASPxGridView0" Width="100%" runat="server" Theme="DevEx" AutoGenerateColumns="False" OnCustomCallback="ASPxGridViews_CustomCallback" KeyFieldName="Id">
                <Columns>
                    <dx:GridViewDataTextColumn VisibleIndex="0" Caption="Period" CellStyle-BackColor="#f5f7fa" Width="200px">
                        <DataItemTemplate>
                            <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text='<%# Eval("Period_0") %>' />
                            <br />
                            <dx:ASPxLabel ID="lblNotes" runat="server" Text='<%# Eval("Period_1") %>' Font-Size="11px" ForeColor="Gray" />
                        </DataItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" />
                        <HeaderStyle HorizontalAlign="Center" Cursor="default" />
                        <CellStyle HorizontalAlign="Center">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Period_0" VisibleIndex="0" Caption="Period" Width="200px" Visible ="false">
                        <HeaderStyle HorizontalAlign="Center" />
                        <HeaderStyle HorizontalAlign="Center" Cursor="default" Wrap="True" />
                        <CellStyle HorizontalAlign="Center">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Active_CICs" VisibleIndex="1" Caption="No. of Active CICs for the last 12 months with no Watani/IPO" Width="200px">
                        <HeaderStyle HorizontalAlign="Center" />
                        <HeaderStyle HorizontalAlign="Center" Cursor="default" Wrap="True" />
                        <CellStyle HorizontalAlign="Center">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Trunover" VisibleIndex="2" Caption="Turnover Total amount traded during the period" Width="200px">
                        <HeaderStyle HorizontalAlign="Center" />
                        <HeaderStyle HorizontalAlign="Center" Cursor="default" Wrap="True" />
                        <CellStyle HorizontalAlign="Center">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Port_Value" VisibleIndex="3" Caption="Total portfolios value Cash/Shares as at the end of the required period" Width="200px">
                        <HeaderStyle HorizontalAlign="Center" />
                        <HeaderStyle HorizontalAlign="Center" Cursor="default" Wrap="True" />
                        <CellStyle HorizontalAlign="Center">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                </Columns>
                <SettingsBehavior AllowFixedGroups="true" AllowGroup="true" />
                <SettingsPager Mode="ShowAllRecords" />
                <SettingsBehavior AllowSort="false" SortMode="DisplayText" />
            </dx:ASPxGridView>
            <br />
            <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Export To Excel" OnClick="ASPxButton1_Click" Theme="DevEx">
            </dx:ASPxButton>
            <dx:ASPxTimer ID="ASPxTimer1" runat="server" Interval="10000">
                <ClientSideEvents Tick="function(s, e) { 
                MainContent_ASPxGridView0.PerformCallback();
                }" />
            </dx:ASPxTimer>
        </div>
        <dx:ASPxGridViewExporter ID="gridExport_0" runat="server" GridViewID="ASPxGridView0" FileName="Brokerage Metrics Yearly"></dx:ASPxGridViewExporter>

    </div>
</asp:Content>
