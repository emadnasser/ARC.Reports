Namespace DevExpress.DevAV.Modules
    Partial Public Class ProductsPeek
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

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
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.moduleLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.searchControl = New DevExpress.XtraEditors.SearchControl()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colImage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.labelItem = New DevExpress.XtraLayout.SimpleLabelItem()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType(Me.searchControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.labelItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Product)
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.searchControl)
            Me.moduleLayout.Controls.Add(Me.gridControl)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.Root
            Me.moduleLayout.Size = New System.Drawing.Size(280, 506)
            Me.moduleLayout.TabIndex = 3
            Me.searchControl.Client = Me.gridControl
            Me.searchControl.Location = New System.Drawing.Point(10, 2)
            Me.searchControl.Name = "searchControl"
            Me.searchControl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {
                New DevExpress.XtraEditors.Repository.ClearButton(),
                New DevExpress.XtraEditors.Repository.SearchButton()
            })
            Me.searchControl.Size = New System.Drawing.Size(260, 20)
            Me.searchControl.StyleController = Me.moduleLayout
            Me.searchControl.TabIndex = 2
            Me.gridControl.DataSource = Me.bindingSource
            Me.gridControl.Location = New System.Drawing.Point(10, 55)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1})
            Me.gridControl.ShowOnlyPredefinedDetails = True
            Me.gridControl.Size = New System.Drawing.Size(260, 441)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView})
            Me.gridView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2})
            Me.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colImage, Me.colName, Me.colDescription})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.Editable = False
            Me.gridView.OptionsFind.AllowFindPanel = False
            Me.gridView.OptionsView.ColumnAutoWidth = True
            Me.gridView.OptionsView.ShowBands = False
            Me.gridView.OptionsView.ShowColumnHeaders = False
            Me.gridView.OptionsView.ShowGroupPanel = False
            Me.gridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False
            Me.gridView.OptionsView.ShowIndicator = False
            Me.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            Me.gridView.RowHeight = 25
            Me.gridBand1.Columns.Add(Me.colImage)
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.OptionsBand.AllowSize = False
            Me.gridBand1.OptionsBand.FixedWidth = True
            Me.gridBand1.VisibleIndex = 0
            Me.gridBand1.Width = 50
            Me.colImage.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colImage.FieldName = "ProductImage"
            Me.colImage.Name = "colImage"
            Me.colImage.OptionsColumn.AllowEdit = False
            Me.colImage.OptionsColumn.AllowFocus = False
            Me.colImage.RowCount = 2
            Me.colImage.Visible = True
            Me.colImage.Width = 50
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.Padding = New System.Windows.Forms.Padding(4)
            Me.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.gridBand2.Columns.Add(Me.colName)
            Me.gridBand2.Columns.Add(Me.colDescription)
            Me.gridBand2.Name = "gridBand2"
            Me.gridBand2.VisibleIndex = 1
            Me.gridBand2.Width = 218
            Me.colName.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 12F)
            Me.colName.AppearanceCell.Options.UseFont = True
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.OptionsColumn.AllowEdit = False
            Me.colName.OptionsColumn.AllowFocus = False
            Me.colName.Visible = True
            Me.colName.Width = 218
            Me.colDescription.AppearanceCell.Options.UseTextOptions = True
            Me.colDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.OptionsColumn.AllowEdit = False
            Me.colDescription.OptionsColumn.AllowFocus = False
            Me.colDescription.RowIndex = 1
            Me.colDescription.Visible = True
            Me.colDescription.Width = 218
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.labelItem})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 0, 8)
            Me.Root.Size = New System.Drawing.Size(280, 506)
            Me.Root.Text = "Root"
            Me.layoutControlItem1.Control = Me.gridControl
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 53)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(264, 445)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem2.Control = Me.searchControl
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(264, 24)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            Me.labelItem.AllowHotTrack = False
            Me.labelItem.CustomizationFormText = "PRODUCTS"
            Me.labelItem.Location = New System.Drawing.Point(0, 24)
            Me.labelItem.Name = "labelItem"
            Me.labelItem.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 8)
            Me.labelItem.Size = New System.Drawing.Size(264, 29)
            Me.labelItem.Text = "PRODUCTS"
            Me.labelItem.TextSize = New System.Drawing.Size(54, 13)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Margin = New System.Windows.Forms.Padding(6)
            Me.Name = "ProductsPeek"
            Me.Size = New System.Drawing.Size(280, 506)
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType(Me.searchControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.labelItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private bindingSource As System.Windows.Forms.BindingSource
        Private moduleLayout As XtraLayout.LayoutControl
        Private searchControl As XtraEditors.SearchControl
        Private gridControl As XtraGrid.GridControl
        Private gridView As XtraGrid.Views.BandedGrid.AdvBandedGridView
        Private gridBand1 As XtraGrid.Views.BandedGrid.GridBand
        Private colImage As XtraGrid.Views.BandedGrid.BandedGridColumn
        Private repositoryItemPictureEdit1 As XtraEditors.Repository.RepositoryItemPictureEdit
        Private gridBand2 As XtraGrid.Views.BandedGrid.GridBand
        Private colName As XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colDescription As XtraGrid.Views.BandedGrid.BandedGridColumn
        Private Root As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private labelItem As XtraLayout.SimpleLabelItem

    End Class
End Namespace
