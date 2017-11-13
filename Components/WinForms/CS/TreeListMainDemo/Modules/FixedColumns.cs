using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.Utils;
using DevExpress.Utils.Menu;


namespace DevExpress.XtraTreeList.Demos {
    public partial class FixedColumns : TutorialControl {
        public FixedColumns() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\TreeListMainDemo\\Modules\\FixedColumns.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraTreeList.Demos.CodeInfo.FixedColumns.xml";
            InitData();
            InitEditors();
            treeList1.ExpandAll();
            //<treeList1>
            /*
            ~Note: the following property is set at design time and listed here only for demonstration purposes.
            ~Anchor a column to the TreeList's left edge:

            treeListColumn1.Fixed = FixedStyle.Left;

            */
            //</treeList1>
            
        }
        private void InitEditors() {
            ceAllowPixelScrolling.Checked = true;
        }
        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\BioLife.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                treeList1.DataSource = dataSet.Tables[0].DefaultView;
            }
        }
        //<treeList1>
        /*
         ~Create a menu with commands to anchor tree list columns:
         */
        private void treeList1_PopupMenuShowing(object sender, DevExpress.XtraTreeList.PopupMenuShowingEventArgs e) {
            TreeListHitInfo hitInfo = treeList1.CalcHitInfo(e.Point);
            if(hitInfo.HitInfoType == HitInfoType.Column) {
                DevExpress.XtraTreeList.Menu.TreeListColumnMenu menu = e.Menu as DevExpress.XtraTreeList.Menu.TreeListColumnMenu;
                menu.Items.Clear();
                if(menu.Column != null) {
                    menu.Items.Add(CreateCheckItem("Not Fixed", menu.Column, FixedStyle.None, imageList1.Images[0]));
                    menu.Items.Add(CreateCheckItem("Fixed Left", menu.Column, FixedStyle.Left, imageList1.Images[1]));
                    menu.Items.Add(CreateCheckItem("Fixed Right", menu.Column, FixedStyle.Right, imageList1.Images[2]));
                }
            }
        }
        DXMenuCheckItem CreateCheckItem(string caption, TreeListColumn column, FixedStyle style, Image image) {
            DXMenuCheckItem item = new DXMenuCheckItem(caption, column.Fixed == style, image, new EventHandler(OnFixedClick));
            item.Tag = new MenuInfo(column, style);
            return item;
        }
        void OnFixedClick(object sender, EventArgs e) {
            DXMenuItem item = sender as DXMenuItem;
            MenuInfo info = item.Tag as MenuInfo;
            if(info == null) return;
            info.Column.Fixed = info.Style;
        }
        //</treeList1>

        //<spinEdit1>
        private void spinEdit1_EditValueChanged(object sender, System.EventArgs e) {
            treeList1.FixedLineWidth = (int)spinEdit1.Value;
        }
        //</spinEdit1>

        private void treeList1_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e) {
            if (e.Column.Fixed != FixedStyle.None && e.Node != treeList1.FocusedNode) {
                e.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
                e.Appearance.BackColor = Color.DarkGray;
                e.Appearance.ForeColor = Color.Black;
            }
        }

        //<treeList1>
        class MenuInfo {
            public MenuInfo(TreeListColumn column, FixedStyle style) {
                this.Column = column;
                this.Style = style;
            }
            public FixedStyle Style;
            public TreeListColumn Column;
        }

        //</treeList1>

        private void ceAllowPixelScrolling_CheckedChanged(object sender, EventArgs e) {
            treeList1.OptionsBehavior.AllowPixelScrolling = ceAllowPixelScrolling.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
    }
}
