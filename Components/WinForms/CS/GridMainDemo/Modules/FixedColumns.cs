using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid; 
using DevExpress.XtraGrid.Columns; 
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.Controls;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for FixedColumns.
	/// </summary>
	public partial class FixedColumns : TutorialControl {
		public FixedColumns() {
			//
			// Required for Windows Form Designer support
			//
			CreateWaitDialog();
			InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\FixedColumns.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.FixedColumns.xml";
			InitNWindData();
			InitEditing();
            InitColumns();
            InitFixedStyle();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        #region Init
		public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return gridView1; } }
		private GridView CurrentGridView { get { return gridView1; }}
        protected override void InitMDBData(string connectionString) {
            DataSet dataSet = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDBAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Customers", connectionString);

            SetWaitDialogCaption(Properties.Resources.LoadingCustomers);
            oleDBAdapter.Fill(dataSet, "Customers");
            gridControl2.DataSource = dataSet.Tables["Customers"];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet dataSet = new DataSet();
            SetWaitDialogCaption(Properties.Resources.LoadingTables);
            dataSet.ReadXml(dataFileName);
            gridControl2.DataSource = dataSet.Tables["Customers"];
        }
		private void InitEditing() {
			numFixedLineWidth1.Value = CurrentGridView.FixedLineWidth;
		}
		private void FixedColumns_Load(object sender, System.EventArgs e) {
			gridControl2.ForceInitialize();
			CurrentGridView.ExpandAllGroups();
            
            //<gridControl2>
            /*
            ~The following properties are specified at design-time and listed here for demonstration purposes
            
            colCompanyName.Fixed = FixedStyle.Left;
            */
            //</gridControl2>
		}
        void InitColumns() {
            icbColumn.Properties.SmallImages = gridView1.Images;
            icbColumn.Properties.Sorted = true;
            foreach(GridColumn col in gridView1.Columns) {
                if(col.Visible)
                    icbColumn.Properties.Items.Add(new ImageComboBoxItem(col.GetTextCaption(), col, col.ImageIndex));
            }
            icbColumn.EditValue = colCompanyName;
        }

        void InitFixedStyle() {
            foreach(FixedStyle style in Enum.GetValues(typeof(FixedStyle)))
                icbFixedStyle.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<FixedStyle>.GetTitle(style), style, -1));
        }
		#endregion
		#region Editing
        //<numFixedLineWidth1>
		private void numFixedLineWidth1_ValueChanged(object sender, System.EventArgs e) {
			CurrentGridView.FixedLineWidth = (int)numFixedLineWidth1.Value;
		}
        //</numFixedLineWidth1>
		#endregion	
		#region Grid events
		private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e) {
			if(e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Column) {
				DevExpress.XtraGrid.Menu.GridViewColumnMenu menu = e.Menu as DevExpress.XtraGrid.Menu.GridViewColumnMenu;
				menu.Items.Clear();
				if(menu.Column != null) {
					menu.Items.Add(CreateCheckItem(Properties.Resources.NotFixed, menu.Column, FixedStyle.None, imageList2.Images[0]));
					menu.Items.Add(CreateCheckItem(Properties.Resources.FixedLeft, menu.Column, FixedStyle.Left, imageList2.Images[1]));
					menu.Items.Add(CreateCheckItem(Properties.Resources.FixedRight, menu.Column, FixedStyle.Right, imageList2.Images[2]));
				}
			}
		}
		#endregion
		#region New column menu
		DXMenuCheckItem CreateCheckItem(string caption, GridColumn column, FixedStyle style, Image image) {
			DXMenuCheckItem item = new DXMenuCheckItem(caption, column.Fixed == style, image, new EventHandler(OnFixedClick));
			item.Tag = new MenuInfo(column, style);
			return item;
		}
		void OnFixedClick(object sender, EventArgs e) {
			DXMenuItem item = sender as DXMenuItem;
			MenuInfo info = item.Tag as MenuInfo;
			if(info == null) return;
			info.Column.Fixed = info.Style;
            UpdateColumnFixed();
		}
		class MenuInfo {
			public MenuInfo(GridColumn column, FixedStyle style) {
				this.Column = column;
				this.Style = style;
			}
			public FixedStyle Style;
			public GridColumn Column;
		}
		#endregion

        
        private void icbColumn_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateColumnFixed();
        }

        void UpdateColumnFixed() {
            GridColumn col = icbColumn.EditValue as GridColumn;
            if(col == null) return;
            icbFixedStyle.EditValue = col.Fixed;
        }
        //<icbFixedStyle>
        private void icbFixedStyle_SelectedIndexChanged(object sender, EventArgs e) {
            GridColumn col = icbColumn.EditValue as GridColumn;
            if(col == null) return;
            col.Fixed = (FixedStyle)icbFixedStyle.EditValue;
        }
        //</icbFixedStyle>
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
	}
}
