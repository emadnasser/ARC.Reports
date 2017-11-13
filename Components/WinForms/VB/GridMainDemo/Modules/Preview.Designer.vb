Imports DevExpress.Export

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class Preview
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Preview))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
            Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
            Me.ceUseMeasurePreviewHeight = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cbName = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceAuto = New DevExpress.XtraEditors.CheckEdit()
            Me.ceCustom = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.pnlGrid = New DevExpress.XtraEditors.PanelControl()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceUseMeasurePreviewHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.cbName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAuto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceCustom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType(Me.pnlGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlGrid.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageEdit1, Me.repositoryItemMemoExEdit1, Me.repositoryItemTextEdit1})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsPrint.PrintPreview = True
            Me.gridView1.OptionsView.ShowPreview = True
            '
            'gridColumn1
            '
            resources.ApplyResources(Me.gridColumn1, "gridColumn1")
            Me.gridColumn1.FieldName = "FirstName"
            Me.gridColumn1.Name = "gridColumn1"
            '
            'gridColumn2
            '
            resources.ApplyResources(Me.gridColumn2, "gridColumn2")
            Me.gridColumn2.FieldName = "LastName"
            Me.gridColumn2.Name = "gridColumn2"
            '
            'gridColumn3
            '
            resources.ApplyResources(Me.gridColumn3, "gridColumn3")
            Me.gridColumn3.FieldName = "Title"
            Me.gridColumn3.Name = "gridColumn3"
            '
            'gridColumn4
            '
            resources.ApplyResources(Me.gridColumn4, "gridColumn4")
            Me.gridColumn4.FieldName = "BirthDate"
            Me.gridColumn4.Name = "gridColumn4"
            '
            'gridColumn5
            '
            resources.ApplyResources(Me.gridColumn5, "gridColumn5")
            Me.gridColumn5.ColumnEdit = Me.repositoryItemTextEdit1
            Me.gridColumn5.FieldName = "HomePhone"
            Me.gridColumn5.Name = "gridColumn5"
            '
            'repositoryItemTextEdit1
            '
            resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
            Me.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask")
            Me.repositoryItemTextEdit1.Mask.MaskType = CType(resources.GetObject("repositoryItemTextEdit1.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            '
            'gridColumn6
            '
            resources.ApplyResources(Me.gridColumn6, "gridColumn6")
            Me.gridColumn6.ColumnEdit = Me.repositoryItemMemoExEdit1
            Me.gridColumn6.FieldName = "Notes"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.OptionsFilter.AllowFilter = False
            '
            'repositoryItemMemoExEdit1
            '
            resources.ApplyResources(Me.repositoryItemMemoExEdit1, "repositoryItemMemoExEdit1")
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("repositoryItemMemoExEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            '
            'gridColumn7
            '
            resources.ApplyResources(Me.gridColumn7, "gridColumn7")
            Me.gridColumn7.ColumnEdit = Me.repositoryItemImageEdit1
            Me.gridColumn7.FieldName = "Photo"
            Me.gridColumn7.Name = "gridColumn7"
            '
            'repositoryItemImageEdit1
            '
            resources.ApplyResources(Me.repositoryItemImageEdit1, "repositoryItemImageEdit1")
            Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("repositoryItemImageEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
            Me.repositoryItemImageEdit1.PopupFormSize = New System.Drawing.Size(220, 220)
            '
            'ceUseMeasurePreviewHeight
            '
            resources.ApplyResources(Me.ceUseMeasurePreviewHeight, "ceUseMeasurePreviewHeight")
            Me.ceUseMeasurePreviewHeight.Name = "ceUseMeasurePreviewHeight"
            Me.ceUseMeasurePreviewHeight.Properties.Caption = resources.GetString("ceUseMeasurePreviewHeight.Properties.Caption")
            Me.ceUseMeasurePreviewHeight.StyleController = Me.layoutControl1
            '
            'layoutControl1
            '
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceUseMeasurePreviewHeight)
            Me.layoutControl1.Controls.Add(Me.cbName)
            Me.layoutControl1.Controls.Add(Me.ceAuto)
            Me.layoutControl1.Controls.Add(Me.ceCustom)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            '
            'cbName
            '
            resources.ApplyResources(Me.cbName, "cbName")
            Me.cbName.Name = "cbName"
            Me.cbName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cbName.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.cbName.Properties.DropDownRows = 10
            Me.cbName.StyleController = Me.layoutControl1
            '
            'ceAuto
            '
            resources.ApplyResources(Me.ceAuto, "ceAuto")
            Me.ceAuto.Name = "ceAuto"
            Me.ceAuto.Properties.Caption = resources.GetString("ceAuto.Properties.Caption")
            Me.ceAuto.StyleController = Me.layoutControl1
            '
            'ceCustom
            '
            resources.ApplyResources(Me.ceCustom, "ceCustom")
            Me.ceCustom.Name = "ceCustom"
            Me.ceCustom.Properties.Caption = resources.GetString("ceCustom.Properties.Caption")
            Me.ceCustom.StyleController = Me.layoutControl1
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.emptySpaceItem1, Me.emptySpaceItem2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(237, 426)
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.ceAuto
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(217, 23)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.ceCustom
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(217, 23)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.ceUseMeasurePreviewHeight
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 46)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(217, 23)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.cbName
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 80)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(217, 40)
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(97, 13)
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 120)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(217, 286)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'emptySpaceItem2
            '
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 69)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(217, 11)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'navigationPane1
            '
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(287, 486)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.SelectedPageIndex = 0
            '
            'navigationPage1
            '
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Image = CType(resources.GetObject("navigationPage1.Image"), System.Drawing.Image)
            Me.navigationPage1.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            '
            'pnlGrid
            '
            Me.pnlGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlGrid.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.pnlGrid, "pnlGrid")
            Me.pnlGrid.Name = "pnlGrid"
            '
            'Preview
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlGrid)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "Preview"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceUseMeasurePreviewHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.cbName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAuto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceCustom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType(Me.pnlGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlGrid.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Private WithEvents ceCustom As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceAuto As DevExpress.XtraEditors.CheckEdit
        Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private WithEvents ceUseMeasurePreviewHeight As DevExpress.XtraEditors.CheckEdit
        Private components As System.ComponentModel.Container = Nothing
        Private WithEvents cbName As DevExpress.XtraEditors.ImageComboBoxEdit
        Private layoutControl1 As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private pnlGrid As XtraEditors.PanelControl
    End Class
End Namespace
