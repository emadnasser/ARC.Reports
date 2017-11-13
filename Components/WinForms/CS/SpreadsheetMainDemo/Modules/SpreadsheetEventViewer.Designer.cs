namespace DevExpress.XtraSpreadsheet.Demos {
    partial class SpreadsheetEventViewerModule {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpreadsheetEventViewerModule));
            this.eventsCheckedListBox = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.clearButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.expandButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.collapseButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.customDrawCellBarEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.appendExpandedBox = new DevExpress.XtraBars.BarCheckItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.loggerControl = new DevExpress.XtraTreeList.TreeList();
            this.eventNameColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.argsTypeColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.valueColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkAllEdit = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsCheckedListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsCheckedListBox
            // 
            this.eventsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsCheckedListBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.eventsCheckedListBox.CheckOnClick = true;
            this.eventsCheckedListBox.Location = new System.Drawing.Point(2, 22);
            this.eventsCheckedListBox.Name = "eventsCheckedListBox";
            this.eventsCheckedListBox.Size = new System.Drawing.Size(245, 267);
            this.eventsCheckedListBox.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.eventsCheckedListBox.TabIndex = 7;
            this.eventsCheckedListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.eventsCheckedListBox_ItemCheck);
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.AllowDrop = true;
            this.spreadsheetControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheetControl1.Location = new System.Drawing.Point(3, 3);
            this.spreadsheetControl1.MenuManager = this.barManager1;
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Size = new System.Drawing.Size(710, 291);
            this.spreadsheetControl1.TabIndex = 6;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.clearButtonItem,
            this.expandButtonItem,
            this.collapseButtonItem,
            this.appendExpandedBox,
            this.barEditItem1,
            this.barStaticItem1,
            this.customDrawCellBarEdit,
            this.barStaticItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 2";
            this.bar2.CanDockStyle = ((DevExpress.XtraBars.BarCanDockStyle)(((((DevExpress.XtraBars.BarCanDockStyle.Left | DevExpress.XtraBars.BarCanDockStyle.Top) 
            | DevExpress.XtraBars.BarCanDockStyle.Right) 
            | DevExpress.XtraBars.BarCanDockStyle.Bottom) 
            | DevExpress.XtraBars.BarCanDockStyle.Standalone)));
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.FloatLocation = new System.Drawing.Point(580, 457);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.clearButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.expandButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.collapseButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.customDrawCellBarEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.appendExpandedBox, true)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar2.Text = "Custom 2";
            // 
            // clearButtonItem
            // 
            this.clearButtonItem.Caption = "Clear Log";
            this.clearButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("clearButtonItem.Glyph")));
            this.clearButtonItem.Id = 0;
            this.clearButtonItem.Name = "clearButtonItem";
            this.clearButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearButtonItem_ItemClick);
            // 
            // expandButtonItem
            // 
            this.expandButtonItem.Caption = "Expand All Log Records";
            this.expandButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("expandButtonItem.Glyph")));
            this.expandButtonItem.Id = 2;
            this.expandButtonItem.Name = "expandButtonItem";
            this.expandButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.expandButtonItem_ItemClick);
            // 
            // collapseButtonItem
            // 
            this.collapseButtonItem.Caption = "Collapse All Log Records";
            this.collapseButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("collapseButtonItem.Glyph")));
            this.collapseButtonItem.Id = 3;
            this.collapseButtonItem.Name = "collapseButtonItem";
            this.collapseButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.collapseButtonItem_ItemClick);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = " ";
            this.barStaticItem2.Id = 12;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = " Log CustomDraw For Cell:";
            this.barStaticItem1.Id = 10;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // customDrawCellBarEdit
            // 
            this.customDrawCellBarEdit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.customDrawCellBarEdit.Caption = "Enter cell reference to log CustomDrawCell and CustomDrawCellBackground events fo" +
    "r that cell.";
            this.customDrawCellBarEdit.Edit = this.repositoryItemTextEdit2;
            this.customDrawCellBarEdit.Id = 11;
            this.customDrawCellBarEdit.Name = "customDrawCellBarEdit";
            this.customDrawCellBarEdit.EditValueChanged += new System.EventHandler(this.customDrawCellBarEdit_EditValueChanged);
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "[A-Za-z]{1,3}[1-9]\\d{0,2}";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // appendExpandedBox
            // 
            this.appendExpandedBox.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.appendExpandedBox.Caption = "Append Expanded";
            this.appendExpandedBox.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.appendExpandedBox.Id = 6;
            this.appendExpandedBox.Name = "appendExpandedBox";
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(969, 23);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(973, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 513);
            this.barDockControlBottom.Size = new System.Drawing.Size(973, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 513);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(973, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 513);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Log CustomDraw For Cell:";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 8;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 54;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // loggerControl
            // 
            this.loggerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loggerControl.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.eventNameColumn,
            this.argsTypeColumn,
            this.valueColumn});
            this.loggerControl.Location = new System.Drawing.Point(3, 26);
            this.loggerControl.Name = "loggerControl";
            this.loggerControl.OptionsBehavior.Editable = false;
            this.loggerControl.OptionsLayout.AddNewColumns = false;
            this.loggerControl.OptionsView.ShowHorzLines = false;
            this.loggerControl.OptionsView.ShowIndicator = false;
            this.loggerControl.OptionsView.ShowVertLines = false;
            this.loggerControl.Size = new System.Drawing.Size(963, 167);
            this.loggerControl.TabIndex = 13;
            // 
            // eventNameColumn
            // 
            this.eventNameColumn.Caption = "Event Name";
            this.eventNameColumn.FieldName = "Name";
            this.eventNameColumn.Name = "eventNameColumn";
            this.eventNameColumn.OptionsColumn.ReadOnly = true;
            this.eventNameColumn.Visible = true;
            this.eventNameColumn.VisibleIndex = 0;
            this.eventNameColumn.Width = 205;
            // 
            // argsTypeColumn
            // 
            this.argsTypeColumn.Caption = "Event Data Type";
            this.argsTypeColumn.FieldName = "ArgsType";
            this.argsTypeColumn.Name = "argsTypeColumn";
            this.argsTypeColumn.OptionsColumn.ReadOnly = true;
            this.argsTypeColumn.Visible = true;
            this.argsTypeColumn.VisibleIndex = 1;
            this.argsTypeColumn.Width = 240;
            // 
            // valueColumn
            // 
            this.valueColumn.Caption = "Event Data Values";
            this.valueColumn.FieldName = "Value";
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.OptionsColumn.ReadOnly = true;
            this.valueColumn.Visible = true;
            this.valueColumn.VisibleIndex = 2;
            this.valueColumn.Width = 396;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.spreadsheetControl1);
            this.splitContainerControl1.Panel1.MinSize = 200;
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.splitContainerControl1.Panel2.Controls.Add(this.standaloneBarDockControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.loggerControl);
            this.splitContainerControl1.Panel2.MinSize = 200;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(973, 513);
            this.splitContainerControl1.SplitterPosition = 308;
            this.splitContainerControl1.TabIndex = 13;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.checkAllEdit);
            this.panelControl1.Controls.Add(this.eventsCheckedListBox);
            this.panelControl1.Location = new System.Drawing.Point(717, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(249, 291);
            this.panelControl1.TabIndex = 12;
            // 
            // checkAllEdit
            // 
            this.checkAllEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAllEdit.Location = new System.Drawing.Point(2, 2);
            this.checkAllEdit.Name = "checkAllEdit";
            this.checkAllEdit.Properties.Caption = "All";
            this.checkAllEdit.Size = new System.Drawing.Size(239, 19);
            this.checkAllEdit.TabIndex = 8;
            this.checkAllEdit.CheckStateChanged += new System.EventHandler(this.checkAllEdit_CheckStateChanged);
            // 
            // SpreadsheetEventViewerModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SpreadsheetEventViewerModule";
            this.Size = new System.Drawing.Size(973, 513);
            ((System.ComponentModel.ISupportInitialize)(this.eventsCheckedListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkAllEdit.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private XtraEditors.CheckedListBoxControl eventsCheckedListBox;
        private SpreadsheetControl spreadsheetControl1;
        private XtraTreeList.TreeList loggerControl;
        private XtraTreeList.Columns.TreeListColumn eventNameColumn;
        private XtraTreeList.Columns.TreeListColumn argsTypeColumn;
        private XtraTreeList.Columns.TreeListColumn valueColumn;
        private XtraEditors.SplitContainerControl splitContainerControl1;
        private XtraEditors.PanelControl panelControl1;
        private XtraEditors.CheckEdit checkAllEdit;
        private XtraBars.BarManager barManager1;
        private XtraBars.Bar bar2;
        private XtraBars.BarButtonItem clearButtonItem;
        private XtraBars.BarButtonItem expandButtonItem;
        private XtraBars.BarButtonItem collapseButtonItem;
        private XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraBars.BarCheckItem appendExpandedBox;
        private XtraBars.BarEditItem barEditItem1;
        private XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private XtraBars.BarStaticItem barStaticItem1;
        private XtraBars.BarEditItem customDrawCellBarEdit;
        private XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private XtraBars.BarStaticItem barStaticItem2;

    }
}
