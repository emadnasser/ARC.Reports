Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraBars.Demos.DockingDemo
	Partial Public Class ucToolbox
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucToolbox))
			Me.navBar = New DevExpress.XtraNavBar.NavBarControl()
			Me.toolboxImages = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.navBar, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' navBar
			' 
			Me.navBar.ActiveGroup = Nothing
			Me.navBar.Dock = System.Windows.Forms.DockStyle.Fill
			Me.navBar.DragDropFlags = (CType(((DevExpress.XtraNavBar.NavBarDragDrop.AllowDrag Or DevExpress.XtraNavBar.NavBarDragDrop.AllowDrop) Or DevExpress.XtraNavBar.NavBarDragDrop.AllowOuterDrop), DevExpress.XtraNavBar.NavBarDragDrop))
			Me.navBar.Location = New System.Drawing.Point(0, 0)
			Me.navBar.Margin = New System.Windows.Forms.Padding(2)
			Me.navBar.Name = "navBar"
			Me.navBar.OptionsNavPane.ExpandedWidth = 139
			Me.navBar.Size = New System.Drawing.Size(139, 373)
			Me.navBar.StoreDefaultPaintStyleName = True
			Me.navBar.TabIndex = 3
			Me.navBar.Text = "navBarControl1"
			Me.navBar.SmallImages = toolboxImages
			' 
			' toolboxImages
			' 
			Me.toolboxImages.ImageStream = (CType(resources.GetObject("toolboxImages.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.toolboxImages.TransparentColor = System.Drawing.Color.Magenta
			Me.toolboxImages.Images.SetKeyName(0, "Label_684.png")
			Me.toolboxImages.Images.SetKeyName(1, "Button_668.png")
			Me.toolboxImages.Images.SetKeyName(2, "CheckBox_669.png")
			Me.toolboxImages.Images.SetKeyName(3, "RadioButton_701.png")
			Me.toolboxImages.Images.SetKeyName(4, "ComboBox_672.png")
			Me.toolboxImages.Images.SetKeyName(5, "ListBox_686.png")
			Me.toolboxImages.Images.SetKeyName(6, "CheckBoxList_727.png")
			Me.toolboxImages.Images.SetKeyName(7, "DataGrid_674.png")
			Me.toolboxImages.Images.SetKeyName(8, "ListView_687.png")
			Me.toolboxImages.Images.SetKeyName(9, "SplitterControl_705.png")
			Me.toolboxImages.Images.SetKeyName(10, "SplitContainerControl_704.png")
			Me.toolboxImages.Images.SetKeyName(11, "Panel_694.png")
			Me.toolboxImages.Images.SetKeyName(12, "TableLayoutPanel_6241.png")
			Me.toolboxImages.Images.SetKeyName(13, "GroupBox_680.png")
			Me.toolboxImages.Images.SetKeyName(14, "TabControl_707.png")
			Me.toolboxImages.Images.SetKeyName(15, "LabelControl_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(16, "SimpleButton_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(17, "CheckButton_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(18, "ToggleSwitch_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(19, "CheckEdit_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(20, "RadioGroup_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(21, "TextEdit_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(22, "MemoEdit_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(23, "ButtonEdit_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(24, "SpinEdit_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(25, "CalcEdit_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(26, "ColorEdit_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(27, "DateControl_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(28, "DateEdit_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(29, "TimeEdit_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(30, "LookUpEdit_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(31, "ListBoxControl_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(32, "PictureEdit_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(33, "RangeControl_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(34, "XtraTabControl_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(35, "BarManager_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(36, "DocumentManager_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(37, "PopupMenu_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(38, "RadialMenu_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(39, "TileControl_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(40, "GridControl_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(41, "GridLookUpEdit_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(42, "PdfViewer_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(43, "ChartControl_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(44, "SpreadsheetControl_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(45, "SchedulerControl_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(46, "PivotGridControl_DX.bmp")
			Me.toolboxImages.Images.SetKeyName(47, "MapControl_DX.bmp")
			' 
			' ucToolbox
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.navBar)
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "ucToolbox"
			Me.Size = New System.Drawing.Size(139, 373)
			CType(Me.navBar, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private navBar As XtraNavBar.NavBarControl
		Private toolboxImages As System.Windows.Forms.ImageList
	End Class
End Namespace
