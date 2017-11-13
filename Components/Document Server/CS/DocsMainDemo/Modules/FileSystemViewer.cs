using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Data;

namespace DevExpress.Docs.Demos.Modules {
    public partial class FileSystemViewer : UserControl {
        FileCollection fileCollection;
        public FileSystemViewer() {
            InitializeComponent();
            Load += OnFileSystemViewerLoad;            
        }

        private void OnFileSystemViewerLoad(object sender, EventArgs e) {
            this.fileCollection = new FileCollection(System.IO.Directory.GetDirectoryRoot(System.Environment.SystemDirectory));
            this.gridControl1.DataSource = this.fileCollection;
            string[] drives = System.Environment.GetLogicalDrives();
            for (int i = 0; i < drives.Length; i++)
                this.cbDrives.Properties.Items.Add(drives[i]);
            SubscribeCbDrivesEvents();
            this.fileCollection.FilePath = FindDemoFolder();
            UpdateDriveLetter();
            UpdateUserPath();
            ChangeFolderPath(FindDemoFolder());
        }

        public List<FileCollectionItem> GetSelectedFiles() {
            List<FileCollectionItem> result = new List<FileCollectionItem>();
            int[] rowIndeces = gridView1.GetSelectedRows();
            if (rowIndeces.Length <= 0)
                return result;
            int zeroRowIndex = rowIndeces[0];
            int index = gridView1.ViewRowHandleToDataSourceIndex(zeroRowIndex);
            if (rowIndeces.Length == 1 && index < this.fileCollection.Count && this.fileCollection[index].ItemType == FileCollectionItemType.Up) {
                result.Add(this.fileCollection[0]);
                return result;
            }

            foreach(int rowIndex in rowIndeces) {
                if((rowIndex < 0))
                    continue;
                int sourceIndex = gridView1.ViewRowHandleToDataSourceIndex(rowIndex);
                if (index < this.fileCollection.Count)
                    result.Add(this.fileCollection[sourceIndex]);
            }
            return result;
        }
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
            if((rowIndex < 0) || (this.fileCollection.Count <= rowIndex) || (this.fileCollection[rowIndex].ItemType == FileCollectionItemType.File))
                return;
            string newPath = this.fileCollection[rowIndex].ItemType == FileCollectionItemType.Up ?
                this.fileCollection[rowIndex].DirectoryName : string.Empty;
            ChangeFolderPath(this.fileCollection[rowIndex].FullName);
        }
        void ChangeFolderPath(string newPath) {
            this.gridView1.BeginUpdate();
            try {
                this.fileCollection.FilePath = newPath;
                ((CurrencyManager)this.gridControl1.BindingContext[this.fileCollection]).Refresh();
                int focusedIndex = newPath != string.Empty ? this.fileCollection.IndexOf(newPath) : 0;
                if(focusedIndex < 0)
                    focusedIndex = 0;
                this.gridView1.FocusedRowHandle = focusedIndex;
                UpdateUserPath();
            } finally {
                this.gridView1.EndUpdate();
            }
        }
        //</gridControl2>

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            int rowIndex = gridView1.ViewRowHandleToDataSourceIndex(e.RowHandle);
            if(rowIndex < 0 || rowIndex >= this.fileCollection.Count)
                return;
            FileCollectionItem fileItem = this.fileCollection[rowIndex];
            if(e.Column == this.gridColumnSize) {
                if(fileItem.ItemType == FileCollectionItemType.File) {
                    long size = fileItem.Size;
                    if(size >= 1024)
                        e.DisplayText = string.Format("{0:### ### ###} {1}", size / 1024, "Kb");
                    else
                        e.DisplayText = string.Format("{0} {1}", size, "B");
                } else
                    e.DisplayText = string.Empty;
            }
            if(e.Column == this.gridColumnModified) {
                if(fileItem.ItemType == FileCollectionItemType.Up)
                    e.DisplayText = string.Empty;
            }
        }

        private void comboBoxDrives_SelectedIndexChanged(object sender, System.EventArgs e) {
            ChangeFolderPath(cbDrives.Text.ToString());
        }

        private void gridView1_CalcPreviewText(object sender, DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs e) {
            e.PreviewText = ((FileCollectionItem)gridView1.GetRow(e.RowHandle)).FullName;
        }

        int FolderComparer(FileCollectionItem item1, FileCollectionItem item2) {
            if(item1.ItemType != item2.ItemType) {
                if(item1.ItemType == FileCollectionItemType.Up)
                    return -1;
                if(item2.ItemType == FileCollectionItemType.Up)
                    return 1;
                if(item1.ItemType == FileCollectionItemType.Directory)
                    return -1;
                if(item2.ItemType == FileCollectionItemType.Directory)
                    return 1;
            }
            return 0;
        }

        bool IsFolder(FileCollectionItem item1) {
            if(item1.ItemType == FileCollectionItemType.Up)
                return true;
            if(item1.ItemType == FileCollectionItemType.Directory)
                return true;
            return false;
        }

        private void gridView1_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e) {
            FileCollectionItem item1 = e.RowObject1 as FileCollectionItem, item2 = e.RowObject2 as FileCollectionItem;
            int res = FolderComparer(item1, item2);
            if(res == 0) {
                res = Comparer.Default.Compare(e.Value1, e.Value2);
                if(e.Column != this.gridColumnName && e.Column != gridColumnModified) {
                    if(IsFolder(item1)) {
                        res = Comparer.Default.Compare(item1.Name, item2.Name);
                        if(res != 0 && e.SortOrder == ColumnSortOrder.Descending)
                            res = res > 0 ? -1 : 1;

                        e.Result = res;
                        e.Handled = true;
                        return;
                    }
                }
            } else {
                if(res != 0 && e.SortOrder == ColumnSortOrder.Descending)
                    res = res > 0 ? -1 : 1;
            }
            e.Result = res;
            e.Handled = true;
        }


        private void GridFolder_Load(object sender, System.EventArgs e) {
            gridView1.FocusedRowHandle = 0;
        }

        private void edtCurrentPath_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode != Keys.Enter)
                return;
            SetNewPath();
        }
        void SetNewPath() {
            try {
                string fileName = edtCurrentPath.Text.Trim('"', ' ');
                System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(fileName);
                if(!dirInfo.Exists)
                    edtCurrentPath.Text = fileCollection.FilePath;
                else {
                    ChangeFolderPath(fileName);
                    UpdateDriveLetter();
                }
            } catch {
                UpdateUserPath();
            }
        }

        void UpdateDriveLetter() {
            UnsubscribeCbDrivesEvents();
            this.cbDrives.EditValue = System.IO.Path.GetPathRoot(this.fileCollection.FilePath);
            SubscribeCbDrivesEvents();
        }

        void UnsubscribeCbDrivesEvents() {
            this.cbDrives.SelectedIndexChanged -= this.comboBoxDrives_SelectedIndexChanged;
        }
        void SubscribeCbDrivesEvents() {
            this.cbDrives.SelectedIndexChanged += this.comboBoxDrives_SelectedIndexChanged;
        }
        void UpdateUserPath() {
            edtCurrentPath.Text = fileCollection.FilePath;
        }
        string FindDemoFolder() {
            string demoPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().FullName);
            DirectoryInfo currentDirInfo = new DirectoryInfo(Assembly.GetExecutingAssembly().FullName);
            do {
                if(currentDirInfo.Name.Contains("Demos"))
                    return currentDirInfo.FullName;
                currentDirInfo = currentDirInfo.Parent;
            } while(currentDirInfo != null);
            return System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
