<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Templates.aspx.cs" Inherits="GridView_Templates" MasterPageFile="~/Shared/DemoLayout.master" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap GridView Templates Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Grid View
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-9">
        <demo:DemoItem runat="server" Title="Cell Template">
            <Description>
                <p>The Grid View control allows you to customize layouts of its visual elements using the template technology. This demo demonstrates the use of a template to display cells within the 'Details' column. The template contains a link labeled 'More Info'. Clicking this link displays a popup window containing additional information about an employee.</p>
            </Description>
            <Example>
                <script type="text/javascript">
                    function initMoreButton(s, e) {
                        $(s.GetMainElement()).find(".more-info").click(function() {
                            var $btn = $(this);
                            callback1.PerformCallback($btn.attr("data-key"), function(res) {
                                $btn.replaceWith(res);
                            });
                        });
                    }
                </script>
                <dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="DataSource1" KeyFieldName="EmployeeID">
                    <CssClasses Table="grid-table-with-template" />
                    <Columns>
                        <dx:BootstrapGridViewDataColumn FieldName="FirstName" />
                        <dx:BootstrapGridViewDataColumn FieldName="LastName" />
                        <dx:BootstrapGridViewDataColumn FieldName="Title" />
                        <dx:BootstrapGridViewDataColumn FieldName="BirthDate" />
                        <dx:BootstrapGridViewDataColumn FieldName="HireDate" />
                        <dx:BootstrapGridViewDataColumn Caption="Details">
                            <DataItemTemplate>
                                <button type="button" class="btn btn-link more-info" data-key="<%# Container.KeyValue %>">More Info...</button>
                            </DataItemTemplate>
                        </dx:BootstrapGridViewDataColumn>
                    </Columns>
                    <ClientSideEvents Init="initMoreButton" EndCallback="initMoreButton" />
                    <SettingsPager Mode="ShowAllRecords" />
                </dx:BootstrapGridView>
                <dx:ASPxCallback runat="server" ID="Callback1" ClientInstanceName="callback1" OnCallback="Callback1_Callback"></dx:ASPxCallback>
                <ef:EntityDataSource runat="server" ID="DataSource1" ContextTypeName="NorthwindContext" EntitySetName="Employees" Where="it.Photo IS NOT NULL" />
            </Example>
            <CodeASPX>&lt;dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="EmployeesDataSource" KeyFieldName="EmployeeID"&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="FirstName" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="LastName" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Title" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="BirthDate" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="HireDate" /&gt;
        &lt;dx:BootstrapGridViewDataColumn Caption="Details"&gt;
            &lt;DataItemTemplate&gt;
                &lt;button type="button" class="btn btn-link more-info" data-key="&lt;%# Container.KeyValue %&gt;"&gt;More Info...&lt;/button&gt;
            &lt;/DataItemTemplate&gt;
        &lt;/dx:BootstrapGridViewDataColumn&gt;
    &lt;/Columns&gt;
    &lt;ClientSideEvents Init="initMore" EndCallback="initMore" /&gt;
&lt;/dx:BootstrapGridView&gt;
&lt;dx:ASPxCallback runat="server" ID="Callback1" ClientInstanceName="callback1" OnCallback="Callback1_Callback"&gt;&lt;/dx:ASPxCallback&gt;</CodeASPX>
            <CodeCS>protected void Callback1_Callback(object source, DevExpress.Web.CallbackEventArgs e) {
    e.Result = GetEmployeeNotes(Convert.ToInt32(e.Parameter));
}</CodeCS>
            <CodeJS>function initMore(s, e) {
    $(s.GetMainElement()).find(".more-info").click(function() {
        var $btn = $(this);
        callback1.PerformCallback($btn.attr("data-key"), function(res) {
            $btn.replaceWith(res);
        });
    });
}</CodeJS>
        </demo:DemoItem>
        <demo:DemoItem runat="server" Title="Preview Template">
            <Description>
                <p>Preview Rows are used to display large memo fields or custom data across all the columns within a Grid View. This demo illustrates how to create a template to display images along with textual content within preview rows.</p>
            </Description>
            <Example>
                <dx:BootstrapGridView ID="GridView2" runat="server" DataSourceID="DataSource2" KeyFieldName="EmployeeID" PreviewFieldName="Notes">
                    <Columns>
                        <dx:BootstrapGridViewDataColumn FieldName="FirstName" />
                        <dx:BootstrapGridViewDataColumn FieldName="LastName" />
                        <dx:BootstrapGridViewDataColumn FieldName="BirthDate" />
                        <dx:BootstrapGridViewDataColumn FieldName="Title" />
                        <dx:BootstrapGridViewDataColumn FieldName="HireDate" />
                    </Columns>
                    <Templates>
                        <PreviewRow>
                            <div class="media">
                              <div class="media-left">
                                <dx:ASPxBinaryImage ID="ASPxBinaryImage2" runat="server" Value='<%# Eval("Photo") %>' />
                              </div>
                              <div class="media-body">
                                <asp:Literal runat="server" Text="<%# Container.Text %>"></asp:Literal>
                              </div>
                            </div>
                        </PreviewRow>
                    </Templates>
                    <Settings ShowPreview="true" />
                    <SettingsPager PageSize="3"></SettingsPager>
                </dx:BootstrapGridView>
                
                <ef:EntityDataSource runat="server" ID="DataSource2" ContextTypeName="NorthwindContext" EntitySetName="Employees" Where="it.Photo IS NOT NULL" />
            </Example>
            <CodeASPX>&lt;dx:BootstrapGridView ID="GridView2" runat="server" DataSourceID="DataSource2" KeyFieldName="EmployeeID" PreviewFieldName="Notes"&gt;
    &lt;Settings ShowPreview="true" /&gt;
    &lt;Columns&gt;
        ...
    &lt;/Columns&gt;
    &lt;Templates&gt;
        &lt;PreviewRow&gt;
            &lt;div class="media"&gt;
                &lt;div class="media-left"&gt;
                    &lt;dx:ASPxBinaryImage ID="ASPxBinaryImage2" runat="server" Value='&lt;%# Eval("Photo") %&gt;' /&gt;
                &lt;/div&gt;
                &lt;div class="media-body"&gt;
                    &lt;asp:Literal runat="server" Text="&lt;%# Container.Text %&gt;"&gt;&lt;/asp:Literal&gt;
                &lt;/div&gt;
            &lt;/div&gt;
        &lt;/PreviewRow&gt;
    &lt;/Templates&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
        </demo:DemoItem>
    </div>
    <div class="col-md-3">
        <div class="affix page-nav" id="page-navigation">
        </div>
    </div>
</asp:Content>
