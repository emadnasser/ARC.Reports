Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ucMailViewer
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ucMailViewer))
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.standaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
            Me.pePhoto = New DevExpress.XtraEditors.PictureEdit()
            Me.lcTitle = New DevExpress.XtraEditors.LabelControl()
            Me.recMessage = New DevExpress.XtraRichEdit.RichEditControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.bbiReply = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiReplyAll = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiForward = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.linkView = New DevExpress.XtraEditors.HyperLinkEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linkView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.layoutControl1)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.standaloneBarDockControl1)
            Me.layoutControl1.Controls.Add(Me.pePhoto)
            Me.layoutControl1.Controls.Add(Me.lcTitle)
            Me.layoutControl1.Controls.Add(Me.recMessage)
            Me.layoutControl1.Controls.Add(Me.linkView)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' standaloneBarDockControl1
            ' 
            Me.standaloneBarDockControl1.CausesValidation = False
            resources.ApplyResources(Me.standaloneBarDockControl1, "standaloneBarDockControl1")
            Me.standaloneBarDockControl1.Name = "standaloneBarDockControl1"
            ' 
            ' pePhoto
            ' 
            Me.pePhoto.EditValue = My.Resources.Unknown_user
            resources.ApplyResources(Me.pePhoto, "pePhoto")
            Me.pePhoto.Name = "pePhoto"
            Me.pePhoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pePhoto.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.pePhoto.StyleController = Me.layoutControl1
            ' 
            ' lcTitle
            ' 
            Me.lcTitle.AllowHtmlString = True
            Me.lcTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
            Me.lcTitle.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            resources.ApplyResources(Me.lcTitle, "lcTitle")
            Me.lcTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            Me.lcTitle.LineVisible = True
            Me.lcTitle.Name = "lcTitle"
            Me.lcTitle.StyleController = Me.layoutControl1
            ' 
            ' recMessage
            ' 
            Me.recMessage.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
            Me.recMessage.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.recMessage, "recMessage")
            Me.recMessage.MenuManager = Me.barManager1
            Me.recMessage.Name = "recMessage"
            Me.recMessage.Options.Fields.UseCurrentCultureDateTimeFormat = False
            Me.recMessage.Options.MailMerge.KeepLastParagraph = False
            Me.recMessage.ReadOnly = True
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar2})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.DockControls.Add(Me.standaloneBarDockControl1)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiReply, Me.bbiReplyAll, Me.bbiForward})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 3
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiReply), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiReplyAll), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiForward)})
            Me.bar2.OptionsBar.AllowQuickCustomization = False
            Me.bar2.OptionsBar.DrawDragBorder = False
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.StandaloneBarDockControl = Me.standaloneBarDockControl1
            resources.ApplyResources(Me.bar2, "bar2")
            ' 
            ' bbiReply
            ' 
            resources.ApplyResources(Me.bbiReply, "bbiReply")
            Me.bbiReply.Enabled = False
            Me.bbiReply.Glyph = My.Resources.Reply
            Me.bbiReply.Id = 0
            Me.bbiReply.Name = "bbiReply"
            Me.bbiReply.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '			Me.bbiReply.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiReply_ItemClick)
            ' 
            ' bbiReplyAll
            ' 
            resources.ApplyResources(Me.bbiReplyAll, "bbiReplyAll")
            Me.bbiReplyAll.Enabled = False
            Me.bbiReplyAll.Glyph = My.Resources.ReplyAll
            Me.bbiReplyAll.Id = 1
            Me.bbiReplyAll.Name = "bbiReplyAll"
            Me.bbiReplyAll.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '			Me.bbiReplyAll.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiReplyAll_ItemClick)
            ' 
            ' bbiForward
            ' 
            resources.ApplyResources(Me.bbiForward, "bbiForward")
            Me.bbiForward.Enabled = False
            Me.bbiForward.Glyph = My.Resources.Forward
            Me.bbiForward.Id = 2
            Me.bbiForward.Name = "bbiForward"
            Me.bbiForward.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '			Me.bbiForward.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiForward_ItemClick)
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            resources.ApplyResources(Me.barDockControlTop, "barDockControlTop")
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            resources.ApplyResources(Me.barDockControlBottom, "barDockControlBottom")
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            resources.ApplyResources(Me.barDockControlLeft, "barDockControlLeft")
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            resources.ApplyResources(Me.barDockControlRight, "barDockControlRight")
            ' 
            ' linkView
            ' 
            resources.ApplyResources(Me.linkView, "linkView")
            Me.linkView.Name = "linkView"
            Me.linkView.Properties.AllowFocused = False
            Me.linkView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.linkView.Properties.Caption = resources.GetString("linkView.Properties.Caption")
            Me.linkView.Properties.StartLinkOnClickingEmptySpace = False
            Me.linkView.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(588, 605)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.lcTitle
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Location = New System.Drawing.Point(84, 28)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(504, 20)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.linkView
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 583)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(588, 22)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            Me.layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.recMessage
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem3.Size = New System.Drawing.Size(588, 535)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.pePhoto
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 28)
            Me.layoutControlItem4.MaxSize = New System.Drawing.Size(84, 0)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(84, 20)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem4.Size = New System.Drawing.Size(84, 20)
            Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextToControlDistance = 0
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.standaloneBarDockControl1
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(588, 28)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextToControlDistance = 0
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' ucMailViewer
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "ucMailViewer"
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linkView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private recMessage As DevExpress.XtraRichEdit.RichEditControl
        Private lcTitle As DevExpress.XtraEditors.LabelControl
        Private linkView As DevExpress.XtraEditors.HyperLinkEdit
        Private layoutControl1 As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private pePhoto As XtraEditors.PictureEdit
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private barManager1 As XtraBars.BarManager
        Private bar2 As XtraBars.Bar
        Private WithEvents bbiReply As XtraBars.BarButtonItem
        Private WithEvents bbiReplyAll As XtraBars.BarButtonItem
        Private WithEvents bbiForward As XtraBars.BarButtonItem
        Private barDockControlTop As XtraBars.BarDockControl
        Private barDockControlBottom As XtraBars.BarDockControl
        Private barDockControlLeft As XtraBars.BarDockControl
        Private barDockControlRight As XtraBars.BarDockControl
        Private standaloneBarDockControl1 As XtraBars.StandaloneBarDockControl
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
    End Class
End Namespace
