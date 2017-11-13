<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Drilldown.aspx.cs"
    Inherits="OLAP_Drilldown" AspCompat="true" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <script type="text/javascript">
        function ShowDrillDown() {
            var mainElement = pivotGrid.GetMainElement();
            DrillDownWindow.ShowAtPos(ASPxClientUtils.GetAbsoluteX(mainElement), ASPxClientUtils.GetAbsoluteY(mainElement));
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <input runat="server" id="ColumnIndex" type="hidden" enableviewstate="true" />
    <input runat="server" id="RowIndex" type="hidden" enableviewstate="true" />
    <input runat="server" id="IsPopupShowing" type="hidden" enableviewstate="true" />
    <input runat="server" id="IsPopupShown" type="hidden" enableviewstate="true" />
    <dx:ASPxPivotGrid ID="pivotGrid" runat="server" CustomizationFieldsLeft="600" CustomizationFieldsTop="400"
        ClientInstanceName="pivotGrid" CssClass="dxpgControl" Width="100%" OnQueryException="pivotGrid_QueryException"
        OLAPConnectionString="<%$ ConnectionStrings:NorthwindCubeFileConnection %>" >
        <Styles>
            <CellStyle Cursor="pointer" />
        </Styles>
        <Fields>
            <dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Category Name" FieldName="[Categories].[Category Name].[Category Name]"
                ID="field0" />
            <dx:PivotGridField Area="FilterArea" AreaIndex="0" Caption="City" FieldName="[Customers].[City].[City]"
                ID="field1" />
            <dx:PivotGridField Area="FilterArea" AreaIndex="0" Caption="Country" FieldName="[Customers].[Country].[Country]"
                ID="field2" />
            <dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Products" FieldName="[Products].[Products].[Products]"
                ID="field3" />
            <dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Quantity" FieldName="[Measures].[Quantity]"
                ID="field4" />
            <dx:PivotGridField Area="DataArea" AreaIndex="1" Caption="Discount" FieldName="[Measures].[Discount]"
                ID="field5" />
        </Fields>
        <OptionsView HorizontalScrollBarMode="Auto" />
        <OptionsFilter NativeCheckBoxes="False" />
    </dx:ASPxPivotGrid>
    <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" Modal="true" Height="1px"
        AllowDragging="True" ClientInstanceName="DrillDownWindow" Left="200" Top="200"
        CloseAction="CloseButton" Width="153px" HeaderText="Drill Down Window" >
    </dx:ASPxPopupControl>
    <dx:ASPxPopupControl ID="ASPxPopupControl2" runat="server" Modal="true" 
        ClientInstanceName="ASPxPopupControl2" PopupHorizontalAlign="Center" PopupVerticalAlign="Middle"
        CloseAction="CloseButton"  HeaderText="Error">
        <ContentCollection>
            <dx:PopupControlContentControl>
                <div id="errorText"></div>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
</asp:Content>
