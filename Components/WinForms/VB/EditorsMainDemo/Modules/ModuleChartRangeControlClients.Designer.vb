Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleChartRangeControlClients
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
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
			Dim rangeControlRange1 As New DevExpress.XtraEditors.RangeControlRange()
			Dim rangeControlRange2 As New DevExpress.XtraEditors.RangeControlRange()
			Dim areaChartRangeControlClientView1 As New DevExpress.XtraEditors.AreaChartRangeControlClientView()
			Me.rangeControl1 = New DevExpress.XtraEditors.RangeControl()
			Me.numericClient = New DevExpress.XtraEditors.NumericChartRangeControlClient()
			Me.rangeControl = New DevExpress.XtraEditors.RangeControl()
			Me.dateTimeClient = New DevExpress.XtraEditors.DateTimeChartRangeControlClient()
			Me.comboBoxPalette = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.trackBarNumericSnapSpacing = New DevExpress.XtraEditors.TrackBarControl()
			Me.trackBarNumericGridSpacing = New DevExpress.XtraEditors.TrackBarControl()
			Me.trackBarDateTimeSnapSpacing = New DevExpress.XtraEditors.TrackBarControl()
			Me.trackBarDateTimeGridSpacing = New DevExpress.XtraEditors.TrackBarControl()
			Me.comboBoxDateTimeGridAlignment = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.checkEditNumericAuto = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEditDateTimeAuto = New DevExpress.XtraEditors.CheckEdit()
			Me.comboBoxDateTimeSnapAlignment = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.radioGroupView = New DevExpress.XtraEditors.RadioGroup()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.backgroundWorker1 = New System.ComponentModel.BackgroundWorker()
			CType(Me.numericClient, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateTimeClient, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxPalette.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.trackBarNumericSnapSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarNumericSnapSpacing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarNumericGridSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarNumericGridSpacing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarDateTimeSnapSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarDateTimeSnapSpacing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarDateTimeGridSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarDateTimeGridSpacing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxDateTimeGridAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditNumericAuto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditDateTimeAuto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxDateTimeSnapAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroupView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel1.SuspendLayout()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' rangeControl1
			' 
			Me.rangeControl1.Client = Me.numericClient
			Me.rangeControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.rangeControl1.Location = New System.Drawing.Point(3, 82)
			Me.rangeControl1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
			Me.rangeControl1.Name = "rangeControl1"
			rangeControlRange1.Maximum = 9R
			rangeControlRange1.Minimum = 0R
			rangeControlRange1.Owner = Me.rangeControl1
			Me.rangeControl1.SelectedRange = rangeControlRange1
			Me.rangeControl1.Size = New System.Drawing.Size(588, 150)
			Me.rangeControl1.TabIndex = 10
			' 
			' rangeControl
			' 
			Me.rangeControl.Client = Me.dateTimeClient
			Me.rangeControl.Dock = System.Windows.Forms.DockStyle.Top
			Me.rangeControl.Location = New System.Drawing.Point(3, 312)
			Me.rangeControl.Margin = New System.Windows.Forms.Padding(3, 40, 3, 3)
			Me.rangeControl.Name = "rangeControl"
			rangeControlRange2.Maximum = New System.DateTime(2014, 5, 8, 0, 0, 0, 0)
			rangeControlRange2.Minimum = New System.DateTime(2014, 4, 29, 0, 0, 0, 0)
			rangeControlRange2.Owner = Me.rangeControl
			Me.rangeControl.SelectedRange = rangeControlRange2
			Me.rangeControl.Size = New System.Drawing.Size(588, 150)
			Me.rangeControl.TabIndex = 0
			' 
			' dateTimeClient
			' 
			Me.dateTimeClient.DataProvider.TemplateView = areaChartRangeControlClientView1
			' 
			' comboBoxPalette
			' 
			Me.comboBoxPalette.Location = New System.Drawing.Point(726, 72)
			Me.comboBoxPalette.Name = "comboBoxPalette"
			Me.comboBoxPalette.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxPalette.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxPalette.Size = New System.Drawing.Size(163, 20)
			Me.comboBoxPalette.StyleController = Me.layoutControl1
			Me.comboBoxPalette.TabIndex = 1
'			Me.comboBoxPalette.SelectedIndexChanged += New System.EventHandler(Me.comboBoxPalette_SelectedIndexChanged);
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.trackBarNumericSnapSpacing)
			Me.layoutControl1.Controls.Add(Me.trackBarNumericGridSpacing)
			Me.layoutControl1.Controls.Add(Me.trackBarDateTimeSnapSpacing)
			Me.layoutControl1.Controls.Add(Me.trackBarDateTimeGridSpacing)
			Me.layoutControl1.Controls.Add(Me.comboBoxDateTimeGridAlignment)
			Me.layoutControl1.Controls.Add(Me.checkEditNumericAuto)
			Me.layoutControl1.Controls.Add(Me.checkEditDateTimeAuto)
			Me.layoutControl1.Controls.Add(Me.comboBoxDateTimeSnapAlignment)
			Me.layoutControl1.Controls.Add(Me.radioGroupView)
			Me.layoutControl1.Controls.Add(Me.comboBoxPalette)
			Me.layoutControl1.Controls.Add(Me.tableLayoutPanel1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(5, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2776, 241, 827, 631)
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(913, 603)
			Me.layoutControl1.TabIndex = 12
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' trackBarNumericSnapSpacing
			' 
			Me.trackBarNumericSnapSpacing.EditValue = 50000
			Me.trackBarNumericSnapSpacing.Location = New System.Drawing.Point(726, 207)
			Me.trackBarNumericSnapSpacing.Name = "trackBarNumericSnapSpacing"
			Me.trackBarNumericSnapSpacing.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.trackBarNumericSnapSpacing.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.trackBarNumericSnapSpacing.Properties.LargeChange = 10000
			Me.trackBarNumericSnapSpacing.Properties.Maximum = 100000
			Me.trackBarNumericSnapSpacing.Properties.Minimum = 50000
			Me.trackBarNumericSnapSpacing.Properties.ShowValueToolTip = True
			Me.trackBarNumericSnapSpacing.Properties.SmallChange = 10000
			Me.trackBarNumericSnapSpacing.Properties.TickFrequency = 10000
			Me.trackBarNumericSnapSpacing.Size = New System.Drawing.Size(163, 45)
			Me.trackBarNumericSnapSpacing.StyleController = Me.layoutControl1
			Me.trackBarNumericSnapSpacing.TabIndex = 14
			Me.trackBarNumericSnapSpacing.Value = 50000
'			Me.trackBarNumericSnapSpacing.EditValueChanged += New System.EventHandler(Me.trackBarNumericSnapSpacing_EditValueChanged);
'			Me.trackBarNumericSnapSpacing.EditValueChanging += New DevExpress.XtraEditors.Controls.ChangingEventHandler(Me.trackBarNumeric_EditValueChanging);
			' 
			' trackBarNumericGridSpacing
			' 
			Me.trackBarNumericGridSpacing.EditValue = 50000
			Me.trackBarNumericGridSpacing.Location = New System.Drawing.Point(726, 158)
			Me.trackBarNumericGridSpacing.Name = "trackBarNumericGridSpacing"
			Me.trackBarNumericGridSpacing.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.trackBarNumericGridSpacing.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.trackBarNumericGridSpacing.Properties.LargeChange = 10000
			Me.trackBarNumericGridSpacing.Properties.Maximum = 100000
			Me.trackBarNumericGridSpacing.Properties.Minimum = 50000
			Me.trackBarNumericGridSpacing.Properties.ShowValueToolTip = True
			Me.trackBarNumericGridSpacing.Properties.SmallChange = 10000
			Me.trackBarNumericGridSpacing.Properties.TickFrequency = 10000
			Me.trackBarNumericGridSpacing.Size = New System.Drawing.Size(163, 45)
			Me.trackBarNumericGridSpacing.StyleController = Me.layoutControl1
			Me.trackBarNumericGridSpacing.TabIndex = 13
			Me.trackBarNumericGridSpacing.Value = 50000
'			Me.trackBarNumericGridSpacing.EditValueChanged += New System.EventHandler(Me.trackBarNumericGridSpacing_EditValueChanged);
'			Me.trackBarNumericGridSpacing.EditValueChanging += New DevExpress.XtraEditors.Controls.ChangingEventHandler(Me.trackBarNumeric_EditValueChanging);
			' 
			' trackBarDateTimeSnapSpacing
			' 
			Me.trackBarDateTimeSnapSpacing.EditValue = 1
			Me.trackBarDateTimeSnapSpacing.Location = New System.Drawing.Point(726, 415)
			Me.trackBarDateTimeSnapSpacing.Name = "trackBarDateTimeSnapSpacing"
			Me.trackBarDateTimeSnapSpacing.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.trackBarDateTimeSnapSpacing.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.trackBarDateTimeSnapSpacing.Properties.LargeChange = 1
			Me.trackBarDateTimeSnapSpacing.Properties.Maximum = 6
			Me.trackBarDateTimeSnapSpacing.Properties.Minimum = 1
			Me.trackBarDateTimeSnapSpacing.Properties.ShowValueToolTip = True
			Me.trackBarDateTimeSnapSpacing.Size = New System.Drawing.Size(163, 45)
			Me.trackBarDateTimeSnapSpacing.StyleController = Me.layoutControl1
			Me.trackBarDateTimeSnapSpacing.TabIndex = 14
			Me.trackBarDateTimeSnapSpacing.Value = 1
'			Me.trackBarDateTimeSnapSpacing.EditValueChanged += New System.EventHandler(Me.trackBarDateTimeSnapSpacing_EditValueChanged);
			' 
			' trackBarDateTimeGridSpacing
			' 
			Me.trackBarDateTimeGridSpacing.EditValue = 1
			Me.trackBarDateTimeGridSpacing.Location = New System.Drawing.Point(726, 366)
			Me.trackBarDateTimeGridSpacing.Name = "trackBarDateTimeGridSpacing"
			Me.trackBarDateTimeGridSpacing.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.trackBarDateTimeGridSpacing.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.trackBarDateTimeGridSpacing.Properties.LargeChange = 1
			Me.trackBarDateTimeGridSpacing.Properties.Maximum = 6
			Me.trackBarDateTimeGridSpacing.Properties.Minimum = 1
			Me.trackBarDateTimeGridSpacing.Properties.ShowValueToolTip = True
			Me.trackBarDateTimeGridSpacing.Size = New System.Drawing.Size(163, 45)
			Me.trackBarDateTimeGridSpacing.StyleController = Me.layoutControl1
			Me.trackBarDateTimeGridSpacing.TabIndex = 13
			Me.trackBarDateTimeGridSpacing.Value = 1
'			Me.trackBarDateTimeGridSpacing.EditValueChanged += New System.EventHandler(Me.trackBarDateTimeGridSpacing_EditValueChanged);
			' 
			' comboBoxDateTimeGridAlignment
			' 
			Me.comboBoxDateTimeGridAlignment.Location = New System.Drawing.Point(726, 318)
			Me.comboBoxDateTimeGridAlignment.Name = "comboBoxDateTimeGridAlignment"
			Me.comboBoxDateTimeGridAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxDateTimeGridAlignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxDateTimeGridAlignment.Size = New System.Drawing.Size(163, 20)
			Me.comboBoxDateTimeGridAlignment.StyleController = Me.layoutControl1
			Me.comboBoxDateTimeGridAlignment.TabIndex = 1
'			Me.comboBoxDateTimeGridAlignment.SelectedIndexChanged += New System.EventHandler(Me.comboBoxDateTimeGridAlignment_SelectedIndexChanged);
			' 
			' checkEditNumericAuto
			' 
			Me.checkEditNumericAuto.Location = New System.Drawing.Point(646, 139)
			Me.checkEditNumericAuto.Name = "checkEditNumericAuto"
			Me.checkEditNumericAuto.Properties.Caption = "Automatic"
			Me.checkEditNumericAuto.Size = New System.Drawing.Size(243, 15)
			Me.checkEditNumericAuto.StyleController = Me.layoutControl1
			Me.checkEditNumericAuto.TabIndex = 8
'			Me.checkEditNumericAuto.CheckedChanged += New System.EventHandler(Me.checkEditNumericAuto_CheckedChanged);
			' 
			' checkEditDateTimeAuto
			' 
			Me.checkEditDateTimeAuto.Location = New System.Drawing.Point(646, 299)
			Me.checkEditDateTimeAuto.Name = "checkEditDateTimeAuto"
			Me.checkEditDateTimeAuto.Properties.Caption = "Automatic"
			Me.checkEditDateTimeAuto.Size = New System.Drawing.Size(243, 15)
			Me.checkEditDateTimeAuto.StyleController = Me.layoutControl1
			Me.checkEditDateTimeAuto.TabIndex = 8
'			Me.checkEditDateTimeAuto.CheckedChanged += New System.EventHandler(Me.checkEditDateTimeAuto_CheckedChanged);
			' 
			' comboBoxDateTimeSnapAlignment
			' 
			Me.comboBoxDateTimeSnapAlignment.Location = New System.Drawing.Point(726, 342)
			Me.comboBoxDateTimeSnapAlignment.Name = "comboBoxDateTimeSnapAlignment"
			Me.comboBoxDateTimeSnapAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxDateTimeSnapAlignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxDateTimeSnapAlignment.Size = New System.Drawing.Size(163, 20)
			Me.comboBoxDateTimeSnapAlignment.StyleController = Me.layoutControl1
			Me.comboBoxDateTimeSnapAlignment.TabIndex = 1
'			Me.comboBoxDateTimeSnapAlignment.SelectedIndexChanged += New System.EventHandler(Me.comboBoxDateTimeSnapAlignment_SelectedIndexChanged);
			' 
			' radioGroupView
			' 
			Me.radioGroupView.AutoSizeInLayoutControl = True
			Me.radioGroupView.Location = New System.Drawing.Point(646, 43)
			Me.radioGroupView.Name = "radioGroupView"
			Me.radioGroupView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Line"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Area")})
			Me.radioGroupView.Size = New System.Drawing.Size(243, 25)
			Me.radioGroupView.StyleController = Me.layoutControl1
			Me.radioGroupView.TabIndex = 13
'			Me.radioGroupView.SelectedIndexChanged += New System.EventHandler(Me.radioGroupView_SelectedIndexChanged);
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 1
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel1.Controls.Add(Me.rangeControl, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.rangeControl1, 0, 0)
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(24, 34)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 2
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(594, 545)
			Me.tableLayoutPanel1.TabIndex = 11
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4, Me.emptySpaceItem2, Me.layoutControlGroup5})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(913, 603)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.CustomizationFormText = "Template View"
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem3, Me.layoutControlItem2})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(622, 0)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(271, 96)
			Me.layoutControlGroup2.Text = "Template View"
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.comboBoxPalette
			Me.layoutControlItem3.CustomizationFormText = "Palette:"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 29)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(247, 24)
			Me.layoutControlItem3.Text = "Palette:"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(77, 13)
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.radioGroupView
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(247, 29)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlGroup3
			' 
			Me.layoutControlGroup3.CustomizationFormText = "Date-Time Client Options"
			Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem6, Me.layoutControlItem5, Me.layoutControlItem4, Me.layoutControlItem7, Me.layoutControlItem8})
			Me.layoutControlGroup3.Location = New System.Drawing.Point(622, 256)
			Me.layoutControlGroup3.Name = "layoutControlGroup3"
			Me.layoutControlGroup3.Size = New System.Drawing.Size(271, 208)
			Me.layoutControlGroup3.Text = "Date-Time Client Options"
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.comboBoxDateTimeSnapAlignment
			Me.layoutControlItem6.CustomizationFormText = "Snap Alignment:"
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 43)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(247, 24)
			Me.layoutControlItem6.Text = "Snap alignment:"
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(77, 13)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.comboBoxDateTimeGridAlignment
			Me.layoutControlItem5.CustomizationFormText = "Grid Alignment:"
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 19)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(247, 24)
			Me.layoutControlItem5.Text = "Grid alignment:"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(77, 13)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.checkEditDateTimeAuto
			Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(247, 19)
			Me.layoutControlItem4.Text = "layoutControlItem4"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextToControlDistance = 0
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.trackBarDateTimeGridSpacing
			Me.layoutControlItem7.CustomizationFormText = "Grid Spacing:"
			Me.layoutControlItem7.Location = New System.Drawing.Point(0, 67)
			Me.layoutControlItem7.Name = "layoutControlItem7"
			Me.layoutControlItem7.Size = New System.Drawing.Size(247, 49)
			Me.layoutControlItem7.Text = "Grid spacing:"
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(77, 13)
			' 
			' layoutControlItem8
			' 
			Me.layoutControlItem8.Control = Me.trackBarDateTimeSnapSpacing
			Me.layoutControlItem8.CustomizationFormText = "Snap Spacing:"
			Me.layoutControlItem8.Location = New System.Drawing.Point(0, 116)
			Me.layoutControlItem8.Name = "layoutControlItem8"
			Me.layoutControlItem8.Size = New System.Drawing.Size(247, 49)
			Me.layoutControlItem8.Text = "Snap spacing:"
			Me.layoutControlItem8.TextSize = New System.Drawing.Size(77, 13)
			' 
			' layoutControlGroup4
			' 
			Me.layoutControlGroup4.CustomizationFormText = "Numeric client options"
			Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem9, Me.layoutControlItem10, Me.layoutControlItem11})
			Me.layoutControlGroup4.Location = New System.Drawing.Point(622, 96)
			Me.layoutControlGroup4.Name = "layoutControlGroup4"
			Me.layoutControlGroup4.Size = New System.Drawing.Size(271, 160)
			Me.layoutControlGroup4.Text = "Numeric client options"
			' 
			' layoutControlItem9
			' 
			Me.layoutControlItem9.Control = Me.trackBarNumericGridSpacing
			Me.layoutControlItem9.CustomizationFormText = "Grid spacing:"
			Me.layoutControlItem9.Location = New System.Drawing.Point(0, 19)
			Me.layoutControlItem9.Name = "layoutControlItem9"
			Me.layoutControlItem9.Size = New System.Drawing.Size(247, 49)
			Me.layoutControlItem9.Text = "Grid spacing:"
			Me.layoutControlItem9.TextSize = New System.Drawing.Size(77, 13)
			' 
			' layoutControlItem10
			' 
			Me.layoutControlItem10.Control = Me.trackBarNumericSnapSpacing
			Me.layoutControlItem10.CustomizationFormText = "Snap spacing:"
			Me.layoutControlItem10.Location = New System.Drawing.Point(0, 68)
			Me.layoutControlItem10.Name = "layoutControlItem10"
			Me.layoutControlItem10.Size = New System.Drawing.Size(247, 49)
			Me.layoutControlItem10.Text = "Snap spacing:"
			Me.layoutControlItem10.TextSize = New System.Drawing.Size(77, 13)
			' 
			' layoutControlItem11
			' 
			Me.layoutControlItem11.Control = Me.checkEditNumericAuto
			Me.layoutControlItem11.CustomizationFormText = "layoutControlItem11"
			Me.layoutControlItem11.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem11.Name = "layoutControlItem11"
			Me.layoutControlItem11.Size = New System.Drawing.Size(247, 19)
			Me.layoutControlItem11.Text = "layoutControlItem11"
			Me.layoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem11.TextToControlDistance = 0
			Me.layoutControlItem11.TextVisible = False
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
			Me.emptySpaceItem2.Location = New System.Drawing.Point(622, 464)
			Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(271, 0)
			Me.emptySpaceItem2.MinSize = New System.Drawing.Size(271, 10)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(271, 119)
			Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem2.Text = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlGroup5
			' 
			Me.layoutControlGroup5.CustomizationFormText = "Sample"
			Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1})
			Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup5.Name = "layoutControlGroup5"
			Me.layoutControlGroup5.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 0, 9)
			Me.layoutControlGroup5.Size = New System.Drawing.Size(622, 583)
			Me.layoutControlGroup5.Text = "Sample"
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.tableLayoutPanel1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(598, 549)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' ModuleChartRangeControlClients
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "ModuleChartRangeControlClients"
			Me.Size = New System.Drawing.Size(918, 608)
			CType(Me.numericClient, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateTimeClient, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxPalette.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.trackBarNumericSnapSpacing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarNumericSnapSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarNumericGridSpacing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarNumericGridSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarDateTimeSnapSpacing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarDateTimeSnapSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarDateTimeGridSpacing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarDateTimeGridSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxDateTimeGridAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditNumericAuto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditDateTimeAuto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxDateTimeSnapAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroupView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel1.ResumeLayout(False)
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private components As System.ComponentModel.IContainer = Nothing
		Private dateTimeClient As DateTimeChartRangeControlClient
		Private numericClient As NumericChartRangeControlClient
		Private WithEvents comboBoxPalette As ComboBoxEdit
		Private WithEvents comboBoxDateTimeGridAlignment As ComboBoxEdit
		Private WithEvents comboBoxDateTimeSnapAlignment As ComboBoxEdit
		Private WithEvents checkEditDateTimeAuto As CheckEdit
		Private layoutControl1 As XtraLayout.LayoutControl
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private WithEvents trackBarDateTimeSnapSpacing As TrackBarControl
		Private WithEvents trackBarDateTimeGridSpacing As TrackBarControl
		Private WithEvents radioGroupView As RadioGroup
		Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
		Private layoutControlItem3 As XtraLayout.LayoutControlItem
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private layoutControlGroup3 As XtraLayout.LayoutControlGroup
		Private layoutControlItem6 As XtraLayout.LayoutControlItem
		Private layoutControlItem5 As XtraLayout.LayoutControlItem
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private layoutControlItem7 As XtraLayout.LayoutControlItem
		Private layoutControlItem8 As XtraLayout.LayoutControlItem
		Private backgroundWorker1 As System.ComponentModel.BackgroundWorker
		Private WithEvents trackBarNumericSnapSpacing As TrackBarControl
		Private WithEvents trackBarNumericGridSpacing As TrackBarControl
		Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private rangeControl As RangeControl
		Private rangeControl1 As RangeControl
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private layoutControlGroup4 As XtraLayout.LayoutControlGroup
		Private layoutControlItem9 As XtraLayout.LayoutControlItem
		Private layoutControlItem10 As XtraLayout.LayoutControlItem
		Private layoutControlGroup5 As XtraLayout.LayoutControlGroup
		Private WithEvents checkEditNumericAuto As CheckEdit
		Private layoutControlItem11 As XtraLayout.LayoutControlItem
	End Class
End Namespace
