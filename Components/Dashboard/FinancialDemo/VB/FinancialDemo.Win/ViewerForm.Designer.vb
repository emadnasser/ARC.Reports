Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.DataAccess
Namespace FinanceDashboardDemo
	Partial Public Class ViewerForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ViewerForm))
			Me.dashboardViewer = New DevExpress.DashboardWin.DashboardViewer(Me.components)
			Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barTools = New DevExpress.XtraBars.Bar()
			Me.barItemExport = New DevExpress.XtraBars.BarLargeButtonItem()
			Me.popupMenuExport = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.barItemPrint = New DevExpress.XtraBars.BarButtonItem()
			Me.barItemExportToPdf = New DevExpress.XtraBars.BarButtonItem()
			Me.barItemExportToImage = New DevExpress.XtraBars.BarButtonItem()
			Me.barItemRefresh = New DevExpress.XtraBars.BarLargeButtonItem()
			Me.barItemParameters = New DevExpress.XtraBars.BarLargeButtonItem()
			Me.barItemSkin = New DevExpress.XtraBars.BarLargeButtonItem()
			Me.gallerySkins = New DevExpress.XtraBars.Ribbon.GalleryDropDown(Me.components)
			Me.standaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.dashboardViewer, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenuExport, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gallerySkins, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' dashboardViewer
			' 
			Me.dashboardViewer.AllowPrintDashboardItems = True
			Me.dashboardViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dashboardViewer.Location = New System.Drawing.Point(0, 42)
			Me.dashboardViewer.Margin = New System.Windows.Forms.Padding(10)
			Me.dashboardViewer.Name = "dashboardViewer"
			Me.dashboardViewer.Padding = New System.Windows.Forms.Padding(5)
			Me.dashboardViewer.Size = New System.Drawing.Size(1173, 744)
			Me.dashboardViewer.TabIndex = 3
			' 
			' barManager
			' 
			Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.barTools})
			Me.barManager.DockControls.Add(Me.barDockControlTop)
			Me.barManager.DockControls.Add(Me.barDockControlBottom)
			Me.barManager.DockControls.Add(Me.barDockControlLeft)
			Me.barManager.DockControls.Add(Me.barDockControlRight)
			Me.barManager.DockControls.Add(Me.standaloneBarDockControl1)
			Me.barManager.Form = Me
			Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barItemExport, Me.barItemRefresh, Me.barItemExportToPdf, Me.barItemExportToImage, Me.barItemPrint, Me.barItemSkin, Me.barItemParameters})
			Me.barManager.MaxItemId = 13
			' 
			' barTools
			' 
			Me.barTools.BarName = "Tools"
			Me.barTools.DockCol = 0
			Me.barTools.DockRow = 0
			Me.barTools.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
			Me.barTools.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barItemExport), New DevExpress.XtraBars.LinkPersistInfo(Me.barItemRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.barItemSkin), New DevExpress.XtraBars.LinkPersistInfo(Me.barItemParameters)})
			Me.barTools.OptionsBar.DrawBorder = False
			Me.barTools.OptionsBar.DrawDragBorder = False
			Me.barTools.OptionsBar.UseWholeRow = True
			Me.barTools.StandaloneBarDockControl = Me.standaloneBarDockControl1
			Me.barTools.Text = "Tools"
			' 
			' barItemExport
			' 
			Me.barItemExport.ActAsDropDown = True
			Me.barItemExport.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
			Me.barItemExport.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.barItemExport.Caption = "Export"
			Me.barItemExport.DropDownControl = Me.popupMenuExport
			Me.barItemExport.Glyph = (CType(resources.GetObject("barItemExport.Glyph"), System.Drawing.Image))
			Me.barItemExport.Id = 7
			Me.barItemExport.Name = "barItemExport"
			' 
			' popupMenuExport
			' 
			Me.popupMenuExport.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barItemPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.barItemExportToPdf), New DevExpress.XtraBars.LinkPersistInfo(Me.barItemExportToImage)})
			Me.popupMenuExport.Manager = Me.barManager
			Me.popupMenuExport.Name = "popupMenuExport"
			' 
			' barItemPrint
			' 
			Me.barItemPrint.Caption = "Print Preview..."
			Me.barItemPrint.Id = 11
			Me.barItemPrint.Name = "barItemPrint"
'			Me.barItemPrint.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barItemPrint_ItemClick);
			' 
			' barItemExportToPdf
			' 
			Me.barItemExportToPdf.Caption = "Export to PDF"
			Me.barItemExportToPdf.Id = 9
			Me.barItemExportToPdf.Name = "barItemExportToPdf"
'			Me.barItemExportToPdf.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barItemExportToPdf_ItemClick);
			' 
			' barItemExportToImage
			' 
			Me.barItemExportToImage.Caption = "Export to Image"
			Me.barItemExportToImage.Id = 10
			Me.barItemExportToImage.Name = "barItemExportToImage"
'			Me.barItemExportToImage.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barItemExportToImage_ItemClick);
			' 
			' barItemRefresh
			' 
			Me.barItemRefresh.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
			Me.barItemRefresh.Caption = "Refresh Dashboard"
			Me.barItemRefresh.Glyph = (CType(resources.GetObject("barItemRefresh.Glyph"), System.Drawing.Image))
			Me.barItemRefresh.Id = 8
			Me.barItemRefresh.Name = "barItemRefresh"
'			Me.barItemRefresh.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barItemRefresh_ItemClick);
			' 
			' barItemParameters
			' 
			Me.barItemParameters.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.barItemParameters.Caption = "Parameters ..."
			Me.barItemParameters.CausesValidation = True
			Me.barItemParameters.Glyph = My.Resources.Parameters_32x32
			Me.barItemParameters.Id = 13
			Me.barItemParameters.Name = "barItemParameters"
'			Me.barItemParameters.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barItemParameters_ItemClick);
			' 
			' barItemSkin
			' 
			Me.barItemSkin.ActAsDropDown = True
			Me.barItemSkin.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.barItemSkin.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.barItemSkin.Caption = "Change Skin"
			Me.barItemSkin.CausesValidation = True
			Me.barItemSkin.DropDownControl = Me.gallerySkins
			Me.barItemSkin.Glyph = My.Resources.Appearance_32x32
			Me.barItemSkin.Id = 12
			Me.barItemSkin.Name = "barItemSkin"
			' 
			' gallerySkins
			' 
			Me.gallerySkins.Manager = Nothing
			Me.gallerySkins.Name = "gallerySkins"
			' 
			' standaloneBarDockControl1
			' 
			Me.standaloneBarDockControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.standaloneBarDockControl1.Appearance.Options.UseBackColor = True
			Me.standaloneBarDockControl1.CausesValidation = False
			Me.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.standaloneBarDockControl1.Location = New System.Drawing.Point(0, 0)
			Me.standaloneBarDockControl1.Name = "standaloneBarDockControl1"
			Me.standaloneBarDockControl1.Size = New System.Drawing.Size(1173, 42)
			Me.standaloneBarDockControl1.Text = "standaloneBarDockControl1"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(1173, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 786)
			Me.barDockControlBottom.Size = New System.Drawing.Size(1173, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 786)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(1173, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 786)
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.standaloneBarDockControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(1173, 42)
			Me.panelControl1.TabIndex = 8
			' 
			' ViewerForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1173, 786)
			Me.Controls.Add(Me.dashboardViewer)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MinimumSize = New System.Drawing.Size(816, 680)
			Me.Name = "ViewerForm"
			Me.Text = "Financial Dashboard Demo"
'			Me.Load += New System.EventHandler(Me.FinanceDashboardDemo_Load);
			CType(Me.dashboardViewer, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenuExport, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gallerySkins, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dashboardViewer As DevExpress.DashboardWin.DashboardViewer
		Private barManager As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barTools As DevExpress.XtraBars.Bar
		Private barItemExport As DevExpress.XtraBars.BarLargeButtonItem
		Private WithEvents barItemRefresh As DevExpress.XtraBars.BarLargeButtonItem
		Private standaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private popupMenuExport As DevExpress.XtraBars.PopupMenu
		Private WithEvents barItemExportToPdf As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barItemExportToImage As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barItemPrint As DevExpress.XtraBars.BarButtonItem
		Private barItemSkin As DevExpress.XtraBars.BarLargeButtonItem
		Private WithEvents barItemParameters As DevExpress.XtraBars.BarLargeButtonItem
		Private gallerySkins As DevExpress.XtraBars.Ribbon.GalleryDropDown
	End Class
End Namespace

