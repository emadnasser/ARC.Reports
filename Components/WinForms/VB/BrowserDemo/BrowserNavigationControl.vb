Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DevExpress.XtraBars.Demos.BrowserDemo
    Public Class BrowserNavigationControl
        Inherits XtraUserControl
        Private barManager1 As BarManager
        Private components As System.ComponentModel.IContainer
        Private barDockControlTop As BarDockControl
        Private barDockControlBottom As BarDockControl
        Private barDockControlLeft As BarDockControl
        Private bar1 As Bar
        Private barButtonItem3 As BarButtonItem
        Private barButtonItem4 As BarButtonItem
        Private barEditItem1 As BarEditItem
        Private repositoryItemSearchControl1 As XtraEditors.Repository.RepositoryItemSearchControl
        Private barButtonItem5 As BarButtonItem
        Private barAndDockingController1 As BarAndDockingController
        Private barDockControlRight As BarDockControl

        Public Sub New()
            MyBase.New()
            InitializeComponent()
            Dock = System.Windows.Forms.DockStyle.Top
        End Sub
        Public ReadOnly Property SearchPanel() As RepositoryItemSearchControl
            Get
                Return Me.repositoryItemSearchControl1
            End Get
        End Property
        Public ReadOnly Property SearchItem() As BarEditItem
            Get
                Return Me.barEditItem1
            End Get
        End Property
        Public ReadOnly Property Manager() As BarManager
            Get
                Return Me.barManager1
            End Get
        End Property
        Public ReadOnly Property BackButton() As BarButtonItem
            Get
                Return Me.barButtonItem3
            End Get
        End Property
        Public ReadOnly Property ForwardButton() As BarButtonItem
            Get
                Return Me.barButtonItem4
            End Get
        End Property
        Public ReadOnly Property RefreshButton() As BarButtonItem
            Get
                Return Me.barButtonItem5
            End Get
        End Property

        Shared ReadOnly SearchItemHorizontalPadding As Integer = 10
        Protected Overrides Sub ScaleControl(factor As System.Drawing.SizeF, specified As System.Windows.Forms.BoundsSpecified)
            MyBase.ScaleControl(factor, specified)
            Me.barButtonItem5.Width = CInt(Me.barButtonItem5.Width * factor.Width)
            Me.barButtonItem4.Width = CInt(Me.barButtonItem4.Width * factor.Width)
            Me.barButtonItem3.Width = CInt(Me.barButtonItem3.Width * factor.Width)
            Dim padding As Integer = CInt(Math.Truncate(SearchItemHorizontalPadding * factor.Width))
            SearchItem.EditorPadding = New System.Windows.Forms.Padding(padding, 0, padding, 0)
        End Sub
        Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As System.Windows.Forms.BoundsSpecified)
            height = Padding.Vertical + barDockControlTop.Height
            MyBase.SetBoundsCore(x, y, width, height, specified)
        End Sub
        Protected Overrides Sub OnSizeChanged(e As EventArgs)
            MyBase.OnSizeChanged(e)
            Me.barEditItem1.Width = ClientSize.Width - Padding.Horizontal - barButtonItem5.Width - barButtonItem4.Width - barButtonItem3.Width
        End Sub
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrowserNavigationControl))
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemSearchControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
            Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'barManager1
            '
            Me.barManager1.AllowCustomization = False
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
            Me.barManager1.Controller = Me.barAndDockingController1
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonItem3, Me.barButtonItem4, Me.barEditItem1, Me.barButtonItem5})
            Me.barManager1.MainMenu = Me.bar1
            Me.barManager1.MaxItemId = 6
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSearchControl1})
            '
            'bar1
            '
            Me.bar1.BarName = "Custom 2"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem5)})
            Me.bar1.OptionsBar.AllowQuickCustomization = False
            Me.bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
            Me.bar1.OptionsBar.DisableClose = True
            Me.bar1.OptionsBar.DisableCustomization = True
            Me.bar1.OptionsBar.DrawBorder = False
            Me.bar1.OptionsBar.DrawDragBorder = False
            Me.bar1.OptionsBar.UseWholeRow = True
            Me.bar1.Text = "Custom 2"
            '
            'barButtonItem3
            '
            Me.barButtonItem3.Caption = "Back"
            Me.barButtonItem3.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center
            Me.barButtonItem3.Enabled = False
            Me.barButtonItem3.Glyph = CType(resources.GetObject("barButtonItem3.Glyph"), System.Drawing.Image)
            Me.barButtonItem3.Id = 2
            Me.barButtonItem3.Name = "barButtonItem3"
            Me.barButtonItem3.Size = New System.Drawing.Size(35, 0)
            '
            'barButtonItem4
            '
            Me.barButtonItem4.Caption = "Forward"
            Me.barButtonItem4.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center
            Me.barButtonItem4.Enabled = False
            Me.barButtonItem4.Glyph = CType(resources.GetObject("barButtonItem4.Glyph"), System.Drawing.Image)
            Me.barButtonItem4.Id = 3
            Me.barButtonItem4.Name = "barButtonItem4"
            Me.barButtonItem4.Size = New System.Drawing.Size(35, 0)
            '
            'barEditItem1
            '
            Me.barEditItem1.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center
            Me.barEditItem1.Edit = Me.repositoryItemSearchControl1
            Me.barEditItem1.EditHeight = 30
            Me.barEditItem1.EditWidth = 70
            Me.barEditItem1.Id = 4
            Me.barEditItem1.Name = "barEditItem1"
            '
            'repositoryItemSearchControl1
            '
            Me.repositoryItemSearchControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.repositoryItemSearchControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.repositoryItemSearchControl1.Appearance.Options.UseFont = True
            Me.repositoryItemSearchControl1.Appearance.Options.UseForeColor = True
            Me.repositoryItemSearchControl1.AutoHeight = False
            Me.repositoryItemSearchControl1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1"
            Me.repositoryItemSearchControl1.ShowClearButton = False
            '
            'barButtonItem5
            '
            Me.barButtonItem5.Caption = "Refresh"
            Me.barButtonItem5.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center
            Me.barButtonItem5.Glyph = CType(resources.GetObject("barButtonItem5.Glyph"), System.Drawing.Image)
            Me.barButtonItem5.Id = 5
            Me.barButtonItem5.Name = "barButtonItem5"
            Me.barButtonItem5.Size = New System.Drawing.Size(37, 0)
            '
            'barAndDockingController1
            '
            Me.barAndDockingController1.PropertiesBar.AllowLinkLighting = False
            Me.barAndDockingController1.PropertiesBar.BarItemHorzIndent = 0
            Me.barAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
            Me.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(18, 14)
            Me.barDockControlTop.Size = New System.Drawing.Size(351, 40)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(18, 135)
            Me.barDockControlBottom.Size = New System.Drawing.Size(351, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(18, 54)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 81)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(369, 54)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 81)
            '
            'BrowserNavigationControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "BrowserNavigationControl"
            Me.Padding = New System.Windows.Forms.Padding(18, 14, 21, 15)
            Me.Size = New System.Drawing.Size(390, 150)
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
    End Class
End Namespace
