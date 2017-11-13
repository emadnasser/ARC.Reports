using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using System.IO;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.Compression;
using DevExpress.Utils;
using DevExpress.XtraTreeList;
using DevExpress.XtraEditors;


namespace DevExpress.Docs.Demos {
    public partial class Decompression : TutorialControlBase {
        ZipItemVisualizer visualizer;
        ZipArchive currentArchive;
        string currentPassword;
        public Decompression() {
            InitializeComponent();
            this.visualizer = new ZipItemVisualizer(this.tlZipContent);
            this.visualizer.SelectionChanged += OnVisualizerSelectionChanged;
            this.buttonEdit1.EditValue = DemoUtils.GetRelativePath("Example.zip");
            ProcessZipArchive();
        }
        void ProcessZipArchive() {
            string pathToZipArchive = this.buttonEdit1.EditValue as String;
            if(String.IsNullOrEmpty(pathToZipArchive))
                return;
            PrepareToVisualizeArchive();
            try {
                this.currentArchive = ZipArchive.Read(pathToZipArchive);
            } catch {
                XtraMessageBox.Show(this, "Aarvhive cannot be opened", "Error");
                return;
            }
            foreach(ZipItem item in this.currentArchive) {
                ZipItemInfo zipInfo = new ZipItemInfo();
                zipInfo.Name = item.Name;
                zipInfo.CompressedSize = item.CompressedSize;
                zipInfo.UncompressedSize = item.UncompressedSize;
                this.visualizer.Add(zipInfo);
            }
            this.visualizer.Sort();
        }
        void ShowItemContent(string itemName) {
            if(CanShowTextContent(itemName))
                ShowTextContent(itemName);
            else if(CanShowImageContent(itemName))
                ShowImageContent(itemName);
            else
                ShowUnknownContent(itemName);
        }
        Stream OpenItem(string itemName) {
            if(this.currentArchive == null)
                return null;
            ZipItem item = this.currentArchive[itemName];
            AskPassword(item);
            Stream result = ExtractItemToStream(item);
            if(result == null)
                return null;
            result.Seek(0, SeekOrigin.Begin);
            return result;
        }
        Stream ExtractItemToStream(ZipItem item) {
            MemoryStream stream = new MemoryStream();
            try {
                item.Extract(stream);
            } catch(WrongPasswordException) {
                this.currentPassword = String.Empty;
                XtraMessageBox.Show(this, "The password is incorrect", "Error");
                return null;
            } catch {
                XtraMessageBox.Show("Can't unzip file", "Unzip error");
                return null;
            }
            return stream;
        }
        void AskPassword(ZipItem item) {
            if(item.EncryptionType.Equals(EncryptionType.None))
                return;
            if(String.IsNullOrEmpty(this.currentPassword)) {
                PasswordForm form = new PasswordForm(item.Name);
                form.StartPosition = FormStartPosition.CenterParent;
                if(form.ShowDialog(this) == DialogResult.OK) {
                    item.Password = form.Password;
                    this.currentPassword = item.Password;
                }
            }
            item.Password = this.currentPassword;
        }
        void ShowUnknownContent(string itemName) {
            this.pictureBox1.Visible = false;
            this.textPreview.Visible = true;
            this.textPreview.Text = "Can't display content";
        }
        void ShowImageContent(string itemName) {
            using(Stream stream = OpenItem(itemName)) {
                if(stream == null)
                    return;
                this.pictureBox1.Visible = true;
                this.textPreview.Visible = false;
                Image img = Image.FromStream(stream);
                this.pictureBox1.Image = img;
            }
        }
        bool CanShowImageContent(string itemName) {
            if(String.IsNullOrEmpty(itemName))
                return false;
            string[] extensions = new string[] { ".bmp", ".png", ".jpeg", ".jpg" };
            return IsFitToExtension(itemName, extensions);
        }
        void ShowTextContent(string itemName) {
            this.pictureBox1.Visible = false;
            this.textPreview.Visible = true;
            using(Stream stream = OpenItem(itemName)) {
                if(stream == null) {
                    this.textPreview.Text = String.Empty;
                    return;
                }
                StreamReader reader = new StreamReader(stream);
                string fileItemName = itemName.ToLower();
                if(fileItemName.EndsWith(".rtf"))
                    this.textPreview.RtfText = reader.ReadToEnd();
                else if(fileItemName.EndsWith(".docx"))
                    this.textPreview.LoadDocument(stream, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
                else if(fileItemName.EndsWith(".doc"))
                    this.textPreview.LoadDocument(stream, DevExpress.XtraRichEdit.DocumentFormat.Doc);
                else
                    this.textPreview.Text = reader.ReadToEnd();
            }
        }
        void OnVisualizerSelectionChanged(object sender, string itemName) {
            ShowItemContent(itemName);
        }
        bool CanShowTextContent(string itemName) {
            if(String.IsNullOrEmpty(itemName))
                return false;
            string[] extensions = new string[] { ".txt", ".xml", ".rels", ".rtf", ".doc", ".docx", ".cs", ".vb", ".aspx" };
            return IsFitToExtension(itemName, extensions);
        }
        static bool IsFitToExtension(string itemName, string[] extensions) {
            foreach(var ext in extensions)
                if(itemName.EndsWith(ext)) {
                    return true;
                }
            return false;
        }
        void PrepareToVisualizeArchive() {
            this.textPreview.Text = String.Empty;
            this.pictureBox1.Visible = false;
            this.textPreview.Visible = true;
            this.currentPassword = String.Empty;
            this.visualizer.Reset();
            if(this.currentArchive != null) {
                this.currentArchive.Dispose();
                this.currentArchive = null;
            }
        }
        void buttonEdit1_ButtonClick(object sender, XtraEditors.Controls.ButtonPressedEventArgs e) {
            ChooseFile(String.Empty);
        }
        void buttonEdit1_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                TryOpen();
            }
        }
        void TryOpen() {
            string fileName = this.buttonEdit1.EditValue as String;
            if(String.IsNullOrEmpty(fileName))
                return;
            FileInfo fileInfo = new FileInfo(fileName);
            if(!fileInfo.Exists) {
                ChooseFile(fileName);
                return;
            }
            ProcessZipArchive();
        }
        void ChooseFile(string initPath) {
            using(OpenFileDialog fileDialog = new OpenFileDialog()) {
                if(!String.IsNullOrEmpty(initPath))
                    fileDialog.InitialDirectory = initPath;
                if(fileDialog.ShowDialog() == DialogResult.OK) {
                    this.buttonEdit1.EditValue = fileDialog.FileName;
                    ProcessZipArchive();
                }
            }
        }
    }
    #region Visualization Code
    public class ZipItemInfo {
        public string Name { get; set; }
        public long CompressedSize { get; set; }
        public long UncompressedSize { get; set; }
    }
    public abstract class VirtualNodeBase {
        protected VirtualNodeBase(string name) {
            Name = name;
            Children = new List<VirtualNodeBase>();
        }
        public List<VirtualNodeBase> Children { get; private set; }
        public string Name { get; private set; }
    }

    public class VirtualNode {
        public VirtualNode(string name) {
            Name = name;
            Children = new List<VirtualNode>();
        }

        public string Name { get; private set; }
        public List<VirtualNode> Children { get; private set; }
        public ZipItemInfo Value { get; set; }

        public void AddChild(VirtualNode node) {
            Children.Add(node);
        }
        internal VirtualNode GetChildByName(string pathItem) {
            foreach(var node in Children)
                if(node.Name == pathItem)
                    return node;
            return null;
        }
        public void Sort() {
            Children.Sort(new VirualNodeComparer());
            foreach(var item in Children)
                item.Sort();
        }
        public bool HasChild { get { return Children.Count > 0; } }
    }
    public delegate void NodeSelectionChanged(object sender, String itemName);
    public class ZipItemVisualizer {
        TreeList treeList;
        bool loadDrives;
        VirtualNode root = new VirtualNode(String.Empty);

        public ZipItemVisualizer(TreeList treeList) {
            this.treeList = treeList;
            this.treeList.CustomDrawNodeCell += OnTreeListCustomDrawNodeCell;
            this.treeList.VirtualTreeGetChildNodes += OnTreeListVirtualTreeGetChildNodes;
            this.treeList.VirtualTreeGetCellValue += OnTreeListVirtualTreeGetCellValue;
            this.treeList.FocusedNodeChanged += OnTreeListFocusedNodeChanged;
            foreach(DevExpress.XtraTreeList.Columns.TreeListColumn column in this.treeList.Columns)
                column.OptionsColumn.AllowSort = false;
            Reset();
        }

        public event NodeSelectionChanged SelectionChanged;

        void OnTreeListFocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e) {
            VirtualNode node = e.Node.GetValue(this.treeList.Columns[0].FieldName) as VirtualNode;
            if(SelectionChanged == null)
                return;
            ZipItemInfo itemInfo = node.Value;
            string name = (itemInfo == null) ? null : itemInfo.Name;
            SelectionChanged(this, name);
        }
        public void Reset() {
            this.loadDrives = false;
            this.treeList.DataSource = null;
            this.root = new VirtualNode(String.Empty);
        }
        public void Add(ZipItemInfo item) {
            string[] pathItems = item.Name.Split('/');
            VirtualNode currentNode = root;
            foreach(var pathItem in pathItems) {
                if(String.IsNullOrEmpty(pathItem))
                    continue;
                VirtualNode node = currentNode.GetChildByName(pathItem);
                if(node == null) {
                    node = new VirtualNode(pathItem);
                    currentNode.AddChild(node);
                }
                currentNode = node;
            }
            currentNode.Value = item;
        }
        public void Sort() {
            this.root.Sort();
            this.treeList.DataSource = new object();
        }
        internal VirtualNode[] GetRootNodes() {
            return this.root.Children.ToArray();
        }
        void OnTreeListVirtualTreeGetChildNodes(object sender, DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo e) {
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if(!loadDrives) {
                VirtualNode[] roots = GetRootNodes();
                e.Children = roots;
                loadDrives = true;
            } else {
                VirtualNode currentNode = (VirtualNode)e.Node;
                e.Children = currentNode.Children.ToArray();
            }
            Cursor.Current = current;
        }
        private void OnTreeListVirtualTreeGetCellValue(object sender, DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo e) {
            VirtualNode vn = e.Node as VirtualNode;
            e.CellData = vn;
        }
        private void OnTreeListCustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e) {
            e.CellText = String.Empty;
            VirtualNode node = e.Node.GetValue(e.Column.FieldName) as VirtualNode;
            if(node == null)
                return;
            if(e.Column.FieldName == "Name" && node != null) {
                if(!node.HasChild)
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                e.CellText = node.Name;
                return;
            }
            ZipItemInfo zipItem = node.Value;
            if(zipItem == null || node.HasChild)
                return;
            FormatAsSizeColumn(e.Appearance);
            long size = 0;
            if(e.Column.FieldName == "CompressedSize")
                size = zipItem.CompressedSize;
            else if(e.Column.FieldName == "UncompressedSize")
                size = zipItem.UncompressedSize;
            e.CellText = GetText(size);
        }
        void FormatAsSizeColumn(AppearanceObject appearance) {
            appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            appearance.Font = new Font(appearance.Font, FontStyle.Italic);
        }
        string GetText(long size) {
            if(size >= 1024)
                return string.Format("{0:### ### ###} KB", size / 1024);
            return string.Format("{0} Bytes", size);
        }
    }
    #endregion
    #region VirualNodeComparer
    class VirualNodeComparer : IComparer<VirtualNode> {
        public int Compare(VirtualNode x, VirtualNode y) {
            if(!x.HasChild && y.HasChild)
                return 1;
            else
                if(x.HasChild && !y.HasChild)
                    return -1;
            return String.Compare(x.Name, y.Name);
        }
    }
    #endregion
}
