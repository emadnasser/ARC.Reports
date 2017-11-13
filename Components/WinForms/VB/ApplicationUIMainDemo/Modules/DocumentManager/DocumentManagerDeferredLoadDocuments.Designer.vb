Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class DocumentManagerDeferredLoadDocuments
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentManagerDeferredLoadDocuments))
			Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
			Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
			Me.documentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
			Me.document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.document2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.document3 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.document4 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.document5 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			CType(Me.documentManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.documentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' documentManager
			' 
			Me.documentManager.BarAndDockingController = Me.barAndDockingController1
			Me.documentManager.ContainerControl = Me
			Me.documentManager.Images = Me.imageList1
			Me.documentManager.MenuManager = Me.barManager1
			Me.documentManager.ShowToolTips = DevExpress.Utils.DefaultBoolean.True
			Me.documentManager.View = Me.tabbedView
			Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.tabbedView})
			' 
			' barAndDockingController1
			' 
			Me.barAndDockingController1.PropertiesBar.AllowLinkLighting = False
			Me.barAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
			Me.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
			' 
			' barManager1
			' 
			Me.barManager1.Controller = Me.barAndDockingController1
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.MaxItemId = 0
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(803, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 448)
			Me.barDockControlBottom.Size = New System.Drawing.Size(803, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 448)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(803, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 448)
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
			' tabbedView
			' 
			Me.tabbedView.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() { Me.documentGroup1})
			Me.tabbedView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() { Me.document1, Me.document2, Me.document3, Me.document4, Me.document5})
			' 
			' documentGroup1
			' 
			Me.documentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() { Me.document1, Me.document2, Me.document3, Me.document4, Me.document5})
			' 
			' document1
			' 
			Me.document1.Caption = "document0"
			Me.document1.ControlName = "document0"
			Me.document1.ImageIndex = 0
			' 
			' document2
			' 
			Me.document2.Caption = "document1"
			Me.document2.ControlName = "document1"
			Me.document2.ImageIndex = 1
			' 
			' document3
			' 
			Me.document3.Caption = "document2"
			Me.document3.ControlName = "document2"
			Me.document3.ImageIndex = 2
			' 
			' document4
			' 
			Me.document4.Caption = "document3"
			Me.document4.ControlName = "document3"
			Me.document4.ImageIndex = 3
			' 
			' document5
			' 
			Me.document5.Caption = "document4"
			Me.document5.ControlName = "document4"
			Me.document5.ImageIndex = 4
			' 
			' DocumentManagerDeferredLoadDocuments
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "DocumentManagerDeferredLoadDocuments"
			Me.Size = New System.Drawing.Size(803, 448)
			CType(Me.documentManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.documentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager
		Private tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
		Private components As System.ComponentModel.IContainer
		Private barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
		Private imageList1 As System.Windows.Forms.ImageList
		Private documentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
		Private document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document2 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document3 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document4 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document5 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barManager1 As DevExpress.XtraBars.BarManager
	End Class
End Namespace
