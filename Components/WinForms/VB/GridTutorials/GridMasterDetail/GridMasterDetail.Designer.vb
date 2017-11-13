Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
    Partial Public Class GridMasterDetail
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GridMasterDetail))
            Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
            Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colAge = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colParentID = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.dsParents1 = New dsParents
            Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colAge1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colName1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colParentID1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colImage1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.panel1 = New DevExpress.XtraEditors.PanelControl
            Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.label1 = New DevExpress.XtraEditors.LabelControl
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dsParents1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridView2
            '
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAge, Me.colName, Me.colParentID, Me.colImage})
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Images = Me.imageList1
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsView.ShowGroupPanel = False
            Me.gridView2.ViewCaption = "Sons"
            '
            'colAge
            '
            Me.colAge.Caption = "Age"
            Me.colAge.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colAge.FieldName = "Age"
            Me.colAge.Name = "colAge"
            Me.colAge.Visible = True
            Me.colAge.VisibleIndex = 2
            Me.colAge.Width = 270
            '
            'repositoryItemSpinEdit1
            '
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'colName
            '
            Me.colName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.colName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.colName.AppearanceCell.Options.UseFont = True
            Me.colName.AppearanceCell.Options.UseForeColor = True
            Me.colName.Caption = "Name"
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 1
            Me.colName.Width = 270
            '
            'colParentID
            '
            Me.colParentID.Caption = "ParentID"
            Me.colParentID.FieldName = "ParentID"
            Me.colParentID.Name = "colParentID"
            '
            'colImage
            '
            Me.colImage.ColumnEdit = Me.repositoryItemImageComboBox2
            Me.colImage.CustomizationCaption = "Image"
            Me.colImage.ImageAlignment = System.Drawing.StringAlignment.Center
            Me.colImage.ImageIndex = 2
            Me.colImage.Name = "colImage"
            Me.colImage.OptionsColumn.AllowEdit = False
            Me.colImage.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colImage.OptionsColumn.AllowMove = False
            Me.colImage.OptionsColumn.AllowSize = False
            Me.colImage.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colImage.OptionsColumn.FixedWidth = True
            Me.colImage.OptionsFilter.AllowFilter = False
            Me.colImage.Visible = True
            Me.colImage.VisibleIndex = 0
            Me.colImage.Width = 30
            '
            'repositoryItemImageComboBox2
            '
            Me.repositoryItemImageComboBox2.AutoHeight = False
            Me.repositoryItemImageComboBox2.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", Nothing, 1)})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.SmallImages = Me.imageList1
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            '
            'gridControl1
            '
            Me.gridControl1.DataSource = Me.dsParents1.Parents
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            GridLevelNode1.LevelTemplate = Me.gridView2
            GridLevelNode1.RelationName = "ParentsSons"
            GridLevelNode2.LevelTemplate = Me.gridView3
            GridLevelNode2.RelationName = "ParentsDaughters"
            Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
            Me.gridControl1.Location = New System.Drawing.Point(0, 76)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.Size = New System.Drawing.Size(598, 290)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView3, Me.gridView1, Me.gridView2})
            '
            'dsParents1
            '
            Me.dsParents1.DataSetName = "dsParents"
            Me.dsParents1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsParents1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'gridView3
            '
            Me.gridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAge1, Me.colName1, Me.colParentID1, Me.colImage1})
            Me.gridView3.GridControl = Me.gridControl1
            Me.gridView3.Images = Me.imageList1
            Me.gridView3.Name = "gridView3"
            Me.gridView3.OptionsView.ShowGroupPanel = False
            Me.gridView3.ViewCaption = "Daughters"
            '
            'colAge1
            '
            Me.colAge1.Caption = "Age"
            Me.colAge1.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colAge1.FieldName = "Age"
            Me.colAge1.Name = "colAge1"
            Me.colAge1.Visible = True
            Me.colAge1.VisibleIndex = 2
            Me.colAge1.Width = 271
            '
            'colName1
            '
            Me.colName1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
            Me.colName1.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colName1.AppearanceCell.Options.UseFont = True
            Me.colName1.AppearanceCell.Options.UseForeColor = True
            Me.colName1.Caption = "Name"
            Me.colName1.FieldName = "Name"
            Me.colName1.Name = "colName1"
            Me.colName1.Visible = True
            Me.colName1.VisibleIndex = 1
            Me.colName1.Width = 269
            '
            'colParentID1
            '
            Me.colParentID1.Caption = "ParentID"
            Me.colParentID1.FieldName = "ParentID"
            Me.colParentID1.Name = "colParentID1"
            '
            'colImage1
            '
            Me.colImage1.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colImage1.CustomizationCaption = "Image"
            Me.colImage1.ImageAlignment = System.Drawing.StringAlignment.Center
            Me.colImage1.ImageIndex = 2
            Me.colImage1.Name = "colImage1"
            Me.colImage1.OptionsColumn.AllowEdit = False
            Me.colImage1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colImage1.OptionsColumn.AllowMove = False
            Me.colImage1.OptionsColumn.AllowSize = False
            Me.colImage1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colImage1.OptionsColumn.FixedWidth = True
            Me.colImage1.OptionsFilter.AllowFilter = False
            Me.colImage1.Visible = True
            Me.colImage1.VisibleIndex = 0
            Me.colImage1.Width = 30
            '
            'repositoryItemImageComboBox1
            '
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", Nothing, 0)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.imageList1
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFirstName, Me.colID, Me.colLastName})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", Nothing, "")})
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsDetail.EnableDetailToolTip = True
            Me.gridView1.OptionsDetail.ShowDetailTabs = False
            Me.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
            '
            'colFirstName
            '
            Me.colFirstName.Caption = "FirstName"
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            Me.colFirstName.Visible = True
            Me.colFirstName.VisibleIndex = 1
            Me.colFirstName.Width = 214
            '
            'colID
            '
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.OptionsFilter.AllowFilter = False
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            Me.colID.Width = 136
            '
            'colLastName
            '
            Me.colLastName.Caption = "LastName"
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            Me.colLastName.Visible = True
            Me.colLastName.VisibleIndex = 2
            Me.colLastName.Width = 220
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.imageComboBoxEdit1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.checkEdit2)
            Me.panel1.Controls.Add(Me.checkEdit1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(598, 68)
            Me.panel1.TabIndex = 6
            '
            'imageComboBoxEdit1
            '
            Me.imageComboBoxEdit1.Location = New System.Drawing.Point(15, 35)
            Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
            Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit1.Size = New System.Drawing.Size(192, 20)
            Me.imageComboBoxEdit1.TabIndex = 5
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(15, 15)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(165, 13)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Smart Detail Expand Button Mode:"
            '
            'checkEdit2
            '
            Me.checkEdit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.checkEdit2.Location = New System.Drawing.Point(399, 33)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = "Show Detail Tabs"
            Me.checkEdit2.Size = New System.Drawing.Size(184, 18)
            Me.checkEdit2.TabIndex = 1
            '
            'checkEdit1
            '
            Me.checkEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.checkEdit1.Location = New System.Drawing.Point(399, 13)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Enable Detail ToolTip"
            Me.checkEdit1.Size = New System.Drawing.Size(184, 18)
            Me.checkEdit1.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 68)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(598, 8)
            Me.panelControl1.TabIndex = 9
            '
            'GridMasterDetail
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridMasterDetail"
            Me.Size = New System.Drawing.Size(598, 366)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dsParents1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private dsParents1 As dsParents
        Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
        Private colID As DevExpress.XtraGrid.Columns.GridColumn
        Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridView3 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colAge As DevExpress.XtraGrid.Columns.GridColumn
        Private colName As DevExpress.XtraGrid.Columns.GridColumn
        Private colParentID As DevExpress.XtraGrid.Columns.GridColumn
        Private colAge1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colName1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colParentID1 As DevExpress.XtraGrid.Columns.GridColumn
        Private imageList1 As System.Windows.Forms.ImageList
        Private colImage1 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private colImage As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private label1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents checkEdit2 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit
        Private components As System.ComponentModel.IContainer
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
