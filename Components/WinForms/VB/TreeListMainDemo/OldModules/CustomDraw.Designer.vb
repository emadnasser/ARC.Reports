Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class TreeListCustomDraw
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TreeListCustomDraw))
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.imglNodes = New System.Windows.Forms.ImageList(Me.components)
			Me.imglCustom = New System.Windows.Forms.ImageList(Me.components)
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
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
			Me.imageList1.Images.SetKeyName(6, "")
			Me.imageList1.Images.SetKeyName(7, "")
			' 
			' imglNodes
			' 
			Me.imglNodes.ImageStream = (CType(resources.GetObject("imglNodes.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imglNodes.TransparentColor = System.Drawing.Color.Magenta
			Me.imglNodes.Images.SetKeyName(0, "")
			Me.imglNodes.Images.SetKeyName(1, "")
			Me.imglNodes.Images.SetKeyName(2, "")
			Me.imglNodes.Images.SetKeyName(3, "")
			Me.imglNodes.Images.SetKeyName(4, "")
			Me.imglNodes.Images.SetKeyName(5, "")
			Me.imglNodes.Images.SetKeyName(6, "")
			' 
			' imglCustom
			' 
			Me.imglCustom.ImageStream = (CType(resources.GetObject("imglCustom.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imglCustom.TransparentColor = System.Drawing.Color.Magenta
			Me.imglCustom.Images.SetKeyName(0, "")
			Me.imglCustom.Images.SetKeyName(1, "")
			Me.imglCustom.Images.SetKeyName(2, "")
			Me.imglCustom.Images.SetKeyName(3, "")
			Me.imglCustom.Images.SetKeyName(4, "")
			Me.imglCustom.Images.SetKeyName(5, "")
			' 
			' treeList1
			' 
			Me.treeList1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
			Me.treeList1.Appearance.Empty.Options.UseBackColor = True
			Me.treeList1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(160)))), (CInt((CByte(228)))), (CInt((CByte(248)))))
			Me.treeList1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
			Me.treeList1.Appearance.EvenRow.Options.UseBackColor = True
			Me.treeList1.Appearance.EvenRow.Options.UseForeColor = True
			Me.treeList1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.treeList1.Appearance.HeaderPanel.Options.UseFont = True
			Me.treeList1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(218)))), (CInt((CByte(239)))), (CInt((CByte(254)))))
			Me.treeList1.Appearance.OddRow.Options.UseBackColor = True
			Me.treeList1.BackgroundImage = (CType(resources.GetObject("treeList1.BackgroundImage"), System.Drawing.Image))
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsView.EnableAppearanceEvenRow = True
			Me.treeList1.OptionsView.EnableAppearanceOddRow = True
			Me.treeList1.OptionsView.ShowSummaryFooter = True
			Me.treeList1.SelectImageList = Me.imglNodes
			Me.treeList1.Size = New System.Drawing.Size(720, 349)
			Me.treeList1.TabIndex = 1
'			Me.treeList1.CustomDrawNodeIndicator += New DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventHandler(Me.treeList1_CustomDrawNodeIndicator)
'			Me.treeList1.CustomDrawRowFooterCell += New DevExpress.XtraTreeList.CustomDrawRowFooterCellEventHandler(Me.treeList1_CustomDrawRowFooterCell)
'			Me.treeList1.CustomDrawNodeCell += New DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(Me.treeList1_CustomDrawNodeCell)
'			Me.treeList1.CustomDrawFooter += New DevExpress.XtraTreeList.CustomDrawFooterEventHandler(Me.treeList1_CustomDrawFooter)
'			Me.treeList1.FocusedColumnChanged += New DevExpress.XtraTreeList.FocusedColumnChangedEventHandler(Me.treeList1_FocusedColumnChanged)
'			Me.treeList1.CustomDrawNodeImages += New DevExpress.XtraTreeList.CustomDrawNodeImagesEventHandler(Me.treeList1_CustomDrawNodeImages)
'			Me.treeList1.CustomDrawNodeButton += New DevExpress.XtraTreeList.CustomDrawNodeButtonEventHandler(Me.treeList1_CustomDrawNodeButton)
'			Me.treeList1.CustomDrawRowFooter += New DevExpress.XtraTreeList.CustomDrawRowFooterEventHandler(Me.treeList1_CustomDrawRowFooter)
'			Me.treeList1.CustomDrawColumnHeader += New DevExpress.XtraTreeList.CustomDrawColumnHeaderEventHandler(Me.treeList1_CustomDrawColumnHeader)
'			Me.treeList1.CustomDrawFooterCell += New DevExpress.XtraTreeList.CustomDrawFooterCellEventHandler(Me.treeList1_CustomDrawFooterCell)
'			Me.treeList1.TreeListMenuItemClick += New DevExpress.XtraTreeList.TreeListMenuItemClickEventHandler(Me.treeList1_TreeListMenuItemClick)
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.MaxItemId = 0
			' 
			' TreeListCustomDraw
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "TreeListCustomDraw"
			Me.Size = New System.Drawing.Size(720, 349)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private imageList1 As System.Windows.Forms.ImageList
		Private imglCustom As System.Windows.Forms.ImageList
		Private imglNodes As System.Windows.Forms.ImageList
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private components As System.ComponentModel.IContainer
	End Class
End Namespace
