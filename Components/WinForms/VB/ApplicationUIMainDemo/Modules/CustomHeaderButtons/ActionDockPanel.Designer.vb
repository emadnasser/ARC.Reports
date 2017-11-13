Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ActionDockPanel
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActionDockPanel))
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.sbClear = New DevExpress.XtraEditors.SimpleButton()
			Me.meActions = New DevExpress.XtraEditors.MemoEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dockPanel1.SuspendLayout()
			Me.dockPanel2_Container.SuspendLayout()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.meActions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 26)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(317, 279)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' dockManager1
			' 
			Me.dockManager1.Form = Me
			Me.dockManager1.MenuManager = Me.barManager1
			Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.dockPanel1})
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.DockManager = Me.dockManager1
			Me.barManager1.Form = Me
			Me.barManager1.MaxItemId = 0
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(426, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 308)
			Me.barDockControlBottom.Size = New System.Drawing.Size(426, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 308)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(426, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 308)
			' 
			' dockPanel1
			' 
			Me.dockPanel1.Controls.Add(Me.dockPanel2_Container)
			Me.dockPanel1.CustomHeaderButtons.AddRange(New DevExpress.XtraBars.Docking2010.IButton() { New DevExpress.XtraBars.Docking.CustomHeaderButton()})
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
			Me.dockPanel1.FloatVertical = True
			Me.dockPanel1.Footer = Nothing
			Me.dockPanel1.Header = Nothing
			Me.dockPanel1.ID = New System.Guid("a7569c21-f90c-4980-b810-fc215fd1be35")
			Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.Options.ShowCloseButton = False
			Me.dockPanel1.OriginalSize = New System.Drawing.Size(318, 200)
			Me.dockPanel1.Size = New System.Drawing.Size(318, 308)
			Me.dockPanel1.Text = "Toolbox"
'			Me.dockPanel1.CustomButtonClick += New DevExpress.XtraBars.Docking2010.ButtonEventHandler(Me.CustomHeaderButtonClick);
'			Me.dockPanel1.CustomButtonUnchecked += New DevExpress.XtraBars.Docking2010.ButtonEventHandler(Me.CustomHeaderButtonUnchecked);
'			Me.dockPanel1.CustomButtonChecked += New DevExpress.XtraBars.Docking2010.ButtonEventHandler(Me.CustomHeaderButtonChecked);
			' 
			' dockPanel2_Container
			' 
			Me.dockPanel2_Container.Controls.Add(Me.layoutControl1)
			Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 40)
			Me.dockPanel2_Container.Name = "dockPanel2_Container"
			Me.dockPanel2_Container.Size = New System.Drawing.Size(310, 264)
			Me.dockPanel2_Container.TabIndex = 0
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.sbClear)
			Me.layoutControl1.Controls.Add(Me.meActions)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(665, 259, 450, 350)
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(310, 264)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' sbClear
			' 
			Me.sbClear.Location = New System.Drawing.Point(231, 230)
			Me.sbClear.Name = "sbClear"
			Me.sbClear.Size = New System.Drawing.Size(67, 22)
			Me.sbClear.StyleController = Me.layoutControl1
			Me.sbClear.TabIndex = 5
			Me.sbClear.Text = "Clear"
'			Me.sbClear.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' meActions
			' 
			Me.meActions.EditValue = ""
			Me.meActions.Location = New System.Drawing.Point(12, 28)
			Me.meActions.Name = "meActions"
			Me.meActions.Size = New System.Drawing.Size(286, 198)
			Me.meActions.StyleController = Me.layoutControl1
			Me.meActions.TabIndex = 4
			Me.meActions.UseOptimizedRendering = True
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.emptySpaceItem1})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(310, 264)
			Me.layoutControlGroup1.Text = "Root"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.meActions
			Me.layoutControlItem1.CustomizationFormText = "Actions:"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(290, 218)
			Me.layoutControlItem1.Text = "Actions:"
			Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(39, 13)
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.sbClear
			Me.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(219, 218)
			Me.layoutControlItem2.MaxSize = New System.Drawing.Size(71, 26)
			Me.layoutControlItem2.MinSize = New System.Drawing.Size(71, 26)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(71, 26)
			Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 218)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(219, 26)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "Backward_16x16.png")
			Me.imageList1.Images.SetKeyName(1, "Previous_16x16.png")
			Me.imageList1.Images.SetKeyName(2, "Apply_16x16.png")
			Me.imageList1.Images.SetKeyName(3, "Unmark_16x16.png")
			Me.imageList1.Images.SetKeyName(4, "Forward_16x16.png")
			' 
			' ActionDockPanel
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.dockPanel1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "ActionDockPanel"
			Me.Size = New System.Drawing.Size(426, 308)
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dockPanel1.ResumeLayout(False)
			Me.dockPanel2_Container.ResumeLayout(False)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.meActions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
		Private WithEvents dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private imageList1 As System.Windows.Forms.ImageList
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private WithEvents sbClear As DevExpress.XtraEditors.SimpleButton
		Private meActions As DevExpress.XtraEditors.MemoEdit
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barManager1 As DevExpress.XtraBars.BarManager

	End Class
End Namespace
