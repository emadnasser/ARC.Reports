<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Selection.aspx.cs" Inherits="Records_Selection" %>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function OnInit(s, e) {
            UpdateSelectedValuesListBox();
        }
        function OnRecordSelectionChanged(s, e) {
            UpdateSelectedValuesListBox();
        }
        function UpdateSelectedValuesListBox() {
            grid.GetSelectedFieldValues("Model;Price", GetSelectedFieldValuesCallback);
        }
        function GetSelectedFieldValuesCallback(values) {
            selectionList.BeginUpdate();
            try {
                selectionList.ClearItems();
                for(var i = 0; i < values.length; i++) {
                    var item = values[i];
                    var texts = [ item[0], '$' + item[1] ];
                    selectionList.AddItem(texts);
                }
            } finally {
                selectionList.EndUpdate();
            }
            document.getElementById("selCount").innerHTML = grid.GetSelectedRecordCount();
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; width: 78%">
        <div class="BottomPadding">
            Click checkbox to select item:
        </div>
        <dx:ASPxVerticalGrid ID="VerticalGrid" ClientInstanceName="grid" runat="server" DataSourceID="HeadphonesDataSource" Width="100%" KeyFieldName="ID">
            <ClientSideEvents SelectionChanged="OnRecordSelectionChanged" />
            <Rows>
                <dx:VerticalGridCommandRow ShowSelectCheckbox="true" />
                <dx:VerticalGridImageRow FieldName="PhotoUrl" Caption="Photo">
                    <PropertiesImage ImageHeight="180" />
                </dx:VerticalGridImageRow>
                <dx:VerticalGridDataRow FieldName="Brand" RecordStyle-HorizontalAlign="Center" />
                <dx:VerticalGridDataRow FieldName="Model" RecordStyle-HorizontalAlign="Center" />
                <dx:VerticalGridDataRow FieldName="Rating" RecordStyle-HorizontalAlign="Center">
                    <DataItemTemplate>
                        <dx:ASPxRatingControl runat="server" Value="<%# Convert.ToDecimal(Container.Text) %>" ReadOnly="true" />
                    </DataItemTemplate>
                </dx:VerticalGridDataRow>
                <dx:VerticalGridTextRow FieldName="Price">
                    <PropertiesTextEdit DisplayFormatString="c" />
                </dx:VerticalGridTextRow>
                <dx:VerticalGridTextRow FieldName="Discount">
                    <RecordStyle ForeColor="Red" />
                    <PropertiesTextEdit DisplayFormatString="{0}%" />
                </dx:VerticalGridTextRow>
                <dx:VerticalGridTextRow FieldName="Total" UnboundType="Decimal" UnboundExpression="[Price]- [Price] * [Discount] / 100">
                    <RecordStyle Font-Bold="true" />
                    <PropertiesTextEdit DisplayFormatString="c" />
                </dx:VerticalGridTextRow>
            </Rows>
            <Settings HeaderAreaWidth="100" RecordWidth="200" HorizontalScrollBarMode="Visible" />
            <SettingsPager PageSize="10" />
        </dx:ASPxVerticalGrid>
    </div>
    <div style="float: right; width: 20%">
        <div class="BottomPadding">
            Selected values:
        </div>
        <dx:ASPxListBox ID="ASPxListBox1" ClientInstanceName="selectionList" runat="server" Height="250px">
            <ClientSideEvents Init="OnInit" />
            <Columns>
                <dx:ListBoxColumn FieldName="Model" Width="80" />
                <dx:ListBoxColumn FieldName="Price" Width="40" />
            </Columns>
        </dx:ASPxListBox>
        <div class="TopPadding">
            Selected count: <span id="selCount" style="font-weight: bold">0</span>
        </div>
    </div>
    <asp:ObjectDataSource ID="HeadphonesDataSource" runat="server" SelectMethod="SelectHeadphones" TypeName="HeadphonesDataProvider" />
</asp:Content>
