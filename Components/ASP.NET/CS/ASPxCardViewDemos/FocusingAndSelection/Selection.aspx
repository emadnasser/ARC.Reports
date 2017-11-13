<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Selection.aspx.cs" Inherits="Cards_Selection" %>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function OnCardSelectionChanged(s, e) {
            s.GetSelectedFieldValues("FirstName;LastName", GetSelectedFieldValuesCallback);
        }
        function GetSelectedFieldValuesCallback(values) {
            selectionList.BeginUpdate();
            try {
                selectionList.ClearItems();
                for (var i = 0; i < values.length; i++) {
                    selectionList.AddItem(values[i].join(' '));
                }
            } finally {
                selectionList.EndUpdate();
            }
            document.getElementById("selCount").innerHTML = cardView.GetSelectedCardCount();
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; width: 20%">
        <div class="BottomPadding">
            Selected values:
        </div>
        <dx:ASPxListBox ID="ASPxListBox1" ClientInstanceName="selectionList" runat="server" Height="250px" Width="100%" />
        <div class="TopPadding">
            Selected count: <span id="selCount" style="font-weight: bold">0</span>
        </div>
    </div>
    <div style="float: right; width: 78%">
        <dx:ASPxCardView ID="CardView" ClientInstanceName="cardView" runat="server" DataSourceID="EmployeesDataSource" Width="100%" KeyFieldName="EmployeeID" EnableCardsCache="false" OnPreRender="CardView_PreRender">
            <ClientSideEvents SelectionChanged="OnCardSelectionChanged" />
            <SettingsBehavior AllowSelectByCardClick="true" />
            <SettingsPager>
                <SettingsTableLayout ColumnCount="2" RowsPerPage="2" />
            </SettingsPager>
            <CardLayoutProperties ColCount="2">
                <Items>
                    <dx:CardViewColumnLayoutItem ColumnName="Photo" ShowCaption="False" />
                    <dx:CardViewLayoutGroup ShowCaption="False" VerticalAlign="Middle" SettingsItemCaptions-Location="Top" GroupBoxDecoration="None">
                        <Items>
                            <dx:CardViewCommandLayoutItem ShowSelectCheckbox="true" HorizontalAlign="Right" />
                            <dx:CardViewColumnLayoutItem ColumnName="FirstName" />
                            <dx:CardViewColumnLayoutItem ColumnName="LastName" />
                            <dx:CardViewColumnLayoutItem ColumnName="Title" />
                        </Items>
                    </dx:CardViewLayoutGroup>
                </Items>
                <Styles LayoutItem-Caption-Font-Bold="true" />
            </CardLayoutProperties>
            <Columns>
                <dx:CardViewBinaryImageColumn FieldName="Photo">
                    <PropertiesBinaryImage ImageWidth="150px" ImageHeight="150px" />
                </dx:CardViewBinaryImageColumn>
                <dx:CardViewColumn FieldName="FirstName" />
                <dx:CardViewColumn FieldName="LastName" />
                <dx:CardViewColumn FieldName="Title" />
            </Columns>
        </dx:ASPxCardView>
    </div>
    <ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" />
</asp:Content>
