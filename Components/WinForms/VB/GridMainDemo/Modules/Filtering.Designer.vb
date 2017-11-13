Namespace DevExpress.XtraGrid.Demos
    Partial Public Class Filtering
        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Filtering))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.dsIssueList1 = New dsIssueList()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProjectID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOwnerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colFixedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCreatorID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
            Me.ceAllowFilter = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.sbInfo = New DevExpress.XtraEditors.SimpleButton()
            Me.ceColumnFilterList = New DevExpress.XtraEditors.CheckEdit()
            Me.ceFilterEditor = New DevExpress.XtraEditors.CheckEdit()
            Me.ceFilterList = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAdvDialog = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dsIssueList1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceAllowFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.ceColumnFilterList.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceFilterEditor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceFilterList.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceAdvDialog.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            DirectCast(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.dsIssueList1.Items
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1, Me.repositoryItemLookUpEdit2, Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3, Me.repositoryItemRadioGroup1})
            Me.gridControl1.Tag = "Design"
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' dsIssueList1
            ' 
            Me.dsIssueList1.DataSetName = "dsIssueList"
            Me.dsIssueList1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsIssueList1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProjectID, Me.colType, Me.colName, Me.colPriority, Me.colStatus, Me.colCreatedDate, Me.colOwnerID, Me.colFixedDate, Me.colCreatorID, Me.colModifiedDate})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
            Me.gridView1.OptionsView.ShowFooter = True
            Me.gridView1.PreviewFieldName = "Description"
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPriority, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' colProjectID
            ' 
            resources.ApplyResources(Me.colProjectID, "colProjectID")
            Me.colProjectID.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.colProjectID.FieldName = "ProjectID"
            Me.colProjectID.Name = "colProjectID"
            ' 
            ' repositoryItemLookUpEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemLookUpEdit1, "repositoryItemLookUpEdit1")
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns"), resources.GetString("repositoryItemLookUpEdit1.Columns1"), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns2"), Integer)), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns3"), DevExpress.Utils.FormatType)), resources.GetString("repositoryItemLookUpEdit1.Columns4"), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns5"), Boolean)), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns6"), DevExpress.Utils.HorzAlignment)))})
            Me.repositoryItemLookUpEdit1.DataSource = Me.dsIssueList1.Projects
            Me.repositoryItemLookUpEdit1.DisplayMember = "Name"
            Me.repositoryItemLookUpEdit1.DropDownRows = 3
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 200
            Me.repositoryItemLookUpEdit1.ShowFooter = False
            Me.repositoryItemLookUpEdit1.ShowHeader = False
            Me.repositoryItemLookUpEdit1.ValueMember = "ID"
            ' 
            ' colType
            ' 
            resources.ApplyResources(Me.colType, "colType")
            Me.colType.ColumnEdit = Me.repositoryItemImageComboBox3
            Me.colType.FieldName = "Type"
            Me.colType.Name = "colType"
            ' 
            ' repositoryItemImageComboBox3
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox3, "repositoryItemImageComboBox3")
            Me.repositoryItemImageComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemImageComboBox3.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items"), (DirectCast(resources.GetObject("repositoryItemImageComboBox3.Items1"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox3.Items2"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items3"), (DirectCast(resources.GetObject("repositoryItemImageComboBox3.Items4"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox3.Items5"), Integer)))
            })
            Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
            Me.repositoryItemImageComboBox3.SmallImages = Me.imageList1
            ' 
            ' imageList1
            ' 
            Me.imageList1.ImageStream = (DirectCast(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            Me.imageList1.Images.SetKeyName(4, "")
            Me.imageList1.Images.SetKeyName(5, "")
            Me.imageList1.Images.SetKeyName(6, "")
            Me.imageList1.Images.SetKeyName(7, "")
            Me.imageList1.Images.SetKeyName(8, "")
            ' 
            ' colName
            ' 
            resources.ApplyResources(Me.colName, "colName")
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((DirectCast(resources.GetObject("colName.Summary"), DevExpress.Data.SummaryItemType)))})
            ' 
            ' colPriority
            ' 
            resources.ApplyResources(Me.colPriority, "colPriority")
            Me.colPriority.ColumnEdit = Me.repositoryItemImageComboBox2
            Me.colPriority.FieldName = "Priority"
            Me.colPriority.Name = "colPriority"
            Me.colPriority.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            Me.colPriority.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
            ' 
            ' repositoryItemImageComboBox2
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox2, "repositoryItemImageComboBox2")
            Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemImageComboBox2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items"), (DirectCast(resources.GetObject("repositoryItemImageComboBox2.Items1"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox2.Items2"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items3"), (DirectCast(resources.GetObject("repositoryItemImageComboBox2.Items4"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox2.Items5"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items6"), (DirectCast(resources.GetObject("repositoryItemImageComboBox2.Items7"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox2.Items8"), Integer)))
            })
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.SmallImages = Me.imageList1
            ' 
            ' colStatus
            ' 
            resources.ApplyResources(Me.colStatus, "colStatus")
            Me.colStatus.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colStatus.FieldName = "Status"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            Me.colStatus.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemImageComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items1"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items2"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items4"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items5"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items7"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items8"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items10"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items11"), Integer)))
            })
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.imageList1
            ' 
            ' colCreatedDate
            ' 
            resources.ApplyResources(Me.colCreatedDate, "colCreatedDate")
            Me.colCreatedDate.FieldName = "CreatedDate"
            Me.colCreatedDate.Name = "colCreatedDate"
            Me.colCreatedDate.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((DirectCast(resources.GetObject("colCreatedDate.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("colCreatedDate.Summary1"), resources.GetString("colCreatedDate.Summary2"))})
            ' 
            ' colOwnerID
            ' 
            resources.ApplyResources(Me.colOwnerID, "colOwnerID")
            Me.colOwnerID.ColumnEdit = Me.repositoryItemLookUpEdit2
            Me.colOwnerID.FieldName = "OwnerID"
            Me.colOwnerID.Name = "colOwnerID"
            ' 
            ' repositoryItemLookUpEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemLookUpEdit2, "repositoryItemLookUpEdit2")
            Me.repositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemLookUpEdit2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit2.Columns"), resources.GetString("repositoryItemLookUpEdit2.Columns1"), (DirectCast(resources.GetObject("repositoryItemLookUpEdit2.Columns2"), Integer)), (DirectCast(resources.GetObject("repositoryItemLookUpEdit2.Columns3"), DevExpress.Utils.FormatType)), resources.GetString("repositoryItemLookUpEdit2.Columns4"), (DirectCast(resources.GetObject("repositoryItemLookUpEdit2.Columns5"), Boolean)), (DirectCast(resources.GetObject("repositoryItemLookUpEdit2.Columns6"), DevExpress.Utils.HorzAlignment)))})
            Me.repositoryItemLookUpEdit2.DataSource = Me.dsIssueList1.Users
            Me.repositoryItemLookUpEdit2.DisplayMember = "FullName"
            Me.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2"
            Me.repositoryItemLookUpEdit2.ShowFooter = False
            Me.repositoryItemLookUpEdit2.ShowHeader = False
            Me.repositoryItemLookUpEdit2.ValueMember = "ID"
            ' 
            ' colFixedDate
            ' 
            resources.ApplyResources(Me.colFixedDate, "colFixedDate")
            Me.colFixedDate.FieldName = "FixedDate"
            Me.colFixedDate.Name = "colFixedDate"
            ' 
            ' colCreatorID
            ' 
            resources.ApplyResources(Me.colCreatorID, "colCreatorID")
            Me.colCreatorID.ColumnEdit = Me.repositoryItemLookUpEdit2
            Me.colCreatorID.FieldName = "CreatorID"
            Me.colCreatorID.Name = "colCreatorID"
            ' 
            ' colModifiedDate
            ' 
            resources.ApplyResources(Me.colModifiedDate, "colModifiedDate")
            Me.colModifiedDate.FieldName = "ModifiedDate"
            Me.colModifiedDate.Name = "colModifiedDate"
            ' 
            ' repositoryItemRadioGroup1
            ' 
            Me.repositoryItemRadioGroup1.Columns = 2
            Me.repositoryItemRadioGroup1.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
                New DevExpress.XtraEditors.Controls.RadioGroupItem((DirectCast(resources.GetObject("repositoryItemRadioGroup1.Items"), Object)), resources.GetString("repositoryItemRadioGroup1.Items1")),
                New DevExpress.XtraEditors.Controls.RadioGroupItem((DirectCast(resources.GetObject("repositoryItemRadioGroup1.Items2"), Object)), resources.GetString("repositoryItemRadioGroup1.Items3"))
            })
            Me.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1"
            ' 
            ' ceAllowFilter
            ' 
            resources.ApplyResources(Me.ceAllowFilter, "ceAllowFilter")
            Me.ceAllowFilter.Name = "ceAllowFilter"
            Me.ceAllowFilter.Properties.Appearance.Font = (DirectCast(resources.GetObject("ceAllowFilter.Properties.Appearance.Font"), System.Drawing.Font))
            Me.ceAllowFilter.Properties.Appearance.Options.UseFont = True
            Me.ceAllowFilter.Properties.Caption = resources.GetString("ceAllowFilter.Properties.Caption")
            Me.ceAllowFilter.StyleController = Me.layoutControl1
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.sbInfo)
            Me.layoutControl1.Controls.Add(Me.ceAllowFilter)
            Me.layoutControl1.Controls.Add(Me.ceColumnFilterList)
            Me.layoutControl1.Controls.Add(Me.ceFilterEditor)
            Me.layoutControl1.Controls.Add(Me.ceFilterList)
            Me.layoutControl1.Controls.Add(Me.ceAdvDialog)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' sbInfo
            ' 
            resources.ApplyResources(Me.sbInfo, "sbInfo")
            Me.sbInfo.Name = "sbInfo"
            Me.sbInfo.StyleController = Me.layoutControl1
            ' 
            ' ceColumnFilterList
            ' 
            resources.ApplyResources(Me.ceColumnFilterList, "ceColumnFilterList")
            Me.ceColumnFilterList.Name = "ceColumnFilterList"
            Me.ceColumnFilterList.Properties.Caption = resources.GetString("ceColumnFilterList.Properties.Caption")
            Me.ceColumnFilterList.StyleController = Me.layoutControl1
            ' 
            ' ceFilterEditor
            ' 
            resources.ApplyResources(Me.ceFilterEditor, "ceFilterEditor")
            Me.ceFilterEditor.Name = "ceFilterEditor"
            Me.ceFilterEditor.Properties.Caption = resources.GetString("ceFilterEditor.Properties.Caption")
            Me.ceFilterEditor.StyleController = Me.layoutControl1
            ' 
            ' ceFilterList
            ' 
            resources.ApplyResources(Me.ceFilterList, "ceFilterList")
            Me.ceFilterList.Name = "ceFilterList"
            Me.ceFilterList.Properties.Caption = resources.GetString("ceFilterList.Properties.Caption")
            Me.ceFilterList.StyleController = Me.layoutControl1
            ' 
            ' ceAdvDialog
            ' 
            resources.ApplyResources(Me.ceAdvDialog, "ceAdvDialog")
            Me.ceAdvDialog.Name = "ceAdvDialog"
            Me.ceAdvDialog.Properties.Caption = resources.GetString("ceAdvDialog.Properties.Caption")
            Me.ceAdvDialog.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.layoutControlItem2, Me.emptySpaceItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(202, 432)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceAllowFilter
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(182, 23)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 125)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(182, 261)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceFilterEditor
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 33)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(182, 23)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 23)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(182, 10)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceAdvDialog
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 56)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(182, 23)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceFilterList
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 79)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(182, 23)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceColumnFilterList
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 102)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(182, 23)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.sbInfo
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 386)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(182, 26)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' imageList2
            ' 
            Me.imageList2.ImageStream = (DirectCast(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList2.Images.SetKeyName(0, "")
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.AllowHtmlText = True
            Me.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.Standard
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(252, 492)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.SelectedPageIndex = 0
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Image = (DirectCast(resources.GetObject("navigationPage1.Image"), System.Drawing.Image))
            Me.navigationPage1.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.panelControl2, "panelControl2")
            Me.panelControl2.Name = "panelControl2"
            ' 
            ' Filtering
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "Filtering"
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dsIssueList1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceAllowFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.ceColumnFilterList.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceFilterEditor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceFilterList.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceAdvDialog.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            DirectCast(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colProjectID As DevExpress.XtraGrid.Columns.GridColumn
        Private colType As DevExpress.XtraGrid.Columns.GridColumn
        Private colName As DevExpress.XtraGrid.Columns.GridColumn
        Private colPriority As DevExpress.XtraGrid.Columns.GridColumn
        Private colStatus As DevExpress.XtraGrid.Columns.GridColumn
        Private colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colOwnerID As DevExpress.XtraGrid.Columns.GridColumn
        Private colFixedDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colCreatorID As DevExpress.XtraGrid.Columns.GridColumn
        Private colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Private repositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Private dsIssueList1 As dsIssueList
        Private imageList1 As System.Windows.Forms.ImageList
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private repositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
        Private WithEvents sbInfo As DevExpress.XtraEditors.SimpleButton
        Private WithEvents ceAllowFilter As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceColumnFilterList As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceFilterList As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceAdvDialog As DevExpress.XtraEditors.CheckEdit
        Private imageList2 As System.Windows.Forms.ImageList
        Private WithEvents ceFilterEditor As DevExpress.XtraEditors.CheckEdit
        Private components As System.ComponentModel.IContainer
        Private toolTipController1 As Utils.ToolTipController
        Private layoutControl1 As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private layoutControlItem6 As XtraLayout.LayoutControlItem
        Private navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private panelControl2 As XtraEditors.PanelControl
    End Class
End Namespace
