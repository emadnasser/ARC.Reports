Namespace DevExpress.DevAV.Modules
    Partial Public Class CustomerView
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
            Me.moduleLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.pictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.bindingSourceCustomerStores = New System.Windows.Forms.BindingSource(Me.components)
            Me.winExplorerView = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
            Me.colAddressLines = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCrestSmallImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomerName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCrestLargeImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCrestCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.HomeOfficeTextLabel = New DevExpress.XtraEditors.LabelControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForGrid = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForLogo = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForHomeOffice = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sliName = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSourceCustomerStores, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.winExplorerView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForHomeOffice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sliName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Customer)
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.pictureEdit)
            Me.moduleLayout.Controls.Add(Me.gridControl)
            Me.moduleLayout.Controls.Add(Me.HomeOfficeTextLabel)
            Me.moduleLayout.DataSource = Me.bindingSource
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Margin = New System.Windows.Forms.Padding(2)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.Root
            Me.moduleLayout.Size = New System.Drawing.Size(376, 423)
            Me.moduleLayout.TabIndex = 0
            Me.pictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Logo", True))
            Me.pictureEdit.Location = New System.Drawing.Point(0, 0)
            Me.pictureEdit.Name = "pictureEdit"
            Me.pictureEdit.Properties.AllowFocused = False
            Me.pictureEdit.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.pictureEdit.Properties.ReadOnly = True
            Me.pictureEdit.Properties.ShowMenu = False
            Me.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.pictureEdit.Size = New System.Drawing.Size(100, 100)
            Me.pictureEdit.StyleController = Me.moduleLayout
            Me.pictureEdit.TabIndex = 1
            Me.gridControl.DataSource = Me.bindingSourceCustomerStores
            Me.gridControl.Location = New System.Drawing.Point(0, 129)
            Me.gridControl.MainView = Me.winExplorerView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(376, 294)
            Me.gridControl.TabIndex = 7
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.winExplorerView})
            Me.bindingSourceCustomerStores.DataSource = GetType(DevExpress.DevAV.CustomerStore)
            Me.winExplorerView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colAddressLines, Me.colCrestSmallImage, Me.colCustomerName, Me.colCrestLargeImage, Me.colCrestCity})
            Me.winExplorerView.ColumnSet.DescriptionColumn = Me.colAddressLines
            Me.winExplorerView.ColumnSet.ExtraLargeImageColumn = Me.colCrestLargeImage
            Me.winExplorerView.ColumnSet.LargeImageColumn = Me.colCrestLargeImage
            Me.winExplorerView.ColumnSet.MediumImageColumn = Me.colCrestSmallImage
            Me.winExplorerView.ColumnSet.SmallImageColumn = Me.colCrestSmallImage
            Me.winExplorerView.ColumnSet.TextColumn = Me.colCrestCity
            Me.winExplorerView.GridControl = Me.gridControl
            Me.winExplorerView.Name = "winExplorerView"
            Me.winExplorerView.OptionsBehavior.Editable = False
            Me.winExplorerView.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Large
            Me.winExplorerView.OptionsViewStyles.Large.ImageSize = New System.Drawing.Size(110, 110)
            Me.winExplorerView.OptionsViewStyles.Large.ShowDescription = DevExpress.Utils.DefaultBoolean.True
            Me.winExplorerView.OptionsViewStyles.Medium.ImageSize = New System.Drawing.Size(80, 80)
            Me.colAddressLines.FieldName = "AddressLines"
            Me.colAddressLines.Name = "colAddressLines"
            Me.colAddressLines.Visible = True
            Me.colAddressLines.VisibleIndex = 0
            Me.colCrestSmallImage.FieldName = "CrestSmallImage"
            Me.colCrestSmallImage.Name = "colCrestSmallImage"
            Me.colCrestSmallImage.Visible = True
            Me.colCrestSmallImage.VisibleIndex = 1
            Me.colCustomerName.FieldName = "CustomerName"
            Me.colCustomerName.Name = "colCustomerName"
            Me.colCustomerName.Visible = True
            Me.colCustomerName.VisibleIndex = 1
            Me.colCrestLargeImage.FieldName = "CrestLargeImage"
            Me.colCrestLargeImage.Name = "colCrestLargeImage"
            Me.colCrestLargeImage.Visible = True
            Me.colCrestLargeImage.VisibleIndex = 0
            Me.colCrestCity.FieldName = "CrestCity"
            Me.colCrestCity.Name = "colCrestCity"
            Me.colCrestCity.Visible = True
            Me.colCrestCity.VisibleIndex = 0
            Me.HomeOfficeTextLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25F)
            Me.HomeOfficeTextLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "HomeOffice", True))
            Me.HomeOfficeTextLabel.Location = New System.Drawing.Point(114, 66)
            Me.HomeOfficeTextLabel.Margin = New System.Windows.Forms.Padding(2)
            Me.HomeOfficeTextLabel.Name = "HomeOfficeTextLabel"
            Me.HomeOfficeTextLabel.Size = New System.Drawing.Size(260, 25)
            Me.HomeOfficeTextLabel.StyleController = Me.moduleLayout
            Me.HomeOfficeTextLabel.TabIndex = 5
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup1})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.OptionsItemText.TextToControlDistance = 6
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(376, 423)
            Me.Root.Text = "Root"
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "autoGeneratedGroup0"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForGrid, Me.ItemForLogo, Me.simpleSeparator1, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6
            Me.layoutControlGroup1.Size = New System.Drawing.Size(376, 423)
            Me.layoutControlGroup1.Text = "autoGeneratedGroup0"
            Me.ItemForGrid.Control = Me.gridControl
            Me.ItemForGrid.CustomizationFormText = "layoutControlItem1"
            Me.ItemForGrid.Location = New System.Drawing.Point(0, 129)
            Me.ItemForGrid.Name = "layoutControlItem1"
            Me.ItemForGrid.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForGrid.Size = New System.Drawing.Size(376, 294)
            Me.ItemForGrid.Text = "layoutControlItem1"
            Me.ItemForGrid.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForGrid.TextToControlDistance = 0
            Me.ItemForGrid.TextVisible = False
            Me.ItemForLogo.Control = Me.pictureEdit
            Me.ItemForLogo.CustomizationFormText = "ItemForLogo"
            Me.ItemForLogo.Location = New System.Drawing.Point(0, 0)
            Me.ItemForLogo.MaxSize = New System.Drawing.Size(100, 100)
            Me.ItemForLogo.MinSize = New System.Drawing.Size(100, 100)
            Me.ItemForLogo.Name = "ItemForLogo"
            Me.ItemForLogo.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForLogo.Size = New System.Drawing.Size(100, 115)
            Me.ItemForLogo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForLogo.Text = "ItemForLogo"
            Me.ItemForLogo.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForLogo.TextToControlDistance = 0
            Me.ItemForLogo.TextVisible = False
            Me.simpleSeparator1.AllowHotTrack = False
            Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
            Me.simpleSeparator1.Location = New System.Drawing.Point(0, 115)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.simpleSeparator1.Size = New System.Drawing.Size(376, 14)
            Me.simpleSeparator1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 12)
            Me.simpleSeparator1.Text = "simpleSeparator1"
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForHomeOffice, Me.sliName, Me.emptySpaceItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(100, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 0, 0, 12)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(276, 115)
            Me.layoutControlGroup2.Text = "layoutControlGroup2"
            Me.ItemForHomeOffice.Control = Me.HomeOfficeTextLabel
            Me.ItemForHomeOffice.CustomizationFormText = "Home Office"
            Me.ItemForHomeOffice.Location = New System.Drawing.Point(0, 45)
            Me.ItemForHomeOffice.Name = "ItemForHomeOffice"
            Me.ItemForHomeOffice.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForHomeOffice.Size = New System.Drawing.Size(260, 44)
            Me.ItemForHomeOffice.Text = "HOME OFFICE"
            Me.ItemForHomeOffice.TextLocation = DevExpress.Utils.Locations.Top
            Me.ItemForHomeOffice.TextSize = New System.Drawing.Size(71, 13)
            Me.sliName.AllowHotTrack = False
            Me.sliName.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.sliName.AppearanceItemCaption.Options.UseFont = True
            Me.sliName.CustomizationFormText = "Name"
            Me.sliName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "Name", True))
            Me.sliName.Location = New System.Drawing.Point(0, 0)
            Me.sliName.Name = "sliName"
            Me.sliName.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 8)
            Me.sliName.Size = New System.Drawing.Size(260, 45)
            Me.sliName.Text = "Name"
            Me.sliName.TextSize = New System.Drawing.Size(71, 37)
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 89)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(260, 10)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Name = "CustomerView"
            Me.Size = New System.Drawing.Size(376, 423)
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSourceCustomerStores, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.winExplorerView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForLogo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForHomeOffice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sliName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private bindingSource As System.Windows.Forms.BindingSource
        Private moduleLayout As DevExpress.XtraDataLayout.DataLayoutControl
        Private HomeOfficeTextLabel As XtraEditors.LabelControl
        Private Root As XtraLayout.LayoutControlGroup
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private ItemForHomeOffice As XtraLayout.LayoutControlItem
        Private gridControl As XtraGrid.GridControl
        Private winExplorerView As XtraGrid.Views.WinExplorer.WinExplorerView
        Private ItemForGrid As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private simpleSeparator1 As XtraLayout.SimpleSeparator
        Private pictureEdit As XtraEditors.PictureEdit
        Private ItemForLogo As XtraLayout.LayoutControlItem
        Private sliName As XtraLayout.SimpleLabelItem
        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
        Private bindingSourceCustomerStores As System.Windows.Forms.BindingSource
        Private colAddressLines As XtraGrid.Columns.GridColumn
        Private colCrestSmallImage As XtraGrid.Columns.GridColumn
        Private colCustomerName As XtraGrid.Columns.GridColumn
        Private colCrestLargeImage As XtraGrid.Columns.GridColumn
        Private colCrestCity As XtraGrid.Columns.GridColumn
    End Class
End Namespace
