using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Data;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Columns;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridDrawColumnObjects.
	/// </summary>
	public partial class GridDrawColumnObjects : TutorialControl {
		public GridDrawColumnObjects() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		#region Init
        string tblGrid = "[Order Details]";
        string tblLookUp = "Products";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblGrid, connectionString);
            oleDbDataAdapter.Fill(ds, tblGrid);
            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblLookUp, connectionString);
            oleDbDataAdapter.Fill(ds, tblLookUp);
            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.ShowOnlyPredefinedDetails = true;
            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }

		private void InitGrid() {
			gridView1.Columns["OrderID"].FilterInfo = new ColumnFilterInfo(ColumnFilterType.Custom, null, "[OrderID] = 11077");
			gridView1.Columns["ProductID"].SortOrder = ColumnSortOrder.Ascending;
		}
		#endregion
		private void GridDrawColumnObjects_Load(object sender, System.EventArgs e) {
			InitNWindData();
			InitGrid();
		}

      //<checkEdit2>
		private static void DrawCustomSortedShape(Graphics g, Rectangle r, ColumnSortOrder so, ImageList iml) {
			if(so == ColumnSortOrder.None) return;
			int i = 0;
			if(so == ColumnSortOrder.Descending) i = 1;
			g.DrawImageUnscaled(iml.Images[i], r.X + (r.Width - iml.ImageSize.Width) / 2, r.Y + (r.Height - iml.ImageSize.Height) / 2);
		}
      //</checkEdit2>

      //<checkEdit1>
		private static void DrawCustomFilterButton(Graphics g, GridColumn column, ObjectInfoArgs filterInfo, ImageList iml) {
			int i = 0;
			if((filterInfo.State & ObjectState.Hot) != 0) i = 1;
			if((filterInfo.State & ObjectState.Pressed) != 0) i = 2;
			if(column.FilterInfo.Type != ColumnFilterType.None) i += 3;
			g.DrawImageUnscaled(iml.Images[i], filterInfo.Bounds.X + (filterInfo.Bounds.Width - iml.ImageSize.Width) / 2, filterInfo.Bounds.Y + (filterInfo.Bounds.Height - iml.ImageSize.Height) / 2);
		}

      //<checkEdit2>
		private void checkEdit_CheckedChanged(object sender, System.EventArgs e) {
			gridView1.InvalidateColumnHeader(null);
		}
      //</checkEdit1>
      //</checkEdit2>

		void UpdateInnerElements(DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e, bool restore, ref Rectangle sortBounds, ref Rectangle filterBounds, ref ObjectInfoArgs filterInfo) {
			foreach(DrawElementInfo item in e.Info.InnerElements) {
				if(item.ElementPainter is SortedShapeObjectPainter) {
					if(!checkEdit2.Checked) {
						if(restore) {
							item.ElementInfo.Bounds = sortBounds;
						} else {
							sortBounds = item.ElementInfo.Bounds;
							item.ElementInfo.Bounds = Rectangle.Empty;
						}
					}
				}
				if(item.ElementInfo is DevExpress.XtraEditors.Drawing.GridFilterButtonInfoArgs) {
					if(!checkEdit1.Checked) {
						if(restore) {
							item.ElementInfo.Bounds = filterBounds ;
						}
						else {
							filterInfo = item.ElementInfo;
							filterBounds = item.ElementInfo.Bounds;
							item.ElementInfo.Bounds = Rectangle.Empty;
						}
					}
				}
			}
		}

      //<checkEdit1>
      //<checkEdit2>
		private void gridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e) {
			if(e.Column == null) return;
			ObjectInfoArgs filterInfo = null;
			Rectangle filterBounds, sortBounds;
			filterBounds = sortBounds = Rectangle.Empty;
			try {
				UpdateInnerElements(e, false, ref sortBounds, ref filterBounds, ref filterInfo);
				e.Painter.DrawObject(e.Info);
			}
			finally {
				UpdateInnerElements(e, true, ref sortBounds, ref filterBounds, ref filterInfo);
			}
			if(!sortBounds.IsEmpty) {
				DrawCustomSortedShape(e.Graphics, sortBounds, e.Column.SortOrder, SortingGlyphsImageList);
			}
			if(!filterBounds.IsEmpty && filterInfo != null) {
				DrawCustomFilterButton(e.Graphics, e.Column, filterInfo, FilterButtonImageList);
			}
			e.Handled = true;
		}
      //</checkEdit2>
      //</checkEdit1>
		
		private ImageList FilterButtonImageList {
			get { return checkEdit1.Checked ? null : imageList1; }
		}

		private ImageList SortingGlyphsImageList {
			get { return checkEdit2.Checked ? null : imageList2; }
		}
	}
}
