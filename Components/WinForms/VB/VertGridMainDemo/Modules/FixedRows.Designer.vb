Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class FixedRows
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(FixedRows))
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.cheAllowFixingNestedRows = New DevExpress.XtraEditors.CheckEdit()
			Me.numFixedLineWidth1 = New DevExpress.XtraEditors.SpinEdit()
			Me.label5 = New System.Windows.Forms.Label()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.menuItemImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
			Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.cheAllowFixingNestedRows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.numFixedLineWidth1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.cheAllowFixingNestedRows)
			Me.panelControl1.Controls.Add(Me.numFixedLineWidth1)
			Me.panelControl1.Controls.Add(Me.label5)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(650, 42)
			Me.panelControl1.TabIndex = 5
			' 
			' cheAllowFixingNestedRows
			' 
			Me.cheAllowFixingNestedRows.Location = New System.Drawing.Point(212, 11)
			Me.cheAllowFixingNestedRows.Name = "cheAllowFixingNestedRows"
			Me.cheAllowFixingNestedRows.Properties.AutoWidth = True
			Me.cheAllowFixingNestedRows.Properties.Caption = "Allow Fixing Nested Rows"
			Me.cheAllowFixingNestedRows.Size = New System.Drawing.Size(145, 19)
			Me.cheAllowFixingNestedRows.TabIndex = 4
			' 
			' numFixedLineWidth1
			' 
			Me.numFixedLineWidth1.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.numFixedLineWidth1.Location = New System.Drawing.Point(113, 10)
			Me.numFixedLineWidth1.Name = "numFixedLineWidth1"
			Me.numFixedLineWidth1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.numFixedLineWidth1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.numFixedLineWidth1.Properties.IsFloatValue = False
			Me.numFixedLineWidth1.Properties.Mask.EditMask = "N00"
			Me.numFixedLineWidth1.Properties.MaxValue = New Decimal(New Integer() { 12, 0, 0, 0})
			Me.numFixedLineWidth1.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.numFixedLineWidth1.Size = New System.Drawing.Size(72, 20)
			Me.numFixedLineWidth1.TabIndex = 3
'			Me.numFixedLineWidth1.EditValueChanged += New System.EventHandler(Me.numFixedLineWidth1_EditValueChanged)
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(11, 13)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(148, 16)
			Me.label5.TabIndex = 2
			Me.label5.Text = "Fixed Line Width:"
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 42)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(650, 8)
			Me.panelControl2.TabIndex = 6
			' 
			' menuItemImageList
			' 
			Me.menuItemImageList.ImageStream = (CType(resources.GetObject("menuItemImageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.menuItemImageList.TransparentColor = System.Drawing.Color.Transparent
			Me.menuItemImageList.Images.SetKeyName(0, "ShowCustomizationWinow.png")
			Me.menuItemImageList.Images.SetKeyName(1, "NotFixed.png")
			Me.menuItemImageList.Images.SetKeyName(2, "FixedTop.png")
			Me.menuItemImageList.Images.SetKeyName(3, "FixedBottom.png")
			' 
			' pictureEdit1
			' 
			Me.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left
			Me.pictureEdit1.EditValue = (CObj(resources.GetObject("pictureEdit1.EditValue")))
			Me.pictureEdit1.Location = New System.Drawing.Point(0, 50)
			Me.pictureEdit1.Name = "pictureEdit1"
			Me.pictureEdit1.Size = New System.Drawing.Size(200, 430)
			Me.pictureEdit1.TabIndex = 8
			' 
			' splitterControl1
			' 
			Me.splitterControl1.Location = New System.Drawing.Point(200, 50)
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(5, 430)
			Me.splitterControl1.TabIndex = 9
			Me.splitterControl1.TabStop = False
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGridControl1.Location = New System.Drawing.Point(205, 50)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.OptionsMenu.EnableContextMenu = True
			Me.propertyGridControl1.OptionsView.MinRowAutoHeight = 20
			Me.propertyGridControl1.Size = New System.Drawing.Size(445, 430)
			Me.propertyGridControl1.TabIndex = 11
'			Me.propertyGridControl1.PopupMenuShowing += New DevExpress.XtraVerticalGrid.Events.PopupMenuShowingEventHandler(Me.propertyGridControl1_PopupMenuShowing)
			' 
			' FixedRows
			' 
			Me.Controls.Add(Me.propertyGridControl1)
			Me.Controls.Add(Me.splitterControl1)
			Me.Controls.Add(Me.pictureEdit1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "FixedRows"
			Me.Size = New System.Drawing.Size(650, 480)
'			Me.Load += New System.EventHandler(Me.FixedRows_Load)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.cheAllowFixingNestedRows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.numFixedLineWidth1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private WithEvents numFixedLineWidth1 As DevExpress.XtraEditors.SpinEdit
		Private label5 As System.Windows.Forms.Label
		Private menuItemImageList As System.Windows.Forms.ImageList
		Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
		Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
		Private WithEvents propertyGridControl1 As PropertyGridControl
		Private cheAllowFixingNestedRows As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace
