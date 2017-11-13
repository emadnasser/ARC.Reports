namespace DevExpress.XtraCharts.Demos.ChartElements {
    partial class HorizontalPanesDemo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HorizontalPanesDemo));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.XYDiagramPane xyDiagramPane1 = new DevExpress.XtraCharts.XYDiagramPane();
            DevExpress.XtraCharts.SecondaryAxisX secondaryAxisX1 = new DevExpress.XtraCharts.SecondaryAxisX();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.oleDbDataAdapterProducts = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapterCategories = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.dS31 = new DevExpress.XtraCharts.Demos.DS3();
            this.lbLeftCategory = new DevExpress.XtraEditors.LabelControl();
            this.cbLeftCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbRightCategory = new DevExpress.XtraEditors.LabelControl();
            this.cbRightCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLeftCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRightCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbRightCategory);
            this.panel.Controls.Add(this.cbRightCategory);
            this.panel.Controls.Add(this.lbLeftCategory);
            this.panel.Controls.Add(this.cbLeftCategory);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.cbLeftCategory, 0);
            this.panel.Controls.SetChildIndex(this.lbLeftCategory, 0);
            this.panel.Controls.SetChildIndex(this.cbRightCategory, 0);
            this.panel.Controls.SetChildIndex(this.lbRightCategory, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 2;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // oleDbDataAdapterProducts
            // 
            this.oleDbDataAdapterProducts.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapterProducts.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
                        new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
                        new System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"),
                        new System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"),
                        new System.Data.Common.DataColumnMapping("Discontinued", "Discontinued"),
                        new System.Data.Common.DataColumnMapping("EAN13", "EAN13")})});
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT CategoryID, Discontinued, EAN13, ProductID, ProductName, QuantityPerUnit, " +
    "ReorderLevel, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            //
            // oleDbDataAdapterCategories
            // 
            this.oleDbDataAdapterCategories.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapterCategories.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Categories", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Picture", "Picture")})});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText");
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // chart
            // 
            this.chart.CrosshairOptions.ShowArgumentLine = false;
            this.chart.CrosshairOptions.ShowValueLine = true;
            this.chart.CrosshairOptions.SnapMode = DevExpress.XtraCharts.CrosshairSnapMode.NearestValue;
            this.chart.DataAdapter = this.oleDbDataAdapterProducts;
            this.chart.DataBindings = null;
            this.chart.DataSource = this.dS31;
            xyDiagram1.AxisX.Label.Angle = -90;
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.Title.Text = "Price, USD";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1;0";
            xyDiagram1.PaneLayoutDirection = DevExpress.XtraCharts.PaneLayoutDirection.Horizontal;
            xyDiagramPane1.Name = "Pane 1";
            xyDiagramPane1.PaneID = 0;
            xyDiagram1.Panes.AddRange(new DevExpress.XtraCharts.XYDiagramPane[] {
            xyDiagramPane1});
            secondaryAxisX1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near;
            secondaryAxisX1.AxisID = 0;
            secondaryAxisX1.Label.Angle = -90;
            secondaryAxisX1.Name = "secondaryAxisX1";
            secondaryAxisX1.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            secondaryAxisX1.VisibleInPanesSerializable = "0";
            xyDiagram1.SecondaryAxesX.AddRange(new DevExpress.XtraCharts.SecondaryAxisX[] {
            secondaryAxisX1});
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "Products.ProductName";
            series1.Name = "Series 1";
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series1.ValueDataMembersSerializable = "Products.UnitPrice";
            series2.ArgumentDataMember = "Products.ProductName";
            series2.Name = "Series 2";
            series2.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series2.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series2.ValueDataMembersSerializable = "Products.UnitPrice";
            sideBySideBarSeriesView1.AxisXName = "secondaryAxisX1";
            sideBySideBarSeriesView1.PaneName = "Pane 1";
            series2.View = sideBySideBarSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 2;
            this.chart.TabStop = false;
            chartTitle1.Text = "Northwind Traders: Comparative Categories Chart";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // dS31
            // 
            this.dS31.DataSetName = "DS3";
            this.dS31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbLeftCategory
            // 
            this.lbLeftCategory.Location = new System.Drawing.Point(12, 12);
            this.lbLeftCategory.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.lbLeftCategory.Name = "lbLeftCategory";
            this.lbLeftCategory.Size = new System.Drawing.Size(69, 13);
            this.lbLeftCategory.TabIndex = 17;
            this.lbLeftCategory.Text = "Left category:";
            // 
            // cbLeftCategory
            // 
            this.cbLeftCategory.EditValue = "";
            this.cbLeftCategory.Location = new System.Drawing.Point(84, 9);
            this.cbLeftCategory.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.cbLeftCategory.Name = "cbLeftCategory";
            this.cbLeftCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLeftCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbLeftCategory.Size = new System.Drawing.Size(100, 20);
            this.cbLeftCategory.TabIndex = 0;
            this.cbLeftCategory.SelectedIndexChanged += new System.EventHandler(this.cbLeftCategory_SelectedIndexChanged);
            // 
            // lbRightCategory
            // 
            this.lbRightCategory.Location = new System.Drawing.Point(204, 12);
            this.lbRightCategory.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.lbRightCategory.Name = "lbRightCategory";
            this.lbRightCategory.Size = new System.Drawing.Size(75, 13);
            this.lbRightCategory.TabIndex = 19;
            this.lbRightCategory.Text = "Right category:";
            // 
            // cbRightCategory
            // 
            this.cbRightCategory.EditValue = "";
            this.cbRightCategory.Location = new System.Drawing.Point(282, 9);
            this.cbRightCategory.Margin = new System.Windows.Forms.Padding(3, 0, 10, 10);
            this.cbRightCategory.Name = "cbRightCategory";
            this.cbRightCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRightCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbRightCategory.Size = new System.Drawing.Size(100, 20);
            this.cbRightCategory.TabIndex = 1;
            this.cbRightCategory.SelectedIndexChanged += new System.EventHandler(this.cbRightCategory_SelectedIndexChanged);
            // 
            // HorizontalPanesDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "HorizontalPanesDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLeftCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRightCategory.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapterProducts;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapterCategories;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private DS3 dS31;
        private DevExpress.XtraEditors.LabelControl lbRightCategory;
        private DevExpress.XtraEditors.ComboBoxEdit cbRightCategory;
        private DevExpress.XtraEditors.LabelControl lbLeftCategory;
        private DevExpress.XtraEditors.ComboBoxEdit cbLeftCategory;
    }
}
