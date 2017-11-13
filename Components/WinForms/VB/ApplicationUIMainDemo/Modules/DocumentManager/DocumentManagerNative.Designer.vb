Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class DocumentManagerNative
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentManagerNative))
			Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
			Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
			Me.nativeView = New DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView(Me.components)
			Me.noDocumentsView1 = New DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(Me.components)
			Me.biAddDocument = New DevExpress.XtraBars.BarButtonItem()
			Me.bsiSkin = New DevExpress.XtraBars.BarSubItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.barDockingMenuItem1 = New DevExpress.XtraBars.BarDockingMenuItem()
			CType(Me.documentManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nativeView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' documentManager
			' 
			Me.documentManager.BarAndDockingController = Me.barAndDockingController1
			Me.documentManager.ContainerControl = Me
			Me.documentManager.View = Me.nativeView
			Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.nativeView, Me.noDocumentsView1})
			' 
			' barAndDockingController1
			' 
			Me.barAndDockingController1.PropertiesBar.AllowLinkLighting = False
			Me.barAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
			Me.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
			' 
			' biAddDocument
			' 
			Me.biAddDocument.Caption = "Add New Document"
			Me.biAddDocument.Glyph = (CType(resources.GetObject("biAddDocument.Glyph"), System.Drawing.Image))
			Me.biAddDocument.Id = 0
			Me.biAddDocument.LargeGlyph = (CType(resources.GetObject("biAddDocument.LargeGlyph"), System.Drawing.Image))
			Me.biAddDocument.Name = "biAddDocument"
'			Me.biAddDocument.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.biAddDocumentClick);
			' 
			' bsiSkin
			' 
			Me.bsiSkin.Caption = "Skin"
			Me.bsiSkin.Id = 1
			Me.bsiSkin.Name = "bsiSkin"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.biAddDocument, Me.bsiSkin, Me.barDockingMenuItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 2
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.Size = New System.Drawing.Size(786, 142)
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "Native View Setttings"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.AllowTextClipping = False
			Me.ribbonPageGroup1.ItemLinks.Add(Me.biAddDocument, True)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.ShowCaptionButton = False
			' 
			' ribbonPageGroup2
			' 
			Me.ribbonPageGroup2.ItemLinks.Add(Me.barDockingMenuItem1)
			Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
			Me.ribbonPageGroup2.Text = "Layout"
			' 
			' barDockingMenuItem1
			' 
			Me.barDockingMenuItem1.Caption = "Manage Documents Layout"
			Me.barDockingMenuItem1.Id = 1
			Me.barDockingMenuItem1.Name = "barDockingMenuItem1"
			' 
			' DocumentManagerNative
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.ribbonControl1)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "DocumentManagerNative"
			Me.Size = New System.Drawing.Size(786, 448)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.documentManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nativeView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager
		Private nativeView As DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView

		Private components As System.ComponentModel.IContainer
		Private WithEvents biAddDocument As DevExpress.XtraBars.BarButtonItem
		Private barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
		Private bsiSkin As DevExpress.XtraBars.BarSubItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private noDocumentsView1 As XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
		Private barDockingMenuItem1 As XtraBars.BarDockingMenuItem
		Private ribbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
	End Class
End Namespace
