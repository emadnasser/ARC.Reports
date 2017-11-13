<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Editing.aspx.cs" Inherits="GridView_Editing" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap GridView Data Editing Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Grid View
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-9">
        <demo:DemoItem runat="server" Title="Editing With Edit Form">
            <Description>
                <p>The Grid View control provides end-user data editing functionality out of the box. The commands for end-user data modification are displayed within a command column. Add this column to the grid’s <strong>Columns</strong> to allow editing.</p>
                <p>By default, a built-in Edit Form is used to modify cell values. The Edit Form displays edit cells that correspond to data columns, and the <strong>Cancel/Update</strong> commands that allow end-users to discard changes or save them to a database.</p>
            </Description>
            <Example>
                <dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="DemoDataSource1" KeyFieldName="EmployeeID" EnableRowsCache="False">
                    <Columns>
                        <dx:BootstrapGridViewCommandColumn ShowEditButton="true" ShowDeleteButton="true" ShowNewButtonInHeader="true" />
                        <dx:BootstrapGridViewDataColumn FieldName="FirstName" />
                        <dx:BootstrapGridViewDataColumn FieldName="LastName" />
                        <dx:BootstrapGridViewDataColumn FieldName="Title" />
                        <dx:BootstrapGridViewDataDateColumn FieldName="BirthDate" />
                        <dx:BootstrapGridViewDataColumn FieldName="City" />
                        <dx:BootstrapGridViewDataColumn FieldName="Country" />
                    </Columns>
                </dx:BootstrapGridView>
                
                <demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="EmployeeID" DataSourceID="DataSource1"></demo:DemoDataSource>
                <ef:EntityDataSource runat="server" ID="DataSource1" ContextTypeName="NorthwindContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntitySetName="Employees">
                </ef:EntityDataSource>
            </Example>
            <CodeASPX>&lt;dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="DataSource1" KeyFieldName="EmployeeID"&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewCommandColumn ShowEditButton="true" ShowDeleteButton="true" ShowNewButtonInHeader="true" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="FirstName" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="LastName" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Title" /&gt;
        &lt;dx:BootstrapGridViewDataDateColumn FieldName="BirthDate" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="City" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Country" /&gt;
    &lt;/Columns&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Editing in Popup Edit Form">
            <Description>
                <p>In this mode, the Edit Form is displayed within a popup window. To use this mode, set the <strong>SettingsEditing.Mode</strong> property to <strong>PopupEditForm</strong>.</p>
            </Description>
            <Example>
                <dx:BootstrapGridView ID="GridView2" runat="server" DataSourceID="DemoDataSource2" KeyFieldName="EmployeeID" EnableRowsCache="False">
                    <CssClassesPager PageNumber="hidden-xs" Ellipsis="hidden-xs" Summary="hidden-md hidden-sm hidden-xs" />
                    <SettingsEditing Mode="PopupEditForm"></SettingsEditing>
                    <Columns>
                        <dx:BootstrapGridViewCommandColumn ShowEditButton="true" ShowDeleteButton="true" ShowNewButtonInHeader="true" />
                        <dx:BootstrapGridViewDataColumn FieldName="FirstName" />
                        <dx:BootstrapGridViewDataColumn FieldName="LastName" />
                        <dx:BootstrapGridViewDataColumn FieldName="Title" />
                        <dx:BootstrapGridViewDataDateColumn FieldName="BirthDate" />
                        <dx:BootstrapGridViewDataColumn FieldName="City" />
                        <dx:BootstrapGridViewDataColumn FieldName="Country" />
                    </Columns>
                    <SettingsPopup>
                        <EditForm Width="600" />
                    </SettingsPopup>
                    <SettingsPager NumericButtonCount="7"></SettingsPager>
                </dx:BootstrapGridView>
                
                <demo:DemoDataSource runat="server" ID="DemoDataSource2" IdentityKey="EmployeeID" DataSourceID="DataSource2"></demo:DemoDataSource>
                <ef:EntityDataSource runat="server" ID="DataSource2" ContextTypeName="NorthwindContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntitySetName="Employees">
                </ef:EntityDataSource>
            </Example>
            <CodeASPX>&lt;dx:BootstrapGridView ID="GridView2" runat="server" DataSourceID="DataSource2" KeyFieldName="EmployeeID"&gt;
    &lt;SettingsEditing Mode="PopupEditForm"&gt;&lt;/SettingsEditing&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewCommandColumn ShowEditButton="true" ShowDeleteButton="true" ShowNewButtonInHeader="true" /&gt;
        ...
    &lt;/Columns&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Inline Editing">
            <Description>
                <p>In the inline editing mode, the Grid View control displays an In-Line Edit Row instead of the edited data row. The edit row displays edit cells that correspond to visible data columns. To use this mode, set the <strong>SettingsEditing.Mode</strong> property to <strong>Inline</strong>.</p>
            </Description>
            <Example>
                <dx:BootstrapGridView ID="GridView3" runat="server" DataSourceID="DemoDataSource3" KeyFieldName="EmployeeID" EnableRowsCache="False">
                    <CssClassesPager PageNumber="hidden-xs" Ellipsis="hidden-xs" Summary="hidden-md hidden-sm hidden-xs" />
                    <SettingsEditing Mode="Inline"></SettingsEditing>
                    <Columns>
                        <dx:BootstrapGridViewCommandColumn ShowEditButton="true" ShowDeleteButton="true" ShowNewButtonInHeader="true" />
                        <dx:BootstrapGridViewDataColumn FieldName="FirstName" />
                        <dx:BootstrapGridViewDataColumn FieldName="LastName" />
                        <dx:BootstrapGridViewDataColumn FieldName="Title" />
                        <dx:BootstrapGridViewDataDateColumn FieldName="BirthDate" />
                        <dx:BootstrapGridViewDataColumn FieldName="City" />
                        <dx:BootstrapGridViewDataColumn FieldName="Country" />
                    </Columns>
                    <SettingsPager NumericButtonCount="7"></SettingsPager>
                </dx:BootstrapGridView>
                
                <demo:DemoDataSource runat="server" ID="DemoDataSource3" IdentityKey="EmployeeID" DataSourceID="DataSource3"></demo:DemoDataSource>
                <ef:EntityDataSource runat="server" ID="DataSource3" ContextTypeName="NorthwindContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntitySetName="Employees">
                </ef:EntityDataSource>
            </Example>
            <CodeASPX>&lt;dx:BootstrapGridView ID="GridView3" runat="server" DataSourceID="DataSource3" KeyFieldName="EmployeeID"&gt;
    &lt;SettingsEditing Mode="Inline"&gt;&lt;/SettingsEditing&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewCommandColumn ShowEditButton="true" ShowDeleteButton="true" ShowNewButtonInHeader="true" /&gt;
        ...
    &lt;/Columns&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
        </demo:DemoItem>
    <demo:DemoItem runat="server" Title="Cascading Combo Boxes">
        <Description>
            <p>In this demo, the combo box in the City column (the City combo box) is populated dynamically with city names using callbacks, based on the value selected in the combo box in the Country column (the Country combo box). Only the content stored in the City combo box is updated during round-trips to the server - not the content of the page or the Grid View control.</p>
            <p>The client-side <strong>SelectedIndexChanged</strong> event of the Country combo box is handled to update the City combo box. On the server side, the <strong>Callback</strong> event is handled to populate the City combo box with required values.</p>
        </Description>
        <Example>
            <script type="text/javascript">
                var lastCountry = null;
                function OnCountryChanged(grid, cmbCountry) {
                    if (grid.GetEditor("City").InCallback() )
                        lastCountry = cmbCountry.GetValue().toString();
                    else 
                        grid.GetEditor("City").PerformCallback(cmbCountry.GetValue().toString());
                }
                function OnCityEndCallback(grid){
                    if (lastCountry){
                        grid.GetEditor("City").PerformCallback(lastCountry);
                        lastCountry = null;
                    }
                }
            </script>
            <dx:BootstrapGridView ID="GridView4" ClientInstanceName="grid" runat="server" DataSourceID="DemoDataSource4"
                KeyFieldName="CustomerID" AutoGenerateColumns="False" OnCellEditorInitialize="grid_CellEditorInitialize">
                <CssClassesPager PageNumber="hidden-xs" Ellipsis="hidden-xs" Summary="hidden-md hidden-sm hidden-xs" />
                <SettingsEditing Mode="Inline" />
                <Columns>
                    <dx:BootstrapGridViewCommandColumn ShowEditButton="true" VisibleIndex="0" />
                    <dx:BootstrapGridViewDataComboBoxColumn FieldName="Country" VisibleIndex="1">
                        <PropertiesComboBox TextField="CountryName" ValueField="CountryName" EnableSynchronization="False"
                            IncrementalFilteringMode="StartsWith" DataSourceID="CountriesDataSource">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { OnCountryChanged(grid, s); }"></ClientSideEvents>
                        </PropertiesComboBox>
                    </dx:BootstrapGridViewDataComboBoxColumn>
                    <dx:BootstrapGridViewDataComboBoxColumn FieldName="City" VisibleIndex="2">
                        <PropertiesComboBox EnableSynchronization="False" IncrementalFilteringMode="StartsWith" >
                            <ClientSideEvents EndCallback="function(s, e) { OnCityEndCallback(grid); }"/>
                        </PropertiesComboBox>
                    </dx:BootstrapGridViewDataComboBoxColumn>
                    <dx:BootstrapGridViewDataColumn VisibleIndex="3" FieldName="ContactName">
                    </dx:BootstrapGridViewDataColumn>
                    <dx:BootstrapGridViewDataColumn VisibleIndex="4" FieldName="CompanyName">
                    </dx:BootstrapGridViewDataColumn>
                </Columns>
                <SettingsPager NumericButtonCount="7"></SettingsPager>
            </dx:BootstrapGridView>
            <demo:DemoDataSource runat="server" ID="DemoDataSource4" DataSourceID="DataSource4"></demo:DemoDataSource>
            <ef:EntityDataSource runat="server" ID="DataSource4"
                ContextTypeName="NorthwindContext"
                EnableDelete="True" EnableInsert="True" EnableUpdate="True"
                EntitySetName="Customers">
            </ef:EntityDataSource>
            <ef:EntityDataSource ID="CountriesDataSource" runat="server" ContextTypeName="WorldCitiesContext" EntitySetName="Countries" OrderBy="it.CountryName"></ef:EntityDataSource>
        </Example>
        
    <CodeASPX>&lt;dx:BootstrapGridView ID="BootstrapGridView1" ClientInstanceName="grid" runat="server" 
    DataSourceID="DemoDataSource4" KeyFieldName="CustomerID" AutoGenerateColumns="False" 
    OnCellEditorInitialize="grid_CellEditorInitialize"&gt;
    &lt;SettingsEditing Mode="Inline" /&gt;
    &lt;Columns&gt;
        ...
        &lt;dx:BootstrapGridViewDataComboBoxColumn FieldName="Country" VisibleIndex="1"&gt;
            &lt;PropertiesComboBox TextField="CountryName" ValueField="CountryName" 
                EnableSynchronization="False" IncrementalFilteringMode="StartsWith" 
                DataSourceID="CountriesDataSource"&gt;
                &lt;ClientSideEvents SelectedIndexChanged="function(s, e) { OnCountryChanged(grid, s); }"&gt;
                &lt;/ClientSideEvents&gt;
            &lt;/PropertiesComboBox&gt;
        &lt;/dx:BootstrapGridViewDataComboBoxColumn&gt;
        &lt;dx:BootstrapGridViewDataComboBoxColumn FieldName="City" VisibleIndex="2"&gt;
            &lt;PropertiesComboBox EnableSynchronization="False" IncrementalFilteringMode="StartsWith" &gt;
                &lt;ClientSideEvents EndCallback="function(s, e) { OnCityEndCallback(grid); }"/&gt;
            &lt;/PropertiesComboBox&gt;
        &lt;/dx:BootstrapGridViewDataComboBoxColumn&gt;
        ...
    &lt;/Columns&gt;
&lt;/dx:BootstrapGridView&gt;
&lt;demo:DemoDataSource runat="server" ID="DemoDataSource5" DataSourceID="DataSource4"&gt;
&lt;/demo:DemoDataSource&gt;
&lt;ef:EntityDataSource runat="server" ID="EntityDataSource1"
    ContextTypeName="NorthwindContext"
    EnableDelete="True" EnableInsert="True" EnableUpdate="True"
    EntitySetName="Customers"&gt;
&lt;/ef:EntityDataSource&gt;
&lt;ef:EntityDataSource ID="EntityDataSource2" runat="server" ContextTypeName="WorldCitiesContext" 
    EntitySetName="Countries" OrderBy="it.CountryName"&gt;&lt;/ef:EntityDataSource&gt;</CodeASPX>
<CodeJS>var lastCountry = null;
function OnCountryChanged(grid, cmbCountry) {
    if (grid.GetEditor("City").InCallback() )
        lastCountry = cmbCountry.GetValue().toString();
    else 
        grid.GetEditor("City").PerformCallback(cmbCountry.GetValue().toString());
}
function OnCityEndCallback(grid){
    if (lastCountry){
        grid.GetEditor("City").PerformCallback(lastCountry);
        lastCountry = null;
    }
}</CodeJS>
<CodeCS>protected void grid_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e) {
    ASPxGridView grid = (ASPxGridView)sender;
    if(!grid.IsEditing || e.Column.FieldName != "City")
        return;
    if(e.KeyValue == DBNull.Value || e.KeyValue == null)
        return;
    object val = grid.GetRowValuesByKeyValue(e.KeyValue, "Country");
    if(val == DBNull.Value)
        return;
    string country = (string)val;
    ASPxComboBox combo = e.Editor as ASPxComboBox;
    FillCityCombo(combo, country);
    combo.Callback += new CallbackEventHandlerBase(cmbCity_OnCallback);
}
protected void FillCityCombo(ASPxComboBox cmb, string country) {
    if(string.IsNullOrEmpty(country))
        return;
    List<string> cities = GetCities(country);
    cmb.Items.Clear();
    foreach(string city in cities)
        cmb.Items.Add(city);
}
List<string> GetCities(string country) {
    using(var context = new WorldCitiesContext())
        return context.Cities.Where(c => c.Country.CountryName == country).OrderBy(c => c.CityName).Select(c => c.CityName).ToList();
}
void cmbCity_OnCallback(object source, CallbackEventArgsBase e) {
    FillCityCombo(source as ASPxComboBox, e.Parameter);
}</CodeCS>
    </demo:DemoItem>
    </div>
    <div class="col-md-3">
        <div class="affix" id="page-navigation">
        </div>
    </div>
</asp:Content>
