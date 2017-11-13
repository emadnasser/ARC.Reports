using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridRunTimeUsing.
	/// </summary>
	public partial class GridRunTimeUsing : TutorialControl {
		public GridRunTimeUsing() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        DataSet ds = new DataSet();
		private void GridRunTimeUsing_Load(object sender, System.EventArgs e) {
			InitNWindData();
			GridAdjustment();
			GridEditorsAdjustment();
			GridAppearance();
		}

        protected override void InitMDBData(string connectionString) {
            OleDbDataAdapter oleDBAdapter1 = new OleDbDataAdapter("SELECT * FROM Customers", connectionString);
            OleDbDataAdapter oleDBAdapter2 = new OleDbDataAdapter("SELECT * FROM Orders", connectionString);
            OleDbDataAdapter oleDBAdapter3 = new OleDbDataAdapter("SELECT * FROM [Order Details]", connectionString);
            OleDbDataAdapter oleDBAdapter4 = new OleDbDataAdapter("SELECT * FROM Employees", connectionString);
            OleDbDataAdapter oleDBAdapter5 = new OleDbDataAdapter("SELECT * FROM Products", connectionString);

            oleDBAdapter1.Fill(ds, "Customers");
            oleDBAdapter2.Fill(ds, "Orders");
            oleDBAdapter3.Fill(ds, "Order Details");
            oleDBAdapter4.Fill(ds, "Employees");
            oleDBAdapter5.Fill(ds, "Products");

            ds.Relations.Add("Orders",
                ds.Tables["Customers"].Columns["CustomerID"],
                ds.Tables["Orders"].Columns["CustomerID"]);

            ds.Relations.Add("OrderDetails",
                ds.Tables["Orders"].Columns["OrderID"],
                ds.Tables["Order Details"].Columns["OrderID"]);

            ds.Relations.Add("Employees",
                ds.Tables["Orders"].Columns["EmployeeID"],
                ds.Tables["Employees"].Columns["EmployeeID"], false);

            gridControl1.DataSource = ds.Tables["Customers"];
            gridControl1.MainView.PopulateColumns();
        }
        protected override void InitXMLData(string dataFileName) {
        }
			
		private void GridAdjustment() {
         gridControl1.MainView.KeyDown += new KeyEventHandler(gridView_KeyDown);
			GridView[] gvs = new GridView[4];
			ColorMaker[] colorMakers = new ColorMaker[4];
			string[] options = new String[] {
												"EvenRow",
												"OddRow",
												"FocusedRow",
												"FocusedCell",
												"GroupRow",
												"HeaderPanel",
												"GroupPanel",
												"HorzLine",
												"VertLine"};
			gvs[0] = gridView1;
			
			colorMakers[0] = new ColorMaker(Color.DimGray, Color.WhiteSmoke);
			colorMakers[1] = new ColorMaker(Color.DarkCyan, Color.LightCyan);
			colorMakers[2] = new ColorMaker(Color.DarkGoldenrod, Color.LightGoldenrodYellow);
			colorMakers[3] = new ColorMaker(Color.Navy, Color.Lavender);
            
			for(int i = 0; i < 4; i++) {
				string prefix = "";
				int basefontsize = 8, backColor = 100, foreColor = 0, font = 0;
				FontStyle fstyle = FontStyle.Regular;
				
				if(i == 0) basefontsize = 9;
				
				if(i > 0) {
					gvs[i] = new GridView(gridControl1);
               gvs[i].KeyDown += new KeyEventHandler(gridView_KeyDown);
					gvs[i].OptionsDetail.ShowDetailTabs = true;
					gvs[i].OptionsDetail.EnableDetailToolTip = true;
                    prefix = ds.Relations[i - 1].RelationName;
				}
				
				if(i < 2 ) 
					gvs[i].OptionsView.ColumnAutoWidth = false;

				foreach(string option in options) {
					switch(option) {
						case "EvenRow":
							backColor = 100; 
							foreColor =	0;
							break;
						case "OddRow":
							backColor = 90; 
							foreColor =	0;
							break;
						case "FocusedRow":
							backColor = 10; 
							foreColor =	90;
							fstyle = FontStyle.Bold;
							break;
						case "FocusedCell":
							backColor = 200; 
							foreColor =	0;
							break;
						case "GroupRow":
							backColor = 60; 
							foreColor =	100;
							fstyle = FontStyle.Italic;
							break;
						case "HeaderPanel":
							backColor = 30; 
							foreColor =	100;
							font = 1;
							fstyle = FontStyle.Bold;
							break;
						case "GroupPanel":
							backColor = 0; 
							foreColor =	100;
							font = 2;
							fstyle = FontStyle.Bold;
							break;
						case "HorzLine":
						case "VertLine":
							backColor = 0; 
							foreColor =	0;
							font = 0;
							break;
					}
					gvs[i].Appearance.GetAppearance(option).BackColor = colorMakers[i].ProduceColor(backColor);
					gvs[i].Appearance.GetAppearance(option).BorderColor = colorMakers[i].ProduceColor(backColor);
					gvs[i].Appearance.GetAppearance(option).ForeColor = colorMakers[i].ProduceColor(foreColor);
					gvs[i].Appearance.GetAppearance(option).Font = new Font(DevExpress.Utils.AppearanceObject.DefaultFont.FontFamily, basefontsize + font, fstyle);
				}

				if(gvs[i].OptionsView.ShowGroupPanel) 
					gvs[i].OptionsView.ShowGroupPanel = false;
				
				gvs[i].DetailHeight = 500;
				gvs[i].PaintStyleName = "MixedXP";
		
				if(prefix == "Orders") 
					gridControl1.LevelTree.Nodes.Add(prefix, gvs[i]);
				else if(prefix != "")
					gridControl1.LevelTree.Nodes["Orders"].Nodes.Add(prefix, gvs[i]);
			}
		}

		private void GridEditorsAdjustment() {
			gridControl1.BeginUpdate();
			try {
				GridColumn col;
				GridView gv;
				int i = 0;
				//values
				string[] s1 = new string[] {"", "AK", "BC", "CA", "Co. Cork", "DF", "ID",
											  "Isle of Wight", "Lara", "MT", "NM", "Nueva Esparta", "OR", "Quebec",
											  "RJ", "SP", "Tachira", "WA", "WY"};
				string[] s2 = new string[] {"Argentina", "Austria", "Belgium", "Brazil", 
											  "Canada", "Denmark", "Finland", "France", "Germany", "Ireland", "Italy", 
											  "Mexico", "Norway", "Poland", "Portugal", "Spain", "Sweden", "Switzerland", 
											  "UK", "USA", "Venezuela"};
				string[] s3 = new string[] {"Speedy Express", "United Package", "Federal Shipping"}; 
				string[] s4 = new string[] {"Dr.","Mr.","Miss","Mrs.","Ms."};
				//editors
				RepositoryItemComboBox cb1 = new RepositoryItemComboBox();
				gridControl1.RepositoryItems.Add(cb1);
				RepositoryItemComboBox cb2 = new RepositoryItemComboBox();
				gridControl1.RepositoryItems.Add(cb2);
				RepositoryItemSpinEdit se1 = new RepositoryItemSpinEdit();
				gridControl1.RepositoryItems.Add(se1);
				RepositoryItemSpinEdit se2 = new RepositoryItemSpinEdit();
				gridControl1.RepositoryItems.Add(se2);
				RepositoryItemImageComboBox pi1 = new RepositoryItemImageComboBox();
				gridControl1.RepositoryItems.Add(pi1);
				RepositoryItemImageComboBox pi2 = new RepositoryItemImageComboBox();
				gridControl1.RepositoryItems.Add(pi2);
				RepositoryItemMemoExEdit me = new RepositoryItemMemoExEdit();
				gridControl1.RepositoryItems.Add(me);
				RepositoryItemLookUpEdit le = new RepositoryItemLookUpEdit();
				gridControl1.RepositoryItems.Add(le);
				se2.IsFloatValue = false;
				foreach(string s in s1) cb1.Items.Add(s);
				foreach(string s in s2) cb2.Items.Add(s);
				foreach(string s in s3) {
					pi1.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(s, i + 1, i));
					i++;
				}
				pi1.SmallImages = imageList1;
				i = 0;
				foreach(string s in s4) {
					pi2.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(s, s, i));
					i++;
				}
				pi2.SmallImages = imageList2;
				le.ValueMember = "ProductID";
				le.DisplayMember = "ProductName";
				le.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Name", 100));
				le.PopupWidth = 200;
				le.DataSource = ds.Tables["Products"];
				//main gridview
				gv = gridView1;
				foreach(GridColumn c in gv.Columns) {
					c.Caption = CaptionByFieldName(c.FieldName);
					if(c.FieldName.IndexOf("ID") > 0) 
						c.VisibleIndex = -1;
				}
				gv.Columns["Region"].ColumnEdit = cb1;
				gv.Columns["Country"].ColumnEdit = cb2;
				//"Orders" gridview 
				gv = gridControl1.LevelTree.Nodes["Orders"].LevelTemplate as GridView;
				foreach(DataColumn c in ds.Tables["Orders"].Columns) {
					col = gv.Columns.Add();
					col.FieldName = c.ColumnName;
					col.Caption = CaptionByFieldName(col.FieldName);
					if(col.FieldName.IndexOf("ID") > 6) 
						col.VisibleIndex = -1;
					else
						col.VisibleIndex = c.Ordinal;
				} 	
				CreateEditorFormat(gv.Columns["Freight"], DevExpress.Utils.FormatType.Numeric, "c"); 
				gv.Columns["Freight"].ColumnEdit = se1;
				gv.Columns["ShipVia"].ColumnEdit = pi1;
				gv.Columns["ShipCountry"].ColumnEdit = cb2;
				//"OrederDetails" gridview 
				gv = gridControl1.LevelTree.Nodes["Orders"].Nodes["OrderDetails"].LevelTemplate as GridView;
				foreach(DataColumn c in ds.Tables["Order Details"].Columns) {
					col = gv.Columns.Add();
					col.FieldName = c.ColumnName;
					col.Caption = CaptionByFieldName(col.FieldName);
                    if(col.GetTextCaption().IndexOf("ID") > 0)
						col.VisibleIndex = -1;
					else
						col.VisibleIndex = c.Ordinal;
					if(c.Ordinal == 2) col.ColumnEdit = se1;
					if(c.Ordinal == 3) col.ColumnEdit = se2;
				}
				gv.Columns["ProductID"].ColumnEdit = le;
				CreateEditorFormat(gv.Columns["UnitPrice"], DevExpress.Utils.FormatType.Numeric, "c");
				CreateEditorFormat(gv.Columns["Discount"], DevExpress.Utils.FormatType.Numeric, "p");
				//"Employees" gridview
				gv = gridControl1.LevelTree.Nodes["Orders"].Nodes["Employees"].LevelTemplate as GridView;
				string[] columns = new String[] {"LastName", "FirstName", "Title", "TitleOfCourtesy", "BirthDate", "Notes"};
				for(int j = 0; j < columns.Length; j++) {
					col = gv.Columns.Add();
					col.FieldName = columns[j];
					col.Caption = CaptionByFieldName(col.FieldName);
					col.VisibleIndex = j;
					col.OptionsFilter.AllowFilter = false;
				}
				gv.Columns["TitleOfCourtesy"].ColumnEdit = pi2;
				gv.Columns["Notes"].ColumnEdit = me;
			} finally {
				gridControl1.EndUpdate();
			}
		}

		private void CreateEditorFormat(GridColumn c, DevExpress.Utils.FormatType formatType, string formatString) {
			c.DisplayFormat.FormatType = formatType;
			c.DisplayFormat.FormatString = formatString;
		}

		private void GridAppearance() {
			gridView1.BestFitColumns();
			gridView1.SetMasterRowExpanded(0, true);
			GridView gv = gridControl1.Views[1] as GridView;
			if(gv != null) {
				gv.SetMasterRowExpanded(0, true);
				gv.SetMasterRowExpandedEx(1, 1, true);
			}
		}

		private void gridControl1_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e) {
			if(e.View is GridView)
				((GridView)e.View).BestFitColumns();
		}

		private string CaptionByFieldName(string s) {
			if(s == "OrderID") return "Order ID";
			if(s == "ProductID") return "Product";
            string ret = s[0].ToString();
			for(int i = 1; i < s.Length; i++) {
				char c = s[i];
				if(c < 'a') ret += " ";
				ret += c;
			}
			return ret;
		}

      public override bool ShowLookAndFeel { get { return false;}}

      private void gridView_KeyDown(object sender, KeyEventArgs e) {
         ColumnView view = sender as ColumnView;
         if(e.KeyCode == Keys.Delete && e.Control) {
            view.DeleteRow(view.FocusedRowHandle);
         }
      }
   }
}
