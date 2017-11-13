Namespace DevExpress.DevAV.Modules
    Partial Public Class EmployeeMapView
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
            Me.imageTilesLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.bingMapDataProvider1 = New DevExpress.XtraMap.BingMapDataProvider()
            Me.informationLayer1 = New DevExpress.XtraMap.InformationLayer()
            Me.bingGeocodeDataProvider1 = New DevExpress.XtraMap.BingGeocodeDataProvider()
            Me.informationLayer2 = New DevExpress.XtraMap.InformationLayer()
            Me.bingSearchDataProvider1 = New DevExpress.XtraMap.BingSearchDataProvider()
            Me.informationLayer3 = New DevExpress.XtraMap.InformationLayer()
            Me.bingRouteDataProvider1 = New DevExpress.XtraMap.BingRouteDataProvider()
            Me.routePanel = New DevExpress.XtraEditors.PanelControl()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.bindingSourceRoute = New System.Windows.Forms.BindingSource(Me.components)
            Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colManeuver = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colDistance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colManeuverInstruction = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biSave = New DevExpress.XtraBars.BarButtonItem()
            Me.biClose = New DevExpress.XtraBars.BarButtonItem()
            Me.biSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biDriving = New DevExpress.XtraBars.BarCheckItem()
            Me.biWalking = New DevExpress.XtraBars.BarCheckItem()
            Me.biPrint = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrintPreview = New DevExpress.XtraBars.BarButtonItem()
            Me.barExportItem = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.routeResultLabel = New DevExpress.XtraEditors.LabelControl()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.moduleDataLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.AddressLabelLine2 = New DevExpress.XtraEditors.LabelControl()
            Me.swapRouteButtons = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.routeButtons = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.editPointB = New DevExpress.XtraEditors.TextEdit()
            Me.editPointA = New DevExpress.XtraEditors.TextEdit()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.FullNameLabel = New DevExpress.XtraEditors.LabelControl()
            Me.AddressLabelLine1 = New DevExpress.XtraEditors.LabelControl()
            Me.PhotoPictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForMap = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForPointB = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForPointA = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForRoutePanel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForRouteButtons = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForSwapButton = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForPhoto = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForAddressLine1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForFullName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForAddressLine2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
            Me.simpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.routePanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.routePanel.SuspendLayout()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSourceRoute, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.moduleDataLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleDataLayout.SuspendLayout()
            CType(Me.editPointB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.editPointA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PhotoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForMap, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForPointB, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForPointA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForRoutePanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForRouteButtons, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForSwapButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForAddressLine1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForFullName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForAddressLine2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.imageTilesLayer1.DataProvider = Me.bingMapDataProvider1
            Me.informationLayer1.DataProvider = Me.bingGeocodeDataProvider1
            Me.bingGeocodeDataProvider1.GenerateLayerItems = False
            Me.bingGeocodeDataProvider1.MaxVisibleResultCount = 3
            Me.bingGeocodeDataProvider1.ProcessMouseEvents = True
            Me.informationLayer2.DataProvider = Me.bingSearchDataProvider1
            Me.bingSearchDataProvider1.GenerateLayerItems = False
            Me.informationLayer3.DataProvider = Me.bingRouteDataProvider1
            Me.informationLayer3.HighlightedItemStyle.Stroke = System.Drawing.Color.Cyan
            Me.informationLayer3.HighlightedItemStyle.StrokeWidth = 3
            Me.informationLayer3.ItemStyle.Stroke = System.Drawing.Color.Cyan
            Me.informationLayer3.ItemStyle.StrokeWidth = 3
            Me.bingRouteDataProvider1.RouteOptions.DistanceUnit = DevExpress.XtraMap.DistanceMeasureUnit.Mile
            Me.routePanel.Controls.Add(Me.gridControl)
            Me.routePanel.Controls.Add(Me.routeResultLabel)
            Me.routePanel.Location = New System.Drawing.Point(870, 252)
            Me.routePanel.Name = "routePanel"
            Me.routePanel.Size = New System.Drawing.Size(340, 359)
            Me.routePanel.TabIndex = 32
            Me.gridControl.DataSource = Me.bindingSourceRoute
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(2, 38)
            Me.gridControl.MainView = Me.advBandedGridView1
            Me.gridControl.MenuManager = Me.ribbonControl
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoEdit1})
            Me.gridControl.ShowOnlyPredefinedDetails = True
            Me.gridControl.Size = New System.Drawing.Size(336, 319)
            Me.gridControl.TabIndex = 6
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1})
            Me.bindingSourceRoute.DataSource = GetType(DevExpress.DevAV.Presenters.RoutePoint)
            Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2})
            Me.advBandedGridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colManeuver, Me.colManeuverInstruction, Me.colDistance})
            Me.advBandedGridView1.GridControl = Me.gridControl
            Me.advBandedGridView1.Name = "advBandedGridView1"
            Me.advBandedGridView1.OptionsBehavior.Editable = False
            Me.advBandedGridView1.OptionsFind.AllowFindPanel = False
            Me.advBandedGridView1.OptionsView.ColumnAutoWidth = True
            Me.advBandedGridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True
            Me.advBandedGridView1.OptionsView.ShowBands = False
            Me.advBandedGridView1.OptionsView.ShowColumnHeaders = False
            Me.advBandedGridView1.OptionsView.ShowGroupPanel = False
            Me.advBandedGridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False
            Me.advBandedGridView1.OptionsView.ShowIndicator = False
            Me.advBandedGridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            Me.advBandedGridView1.RowHeight = 16
            Me.gridBand1.Columns.Add(Me.colManeuver)
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.OptionsBand.AllowSize = False
            Me.gridBand1.OptionsBand.FixedWidth = True
            Me.gridBand1.VisibleIndex = 0
            Me.gridBand1.Width = 64
            Me.colManeuver.FieldName = "Maneuver"
            Me.colManeuver.Name = "colManeuver"
            Me.colManeuver.OptionsColumn.AllowEdit = False
            Me.colManeuver.OptionsColumn.AllowFocus = False
            Me.colManeuver.RowCount = 4
            Me.colManeuver.Visible = True
            Me.colManeuver.Width = 64
            Me.gridBand2.Columns.Add(Me.colDistance)
            Me.gridBand2.Columns.Add(Me.colManeuverInstruction)
            Me.gridBand2.Name = "gridBand2"
            Me.gridBand2.VisibleIndex = 1
            Me.gridBand2.Width = 254
            Me.colDistance.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.colDistance.AppearanceCell.Options.UseFont = True
            Me.colDistance.AppearanceCell.Options.UseTextOptions = True
            Me.colDistance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.colDistance.FieldName = "Distance"
            Me.colDistance.Name = "colDistance"
            Me.colDistance.OptionsColumn.AllowEdit = False
            Me.colDistance.OptionsColumn.AllowFocus = False
            Me.colDistance.Visible = True
            Me.colDistance.Width = 254
            Me.colManeuverInstruction.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 12F)
            Me.colManeuverInstruction.AppearanceCell.Options.UseFont = True
            Me.colManeuverInstruction.AppearanceCell.Options.UseTextOptions = True
            Me.colManeuverInstruction.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.colManeuverInstruction.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.colManeuverInstruction.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colManeuverInstruction.FieldName = "ManeuverInstruction"
            Me.colManeuverInstruction.Name = "colManeuverInstruction"
            Me.colManeuverInstruction.OptionsColumn.AllowEdit = False
            Me.colManeuverInstruction.OptionsColumn.AllowFocus = False
            Me.colManeuverInstruction.RowCount = 3
            Me.colManeuverInstruction.RowIndex = 1
            Me.colManeuverInstruction.Visible = True
            Me.colManeuverInstruction.Width = 254
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.biSave, Me.biClose, Me.biSaveAndClose, Me.biDelete, Me.biDriving, Me.biWalking, Me.biPrint, Me.biPrintPreview, Me.barExportItem})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 12
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl.Size = New System.Drawing.Size(1226, 141)
            Me.biSave.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biSave.Caption = "Save"
            Me.biSave.Id = 1
            Me.biSave.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biSave.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Save.svg"
            Me.biSave.Name = "biSave"
            Me.biClose.Caption = "Close"
            Me.biClose.Glyph = My.Resources.icon_close_16
            Me.biClose.Id = 2
            Me.biClose.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biClose.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg"
            Me.biClose.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
            Me.biClose.LargeGlyph = My.Resources.icon_close_32
            Me.biClose.Name = "biClose"
            Me.biSaveAndClose.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biSaveAndClose.Caption = "Save && Close"
            Me.biSaveAndClose.Id = 3
            Me.biSaveAndClose.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biSaveAndClose.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SaveAndClose.svg"
            Me.biSaveAndClose.Name = "biSaveAndClose"
            Me.biDelete.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biDelete.Caption = "Delete"
            Me.biDelete.Id = 4
            Me.biDelete.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDelete.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg"
            Me.biDelete.Name = "biDelete"
            Me.biDriving.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biDriving.Caption = "Driving"
            Me.biDriving.Id = 5
            Me.biDriving.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDriving.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Driving.svg"
            Me.biDriving.Name = "biDriving"
            Me.biWalking.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biWalking.Caption = "Walking"
            Me.biWalking.Id = 6
            Me.biWalking.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biWalking.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Walking.svg"
            Me.biWalking.Name = "biWalking"
            Me.biPrint.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biPrint.Caption = "Print"
            Me.biPrint.Id = 8
            Me.biPrint.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPrint.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg"
            Me.biPrint.Name = "biPrint"
            Me.biPrintPreview.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biPrintPreview.Caption = "Print Preview"
            Me.biPrintPreview.Id = 9
            Me.biPrintPreview.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPrintPreview.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintPreview.svg"
            Me.biPrintPreview.Name = "biPrintPreview"
            Me.barExportItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.barExportItem.Caption = "Export"
            Me.barExportItem.Id = 11
            Me.barExportItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.barExportItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Export.svg"
            Me.barExportItem.LargeImageIndex = 50
            Me.barExportItem.Name = "barExportItem"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup5, Me.ribbonPageGroup4, Me.ribbonPageGroup3})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "CONTACT"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biSave)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biSaveAndClose)
            Me.ribbonPageGroup1.MergeOrder = 0
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup2.AllowTextClipping = False
            Me.ribbonPageGroup2.ItemLinks.Add(Me.biDelete)
            Me.ribbonPageGroup2.MergeOrder = 0
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.ShowCaptionButton = False
            Me.ribbonPageGroup2.Text = "Delete"
            Me.ribbonPageGroup5.AllowTextClipping = False
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biPrintPreview)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biPrint)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.barExportItem)
            Me.ribbonPageGroup5.MergeOrder = 0
            Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
            Me.ribbonPageGroup5.ShowCaptionButton = False
            Me.ribbonPageGroup5.Text = "Print and Export"
            Me.ribbonPageGroup4.AllowTextClipping = False
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biDriving)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biWalking)
            Me.ribbonPageGroup4.MergeOrder = 0
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.ShowCaptionButton = False
            Me.ribbonPageGroup4.Text = "Route Options"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biClose)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.ShowCaptionButton = False
            Me.ribbonPageGroup3.Text = "Close"
            Me.routeResultLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.routeResultLabel.Appearance.Options.UseFont = True
            Me.routeResultLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.routeResultLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "RouteResult", True))
            Me.routeResultLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.routeResultLabel.Location = New System.Drawing.Point(2, 2)
            Me.routeResultLabel.Name = "routeResultLabel"
            Me.routeResultLabel.Padding = New System.Windows.Forms.Padding(12, 12, 12, 24)
            Me.routeResultLabel.Size = New System.Drawing.Size(336, 36)
            Me.routeResultLabel.TabIndex = 29
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.ViewModels.EmployeeMapViewModel)
            Me.moduleDataLayout.AllowCustomization = False
            Me.moduleDataLayout.Controls.Add(Me.AddressLabelLine2)
            Me.moduleDataLayout.Controls.Add(Me.swapRouteButtons)
            Me.moduleDataLayout.Controls.Add(Me.routeButtons)
            Me.moduleDataLayout.Controls.Add(Me.routePanel)
            Me.moduleDataLayout.Controls.Add(Me.editPointB)
            Me.moduleDataLayout.Controls.Add(Me.editPointA)
            Me.moduleDataLayout.Controls.Add(Me.mapControl)
            Me.moduleDataLayout.Controls.Add(Me.FullNameLabel)
            Me.moduleDataLayout.Controls.Add(Me.AddressLabelLine1)
            Me.moduleDataLayout.Controls.Add(Me.PhotoPictureEdit)
            Me.moduleDataLayout.DataSource = Me.bindingSource
            Me.moduleDataLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleDataLayout.Location = New System.Drawing.Point(0, 141)
            Me.moduleDataLayout.Name = "moduleDataLayout"
            Me.moduleDataLayout.Root = Me.layoutControlGroup1
            Me.moduleDataLayout.Size = New System.Drawing.Size(1226, 621)
            Me.moduleDataLayout.TabIndex = 1
            Me.moduleDataLayout.Text = "moduleDataLayout"
            Me.AddressLabelLine2.Appearance.Font = New System.Drawing.Font("Segoe UI", 11F)
            Me.AddressLabelLine2.Appearance.Options.UseFont = True
            Me.AddressLabelLine2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "AddressLine2", True))
            Me.AddressLabelLine2.Location = New System.Drawing.Point(957, 62)
            Me.AddressLabelLine2.Name = "AddressLabelLine2"
            Me.AddressLabelLine2.Size = New System.Drawing.Size(253, 20)
            Me.AddressLabelLine2.StyleController = Me.moduleDataLayout
            Me.AddressLabelLine2.TabIndex = 33
            Me.swapRouteButtons.AllowGlyphSkinning = False
            Me.swapRouteButtons.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() { New DevExpress.XtraBars.Docking2010.WindowsUIButton("Driving", My.Resources.icon_revert_direction_14, -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", False, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False)})
            Me.swapRouteButtons.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.swapRouteButtons.Location = New System.Drawing.Point(870, 196)
            Me.swapRouteButtons.Name = "swapRouteButtons"
            Me.swapRouteButtons.Size = New System.Drawing.Size(340, 14)
            Me.swapRouteButtons.TabIndex = 31
            Me.swapRouteButtons.UseButtonBackgroundImages = False
            Me.routeButtons.AllowGlyphSkinning = False
            Me.routeButtons.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("Walking", My.Resources.icon_walking_14, -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", False, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False),
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("Driving", My.Resources.icon_driving_14, -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", False, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False)
            })
            Me.routeButtons.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.routeButtons.Location = New System.Drawing.Point(870, 150)
            Me.routeButtons.Name = "routeButtons"
            Me.routeButtons.Size = New System.Drawing.Size(340, 14)
            Me.routeButtons.TabIndex = 30
            Me.routeButtons.UseButtonBackgroundImages = False
            Me.editPointB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "PointBAddress", True))
            Me.editPointB.Location = New System.Drawing.Point(870, 210)
            Me.editPointB.MinimumSize = New System.Drawing.Size(340, 0)
            Me.editPointB.Name = "editPointB"
            Me.editPointB.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.editPointB.Properties.Appearance.Options.UseFont = True
            Me.editPointB.Size = New System.Drawing.Size(340, 28)
            Me.editPointB.StyleController = Me.moduleDataLayout
            Me.editPointB.TabIndex = 24
            Me.editPointA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "PointAAddress", True))
            Me.editPointA.Location = New System.Drawing.Point(870, 168)
            Me.editPointA.Name = "editPointA"
            Me.editPointA.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.editPointA.Properties.Appearance.Options.UseFont = True
            Me.editPointA.Size = New System.Drawing.Size(340, 28)
            Me.editPointA.StyleController = Me.moduleDataLayout
            Me.editPointA.TabIndex = 21
            Me.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl.Layers.Add(Me.imageTilesLayer1)
            Me.mapControl.Layers.Add(Me.informationLayer1)
            Me.mapControl.Layers.Add(Me.informationLayer2)
            Me.mapControl.Layers.Add(Me.informationLayer3)
            Me.mapControl.Location = New System.Drawing.Point(0, 0)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.ShowSearchPanel = False
            Me.mapControl.Size = New System.Drawing.Size(819, 621)
            Me.mapControl.TabIndex = 18
            Me.mapControl.ZoomLevel = 8R
            Me.FullNameLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 18F)
            Me.FullNameLabel.Appearance.Options.UseFont = True
            Me.FullNameLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "FullName", True))
            Me.FullNameLabel.Location = New System.Drawing.Point(955, 8)
            Me.FullNameLabel.Name = "FullNameLabel"
            Me.FullNameLabel.Size = New System.Drawing.Size(257, 32)
            Me.FullNameLabel.StyleController = Me.moduleDataLayout
            Me.FullNameLabel.TabIndex = 8
            Me.AddressLabelLine1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11F)
            Me.AddressLabelLine1.Appearance.Options.UseFont = True
            Me.AddressLabelLine1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "AddressLine1", True))
            Me.AddressLabelLine1.Location = New System.Drawing.Point(955, 40)
            Me.AddressLabelLine1.Name = "AddressLabelLine1"
            Me.AddressLabelLine1.Size = New System.Drawing.Size(257, 20)
            Me.AddressLabelLine1.StyleController = Me.moduleDataLayout
            Me.AddressLabelLine1.TabIndex = 8
            Me.PhotoPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
            Me.PhotoPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Picture", True))
            Me.PhotoPictureEdit.Location = New System.Drawing.Point(835, 8)
            Me.PhotoPictureEdit.MenuManager = Me.ribbonControl
            Me.PhotoPictureEdit.Name = "PhotoPictureEdit"
            Me.PhotoPictureEdit.Properties.ReadOnly = True
            Me.PhotoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.PhotoPictureEdit.Properties.ZoomAccelerationFactor = 1R
            Me.PhotoPictureEdit.Size = New System.Drawing.Size(108, 120)
            Me.PhotoPictureEdit.StyleController = Me.moduleDataLayout
            Me.PhotoPictureEdit.TabIndex = 17
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForMap, Me.layoutControlGroup3, Me.layoutControlGroup4, Me.simpleSeparator1, Me.simpleSeparator2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1226, 621)
            Me.layoutControlGroup1.TextVisible = False
            Me.ItemForMap.Control = Me.mapControl
            Me.ItemForMap.CustomizationFormText = "ItemForMap"
            Me.ItemForMap.Location = New System.Drawing.Point(0, 0)
            Me.ItemForMap.Name = "ItemForMap"
            Me.ItemForMap.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForMap.Size = New System.Drawing.Size(819, 621)
            Me.ItemForMap.Text = "map"
            Me.ItemForMap.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForMap.TextVisible = False
            Me.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3"
            Me.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForPointB, Me.ItemForPointA, Me.ItemForRoutePanel, Me.ItemForRouteButtons, Me.ItemForSwapButton})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(821, 140)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 8, 8)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(405, 481)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 0)
            Me.layoutControlGroup3.TextVisible = False
            Me.ItemForPointB.Control = Me.editPointB
            Me.ItemForPointB.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.ItemForPointB.CustomizationFormText = "B"
            Me.ItemForPointB.Image = My.Resources.icon_B_24
            Me.ItemForPointB.ImageToTextDistance = 0
            Me.ItemForPointB.Location = New System.Drawing.Point(0, 60)
            Me.ItemForPointB.Name = "ItemForPointB"
            Me.ItemForPointB.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 2)
            Me.ItemForPointB.Size = New System.Drawing.Size(377, 30)
            Me.ItemForPointB.Text = " "
            Me.ItemForPointB.TextSize = New System.Drawing.Size(27, 24)
            Me.ItemForPointA.Control = Me.editPointA
            Me.ItemForPointA.ControlAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.ItemForPointA.CustomizationFormText = "A"
            Me.ItemForPointA.Image = My.Resources.icon_A_24
            Me.ItemForPointA.ImageToTextDistance = 0
            Me.ItemForPointA.Location = New System.Drawing.Point(0, 16)
            Me.ItemForPointA.Name = "ItemForPointA"
            Me.ItemForPointA.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 0)
            Me.ItemForPointA.Size = New System.Drawing.Size(377, 30)
            Me.ItemForPointA.Text = " "
            Me.ItemForPointA.TextSize = New System.Drawing.Size(27, 24)
            Me.ItemForRoutePanel.Control = Me.routePanel
            Me.ItemForRoutePanel.CustomizationFormText = " "
            Me.ItemForRoutePanel.Location = New System.Drawing.Point(0, 90)
            Me.ItemForRoutePanel.Name = "ItemForRoutePanel"
            Me.ItemForRoutePanel.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 12, 2)
            Me.ItemForRoutePanel.Size = New System.Drawing.Size(377, 373)
            Me.ItemForRoutePanel.Text = " "
            Me.ItemForRoutePanel.TextSize = New System.Drawing.Size(27, 13)
            Me.ItemForRouteButtons.Control = Me.routeButtons
            Me.ItemForRouteButtons.CustomizationFormText = " "
            Me.ItemForRouteButtons.Location = New System.Drawing.Point(0, 0)
            Me.ItemForRouteButtons.Name = "ItemForRouteButtons"
            Me.ItemForRouteButtons.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 2)
            Me.ItemForRouteButtons.Size = New System.Drawing.Size(377, 16)
            Me.ItemForRouteButtons.Text = " "
            Me.ItemForRouteButtons.TextSize = New System.Drawing.Size(27, 13)
            Me.ItemForSwapButton.Control = Me.swapRouteButtons
            Me.ItemForSwapButton.CustomizationFormText = " "
            Me.ItemForSwapButton.Location = New System.Drawing.Point(0, 46)
            Me.ItemForSwapButton.Name = "ItemForSwapButton"
            Me.ItemForSwapButton.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 0)
            Me.ItemForSwapButton.Size = New System.Drawing.Size(377, 14)
            Me.ItemForSwapButton.Text = " "
            Me.ItemForSwapButton.TextSize = New System.Drawing.Size(27, 13)
            Me.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4"
            Me.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup4.GroupBordersVisible = False
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.emptySpaceItem2, Me.ItemForPhoto, Me.ItemForAddressLine1, Me.ItemForFullName, Me.ItemForAddressLine2})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(821, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 8, 8)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(405, 138)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 2)
            Me.layoutControlGroup4.TextVisible = False
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(120, 76)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(257, 44)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForPhoto.Control = Me.PhotoPictureEdit
            Me.ItemForPhoto.CustomizationFormText = "Photo"
            Me.ItemForPhoto.Location = New System.Drawing.Point(0, 0)
            Me.ItemForPhoto.MaxSize = New System.Drawing.Size(120, 120)
            Me.ItemForPhoto.MinSize = New System.Drawing.Size(120, 120)
            Me.ItemForPhoto.Name = "ItemForPhoto"
            Me.ItemForPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 12, 0, 0)
            Me.ItemForPhoto.Size = New System.Drawing.Size(120, 120)
            Me.ItemForPhoto.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForPhoto.Text = "Photo"
            Me.ItemForPhoto.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForPhoto.TextVisible = False
            Me.ItemForAddressLine1.Control = Me.AddressLabelLine1
            Me.ItemForAddressLine1.CustomizationFormText = "Address"
            Me.ItemForAddressLine1.Location = New System.Drawing.Point(120, 32)
            Me.ItemForAddressLine1.Name = "ItemForAddressLine1"
            Me.ItemForAddressLine1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForAddressLine1.Size = New System.Drawing.Size(257, 20)
            Me.ItemForAddressLine1.Text = "Address"
            Me.ItemForAddressLine1.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForAddressLine1.TextVisible = False
            Me.ItemForFullName.Control = Me.FullNameLabel
            Me.ItemForFullName.CustomizationFormText = "Full Name"
            Me.ItemForFullName.Location = New System.Drawing.Point(120, 0)
            Me.ItemForFullName.Name = "ItemForFullName"
            Me.ItemForFullName.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForFullName.Size = New System.Drawing.Size(257, 32)
            Me.ItemForFullName.Text = "Full Name"
            Me.ItemForFullName.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForFullName.TextVisible = False
            Me.ItemForAddressLine2.Control = Me.AddressLabelLine2
            Me.ItemForAddressLine2.CustomizationFormText = "Address"
            Me.ItemForAddressLine2.Location = New System.Drawing.Point(120, 52)
            Me.ItemForAddressLine2.Name = "ItemForAddressLine2"
            Me.ItemForAddressLine2.Size = New System.Drawing.Size(257, 24)
            Me.ItemForAddressLine2.Text = "Address"
            Me.ItemForAddressLine2.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForAddressLine2.TextVisible = False
            Me.simpleSeparator1.AllowHotTrack = False
            Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
            Me.simpleSeparator1.Location = New System.Drawing.Point(821, 138)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Size = New System.Drawing.Size(405, 2)
            Me.simpleSeparator2.AllowHotTrack = False
            Me.simpleSeparator2.CustomizationFormText = "simpleSeparator2"
            Me.simpleSeparator2.Location = New System.Drawing.Point(819, 0)
            Me.simpleSeparator2.Name = "simpleSeparator2"
            Me.simpleSeparator2.Size = New System.Drawing.Size(2, 621)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleDataLayout)
            Me.Controls.Add(Me.ribbonControl)
            Me.Name = "EmployeeMapView"
            Me.Size = New System.Drawing.Size(1226, 762)
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.routePanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.routePanel.ResumeLayout(False)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSourceRoute, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.moduleDataLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleDataLayout.ResumeLayout(False)
            CType(Me.editPointB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.editPointA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PhotoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForMap, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForPointB, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForPointA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForRoutePanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForRouteButtons, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForSwapButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForPhoto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForAddressLine1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForFullName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForAddressLine2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbonControl As XtraBars.Ribbon.RibbonControl
        Private biSave As XtraBars.BarButtonItem
        Private biClose As XtraBars.BarButtonItem
        Private biSaveAndClose As XtraBars.BarButtonItem
        Private biDelete As XtraBars.BarButtonItem
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
        Private moduleDataLayout As XtraDataLayout.DataLayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private bindingSource As System.Windows.Forms.BindingSource
        Private FullNameLabel As XtraEditors.LabelControl
        Private AddressLabelLine1 As XtraEditors.LabelControl
        Private PhotoPictureEdit As XtraEditors.PictureEdit
        Private mapControl As DevExpress.XtraMap.MapControl
        Private editPointB As DevExpress.XtraEditors.TextEdit
        Private editPointA As DevExpress.XtraEditors.TextEdit
        Private gridControl As XtraGrid.GridControl
        Private biDriving As XtraBars.BarCheckItem
        Private biWalking As XtraBars.BarCheckItem
        Private ribbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
        Private routeResultLabel As XtraEditors.LabelControl
        Private bindingSourceRoute As System.Windows.Forms.BindingSource
        Private routeButtons As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
        Private biPrint As XtraBars.BarButtonItem
        Private biPrintPreview As XtraBars.BarButtonItem
        Private barExportItem As XtraBars.BarButtonItem
        Private ribbonPageGroup5 As XtraBars.Ribbon.RibbonPageGroup
        Private repositoryItemMemoEdit1 As XtraEditors.Repository.RepositoryItemMemoEdit
        Private advBandedGridView1 As XtraGrid.Views.BandedGrid.AdvBandedGridView
        Private colManeuver As XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colManeuverInstruction As XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colDistance As XtraGrid.Views.BandedGrid.BandedGridColumn
        Private gridBand1 As XtraGrid.Views.BandedGrid.GridBand
        Private gridBand2 As XtraGrid.Views.BandedGrid.GridBand
        Private swapRouteButtons As XtraBars.Docking2010.WindowsUIButtonPanel
        Private routePanel As XtraEditors.PanelControl
        Private ItemForMap As XtraLayout.LayoutControlItem
        Private layoutControlGroup3 As XtraLayout.LayoutControlGroup
        Private ItemForPointB As XtraLayout.LayoutControlItem
        Private ItemForPointA As XtraLayout.LayoutControlItem
        Private ItemForRoutePanel As XtraLayout.LayoutControlItem
        Private ItemForRouteButtons As XtraLayout.LayoutControlItem
        Private ItemForSwapButton As XtraLayout.LayoutControlItem
        Private layoutControlGroup4 As XtraLayout.LayoutControlGroup
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private ItemForPhoto As XtraLayout.LayoutControlItem
        Private ItemForAddressLine1 As XtraLayout.LayoutControlItem
        Private ItemForFullName As XtraLayout.LayoutControlItem
        Private simpleSeparator1 As XtraLayout.SimpleSeparator
        Private simpleSeparator2 As XtraLayout.SimpleSeparator
        Private AddressLabelLine2 As XtraEditors.LabelControl
        Private ItemForAddressLine2 As XtraLayout.LayoutControlItem
        Private imageTilesLayer1 As XtraMap.ImageLayer
        Private bingMapDataProvider1 As XtraMap.BingMapDataProvider
        Private informationLayer1 As XtraMap.InformationLayer
        Private bingGeocodeDataProvider1 As XtraMap.BingGeocodeDataProvider
        Private informationLayer2 As XtraMap.InformationLayer
        Private bingSearchDataProvider1 As XtraMap.BingSearchDataProvider
        Private informationLayer3 As XtraMap.InformationLayer
        Private bingRouteDataProvider1 As XtraMap.BingRouteDataProvider
    End Class
End Namespace
