namespace DevExpress.XtraCharts.Demos.DataBinding {
	partial class BindingIndividualSeriesDemo {
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.BarSlideAnimation barSlideAnimation1 = new DevExpress.XtraCharts.BarSlideAnimation();
            DevExpress.XtraCharts.BounceEasingFunction bounceEasingFunction1 = new DevExpress.XtraCharts.BounceEasingFunction();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BindingIndividualSeriesDemo));
            this.ds1 = new DevExpress.XtraCharts.Demos.DS();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.oleDbDataAdapterProducts = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapterCategories = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.comboBoxEditFilter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditSortOrder = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditSortBy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelSortOrder = new DevExpress.XtraEditors.LabelControl();
            this.labelSortBy = new DevExpress.XtraEditors.LabelControl();
            this.labelFilter = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSortOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSortBy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelFilter);
            this.panel.Controls.Add(this.labelSortBy);
            this.panel.Controls.Add(this.labelSortOrder);
            this.panel.Controls.Add(this.comboBoxEditSortBy);
            this.panel.Controls.Add(this.comboBoxEditSortOrder);
            this.panel.Controls.Add(this.comboBoxEditFilter);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditFilter, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditSortOrder, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditSortBy, 0);
            this.panel.Controls.SetChildIndex(this.labelSortOrder, 0);
            this.panel.Controls.SetChildIndex(this.labelSortBy, 0);
            this.panel.Controls.SetChildIndex(this.labelFilter, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 4;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.EnforceConstraints = false;
            this.ds1.Locale = new System.Globalization.CultureInfo("en-US");
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart
            // 
            this.chart.DataAdapter = this.oleDbDataAdapterProducts;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.Label.Angle = -30;
            xyDiagram1.AxisX.Title.Text = "Products";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.Title.Text = "Price, Millions of Dollars";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "ProductName";
            series1.DataSource = this.ds1.Products;
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "Products";
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series1.ValueDataMembersSerializable = "UnitPrice";
            barSlideAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromTop;
            bounceEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out;
            barSlideAnimation1.EasingFunction = bounceEasingFunction1;
            barSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000");
            sideBySideBarSeriesView1.Animation = barSlideAnimation1;
            series1.View = sideBySideBarSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle1.Font = new System.Drawing.Font("Tahoma", 10F);
            chartTitle1.Text = "";
            chartTitle2.Text = "Northwind Traders";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chart_BoundDataChanged);
            // 
            // oleDbDataAdapterProducts
            // 
            this.oleDbDataAdapterProducts.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDbDataAdapterProducts.InsertCommand = this.oleDbInsertCommand2;
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
            this.oleDbDataAdapterProducts.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Discontinued", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Discontinued", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_EAN13", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EAN13", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_EAN131", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EAN13", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_QuantityPerUnit1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ReorderLevel1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitPrice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitsInStock1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitsOnOrder1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO Products(CategoryID, Discontinued, EAN13, ProductName, QuantityPerUni" +
    "t, ReorderLevel, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder) VALUES (?, ?" +
    ", ?, ?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("Discontinued", System.Data.OleDb.OleDbType.Boolean, 2, "Discontinued"),
            new System.Data.OleDb.OleDbParameter("EAN13", System.Data.OleDb.OleDbType.VarWChar, 12, "EAN13"),
            new System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, "ProductName"),
            new System.Data.OleDb.OleDbParameter("QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, "QuantityPerUnit"),
            new System.Data.OleDb.OleDbParameter("ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("SupplierID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "SupplierID", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Current, null)});
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT CategoryID, Discontinued, EAN13, ProductID, ProductName, QuantityPerUnit, " +
    "ReorderLevel, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("Discontinued", System.Data.OleDb.OleDbType.Boolean, 2, "Discontinued"),
            new System.Data.OleDb.OleDbParameter("EAN13", System.Data.OleDb.OleDbType.VarWChar, 12, "EAN13"),
            new System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, "ProductName"),
            new System.Data.OleDb.OleDbParameter("QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, "QuantityPerUnit"),
            new System.Data.OleDb.OleDbParameter("ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("SupplierID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "SupplierID", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Discontinued", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Discontinued", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_EAN13", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EAN13", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_EAN131", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EAN13", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_QuantityPerUnit1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ReorderLevel1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitPrice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitsInStock1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitsOnOrder1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapterCategories
            // 
            this.oleDbDataAdapterCategories.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapterCategories.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapterCategories.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapterCategories.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Categories", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Picture", "Picture")})});
            this.oleDbDataAdapterCategories.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM Categories WHERE (CategoryID = ?) AND (CategoryName = ?) AND (Descrip" +
    "tion = ? OR ? IS NULL AND Description IS NULL) AND (Picture = ? OR ? IS NULL AND" +
    " Picture IS NULL)";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Picture", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Picture", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Picture1", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Picture", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO Categories(CategoryName, Description, Picture) VALUES (?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, "CategoryName"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.VarBinary, 0, "Picture")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, "CategoryName"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.VarBinary, 0, "Picture"),
            new System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Picture", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Picture", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Picture1", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Picture", System.Data.DataRowVersion.Original, null)});
            // 
            // comboBoxEditFilter
            // 
            this.comboBoxEditFilter.EditValue = "";
            this.comboBoxEditFilter.Location = new System.Drawing.Point(282, 9);
            this.comboBoxEditFilter.Margin = new System.Windows.Forms.Padding(3, 0, 10, 10);
            this.comboBoxEditFilter.Name = "comboBoxEditFilter";
            this.comboBoxEditFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditFilter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditFilter.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditFilter.TabIndex = 2;
            this.comboBoxEditFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditFilter_SelectedIndexChanged);
            // 
            // comboBoxEditSortOrder
            // 
            this.comboBoxEditSortOrder.EditValue = "";
            this.comboBoxEditSortOrder.Location = new System.Drawing.Point(70, 9);
            this.comboBoxEditSortOrder.Margin = new System.Windows.Forms.Padding(3, 0, 10, 10);
            this.comboBoxEditSortOrder.Name = "comboBoxEditSortOrder";
            this.comboBoxEditSortOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSortOrder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditSortOrder.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditSortOrder.TabIndex = 0;
            this.comboBoxEditSortOrder.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditSortOrder_SelectedIndexChanged);
            // 
            // comboBoxEditSortBy
            // 
            this.comboBoxEditSortBy.EditValue = "";
            this.comboBoxEditSortBy.Location = new System.Drawing.Point(70, 37);
            this.comboBoxEditSortBy.Margin = new System.Windows.Forms.Padding(3, 10, 10, 0);
            this.comboBoxEditSortBy.Name = "comboBoxEditSortBy";
            this.comboBoxEditSortBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSortBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditSortBy.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditSortBy.TabIndex = 1;
            this.comboBoxEditSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditSortBy_SelectedIndexChanged);
            // 
            // labelSortOrder
            // 
            this.labelSortOrder.Location = new System.Drawing.Point(12, 12);
            this.labelSortOrder.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(55, 13);
            this.labelSortOrder.TabIndex = 13;
            this.labelSortOrder.Text = "Sort Order:";
            // 
            // labelSortBy
            // 
            this.labelSortBy.Location = new System.Drawing.Point(12, 40);
            this.labelSortBy.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(39, 13);
            this.labelSortBy.TabIndex = 14;
            this.labelSortBy.Text = "Sort By:";
            // 
            // labelFilter
            // 
            this.labelFilter.Location = new System.Drawing.Point(188, 12);
            this.labelFilter.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(91, 13);
            this.labelFilter.TabIndex = 15;
            this.labelFilter.Text = "Filter By Category:";
            // 
            // BindingIndividualSeriesDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "BindingIndividualSeriesDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSortOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSortBy.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl labelSortOrder;
        private DevExpress.XtraEditors.LabelControl labelFilter;
        private DevExpress.XtraEditors.LabelControl labelSortBy;
	}
}
