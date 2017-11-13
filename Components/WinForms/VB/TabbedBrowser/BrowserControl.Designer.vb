Namespace TabbedBrowser
    Partial Public Class BrowserControl
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrowserControl))
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
            Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
            Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl
            Me.standaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl
            Me.webBrowser = New System.Windows.Forms.WebBrowser
            Me.AddressBar = New DevExpress.XtraEditors.ButtonEdit
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar
            Me.Back = New DevExpress.XtraBars.BarButtonItem
            Me.Forward = New DevExpress.XtraBars.BarButtonItem
            Me.Refresh_button = New DevExpress.XtraBars.BarButtonItem
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.AddressBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.standaloneBarDockControl1)
            Me.layoutControl.Controls.Add(Me.webBrowser)
            Me.layoutControl.Controls.Add(Me.AddressBar)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(605, 200, 773, 548)
            Me.layoutControl.Root = Me.layoutControlGroup1
            Me.layoutControl.Size = New System.Drawing.Size(758, 426)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            '
            'standaloneBarDockControl1
            '
            Me.standaloneBarDockControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.standaloneBarDockControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.standaloneBarDockControl1.Appearance.Options.UseFont = True
            Me.standaloneBarDockControl1.CausesValidation = False
            Me.standaloneBarDockControl1.Location = New System.Drawing.Point(12, 12)
            Me.standaloneBarDockControl1.Name = "standaloneBarDockControl1"
            Me.standaloneBarDockControl1.Size = New System.Drawing.Size(147, 40)
            Me.standaloneBarDockControl1.Text = "standaloneBarDockControl1"
            '
            'webBrowser
            '
            Me.webBrowser.Location = New System.Drawing.Point(12, 56)
            Me.webBrowser.MinimumSize = New System.Drawing.Size(20, 20)
            Me.webBrowser.Name = "webBrowser"
            Me.webBrowser.Size = New System.Drawing.Size(734, 358)
            Me.webBrowser.TabIndex = 11
            '
            'AddressBar
            '
            Me.AddressBar.Location = New System.Drawing.Point(164, 13)
            Me.AddressBar.Name = "AddressBar"
            Me.AddressBar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AddressBar.Properties.Appearance.Options.UseFont = True
            Me.AddressBar.Size = New System.Drawing.Size(581, 36)
            Me.AddressBar.StyleController = Me.layoutControl
            Me.AddressBar.TabIndex = 4
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(758, 426)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.AddressBar
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(151, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(54, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.layoutControlItem1.Size = New System.Drawing.Size(587, 44)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.webBrowser
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 44)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(24, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(738, 362)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.standaloneBarDockControl1
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.MaxSize = New System.Drawing.Size(151, 44)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(151, 44)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(151, 44)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.Text = "layoutControlItem3"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            '
            'barManager1
            '
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.DockControls.Add(Me.standaloneBarDockControl1)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Back, Me.Forward, Me.Refresh_button})
            Me.barManager1.MainMenu = Me.bar1
            Me.barManager1.MaxItemId = 3
            '
            'bar1
            '
            Me.bar1.BarName = "Custom 2"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.bar1.FloatLocation = New System.Drawing.Point(167, 169)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Back), New DevExpress.XtraBars.LinkPersistInfo(Me.Forward), New DevExpress.XtraBars.LinkPersistInfo(Me.Refresh_button)})
            Me.bar1.OptionsBar.AllowQuickCustomization = False
            Me.bar1.OptionsBar.DrawDragBorder = False
            Me.bar1.OptionsBar.MultiLine = True
            Me.bar1.OptionsBar.RotateWhenVertical = False
            Me.bar1.OptionsBar.UseWholeRow = True
            Me.bar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            Me.bar1.Text = "Custom 2"
            '
            'Back
            '
            Me.Back.Caption = "Back"
            Me.Back.Glyph = CType(resources.GetObject("Back.Glyph"), System.Drawing.Image)
            Me.Back.Id = 0
            Me.Back.Name = "Back"
            ToolTipTitleItem1.Text = "Back"
            SuperToolTip1.Items.Add(ToolTipTitleItem1)
            Me.Back.SuperTip = SuperToolTip1
            '
            'Forward
            '
            Me.Forward.Caption = "Forward"
            Me.Forward.Glyph = CType(resources.GetObject("Forward.Glyph"), System.Drawing.Image)
            Me.Forward.Id = 1
            Me.Forward.Name = "Forward"
            ToolTipTitleItem2.Text = "Forward"
            SuperToolTip2.Items.Add(ToolTipTitleItem2)
            Me.Forward.SuperTip = SuperToolTip2
            '
            'Refresh_button
            '
            Me.Refresh_button.Caption = "Refresh"
            Me.Refresh_button.Glyph = CType(resources.GetObject("Refresh_button.Glyph"), System.Drawing.Image)
            Me.Refresh_button.Id = 2
            Me.Refresh_button.Name = "Refresh_button"
            ToolTipTitleItem3.Text = "Refresh"
            SuperToolTip3.Items.Add(ToolTipTitleItem3)
            Me.Refresh_button.SuperTip = SuperToolTip3
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(758, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 426)
            Me.barDockControlBottom.Size = New System.Drawing.Size(758, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 426)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(758, 0)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 426)
            '
            'BrowserControl
            '
            Me.Controls.Add(Me.layoutControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.LookAndFeel.UseDefaultLookAndFeel = False
            Me.Name = "BrowserControl"
            Me.Size = New System.Drawing.Size(758, 426)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.AddressBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private layoutControl As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents AddressBar As DevExpress.XtraEditors.ButtonEdit
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private webBrowser As WebBrowser
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private standaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private bar1 As DevExpress.XtraBars.Bar
        Private WithEvents Back As DevExpress.XtraBars.BarButtonItem
        Private WithEvents Forward As DevExpress.XtraBars.BarButtonItem
        Private WithEvents Refresh_button As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace
