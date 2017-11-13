<%@ Page Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="LargeDataBase.aspx.cs" Inherits="GridView_LargeDataBase" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap GridView Binding to Large DataBase Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Grid View
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <demo:DemoItem runat="server" Title="Binding To Large Database (Server Mode)" ID="BindingToDatabaseDemo">
        <Description>
            <p>The Grid View control supports binding to data in the server mode using the <strong>EntityServerModeDataSource</strong> component. In this mode, the Grid View loads only the minimum amount of data required for display on screen and delegates all data processing (such as grouping and sorting) to the database server. This technique significantly reduces the application's response time when working with large data sets.</p>
        </Description>
        <CreateDataBaseControl>
            <demo:CreateDatabaseControl runat="server" ID="CreateDatabaseControl" TableKey="GeneratedEmailTable" />
        </CreateDataBaseControl>
        <Example>
            <script type="text/javascript">
                var gridViewSW;
                function onGridViewInit(s, e) {
                    s.Refresh();
                }
                function onGridViewBeginCallback(s, e) {
                    gridViewSW = new Date();
                    var container = $(s.GetMainElement().parentNode);
                    container.find(".alert > .perf-cmd-name").text(e.command);
                    container.find(".alert > b").text("working...");
                }
                function onGridViewEndCallback(s, e) {
                    var container = $(s.GetMainElement().parentNode);
                    container.find(".alert > b").text(new Date() - gridViewSW + "ms");
                }
            </script>
            <div class="alert alert-success" role="alert"><span class="perf-cmd-name"></span>: <b>100ms</b></div>
            <dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="EntityServerModeDataSource" KeyFieldName="ID" AutoGenerateColumns="False"
                OnCustomColumnDisplayText="GridView1_CustomColumnDisplayText" OnSummaryDisplayText="GridView1_SummaryDisplayText">
                <CssClassesPager PageNumber="hidden-md hidden-sm hidden-xs" Ellipsis="hidden-md hidden-sm hidden-xs" Summary="hidden-sm hidden-xs" />
                <Columns>
                    <dx:BootstrapGridViewDataDateColumn FieldName="Sent">
                        <Settings AllowHeaderFilter="True" />
                    </dx:BootstrapGridViewDataDateColumn>
                    <dx:BootstrapGridViewDataTextColumn FieldName="From">
                        <Settings AllowHeaderFilter="True" />
                    </dx:BootstrapGridViewDataTextColumn>
                    <dx:BootstrapGridViewDataTextColumn FieldName="Subject" />
                    <dx:BootstrapGridViewDataCheckColumn Caption="Has Attachments" FieldName="HasAttachment">
                        <Settings AllowHeaderFilter="True" />
                    </dx:BootstrapGridViewDataCheckColumn>
                </Columns>
                <Settings ShowGroupPanel="True" ShowFooter="True" />
                <SettingsPager NumericButtonCount="7">
                    <PageSizeItemSettings Visible="true" Items="10, 20, 50" />
                </SettingsPager>
                <SettingsDataSecurity AllowInsert="false" AllowEdit="false" AllowDelete="false" />
                <TotalSummary>
                    <dx:ASPxSummaryItem FieldName="Size" SummaryType="Sum" />
                </TotalSummary>
                <GroupSummary>
                    <dx:ASPxSummaryItem SummaryType="Count" />
                </GroupSummary>
                <ClientSideEvents Init="onGridViewInit" BeginCallback="onGridViewBeginCallback" EndCallback="onGridViewEndCallback" />
            </dx:BootstrapGridView>
            <dx:EntityServerModeDataSource ID="EntityServerModeDataSource" runat="server" ContextTypeName="LargeDatabaseContext"
                TableName="Emails" />
        </Example>
        <CodeASPX>&lt;dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="EntityServerModeDataSource" KeyFieldName="ID" AutoGenerateColumns="False"&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewDataDateColumn FieldName="Sent"&gt;
            &lt;Settings AllowHeaderFilter="True" /&gt;
        &lt;/dx:BootstrapGridViewDataDateColumn&gt;
        &lt;dx:BootstrapGridViewDataTextColumn FieldName="From"&gt;
            &lt;Settings AllowHeaderFilter="True" /&gt;
        &lt;/dx:BootstrapGridViewDataTextColumn&gt;
        &lt;dx:BootstrapGridViewDataTextColumn FieldName="Subject" /&gt;
        &lt;dx:BootstrapGridViewDataCheckColumn Caption="Has Attachments" FieldName="HasAttachment"&gt;
            &lt;Settings AllowHeaderFilter="True" /&gt;
        &lt;/dx:BootstrapGridViewDataCheckColumn&gt;
    &lt;/Columns&gt;
    &lt;Settings ShowGroupPanel="True" ShowFooter="True" /&gt;
    &lt;SettingsPager&gt;
        &lt;PageSizeItemSettings Visible="true" Items="10, 20, 50" /&gt;
    &lt;/SettingsPager&gt;
    &lt;TotalSummary&gt;
        &lt;dx:ASPxSummaryItem FieldName="Size" SummaryType="Sum" /&gt;
    &lt;/TotalSummary&gt;
    &lt;GroupSummary&gt;
        &lt;dx:ASPxSummaryItem SummaryType="Count" /&gt;
    &lt;/GroupSummary&gt;
&lt;/dx:BootstrapGridView&gt;
&lt;dx:EntityServerModeDataSource ID="EntityServerModeDataSource" runat="server" ContextTypeName="LargeDatabaseContext" TableName="Emails" /&gt;</CodeASPX>
    </demo:DemoItem>
</asp:Content>
