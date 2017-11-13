Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class DocumentManagerTabbedDocuments
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentManagerTabbedDocuments))
			Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
			Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
			Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
			Me.biAddDocument = New DevExpress.XtraBars.BarButtonItem()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.beiOrientation = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.bciColoredTabs = New DevExpress.XtraBars.BarCheckItem()
			Me.beiHeadeLocation = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.beiHeaderOrientation = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.beiClosePageButton = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemImageComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.beiShowPinTab = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemImageComboBox5 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.repositoryItemCheckedComboBoxEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.repositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.barDockingMenuItem1 = New DevExpress.XtraBars.BarDockingMenuItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.bciDockGuides = New DevExpress.XtraBars.BarCheckItem()
			CType(Me.documentManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' documentManager
			' 
			Me.documentManager.BarAndDockingController = Me.barAndDockingController1
			Me.documentManager.ContainerControl = Me
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
			' tabbedView
			' 
			Me.tabbedView.DocumentProperties.AllowPin = True
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
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.IsFloatValue = False
			Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			Me.repositoryItemSpinEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			' 
			' beiOrientation
			' 
			Me.beiOrientation.Caption = "Orientation"
			Me.beiOrientation.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.beiOrientation.Edit = Me.repositoryItemImageComboBox3
			Me.beiOrientation.Id = 3
			Me.beiOrientation.Name = "beiOrientation"
			Me.beiOrientation.Width = 100
'			Me.beiOrientation.EditValueChanged += New System.EventHandler(Me.viewOrientationChanged);
			' 
			' repositoryItemImageComboBox3
			' 
			Me.repositoryItemImageComboBox3.AutoHeight = False
			Me.repositoryItemImageComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
			' 
			' bciColoredTabs
			' 
			Me.bciColoredTabs.Caption = "Colored Tabs"
			Me.bciColoredTabs.Id = 4
			Me.bciColoredTabs.Name = "bciColoredTabs"
'			Me.bciColoredTabs.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.bciColoredTabs_CheckedChanged);
			' 
			' beiHeadeLocation
			' 
			Me.beiHeadeLocation.Caption = "Header Location"
			Me.beiHeadeLocation.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.beiHeadeLocation.Edit = Me.repositoryItemImageComboBox1
			Me.beiHeadeLocation.Id = 5
			Me.beiHeadeLocation.Name = "beiHeadeLocation"
			Me.beiHeadeLocation.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
			Me.beiHeadeLocation.Width = 110
'			Me.beiHeadeLocation.EditValueChanged += New System.EventHandler(Me.headerLocationChanged);
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			' 
			' beiHeaderOrientation
			' 
			Me.beiHeaderOrientation.Caption = "Header Orientation"
			Me.beiHeaderOrientation.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.beiHeaderOrientation.Edit = Me.repositoryItemImageComboBox2
			Me.beiHeaderOrientation.Id = 6
			Me.beiHeaderOrientation.Name = "beiHeaderOrientation"
			Me.beiHeaderOrientation.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
			Me.beiHeaderOrientation.Width = 110
'			Me.beiHeaderOrientation.EditValueChanged += New System.EventHandler(Me.headerOrientationChanged);
			' 
			' repositoryItemImageComboBox2
			' 
			Me.repositoryItemImageComboBox2.AutoHeight = False
			Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
			' 
			' beiClosePageButton
			' 
			Me.beiClosePageButton.Caption = "Show Close Button"
			Me.beiClosePageButton.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.beiClosePageButton.Edit = Me.repositoryItemImageComboBox4
			Me.beiClosePageButton.Id = 4
			Me.beiClosePageButton.Name = "beiClosePageButton"
			Me.beiClosePageButton.Width = 145
'			Me.beiClosePageButton.EditValueChanged += New System.EventHandler(Me.closePageButtonModeChanged);
			' 
			' repositoryItemImageComboBox4
			' 
			Me.repositoryItemImageComboBox4.AutoHeight = False
			Me.repositoryItemImageComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4"
			' 
			' beiShowPinTab
			' 
			Me.beiShowPinTab.Caption = "Show Pin Button"
			Me.beiShowPinTab.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.beiShowPinTab.Edit = Me.repositoryItemImageComboBox5
			Me.beiShowPinTab.Id = 5
			Me.beiShowPinTab.Name = "beiShowPinTab"
			Me.beiShowPinTab.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
			Me.beiShowPinTab.Width = 145
'			Me.beiShowPinTab.EditValueChanged += New System.EventHandler(Me.showPinTabChanged);
			' 
			' repositoryItemImageComboBox5
			' 
			Me.repositoryItemImageComboBox5.AutoHeight = False
			Me.repositoryItemImageComboBox5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox5.Name = "repositoryItemImageComboBox5"
			' 
			' repositoryItemCheckedComboBoxEdit1
			' 
			Me.repositoryItemCheckedComboBoxEdit1.AutoHeight = False
			Me.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1"
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Caption = "Check"
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' repositoryItemTextEdit2
			' 
			Me.repositoryItemTextEdit2.AutoHeight = False
			Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
			' 
			' repositoryItemSpinEdit2
			' 
			Me.repositoryItemSpinEdit2.AutoHeight = False
			Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
			' 
			' repositoryItemTextEdit3
			' 
			Me.repositoryItemTextEdit3.AutoHeight = False
			Me.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3"
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
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.bciColoredTabs, Me.biAddDocument, Me.beiHeadeLocation, Me.beiHeaderOrientation, Me.beiOrientation, Me.beiClosePageButton, Me.beiShowPinTab, Me.barDockingMenuItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 17
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1, Me.repositoryItemImageComboBox3, Me.repositoryItemImageComboBox4, Me.repositoryItemImageComboBox5, Me.repositoryItemCheckedComboBoxEdit1, Me.repositoryItemCheckEdit1, Me.repositoryItemTextEdit1, Me.repositoryItemTextEdit2, Me.repositoryItemSpinEdit2, Me.repositoryItemTextEdit3})
			Me.ribbonControl1.Size = New System.Drawing.Size(807, 142)
			' 
			' barDockingMenuItem1
			' 
			Me.barDockingMenuItem1.Caption = "Manage Documents Layout"
			Me.barDockingMenuItem1.Id = 13
			Me.barDockingMenuItem1.Name = "barDockingMenuItem1"
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3, Me.ribbonPageGroup4, Me.ribbonPageGroup5})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "Tabbed View Settings"
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
			Me.ribbonPageGroup2.ItemLinks.Add(Me.beiOrientation)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.barDockingMenuItem1)
			Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
			Me.ribbonPageGroup2.Text = "Layout"
			' 
			' ribbonPageGroup3
			' 
			Me.ribbonPageGroup3.ItemLinks.Add(Me.beiHeadeLocation, True)
			Me.ribbonPageGroup3.ItemLinks.Add(Me.beiHeaderOrientation)
			Me.ribbonPageGroup3.ItemLinks.Add(Me.beiClosePageButton, False, "", "", True)
			Me.ribbonPageGroup3.ItemLinks.Add(Me.beiShowPinTab, False, "", "", True)
			Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
			Me.ribbonPageGroup3.Text = "Tab Header Options"
			' 
			' ribbonPageGroup4
			' 
			Me.ribbonPageGroup4.AllowTextClipping = False
			Me.ribbonPageGroup4.ItemLinks.Add(Me.bciColoredTabs)
			Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
			Me.ribbonPageGroup4.Text = "Appearance"
			' 
			' ribbonPageGroup5
			' 
			Me.ribbonPageGroup5.AllowTextClipping = False
			Me.ribbonPageGroup5.ItemLinks.Add(Me.bciDockGuides)
			Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
			Me.ribbonPageGroup5.ShowCaptionButton = False
			Me.ribbonPageGroup5.Text = "Behavior"
			' 
			' bciDockGuides
			' 
			Me.bciDockGuides.Caption = "Show DockGuides On Pressing Shift"
			Me.bciDockGuides.Id = 10
			Me.bciDockGuides.Name = "bciDockGuides"
'			Me.bciDockGuides.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.bciDockGuides_CheckedChanged);
			' 
			' DocumentManagerTabbedDocuments
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.ribbonControl1)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "DocumentManagerTabbedDocuments"
			Me.Size = New System.Drawing.Size(807, 448)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.documentManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager
		Private tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

		Private WithEvents beiHeadeLocation As DevExpress.XtraBars.BarEditItem
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private WithEvents beiHeaderOrientation As DevExpress.XtraBars.BarEditItem
		Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private WithEvents beiOrientation As DevExpress.XtraBars.BarEditItem
		Private components As System.ComponentModel.IContainer
		Private WithEvents biAddDocument As DevExpress.XtraBars.BarButtonItem
		Private WithEvents bciColoredTabs As DevExpress.XtraBars.BarCheckItem
		Private barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
		Private WithEvents beiClosePageButton As DevExpress.XtraBars.BarEditItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents beiShowPinTab As DevExpress.XtraBars.BarEditItem
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private repositoryItemSpinEdit1 As XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemImageComboBox3 As XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox4 As XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox5 As XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemCheckedComboBoxEdit1 As XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
		Private repositoryItemCheckEdit1 As XtraEditors.Repository.RepositoryItemCheckEdit
		Private repositoryItemTextEdit1 As XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemTextEdit2 As XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemSpinEdit2 As XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemTextEdit3 As XtraEditors.Repository.RepositoryItemTextEdit
		Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup5 As XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents bciDockGuides As XtraBars.BarCheckItem
		Private barDockingMenuItem1 As XtraBars.BarDockingMenuItem
	End Class
End Namespace
