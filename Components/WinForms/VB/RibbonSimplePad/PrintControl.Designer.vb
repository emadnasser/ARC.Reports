Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Ribbon
Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
	Partial Public Class PrintControl
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
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.ddbDuplex = New DevExpress.XtraEditors.DropDownButton()
			Me.printerLabel = New DevExpress.XtraBars.Demos.RibbonSimplePad.BackstageViewLabel()
			Me.ddbPrinter = New DevExpress.XtraEditors.DropDownButton()
			Me.copySpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.printButton = New DevExpress.XtraEditors.SimpleButton()
			Me.backstageViewLabel1 = New DevExpress.XtraBars.Demos.RibbonSimplePad.BackstageViewLabel()
			Me.backstageViewLabel2 = New DevExpress.XtraBars.Demos.RibbonSimplePad.BackstageViewLabel()
			Me.ddbOrientation = New DevExpress.XtraEditors.DropDownButton()
			Me.ddbPaperSize = New DevExpress.XtraEditors.DropDownButton()
			Me.ddbMargins = New DevExpress.XtraEditors.DropDownButton()
			Me.ddbCollate = New DevExpress.XtraEditors.DropDownButton()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciPrintButton = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciOrientation = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciMargins = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciPaperSize = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciPrintLabel = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciCopiesSpinEdit = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.lciSettingsLabel = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciPrinterLabel = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciPrinter = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciDuplex = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciCollated = New DevExpress.XtraLayout.LayoutControlItem()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.printControl1 = New DevExpress.XtraPrinting.Control.PrintControl()
            Me.panel1 = New AutoHeightPanel()
			Me.zoomTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.pageButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.zoomTrackBarControl1 = New DevExpress.XtraEditors.ZoomTrackBarControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.copySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPrintButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciOrientation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciMargins, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPaperSize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPrintLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCopiesSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciSettingsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPrinterLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciDuplex, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCollated, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel3.SuspendLayout()
			Me.panel1.SuspendLayout()
			CType(Me.zoomTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pageButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.zoomTrackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.zoomTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer1.IsSplitterFixed = True
			Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainer1.Name = "splitContainer1"
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.layoutControl1)
			Me.splitContainer1.Panel1MinSize = 280
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.panel3)
			Me.splitContainer1.Panel2.Controls.Add(Me.labelControl4)
			Me.splitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(3)
			Me.splitContainer1.Size = New System.Drawing.Size(1476, 679)
			Me.splitContainer1.SplitterDistance = 520
			Me.splitContainer1.TabIndex = 0
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.ddbDuplex)
			Me.layoutControl1.Controls.Add(Me.printerLabel)
			Me.layoutControl1.Controls.Add(Me.ddbPrinter)
			Me.layoutControl1.Controls.Add(Me.copySpinEdit)
			Me.layoutControl1.Controls.Add(Me.printButton)
			Me.layoutControl1.Controls.Add(Me.backstageViewLabel1)
			Me.layoutControl1.Controls.Add(Me.backstageViewLabel2)
			Me.layoutControl1.Controls.Add(Me.ddbOrientation)
			Me.layoutControl1.Controls.Add(Me.ddbPaperSize)
			Me.layoutControl1.Controls.Add(Me.ddbMargins)
			Me.layoutControl1.Controls.Add(Me.ddbCollate)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(532, 478, 648, 350)
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(520, 679)
			Me.layoutControl1.TabIndex = 5
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' ddbDuplex
			' 
			Me.ddbDuplex.Appearance.Options.UseTextOptions = True
			Me.ddbDuplex.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.ddbDuplex.Location = New System.Drawing.Point(12, 220)
			Me.ddbDuplex.Name = "ddbDuplex"
			Me.ddbDuplex.Size = New System.Drawing.Size(496, 52)
			Me.ddbDuplex.StyleController = Me.layoutControl1
			Me.ddbDuplex.TabIndex = 4
			Me.ddbDuplex.Text = "Print OneSided"
			' 
			' printerLabel
			' 
			Me.printerLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.printerLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.printerLabel.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
			Me.printerLabel.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
			Me.printerLabel.LineVisible = True
			Me.printerLabel.Location = New System.Drawing.Point(12, 92)
			Me.printerLabel.Name = "printerLabel"
			Me.printerLabel.ShowLineShadow = False
			Me.printerLabel.Size = New System.Drawing.Size(496, 32)
			Me.printerLabel.StyleController = Me.layoutControl1
			Me.printerLabel.TabIndex = 9
			Me.printerLabel.Text = "Printer"
			' 
			' ddbPrinter
			' 
			Me.ddbPrinter.Appearance.Options.UseTextOptions = True
			Me.ddbPrinter.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.ddbPrinter.Location = New System.Drawing.Point(12, 128)
			Me.ddbPrinter.Name = "ddbPrinter"
			Me.ddbPrinter.Size = New System.Drawing.Size(496, 52)
			Me.ddbPrinter.StyleController = Me.layoutControl1
			Me.ddbPrinter.TabIndex = 8
			Me.ddbPrinter.Text = "Printer"
			' 
			' copySpinEdit
			' 
			Me.copySpinEdit.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.copySpinEdit.Location = New System.Drawing.Point(154, 48)
			Me.copySpinEdit.Name = "copySpinEdit"
			Me.copySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.copySpinEdit.Properties.MaxValue = New Decimal(New Integer() { 30, 0, 0, 0})
			Me.copySpinEdit.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.copySpinEdit.Size = New System.Drawing.Size(100, 20)
			Me.copySpinEdit.StyleController = Me.layoutControl1
			Me.copySpinEdit.TabIndex = 6
			' 
			' printButton
			' 
            Me.printButton.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PrintDirectLarge
			Me.printButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
			Me.printButton.Location = New System.Drawing.Point(12, 12)
			Me.printButton.Name = "printButton"
			Me.printButton.Size = New System.Drawing.Size(80, 76)
			Me.printButton.StyleController = Me.layoutControl1
			Me.printButton.TabIndex = 4
			Me.printButton.Text = "Print"
'			Me.printButton.Click += New System.EventHandler(Me.printButton_Click);
			' 
			' backstageViewLabel1
			' 
			Me.backstageViewLabel1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.backstageViewLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.backstageViewLabel1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
			Me.backstageViewLabel1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
			Me.backstageViewLabel1.LineVisible = True
			Me.backstageViewLabel1.Location = New System.Drawing.Point(96, 12)
			Me.backstageViewLabel1.Name = "backstageViewLabel1"
			Me.backstageViewLabel1.Padding = New System.Windows.Forms.Padding(20)
			Me.backstageViewLabel1.ShowLineShadow = False
			Me.backstageViewLabel1.Size = New System.Drawing.Size(412, 32)
			Me.backstageViewLabel1.StyleController = Me.layoutControl1
			Me.backstageViewLabel1.TabIndex = 5
			Me.backstageViewLabel1.Text = "Print"
			' 
			' backstageViewLabel2
			' 
			Me.backstageViewLabel2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.backstageViewLabel2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.backstageViewLabel2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
			Me.backstageViewLabel2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
			Me.backstageViewLabel2.LineVisible = True
			Me.backstageViewLabel2.Location = New System.Drawing.Point(12, 184)
			Me.backstageViewLabel2.Name = "backstageViewLabel2"
			Me.backstageViewLabel2.ShowLineShadow = False
			Me.backstageViewLabel2.Size = New System.Drawing.Size(496, 32)
			Me.backstageViewLabel2.StyleController = Me.layoutControl1
			Me.backstageViewLabel2.TabIndex = 7
			Me.backstageViewLabel2.Text = "Settings"
			' 
			' ddbOrientation
			' 
			Me.ddbOrientation.Appearance.Options.UseTextOptions = True
			Me.ddbOrientation.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.ddbOrientation.Location = New System.Drawing.Point(12, 332)
			Me.ddbOrientation.Name = "ddbOrientation"
			Me.ddbOrientation.Size = New System.Drawing.Size(496, 52)
			Me.ddbOrientation.StyleController = Me.layoutControl1
			Me.ddbOrientation.TabIndex = 0
			Me.ddbOrientation.Text = "Orientation"
			' 
			' ddbPaperSize
			' 
			Me.ddbPaperSize.Appearance.Options.UseTextOptions = True
			Me.ddbPaperSize.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.ddbPaperSize.Location = New System.Drawing.Point(12, 444)
			Me.ddbPaperSize.Name = "ddbPaperSize"
			Me.ddbPaperSize.Size = New System.Drawing.Size(496, 52)
			Me.ddbPaperSize.StyleController = Me.layoutControl1
			Me.ddbPaperSize.TabIndex = 2
			Me.ddbPaperSize.Text = "Paper Size"
			' 
			' ddbMargins
			' 
			Me.ddbMargins.Appearance.Options.UseTextOptions = True
			Me.ddbMargins.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.ddbMargins.Location = New System.Drawing.Point(12, 388)
			Me.ddbMargins.Name = "ddbMargins"
			Me.ddbMargins.Size = New System.Drawing.Size(496, 52)
			Me.ddbMargins.StyleController = Me.layoutControl1
			Me.ddbMargins.TabIndex = 1
			Me.ddbMargins.Text = "Margins"
			' 
			' ddbCollate
			' 
			Me.ddbCollate.Appearance.Options.UseTextOptions = True
			Me.ddbCollate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.ddbCollate.Location = New System.Drawing.Point(12, 276)
			Me.ddbCollate.Name = "ddbCollate"
			Me.ddbCollate.Size = New System.Drawing.Size(496, 52)
			Me.ddbCollate.StyleController = Me.layoutControl1
			Me.ddbCollate.TabIndex = 3
			Me.ddbCollate.Text = "Collated"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciPrintButton, Me.lciOrientation, Me.lciMargins, Me.lciPaperSize, Me.lciPrintLabel, Me.lciCopiesSpinEdit, Me.emptySpaceItem1, Me.lciSettingsLabel, Me.lciPrinterLabel, Me.lciPrinter, Me.lciDuplex, Me.lciCollated})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(520, 679)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' lciPrintButton
			' 
			Me.lciPrintButton.Control = Me.printButton
			Me.lciPrintButton.CustomizationFormText = "lciPrintButton"
			Me.lciPrintButton.Location = New System.Drawing.Point(0, 0)
			Me.lciPrintButton.MaxSize = New System.Drawing.Size(84, 80)
			Me.lciPrintButton.MinSize = New System.Drawing.Size(84, 80)
			Me.lciPrintButton.Name = "lciPrintButton"
			Me.lciPrintButton.Size = New System.Drawing.Size(84, 80)
			Me.lciPrintButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciPrintButton.Text = "lciPrintButton"
			Me.lciPrintButton.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPrintButton.TextToControlDistance = 0
			Me.lciPrintButton.TextVisible = False
			' 
			' lciOrientation
			' 
			Me.lciOrientation.Control = Me.ddbOrientation
			Me.lciOrientation.CustomizationFormText = "lciOrientation"
			Me.lciOrientation.Location = New System.Drawing.Point(0, 320)
			Me.lciOrientation.MaxSize = New System.Drawing.Size(0, 56)
			Me.lciOrientation.MinSize = New System.Drawing.Size(100, 56)
			Me.lciOrientation.Name = "lciOrientation"
			Me.lciOrientation.Size = New System.Drawing.Size(500, 56)
			Me.lciOrientation.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciOrientation.Text = "lciOrientation"
			Me.lciOrientation.TextSize = New System.Drawing.Size(0, 0)
			Me.lciOrientation.TextToControlDistance = 0
			Me.lciOrientation.TextVisible = False
			' 
			' lciMargins
			' 
			Me.lciMargins.Control = Me.ddbMargins
			Me.lciMargins.CustomizationFormText = "lciMargins"
			Me.lciMargins.Location = New System.Drawing.Point(0, 376)
			Me.lciMargins.MaxSize = New System.Drawing.Size(0, 56)
			Me.lciMargins.MinSize = New System.Drawing.Size(100, 56)
			Me.lciMargins.Name = "lciMargins"
			Me.lciMargins.Size = New System.Drawing.Size(500, 56)
			Me.lciMargins.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciMargins.Text = "lciMargins"
			Me.lciMargins.TextSize = New System.Drawing.Size(0, 0)
			Me.lciMargins.TextToControlDistance = 0
			Me.lciMargins.TextVisible = False
			' 
			' lciPaperSize
			' 
			Me.lciPaperSize.Control = Me.ddbPaperSize
			Me.lciPaperSize.CustomizationFormText = "lciPaperSize"
			Me.lciPaperSize.Location = New System.Drawing.Point(0, 432)
			Me.lciPaperSize.MaxSize = New System.Drawing.Size(0, 56)
			Me.lciPaperSize.MinSize = New System.Drawing.Size(100, 56)
			Me.lciPaperSize.Name = "lciPaperSize"
			Me.lciPaperSize.Size = New System.Drawing.Size(500, 227)
			Me.lciPaperSize.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciPaperSize.Text = "lciPaperSize"
			Me.lciPaperSize.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPaperSize.TextToControlDistance = 0
			Me.lciPaperSize.TextVisible = False
			' 
			' lciPrintLabel
			' 
			Me.lciPrintLabel.Control = Me.backstageViewLabel1
			Me.lciPrintLabel.CustomizationFormText = "lciPrintLabel"
			Me.lciPrintLabel.Location = New System.Drawing.Point(84, 0)
			Me.lciPrintLabel.MaxSize = New System.Drawing.Size(0, 36)
			Me.lciPrintLabel.MinSize = New System.Drawing.Size(14, 36)
			Me.lciPrintLabel.Name = "lciPrintLabel"
			Me.lciPrintLabel.Size = New System.Drawing.Size(416, 36)
			Me.lciPrintLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciPrintLabel.Text = "lciPrintLabel"
			Me.lciPrintLabel.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPrintLabel.TextToControlDistance = 0
			Me.lciPrintLabel.TextVisible = False
			' 
			' lciCopiesSpinEdit
			' 
			Me.lciCopiesSpinEdit.Control = Me.copySpinEdit
			Me.lciCopiesSpinEdit.CustomizationFormText = "Copies:"
			Me.lciCopiesSpinEdit.Location = New System.Drawing.Point(84, 36)
			Me.lciCopiesSpinEdit.MaxSize = New System.Drawing.Size(180, 24)
			Me.lciCopiesSpinEdit.MinSize = New System.Drawing.Size(180, 24)
			Me.lciCopiesSpinEdit.Name = "lciCopiesSpinEdit"
			Me.lciCopiesSpinEdit.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 20, 2, 2)
			Me.lciCopiesSpinEdit.Size = New System.Drawing.Size(180, 44)
			Me.lciCopiesSpinEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciCopiesSpinEdit.Text = "Copies:"
			Me.lciCopiesSpinEdit.TextSize = New System.Drawing.Size(36, 13)
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(264, 36)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(236, 44)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' lciSettingsLabel
			' 
			Me.lciSettingsLabel.Control = Me.backstageViewLabel2
			Me.lciSettingsLabel.CustomizationFormText = "Settings"
			Me.lciSettingsLabel.Location = New System.Drawing.Point(0, 172)
			Me.lciSettingsLabel.MaxSize = New System.Drawing.Size(0, 36)
			Me.lciSettingsLabel.MinSize = New System.Drawing.Size(14, 36)
			Me.lciSettingsLabel.Name = "lciSettingsLabel"
			Me.lciSettingsLabel.Size = New System.Drawing.Size(500, 36)
			Me.lciSettingsLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciSettingsLabel.Text = "Settings"
			Me.lciSettingsLabel.TextSize = New System.Drawing.Size(0, 0)
			Me.lciSettingsLabel.TextToControlDistance = 0
			Me.lciSettingsLabel.TextVisible = False
			' 
			' lciPrinterLabel
			' 
			Me.lciPrinterLabel.Control = Me.printerLabel
			Me.lciPrinterLabel.CustomizationFormText = "lciPrinterLabel"
			Me.lciPrinterLabel.Location = New System.Drawing.Point(0, 80)
			Me.lciPrinterLabel.MaxSize = New System.Drawing.Size(0, 36)
			Me.lciPrinterLabel.MinSize = New System.Drawing.Size(14, 36)
			Me.lciPrinterLabel.Name = "lciPrinterLabel"
			Me.lciPrinterLabel.Size = New System.Drawing.Size(500, 36)
			Me.lciPrinterLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciPrinterLabel.Text = "lciPrinterLabel"
			Me.lciPrinterLabel.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPrinterLabel.TextToControlDistance = 0
			Me.lciPrinterLabel.TextVisible = False
			' 
			' lciPrinter
			' 
			Me.lciPrinter.Control = Me.ddbPrinter
			Me.lciPrinter.CustomizationFormText = "lciPrinter"
			Me.lciPrinter.Location = New System.Drawing.Point(0, 116)
			Me.lciPrinter.MaxSize = New System.Drawing.Size(0, 56)
			Me.lciPrinter.MinSize = New System.Drawing.Size(100, 56)
			Me.lciPrinter.Name = "lciPrinter"
			Me.lciPrinter.Size = New System.Drawing.Size(500, 56)
			Me.lciPrinter.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciPrinter.Text = "lciPrinter"
			Me.lciPrinter.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPrinter.TextToControlDistance = 0
			Me.lciPrinter.TextVisible = False
			' 
			' lciDuplex
			' 
			Me.lciDuplex.Control = Me.ddbDuplex
			Me.lciDuplex.CustomizationFormText = "lciDuplex"
			Me.lciDuplex.Location = New System.Drawing.Point(0, 208)
			Me.lciDuplex.MaxSize = New System.Drawing.Size(0, 56)
			Me.lciDuplex.MinSize = New System.Drawing.Size(68, 56)
			Me.lciDuplex.Name = "lciDuplex"
			Me.lciDuplex.Size = New System.Drawing.Size(500, 56)
			Me.lciDuplex.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciDuplex.Text = "lciDuplex"
			Me.lciDuplex.TextSize = New System.Drawing.Size(0, 0)
			Me.lciDuplex.TextToControlDistance = 0
			Me.lciDuplex.TextVisible = False
			' 
			' lciCollated
			' 
			Me.lciCollated.Control = Me.ddbCollate
			Me.lciCollated.CustomizationFormText = "lciPagePerSheet"
			Me.lciCollated.Location = New System.Drawing.Point(0, 264)
			Me.lciCollated.MaxSize = New System.Drawing.Size(0, 56)
			Me.lciCollated.MinSize = New System.Drawing.Size(100, 56)
			Me.lciCollated.Name = "lciCollated"
			Me.lciCollated.Size = New System.Drawing.Size(500, 56)
			Me.lciCollated.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciCollated.Text = "lciCollated"
			Me.lciCollated.TextSize = New System.Drawing.Size(0, 0)
			Me.lciCollated.TextToControlDistance = 0
			Me.lciCollated.TextVisible = False
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.printControl1)
			Me.panel3.Controls.Add(Me.panel1)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel3.Location = New System.Drawing.Point(7, 3)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(942, 673)
			Me.panel3.TabIndex = 2
			' 
			' printControl1
			' 
			Me.printControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.printControl1.ForeColor = System.Drawing.Color.Empty
			Me.printControl1.IsMetric = True
			Me.printControl1.Location = New System.Drawing.Point(0, 0)
			Me.printControl1.Name = "printControl1"
			Me.printControl1.Size = New System.Drawing.Size(942, 647)
			Me.printControl1.TabIndex = 0
			Me.printControl1.TooltipFont = New System.Drawing.Font("Tahoma", 8.25F)
'			Me.printControl1.SelectedPageChanged += New DevExpress.XtraPrinting.PageEventHandler(Me.printControl1_SelectedPageChanged);
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.zoomTextEdit)
			Me.panel1.Controls.Add(Me.pageButtonEdit)
			Me.panel1.Controls.Add(Me.panel2)
			Me.panel1.Controls.Add(Me.zoomTrackBarControl1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel1.Location = New System.Drawing.Point(0, 647)
			Me.panel1.Name = "panel1"
			Me.panel1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
			Me.panel1.Size = New System.Drawing.Size(942, 26)
			Me.panel1.TabIndex = 1
			' 
			' zoomTextEdit
			' 
			Me.zoomTextEdit.Dock = System.Windows.Forms.DockStyle.Right
			Me.zoomTextEdit.EditValue = (CShort(Fix(100)))
			Me.zoomTextEdit.Location = New System.Drawing.Point(645, 3)
			Me.zoomTextEdit.Name = "zoomTextEdit"
			Me.zoomTextEdit.Properties.DisplayFormat.FormatString = "{0}%"
			Me.zoomTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.zoomTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.zoomTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.zoomTextEdit.Size = New System.Drawing.Size(73, 20)
			Me.zoomTextEdit.TabIndex = 4
'			Me.zoomTextEdit.EditValueChanged += New System.EventHandler(Me.zoomTextEdit_EditValueChanged);
			' 
			' pageButtonEdit
			' 
			Me.pageButtonEdit.Dock = System.Windows.Forms.DockStyle.Left
			Me.pageButtonEdit.EditValue = "1"
			Me.pageButtonEdit.Location = New System.Drawing.Point(0, 3)
			Me.pageButtonEdit.Name = "pageButtonEdit"
			Me.pageButtonEdit.Properties.Appearance.Options.UseTextOptions = True
			Me.pageButtonEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.pageButtonEdit.Properties.AutoHeight = False
			Me.pageButtonEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pageButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Left, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right)})
			Me.pageButtonEdit.Properties.DisplayFormat.FormatString = "Page {0} of 1"
			Me.pageButtonEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.pageButtonEdit.Size = New System.Drawing.Size(118, 20)
			Me.pageButtonEdit.TabIndex = 3
'			Me.pageButtonEdit.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.pageButtonEdit_ButtonClick);
'			Me.pageButtonEdit.EditValueChanged += New System.EventHandler(Me.pageButtonEdit_EditValueChanged);
'			Me.pageButtonEdit.EditValueChanging += New DevExpress.XtraEditors.Controls.ChangingEventHandler(Me.pageButtonEdit_EditValueChanging);
			' 
			' panel2
			' 
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel2.Location = New System.Drawing.Point(718, 3)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(10, 20)
			Me.panel2.TabIndex = 1
			' 
			' zoomTrackBarControl1
			' 
			Me.zoomTrackBarControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.zoomTrackBarControl1.EditValue = 40
			Me.zoomTrackBarControl1.Location = New System.Drawing.Point(728, 3)
			Me.zoomTrackBarControl1.Name = "zoomTrackBarControl1"
			Me.zoomTrackBarControl1.Properties.Alignment = DevExpress.Utils.VertAlignment.Center
			Me.zoomTrackBarControl1.Properties.Maximum = 80
			Me.zoomTrackBarControl1.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.zoomTrackBarControl1.Properties.SmallChange = 2
			Me.zoomTrackBarControl1.Size = New System.Drawing.Size(214, 20)
			Me.zoomTrackBarControl1.TabIndex = 0
			Me.zoomTrackBarControl1.Value = 40
'			Me.zoomTrackBarControl1.EditValueChanged += New System.EventHandler(Me.zoomTrackBarControl1_EditValueChanged);
			' 
			' labelControl4
			' 
			Me.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl4.Dock = System.Windows.Forms.DockStyle.Left
			Me.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical
			Me.labelControl4.LineVisible = True
			Me.labelControl4.Location = New System.Drawing.Point(3, 3)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(4, 673)
			Me.labelControl4.TabIndex = 4
			' 
			' PrintControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.splitContainer1)
			Me.Name = "PrintControl"
			Me.Size = New System.Drawing.Size(1476, 679)
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.ResumeLayout(False)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.copySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPrintButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciOrientation, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciMargins, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPaperSize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPrintLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCopiesSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciSettingsLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPrinterLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPrinter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciDuplex, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCollated, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel3.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.zoomTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pageButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.zoomTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.zoomTrackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private WithEvents printControl1 As DevExpress.XtraPrinting.Control.PrintControl
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents zoomTrackBarControl1 As DevExpress.XtraEditors.ZoomTrackBarControl
		Private panel2 As System.Windows.Forms.Panel
		Private WithEvents pageButtonEdit As DevExpress.XtraEditors.ButtonEdit
		Private WithEvents zoomTextEdit As DevExpress.XtraEditors.TextEdit
		Private ddbOrientation As DevExpress.XtraEditors.DropDownButton
		Private ddbCollate As DevExpress.XtraEditors.DropDownButton
		Private ddbPaperSize As DevExpress.XtraEditors.DropDownButton
		Private ddbMargins As DevExpress.XtraEditors.DropDownButton
		Private WithEvents printButton As DevExpress.XtraEditors.SimpleButton
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private backstageViewLabel1 As BackstageViewLabel
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private lciPrintButton As DevExpress.XtraLayout.LayoutControlItem
		Private lciOrientation As DevExpress.XtraLayout.LayoutControlItem
		Private lciMargins As DevExpress.XtraLayout.LayoutControlItem
		Private lciPaperSize As DevExpress.XtraLayout.LayoutControlItem
		Private lciCollated As DevExpress.XtraLayout.LayoutControlItem
		Private lciPrintLabel As DevExpress.XtraLayout.LayoutControlItem
		Private copySpinEdit As DevExpress.XtraEditors.SpinEdit
		Private lciCopiesSpinEdit As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private backstageViewLabel2 As BackstageViewLabel
		Private lciSettingsLabel As DevExpress.XtraLayout.LayoutControlItem
		Private printerLabel As BackstageViewLabel
		Private ddbPrinter As DevExpress.XtraEditors.DropDownButton
		Private lciPrinterLabel As DevExpress.XtraLayout.LayoutControlItem
		Private lciPrinter As DevExpress.XtraLayout.LayoutControlItem
		Private ddbDuplex As DevExpress.XtraEditors.DropDownButton
		Private lciDuplex As DevExpress.XtraLayout.LayoutControlItem
		Private panel3 As System.Windows.Forms.Panel
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
