<%@ Page Language="C#" MasterPageFile="~/Shared/DemoLayout.master" AutoEventWireup="true" CodeFile="Export.aspx.cs" Inherits="GridView_Export" %>
<asp:Content ID="PageTitleHolder" ContentPlaceHolderID="PageTitle" runat="server">
    Bootstrap GridView Export Demo | DevExpress Bootstrap controls for ASP.NET
</asp:Content>
<asp:Content ID="PageHeaderHolder" ContentPlaceHolderID="PageHeader" runat="server">
    DevExpress Bootstrap Grid View
</asp:Content>
<asp:Content ID="ContentHolder" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-9">
    <demo:DemoItem runat="server" Title="Exporting to PDF, XLS, XLSX, CSV and RTF">
        <Description>
            <p>The Grid View Exporter control allows you to export Grid View data with ease. Data can be exported to a file or stream in the following formats:</p>
            <ul>
                <li><strong>PDF</strong> (WritePdf, WritePdfToResponse)</li>
                <li><strong>XLS</strong> (WriteXls, WriteXlsToResponse)</li>
                <li><strong>XLSX</strong> (WriteXlsx, WriteXlsxToResponse)</li>
                <li><strong>RTF</strong> (WriteRtf, WriteRtfToResponse)</li>
                <li><strong>CSV</strong> (WriteCsv, WriteCsvToResponse)</li>
            </ul>
            <p>Note that in this demo, export to table formats (XLS, XLSX, and CSV) is performed in the WYSIWYG (What You See Is What You Get) mode. Therefore, the table formatting, e.g., grouping, is lost and grid summaries are converted to strings. However, you can maintain such information by exporting grid data in the data-aware mode.</p>
        </Description>
        <Example>
            <div class="form-inline">
                <div class="form-group">
                    <b>Export To:</b>
                    <div class="btn-group" role="group" aria-label="Export Formats">
                        <dx:BootstrapButton runat="server" Text="PDF" ID="ButtonPDF1" OnClick="ButtonPDF1_Click">
                            <CssClasses Icon="fa fa-file-pdf-o" />
                        </dx:BootstrapButton>
                        <dx:BootstrapButton runat="server" Text="XLS" ID="ButtonXLS1" OnClick="ButtonXLS1_Click">
                            <CssClasses Icon="fa fa-file-excel-o" />
                        </dx:BootstrapButton>
                        <dx:BootstrapButton runat="server" Text="XLSX" ID="ButtonXLSX1" OnClick="ButtonXLSX1_Click">
                            <CssClasses Icon="fa fa-file-excel-o" />
                        </dx:BootstrapButton>
                        <dx:BootstrapButton runat="server" Text="CSV" ID="ButtonCSV1" OnClick="ButtonCSV1_Click">
                            <CssClasses Icon="fa fa-file-text-o" />
                        </dx:BootstrapButton>
                        <dx:BootstrapButton runat="server" Text="RTF" ID="ButtonRTF1" OnClick="ButtonRTF1_Click">
                            <CssClasses Icon="fa fa-file-word-o" />
                        </dx:BootstrapButton>
                    </div>
                </div>
            </div>
            <br />
            <dx:ASPxGridViewExporter ID="GridViewExporter1" runat="server" GridViewID="GridView1"></dx:ASPxGridViewExporter>
            <dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="DataSource1" AutoGenerateColumns="False">
                <CssClassesPager PageNumber="hidden-xs" Ellipsis="hidden-xs" Summary="hidden-md hidden-sm hidden-xs" />
                <Settings ShowGroupPanel="True" />
                <SettingsPager NumericButtonCount="7"></SettingsPager>
                <Columns>
                    <dx:BootstrapGridViewDataColumn FieldName="ProductName" />
                    <dx:BootstrapGridViewDataColumn FieldName="Category" />
                    <dx:BootstrapGridViewDataColumn FieldName="Supplier" />
                    <dx:BootstrapGridViewDataColumn FieldName="QuantityPerUnit" />
                    <dx:BootstrapGridViewDataTextColumn FieldName="UnitPrice">
                        <PropertiesTextEdit DisplayFormatString="c" />
                    </dx:BootstrapGridViewDataTextColumn>
                </Columns>
            </dx:BootstrapGridView>
            <ef:EntityDataSource runat="server" ID="DataSource1" ContextTypeName="NorthwindContext" 
                CommandText="SELECT p.ProductName, c.CategoryName AS Category, p.QuantityPerUnit, p.UnitPrice, s.CompanyName AS Supplier FROM Products AS p INNER JOIN Categories AS c ON p.CategoryID = c.CategoryID INNER JOIN Suppliers AS s ON s.SupplierID = p.SupplierID" />
        </Example>
        <CodeASPX>&lt;dx:ASPxGridViewExporter ID="GridViewExporter1" runat="server" GridViewID="GridView1"&gt;&lt;/dx:ASPxGridViewExporter&gt;
            
&lt;dx:BootstrapGridView ID="GridView1" runat="server" DataSourceID="DataSource1" AutoGenerateColumns="False"&gt;
    &lt;Settings ShowGroupPanel="True" /&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="ProductName" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Category" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="Supplier" /&gt;
        &lt;dx:BootstrapGridViewDataColumn FieldName="QuantityPerUnit" /&gt;
        &lt;dx:BootstrapGridViewDataTextColumn FieldName="UnitPrice"&gt;
            &lt;PropertiesTextEdit DisplayFormatString="c" /&gt;
        &lt;/dx:BootstrapGridViewDataTextColumn&gt;
    &lt;/Columns&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
        <CodeCS>protected void ButtonPDF1_Click(object sender, EventArgs e) {
    GridViewExporter1.WritePdfToResponse();
}
protected void ButtonXLS1_Click(object sender, EventArgs e) {
    GridViewExporter1.WriteXlsToResponse(new XlsExportOptionsEx { ExportType = ExportType.WYSIWYG });
}
protected void ButtonXLSX1_Click(object sender, EventArgs e) {
    GridViewExporter1.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
}
protected void ButtonCSV1_Click(object sender, EventArgs e) {
    GridViewExporter1.WriteCsvToResponse(new CsvExportOptionsEx() { ExportType = ExportType.WYSIWYG });
}
protected void ButtonRTF1_Click(object sender, EventArgs e) {
    GridViewExporter1.WriteRtfToResponse();
}</CodeCS>
    </demo:DemoItem>
    <demo:DemoItem runat="server" Title="Data Aware Export">
    <Description>
        <p>The Grid View Exporter can export data to XLS and XLSX formats in the data-aware mode. In this mode, the DevExpress Export Engine maintains data grouping layout and automatically transforms summary items to corresponding Excel functions.</p>
    </Description>
    <Example>
        <div class="form-inline">
            <div class="form-group">
                <b>Export To:</b>
                <div class="btn-group" role="group" aria-label="...">
                    <dx:BootstrapButton runat="server" Text="XLS" ID="ButtonXLS2" OnClick="ButtonXLS2_Click">
                        <CssClasses Icon="fa fa-file-excel-o" />
                    </dx:BootstrapButton>
                    <dx:BootstrapButton runat="server" Text="XLSX" ID="ButtonXLSX2" OnClick="ButtonXLSX2_Click">
                        <CssClasses Icon="fa fa-file-excel-o" />
                    </dx:BootstrapButton>
                    <dx:BootstrapButton runat="server" Text="CSV" ID="ButtonCSV2" OnClick="ButtonCSV2_Click">
                        <CssClasses Icon="fa fa-file-text-o" />
                    </dx:BootstrapButton>
                </div>
            </div>
        </div>
        <br />
        <dx:BootstrapGridView ID="GridView2" runat="server" DataSourceID="DataSource2" AutoGenerateColumns="True">
            <CssClassesPager PageNumber="hidden-xs" Ellipsis="hidden-xs" Summary="hidden-md hidden-sm hidden-xs" />
            <Columns>
                <dx:BootstrapGridViewDataTextColumn FieldName="OrderID" />
                <dx:BootstrapGridViewDataDateColumn FieldName="OrderDate" />
                <dx:BootstrapGridViewDataTextColumn FieldName="CompanyName" />
                <dx:BootstrapGridViewDataTextColumn FieldName="ShippedDate" />
                <dx:BootstrapGridViewDataTextColumn FieldName="ShipCountry" GroupIndex="0" />
                <dx:BootstrapGridViewDataTextColumn FieldName="ShipCity" />
                <dx:BootstrapGridViewDataTextColumn FieldName="SaleAmount">
                    <PropertiesTextEdit DisplayFormatString="c" />
                </dx:BootstrapGridViewDataTextColumn>
            </Columns>
            <Settings ShowGroupPanel="True" ShowFooter="True" ShowGroupFooter="VisibleIfExpanded" />
            <SettingsPager PageSize="12" NumericButtonCount="7"></SettingsPager>
            <GroupSummary>
                <dx:ASPxSummaryItem FieldName="OrderID" SummaryType="Count" ShowInGroupFooterColumn="OrderDate" />
                <dx:ASPxSummaryItem FieldName="SaleAmount" SummaryType="Sum" ShowInGroupFooterColumn="SaleAmount" />
            </GroupSummary>
            <TotalSummary>
                <dx:ASPxSummaryItem FieldName="OrderID" SummaryType="Count" ShowInColumn="OrderDate" />
                <dx:ASPxSummaryItem FieldName="SaleAmount" SummaryType="Sum" />
            </TotalSummary>
        </dx:BootstrapGridView>
        <dx:ASPxGridViewExporter ID="GridViewExporter2" runat="server" GridViewID="GridView2"></dx:ASPxGridViewExporter>
        <ef:EntityDataSource runat="server" ID="DataSource2" ContextTypeName="NorthwindContext" 
            CommandText="SELECT s.SaleAmount, s.CompanyName, o.OrderDate, o.OrderID, o.ShippedDate, o.ShipCountry, o.ShipCity FROM Orders AS o INNER JOIN Sales_Totals_by_Amounts AS s ON o.OrderID = s.OrderID" />
    </Example>
    <CodeASPX>&lt;dx:ASPxGridViewExporter ID="GridViewExporter2" runat="server" GridViewID="GridView2"&gt;&lt;/dx:ASPxGridViewExporter&gt;
        
&lt;dx:BootstrapGridView ID="GridView2" runat="server" DataSourceID="DataSource2" AutoGenerateColumns="True"&gt;
	&lt;Columns&gt;
		&lt;dx:BootstrapGridViewDataTextColumn FieldName="OrderID" /&gt;
		&lt;dx:BootstrapGridViewDataDateColumn FieldName="OrderDate" /&gt;
		&lt;dx:BootstrapGridViewDataTextColumn FieldName="CompanyName" /&gt;
		&lt;dx:BootstrapGridViewDataTextColumn FieldName="ShippedDate" /&gt;
		&lt;dx:BootstrapGridViewDataTextColumn FieldName="ShipCountry" GroupIndex="0" /&gt;
		&lt;dx:BootstrapGridViewDataTextColumn FieldName="ShipCity" /&gt;
		&lt;dx:BootstrapGridViewDataTextColumn FieldName="SaleAmount"&gt;
			&lt;PropertiesTextEdit DisplayFormatString="c" /&gt;
		&lt;/dx:BootstrapGridViewDataTextColumn&gt;
	&lt;/Columns&gt;
	&lt;Settings ShowGroupPanel="True" ShowFooter="True" ShowGroupFooter="VisibleIfExpanded" /&gt;
	&lt;GroupSummary&gt;
		&lt;dx:ASPxSummaryItem FieldName="OrderID" SummaryType="Count" ShowInGroupFooterColumn="OrderDate" /&gt;
		&lt;dx:ASPxSummaryItem FieldName="SaleAmount" SummaryType="Sum" ShowInGroupFooterColumn="SaleAmount" /&gt;
	&lt;/GroupSummary&gt;
	&lt;TotalSummary&gt;
		&lt;dx:ASPxSummaryItem FieldName="OrderID" SummaryType="Count" ShowInColumn="OrderDate" /&gt;
		&lt;dx:ASPxSummaryItem FieldName="SaleAmount" SummaryType="Sum" /&gt;
	&lt;/TotalSummary&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
        <CodeCS>protected void ButtonXLS2_Click(object sender, EventArgs e) {
    GridViewExporter2.WriteXlsToResponse(new XlsExportOptionsEx() { ExportType = ExportType.DataAware });
}
protected void ButtonXLSX2_Click(object sender, EventArgs e) {
    GridViewExporter2.WriteXlsxToResponse(new XlsxExportOptionsEx() { ExportType = ExportType.DataAware });
}
protected void ButtonCSV2_Click(object sender, EventArgs e) {
    GridViewExporter2.WriteCsvToResponse(new CsvExportOptionsEx() { ExportType = ExportType.DataAware });
}</CodeCS>
    </demo:DemoItem>
    <demo:DemoItem runat="server" Title="Export Selected Records">
        <Description>
            <p>To export only the currently selected grid rows, set the Grid View Exporter’s <strong>ExportSelectedRowsOnly</strong> property to <strong>true</strong>.</p>
        </Description>
        <Example>
            <div class="form-inline">
                <div class="form-group">
                    <b>Export To:</b>
                    <div class="btn-group" role="group" aria-label="...">
                        <dx:BootstrapButton runat="server" Text="PDF" ID="ButtonPDF3" OnClick="ButtonPDF3_Click">
	                        <CssClasses Icon="fa fa-file-pdf-o" />
                        </dx:BootstrapButton>
                        <dx:BootstrapButton runat="server" Text="XLS" ID="ButtonXLS3" OnClick="ButtonXLS3_Click">
	                        <CssClasses Icon="fa fa-file-excel-o" />
                        </dx:BootstrapButton>
                        <dx:BootstrapButton runat="server" Text="XLSX" ID="ButtonXLSX3" OnClick="ButtonXLSX3_Click">
	                        <CssClasses Icon="fa fa-file-excel-o" />
                        </dx:BootstrapButton>
                        <dx:BootstrapButton runat="server" Text="CSV" ID="ButtonCSV3" OnClick="ButtonCSV3_Click">
	                        <CssClasses Icon="fa fa-file-text-o" />
                        </dx:BootstrapButton>
                        <dx:BootstrapButton runat="server" Text="RTF" ID="ButtonRTF3" OnClick="ButtonRTF3_Click">
	                        <CssClasses Icon="fa fa-file-word-o" />
                        </dx:BootstrapButton>
                    </div>
                </div>
            </div>
            <br />
            <dx:ASPxGridViewExporter ID="GridViewExporter3" runat="server" GridViewID="GridView3" ExportSelectedRowsOnly="true"></dx:ASPxGridViewExporter>
            
            <dx:BootstrapGridView ID="GridView3" runat="server" DataSourceID="DataSource3" AutoGenerateColumns="False" KeyFieldName="ProductID">
                <CssClassesPager PageNumber="hidden-xs" Ellipsis="hidden-xs" Summary="hidden-md hidden-sm hidden-xs" />
                <Settings ShowGroupPanel="True" />
                <SettingsPager NumericButtonCount="7"></SettingsPager>
                <Columns>
                    <dx:BootstrapGridViewCommandColumn SelectAllCheckboxMode="AllPages" ShowSelectCheckbox="true"></dx:BootstrapGridViewCommandColumn>
                    <dx:BootstrapGridViewDataColumn FieldName="ProductName" />
                    <dx:BootstrapGridViewDataColumn FieldName="Category" />
                    <dx:BootstrapGridViewDataColumn FieldName="Supplier" />
                    <dx:BootstrapGridViewDataColumn FieldName="QuantityPerUnit" />
                    <dx:BootstrapGridViewDataTextColumn FieldName="UnitPrice">
                        <PropertiesTextEdit DisplayFormatString="c" />
                    </dx:BootstrapGridViewDataTextColumn>
                </Columns>
            </dx:BootstrapGridView>
            <ef:EntityDataSource runat="server" ID="DataSource3" ContextTypeName="NorthwindContext" 
                CommandText="SELECT p.ProductName, p.ProductID, c.CategoryName AS Category, p.QuantityPerUnit, p.UnitPrice, s.CompanyName AS Supplier FROM Products AS p INNER JOIN Categories AS c ON p.CategoryID = c.CategoryID INNER JOIN Suppliers AS s ON s.SupplierID = p.SupplierID" />
        </Example>
        <CodeASPX>&lt;dx:ASPxGridViewExporter ID="GridViewExporter3" runat="server" GridViewID="GridView3" ExportSelectedRowsOnly="true"&gt;&lt;/dx:ASPxGridViewExporter&gt;
            
&lt;dx:BootstrapGridView ID="GridView3" runat="server" DataSourceID="DataSource3" AutoGenerateColumns="False" KeyFieldName="ProductID"&gt;
    &lt;Columns&gt;
        &lt;dx:BootstrapGridViewCommandColumn SelectAllCheckboxMode="AllPages" ShowSelectCheckbox="true"&gt;&lt;/dx:BootstrapGridViewCommandColumn&gt;
        ...
    &lt;/Columns&gt;
    &lt;Settings ShowGroupPanel="True" /&gt;
&lt;/dx:BootstrapGridView&gt;</CodeASPX>
        <CodeCS>protected void ButtonRTF3_Click(object sender, EventArgs e) {
    GridViewExporter3.WriteRtfToResponse();
}
protected void ButtonCSV3_Click(object sender, EventArgs e) {
    GridViewExporter3.WriteCsvToResponse(new CsvExportOptionsEx() { ExportType = ExportType.WYSIWYG });
}
protected void ButtonXLSX3_Click(object sender, EventArgs e) {
    GridViewExporter3.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
}
protected void ButtonXLS3_Click(object sender, EventArgs e) {
    GridViewExporter3.WriteXlsToResponse(new XlsExportOptionsEx { ExportType = ExportType.WYSIWYG });
}
protected void ButtonPDF3_Click(object sender, EventArgs e) {
    GridViewExporter3.WritePdfToResponse();
}</CodeCS>
    </demo:DemoItem>
    </div>
    <div class="col-md-3">
        <div class="affix page-nav" id="page-navigation">
        </div>
    </div>
</asp:Content>
