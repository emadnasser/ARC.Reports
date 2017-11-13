Namespace XtraPrintingDemos.CompositeLink
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
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim pieSeriesLabel1 As New DevExpress.XtraCharts.PieSeriesLabel()
            Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(PreviewControl))
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New XtraPrintingDemos.nwindDataSet()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.navigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.productsTableAdapter = New XtraPrintingDemos.nwindDataSetTableAdapters.ProductsTableAdapter()
            Me.categoriesTableAdapter = New XtraPrintingDemos.nwindDataSetTableAdapters.CategoriesTableAdapter()
            Me.gridLink = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
            Me.chartLink = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
            Me.compositeLink = New DevExpress.XtraPrintingLinks.CompositeLink(Me.components)
            CType(Me.printingSystem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPage1.SuspendLayout()
            Me.navigationPage2.SuspendLayout()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pControl
            ' 
            Me.pControl.Size = New System.Drawing.Size(641, 329)
            ' 
            ' printingSystem
            ' 
            Me.printingSystem.Links.AddRange(New Object() { Me.gridLink, Me.chartLink, Me.compositeLink})
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Controls.Add(Me.navigationPage2)
            Me.navigationPane1.Location = New System.Drawing.Point(645, 141)
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPage1, Me.navigationPage2})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(566, 333)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(566, 333)
            Me.navigationPane1.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Default
            Me.navigationPane1.Visible = True
            ' 
            ' productsBindingSource
            ' 
            Me.productsBindingSource.DataMember = "Products"
            Me.productsBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' colProductName
            ' 
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.OptionsFilter.AllowFilter = False
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 0
            Me.colProductName.Width = 150
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.categoriesBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            gridLevelNode1.RelationName = "CategoriesProducts"
            Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(523, 273)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' categoriesBindingSource
            ' 
            Me.categoriesBindingSource.DataMember = "Categories"
            Me.categoriesBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' gridView1
            ' 
            Me.gridView1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.gridView1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colPicture, Me.colCategoryName, Me.colDescription})
            Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsView.RowAutoHeight = True
            Me.gridView1.OptionsView.ShowDetailButtons = False
            Me.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            ' 
            ' colPicture
            ' 
            Me.colPicture.FieldName = "Picture"
            Me.colPicture.Name = "colPicture"
            Me.colPicture.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            Me.colPicture.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
            Me.colPicture.OptionsColumn.AllowMove = False
            Me.colPicture.OptionsColumn.AllowShowHide = False
            Me.colPicture.OptionsColumn.AllowSize = False
            Me.colPicture.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colPicture.OptionsColumn.FixedWidth = True
            Me.colPicture.OptionsFilter.AllowFilter = False
            Me.colPicture.Visible = True
            Me.colPicture.VisibleIndex = 0
            Me.colPicture.Width = 60
            ' 
            ' colCategoryName
            ' 
            Me.colCategoryName.FieldName = "CategoryName"
            Me.colCategoryName.Name = "colCategoryName"
            Me.colCategoryName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            Me.colCategoryName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
            Me.colCategoryName.OptionsColumn.AllowMove = False
            Me.colCategoryName.OptionsColumn.AllowShowHide = False
            Me.colCategoryName.OptionsColumn.AllowSize = False
            Me.colCategoryName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colCategoryName.OptionsFilter.AllowFilter = False
            Me.colCategoryName.Visible = True
            Me.colCategoryName.VisibleIndex = 1
            Me.colCategoryName.Width = 156
            ' 
            ' colDescription
            ' 
            Me.colDescription.AppearanceCell.Options.UseTextOptions = True
            Me.colDescription.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            Me.colDescription.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
            Me.colDescription.OptionsColumn.AllowMove = False
            Me.colDescription.OptionsColumn.AllowShowHide = False
            Me.colDescription.OptionsColumn.AllowSize = False
            Me.colDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colDescription.OptionsFilter.AllowFilter = False
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 2
            Me.colDescription.Width = 305
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Product Categories"
            Me.navigationPage1.Controls.Add(Me.gridControl1)
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(523, 273)
            ' 
            ' navigationPage2
            ' 
            Me.navigationPage2.Caption = "Product Count by Categories"
            Me.navigationPage2.Controls.Add(Me.chartControl1)
            Me.navigationPage2.Name = "navigationPage2"
            Me.navigationPage2.Size = New System.Drawing.Size(523, 273)
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl1.DataAdapter = Me.productsTableAdapter
            Me.chartControl1.DataBindings = Nothing
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Name = "Default Legend"
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.OptionsPrint.ImageFormat = DevExpress.XtraCharts.Printing.PrintImageFormat.Metafile
            Me.chartControl1.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom
            series1.ArgumentDataMember = "CategoryName"
            series1.DataSource = Me.productsBindingSource
            pieSeriesLabel1.TextPattern = "{A}"
            series1.Label = pieSeriesLabel1
            series1.Name = "Series 1"
            series1.SummaryFunction = "COUNT()"
            series1.View = pieSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chartControl1.Size = New System.Drawing.Size(523, 273)
            Me.chartControl1.TabIndex = 0
            ' 
            ' productsTableAdapter
            ' 
            Me.productsTableAdapter.ClearBeforeFill = True
            ' 
            ' categoriesTableAdapter
            ' 
            Me.categoriesTableAdapter.ClearBeforeFill = True
            ' 
            ' gridLink
            ' 
            Me.gridLink.Component = Me.gridControl1
            Me.gridLink.PrintingSystemBase = Me.printingSystem
            ' 
            ' chartLink
            ' 
            Me.chartLink.Component = Me.chartControl1
            Me.chartLink.PrintingSystemBase = Me.printingSystem
            Me.chartLink.RtfReportHeader = resources.GetString("chartLink.RtfReportHeader")
            ' 
            ' compositeLink
            ' 
            Me.compositeLink.BreakSpace = 50
            Me.compositeLink.Links.AddRange(New Object() { Me.gridLink, Me.chartLink})
            Me.compositeLink.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(Nothing, New DevExpress.XtraPrinting.PageFooterArea(New String() { "", "", "Page: [Page #]/ [Pages #]  "}, New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))), DevExpress.XtraPrinting.BrickAlignment.Near))
            Me.compositeLink.PrintingSystemBase = Me.printingSystem
            Me.compositeLink.RtfReportHeader = resources.GetString("compositeLink.RtfReportHeader")
            ' 
            ' pControl
            ' 
            Me.pControl.DocumentSource = Me.printingSystem
            ' 
            ' PreviewControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "PreviewControl"
            CType(Me.printingSystem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPage1.ResumeLayout(False)
            Me.navigationPage2.ResumeLayout(False)
            CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private navigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
        Private navigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private categoriesBindingSource As System.Windows.Forms.BindingSource
        Private nwindDataSet As nwindDataSet
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colPicture As DevExpress.XtraGrid.Columns.GridColumn
        Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
        Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Private categoriesTableAdapter As nwindDataSetTableAdapters.CategoriesTableAdapter
        Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter
        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private productsBindingSource As System.Windows.Forms.BindingSource
        Private gridLink As DevExpress.XtraPrinting.PrintableComponentLink
        Private chartLink As DevExpress.XtraPrinting.PrintableComponentLink
        Private compositeLink As DevExpress.XtraPrintingLinks.CompositeLink
    End Class
End Namespace
