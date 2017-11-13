Namespace XtraPrintingDemos.XtraGrid
    Partial Public Class PreviewControl
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing
        Private printingSystem As DevExpress.XtraPrinting.PrintingSystem

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.printingSystem = New DevExpress.XtraPrinting.PrintingSystem()
            Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(PreviewControl))
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New XtraPrintingDemos.nwindDataSet()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.categoriesTableAdapter = New XtraPrintingDemos.nwindDataSetTableAdapters.CategoriesTableAdapter()
            Me.gridLink = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
            Me.productsTableAdapter = New XtraPrintingDemos.nwindDataSetTableAdapters.ProductsTableAdapter()
            CType(Me.printingSystem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' pControl
            ' 
            Me.pControl.DocumentSource = Me.printingSystem
            Me.pControl.Size = New System.Drawing.Size(641, 329)
            ' 
            ' printingSystem
            ' 
            Me.printingSystem.Links.AddRange(New Object() { Me.gridLink})
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Location = New System.Drawing.Point(645, 141)
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(566, 333)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(566, 333)
            Me.navigationPane1.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Default
            Me.navigationPane1.Visible = True
            ' 
            ' gridView2
            ' 
            Me.gridView2.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.gridView2.AppearancePrint.HeaderPanel.Options.UseBackColor = True
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductName})
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsBehavior.Editable = False
            Me.gridView2.OptionsView.ShowGroupPanel = False
            Me.gridView2.OptionsView.ShowIndicator = False
            ' 
            ' colProductName
            ' 
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colProductName.OptionsFilter.AllowFilter = False
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 0
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.categoriesBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            gridLevelNode1.LevelTemplate = Me.gridView2
            gridLevelNode1.RelationName = "CategoriesProducts"
            Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(523, 273)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
            ' 
            ' categoriesBindingSource
            ' 
            Me.categoriesBindingSource.DataMember = "Categories"
            Me.categoriesBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridView1
            ' 
            Me.gridView1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.gridView1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryName, Me.colDescription, Me.colPicture})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsPrint.ExpandAllDetails = True
            Me.gridView1.OptionsPrint.PrintDetails = True
            Me.gridView1.OptionsView.RowAutoHeight = True
            Me.gridView1.OptionsView.ShowGroupExpandCollapseButtons = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            ' 
            ' colCategoryName
            ' 
            Me.colCategoryName.FieldName = "CategoryName"
            Me.colCategoryName.Name = "colCategoryName"
            Me.colCategoryName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            Me.colCategoryName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
            Me.colCategoryName.OptionsColumn.AllowMove = False
            Me.colCategoryName.OptionsColumn.AllowShowHide = False
            Me.colCategoryName.OptionsFilter.AllowFilter = False
            Me.colCategoryName.Visible = True
            Me.colCategoryName.VisibleIndex = 1
            Me.colCategoryName.Width = 164
            ' 
            ' colDescription
            ' 
            Me.colDescription.AppearanceCell.Options.UseTextOptions = True
            Me.colDescription.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            Me.colDescription.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
            Me.colDescription.OptionsColumn.AllowMove = False
            Me.colDescription.OptionsColumn.AllowShowHide = False
            Me.colDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colDescription.OptionsFilter.AllowFilter = False
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 2
            Me.colDescription.Width = 244
            ' 
            ' colPicture
            ' 
            Me.colPicture.FieldName = "Picture"
            Me.colPicture.Name = "colPicture"
            Me.colPicture.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            Me.colPicture.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
            Me.colPicture.OptionsColumn.AllowMove = False
            Me.colPicture.OptionsColumn.AllowShowHide = False
            Me.colPicture.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colPicture.OptionsFilter.AllowFilter = False
            Me.colPicture.Visible = True
            Me.colPicture.VisibleIndex = 0
            Me.colPicture.Width = 113
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            Me.repositoryItemMemoEdit1.ReadOnly = True
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Products by Categories"
            Me.navigationPage1.Controls.Add(Me.gridControl1)
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(523, 273)
            ' 
            ' categoriesTableAdapter
            ' 
            Me.categoriesTableAdapter.ClearBeforeFill = True
            ' 
            ' gridLink
            ' 
            Me.gridLink.Component = Me.gridControl1
            Me.gridLink.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String(){}, New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() { "", "", "Page: [Page #]/ [Pages #]  "}, New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))), DevExpress.XtraPrinting.BrickAlignment.Near))
            Me.gridLink.PrintingSystemBase = Me.printingSystem
            Me.gridLink.RtfReportHeader = resources.GetString("gridLink.RtfReportHeader")
            ' 
            ' productsTableAdapter
            ' 
            Me.productsTableAdapter.ClearBeforeFill = True
            ' 
            ' PreviewControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "PreviewControl"
            CType(Me.printingSystem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private navigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
        Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Private colPicture As DevExpress.XtraGrid.Columns.GridColumn
        Private categoriesBindingSource As System.Windows.Forms.BindingSource
        Private nwindDataSet As nwindDataSet
        Private categoriesTableAdapter As nwindDataSetTableAdapters.CategoriesTableAdapter
        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Private gridLink As DevExpress.XtraPrinting.PrintableComponentLink
        Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
