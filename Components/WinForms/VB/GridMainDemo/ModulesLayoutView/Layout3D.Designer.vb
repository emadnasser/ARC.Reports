Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class Layout3D
        Inherits TutorialControl

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>

        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Layout3D))
            Me.bottomCardFading = New DevExpress.XtraEditors.ZoomTrackBarControl()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.cardsCount = New DevExpress.XtraEditors.ZoomTrackBarControl()
            Me.flatFactor = New DevExpress.XtraEditors.ZoomTrackBarControl()
            Me.endAlpha = New DevExpress.XtraEditors.ZoomTrackBarControl()
            Me.rollAngle = New DevExpress.XtraEditors.ZoomTrackBarControl()
            Me.endSizeScale = New DevExpress.XtraEditors.ZoomTrackBarControl()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
            Me.colCaption = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.layoutViewField_colCaption = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colYear = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colYear = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colPlotoutLine = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.layoutViewField_colPlotoutLine = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colRunTime = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colRunTime = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colColor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colColor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.layoutViewField_colPhoto = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewTemplateCard = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
            Me.repositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            DirectCast(Me.bottomCardFading, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.bottomCardFading.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            DirectCast(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cardsCount, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cardsCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.flatFactor, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.flatFactor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.endAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.endAlpha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.rollAngle, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.rollAngle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.endSizeScale, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.endSizeScale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutViewField_colCaption, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutViewField_colYear, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutViewField_colPlotoutLine, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutViewField_colRunTime, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutViewField_colColor, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutViewField_colPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutViewTemplateCard, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' bottomCardFading
            ' 
            resources.ApplyResources(Me.bottomCardFading, "bottomCardFading")
            Me.bottomCardFading.Name = "bottomCardFading"
            Me.bottomCardFading.Properties.Maximum = 100
            Me.bottomCardFading.Properties.Middle = 5
            Me.bottomCardFading.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            Me.bottomCardFading.StyleController = Me.layoutControl2
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.AllowCustomization = False
            Me.layoutControl2.Controls.Add(Me.comboBoxEdit1)
            Me.layoutControl2.Controls.Add(Me.cardsCount)
            Me.layoutControl2.Controls.Add(Me.bottomCardFading)
            Me.layoutControl2.Controls.Add(Me.flatFactor)
            Me.layoutControl2.Controls.Add(Me.endAlpha)
            Me.layoutControl2.Controls.Add(Me.rollAngle)
            Me.layoutControl2.Controls.Add(Me.endSizeScale)
            resources.ApplyResources(Me.layoutControl2, "layoutControl2")
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl2.Root = Me.layoutControlGroup2
            ' 
            ' comboBoxEdit1
            ' 
            resources.ApplyResources(Me.comboBoxEdit1, "comboBoxEdit1")
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("comboBoxEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.comboBoxEdit1.Properties.DropDownRows = 10
            Me.comboBoxEdit1.StyleController = Me.layoutControl2
            ' 
            ' cardsCount
            ' 
            resources.ApplyResources(Me.cardsCount, "cardsCount")
            Me.cardsCount.Name = "cardsCount"
            Me.cardsCount.Properties.Maximum = 20
            Me.cardsCount.Properties.Middle = 5
            Me.cardsCount.Properties.Minimum = 5
            Me.cardsCount.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            Me.cardsCount.StyleController = Me.layoutControl2
            Me.cardsCount.Value = 15
            ' 
            ' flatFactor
            ' 
            resources.ApplyResources(Me.flatFactor, "flatFactor")
            Me.flatFactor.Name = "flatFactor"
            Me.flatFactor.Properties.Maximum = 360
            Me.flatFactor.Properties.Middle = 5
            Me.flatFactor.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            Me.flatFactor.StyleController = Me.layoutControl2
            Me.flatFactor.Value = 65
            ' 
            ' endAlpha
            ' 
            resources.ApplyResources(Me.endAlpha, "endAlpha")
            Me.endAlpha.Name = "endAlpha"
            Me.endAlpha.Properties.Maximum = 100
            Me.endAlpha.Properties.Middle = 5
            Me.endAlpha.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            Me.endAlpha.StyleController = Me.layoutControl2
            ' 
            ' rollAngle
            ' 
            resources.ApplyResources(Me.rollAngle, "rollAngle")
            Me.rollAngle.Name = "rollAngle"
            Me.rollAngle.Properties.Maximum = 360
            Me.rollAngle.Properties.Middle = 5
            Me.rollAngle.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            Me.rollAngle.StyleController = Me.layoutControl2
            Me.rollAngle.Value = 180
            ' 
            ' endSizeScale
            ' 
            resources.ApplyResources(Me.endSizeScale, "endSizeScale")
            Me.endSizeScale.Name = "endSizeScale"
            Me.endSizeScale.Properties.Maximum = 100
            Me.endSizeScale.Properties.Middle = 5
            Me.endSizeScale.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            Me.endSizeScale.StyleController = Me.layoutControl2
            Me.endSizeScale.Value = 20
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem1, Me.layoutControlItem7, Me.emptySpaceItem1, Me.emptySpaceItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "Root"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(211, 445)
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.flatFactor
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(191, 38)
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.rollAngle
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 38)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(191, 38)
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.endSizeScale
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 76)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(191, 38)
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.endAlpha
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 114)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(191, 38)
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.bottomCardFading
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 152)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(191, 38)
            resources.ApplyResources(Me.layoutControlItem6, "layoutControlItem6")
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cardsCount
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 190)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(191, 38)
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.comboBoxEdit1
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 238)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(191, 40)
            resources.ApplyResources(Me.layoutControlItem7, "layoutControlItem7")
            Me.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(118, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 278)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(191, 147)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 228)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(191, 10)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.Default
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.layoutView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEdit1, Me.repositoryItemPictureEdit1, Me.repositoryItemHyperLinkEdit1, Me.repositoryItemMemoEdit2})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView1})
            ' 
            ' layoutView1
            ' 
            Me.layoutView1.Appearance.CardCaption.Font = (DirectCast(resources.GetObject("layoutView1.Appearance.CardCaption.Font"), System.Drawing.Font))
            Me.layoutView1.Appearance.CardCaption.Options.UseFont = True
            Me.layoutView1.Appearance.CardCaption.Options.UseTextOptions = True
            Me.layoutView1.Appearance.CardCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutView1.Appearance.CardCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.layoutView1.Appearance.FocusedCardCaption.Font = (DirectCast(resources.GetObject("layoutView1.Appearance.FocusedCardCaption.Font"), System.Drawing.Font))
            Me.layoutView1.Appearance.FocusedCardCaption.Options.UseFont = True
            Me.layoutView1.Appearance.FocusedCardCaption.Options.UseTextOptions = True
            Me.layoutView1.Appearance.FocusedCardCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutView1.Appearance.FocusedCardCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.layoutView1.Appearance.HideSelectionCardCaption.Font = (DirectCast(resources.GetObject("layoutView1.Appearance.HideSelectionCardCaption.Font"), System.Drawing.Font))
            Me.layoutView1.Appearance.HideSelectionCardCaption.Options.UseFont = True
            Me.layoutView1.Appearance.HideSelectionCardCaption.Options.UseTextOptions = True
            Me.layoutView1.Appearance.HideSelectionCardCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutView1.Appearance.HideSelectionCardCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.layoutView1.Appearance.SelectedCardCaption.Font = (DirectCast(resources.GetObject("layoutView1.Appearance.SelectedCardCaption.Font"), System.Drawing.Font))
            Me.layoutView1.Appearance.SelectedCardCaption.Options.UseFont = True
            Me.layoutView1.Appearance.SelectedCardCaption.Options.UseTextOptions = True
            Me.layoutView1.Appearance.SelectedCardCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutView1.Appearance.SelectedCardCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            resources.ApplyResources(Me.layoutView1, "layoutView1")
            Me.layoutView1.CardMinSize = New System.Drawing.Size(344, 224)
            Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colCaption, Me.colYear, Me.colPlotoutLine, Me.colRunTime, Me.colColor, Me.colPhoto})
            Me.layoutView1.GridControl = Me.gridControl1
            Me.layoutView1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colCaption})
            Me.layoutView1.Name = "layoutView1"
            Me.layoutView1.OptionsCarouselMode.PitchAngle = 1.13F
            Me.layoutView1.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.AutoSize
            Me.layoutView1.OptionsView.AllowHotTrackFields = False
            Me.layoutView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.NeverAnimate
            Me.layoutView1.OptionsView.ShowCardExpandButton = False
            Me.layoutView1.OptionsView.ShowCardLines = False
            Me.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            Me.layoutView1.OptionsView.ShowHeaderPanel = False
            Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel
            Me.layoutView1.TemplateCard = Me.layoutViewTemplateCard
            ' 
            ' colCaption
            ' 
            resources.ApplyResources(Me.colCaption, "colCaption")
            Me.colCaption.ColumnEdit = Me.repositoryItemTextEdit1
            Me.colCaption.FieldName = "Title"
            Me.colCaption.LayoutViewField = Me.layoutViewField_colCaption
            Me.colCaption.Name = "colCaption"
            Me.colCaption.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colCaption.OptionsFilter.AllowFilter = False
            ' 
            ' repositoryItemTextEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' layoutViewField_colCaption
            ' 
            Me.layoutViewField_colCaption.EditorPreferredWidth = 25
            Me.layoutViewField_colCaption.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colCaption.Name = "layoutViewField_colCaption"
            Me.layoutViewField_colCaption.Size = New System.Drawing.Size(368, 110)
            Me.layoutViewField_colCaption.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutViewField_colCaption.TextVisible = False
            ' 
            ' colYear
            ' 
            resources.ApplyResources(Me.colYear, "colYear")
            Me.colYear.FieldName = "ReleaseDate"
            Me.colYear.LayoutViewField = Me.layoutViewField_colYear
            Me.colYear.Name = "colYear"
            Me.colYear.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colYear.OptionsFilter.AllowFilter = False
            ' 
            ' layoutViewField_colYear
            ' 
            Me.layoutViewField_colYear.EditorPreferredWidth = 166
            Me.layoutViewField_colYear.Location = New System.Drawing.Point(130, 0)
            Me.layoutViewField_colYear.Name = "layoutViewField_colYear"
            Me.layoutViewField_colYear.Size = New System.Drawing.Size(208, 27)
            Me.layoutViewField_colYear.TextSize = New System.Drawing.Size(26, 13)
            ' 
            ' colPlotoutLine
            ' 
            resources.ApplyResources(Me.colPlotoutLine, "colPlotoutLine")
            Me.colPlotoutLine.ColumnEdit = Me.repositoryItemMemoEdit2
            Me.colPlotoutLine.FieldName = "Plot"
            Me.colPlotoutLine.LayoutViewField = Me.layoutViewField_colPlotoutLine
            Me.colPlotoutLine.Name = "colPlotoutLine"
            Me.colPlotoutLine.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colPlotoutLine.OptionsFilter.AllowFilter = False
            ' 
            ' repositoryItemMemoEdit2
            ' 
            Me.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2"
            ' 
            ' layoutViewField_colPlotoutLine
            ' 
            Me.layoutViewField_colPlotoutLine.EditorPreferredWidth = 197
            Me.layoutViewField_colPlotoutLine.Location = New System.Drawing.Point(130, 54)
            Me.layoutViewField_colPlotoutLine.Name = "layoutViewField_colPlotoutLine"
            Me.layoutViewField_colPlotoutLine.Size = New System.Drawing.Size(208, 29)
            Me.layoutViewField_colPlotoutLine.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutViewField_colPlotoutLine.TextVisible = False
            ' 
            ' colRunTime
            ' 
            resources.ApplyResources(Me.colRunTime, "colRunTime")
            Me.colRunTime.FieldName = "RunTime"
            Me.colRunTime.LayoutViewField = Me.layoutViewField_colRunTime
            Me.colRunTime.Name = "colRunTime"
            Me.colRunTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colRunTime.OptionsFilter.AllowFilter = False
            ' 
            ' layoutViewField_colRunTime
            ' 
            Me.layoutViewField_colRunTime.EditorPreferredWidth = 64
            Me.layoutViewField_colRunTime.Location = New System.Drawing.Point(130, 27)
            Me.layoutViewField_colRunTime.Name = "layoutViewField_colRunTime"
            Me.layoutViewField_colRunTime.Size = New System.Drawing.Size(125, 27)
            Me.layoutViewField_colRunTime.TextSize = New System.Drawing.Size(43, 13)
            ' 
            ' colColor
            ' 
            resources.ApplyResources(Me.colColor, "colColor")
            Me.colColor.FieldName = "IsColor"
            Me.colColor.LayoutViewField = Me.layoutViewField_colColor
            Me.colColor.Name = "colColor"
            Me.colColor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colColor.OptionsFilter.AllowFilter = False
            ' 
            ' layoutViewField_colColor
            ' 
            Me.layoutViewField_colColor.EditorPreferredWidth = 38
            Me.layoutViewField_colColor.Location = New System.Drawing.Point(255, 27)
            Me.layoutViewField_colColor.Name = "layoutViewField_colColor"
            Me.layoutViewField_colColor.Size = New System.Drawing.Size(83, 27)
            Me.layoutViewField_colColor.TextSize = New System.Drawing.Size(29, 13)
            ' 
            ' colPhoto
            ' 
            resources.ApplyResources(Me.colPhoto, "colPhoto")
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.LayoutViewField = Me.layoutViewField_colPhoto
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colPhoto.OptionsFilter.AllowFilter = False
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            ' 
            ' layoutViewField_colPhoto
            ' 
            Me.layoutViewField_colPhoto.EditorPreferredWidth = 119
            Me.layoutViewField_colPhoto.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto"
            Me.layoutViewField_colPhoto.Size = New System.Drawing.Size(130, 83)
            Me.layoutViewField_colPhoto.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutViewField_colPhoto.TextVisible = False
            ' 
            ' layoutViewTemplateCard
            ' 
            resources.ApplyResources(Me.layoutViewTemplateCard, "layoutViewTemplateCard")
            Me.layoutViewTemplateCard.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewTemplateCard.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colPhoto, Me.layoutViewField_colPlotoutLine, Me.layoutViewField_colRunTime, Me.layoutViewField_colColor, Me.layoutViewField_colYear})
            Me.layoutViewTemplateCard.Name = "layoutViewTemplateCard"
            ' 
            ' repositoryItemHyperLinkEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemHyperLinkEdit1, "repositoryItemHyperLinkEdit1")
            Me.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1"
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
            Me.navigationPane1.RegularSize = New System.Drawing.Size(261, 505)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.SelectedPageIndex = 0
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl2)
            Me.navigationPage1.Image = (DirectCast(resources.GetObject("navigationPage1.Image"), System.Drawing.Image))
            Me.navigationPage1.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' Layout3D
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "Layout3D"
            DirectCast(Me.bottomCardFading.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.bottomCardFading, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            DirectCast(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cardsCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cardsCount, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.flatFactor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.flatFactor, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.endAlpha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.endAlpha, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.rollAngle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.rollAngle, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.endSizeScale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.endSizeScale, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutViewField_colCaption, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutViewField_colYear, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutViewField_colPlotoutLine, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutViewField_colRunTime, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutViewField_colColor, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutViewField_colPhoto, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutViewTemplateCard, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
        Private colCaption As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private layoutViewField_colCaption As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private colYear As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colPlotoutLine As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colRunTime As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colColor As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private colPhoto As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Private repositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Private repositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        #End Region

        Private layoutViewTemplateCard As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
        Private layoutViewField_colYear As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colPlotoutLine As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colRunTime As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colColor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colPhoto As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private WithEvents endAlpha As DevExpress.XtraEditors.ZoomTrackBarControl
        Private WithEvents endSizeScale As DevExpress.XtraEditors.ZoomTrackBarControl
        Private WithEvents rollAngle As DevExpress.XtraEditors.ZoomTrackBarControl
        Private WithEvents flatFactor As DevExpress.XtraEditors.ZoomTrackBarControl
        Private WithEvents cardsCount As DevExpress.XtraEditors.ZoomTrackBarControl
        Private WithEvents bottomCardFading As DevExpress.XtraEditors.ZoomTrackBarControl
        Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit
        Private layoutControl2 As XtraLayout.LayoutControl
        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private layoutControlItem6 As XtraLayout.LayoutControlItem
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem7 As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private panelControl1 As XtraEditors.PanelControl


    End Class
End Namespace
