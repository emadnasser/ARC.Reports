Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class ucSolutionExplorer
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ucSolutionExplorer))
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.iRefresh = New DevExpress.XtraBars.BarButtonItem()
            Me.iShow = New DevExpress.XtraBars.BarButtonItem()
            Me.iProperties = New DevExpress.XtraBars.BarButtonItem()
            Me.barAndDockingController = New DevExpress.XtraBars.BarAndDockingController(Me.components)
            Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
            Me.fileTypeImages = New System.Windows.Forms.ImageList(Me.components)
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.treeView = New DevExpress.XtraTreeList.TreeList()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barAndDockingController, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.treeView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barManager
            ' 
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
            Me.barManager.Controller = Me.barAndDockingController
            Me.barManager.DockControls.Add(Me.barDockControl1)
            Me.barManager.DockControls.Add(Me.barDockControl2)
            Me.barManager.DockControls.Add(Me.barDockControl3)
            Me.barManager.DockControls.Add(Me.barDockControl4)
            Me.barManager.Form = Me
            Me.barManager.Images = Me.fileTypeImages
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.iRefresh, Me.iShow, Me.iProperties})
            Me.barManager.MaxItemId = 0
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Explorer"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(53, 102)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.iRefresh),
                New DevExpress.XtraBars.LinkPersistInfo(Me.iShow, True),
                New DevExpress.XtraBars.LinkPersistInfo(Me.iProperties, True)
            })
            Me.bar1.OptionsBar.AllowQuickCustomization = False
            Me.bar1.OptionsBar.DrawDragBorder = False
            Me.bar1.OptionsBar.RotateWhenVertical = False
            Me.bar1.OptionsBar.UseWholeRow = True
            Me.bar1.Text = "Explorer"
            ' 
            ' iRefresh
            ' 
            Me.iRefresh.Caption = "Refresh"
            Me.iRefresh.Hint = "Refresh"
            Me.iRefresh.Id = 0
            Me.iRefresh.ImageIndex = 0
            Me.iRefresh.Name = "iRefresh"
            ' 
            ' iShow
            ' 
            Me.iShow.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.iShow.Caption = "Show All Files"
            Me.iShow.Hint = "Show All Files"
            Me.iShow.Id = 1
            Me.iShow.ImageIndex = 1
            Me.iShow.Name = "iShow"
            ' 
            ' iProperties
            ' 
            Me.iProperties.Caption = "Properties"
            Me.iProperties.Hint = "Properties"
            Me.iProperties.Id = 2
            Me.iProperties.ImageIndex = 2
            Me.iProperties.Name = "iProperties"
            ' 
            ' barAndDockingController
            ' 
            Me.barAndDockingController.PropertiesBar.AllowLinkLighting = False
            Me.barAndDockingController.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
            Me.barAndDockingController.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
            ' 
            ' barDockControl1
            ' 
            Me.barDockControl1.CausesValidation = False
            Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControl1.Location = New System.Drawing.Point(0, 0)
            Me.barDockControl1.Size = New System.Drawing.Size(288, 31)
            ' 
            ' barDockControl2
            ' 
            Me.barDockControl2.CausesValidation = False
            Me.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControl2.Location = New System.Drawing.Point(0, 288)
            Me.barDockControl2.Size = New System.Drawing.Size(288, 0)
            ' 
            ' barDockControl3
            ' 
            Me.barDockControl3.CausesValidation = False
            Me.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControl3.Location = New System.Drawing.Point(0, 31)
            Me.barDockControl3.Size = New System.Drawing.Size(0, 257)
            ' 
            ' barDockControl4
            ' 
            Me.barDockControl4.CausesValidation = False
            Me.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControl4.Location = New System.Drawing.Point(288, 31)
            Me.barDockControl4.Size = New System.Drawing.Size(0, 257)
            ' 
            ' fileTypeImages
            ' 
            Me.fileTypeImages.ImageStream = (CType(resources.GetObject("fileTypeImages.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.fileTypeImages.TransparentColor = System.Drawing.Color.Magenta
            Me.fileTypeImages.Images.SetKeyName(0, "refresh_16xLG.png")
            Me.fileTypeImages.Images.SetKeyName(1, "ShowAllFiles_349.png")
            Me.fileTypeImages.Images.SetKeyName(2, "Property_501.png")
            Me.fileTypeImages.Images.SetKeyName(3, "Solution_8308.png")
            Me.fileTypeImages.Images.SetKeyName(4, "CSharpProject_SolutionExplorerNode.png")
            Me.fileTypeImages.Images.SetKeyName(5, "reference_16xLG.png")
            Me.fileTypeImages.Images.SetKeyName(6, "FolderOpen.png")
            Me.fileTypeImages.Images.SetKeyName(7, "Folder.png")
            Me.fileTypeImages.Images.SetKeyName(8, "HiddenFolder_428.png")
            Me.fileTypeImages.Images.SetKeyName(9, "HiddenFolder_427.png")
            Me.fileTypeImages.Images.SetKeyName(10, "CSharpFile_SolutionExplorerNode.png")
            Me.fileTypeImages.Images.SetKeyName(11, "dialog_16xLG.png")
            Me.fileTypeImages.Images.SetKeyName(12, "UserControl.png")
            Me.fileTypeImages.Images.SetKeyName(13, "Generatedfile_430.png")
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.treeView)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 31)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(288, 257)
            Me.panel1.TabIndex = 4
            ' 
            ' treeView
            ' 
            Me.treeView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeView.Location = New System.Drawing.Point(0, 0)
            Me.treeView.Name = "treeView"
            Me.treeView.Size = New System.Drawing.Size(288, 257)
            Me.treeView.StateImageList = Me.fileTypeImages
            Me.treeView.TabIndex = 0
            ' 
            ' ucSolutionExplorer
            ' 
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.barDockControl3)
            Me.Controls.Add(Me.barDockControl4)
            Me.Controls.Add(Me.barDockControl2)
            Me.Controls.Add(Me.barDockControl1)
            Me.Name = "ucSolutionExplorer"
            Me.Size = New System.Drawing.Size(288, 288)
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barAndDockingController, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.treeView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Friend barManager As DevExpress.XtraBars.BarManager
        Private barDockControl1 As DevExpress.XtraBars.BarDockControl
        Private barDockControl2 As DevExpress.XtraBars.BarDockControl
        Private barDockControl3 As DevExpress.XtraBars.BarDockControl
        Private barDockControl4 As DevExpress.XtraBars.BarDockControl
        Private iRefresh As DevExpress.XtraBars.BarButtonItem
        Private WithEvents iShow As DevExpress.XtraBars.BarButtonItem
        Private WithEvents iProperties As DevExpress.XtraBars.BarButtonItem
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents treeView As DevExpress.XtraTreeList.TreeList
        Private bar1 As DevExpress.XtraBars.Bar
        Private barAndDockingController As DevExpress.XtraBars.BarAndDockingController
        Private components As System.ComponentModel.IContainer
        Private fileTypeImages As System.Windows.Forms.ImageList

    End Class
End Namespace
