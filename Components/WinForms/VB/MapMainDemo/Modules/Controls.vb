Imports Microsoft.VisualBasic
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Windows.Forms

Namespace DevExpress.XtraMap.Demos
	Public Class MapTutorialControl
		Inherits TutorialControlBase
		Implements IDXMenuManager
		#Region "static"

		Public Shared Function GetSaveFileName(ByVal defaulName As String) As String
			Return GetSaveFileName("Xlsx files(*.xlsx)|*.xlsx|All files (*.*)|*.*", defaulName)
		End Function
		Public Shared Function GetSaveFileName(ByVal filter As String, ByVal defaulName As String) As String
			Dim sfDialog As New SaveFileDialog()
			sfDialog.Filter = filter
			sfDialog.FileName = defaulName
			If sfDialog.ShowDialog() <> DialogResult.OK Then
				Return Nothing
			End If
			Return sfDialog.FileName
		End Function
		Public Shared Sub ShowFile(ByVal fileName As String, ByVal control As TutorialControlBase)
			If (Not File.Exists(fileName)) Then
				Return
			End If
			Dim dResult As DialogResult = XtraMessageBox.Show(control.LookAndFeel, control, String.Format("Do you want to open the resulting file: {0} ?", fileName), control.TutorialName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If dResult = DialogResult.Yes Then
				Process.Start(fileName)
			End If
		End Sub
		#End Region
		#Region "fields"
		Private menu As LookAndFeelMenu = Nothing
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private WithEvents chkShowNavPanel As BarCheckItem
		Private WithEvents chkNavigation As BarCheckItem
		Private WithEvents chkMiniMap As BarCheckItem
		Private WithEvents bbiZoomIn As BarButtonItem
		Private WithEvents bbiZoomOut As BarButtonItem
		Private WithEvents bbiInitialView As BarButtonItem
		Private rpOptions As XtraBars.Ribbon.RibbonPage
		Private rpgView As XtraBars.Ribbon.RibbonPageGroup
		Private fMenuManager As IDXMenuManager
		#End Region

		Public Sub New()
			InitializeComponent()
			AutoMergeRibbon = True
		End Sub

		#Region "properties"
		Protected Overridable ReadOnly Property Overlays() As MapOverlay()
			Get
				Return New MapOverlay(){}
			End Get
		End Property
		Protected ReadOnly Property ChkShowNavigationPanel() As BarCheckItem
			Get
				Return chkShowNavPanel
			End Get
		End Property
		Protected ReadOnly Property ChkShowMinimap() As BarCheckItem
			Get
				Return chkMiniMap
			End Get
		End Property
		Protected ReadOnly Property ChkLockNavigation() As BarCheckItem
			Get
				Return chkNavigation
			End Get
		End Property
		Protected ReadOnly Property OptionsPage() As RibbonPage
			Get
				Return rpOptions
			End Get
		End Property
		Protected Overridable ReadOnly Property MiniMapBingKind() As BingMapKind
			Get
				Return BingMapKind.Area
			End Get
		End Property
		Protected Overridable ReadOnly Property MiniMapAlignment() As MiniMapAlignment
			Get
				Return MiniMapAlignment.BottomLeft
			End Get
		End Property
		Public Overridable ReadOnly Property MapControl() As MapControl
			Get
				Return Nothing
			End Get
		End Property

		Public Property DemoMainMenu() As LookAndFeelMenu
			Get
				Return menu
			End Get
			Set(ByVal value As LookAndFeelMenu)
				If menu Is value Then
					Return
				End If
				Me.menu = value
			End Set
		End Property
		Public Property MenuManager() As IDXMenuManager
			Get
				Return fMenuManager
			End Get
			Set(ByVal value As IDXMenuManager)
				fMenuManager = value
			End Set
		End Property
		Public Overridable ReadOnly Property ShowOptions() As Boolean
			Get
				Return False
			End Get
		End Property
		#End Region
		#Region "initialize"
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MapTutorialControl))
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.chkMiniMap = New DevExpress.XtraBars.BarCheckItem()
			Me.chkShowNavPanel = New DevExpress.XtraBars.BarCheckItem()
			Me.chkNavigation = New DevExpress.XtraBars.BarCheckItem()
			Me.bbiZoomIn = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiZoomOut = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiInitialView = New DevExpress.XtraBars.BarButtonItem()
			Me.rpOptions = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgView = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.chkMiniMap, Me.chkShowNavPanel, Me.chkNavigation, Me.bbiZoomIn, Me.bbiZoomOut, Me.bbiInitialView})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 7
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.rpOptions})
			Me.ribbonControl1.Size = New System.Drawing.Size(500, 141)
			' 
			' chkShowMiniMap
			' 
			Me.chkMiniMap.Caption = "Show Minimap"
			Me.chkMiniMap.Glyph = (CType(resources.GetObject("chkShowMiniMap.Glyph"), System.Drawing.Image))
			Me.chkMiniMap.Id = 1
			Me.chkMiniMap.LargeGlyph = (CType(resources.GetObject("chkShowMiniMap.LargeGlyph"), System.Drawing.Image))
			Me.chkMiniMap.Name = "chkShowMiniMap"
'			Me.chkMiniMap.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.chkShowMiniMap_CheckedChanged);
			' 
			' chkShowNavPanel
			' 
			Me.chkShowNavPanel.BindableChecked = True
			Me.chkShowNavPanel.Caption = "Show Navigation Panel"
			Me.chkShowNavPanel.Checked = True
			Me.chkShowNavPanel.Glyph = (CType(resources.GetObject("chkShowNavPanel.Glyph"), System.Drawing.Image))
			Me.chkShowNavPanel.Id = 2
			Me.chkShowNavPanel.LargeGlyph = (CType(resources.GetObject("chkShowNavPanel.LargeGlyph"), System.Drawing.Image))
			Me.chkShowNavPanel.Name = "chkShowNavPanel"
'			Me.chkShowNavPanel.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.chkShowNavPanel_CheckedChanged);
			' 
			' chkLockNavigation
			' 
			Me.chkNavigation.Caption = "Lock Navigation"
			Me.chkNavigation.Glyph = (CType(resources.GetObject("chkLockNavigation.Glyph"), System.Drawing.Image))
			Me.chkNavigation.Id = 3
			Me.chkNavigation.LargeGlyph = (CType(resources.GetObject("chkLockNavigation.LargeGlyph"), System.Drawing.Image))
			Me.chkNavigation.Name = "chkLockNavigation"
'			Me.chkNavigation.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.chkLockNavigation_CheckedChanged);
			'this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
			' 
			' bbiZoomIn
			' 
			Me.bbiZoomIn.Caption = "Zoom In"
			Me.bbiZoomIn.Glyph = (CType(resources.GetObject("bbiZoomIn.Glyph"), System.Drawing.Image))
			Me.bbiZoomIn.Id = 4
			Me.bbiZoomIn.LargeGlyph = (CType(resources.GetObject("bbiZoomIn.LargeGlyph"), System.Drawing.Image))
			Me.bbiZoomIn.Name = "bbiZoomIn"
'			Me.bbiZoomIn.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiZoomIn_ItemClick);
			' 
			' bbiZoomOut
			' 
			Me.bbiZoomOut.Caption = "Zoom Out"
			Me.bbiZoomOut.Glyph = (CType(resources.GetObject("bbiZoomOut.Glyph"), System.Drawing.Image))
			Me.bbiZoomOut.Id = 5
			Me.bbiZoomOut.LargeGlyph = (CType(resources.GetObject("bbiZoomOut.LargeGlyph"), System.Drawing.Image))
			Me.bbiZoomOut.Name = "bbiZoomOut"
'			Me.bbiZoomOut.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiZoomOut_ItemClick);
			' 
			' bbiInitialView
			' 
			Me.bbiInitialView.Caption = "Initial View"
			Me.bbiInitialView.Glyph = (CType(resources.GetObject("bbiInitialView.Glyph"), System.Drawing.Image))
			Me.bbiInitialView.Id = 6
			Me.bbiInitialView.LargeGlyph = (CType(resources.GetObject("bbiInitialView.LargeGlyph"), System.Drawing.Image))
			Me.bbiInitialView.Name = "bbiInitialView"
'			Me.bbiInitialView.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiInitialView_ItemClick);
			' 
			' ribbonPage1
			' 
			Me.rpOptions.Name = "ribbonPage1"
			Me.rpOptions.Text = "Options"
			' 
			' ribbonPageGroup1
			' 
			Me.rpgView.ItemLinks.Add(Me.chkShowNavPanel)
			Me.rpgView.ItemLinks.Add(Me.chkNavigation)
			Me.rpgView.ItemLinks.Add(Me.chkMiniMap)
			Me.rpgView.ItemLinks.Add(Me.bbiZoomIn)
			Me.rpgView.ItemLinks.Add(Me.bbiZoomOut)
			Me.rpgView.ItemLinks.Add(Me.bbiInitialView)
			Me.rpgView.Name = "ribbonPageGroup1"
			Me.rpgView.Text = "View"
			' 
			' MapTutorialControl
			' 
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "MapTutorialControl"
			Me.Size = New System.Drawing.Size(500, 500)
'			Me.Load += New System.EventHandler(Me.MapTutorialControl_Load);
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private Sub ShowPopupMenu(ByVal menu As DXPopupMenu, ByVal control As Control, ByVal pos As Point) Implements IDXMenuManager.ShowPopupMenu
			MenuManagerHelper.ShowMenu(menu, LookAndFeel, fMenuManager, control, pos)
		End Sub

		Private Function Clone(ByVal newForm As Form) As IDXMenuManager Implements IDXMenuManager.Clone
			Return Me
		End Function

		Private Sub DisposeManager() Implements IDXMenuManager.DisposeManager
		End Sub

		Private Sub InitializeMiniMap()
			Dim miniMap As New MiniMap()
			miniMap.Behavior = New DynamicMiniMapBehavior() With {.ZoomOffset = -5}
			miniMap.Layers.Add(CreateMiniMapLayer())
			miniMap.Alignment = MiniMapAlignment
			MapControl.MiniMap = miniMap
		End Sub

		Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
			Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
			If be IsNot Nothing Then
				be.MenuManager = manager
			End If
		End Sub
		Protected Overrides Sub AllowExport()
			EnabledPrintExportActions(True, True, ExportFormats.PDF Or ExportFormats.MHT Or ExportFormats.RTF Or ExportFormats.XLS Or ExportFormats.XLSX Or ExportFormats.Image, False)
		End Sub
		Protected Overrides Sub PrintPreview()
			If MapControl IsNot Nothing Then
				MapControl.ShowRibbonPrintPreview()
			End If
		End Sub
		Protected Overrides Sub Print()
			If MapControl IsNot Nothing Then
				MapControl.Print()
			End If
		End Sub
		Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
			Dim map As MapControl = MapControl
			If map IsNot Nothing Then
				Dim currentCursor As Cursor = Cursor.Current
				Cursor.Current = Cursors.WaitCursor
				If ext = "rtf" Then
					map.ExportToRtf(filename)
				ElseIf ext = "pdf" Then
					map.ExportToPdf(filename)
				ElseIf ext = "mht" Then
					map.ExportToMht(filename)
				ElseIf ext = "xls" Then
					map.ExportToXls(filename)
				ElseIf ext = "xlsx" Then
					map.ExportToXlsx(filename)
				End If
				Cursor.Current = currentCursor
			End If
		End Sub
		Public Overrides Overloads Function Equals(ByVal obj As Object) As Boolean
			If obj Is Nothing Then
				Return False
			End If
			Return Me.GetType().Equals(obj.GetType())
		End Function
		Public Overrides Function GetHashCode() As Integer
			Return Me.GetType().GetHashCode()
		End Function
		Protected Overrides Sub ExportToImage()
			If MapControl Is Nothing Then
				Return
			End If
			Dim fileName As String = MainFormHelper.GetFileName("", GetImageFormatsFilter())
			If (Not String.IsNullOrEmpty(fileName)) Then
				MapControl.ExportToImage(fileName, GetImageFormat(Path.GetExtension(fileName).TrimStart("."c).ToLower()))
			End If
		End Sub
		Protected Overridable Function CreateMiniMapLayer() As MiniMapLayerBase
			Dim miniMapImageTilesLayer As New MiniMapImageTilesLayer()
			Dim miniMapDataProvider As New BingMapDataProvider()
			miniMapDataProvider.Kind = MiniMapBingKind
			DemoUtils.SetBingMapDataProviderKey(miniMapDataProvider)
			miniMapImageTilesLayer.DataProvider = miniMapDataProvider
			Return miniMapImageTilesLayer
		End Function

		Private Function GetImageFormatsFilter() As String
			Dim result As String = String.Empty
			Dim codecInfos() As ImageCodecInfo = ImageCodecInfo.GetImageEncoders()
			For i As Integer = 0 To codecInfos.Length - 1
				Dim extension As String = codecInfos(i).FormatDescription
				result &= String.Format("{0} Image (*.{1})|*.{1}|", extension.ToUpper(), extension.ToLower())
			Next i
			Return result.TrimEnd("|"c)
		End Function
		Private Function GetImageFormat(ByVal extension As String) As ImageFormat
			Dim codecInfo As ImageCodecInfo = ImageCodecInfo.GetImageEncoders().First(Function(info) info.FormatDescription.ToLower() = extension)
			For Each imageFormatInfo As PropertyInfo In GetType(ImageFormat).GetProperties().Where(Function(info) info.PropertyType.Equals(GetType(ImageFormat)))
				Dim format As ImageFormat = CType(imageFormatInfo.GetValue(Nothing, Nothing), ImageFormat)
				If format.Guid.Equals(codecInfo.FormatID) Then
					Return format
				End If
			Next imageFormatInfo
			Return Nothing
		End Function
		Private Sub chkShowMiniMap_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles chkMiniMap.CheckedChanged
			If MapControl.MiniMap Is Nothing Then
				InitializeMiniMap()
			End If
			MapControl.MiniMap.Visible = (CType(e.Item, BarCheckItem)).Checked
		End Sub
		Private Sub chkShowNavPanel_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles chkShowNavPanel.CheckedChanged
			If MapControl IsNot Nothing Then
				MapControl.NavigationPanelOptions.Visible = (CType(e.Item, BarCheckItem)).Checked
			End If
		End Sub
		Private Sub chkLockNavigation_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles chkNavigation.CheckedChanged
			ChangeEnableNavigation(Not(CType(e.Item, BarCheckItem)).Checked)
		End Sub
		Private Sub bbiZoomIn_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiZoomIn.ItemClick
			MapControl.ZoomIn()
		End Sub
		Private Sub bbiZoomOut_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiZoomOut.ItemClick
			MapControl.ZoomOut()
		End Sub
		Private Sub bbiInitialView_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiInitialView.ItemClick
			RestoreInitialView()
		End Sub
		Protected Overridable Sub RestoreInitialView()
		End Sub
		Protected Overridable Sub ChangeEnableNavigation(ByVal enable As Boolean)
			MapControl.EnableScrolling = enable
			MapControl.EnableZooming = enable
			bbiZoomIn.Enabled = enable
			bbiZoomOut.Enabled = enable
		End Sub
		Protected Overridable Sub InitRibbon()
			rpOptions.Groups.Add(rpgView)
			chkMiniMap.Checked = MapControl IsNot Nothing AndAlso MapControl.MiniMap IsNot Nothing AndAlso MapControl.MiniMap.Visible
			chkShowNavPanel.Checked = MapControl IsNot Nothing AndAlso MapControl.NavigationPanelOptions IsNot Nothing AndAlso MapControl.NavigationPanelOptions.Visible
		End Sub
		Protected Sub DisableZoomOptions()
			bbiZoomIn.Enabled = False
			bbiZoomOut.Enabled = False
		End Sub
		Protected Overrides Sub ExportToPDF()
			ExportTo("pdf", "PDF document (*.pdf)|*.pdf")
		End Sub
		Protected Overrides Sub ExportToHTML()
			ExportTo("html", "HTML document (*.html)|*.html")
		End Sub
		Protected Overrides Sub ExportToMHT()
			ExportTo("mht", "MHT document (*.mht)|*.mht")
		End Sub
		Protected Overrides Sub ExportToXLS()
			ExportTo("xls", "XLS document (*.xls)|*.xls")
		End Sub
		Protected Overrides Sub ExportToXLSX()
			ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx")
		End Sub
		Protected Overrides Sub ExportToRTF()
			ExportTo("rtf", "RTF document (*.rtf)|*.rtf")
		End Sub
		Protected Overrides Sub ExportToText()
			ExportTo("txt", "Text document (*.txt)|*.txt")
		End Sub
		Public Sub AppendOverlays()
			If MapControl Is Nothing Then
				Return
			End If
			MapControl.Overlays.Clear()
			MapControl.Overlays.AddRange(Overlays)
		End Sub

		Private Sub MapTutorialControl_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitRibbon()
		End Sub
	End Class

	Public NotInheritable Class MapModulesPool
		Private Const MaxModulesCount As Integer = 5

		Private Shared modules As New List(Of MapTutorialControl)(MaxModulesCount)

		Private Sub New()
		End Sub
		Private Shared Sub UnregisterModule(ByVal [module] As MapTutorialControl)
			If (Not modules.Contains([module])) Then
				Return
			End If
			Dim moduleInfo As ModuleInfo = ModulesInfo.GetItem([module].TutorialName)
			moduleInfo.ResetModule()
			If (Not [module].IsDisposed) Then
				[module].Dispose()
			End If
			modules.Remove([module])
		End Sub
		Public Shared Sub RegisterModule(ByVal [module] As MapTutorialControl)
			If modules.Contains([module]) Then
				modules.Remove([module])
				modules.Add([module])
				Return
			End If
			If modules.Count = MaxModulesCount Then
				UnregisterModule(modules(0))
			End If
			modules.Add([module])
		End Sub
		Public Shared Function GetPreviousModule() As MapTutorialControl
			Return If(modules.Count > 0, modules(modules.Count - 1), Nothing)
		End Function
	End Class
End Namespace
