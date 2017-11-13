using DevExpress.XtraTab;
using DevExpress.XtraEditors;
namespace DevExpress.XtraVerticalGrid.Demos {
    partial class PropertiesBase {
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesBase));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Build", 3, 3);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Debugging");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Advanced");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Configuration Properties", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.multiEditorRowProperties1 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.multiEditorRowProperties2 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.multiEditorRowProperties3 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.multiEditorRowProperties4 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.multiEditorRowProperties5 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.multiEditorRowProperties6 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.multiEditorRowProperties7 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.multiEditorRowProperties8 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.multiEditorRowProperties9 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tabPage8 = new DevExpress.XtraTab.XtraTabPage();
            this.vGridControl4 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection3 = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.rowID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTrademark = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowModel = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCategory = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowHP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowLiter = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCyl = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTransmiss_Speed_Count = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTransmiss_Automatic = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMPG = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.categoryRow2 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowPicture = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowIcon = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDescription = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowHyperlink = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow3 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowPrice = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDelivery_Date = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowIs_In_Stock = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.tabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.vGridControl2 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemTextEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemImageComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.categoryRow4 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.editorRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.multiEditorRow1 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.editorRow2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.multiEditorRow2 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.editorRow7 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow8 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow5 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.editorRow4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.multiEditorRow3 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.editorRow6 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow6 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.editorRow9 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow10 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow11 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow12 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow13 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.tabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.vGridControl3 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.splitter2 = new DevExpress.XtraEditors.SplitterControl();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new DevExpress.XtraEditors.SplitterControl();
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.pnlMemo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlMemo.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiEditorRowProperties1
            // 
            this.multiEditorRowProperties1.Caption = "MPG City";
            this.multiEditorRowProperties1.FieldName = "MPG City";
            this.multiEditorRowProperties1.RowEdit = this.repositoryItemSpinEdit1;
            this.multiEditorRowProperties1.Width = 17;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AllowFocused = false;
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.IsFloatValue = false;
            this.repositoryItemSpinEdit1.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // multiEditorRowProperties2
            // 
            this.multiEditorRowProperties2.Caption = "MPG Highway";
            this.multiEditorRowProperties2.FieldName = "MPG Highway";
            this.multiEditorRowProperties2.RowEdit = this.repositoryItemSpinEdit1;
            this.multiEditorRowProperties2.Width = 23;
            // 
            // multiEditorRowProperties3
            // 
            this.multiEditorRowProperties3.Caption = "First Name";
            this.multiEditorRowProperties3.FieldName = "FirstName";
            this.multiEditorRowProperties3.Width = 22;
            // 
            // multiEditorRowProperties4
            // 
            this.multiEditorRowProperties4.Caption = "Last Name";
            this.multiEditorRowProperties4.FieldName = "LastName";
            this.multiEditorRowProperties4.Width = 18;
            // 
            // multiEditorRowProperties5
            // 
            this.multiEditorRowProperties5.Caption = "Occupation";
            this.multiEditorRowProperties5.FieldName = "Occupation";
            // 
            // multiEditorRowProperties6
            // 
            this.multiEditorRowProperties6.Caption = "Risk Level";
            this.multiEditorRowProperties6.FieldName = "RiskLevel";
            this.multiEditorRowProperties6.RowEdit = this.repositoryItemImageComboBox4;
            // 
            // repositoryItemImageComboBox4
            // 
            this.repositoryItemImageComboBox4.AllowFocused = false;
            this.repositoryItemImageComboBox4.AutoHeight = false;
            this.repositoryItemImageComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox4.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Medium", 1, 7),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, 8)});
            this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
            this.repositoryItemImageComboBox4.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            // 
            // multiEditorRowProperties7
            // 
            this.multiEditorRowProperties7.Caption = "City";
            this.multiEditorRowProperties7.FieldName = "City";
            this.multiEditorRowProperties7.Width = 18;
            // 
            // multiEditorRowProperties8
            // 
            this.multiEditorRowProperties8.Caption = "State";
            this.multiEditorRowProperties8.FieldName = "State";
            this.multiEditorRowProperties8.RowEdit = this.repositoryItemComboBox1;
            this.multiEditorRowProperties8.Width = 18;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AllowFocused = false;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "CA",
            "CT",
            "GA",
            "IL",
            "MI",
            "NJ",
            "NY",
            "OH",
            "OK"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // multiEditorRowProperties9
            // 
            this.multiEditorRowProperties9.Caption = "Zip Code";
            this.multiEditorRowProperties9.FieldName = "ZipCode";
            this.multiEditorRowProperties9.RowEdit = this.repositoryItemTextEdit5;
            this.multiEditorRowProperties9.Width = 24;
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AllowFocused = false;
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.Mask.EditMask = "00000";
            this.repositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.repositoryItemTextEdit5.Mask.PlaceHolder = '0';
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(209, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tabPage8;
            this.tcMain.Size = new System.Drawing.Size(595, 488);
            this.tcMain.TabIndex = 0;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPage1,
            this.tabPage5,
            this.tabPage7,
            this.tabPage8});
            this.tcMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.vGridControl4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage8.Size = new System.Drawing.Size(589, 460);
            this.tabPage8.Text = "Demo Binding";
            // 
            // vGridControl4
            // 
            this.vGridControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl4.Location = new System.Drawing.Point(4, 4);
            this.vGridControl4.Name = "vGridControl4";
            this.vGridControl4.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit4});
            this.vGridControl4.Size = new System.Drawing.Size(581, 452);
            this.vGridControl4.TabIndex = 0;
            this.vGridControl4.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar;
            this.vGridControl4.HideCustomizationForm += new System.EventHandler(this.vGridControl_HideCustomizationForm);
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AllowFocused = false;
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.vGridControl1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(589, 460);
            this.tabPage1.Text = "Data Binding";
            // 
            // vGridControl1
            // 
            this.vGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.ImageList = this.imageCollection1;
            this.vGridControl1.Location = new System.Drawing.Point(4, 4);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemImageEdit1,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemMemoEdit1,
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemRadioGroup1});
            this.vGridControl1.RowHeaderWidth = 190;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowID,
            this.rowTrademark,
            this.rowModel,
            this.rowCategory,
            this.categoryRow1,
            this.categoryRow2,
            this.categoryRow3});
            this.vGridControl1.Size = new System.Drawing.Size(581, 452);
            this.vGridControl1.TabIndex = 0;
            this.vGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar;
            this.vGridControl1.HideCustomizationForm += new System.EventHandler(this.vGridControl_HideCustomizationForm);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("notes_16x16.png", "images/content/notes_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/notes_16x16.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "notes_16x16.png");
            this.imageCollection1.InsertGalleryImage("image_16x16.png", "images/content/image_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/image_16x16.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "image_16x16.png");
            this.imageCollection1.InsertGalleryImage("feature_16x16.png", "images/support/feature_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/feature_16x16.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "feature_16x16.png");
            this.imageCollection1.InsertGalleryImage("contact_16x16.png", "images/mail/contact_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/contact_16x16.png"), 3);
            this.imageCollection1.Images.SetKeyName(3, "contact_16x16.png");
            this.imageCollection1.InsertGalleryImage("home_16x16.png", "images/navigation/home_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/home_16x16.png"), 4);
            this.imageCollection1.Images.SetKeyName(4, "home_16x16.png");
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AllowFocused = false;
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AllowFocused = false;
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AllowFocused = false;
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AllowFocused = false;
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AllowFocused = false;
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sports", "SPORTS", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Saloon", "SALOON", 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Truck", "TRUCK", 4)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageList1;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AllowFocused = false;
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yes", "Yes", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("No", "No", 1)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            this.repositoryItemImageComboBox2.SmallImages = this.imageCollection3;
            // 
            // imageCollection3
            // 
            this.imageCollection3.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection3.ImageStream")));
            this.imageCollection3.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 0);
            this.imageCollection3.Images.SetKeyName(0, "apply_16x16.png");
            this.imageCollection3.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 1);
            this.imageCollection3.Images.SetKeyName(1, "cancel_16x16.png");
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.AllowFocused = false;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Yes", "Yes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("No", "No")});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // rowID
            // 
            this.rowID.Height = 16;
            this.rowID.Name = "rowID";
            this.rowID.Properties.Caption = "Record ID";
            this.rowID.Properties.FieldName = "ID";
            // 
            // rowTrademark
            // 
            this.rowTrademark.Name = "rowTrademark";
            this.rowTrademark.Properties.Caption = "Trademark";
            this.rowTrademark.Properties.FieldName = "Trademark";
            this.rowTrademark.Properties.ImageIndex = 2;
            this.rowTrademark.Properties.RowEdit = this.repositoryItemButtonEdit1;
            // 
            // rowModel
            // 
            this.rowModel.Height = 16;
            this.rowModel.Name = "rowModel";
            this.rowModel.Properties.Caption = "Model";
            this.rowModel.Properties.FieldName = "Model";
            // 
            // rowCategory
            // 
            this.rowCategory.Height = 19;
            this.rowCategory.Name = "rowCategory";
            this.rowCategory.Properties.Caption = "Category";
            this.rowCategory.Properties.FieldName = "Category";
            this.rowCategory.Properties.RowEdit = this.repositoryItemImageComboBox1;
            // 
            // categoryRow1
            // 
            this.categoryRow1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowHP,
            this.rowLiter,
            this.rowCyl,
            this.rowTransmiss_Speed_Count,
            this.rowTransmiss_Automatic,
            this.rowMPG});
            this.categoryRow1.Name = "categoryRow1";
            this.categoryRow1.Properties.Caption = "Performance Attributes";
            // 
            // rowHP
            // 
            this.rowHP.Name = "rowHP";
            this.rowHP.Properties.Caption = "HP";
            this.rowHP.Properties.FieldName = "HP";
            // 
            // rowLiter
            // 
            this.rowLiter.Name = "rowLiter";
            this.rowLiter.Properties.Caption = "Capacity";
            this.rowLiter.Properties.FieldName = "Liter";
            this.rowLiter.Properties.Format.FormatString = "#.### Liters";
            this.rowLiter.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // rowCyl
            // 
            this.rowCyl.Name = "rowCyl";
            this.rowCyl.Properties.Caption = "Cyl";
            this.rowCyl.Properties.FieldName = "Cyl";
            this.rowCyl.Properties.RowEdit = this.repositoryItemSpinEdit1;
            // 
            // rowTransmiss_Speed_Count
            // 
            this.rowTransmiss_Speed_Count.Name = "rowTransmiss_Speed_Count";
            this.rowTransmiss_Speed_Count.Properties.Caption = "# of Gears";
            this.rowTransmiss_Speed_Count.Properties.FieldName = "Transmiss Speed Count";
            this.rowTransmiss_Speed_Count.Properties.RowEdit = this.repositoryItemSpinEdit1;
            // 
            // rowTransmiss_Automatic
            // 
            this.rowTransmiss_Automatic.Name = "rowTransmiss_Automatic";
            this.rowTransmiss_Automatic.Properties.Caption = "Automatic Transmission";
            this.rowTransmiss_Automatic.Properties.FieldName = "Transmiss Automatic";
            this.rowTransmiss_Automatic.Properties.RowEdit = this.repositoryItemRadioGroup1;
            // 
            // rowMPG
            // 
            this.rowMPG.Name = "rowMPG";
            this.rowMPG.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.multiEditorRowProperties1,
            this.multiEditorRowProperties2});
            // 
            // categoryRow2
            // 
            this.categoryRow2.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowPicture,
            this.rowDescription,
            this.rowHyperlink});
            this.categoryRow2.Name = "categoryRow2";
            this.categoryRow2.Properties.Caption = "Notes";
            this.categoryRow2.Properties.ImageIndex = 0;
            // 
            // rowPicture
            // 
            this.rowPicture.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowIcon});
            this.rowPicture.Name = "rowPicture";
            this.rowPicture.Properties.Caption = "Picture";
            this.rowPicture.Properties.FieldName = "Picture";
            this.rowPicture.Properties.RowEdit = this.repositoryItemImageEdit1;
            // 
            // rowIcon
            // 
            this.rowIcon.Height = 52;
            this.rowIcon.Name = "rowIcon";
            this.rowIcon.Properties.Caption = "Icon";
            this.rowIcon.Properties.FieldName = "Icon";
            this.rowIcon.Properties.ImageIndex = 1;
            this.rowIcon.Properties.RowEdit = this.repositoryItemPictureEdit1;
            // 
            // rowDescription
            // 
            this.rowDescription.Name = "rowDescription";
            this.rowDescription.Properties.Caption = "Description";
            this.rowDescription.Properties.FieldName = "Description";
            this.rowDescription.Properties.RowEdit = this.repositoryItemMemoExEdit1;
            // 
            // rowHyperlink
            // 
            this.rowHyperlink.Name = "rowHyperlink";
            this.rowHyperlink.Properties.Caption = "Hyperlink";
            this.rowHyperlink.Properties.FieldName = "Hyperlink";
            this.rowHyperlink.Properties.RowEdit = this.repositoryItemHyperLinkEdit1;
            // 
            // categoryRow3
            // 
            this.categoryRow3.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowPrice,
            this.rowDelivery_Date,
            this.rowIs_In_Stock});
            this.categoryRow3.Name = "categoryRow3";
            this.categoryRow3.Properties.Caption = "Others";
            // 
            // rowPrice
            // 
            this.rowPrice.Name = "rowPrice";
            this.rowPrice.Properties.Caption = "Price";
            this.rowPrice.Properties.FieldName = "Price";
            this.rowPrice.Properties.Format.FormatString = "c";
            this.rowPrice.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rowPrice.Properties.RowEdit = this.repositoryItemCalcEdit1;
            // 
            // rowDelivery_Date
            // 
            this.rowDelivery_Date.Name = "rowDelivery_Date";
            this.rowDelivery_Date.Properties.Caption = "Delivery Date";
            this.rowDelivery_Date.Properties.FieldName = "Delivery Date";
            // 
            // rowIs_In_Stock
            // 
            this.rowIs_In_Stock.Name = "rowIs_In_Stock";
            this.rowIs_In_Stock.Properties.Caption = "In Stock?";
            this.rowIs_In_Stock.Properties.FieldName = "Is In Stock";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.vGridControl2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(589, 460);
            this.tabPage5.Text = "Simple Mode";
            // 
            // vGridControl2
            // 
            this.vGridControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl2.ImageList = this.imageCollection1;
            this.vGridControl2.Location = new System.Drawing.Point(4, 4);
            this.vGridControl2.Name = "vGridControl2";
            this.vGridControl2.RecordWidth = 198;
            this.vGridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox3,
            this.repositoryItemImageComboBox4,
            this.repositoryItemMemoEdit2,
            this.repositoryItemComboBox1,
            this.repositoryItemTextEdit5,
            this.repositoryItemTextEdit6,
            this.repositoryItemImageComboBox5,
            this.repositoryItemSpinEdit2,
            this.repositoryItemLookUpEdit1});
            this.vGridControl2.RowHeaderWidth = 194;
            this.vGridControl2.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.categoryRow4,
            this.categoryRow5,
            this.categoryRow6});
            this.vGridControl2.Size = new System.Drawing.Size(581, 452);
            this.vGridControl2.TabIndex = 0;
            this.vGridControl2.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar;
            this.vGridControl2.HideCustomizationForm += new System.EventHandler(this.vGridControl_HideCustomizationForm);
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AllowFocused = false;
            this.repositoryItemImageComboBox3.AutoHeight = false;
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Male", "M", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Female", "F", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Unknown", "N", -1)});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.AllowFocused = false;
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // repositoryItemTextEdit6
            // 
            this.repositoryItemTextEdit6.AllowFocused = false;
            this.repositoryItemTextEdit6.AutoHeight = false;
            this.repositoryItemTextEdit6.Mask.EditMask = "(999) 000-0000";
            this.repositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.repositoryItemTextEdit6.Name = "repositoryItemTextEdit6";
            // 
            // repositoryItemImageComboBox5
            // 
            this.repositoryItemImageComboBox5.AllowFocused = false;
            this.repositoryItemImageComboBox5.AutoHeight = false;
            this.repositoryItemImageComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox5.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Visa", "VS", 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("American Express", "AM", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Master", "MS", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cash", "CS", 1)});
            this.repositoryItemImageComboBox5.Name = "repositoryItemImageComboBox5";
            this.repositoryItemImageComboBox5.SmallImages = this.imageCollection2;
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageSize = new System.Drawing.Size(24, 16);
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.Images.SetKeyName(0, "amex.png");
            this.imageCollection2.Images.SetKeyName(1, "cash.png");
            this.imageCollection2.Images.SetKeyName(2, "master.png");
            this.imageCollection2.Images.SetKeyName(3, "visa.png");
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AllowFocused = false;
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit2.IsFloatValue = false;
            this.repositoryItemSpinEdit2.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AllowFocused = false;
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 40, "Product"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", 120, "Description")});
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.PopupWidth = 350;
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // categoryRow4
            // 
            this.categoryRow4.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow1,
            this.multiEditorRow1,
            this.editorRow2,
            this.editorRow3,
            this.editorRow5,
            this.multiEditorRow2,
            this.editorRow7,
            this.editorRow8});
            this.categoryRow4.Name = "categoryRow4";
            this.categoryRow4.Properties.Caption = "Client";
            this.categoryRow4.Properties.ImageIndex = 3;
            // 
            // editorRow1
            // 
            this.editorRow1.Name = "editorRow1";
            this.editorRow1.Properties.Caption = "Client ID";
            this.editorRow1.Properties.FieldName = "ClientID";
            // 
            // multiEditorRow1
            // 
            this.multiEditorRow1.Name = "multiEditorRow1";
            this.multiEditorRow1.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.multiEditorRowProperties3,
            this.multiEditorRowProperties4});
            // 
            // editorRow2
            // 
            this.editorRow2.Name = "editorRow2";
            this.editorRow2.Properties.Caption = "Company Name";
            this.editorRow2.Properties.FieldName = "CompanyName";
            // 
            // editorRow3
            // 
            this.editorRow3.Name = "editorRow3";
            this.editorRow3.Properties.Caption = "Customer";
            this.editorRow3.Properties.FieldName = "Customer";
            // 
            // editorRow5
            // 
            this.editorRow5.Name = "editorRow5";
            this.editorRow5.Properties.Caption = "Gender";
            this.editorRow5.Properties.FieldName = "Gender";
            this.editorRow5.Properties.RowEdit = this.repositoryItemImageComboBox3;
            // 
            // multiEditorRow2
            // 
            this.multiEditorRow2.Name = "multiEditorRow2";
            this.multiEditorRow2.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.multiEditorRowProperties5,
            this.multiEditorRowProperties6});
            // 
            // editorRow7
            // 
            this.editorRow7.Height = 45;
            this.editorRow7.Name = "editorRow7";
            this.editorRow7.Properties.Caption = "Interest (Ctrl+Enter - close editor)";
            this.editorRow7.Properties.FieldName = "Interest";
            this.editorRow7.Properties.RowEdit = this.repositoryItemMemoEdit2;
            // 
            // editorRow8
            // 
            this.editorRow8.Name = "editorRow8";
            this.editorRow8.Properties.Caption = "Date Open";
            this.editorRow8.Properties.FieldName = "DateOpen";
            // 
            // categoryRow5
            // 
            this.categoryRow5.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow4,
            this.multiEditorRow3,
            this.editorRow6});
            this.categoryRow5.Name = "categoryRow5";
            this.categoryRow5.Properties.Caption = "Address";
            // 
            // editorRow4
            // 
            this.editorRow4.Name = "editorRow4";
            this.editorRow4.Properties.Caption = "Address";
            this.editorRow4.Properties.FieldName = "Address";
            this.editorRow4.Properties.ImageIndex = 4;
            // 
            // multiEditorRow3
            // 
            this.multiEditorRow3.Name = "multiEditorRow3";
            this.multiEditorRow3.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.multiEditorRowProperties7,
            this.multiEditorRowProperties8,
            this.multiEditorRowProperties9});
            // 
            // editorRow6
            // 
            this.editorRow6.Name = "editorRow6";
            this.editorRow6.Properties.Caption = "Phone";
            this.editorRow6.Properties.FieldName = "Phone";
            this.editorRow6.Properties.RowEdit = this.repositoryItemTextEdit6;
            // 
            // categoryRow6
            // 
            this.categoryRow6.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow9,
            this.editorRow10,
            this.editorRow11,
            this.editorRow12,
            this.editorRow13});
            this.categoryRow6.Name = "categoryRow6";
            this.categoryRow6.Properties.Caption = "Payment Information";
            // 
            // editorRow9
            // 
            this.editorRow9.Name = "editorRow9";
            this.editorRow9.Properties.Caption = "Payment Type";
            this.editorRow9.Properties.FieldName = "PaymentType";
            this.editorRow9.Properties.RowEdit = this.repositoryItemImageComboBox5;
            // 
            // editorRow10
            // 
            this.editorRow10.Name = "editorRow10";
            this.editorRow10.Properties.Caption = "Payment Amount";
            this.editorRow10.Properties.FieldName = "PaymentAmount";
            this.editorRow10.Properties.Format.FormatString = "c";
            this.editorRow10.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.editorRow10.Properties.RowEdit = this.repositoryItemSpinEdit2;
            // 
            // editorRow11
            // 
            this.editorRow11.Name = "editorRow11";
            this.editorRow11.Properties.Caption = "Payment Date";
            this.editorRow11.Properties.FieldName = "PaymentDate";
            // 
            // editorRow12
            // 
            this.editorRow12.Name = "editorRow12";
            this.editorRow12.Properties.Caption = "Product";
            this.editorRow12.Properties.FieldName = "ProductID";
            this.editorRow12.Properties.RowEdit = this.repositoryItemLookUpEdit1;
            // 
            // editorRow13
            // 
            this.editorRow13.Name = "editorRow13";
            this.editorRow13.Properties.Caption = "Copies";
            this.editorRow13.Properties.FieldName = "Copies";
            this.editorRow13.Properties.RowEdit = this.repositoryItemSpinEdit2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.vGridControl3);
            this.tabPage7.Controls.Add(this.splitter2);
            this.tabPage7.Controls.Add(this.treeView1);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(589, 460);
            this.tabPage7.Text = "Runtime Row Creation";
            // 
            // vGridControl3
            // 
            this.vGridControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl3.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl3.Location = new System.Drawing.Point(157, 4);
            this.vGridControl3.Name = "vGridControl3";
            this.vGridControl3.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit3});
            this.vGridControl3.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways;
            this.vGridControl3.Size = new System.Drawing.Size(428, 452);
            this.vGridControl3.TabIndex = 0;
            this.vGridControl3.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar;
            this.vGridControl3.CustomDrawRowValueCell += new DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventHandler(this.vGridControl3_CustomDrawRowValueCell);
            this.vGridControl3.HideCustomizationForm += new System.EventHandler(this.vGridControl_HideCustomizationForm);
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AllowFocused = false;
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(152, 4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 452);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList4;
            this.treeView1.Location = new System.Drawing.Point(4, 4);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 3;
            treeNode1.Name = "";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "Build";
            treeNode2.Name = "";
            treeNode2.Text = "Debugging";
            treeNode3.Name = "";
            treeNode3.Text = "Advanced";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Configuration Properties";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.Size = new System.Drawing.Size(148, 452);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCollapse);
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList4
            // 
            this.imageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList4.ImageStream")));
            this.imageList4.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList4.Images.SetKeyName(0, "");
            this.imageList4.Images.SetKeyName(1, "");
            this.imageList4.Images.SetKeyName(2, "");
            this.imageList4.Images.SetKeyName(3, "");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(204, 0);
            this.splitter1.MinSize = 200;
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 488);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlMemo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(204, 488);
            this.pnlLeft.TabIndex = 4;
            // 
            // pnlMemo
            // 
            this.pnlMemo.Controls.Add(this.label6);
            this.pnlMemo.Controls.Add(this.lbHint);
            this.pnlMemo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMemo.Location = new System.Drawing.Point(2, 398);
            this.pnlMemo.Name = "pnlMemo";
            this.pnlMemo.Size = new System.Drawing.Size(200, 88);
            this.pnlMemo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 4;
            // 
            // lbHint
            // 
            this.lbHint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHint.Location = new System.Drawing.Point(28, 8);
            this.lbHint.Name = "lbHint";
            this.lbHint.Size = new System.Drawing.Size(168, 76);
            this.lbHint.TabIndex = 3;
            // 
            // PropertiesBase
            // 
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlLeft);
            this.Name = "PropertiesBase";
            this.Size = new System.Drawing.Size(804, 488);
            this.Load += new System.EventHandler(this.PropertiesBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlMemo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private XtraTabControl tcMain;
        private XtraTabPage tabPage1;
        private DevExpress.XtraEditors.SplitterControl splitter1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private System.ComponentModel.IContainer components;
        private XtraTabPage tabPage5;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        protected DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        protected DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private System.Windows.Forms.ImageList imageList1;
        private XtraTabPage tabPage7;
        private XtraTabPage tabPage8;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        protected DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTrademark;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowModel;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCategory;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowHP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowLiter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCyl;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTransmiss_Speed_Count;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTransmiss_Automatic;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow rowMPG;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowIcon;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPicture;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDescription;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowHyperlink;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPrice;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDelivery_Date;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowIs_In_Stock;
        protected System.Windows.Forms.ImageList imageList2;
        protected PanelControl pnlLeft;
        private System.Windows.Forms.Panel pnlMemo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbHint;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit6;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox5;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.TreeView treeView1;
        private DevExpress.XtraEditors.SplitterControl splitter2;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow1;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow multiEditorRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow5;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow multiEditorRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow7;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow8;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow5;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow4;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow multiEditorRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow6;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow6;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow9;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow10;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow11;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow12;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow13;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        protected DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private Rows.MultiEditorRowProperties multiEditorRowProperties1;
        private Rows.MultiEditorRowProperties multiEditorRowProperties2;
        private Rows.MultiEditorRowProperties multiEditorRowProperties3;
        private Rows.MultiEditorRowProperties multiEditorRowProperties4;
        private Rows.MultiEditorRowProperties multiEditorRowProperties5;
        private Rows.MultiEditorRowProperties multiEditorRowProperties6;
        private Rows.MultiEditorRowProperties multiEditorRowProperties7;
        private Rows.MultiEditorRowProperties multiEditorRowProperties8;
        private Rows.MultiEditorRowProperties multiEditorRowProperties9;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.Utils.ImageCollection imageCollection2;
        private DevExpress.Utils.ImageCollection imageCollection3;
    }
}
