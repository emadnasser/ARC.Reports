<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FilterPopup.aspx.cs" Inherits="FilterPopup" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <script type="text/javascript">
        function getHeader(name) {
            var areas = ['FilterArea', 'DataArea', 'RowArea', 'ColumnArea'];
            for(var i = 0; i < areas.length; i++) {
                var areaTable = pivotGrid.GetHeadersTable(areas[i]);
                if(areaTable == null)
                    continue;
                var areaHeaders = ASPx.GetNodes(areaTable , function(e) {
                    return ASPx.ElementContainsCssClass(e, 'dxpgHeader') && e.tagName.toUpperCase() == 'TABLE' && e.textContent.trim() == name;
                });
                if(areaHeaders.length != 0)
                    return areaHeaders[0];
            }
        }
        function getHeaderFilterButton(header) {
            return ASPx.GetNodes(header, function(e) {
                return ASPx.ElementContainsCssClass(e, 'FilterButton');
            })[0];
        }
        function click(control) {
            var event = document.createEvent('MouseEvents');
            event.initEvent('click', false, true);
            control.dispatchEvent(event);
        }
        function showFilterPopup(name) {
            click(getHeaderFilterButton(getHeader(name)));
        }
    </script>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <table class="OptionsTable BottomMargin">
        <tr>
            <td>
                <dx:ASPxCheckBox ID="cbShowOnlyAvailableItems" runat="server" 
                    Text="Show Only Available Items" Checked="true" AutoPostBack="true" 
                    oncheckedchanged="cbShowOnlyAvailableItems_CheckedChanged" />
            </td>            
            <td>
                <dx:ASPxCheckBox ID="cbShowHiddenItems" runat="server" Text="Show Hidden Items" Checked="false" AutoPostBack="true" 
                    oncheckedchanged="cbShowHiddenItems_CheckedChanged" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="cbNativeCheckBoxes" runat="server" Text="Native CheckBoxes" Checked="true" AutoPostBack="true"
                    oncheckedchanged="cbNativeCheckBoxes_CheckedChanged" />
            </td>
        </tr>
    </table>
    <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" 
        ClientInstanceName="pivotGrid" Width="100%" DataSourceID="SalesPersonsDataSource">
        <Fields>
            <dx:PivotGridField ID="fieldOrderAmount" Area="DataArea" AreaIndex="0" Caption="Order Amount"
                UnboundType="Decimal" UnboundFieldName="OrderAmount" UnboundExpression="[UnitPrice] * [Quantity]" />
            <dx:PivotGridField ID="fieldQuantity" Area="DataArea" AreaIndex="1" FieldName="Quantity" />
            <dx:PivotGridField ID="fieldCategory" Area="FilterArea" AreaIndex="0" Caption="Category" FieldName="CategoryName" />
            <dx:PivotGridField ID="fieldProduct" Area="RowArea" AreaIndex="0" Caption="Product" FieldName="ProductName" />
        </Fields>
    </dx:ASPxPivotGrid>
    <ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" />
</asp:Content>
