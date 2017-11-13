Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ucDocumentManagerWindowsUISearchPanel
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

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

		#Region "Windows Form Designer generated code"

		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucDocumentManagerWindowsUISearchPanel))
            Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.windowsUIView = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(Me.components)
            Me.tileContainer = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(Me.components)
            Me.salesByStateTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.salesByState = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(Me.components)
            Me.ucChoroplethMapItemDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucProductsGridDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucCategorySalesDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucChartProductItemDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.salesInCaliforniaTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.salesInCalifornia = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(Me.components)
            Me.salesInMontanaTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.salesInMontana = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(Me.components)
            Me.salesInTexasTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.salesInTexas = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(Me.components)
            CType(Me.documentManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.windowsUIView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tileContainer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.salesByStateTile, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.salesByState, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ucChoroplethMapItemDocument, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ucProductsGridDocument, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ucCategorySalesDocument, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ucChartProductItemDocument, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.salesInCaliforniaTile, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.salesInCalifornia, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.salesInMontanaTile, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.salesInMontana, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.salesInTexasTile, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.salesInTexas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'documentManager
            '
            Me.documentManager.ContainerControl = Me
            Me.documentManager.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentManager.View = Me.windowsUIView
            Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.windowsUIView})
            '
            'windowsUIView
            '
            Me.windowsUIView.Caption = "Press Ctrl+F to invoke the Search Panel"
            Me.windowsUIView.ContentContainers.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer() {Me.tileContainer, Me.salesByState, Me.salesInCalifornia, Me.salesInMontana, Me.salesInTexas})
            Me.windowsUIView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.ucChartProductItemDocument, Me.ucCategorySalesDocument, Me.ucChoroplethMapItemDocument, Me.ucProductsGridDocument})
            Me.windowsUIView.SearchPanelProperties.ClearButtonShowMode = DevExpress.XtraBars.Docking2010.Customization.ClearButtonShowMode.[Auto]
            Me.windowsUIView.Tiles.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() {Me.salesByStateTile, Me.salesInCaliforniaTile, Me.salesInMontanaTile, Me.salesInTexasTile})
            Me.windowsUIView.UseSplashScreen = DevExpress.Utils.DefaultBoolean.[False]
            '
            'tileContainer
            '
            Me.tileContainer.ExcludeFromSearch = True
            Me.tileContainer.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() {Me.salesByStateTile, Me.salesInCaliforniaTile, Me.salesInMontanaTile, Me.salesInTexasTile})
            Me.tileContainer.Name = "tileContainer"
            Me.tileContainer.Position = 138
            '
            'salesByStateTile
            '
            Me.salesByStateTile.ActivationTarget = Me.salesByState
            Me.salesByStateTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(212, Byte), Integer))
            Me.salesByStateTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(212, Byte), Integer))
            Me.salesByStateTile.Appearances.Normal.Options.UseBackColor = True
            Me.salesByStateTile.Appearances.Normal.Options.UseBorderColor = True
            Me.salesByStateTile.BackgroundImage = CType(resources.GetObject("salesByStateTile.BackgroundImage"), System.Drawing.Image)
            TileItemElement1.ImageBorderColor = System.Drawing.Color.Empty
            TileItemElement1.Text = "Sales by state"
            TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
            Me.salesByStateTile.Elements.Add(TileItemElement1)
            Me.tileContainer.SetID(Me.salesByStateTile, 3)
            Me.salesByStateTile.Name = "salesByStateTile"
            '
            'salesByState
            '
            Me.salesByState.Caption = "Sales by state"
            Me.salesByState.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document() {Me.ucChoroplethMapItemDocument, Me.ucProductsGridDocument, Me.ucCategorySalesDocument, Me.ucChartProductItemDocument})
            Me.salesByState.Name = "salesByState"
            Me.salesByState.Parent = Me.tileContainer
            '
            'ucChoroplethMapItemDocument
            '
            Me.ucChoroplethMapItemDocument.Caption = "Choropleth Map"
            Me.ucChoroplethMapItemDocument.ControlName = "ucChoroplethMapItem"
            Me.ucChoroplethMapItemDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucChoroplethMapItem"
            '
            'ucProductsGridDocument
            '
            Me.ucProductsGridDocument.Caption = "Products"
            Me.ucProductsGridDocument.ControlName = "ucProductsGrid"
            Me.ucProductsGridDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucProductsGrid"
            '
            'ucCategorySalesDocument
            '
            Me.ucCategorySalesDocument.Caption = "Category Sales"
            Me.ucCategorySalesDocument.ControlName = "ucCategorySales"
            Me.ucCategorySalesDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCategorySales"
            '
            'ucChartProductItemDocument
            '
            Me.ucChartProductItemDocument.Caption = "Chart Product"
            Me.ucChartProductItemDocument.ControlName = "ucChartProductItem"
            Me.ucChartProductItemDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucChartProductItem"
            '
            'salesInCaliforniaTile
            '
            Me.salesInCaliforniaTile.ActivationTarget = Me.salesInCalifornia
            Me.salesInCaliforniaTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(212, Byte), Integer))
            Me.salesInCaliforniaTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(212, Byte), Integer))
            Me.salesInCaliforniaTile.Appearances.Normal.Options.UseBackColor = True
            Me.salesInCaliforniaTile.Appearances.Normal.Options.UseBorderColor = True
            Me.salesInCaliforniaTile.BackgroundImage = CType(resources.GetObject("salesInCaliforniaTile.BackgroundImage"), System.Drawing.Image)
            TileItemElement2.ImageBorderColor = System.Drawing.Color.Empty
            TileItemElement2.Text = "Sales in California"
            TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
            Me.salesInCaliforniaTile.Elements.Add(TileItemElement2)
            Me.tileContainer.SetID(Me.salesInCaliforniaTile, 24)
            Me.salesInCaliforniaTile.Name = "salesInCaliforniaTile"
            '
            'salesInCalifornia
            '
            Me.salesInCalifornia.Caption = "Sales in California"
            Me.salesInCalifornia.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document() {Me.ucProductsGridDocument, Me.ucCategorySalesDocument, Me.ucChartProductItemDocument})
            Me.salesInCalifornia.Name = "salesInCalifornia"
            Me.salesInCalifornia.Parent = Me.tileContainer
            '
            'salesInMontanaTile
            '
            Me.salesInMontanaTile.ActivationTarget = Me.salesInMontana
            Me.salesInMontanaTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(212, Byte), Integer))
            Me.salesInMontanaTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(212, Byte), Integer))
            Me.salesInMontanaTile.Appearances.Normal.Options.UseBackColor = True
            Me.salesInMontanaTile.Appearances.Normal.Options.UseBorderColor = True
            Me.salesInMontanaTile.BackgroundImage = CType(resources.GetObject("salesInMontanaTile.BackgroundImage"), System.Drawing.Image)
            TileItemElement3.ImageBorderColor = System.Drawing.Color.Empty
            TileItemElement3.Text = "Sales in Montana"
            TileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
            Me.salesInMontanaTile.Elements.Add(TileItemElement3)
            Me.tileContainer.SetID(Me.salesInMontanaTile, 25)
            Me.salesInMontanaTile.Name = "salesInMontanaTile"
            '
            'salesInMontana
            '
            Me.salesInMontana.Caption = "Sales in Montana"
            Me.salesInMontana.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document() {Me.ucProductsGridDocument, Me.ucCategorySalesDocument, Me.ucChartProductItemDocument})
            Me.salesInMontana.Name = "salesInMontana"
            Me.salesInMontana.Parent = Me.tileContainer
            '
            'salesInTexasTile
            '
            Me.salesInTexasTile.ActivationTarget = Me.salesInTexas
            Me.salesInTexasTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(212, Byte), Integer))
            Me.salesInTexasTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(212, Byte), Integer))
            Me.salesInTexasTile.Appearances.Normal.Options.UseBackColor = True
            Me.salesInTexasTile.Appearances.Normal.Options.UseBorderColor = True
            Me.salesInTexasTile.BackgroundImage = CType(resources.GetObject("salesInTexasTile.BackgroundImage"), System.Drawing.Image)
            TileItemElement4.ImageBorderColor = System.Drawing.Color.Empty
            TileItemElement4.Text = "Sales in Texas"
            TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
            Me.salesInTexasTile.Elements.Add(TileItemElement4)
            Me.tileContainer.SetID(Me.salesInTexasTile, 36)
            Me.salesInTexasTile.Name = "salesInTexasTile"
            '
            'salesInTexas
            '
            Me.salesInTexas.Caption = "Sales in Texas"
            Me.salesInTexas.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document() {Me.ucProductsGridDocument, Me.ucCategorySalesDocument, Me.ucChartProductItemDocument})
            Me.salesInTexas.Name = "salesInTexas"
            Me.salesInTexas.Parent = Me.tileContainer
            '
            'ucDocumentManagerWindowsUISearchPanel
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "ucDocumentManagerWindowsUISearchPanel"
            Me.Size = New System.Drawing.Size(806, 448)
            CType(Me.documentManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.windowsUIView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tileContainer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.salesByStateTile, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.salesByState, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ucChoroplethMapItemDocument, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ucProductsGridDocument, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ucCategorySalesDocument, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ucChartProductItemDocument, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.salesInCaliforniaTile, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.salesInCalifornia, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.salesInMontanaTile, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.salesInMontana, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.salesInTexasTile, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.salesInTexas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region
        Private documentManager As XtraBars.Docking2010.DocumentManager
        Private windowsUIView As XtraBars.Docking2010.Views.WindowsUI.WindowsUIView
        Private tileContainer As XtraBars.Docking2010.Views.WindowsUI.TileContainer
        Private salesByStateTile As XtraBars.Docking2010.Views.WindowsUI.Tile
        Private ucChartProductItemDocument As XtraBars.Docking2010.Views.WindowsUI.Document
        Private salesInCaliforniaTile As XtraBars.Docking2010.Views.WindowsUI.Tile
        Private ucCategorySalesDocument As XtraBars.Docking2010.Views.WindowsUI.Document
        Private salesInMontanaTile As XtraBars.Docking2010.Views.WindowsUI.Tile
        Private ucChoroplethMapItemDocument As XtraBars.Docking2010.Views.WindowsUI.Document
        Private salesInTexasTile As XtraBars.Docking2010.Views.WindowsUI.Tile
        Private ucProductsGridDocument As XtraBars.Docking2010.Views.WindowsUI.Document
        Private salesByState As XtraBars.Docking2010.Views.WindowsUI.PageGroup
        Private salesInCalifornia As XtraBars.Docking2010.Views.WindowsUI.PageGroup
        Private salesInMontana As XtraBars.Docking2010.Views.WindowsUI.PageGroup
        Private salesInTexas As XtraBars.Docking2010.Views.WindowsUI.PageGroup
    End Class
End Namespace
