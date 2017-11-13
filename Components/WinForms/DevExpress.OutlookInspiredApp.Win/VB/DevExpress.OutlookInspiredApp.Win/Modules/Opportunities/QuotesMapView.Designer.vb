Namespace DevExpress.DevAV.Modules
    Partial Public Class QuoteMapView
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
            Dim keyColorColorizer1 As New DevExpress.XtraMap.KeyColorColorizer()
            Dim argumentItemKeyProvider1 As New DevExpress.XtraMap.ArgumentItemKeyProvider()
            Dim mapCallout1 As New DevExpress.XtraMap.MapCallout()
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.bingMapDataProvider1 = New DevExpress.XtraMap.BingMapDataProvider()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.bubbleChartDataAdapter1 = New DevExpress.XtraMap.BubbleChartDataAdapter()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.vectorItemsLayer2 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.mapItemStorage1 = New DevExpress.XtraMap.MapItemStorage()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biSave = New DevExpress.XtraBars.BarButtonItem()
            Me.biClose = New DevExpress.XtraBars.BarButtonItem()
            Me.biSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrint = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrintPreview = New DevExpress.XtraBars.BarButtonItem()
            Me.barExportItem = New DevExpress.XtraBars.BarButtonItem()
            Me.biHigh = New DevExpress.XtraBars.BarCheckItem()
            Me.biMedium = New DevExpress.XtraBars.BarCheckItem()
            Me.biLow = New DevExpress.XtraBars.BarCheckItem()
            Me.biUnlikely = New DevExpress.XtraBars.BarCheckItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.moduleDataLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForMap = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
            Me.simpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.moduleDataLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleDataLayout.SuspendLayout()
            CType(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForMap, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.imageLayer1.DataProvider = Me.bingMapDataProvider1
            Me.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1
            Me.vectorItemsLayer1.Colorizer = keyColorColorizer1
            Me.vectorItemsLayer1.Data = Me.bubbleChartDataAdapter1
            Me.vectorItemsLayer1.ToolTipPattern = "City:%A% Value:%V%"
            Me.bubbleChartDataAdapter1.BubbleItemDataMember = "City"
            Me.bubbleChartDataAdapter1.DataSource = Me.bindingSource
            Me.bubbleChartDataAdapter1.Mappings.BubbleGroup = "Index"
            Me.bubbleChartDataAdapter1.Mappings.Latitude = "Latitude"
            Me.bubbleChartDataAdapter1.Mappings.Longitude = "Longitude"
            Me.bubbleChartDataAdapter1.Mappings.Value = "Value"
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.QuoteMapItem)
            Me.vectorItemsLayer2.Data = Me.mapItemStorage1
            mapCallout1.AllowHtmlText = True
            mapCallout1.Text = "Test"
            Me.mapItemStorage1.Items.Add(mapCallout1)
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.biSave, Me.biClose, Me.biSaveAndClose, Me.biDelete, Me.biPrint, Me.biPrintPreview, Me.barExportItem, Me.biHigh, Me.biMedium, Me.biLow, Me.biUnlikely})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 20
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
            Me.ribbonControl.Size = New System.Drawing.Size(1226, 120)
            Me.biSave.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biSave.Caption = "Save"
            Me.biSave.Id = 1
            Me.biSave.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biSave.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Save.svg"
            Me.biSave.Name = "biSave"
            Me.biClose.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biClose.Caption = "Close"
            Me.biClose.Id = 2
            Me.biClose.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biClose.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg"
            Me.biClose.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
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
            Me.biHigh.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biHigh.Caption = "High"
            Me.biHigh.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.biHigh.Id = 16
            Me.biHigh.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biHigh.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.High.svg"
            Me.biHigh.Name = "biHigh"
            Me.biMedium.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biMedium.Caption = "Medium"
            Me.biMedium.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.biMedium.Id = 17
            Me.biMedium.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMedium.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Medium.svg"
            Me.biMedium.Name = "biMedium"
            Me.biLow.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biLow.Caption = "Low"
            Me.biLow.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.biLow.Id = 18
            Me.biLow.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biLow.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Low.svg"
            Me.biLow.Name = "biLow"
            Me.biUnlikely.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biUnlikely.Caption = "Unlikely"
            Me.biUnlikely.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.biUnlikely.Id = 19
            Me.biUnlikely.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biUnlikely.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Unlike.svg"
            Me.biUnlikely.Name = "biUnlikely"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup5, Me.ribbonPageGroup4, Me.ribbonPageGroup3})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "HOME"
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
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biHigh)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biMedium)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biLow)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biUnlikely)
            Me.ribbonPageGroup4.MergeOrder = 0
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.ShowCaptionButton = False
            Me.ribbonPageGroup4.Text = "Opportunities"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biClose)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.ShowCaptionButton = False
            Me.ribbonPageGroup3.Text = "Close"
            Me.moduleDataLayout.AllowCustomization = False
            Me.moduleDataLayout.Controls.Add(Me.mapControl)
            Me.moduleDataLayout.DataSource = Me.bindingSource
            Me.moduleDataLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleDataLayout.Location = New System.Drawing.Point(0, 120)
            Me.moduleDataLayout.Name = "moduleDataLayout"
            Me.moduleDataLayout.Root = Me.layoutControlGroup1
            Me.moduleDataLayout.Size = New System.Drawing.Size(1226, 642)
            Me.moduleDataLayout.TabIndex = 2
            Me.moduleDataLayout.Text = "moduleDataLayout"
            Me.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl.Cursor = System.Windows.Forms.Cursors.Default
            Me.mapControl.Layers.Add(Me.imageLayer1)
            Me.mapControl.Layers.Add(Me.vectorItemsLayer1)
            Me.mapControl.Layers.Add(Me.vectorItemsLayer2)
            Me.mapControl.Location = New System.Drawing.Point(0, 0)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(1222, 642)
            Me.mapControl.TabIndex = 18
            Me.mapControl.ZoomLevel = 8R
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForMap, Me.simpleSeparator1, Me.simpleSeparator2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1226, 642)
            Me.layoutControlGroup1.TextVisible = False
            Me.ItemForMap.Control = Me.mapControl
            Me.ItemForMap.CustomizationFormText = "map"
            Me.ItemForMap.Location = New System.Drawing.Point(0, 0)
            Me.ItemForMap.Name = "layoutControlItem1"
            Me.ItemForMap.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForMap.Size = New System.Drawing.Size(1222, 642)
            Me.ItemForMap.Text = "map"
            Me.ItemForMap.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForMap.TextVisible = False
            Me.simpleSeparator1.AllowHotTrack = False
            Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
            Me.simpleSeparator1.Location = New System.Drawing.Point(1224, 0)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Size = New System.Drawing.Size(2, 642)
            Me.simpleSeparator2.AllowHotTrack = False
            Me.simpleSeparator2.CustomizationFormText = "simpleSeparator2"
            Me.simpleSeparator2.Location = New System.Drawing.Point(1222, 0)
            Me.simpleSeparator2.Name = "simpleSeparator2"
            Me.simpleSeparator2.Size = New System.Drawing.Size(2, 642)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleDataLayout)
            Me.Controls.Add(Me.ribbonControl)
            Me.Margin = New System.Windows.Forms.Padding(6)
            Me.Name = "QuoteMapView"
            Me.Size = New System.Drawing.Size(1226, 762)
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.moduleDataLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleDataLayout.ResumeLayout(False)
            CType(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForMap, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private bindingSource As System.Windows.Forms.BindingSource
        Private ribbonControl As XtraBars.Ribbon.RibbonControl
        Private biSave As XtraBars.BarButtonItem
        Private biClose As XtraBars.BarButtonItem
        Private biSaveAndClose As XtraBars.BarButtonItem
        Private biDelete As XtraBars.BarButtonItem
        Private biPrint As XtraBars.BarButtonItem
        Private biPrintPreview As XtraBars.BarButtonItem
        Private barExportItem As XtraBars.BarButtonItem
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup5 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
        Private moduleDataLayout As XtraDataLayout.DataLayoutControl
        Private mapControl As XtraMap.MapControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private ItemForMap As XtraLayout.LayoutControlItem
        Private simpleSeparator1 As XtraLayout.SimpleSeparator
        Private simpleSeparator2 As XtraLayout.SimpleSeparator
        Private biHigh As XtraBars.BarCheckItem
        Private biMedium As XtraBars.BarCheckItem
        Private biLow As XtraBars.BarCheckItem
        Private biUnlikely As XtraBars.BarCheckItem
        Private ribbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
        Private imageLayer1 As XtraMap.ImageLayer
        Private bingMapDataProvider1 As XtraMap.BingMapDataProvider
        Private WithEvents vectorItemsLayer1 As XtraMap.VectorItemsLayer
        Private bubbleChartDataAdapter1 As XtraMap.BubbleChartDataAdapter
        Private vectorItemsLayer2 As XtraMap.VectorItemsLayer
        Private mapItemStorage1 As XtraMap.MapItemStorage
    End Class
End Namespace
