<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Selection.aspx.cs" Inherits="GridView_Selection" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap GridView Selection Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Grid View
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <div class="col-md-9">
    <demo:DemoItem runat="server" Title="Selection via Row Click">
        <Description>
            <p>In addition to using check boxes to select individual rows, the Grid View control allows end-users to select rows with a simple mouse click. To enable this selection mode, set the <strong>SettingsBehavior.AllowSelectByRowClick</strong> property to <strong>true</strong>. Once set, clicking any row clears the previous selection and selects this row.</p>
            <p>To select multiple rows, click the desired rows while holding down the <kbd>Ctrl</kbd> key. Clicking a row in this manner toggles its selected state and preserves the selection. To select contiguous rows, click the first row you wish to select, hold down the <kbd>Shift</kbd> key, and click the last row. You can continue to customize the selection by clicking individual rows while holding down the <kbd>Ctrl</kbd> key.</p>
        </Description>
        <Example>
            <script type="text/javascript">
                function onGridViewAction1(s, e) {
                    $("#info1").html("Total rows selected: " + s.GetSelectedRowCount());
                }
            </script>
            <span id="info1" class="label label-default"></span>
            <br /><br />
            <dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="DataSource1" KeyFieldName="CustomerID">
                <ClientSideEvents Init="onGridViewAction1" SelectionChanged="onGridViewAction1" EndCallback="onGridViewAction1" />
                <CssClassesPager PageNumber="hidden-xs" Ellipsis="hidden-xs" Summary="hidden-md hidden-sm hidden-xs" />
                <SettingsBehavior AllowSelectByRowClick="true" />
                <Columns>
                    <dx:BootstrapGridViewCommandColumn ShowSelectCheckbox="True" SelectAllCheckboxMode="Page" />
                    <dx:BootstrapGridViewDataColumn FieldName="ContactName" />
                    <dx:BootstrapGridViewDataColumn FieldName="CompanyName" />
                    <dx:BootstrapGridViewDataColumn FieldName="City" />
                    <dx:BootstrapGridViewDataColumn FieldName="Country" />
                </Columns>
                <SettingsPager NumericButtonCount="7"></SettingsPager>
            </dx:BootstrapGridView>
            <ef:EntityDataSource runat="server" ID="DataSource1" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
        </Example>
        <CodeASPX>&lt;dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="DataSource1" KeyFieldName="CustomerID"&gt;
    &lt;SettingsBehavior AllowSelectByRowClick="true" /&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewCommandColumn ShowSelectCheckbox="True" SelectAllCheckboxMode="Page" /&gt;
        ...
    &lt;/Columns&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
    </demo:DemoItem>
    <demo:DemoItem runat="server" Title="Selection via Check Boxes">
        <Description>
            <p>The Grid View control provides the capability to allow end-users to select rows using check boxes. To do this, add a command column to the grid and set its <strong>ShowSelectCheckBox</strong> property to <strong>true</strong>. The column will display check boxes within its cells. End-users can check or uncheck these check boxes to select or de-select the corresponding data rows.</p>
            <p>The command column’s <strong>SelectAllCheckboxMode</strong> property allows you to specify the behavior of the Select All check box. This check box can either select all rows in the grid, or only on the current page. If the <strong>SelectAllCheckboxMode</strong> property is set to <strong>None</strong>, the Select All check box is not displayed.</p>
        </Description>
        <Example>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="form-inline">
                        <dx:BootstrapComboBox ID="selectAllMode" Caption="Select all check box mode:" runat="server" AutoPostBack="true"
                            OnSelectedIndexChanged="SelectAllMode_SelectedIndexChanged">
                        </dx:BootstrapComboBox>
                    </div>
                    <script type="text/javascript">
                        function onGridViewAction2(s, e) {
                            $("#info2").html("Total rows selected: " + s.GetSelectedRowCount());
                        }
                    </script>
                    <span id="info2" class="label label-default"></span>
                    <br /><br />
                    <dx:BootstrapGridView ID="GridView2" runat="server" DataSourceID="DataSource2" KeyFieldName="CustomerID">
                        <ClientSideEvents Init="onGridViewAction2" SelectionChanged="onGridViewAction2" EndCallback="onGridViewAction2" />
                        <CssClassesPager PageNumber="hidden-xs" Ellipsis="hidden-xs" Summary="hidden-md hidden-sm hidden-xs" />
                        <Columns>
                            <dx:BootstrapGridViewCommandColumn ShowSelectCheckbox="True" SelectAllCheckboxMode="Page" />
                            <dx:BootstrapGridViewDataColumn FieldName="ContactName" />
                            <dx:BootstrapGridViewDataColumn FieldName="CompanyName" />
                            <dx:BootstrapGridViewDataColumn FieldName="City" />
                            <dx:BootstrapGridViewDataColumn FieldName="Country" />
                        </Columns>
                        <SettingsPager NumericButtonCount="7"></SettingsPager>
                    </dx:BootstrapGridView>
                    <ef:EntityDataSource runat="server" ID="DataSource2" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </Example>
        <CodeASPX>&lt;dx:BootstrapGridView ID="GridView2" runat="server" DataSourceID="DataSource2" KeyFieldName="CustomerID"&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewCommandColumn ShowSelectCheckbox="True" SelectAllCheckboxMode="Page" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="ContactName" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="CompanyName" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="City" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Country" /&gt;
    &lt;/Columns&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
    </demo:DemoItem>
    <demo:DemoItem runat="server" Title="Single Row Only mode">
        <Description>
            <p>In the Single Row Only selection mode, the Grid View only allows one row to be selected at a time. To activate this mode, set the <strong>SettingsBehavior.AllowSelectSingleRowOnly</strong> property to <strong>true</strong>.</p>
        </Description>
        <Example>
            <dx:BootstrapGridView ID="GridView3" runat="server" DataSourceID="DataSource3" KeyFieldName="CustomerID">
                <SettingsBehavior AllowSelectSingleRowOnly="true" AllowSelectByRowClick="true" />
                <Columns>
                    <dx:BootstrapGridViewCommandColumn ShowSelectCheckbox="True" />
                    <dx:BootstrapGridViewDataColumn FieldName="ContactName" />
                    <dx:BootstrapGridViewDataColumn FieldName="CompanyName" />
                    <dx:BootstrapGridViewDataColumn FieldName="City" />
                    <dx:BootstrapGridViewDataColumn FieldName="Country" />
                </Columns>
                <SettingsPager NumericButtonCount="5"></SettingsPager>
            </dx:BootstrapGridView>
            <ef:EntityDataSource runat="server" ID="DataSource3" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
        </Example>
        <CodeASPX>&lt;dx:BootstrapGridView ID="GridView3" runat="server" DataSourceID="DataSource3" KeyFieldName="CustomerID"&gt;
    &lt;SettingsBehavior AllowSelectSingleRowOnly="true" AllowSelectByRowClick="true" /&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewCommandColumn ShowSelectCheckbox="True" SelectAllCheckboxMode="Page" /&gt;
        ...
    &lt;/Columns&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
    </demo:DemoItem>
    <demo:DemoItem runat="server" Title="Selection API">
        <Description>
            <p>The Grid View control provides a client-side API allowing you to programmatically manipulate row selection and obtain information about currently selected rows. Use the following methods to manipulate row selection on the client.</p>
            <ul>
                <li><strong>SelectRows</strong> - allows you to select and deselect specified rows, or select all rows within the grid.</li>
                <li><strong>SelectRowsByKey</strong> - allows you to select and deselect row by their keys.</li>
                <li><strong>SelectAllRowsOnPage</strong> - allows you to select or deselect all rows displayed on the current page.</li>
                <li><strong>UnselectRows</strong> - deselects all rows, or the specified rows within the grid.</li>
            </ul>
            <p>To respond to selection changes, handle the <strong>SelectionChanged</strong> event.</p>
        </Description>
        <Example>
            <script type="text/javascript">
                function onSelectAllRowsClick() {
                    gridView4.SelectRows();
                }
                function onSelectAllRowsOnPageClick() {
                    gridView4.SelectAllRowsOnPage();
                }
                function onClearSelectionClick() {
                    gridView4.UnselectRows();
                }
                function onGridViewAction4(s, e) {
                    btnSelectAllRows.SetEnabled(s.GetSelectedRowCount() < s.cpVisibleRowCount);
                    btnClearSelection.SetEnabled(s.GetSelectedRowCount() > 0);
                    btnSelectAllRowsOnPage.SetEnabled(s.GetSelectedKeysOnPage().length < s.GetVisibleRowsOnPage());
                    $("#info4").html("Total rows selected: " + s.GetSelectedRowCount());
                }
            </script>
            <div class="btn-toolbar form-group">
                <dx:BootstrapButton ClientInstanceName="btnSelectAllRows" Text="Select all rows" runat="server" ClientSideEvents-Click="onSelectAllRowsClick" AutoPostBack="false" />
                <dx:BootstrapButton ClientInstanceName="btnSelectAllRowsOnPage" Text="Select all rows on page" runat="server" ClientSideEvents-Click="onSelectAllRowsOnPageClick" AutoPostBack="false" />
                <dx:BootstrapButton ClientInstanceName="btnClearSelection" Text="Clear selection" runat="server" ClientSideEvents-Click="onClearSelectionClick" AutoPostBack="false" />
            </div>
            <span id="info4" class="label label-default"></span>
            <br /><br />
            <dx:BootstrapGridView ID="GridView4" ClientInstanceName="gridView4" runat="server" DataSourceID="DataSource4" KeyFieldName="CustomerID" OnCustomJSProperties="GridView4_CustomJSProperties">
                <ClientSideEvents Init="onGridViewAction4" SelectionChanged="onGridViewAction4" EndCallback="onGridViewAction4" />
                <Columns>
                    <dx:BootstrapGridViewCommandColumn ShowSelectCheckbox="True" />
                    <dx:BootstrapGridViewDataColumn FieldName="ContactName" />
                    <dx:BootstrapGridViewDataColumn FieldName="CompanyName" />
                    <dx:BootstrapGridViewDataColumn FieldName="City" />
                    <dx:BootstrapGridViewDataColumn FieldName="Country" />
                </Columns>
                <SettingsPager NumericButtonCount="5"></SettingsPager>
            </dx:BootstrapGridView>
            <ef:EntityDataSource runat="server" ID="DataSource4" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
        </Example>
        <CodeASPX>&lt;dx:BootstrapGridView ID="GridView4" ClientInstanceName="gridView4" runat="server" DataSourceID="DataSource4" KeyFieldName="CustomerID" OnCustomJSProperties="GridView4_CustomJSProperties"&gt;
    &lt;ClientSideEvents Init="onGridViewAction4" SelectionChanged="onGridViewAction4" EndCallback="onGridViewAction4" /&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewCommandColumn ShowSelectCheckbox="True" /&gt;
        ...
    &lt;/Columns&gt;
    &lt;SettingsPager NumericButtonCount="5"&gt;&lt;/SettingsPager&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
        <CodeJS>function onSelectAllRowsClick() {
    gridView4.SelectRows();
}
function onSelectAllRowsOnPageClick() {
    gridView4.SelectAllRowsOnPage();
}
function onClearSelectionClick() {
    gridView4.UnselectRows();
}
function onGridViewAction4(s, e) {
    btnSelectAllRows.SetEnabled(s.GetSelectedRowCount() &lt; s.cpVisibleRowCount);
    btnClearSelection.SetEnabled(s.GetSelectedRowCount() &gt; 0);
    btnSelectAllRowsOnPage.SetEnabled(s.GetSelectedKeysOnPage().length &lt; s.GetVisibleRowsOnPage());
    $("#info4").html("Total rows selected: " + s.GetSelectedRowCount());
}</CodeJS>
    </demo:DemoItem>
    </div>
    <div class="col-md-3">
        <div class="affix" id="page-navigation">
        </div>
    </div>
</asp:Content>
