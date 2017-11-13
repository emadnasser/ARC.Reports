Namespace TabbedBrowser
	Partial Public Class RootMainForm
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

		Private Sub InitializeComponent()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RootMainForm))
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager()
            Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
            Me.barManager1 = New DevExpress.XtraBars.BarManager()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'documentManager1
            '
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.View = Me.tabbedView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tabbedView1})
            Me.documentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.True
            '
            'tabbedView1
            '
            ToolTipTitleItem1.Text = "Home"
            SuperToolTip1.Items.Add(ToolTipTitleItem1)
            ToolTipTitleItem2.Text = "History"
            SuperToolTip2.Items.Add(ToolTipTitleItem2)
            ToolTipTitleItem3.Text = "Property"
            SuperToolTip3.Items.Add(ToolTipTitleItem3)
            Me.tabbedView1.DocumentGroupProperties.CustomHeaderButtons.AddRange(New DevExpress.XtraTab.Buttons.CustomHeaderButton() {New DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Home", -1, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("tabbedView1.DocumentGroupProperties.CustomHeaderButtons"), System.Drawing.Image), SerializableAppearanceObject1, "", Nothing, SuperToolTip1, True), New DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "History", -1, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("tabbedView1.DocumentGroupProperties.CustomHeaderButtons1"), System.Drawing.Image), SerializableAppearanceObject2, "", Nothing, SuperToolTip2, True), New DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Property", -1, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("tabbedView1.DocumentGroupProperties.CustomHeaderButtons2"), System.Drawing.Image), SerializableAppearanceObject3, "", Nothing, SuperToolTip3, True)})
            Me.tabbedView1.DocumentGroupProperties.ShowDocumentSelectorButton = False
            Me.tabbedView1.DocumentProperties.AllowPin = True
            Me.tabbedView1.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost
            '
            'barManager1
            '
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.MaxItemId = 2
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(744, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 365)
            Me.barDockControlBottom.Size = New System.Drawing.Size(744, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 365)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(744, 0)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 365)
            '
            'RootMainForm
            '
            Me.ClientSize = New System.Drawing.Size(744, 365)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "RootMainForm"
            Me.Text = "Tabbed Browser Demo"
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Friend documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
		Private WithEvents tabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView





	End Class
End Namespace

