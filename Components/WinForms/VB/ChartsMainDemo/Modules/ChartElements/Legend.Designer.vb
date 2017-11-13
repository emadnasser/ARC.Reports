Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class LegendDemo
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesView1 As New DevExpress.XtraCharts.PointSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesView2 As New DevExpress.XtraCharts.PointSeriesView()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesView3 As New DevExpress.XtraCharts.PointSeriesView()
			Dim series4 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesView4 As New DevExpress.XtraCharts.PointSeriesView()
			Dim series5 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesView5 As New DevExpress.XtraCharts.PointSeriesView()
			Dim series6 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesView6 As New DevExpress.XtraCharts.PointSeriesView()
			Dim series7 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesView7 As New DevExpress.XtraCharts.PointSeriesView()
			Dim series8 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesView8 As New DevExpress.XtraCharts.PointSeriesView()
			Dim series9 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesView9 As New DevExpress.XtraCharts.PointSeriesView()
			Dim series10 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesView10 As New DevExpress.XtraCharts.PointSeriesView()
			Dim series11 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesView11 As New DevExpress.XtraCharts.PointSeriesView()
			Dim series12 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesView12 As New DevExpress.XtraCharts.PointSeriesView()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.cmbMaxVertPercentage = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cmbMaxHorPercentage = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbEquallySpacedItems = New DevExpress.XtraEditors.CheckEdit()
			Me.cbDirection = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelSeriesDataMemberlabelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.cbHorAlign = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbVertAlign = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbMaxVertPercentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbMaxHorPercentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbEquallySpacedItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbDirection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbHorAlign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbVertAlign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelSeriesDataMemberlabelControl3)
			Me.panel.Controls.Add(Me.labelControl2)
			Me.panel.Controls.Add(Me.label1)
			Me.panel.Controls.Add(Me.cmbMaxHorPercentage)
			Me.panel.Controls.Add(Me.labelControl1)
			Me.panel.Controls.Add(Me.cmbMaxVertPercentage)
			Me.panel.Controls.Add(Me.cbHorAlign)
			Me.panel.Controls.Add(Me.cbVertAlign)
			Me.panel.Controls.Add(Me.label4)
			Me.panel.Controls.Add(Me.cbDirection)
			Me.panel.Controls.Add(Me.cbEquallySpacedItems)
			Me.panel.Controls.SetChildIndex(Me.cbEquallySpacedItems, 0)
			Me.panel.Controls.SetChildIndex(Me.cbDirection, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.label4, 0)
			Me.panel.Controls.SetChildIndex(Me.cbVertAlign, 0)
			Me.panel.Controls.SetChildIndex(Me.cbHorAlign, 0)
			Me.panel.Controls.SetChildIndex(Me.cmbMaxVertPercentage, 0)
			Me.panel.Controls.SetChildIndex(Me.labelControl1, 0)
			Me.panel.Controls.SetChildIndex(Me.cmbMaxHorPercentage, 0)
			Me.panel.Controls.SetChildIndex(Me.label1, 0)
			Me.panel.Controls.SetChildIndex(Me.labelControl2, 0)
			Me.panel.Controls.SetChildIndex(Me.labelSeriesDataMemberlabelControl3, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(451, 37)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 4
			' 
			' chart
			' 
			Me.chart.AutoLayout = False
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Cursor = System.Windows.Forms.Cursors.Default
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
			xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year
			xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Label.TextPattern = "{A}"
			xyDiagram1.AxisX.Title.Text = "Years"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Title.Text = ""
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.MaxHorizontalPercentage = 50R
			Me.chart.Legend.MaxVerticalPercentage = 50R
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series1.Name = "Series Name 1"
			series1.View = pointSeriesView1
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series2.Name = "Long Series Name 1"
			series2.View = pointSeriesView2
			series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series3.Name = "Very Long Series Name 1"
			series3.View = pointSeriesView3
			series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series4.Name = "Very Long Series Name 2"
			series4.View = pointSeriesView4
			series5.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series5.Name = "Long Series Name 2"
			series5.View = pointSeriesView5
			series6.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series6.Name = "Series Name 2"
			series6.View = pointSeriesView6
			series7.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series7.Name = "Series Name 3"
			series7.View = pointSeriesView7
			series8.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series8.Name = "Long Series Name 3"
			series8.View = pointSeriesView8
			series9.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series9.Name = "Very Long Series Name 3"
			series9.View = pointSeriesView9
			series10.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series10.Name = "Very Long Series Name 4"
			series10.View = pointSeriesView10
			series11.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series11.Name = "Long Series Name 4"
			series11.View = pointSeriesView11
			series12.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series12.Name = "Series Name 4"
			series12.View = pointSeriesView12
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3, series4, series5, series6, series7, series8, series9, series10, series11, series12}
			sideBySideBarSeriesLabel1.TextPattern = "{V:yyyy}"
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
'			Me.chart.VisibleChanged += New System.EventHandler(Me.chart_VisibleChanged);
			' 
			' cmbMaxVertPercentage
			' 
			Me.cmbMaxVertPercentage.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.cmbMaxVertPercentage.Location = New System.Drawing.Point(631, 37)
			Me.cmbMaxVertPercentage.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
			Me.cmbMaxVertPercentage.Name = "cmbMaxVertPercentage"
			Me.cmbMaxVertPercentage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbMaxVertPercentage.Properties.Items.AddRange(New Object() { "25%", "50%", "75%", "100%"})
			Me.cmbMaxVertPercentage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbMaxVertPercentage.Size = New System.Drawing.Size(57, 20)
			Me.cmbMaxVertPercentage.TabIndex = 6
'			Me.cmbMaxVertPercentage.SelectedIndexChanged += New System.EventHandler(Me.cmbMaxVertPercentage_SelectedIndexChanged);
			' 
			' cmbMaxHorPercentage
			' 
			Me.cmbMaxHorPercentage.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.cmbMaxHorPercentage.Location = New System.Drawing.Point(631, 9)
			Me.cmbMaxHorPercentage.Margin = New System.Windows.Forms.Padding(3, 0, 0, 10)
			Me.cmbMaxHorPercentage.Name = "cmbMaxHorPercentage"
			Me.cmbMaxHorPercentage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbMaxHorPercentage.Properties.HideSelection = False
			Me.cmbMaxHorPercentage.Properties.Items.AddRange(New Object() { "25%", "50%", "75%", "100%"})
			Me.cmbMaxHorPercentage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbMaxHorPercentage.Size = New System.Drawing.Size(57, 20)
			Me.cmbMaxHorPercentage.TabIndex = 5
'			Me.cmbMaxHorPercentage.SelectedIndexChanged += New System.EventHandler(Me.cmbMaxHorPercentage_SelectedIndexChanged);
			' 
			' cbEquallySpacedItems
			' 
			Me.cbEquallySpacedItems.Location = New System.Drawing.Point(240, 37)
			Me.cbEquallySpacedItems.Margin = New System.Windows.Forms.Padding(7)
			Me.cbEquallySpacedItems.Name = "cbEquallySpacedItems"
			Me.cbEquallySpacedItems.Properties.Caption = "Equally Spaced Items"
			Me.cbEquallySpacedItems.Size = New System.Drawing.Size(127, 19)
			Me.cbEquallySpacedItems.TabIndex = 3
'			Me.cbEquallySpacedItems.CheckedChanged += New System.EventHandler(Me.cbEquallySpacedItems_CheckedChanged);
			' 
			' cbDirection
			' 
			Me.cbDirection.EditValue = "Top To Bottom "
			Me.cbDirection.Location = New System.Drawing.Point(289, 9)
			Me.cbDirection.Margin = New System.Windows.Forms.Padding(3, 0, 10, 10)
			Me.cbDirection.Name = "cbDirection"
			Me.cbDirection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbDirection.Properties.HideSelection = False
			Me.cbDirection.Properties.Items.AddRange(New Object() { "Top To Bottom ", "Bottom To Top", "Left To Right", "Right To Left"})
			Me.cbDirection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbDirection.Size = New System.Drawing.Size(111, 20)
			Me.cbDirection.TabIndex = 2
'			Me.cbDirection.SelectedIndexChanged += New System.EventHandler(Me.cbDirection_SelectedIndexChanged);
			' 
			' labelSeriesDataMemberlabelControl3
			' 
			Me.labelSeriesDataMemberlabelControl3.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelSeriesDataMemberlabelControl3.Location = New System.Drawing.Point(567, 40)
			Me.labelSeriesDataMemberlabelControl3.Margin = New System.Windows.Forms.Padding(7)
			Me.labelSeriesDataMemberlabelControl3.Name = "labelSeriesDataMemberlabelControl3"
			Me.labelSeriesDataMemberlabelControl3.Size = New System.Drawing.Size(58, 13)
			Me.labelSeriesDataMemberlabelControl3.TabIndex = 17
			Me.labelSeriesDataMemberlabelControl3.Text = "Max Height:"
			' 
			' label1
			' 
			Me.label1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.label1.Location = New System.Drawing.Point(570, 12)
			Me.label1.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(55, 13)
			Me.label1.TabIndex = 17
			Me.label1.Text = "Max Width:"
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(240, 12)
			Me.label4.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(46, 13)
			Me.label4.TabIndex = 16
			Me.label4.Text = "Direction:"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(12, 40)
			Me.labelControl2.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(89, 13)
			Me.labelControl2.TabIndex = 20
			Me.labelControl2.Text = "Vertical Alignment:"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 12)
			Me.labelControl1.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(102, 13)
			Me.labelControl1.TabIndex = 19
			Me.labelControl1.Text = "Horizontal Alignment:"
			' 
			' cbHorAlign
			' 
			Me.cbHorAlign.EditValue = "Top Outside"
			Me.cbHorAlign.Location = New System.Drawing.Point(117, 9)
			Me.cbHorAlign.Margin = New System.Windows.Forms.Padding(3, 0, 10, 10)
			Me.cbHorAlign.Name = "cbHorAlign"
			Me.cbHorAlign.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbHorAlign.Properties.Items.AddRange(New Object() { "Left Outside", "Left", "Center", "Right", "Right Outside"})
			Me.cbHorAlign.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbHorAlign.Size = New System.Drawing.Size(102, 20)
			Me.cbHorAlign.TabIndex = 0
'			Me.cbHorAlign.SelectedIndexChanged += New System.EventHandler(Me.cbHorAlign_SelectedIndexChanged);
			' 
			' cbVertAlign
			' 
			Me.cbVertAlign.EditValue = "Left Outside"
			Me.cbVertAlign.Location = New System.Drawing.Point(117, 37)
			Me.cbVertAlign.Margin = New System.Windows.Forms.Padding(3, 10, 10, 0)
			Me.cbVertAlign.Name = "cbVertAlign"
			Me.cbVertAlign.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbVertAlign.Properties.HideSelection = False
			Me.cbVertAlign.Properties.Items.AddRange(New Object() { "Top Outside", "Top", "Center", "Bottom", "Bottom Outside"})
			Me.cbVertAlign.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbVertAlign.Size = New System.Drawing.Size(102, 20)
			Me.cbVertAlign.TabIndex = 1
'			Me.cbVertAlign.SelectedIndexChanged += New System.EventHandler(Me.cbVertAlign_SelectedIndexChanged);
			' 
			' LegendDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "LegendDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbMaxVertPercentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbMaxHorPercentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbEquallySpacedItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbDirection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbHorAlign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbVertAlign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents cmbMaxVertPercentage As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cmbMaxHorPercentage As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbEquallySpacedItems As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cbDirection As DevExpress.XtraEditors.ComboBoxEdit
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private labelSeriesDataMemberlabelControl3 As DevExpress.XtraEditors.LabelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbHorAlign As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbVertAlign As DevExpress.XtraEditors.ComboBoxEdit

	End Class
End Namespace
