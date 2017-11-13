namespace DevExpress.XtraCharts.Demos.Miscellaneous {
    partial class DrillDownDemo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrillDownDemo));
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.PieFlyInAnimation pieFlyInAnimation1 = new DevExpress.XtraCharts.PieFlyInAnimation();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.BarGrowUpAnimation barGrowUpAnimation1 = new DevExpress.XtraCharts.BarGrowUpAnimation();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.dS31 = new DevExpress.XtraCharts.Demos.DS3();
            this.oleDbDataAdapterCategories = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapterProducts = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.labelSummary1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxSummary = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelSummary2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxSummary.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelSummary2);
            this.panel.Controls.Add(this.labelSummary1);
            this.panel.Controls.Add(this.comboBoxSummary);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxSummary, 0);
            this.panel.Controls.SetChildIndex(this.labelSummary1, 0);
            this.panel.Controls.SetChildIndex(this.labelSummary2, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 3;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // dS31
            // 
            this.dS31.DataSetName = "DS3";
            this.dS31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // chart
            // 
            this.chart.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart.DataAdapter = this.oleDbDataAdapterProducts;
            this.chart.DataBindings = null;
            this.chart.DataSource = this.dS31.Products;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            this.chart.RefreshDataOnRepaint = true;
            this.chart.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point;
            series1.ArgumentDataMember = "CategoryName";
            series1.DataSource = this.dS31.Categories;
            pieSeriesLabel1.BackColor = System.Drawing.Color.Transparent;
            pieSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            pieSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside;
            pieSeriesLabel1.TextColor = System.Drawing.Color.Black;
            pieSeriesLabel1.TextPattern = "${V:F1}";
            series1.Label = pieSeriesLabel1;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Categories";
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series1.ToolTipSeriesPattern = "";
            series1.ValueDataMembersSerializable = "MinPrice";
            pieSeriesView1.Animation = pieFlyInAnimation1;
            pieSeriesView1.ExplodeMode = DevExpress.XtraCharts.PieExplodeMode.All;
            pieSeriesView1.HeightToWidthRatio = 0.7D;
            series1.View = pieSeriesView1;
            series2.ArgumentDataMember = "ProductName";
            series2.DataFilters.ClearAndAddRange(new DevExpress.XtraCharts.DataFilter[] {
            new DevExpress.XtraCharts.DataFilter("CategoryID", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, null)});
            series2.DataSource = this.dS31.Products;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series2.Name = "Products";
            series2.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series2.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series2.ValueDataMembersSerializable = "UnitPrice";
            barGrowUpAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000");
            sideBySideBarSeriesView1.Animation = barGrowUpAnimation1;
            series2.View = sideBySideBarSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle2.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle2.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.False;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Underline);
            chartTitle2.Text = "Back to the main view...";
            chartTitle2.TextColor = System.Drawing.Color.Blue;
            chartTitle2.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            this.chart.ToolTipOptions.ShowForPoints = false;
            // 
            // labelSummary1
            // 
            this.labelSummary1.Location = new System.Drawing.Point(12, 12);
            this.labelSummary1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.labelSummary1.Name = "labelSummary1";
            this.labelSummary1.Size = new System.Drawing.Size(26, 13);
            this.labelSummary1.TabIndex = 17;
            this.labelSummary1.Text = "Show";
            // 
            // comboBoxSummary
            // 
            this.comboBoxSummary.Location = new System.Drawing.Point(41, 9);
            this.comboBoxSummary.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.comboBoxSummary.Name = "comboBoxSummary";
            this.comboBoxSummary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxSummary.Properties.Items.AddRange(new object[] {
            "Min",
            "Max",
            "Average"});
            this.comboBoxSummary.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxSummary.Size = new System.Drawing.Size(90, 20);
            this.comboBoxSummary.TabIndex = 0;
            this.comboBoxSummary.SelectedIndexChanged += new System.EventHandler(this.comboBoxSummary_SelectedIndexChanged);
            // 
            // labelSummary2
            // 
            this.labelSummary2.Location = new System.Drawing.Point(137, 12);
            this.labelSummary2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.labelSummary2.Name = "labelSummary2";
            this.labelSummary2.Size = new System.Drawing.Size(151, 13);
            this.labelSummary2.TabIndex = 1;
            this.labelSummary2.Text = "product price in every category";
            // 
            // DrillDownDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "DrillDownDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxSummary.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DS3 dS31;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapterCategories;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapterProducts;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private DevExpress.XtraEditors.LabelControl labelSummary1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxSummary;
        private DevExpress.XtraEditors.LabelControl labelSummary2;
    }
}
