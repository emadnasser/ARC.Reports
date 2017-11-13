using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Data;
using System.Windows.Forms;
using DevExpress.ActiveDemos;

namespace DevExpress.XtraGrid.Demos {
    public partial class GridFolder : TutorialControl {
        //<gridControl2>
        FileCollection fileCollection;
        //</gridControl2>
        public GridFolder() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\GridFolder.cs;CS\\GridMainDemo\\Modules\\Directories.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.GridFolder.xml";
            //<gridControl2>
            this.fileCollection = new FileCollection(System.IO.Directory.GetDirectoryRoot(System.Environment.SystemDirectory));
            this.gridControl2.DataSource = this.fileCollection;
            //</gridControl2>
            string[] drives = System.Environment.GetLogicalDrives();
            for(int i = 0; i < drives.Length; i++)
                this.comboBoxDrives.Properties.Items.Add(drives[i]);
            this.comboBoxDrives.SelectedIndex = this.comboBoxDrives.Properties.Items.IndexOf(this.fileCollection.FilePath);
            this.labelCurrentPath.Text = this.fileCollection.FilePath;
            this.gridColumnImage.Caption = " ";
            this.comboBoxDrives.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrives_SelectedIndexChanged);
        }

        
        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return gridView1; } }
        public override bool HasActiveDemo { get { return true; } }
        protected override ActiveDemo CreateActiveDemo() {
            return new ActiveGridDemo(gridControl2);
        }
        protected override void RunGridActiveDemo(ActiveGridDemo activeDemo) {
            string st = System.Environment.SystemDirectory;
            if(st != string.Empty) {
                st = st[0] + ":\\";
                comboBoxDrives.Text = st;
                ChangeFolderPath(st);
            }

            activeDemo.ClickGridColumn(this.gridColumnName);
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_Folder_Sorting);
            activeDemo.SelectCellByMouse(this.gridColumnName, 0);
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_Folder_IncrementalSearch);
            activeDemo.Actions.SendString(gridControl2, "Docu");
            activeDemo.Actions.SendString(gridControl2, "[Back][Back][Back][Back]");
            activeDemo.Actions.SendString(gridControl2, "Windows");
            activeDemo.Actions.SendString(gridControl2, "[Enter]");
            activeDemo.Actions.SendString(gridControl2, "Microsoft.Net");
            activeDemo.Actions.SendString(gridControl2, "[Enter]");
            activeDemo.Actions.SendString(gridControl2, "Framework");
            activeDemo.Actions.SendString(gridControl2, "[Enter]");
        }

        //<gridControl2>
        private void gridView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            if(e.Clicks > 1) {
                DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInfo = this.gridView1.CalcHitInfo(new Point(e.X, e.Y));
                if(hitInfo.InRow)
                    ChangedFolderPath();
            }
        }
        private void gridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter)
                ChangedFolderPath();
        }
        void ChangedFolderPath() {
            int rowIndex = gridView1.ViewRowHandleToDataSourceIndex(this.gridView1.FocusedRowHandle);
            if((rowIndex < 0) || (this.fileCollection[rowIndex].ItemType == FileCollectionItemType.File))
                return;
            string newPath = this.fileCollection[rowIndex].ItemType == FileCollectionItemType.Up ?
                this.fileCollection[rowIndex].DirectoryName : string.Empty;
            ChangeFolderPath(this.fileCollection[rowIndex].FullName);
        }
        void ChangeFolderPath(string newPath) {
            this.gridView1.BeginUpdate();
            try {
                this.fileCollection.FilePath = newPath;
                ((CurrencyManager)this.gridControl2.BindingContext[this.fileCollection]).Refresh();
                int focusedIndex = newPath != string.Empty ? this.fileCollection.IndexOf(newPath) : 0;
                if(focusedIndex < 0)
                    focusedIndex = 0;
                this.gridView1.FocusedRowHandle = focusedIndex;
                this.labelCurrentPath.Text = this.fileCollection.FilePath;
            }
            finally {
                this.gridView1.EndUpdate();
            }
        }
        //</gridControl2>

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            int rowIndex = gridView1.ViewRowHandleToDataSourceIndex(e.RowHandle);
            if(rowIndex < 0) return;
            if(e.Column == this.gridColumnSize) {
                if(this.fileCollection[rowIndex].ItemType == FileCollectionItemType.File) {
                    long size = this.fileCollection[rowIndex].Size;
                    if(size >= 1024)
                        e.DisplayText = string.Format("{0:### ### ###} {1}", size / 1024, Properties.Resources.Kilobytes);
                    else e.DisplayText = string.Format("{0} {1}", size, Properties.Resources.Bytes);
                }
                else e.DisplayText = string.Empty;
            }
            if(e.Column == this.gridColumnModified) {
                if(this.fileCollection[rowIndex].ItemType == FileCollectionItemType.Up)
                    e.DisplayText = string.Empty;
            }
        }

        private void comboBoxDrives_SelectedIndexChanged(object sender, System.EventArgs e) {
            ChangeFolderPath(comboBoxDrives.Text.ToString());
        }

        private void gridView1_CalcPreviewText(object sender, DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs e) {
            e.PreviewText = ((FileCollectionItem)gridView1.GetRow(e.RowHandle)).FullName;
        }

        int FolderComparer(FileCollectionItem item1, FileCollectionItem item2) {
            if(item1.ItemType != item2.ItemType) {
                if(item1.ItemType == FileCollectionItemType.Up) return -1;
                if(item2.ItemType == FileCollectionItemType.Up) return 1;
                if(item1.ItemType == FileCollectionItemType.Directory) return -1;
                if(item2.ItemType == FileCollectionItemType.Directory) return 1;
            }
            return 0;
        }

        bool IsFolder(FileCollectionItem item1) {
            if(item1.ItemType == FileCollectionItemType.Up) return true;
            if(item1.ItemType == FileCollectionItemType.Directory) return true;
            return false;
        }

        private void gridView1_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e) {
            FileCollectionItem item1 = e.RowObject1 as FileCollectionItem, item2 = e.RowObject2 as FileCollectionItem;
            int res = FolderComparer(item1, item2);
            if(res == 0) {
                res = Comparer.Default.Compare(e.Value1, e.Value2);
                if(e.Column != gridColumnName && e.Column != gridColumnModified) {
                    if(IsFolder(item1)) {
                        res = Comparer.Default.Compare(item1.Name, item2.Name);
                        if(res != 0 && e.SortOrder == ColumnSortOrder.Descending)
                            res = res > 0 ? -1 : 1;

                        e.Result = res;
                        e.Handled = true;
                        return;
                    }
                }
            }
            else {
                if(res != 0 && e.SortOrder == ColumnSortOrder.Descending) res = res > 0 ? -1 : 1;
            }
            e.Result = res;
            e.Handled = true;
        }


        private void GridFolder_Load(object sender, System.EventArgs e) {
            gridView1.FocusedRowHandle = 0;
        }
    }
}

