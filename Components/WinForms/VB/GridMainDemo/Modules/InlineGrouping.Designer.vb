Namespace DevExpress.XtraGrid.Demos
    Partial Public Class InlineGrouping
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(InlineGrouping))
            Dim gridFormatRule1 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue1 As New DevExpress.XtraEditors.FormatConditionRuleValue()
            Me.colInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceGroupExpandedOnSorting = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAutoExpandAllGroups = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowExpandCollapseButtons = New DevExpress.XtraEditors.CheckEdit()
            Me.icbGroupDrawMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceAllowPartialGroups = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colTrademarkImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModification = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBodyStyle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
            Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.ceGroupExpandedOnSorting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceAutoExpandAllGroups.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceShowExpandCollapseButtons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbGroupDrawMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceAllowPartialGroups.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colInStock
            ' 
            Me.colInStock.FieldName = "InStock"
            Me.colInStock.Name = "colInStock"
            Me.colInStock.Width = 90
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right
            Me.navigationPane1.Location = New System.Drawing.Point(678, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(277, 591)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.SelectedPageIndex = 0
            Me.navigationPane1.Size = New System.Drawing.Size(277, 591)
            Me.navigationPane1.TabIndex = 8
            Me.navigationPane1.Text = "navigationPane1"
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Image = (DirectCast(resources.GetObject("navigationPage1.Image"), System.Drawing.Image))
            Me.navigationPage1.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(227, 531)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceGroupExpandedOnSorting)
            Me.layoutControl1.Controls.Add(Me.ceAutoExpandAllGroups)
            Me.layoutControl1.Controls.Add(Me.ceShowExpandCollapseButtons)
            Me.layoutControl1.Controls.Add(Me.icbGroupDrawMode)
            Me.layoutControl1.Controls.Add(Me.ceAllowPartialGroups)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(227, 531)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceGroupExpandedOnSorting
            ' 
            Me.ceGroupExpandedOnSorting.Location = New System.Drawing.Point(12, 141)
            Me.ceGroupExpandedOnSorting.Name = "ceGroupExpandedOnSorting"
            Me.ceGroupExpandedOnSorting.Properties.Caption = "Keep Group Expanded On Sorting"
            Me.ceGroupExpandedOnSorting.Size = New System.Drawing.Size(203, 19)
            Me.ceGroupExpandedOnSorting.StyleController = Me.layoutControl1
            Me.ceGroupExpandedOnSorting.TabIndex = 8
            ' 
            ' ceAutoExpandAllGroups
            ' 
            Me.ceAutoExpandAllGroups.Location = New System.Drawing.Point(12, 118)
            Me.ceAutoExpandAllGroups.Name = "ceAutoExpandAllGroups"
            Me.ceAutoExpandAllGroups.Properties.Caption = "Auto Expand All Groups"
            Me.ceAutoExpandAllGroups.Size = New System.Drawing.Size(203, 19)
            Me.ceAutoExpandAllGroups.StyleController = Me.layoutControl1
            Me.ceAutoExpandAllGroups.TabIndex = 7
            ' 
            ' ceShowExpandCollapseButtons
            ' 
            Me.ceShowExpandCollapseButtons.Location = New System.Drawing.Point(12, 85)
            Me.ceShowExpandCollapseButtons.Name = "ceShowExpandCollapseButtons"
            Me.ceShowExpandCollapseButtons.Properties.Caption = "Show Group Buttons"
            Me.ceShowExpandCollapseButtons.Size = New System.Drawing.Size(203, 19)
            Me.ceShowExpandCollapseButtons.StyleController = Me.layoutControl1
            Me.ceShowExpandCollapseButtons.TabIndex = 6
            ' 
            ' icbGroupDrawMode
            ' 
            Me.icbGroupDrawMode.Location = New System.Drawing.Point(12, 61)
            Me.icbGroupDrawMode.Name = "icbGroupDrawMode"
            Me.icbGroupDrawMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbGroupDrawMode.Size = New System.Drawing.Size(203, 20)
            Me.icbGroupDrawMode.StyleController = Me.layoutControl1
            Me.icbGroupDrawMode.TabIndex = 5
            ' 
            ' ceAllowPartialGroups
            ' 
            Me.ceAllowPartialGroups.Location = New System.Drawing.Point(12, 12)
            Me.ceAllowPartialGroups.Name = "ceAllowPartialGroups"
            Me.ceAllowPartialGroups.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True
            Me.ceAllowPartialGroups.Properties.Caption = "<b>Allow Partial Groups"
            Me.ceAllowPartialGroups.Size = New System.Drawing.Size(203, 19)
            Me.ceAllowPartialGroups.StyleController = Me.layoutControl1
            Me.ceAllowPartialGroups.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.emptySpaceItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(227, 531)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceAllowPartialGroups
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(207, 23)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbGroupDrawMode
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 33)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(207, 40)
            Me.layoutControlItem2.Text = "Group Draw Mode:"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(90, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 23)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(207, 10)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 152)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(207, 359)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceShowExpandCollapseButtons
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 73)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(207, 23)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceAutoExpandAllGroups
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 106)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(207, 23)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceGroupExpandedOnSorting
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 129)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(207, 23)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 96)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(207, 10)
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.gridControl1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
            Me.panel1.Size = New System.Drawing.Size(678, 591)
            Me.panel1.TabIndex = 9
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageEdit1, Me.repositoryItemMemoExEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(668, 591)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colTrademarkImage, Me.colTrademark, Me.colName, Me.colModification, Me.colCategory, Me.colPrice, Me.colBodyStyle, Me.colDescription, Me.colDeliveryDate, Me.colInStock, Me.colPhoto})
            gridFormatRule1.ApplyToRow = True
            gridFormatRule1.Column = Me.colInStock
            gridFormatRule1.Name = "Format0"
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.DarkGray
            formatConditionRuleValue1.Appearance.Options.UseForeColor = True
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
            formatConditionRuleValue1.PredefinedName = "Strikeout Text"
            formatConditionRuleValue1.Value1 = False
            gridFormatRule1.Rule = formatConditionRuleValue1
            Me.gridView1.FormatRules.Add(gridFormatRule1)
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.True
            Me.gridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDeliveryDate, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' colTrademarkImage
            ' 
            Me.colTrademarkImage.FieldName = "TrademarkImage"
            Me.colTrademarkImage.Image = (DirectCast(resources.GetObject("colTrademarkImage.Image"), System.Drawing.Image))
            Me.colTrademarkImage.ImageAlignment = System.Drawing.StringAlignment.Center
            Me.colTrademarkImage.Name = "colTrademarkImage"
            Me.colTrademarkImage.OptionsColumn.AllowFocus = False
            Me.colTrademarkImage.OptionsColumn.AllowSize = False
            Me.colTrademarkImage.OptionsColumn.FixedWidth = True
            Me.colTrademarkImage.OptionsColumn.ShowCaption = False
            Me.colTrademarkImage.OptionsFilter.AllowFilter = False
            Me.colTrademarkImage.Visible = True
            Me.colTrademarkImage.VisibleIndex = 1
            Me.colTrademarkImage.Width = 66
            ' 
            ' colTrademark
            ' 
            Me.colTrademark.FieldName = "Trademark"
            Me.colTrademark.Name = "colTrademark"
            Me.colTrademark.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            Me.colTrademark.Visible = True
            Me.colTrademark.VisibleIndex = 2
            Me.colTrademark.Width = 142
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 3
            Me.colName.Width = 131
            ' 
            ' colModification
            ' 
            Me.colModification.FieldName = "Modification"
            Me.colModification.Name = "colModification"
            Me.colModification.Visible = True
            Me.colModification.VisibleIndex = 4
            Me.colModification.Width = 134
            ' 
            ' colCategory
            ' 
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            Me.colCategory.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            Me.colCategory.Visible = True
            Me.colCategory.VisibleIndex = 5
            Me.colCategory.Width = 130
            ' 
            ' colPrice
            ' 
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            Me.colPrice.Visible = True
            Me.colPrice.VisibleIndex = 6
            Me.colPrice.Width = 121
            ' 
            ' colBodyStyle
            ' 
            Me.colBodyStyle.FieldName = "BodyStyle"
            Me.colBodyStyle.Name = "colBodyStyle"
            Me.colBodyStyle.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            Me.colBodyStyle.Width = 117
            ' 
            ' colDescription
            ' 
            Me.colDescription.ColumnEdit = Me.repositoryItemMemoExEdit1
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.OptionsFilter.AllowFilter = False
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 7
            Me.colDescription.Width = 83
            ' 
            ' repositoryItemMemoExEdit1
            ' 
            Me.repositoryItemMemoExEdit1.AutoHeight = False
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            Me.repositoryItemMemoExEdit1.PopupFormMinSize = New System.Drawing.Size(300, 150)
            ' 
            ' colDeliveryDate
            ' 
            Me.colDeliveryDate.FieldName = "DeliveryDate"
            Me.colDeliveryDate.Name = "colDeliveryDate"
            Me.colDeliveryDate.Visible = True
            Me.colDeliveryDate.VisibleIndex = 0
            Me.colDeliveryDate.Width = 127
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.ColumnEdit = Me.repositoryItemImageEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.OptionsFilter.AllowFilter = False
            Me.colPhoto.Width = 91
            ' 
            ' repositoryItemImageEdit1
            ' 
            Me.repositoryItemImageEdit1.AutoHeight = False
            Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
            Me.repositoryItemImageEdit1.PopupFormMinSize = New System.Drawing.Size(300, 150)
            Me.repositoryItemImageEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
            ' 
            ' InlineGrouping
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "InlineGrouping"
            Me.Size = New System.Drawing.Size(955, 591)
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.ceGroupExpandedOnSorting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceAutoExpandAllGroups.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceShowExpandCollapseButtons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbGroupDrawMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceAllowPartialGroups.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private layoutControl1 As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private panel1 As System.Windows.Forms.Panel
        Private gridControl1 As GridControl
        Private gridView1 As Views.Grid.GridView
        Private colTrademarkImage As Columns.GridColumn
        Private colTrademark As Columns.GridColumn
        Private colName As Columns.GridColumn
        Private colModification As Columns.GridColumn
        Private colCategory As Columns.GridColumn
        Private colPrice As Columns.GridColumn
        Private colBodyStyle As Columns.GridColumn
        Private colDescription As Columns.GridColumn
        Private colDeliveryDate As Columns.GridColumn
        Private colInStock As Columns.GridColumn
        Private colPhoto As Columns.GridColumn
        Private repositoryItemMemoExEdit1 As XtraEditors.Repository.RepositoryItemMemoExEdit
        Private repositoryItemImageEdit1 As XtraEditors.Repository.RepositoryItemImageEdit
        Private WithEvents ceAllowPartialGroups As XtraEditors.CheckEdit
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private WithEvents icbGroupDrawMode As XtraEditors.ImageComboBoxEdit
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private WithEvents ceShowExpandCollapseButtons As XtraEditors.CheckEdit
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private WithEvents ceGroupExpandedOnSorting As XtraEditors.CheckEdit
        Private WithEvents ceAutoExpandAllGroups As XtraEditors.CheckEdit
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
    End Class
End Namespace
