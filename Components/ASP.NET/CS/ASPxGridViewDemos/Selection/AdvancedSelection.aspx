<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AdvancedSelection.aspx.cs"
    Inherits="Selection_AdvancedSelection" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .titleContainer
        {
            height: 32px;
            padding: 6px 10px;
            line-height: 145%;
            text-align: left;
        }
        
    </style>
    <%--start highlighted block--%>
    <script type="text/javascript">
        function OnSelectAllRowsLinkClick(){
            grid.SelectRows();
        }
        function OnUnselectAllRowsLinkClick(){
           grid.UnselectRows();
        }
        function OnGridViewInit(){
            UpdateTitlePanel();
        }
        function OnGridViewSelectionChanged(){
            UpdateTitlePanel();
        }
        function OnGridViewEndCallback(){
            UpdateTitlePanel();
        }
        function UpdateTitlePanel(){
            var selectedFilteredRowCount = GetSelectedFilteredRowCount();
            if(selectAllMode.GetValue() != "AllPages"){
                lnkSelectAllRows.SetVisible(grid.cpVisibleRowCount > selectedFilteredRowCount);
                lnkClearSelection.SetVisible(grid.GetSelectedRowCount() > 0);
            }
            
            var text = "Total rows selected: <b>" + grid.GetSelectedRowCount() + "</b>. ";
            var hiddenSelectedRowCount = grid.GetSelectedRowCount() - GetSelectedFilteredRowCount();
            if(hiddenSelectedRowCount > 0)
                text += "Selected rows hidden by the applied filter: <b>" + hiddenSelectedRowCount + "</b>.";
            text += "<br />";
            info.SetText(text);
        }
        function GetSelectedFilteredRowCount(){
            return grid.cpFilteredRowCountWithoutPage + grid.GetSelectedKeysOnPage().length;
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox ID="selectAllMode" ClientInstanceName="selectAllMode" Caption="Select all checkbox mode:" runat="server" AutoPostBack="true"
        OnSelectedIndexChanged="SelectAllMode_SelectedIndexChanged">
    <RootStyle CssClass="OptionsBottomMargin"></RootStyle>
    </dx:ASPxComboBox>
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource"
        KeyFieldName="CustomerID" Width="100%" OnCustomJSProperties="GridView_CustomJSProperties" EnableRowsCache="false">
        <Settings ShowTitlePanel="true" ShowFilterRow="true" ShowFilterBar="Auto" />
        <SettingsBehavior AllowGroup="false" AllowDragDrop="false" />
        <ClientSideEvents Init="OnGridViewInit" SelectionChanged="OnGridViewSelectionChanged" EndCallback="OnGridViewEndCallback" />
        <Styles TitlePanel-CssClass="titleContainer" />
        <Columns>
            <dx:GridViewCommandColumn ShowSelectCheckbox="True" ShowClearFilterButton="true" VisibleIndex="0" SelectAllCheckboxMode="Page" />
            <dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="1" />
            <dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="2" />
            <dx:GridViewDataColumn FieldName="City" VisibleIndex="3" />
            <dx:GridViewDataColumn FieldName="Region" VisibleIndex="4" />
            <dx:GridViewDataColumn FieldName="Country" VisibleIndex="5" />
        </Columns>
        <Templates>
            <TitlePanel>
                <dx:ASPxLabel ID="lblInfo" ClientInstanceName="info" runat="server" />
                <dx:ASPxHyperLink ID="lnkSelectAllRows" ClientInstanceName="lnkSelectAllRows" OnLoad="lnkSelectAllRows_Load"
                    Text="Select all rows" runat="server" Cursor="pointer" ClientSideEvents-Click="OnSelectAllRowsLinkClick" />
                &nbsp;
                <dx:ASPxHyperLink ID="lnkClearSelection" ClientInstanceName="lnkClearSelection" OnLoad="lnkClearSelection_Load"
                    Text="Clear selection" runat="server" Cursor="pointer" ClientVisible="false" ClientSideEvents-Click="OnUnselectAllRowsLinkClick" />
            </TitlePanel>
        </Templates>
    </dx:ASPxGridView>
    <ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>
