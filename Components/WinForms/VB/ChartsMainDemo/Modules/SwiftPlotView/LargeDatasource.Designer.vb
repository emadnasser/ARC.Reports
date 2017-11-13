Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.SwiftPlotView
	Partial Public Class LargeDataSourceDemo
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
			Dim swiftPlotDiagram1 As New DevExpress.XtraCharts.SwiftPlotDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim swiftPlotSeriesView1 As New DevExpress.XtraCharts.SwiftPlotSeriesView()
			Me.cmbPointCount = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblPointCount = New DevExpress.XtraEditors.LabelControl()
			Me.btnApply = New DevExpress.XtraEditors.SimpleButton()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.cmbPointCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(swiftPlotDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(swiftPlotSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.lblPointCount)
			Me.panel.Controls.Add(Me.cmbPointCount)
			Me.panel.Controls.Add(Me.btnApply)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.btnApply, 0)
			Me.panel.Controls.SetChildIndex(Me.cmbPointCount, 0)
			Me.panel.Controls.SetChildIndex(Me.lblPointCount, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(597, 37)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.Visible = False
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' cmbPointCount
			' 
			Me.cmbPointCount.Location = New System.Drawing.Point(76, 9)
			Me.cmbPointCount.Name = "cmbPointCount"
			Me.cmbPointCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbPointCount.Properties.DisplayFormat.FormatString = "N0"
			Me.cmbPointCount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
			Me.cmbPointCount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
'			Me.cmbPointCount.Properties.DrawItem += New DevExpress.XtraEditors.ListBoxDrawItemEventHandler(Me.cmbPointCount_Properties_DrawItem);
			Me.cmbPointCount.Size = New System.Drawing.Size(79, 20)
			Me.cmbPointCount.TabIndex = 2
'			Me.cmbPointCount.SelectedIndexChanged += New System.EventHandler(Me.cmbPointCount_SelectedIndexChanged);
			' 
			' lblPointCount
			' 
			Me.lblPointCount.Location = New System.Drawing.Point(12, 12)
			Me.lblPointCount.Name = "lblPointCount"
			Me.lblPointCount.Size = New System.Drawing.Size(58, 13)
			Me.lblPointCount.TabIndex = 3
			Me.lblPointCount.Text = "Point count:"
			' 
			' btnApply
			' 
			Me.btnApply.Enabled = False
			Me.btnApply.Location = New System.Drawing.Point(170, 8)
			Me.btnApply.Name = "btnApply"
			Me.btnApply.Size = New System.Drawing.Size(75, 22)
			Me.btnApply.TabIndex = 4
			Me.btnApply.Text = "Apply"
'			Me.btnApply.Click += New System.EventHandler(Me.btnApply_Click);
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			swiftPlotDiagram1.AxisX.Label.TextPattern = "{A:N0}"
			swiftPlotDiagram1.AxisX.Title.Text = "Arguments"
			swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			swiftPlotDiagram1.AxisX.VisualRange.Auto = False
			swiftPlotDiagram1.AxisX.VisualRange.AutoSideMargins = False
			swiftPlotDiagram1.AxisX.VisualRange.MaxValueSerializable = "9"
			swiftPlotDiagram1.AxisX.VisualRange.MinValueSerializable = "0"
			swiftPlotDiagram1.AxisX.VisualRange.SideMarginsValue = 0R
			swiftPlotDiagram1.AxisX.WholeRange.AutoSideMargins = False
			swiftPlotDiagram1.AxisX.WholeRange.SideMarginsValue = 0R
			swiftPlotDiagram1.AxisY.Interlaced = True
			swiftPlotDiagram1.AxisY.Title.Text = "Values"
			swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			swiftPlotDiagram1.EnableAxisXScrolling = True
			swiftPlotDiagram1.EnableAxisYScrolling = True
			Me.chart.Diagram = swiftPlotDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series1.Name = "Series 1"
			series1.View = swiftPlotSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 3
			' 
			' LargeDataSourceDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "LargeDataSourceDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.cmbPointCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(swiftPlotDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(swiftPlotSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents cmbPointCount As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents btnApply As DevExpress.XtraEditors.SimpleButton
		Private lblPointCount As DevExpress.XtraEditors.LabelControl
		Private chart As ChartControl
	End Class
End Namespace
