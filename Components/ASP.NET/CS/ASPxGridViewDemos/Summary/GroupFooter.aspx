<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="GroupFooter.aspx.cs"
    Inherits="Summary_GroupFooter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox runat="server" ID="ddlGroupFooter" AutoPostBack="true" OnSelectedIndexChanged="ddlGroupFooter_SelectedIndexChanged" Caption="Group footer mode">
        <RootStyle CssClass="OptionsBottomMargin"></RootStyle>
    </dx:ASPxComboBox>
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="SalesPersonsDataSource"
        KeyFieldName="OrderID" OnCustomUnboundColumnData="grid_CustomUnboundColumnData"
        Width="100%" AutoGenerateColumns="False">
        <Columns>
            <dx:GridViewDataTextColumn FieldName="ProductName" VisibleIndex="0" />
            <dx:GridViewDataTextColumn FieldName="CategoryName" VisibleIndex="1" />
            <dx:GridViewDataTextColumn FieldName="Country" VisibleIndex="2" />
            <dx:GridViewDataDateColumn FieldName="OrderDate" VisibleIndex="3" GroupIndex="0" />
            <dx:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="4">
                <PropertiesTextEdit DisplayFormatString="c" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Quantity" VisibleIndex="5" />
            <dx:GridViewDataTextColumn FieldName="Total" VisibleIndex="6" UnboundType="Decimal">
                <PropertiesTextEdit DisplayFormatString="c" />
            </dx:GridViewDataTextColumn>
        </Columns>
        <Settings ShowGroupPanel="True" ShowFooter="True" ShowGroupFooter="VisibleIfExpanded" />
        <TotalSummary>
            <dx:ASPxSummaryItem FieldName="Country" SummaryType="Count" />
            <dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
        </TotalSummary>
        <GroupSummary>
            <dx:ASPxSummaryItem FieldName="Country" ShowInGroupFooterColumn="Country" SummaryType="Count" />
            <dx:ASPxSummaryItem FieldName="Quantity" ShowInGroupFooterColumn="Quantity" SummaryType="Sum" />
            <dx:ASPxSummaryItem FieldName="Total" ShowInGroupFooterColumn="Total" SummaryType="Sum" />
        </GroupSummary>
    </dx:ASPxGridView>
    <ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons"/>
</asp:Content>
