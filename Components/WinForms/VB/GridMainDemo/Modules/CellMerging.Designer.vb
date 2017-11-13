Namespace DevExpress.XtraGrid.Demos
    Partial Public Class CellMerging
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CellMerging))
            Me.panel1 = New DevExpress.XtraEditors.PanelControl()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.ceMerging = New DevExpress.XtraEditors.CheckEdit()
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
            DirectCast(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            DirectCast(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            DirectCast(Me.ceMerging.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dsIssueList1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panel1
            ' 
            Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panel1.Controls.Add(Me.panelControl2)
            Me.panel1.Controls.Add(Me.ceMerging)
            resources.ApplyResources(Me.panel1, "panel1")
            Me.panel1.Name = "panel1"
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Controls.Add(Me.simpleButton1)
            resources.ApplyResources(Me.panelControl2, "panelControl2")
            Me.panelControl2.Name = "panelControl2"
            ' 
            ' simpleButton1
            ' 
            resources.ApplyResources(Me.simpleButton1, "simpleButton1")
            Me.simpleButton1.Name = "simpleButton1"
            ' 
            ' ceMerging
            ' 
            resources.ApplyResources(Me.ceMerging, "ceMerging")
            Me.ceMerging.Name = "ceMerging"
            Me.ceMerging.Properties.Caption = resources.GetString("ceMerging.Properties.Caption")
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.dsIssueList1.Items
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1, Me.repositoryItemLookUpEdit2, Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3})
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
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.AllowCellMerge = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.PreviewFieldName = "Description"
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {
                New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colProjectID, DevExpress.Data.ColumnSortOrder.Ascending),
                New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colType, DevExpress.Data.ColumnSortOrder.Ascending),
                New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPriority, DevExpress.Data.ColumnSortOrder.Ascending),
                New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colStatus, DevExpress.Data.ColumnSortOrder.Ascending)
            })
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
            ' CellMerging
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "CellMerging"
            DirectCast(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            DirectCast(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            DirectCast(Me.ceMerging.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dsIssueList1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents ceMerging As DevExpress.XtraEditors.CheckEdit
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
        Private components As System.ComponentModel.IContainer
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
