Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ContextButtons
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
            Dim contextButton1 As New DevExpress.Utils.ContextButton()
            Dim contextButton2 As New DevExpress.Utils.ContextButton()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ContextButtons))
            Dim contextButton3 As New DevExpress.Utils.ContextButton()
            Dim contextButton4 As New DevExpress.Utils.ContextButton()
            Dim checkContextButton1 As New DevExpress.Utils.CheckContextButton()
            Dim ratingContextButton1 As New DevExpress.Utils.RatingContextButton()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.winExplorerView1 = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemZoomTrackBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.winExplorerView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemZoomTrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 38)
            Me.gridControl1.MainView = Me.winExplorerView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(711, 420)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.winExplorerView1})
            ' 
            ' winExplorerView1
            ' 
            Me.winExplorerView1.ContextButtonOptions.BottomPanelColor = System.Drawing.Color.FromArgb((CInt((CByte(160)))), (CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
            Me.winExplorerView1.ContextButtonOptions.BottomPanelPadding = New System.Windows.Forms.Padding(5)
            Me.winExplorerView1.ContextButtonOptions.Indent = 3
            Me.winExplorerView1.ContextButtonOptions.TopPanelColor = System.Drawing.Color.FromArgb((CInt((CByte(160)))), (CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
            Me.winExplorerView1.ContextButtonOptions.TopPanelPadding = New System.Windows.Forms.Padding(5)
            contextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.MiddleTop
            contextButton1.AppearanceHover.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            contextButton1.AppearanceHover.ForeColor = System.Drawing.Color.White
            contextButton1.AppearanceHover.Options.UseFont = True
            contextButton1.AppearanceHover.Options.UseForeColor = True
            contextButton1.AppearanceNormal.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            contextButton1.AppearanceNormal.ForeColor = System.Drawing.Color.White
            contextButton1.AppearanceNormal.Options.UseFont = True
            contextButton1.AppearanceNormal.Options.UseForeColor = True
            contextButton1.Id = New System.Guid("62095aba-f30f-4377-b233-14b1eab8c0db")
            contextButton1.Name = "itemText"
            contextButton2.Alignment = DevExpress.Utils.ContextItemAlignment.TopFar
            contextButton2.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True
            contextButton2.AppearanceHover.ForeColor = System.Drawing.Color.White
            contextButton2.AppearanceHover.Options.UseForeColor = True
            contextButton2.AppearanceNormal.ForeColor = System.Drawing.Color.White
            contextButton2.AppearanceNormal.Options.UseForeColor = True
            contextButton2.Glyph = (CType(resources.GetObject("contextButton2.Glyph"), System.Drawing.Image))
            contextButton2.Id = New System.Guid("aff114b4-1a64-4e9b-ae04-098d9ddc4ec4")
            contextButton2.Name = "itemRemove"
            contextButton3.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True
            contextButton3.AppearanceHover.ForeColor = System.Drawing.Color.White
            contextButton3.AppearanceHover.Options.UseForeColor = True
            contextButton3.AppearanceNormal.ForeColor = System.Drawing.Color.White
            contextButton3.AppearanceNormal.Options.UseForeColor = True
            contextButton3.Glyph = (CType(resources.GetObject("contextButton3.Glyph"), System.Drawing.Image))
            contextButton3.Id = New System.Guid("8919a814-c5ac-42a5-96fe-71a6f31d1f7e")
            contextButton3.Name = "itemDownload"
            contextButton4.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True
            contextButton4.AppearanceHover.ForeColor = System.Drawing.Color.White
            contextButton4.AppearanceHover.Options.UseForeColor = True
            contextButton4.AppearanceNormal.ForeColor = System.Drawing.Color.White
            contextButton4.AppearanceNormal.Options.UseForeColor = True
            contextButton4.Glyph = (CType(resources.GetObject("contextButton4.Glyph"), System.Drawing.Image))
            contextButton4.Id = New System.Guid("52064e3b-1c98-4a1f-9296-07465624a0d5")
            contextButton4.Name = "itemInfo"
            checkContextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.BottomNear
            checkContextButton1.Id = New System.Guid("d5e27663-722f-40c8-8363-cc4eded0e782")
            checkContextButton1.Name = "itemCheck"
            ratingContextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.MiddleBottom
            ratingContextButton1.Id = New System.Guid("93da3997-ef55-4c87-8eef-d2881dc0e6dd")
            ratingContextButton1.Name = "itemRating"
            ratingContextButton1.Rating = New Decimal(New Integer() {0, 0, 0, 0})
            Me.winExplorerView1.ContextButtons.Add(contextButton1)
            Me.winExplorerView1.ContextButtons.Add(contextButton2)
            Me.winExplorerView1.ContextButtons.Add(contextButton3)
            Me.winExplorerView1.ContextButtons.Add(contextButton4)
            Me.winExplorerView1.ContextButtons.Add(checkContextButton1)
            Me.winExplorerView1.ContextButtons.Add(ratingContextButton1)
            Me.winExplorerView1.GridControl = Me.gridControl1
            Me.winExplorerView1.Name = "winExplorerView1"
            Me.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.ExtraLarge
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar2})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barEditItem2, Me.barEditItem1})
            Me.barManager1.MaxItemId = 3
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemZoomTrackBar2, Me.repositoryItemImageComboBox1})
            Me.barManager1.TransparentEditors = True
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem2)
            })
            Me.bar2.OptionsBar.AllowQuickCustomization = False
            Me.bar2.OptionsBar.DrawBorder = False
            Me.bar2.OptionsBar.DrawDragBorder = False
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            ' 
            ' barEditItem1
            ' 
            Me.barEditItem1.Caption = "Animation Type"
            Me.barEditItem1.Edit = Me.repositoryItemImageComboBox1
            Me.barEditItem1.Id = 2
            Me.barEditItem1.Name = "barEditItem1"
            Me.barEditItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            Me.barEditItem1.Width = 182
            ' 
            ' repositoryItemImageComboBox1
            ' 
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            ' 
            ' barEditItem2
            ' 
            Me.barEditItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.barEditItem2.Caption = "Thumbnails"
            Me.barEditItem2.Edit = Me.repositoryItemZoomTrackBar2
            Me.barEditItem2.EditValue = 300
            Me.barEditItem2.Id = 1
            Me.barEditItem2.Name = "barEditItem2"
            Me.barEditItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            Me.barEditItem2.Width = 150
            ' 
            ' repositoryItemZoomTrackBar2
            ' 
            Me.repositoryItemZoomTrackBar2.AllowFocused = False
            Me.repositoryItemZoomTrackBar2.AllowUseMiddleValue = True
            Me.repositoryItemZoomTrackBar2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemZoomTrackBar2.Maximum = 392
            Me.repositoryItemZoomTrackBar2.Middle = 300
            Me.repositoryItemZoomTrackBar2.Minimum = 192
            Me.repositoryItemZoomTrackBar2.Name = "repositoryItemZoomTrackBar2"
            Me.repositoryItemZoomTrackBar2.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(711, 30)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 458)
            Me.barDockControlBottom.Size = New System.Drawing.Size(711, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 30)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 428)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(711, 30)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 428)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 30)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(711, 8)
            Me.panelControl1.TabIndex = 5
            ' 
            ' ContextButtons
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "ContextButtons"
            Me.Size = New System.Drawing.Size(711, 458)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.winExplorerView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemZoomTrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControl1 As GridControl
        Private WithEvents winExplorerView1 As Views.WinExplorer.WinExplorerView
        Private barManager1 As XtraBars.BarManager
        Private bar2 As XtraBars.Bar
        Private barDockControlTop As XtraBars.BarDockControl
        Private barDockControlBottom As XtraBars.BarDockControl
        Private barDockControlLeft As XtraBars.BarDockControl
        Private barDockControlRight As XtraBars.BarDockControl
        Private barEditItem2 As XtraBars.BarEditItem
        Private WithEvents repositoryItemZoomTrackBar2 As XtraEditors.Repository.RepositoryItemZoomTrackBar
        Private barEditItem1 As XtraBars.BarEditItem
        Private WithEvents repositoryItemImageComboBox1 As XtraEditors.Repository.RepositoryItemImageComboBox
        Private panelControl1 As XtraEditors.PanelControl
    End Class
End Namespace
