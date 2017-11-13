Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.CustomDraw
	Partial Public Class XYDiagramCustomPaintDemo
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim pointSeriesView1 As New DevExpress.XtraCharts.PointSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.simpleButtonRandom = New DevExpress.XtraEditors.SimpleButton()
			Me.cheAutoMode = New DevExpress.XtraEditors.CheckEdit()
			Me.lbSelectedPoints = New DevExpress.XtraEditors.ListBoxControl()
			Me.labelSelectedPoints = New DevExpress.XtraEditors.LabelControl()
			Me.panelSelectedPoints = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheAutoMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbSelectedPoints, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelSelectedPoints, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelSelectedPoints.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.panel.Controls.Add(Me.simpleButtonRandom)
			Me.panel.Controls.Add(Me.cheAutoMode)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.cheAutoMode, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.simpleButtonRandom, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chart.CacheToMemory = True
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.GridLines.MinorVisible = True
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Title.Text = "Arguments"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.MinorCount = 4
			xyDiagram1.AxisY.Title.Text = "Values"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chart.Diagram = xyDiagram1
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel1.Font = New System.Drawing.Font("Tahoma", 6F)
			pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			pointSeriesLabel1.TextPattern = "{V:F2}"
			series1.Label = pointSeriesLabel1
			series1.Name = "Random Series"
			series1.View = pointSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.Size = New System.Drawing.Size(547, 454)
			Me.chart.TabIndex = 2
			chartTitle1.Text = "Random Points Generator"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
'			Me.chart.CustomPaint += New DevExpress.XtraCharts.CustomPaintEventHandler(Me.chart_CustomPaint);
'			Me.chart.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.chart_MouseDown);
'			Me.chart.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.chart_MouseMove);
'			Me.chart.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.chart_MouseUp);
			' 
			' simpleButtonRandom
			' 
			Me.simpleButtonRandom.Location = New System.Drawing.Point(12, 8)
			Me.simpleButtonRandom.Name = "simpleButtonRandom"
			Me.simpleButtonRandom.Size = New System.Drawing.Size(85, 22)
			Me.simpleButtonRandom.TabIndex = 2
			Me.simpleButtonRandom.Text = "Create Points"
'			Me.simpleButtonRandom.Click += New System.EventHandler(Me.simpleButtonRandom_Click);
			' 
			' cheAutoMode
			' 
			Me.cheAutoMode.Location = New System.Drawing.Point(120, 9)
			Me.cheAutoMode.Name = "cheAutoMode"
			Me.cheAutoMode.Properties.Caption = "Auto Mode"
			Me.cheAutoMode.Size = New System.Drawing.Size(75, 19)
			Me.cheAutoMode.TabIndex = 3
'			Me.cheAutoMode.CheckedChanged += New System.EventHandler(Me.cheAutoMode_CheckedChanged);
			' 
			' lbSelectedPoints
			' 
			Me.lbSelectedPoints.Appearance.Font = New System.Drawing.Font("Courier New", 9F)
			Me.lbSelectedPoints.Appearance.Options.UseFont = True
			Me.lbSelectedPoints.Cursor = System.Windows.Forms.Cursors.Default
			Me.lbSelectedPoints.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lbSelectedPoints.Location = New System.Drawing.Point(2, 20)
			Me.lbSelectedPoints.Name = "lbSelectedPoints"
			Me.lbSelectedPoints.Size = New System.Drawing.Size(145, 432)
			Me.lbSelectedPoints.TabIndex = 1
			' 
			' labelSelectedPoints
			' 
			Me.labelSelectedPoints.Appearance.Options.UseTextOptions = True
			Me.labelSelectedPoints.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.labelSelectedPoints.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelSelectedPoints.Dock = System.Windows.Forms.DockStyle.Top
			Me.labelSelectedPoints.Location = New System.Drawing.Point(2, 2)
			Me.labelSelectedPoints.Name = "labelSelectedPoints"
			Me.labelSelectedPoints.Size = New System.Drawing.Size(145, 18)
			Me.labelSelectedPoints.TabIndex = 0
			Me.labelSelectedPoints.Text = "The cluster's points "
			' 
			' panelSelectedPoints
			' 
			Me.panelSelectedPoints.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.panelSelectedPoints.Controls.Add(Me.lbSelectedPoints)
			Me.panelSelectedPoints.Controls.Add(Me.labelSelectedPoints)
			Me.panelSelectedPoints.Dock = System.Windows.Forms.DockStyle.Right
			Me.panelSelectedPoints.Location = New System.Drawing.Point(551, 46)
			Me.panelSelectedPoints.Name = "panelSelectedPoints"
			Me.panelSelectedPoints.Size = New System.Drawing.Size(149, 454)
			Me.panelSelectedPoints.TabIndex = 3
			' 
			' XYDiagramCustomPaintDemo
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panelSelectedPoints)
			Me.Controls.Add(Me.chart)
			Me.Name = "XYDiagramCustomPaintDemo"
			Me.Controls.SetChildIndex(Me.chart, 0)
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.panelSelectedPoints, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheAutoMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbSelectedPoints, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelSelectedPoints, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelSelectedPoints.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chart As ChartControl
		Private WithEvents simpleButtonRandom As DevExpress.XtraEditors.SimpleButton
		Private WithEvents cheAutoMode As DevExpress.XtraEditors.CheckEdit
		Private lbSelectedPoints As DevExpress.XtraEditors.ListBoxControl
		Private labelSelectedPoints As DevExpress.XtraEditors.LabelControl
		Private panelSelectedPoints As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
