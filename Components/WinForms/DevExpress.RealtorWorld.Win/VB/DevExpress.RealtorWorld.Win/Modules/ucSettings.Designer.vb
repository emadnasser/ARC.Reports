Imports Microsoft.VisualBasic
Imports System
	Namespace DevExpress.RealtorWorld.Win
	Partial Public Class ucSettings
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ucSettings))
			Me.animationButtonPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
			Me.xtraUserControl2 = New DevExpress.XtraEditors.XtraUserControl()
			Me.windowsUIView1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(Me.components)
			Me.pageGroup1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(Me.components)
			Me.document1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
			Me.document2 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
			Me.noDocumentsView1 = New DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(Me.components)
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.barDockingMenuItem1 = New DevExpress.XtraBars.BarDockingMenuItem()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pageGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel1.SuspendLayout()
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl3.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' animationButtonPanel
			' 
			Me.animationButtonPanel.AllowHtmlDraw = True
			Me.animationButtonPanel.AppearanceButton.Hovered.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.animationButtonPanel.AppearanceButton.Hovered.Options.UseFont = True
			Me.animationButtonPanel.AppearanceButton.Hovered.Options.UseTextOptions = True
			Me.animationButtonPanel.AppearanceButton.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.animationButtonPanel.AppearanceButton.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.animationButtonPanel.AppearanceButton.Normal.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.animationButtonPanel.AppearanceButton.Normal.Options.UseFont = True
			Me.animationButtonPanel.AppearanceButton.Normal.Options.UseTextOptions = True
			Me.animationButtonPanel.AppearanceButton.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.animationButtonPanel.AppearanceButton.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.animationButtonPanel.AppearanceButton.Pressed.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.animationButtonPanel.AppearanceButton.Pressed.Options.UseFont = True
			Me.animationButtonPanel.AppearanceButton.Pressed.Options.UseTextOptions = True
			Me.animationButtonPanel.AppearanceButton.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.animationButtonPanel.AppearanceButton.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.animationButtonPanel.ButtonBackgroundImages = Me.imageList2
			Me.animationButtonPanel.ButtonInterval = 48
			Me.animationButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() { New DevExpress.XtraBars.Docking2010.WindowsUIButton("Horizontal<br>Slide", Nothing, 1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", True, -1, True, Nothing, True, False, True, Nothing, DevExpress.XtraBars.Docking2010.Customization.TransitionAnimation.HorizontalSlide, 0, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Vertical<br>Slide", Nothing, 5, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", True, -1, True, Nothing, True, False, True, Nothing, DevExpress.XtraBars.Docking2010.Customization.TransitionAnimation.VerticalSlide, 0, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("FadeIn<br>Animation", Nothing, 0, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", True, -1, True, Nothing, True, False, True, Nothing, DevExpress.XtraBars.Docking2010.Customization.TransitionAnimation.FadeIn, 0, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton(" Segment<br>Fade", Nothing, 4, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", True, -1, True, Nothing, True, False, True, Nothing, DevExpress.XtraBars.Docking2010.Customization.TransitionAnimation.SegmentedFade, 0, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton(" Random<br>Fade", Nothing, 3, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", True, -1, True, Nothing, True, False, True, Nothing, DevExpress.XtraBars.Docking2010.Customization.TransitionAnimation.RandomSegmentedFade, 0, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("No<br>Animation", Nothing, 2, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", True, -1, True, Nothing, True, False, True, Nothing, DevExpress.XtraBars.Docking2010.Customization.TransitionAnimation.None, 0, False, False)})
			Me.animationButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.animationButtonPanel.Images = Me.imageList1
			Me.animationButtonPanel.Location = New System.Drawing.Point(0, 0)
			Me.animationButtonPanel.Name = "animationButtonPanel"
			Me.animationButtonPanel.Size = New System.Drawing.Size(1240, 294)
			Me.animationButtonPanel.TabIndex = 0
			Me.animationButtonPanel.Text = "animationButtonPanel"
			Me.animationButtonPanel.WrapButtons = True
'			Me.animationButtonPanel.ButtonChecked += New DevExpress.XtraBars.Docking2010.ButtonEventHandler(Me.animationButtonChecked);
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList2.Images.SetKeyName(0, "Circle_1.png")
			Me.imageList2.Images.SetKeyName(1, "Circle_2.png")
			Me.imageList2.Images.SetKeyName(2, "Circle_3.png")
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "FadeIn.png")
			Me.imageList1.Images.SetKeyName(1, "Horizontal.png")
			Me.imageList1.Images.SetKeyName(2, "None.png")
			Me.imageList1.Images.SetKeyName(3, "RSFade.png")
			Me.imageList1.Images.SetKeyName(4, "SFade.png")
			Me.imageList1.Images.SetKeyName(5, "Vertical.png")
			' 
			' documentManager1
			' 
			Me.documentManager1.ContainerControl = Me.xtraUserControl2
			Me.documentManager1.View = Me.windowsUIView1
			Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.windowsUIView1, Me.noDocumentsView1})
			' 
			' xtraUserControl2
			' 
			Me.xtraUserControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraUserControl2.Location = New System.Drawing.Point(0, 0)
			Me.xtraUserControl2.Name = "xtraUserControl2"
			Me.xtraUserControl2.Size = New System.Drawing.Size(1240, 239)
			Me.xtraUserControl2.TabIndex = 0
			' 
			' windowsUIView1
			' 
			Me.windowsUIView1.ContentContainers.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer() { Me.pageGroup1})
			Me.windowsUIView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() { Me.document1, Me.document2})
			Me.windowsUIView1.UseSplashScreen = DevExpress.Utils.DefaultBoolean.False
			' 
			' pageGroup1
			' 
			Me.pageGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document() { Me.document1, Me.document2})
			Me.pageGroup1.Name = "pageGroup1"
			' 
			' document1
			' 
			Me.document1.Caption = ""
			Me.document1.ControlName = "ucStats"
			Me.document1.ControlTypeName = "DevExpress.RealtorWorld.Win.ucStats"
			' 
			' document2
			' 
			Me.document2.Caption = ""
			Me.document2.ControlName = "ucResearch"
			Me.document2.ControlTypeName = "DevExpress.RealtorWorld.Win.ucResearch"
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barDockingMenuItem1})
			Me.barManager1.MaxItemId = 2
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(1757, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 545)
			Me.barDockControlBottom.Size = New System.Drawing.Size(1757, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 545)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(1757, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 545)
			' 
			' barDockingMenuItem1
			' 
			Me.barDockingMenuItem1.Caption = "Window"
			Me.barDockingMenuItem1.Id = 0
			Me.barDockingMenuItem1.Name = "barDockingMenuItem1"
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.AllowHotTrack = False
			Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem2"
			Me.emptySpaceItem3.Location = New System.Drawing.Point(718, 0)
			Me.emptySpaceItem3.Name = "emptySpaceItem2"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(203, 158)
			Me.emptySpaceItem3.Text = "emptySpaceItem2"
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 3
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.1844F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.92199F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F))
			Me.tableLayoutPanel1.Controls.Add(Me.panelControl3, 1, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.panelControl2, 1, 0)
			Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 2
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(1757, 545)
			Me.tableLayoutPanel1.TabIndex = 10
			' 
			' panelControl3
			' 
			Me.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl3.Controls.Add(Me.animationButtonPanel)
			Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl3.Location = New System.Drawing.Point(252, 248)
			Me.panelControl3.Name = "panelControl3"
			Me.panelControl3.Size = New System.Drawing.Size(1240, 294)
			Me.panelControl3.TabIndex = 1
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Controls.Add(Me.xtraUserControl2)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl2.Location = New System.Drawing.Point(252, 3)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(1240, 239)
			Me.panelControl2.TabIndex = 1
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 98)
			Me.emptySpaceItem2.Name = "emptySpaceItem1"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(374, 171)
			Me.emptySpaceItem2.Text = "emptySpaceItem1"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' ucSettings
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Margin = New System.Windows.Forms.Padding(0)
			Me.Name = "ucSettings"
			Me.Size = New System.Drawing.Size(1757, 545)
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pageGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel1.ResumeLayout(False)
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl3.ResumeLayout(False)
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents animationButtonPanel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
		Private imageList1 As System.Windows.Forms.ImageList
		Private imageList2 As System.Windows.Forms.ImageList
		Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
		Private windowsUIView1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView
		Private pageGroup1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private document1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private document2 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private barDockingMenuItem1 As DevExpress.XtraBars.BarDockingMenuItem
		Private noDocumentsView1 As DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView
		Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private panelControl3 As DevExpress.XtraEditors.PanelControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private xtraUserControl2 As DevExpress.XtraEditors.XtraUserControl
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
	End Class
	End Namespace
