Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class PointDemo
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
			Dim xyDiagram4 As New DevExpress.XtraCharts.XYDiagram()
			Dim series10 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel10 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim pointSeriesView10 As New DevExpress.XtraCharts.PointSeriesView()
			Dim xyMarkerWidenAnimation10 As New DevExpress.XtraCharts.XYMarkerWidenAnimation()
			Dim series11 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel11 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim pointSeriesView11 As New DevExpress.XtraCharts.PointSeriesView()
			Dim xyMarkerWidenAnimation11 As New DevExpress.XtraCharts.XYMarkerWidenAnimation()
			Dim series12 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel12 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim pointSeriesView12 As New DevExpress.XtraCharts.PointSeriesView()
			Dim xyMarkerWidenAnimation12 As New DevExpress.XtraCharts.XYMarkerWidenAnimation()
			Dim chartTitle4 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.simpleButtonRandom = New DevExpress.XtraEditors.SimpleButton()
			Me.cbeLabelPosition = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblLabelPosition = New DevExpress.XtraEditors.LabelControl()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditLabelAngle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeLabelPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboBoxEditMarkerKind
			' 
			Me.comboBoxEditMarkerKind.TabIndex = 1
			' 
			' comboBoxEditLabelAngle
			' 
			Me.comboBoxEditLabelAngle.Size = New System.Drawing.Size(72, 20)
			Me.comboBoxEditLabelAngle.TabIndex = 3
			' 
			' comboBoxEditMarkerSize
			' 
			Me.comboBoxEditMarkerSize.TabIndex = 2
			' 
			' labelMarkerKind
			' 
			Me.labelMarkerKind.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			' 
			' labelMarkerSize
			' 
			Me.labelMarkerSize.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.cbeLabelPosition)
			Me.panel.Controls.Add(Me.lblLabelPosition)
			Me.panel.Controls.Add(Me.simpleButtonRandom)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditLabelAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.labelAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.simpleButtonRandom, 0)
			Me.panel.Controls.SetChildIndex(Me.lblLabelPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeLabelPosition, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.checkEditShowLabels.Location = New System.Drawing.Point(351, 37)
			Me.checkEditShowLabels.TabIndex = 5
			' 
			' chart
			' 
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			xyDiagram4.AxisX.GridLines.MinorVisible = True
			xyDiagram4.AxisX.GridLines.Visible = True
			xyDiagram4.AxisX.Title.Text = "Arguments"
			xyDiagram4.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram4.AxisY.GridLines.MinorVisible = True
			xyDiagram4.AxisY.MinorCount = 4
			xyDiagram4.AxisY.Title.Text = "Values"
			xyDiagram4.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram4
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series10.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel10.Font = New System.Drawing.Font("Tahoma", 6F)
			series10.Label = pointSeriesLabel10
			series10.Name = "Population 1"
			xyMarkerWidenAnimation10.PointDelay = System.TimeSpan.Parse("00:00:00.0500000")
			xyMarkerWidenAnimation10.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random
			pointSeriesView10.SeriesPointAnimation = xyMarkerWidenAnimation10
			series10.View = pointSeriesView10
			series11.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel11.Font = New System.Drawing.Font("Tahoma", 6F)
			series11.Label = pointSeriesLabel11
			series11.Name = "Population 2"
			xyMarkerWidenAnimation11.PointDelay = System.TimeSpan.Parse("00:00:00.0500000")
			xyMarkerWidenAnimation11.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random
			pointSeriesView11.SeriesPointAnimation = xyMarkerWidenAnimation11
			series11.View = pointSeriesView11
			series12.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel12.Font = New System.Drawing.Font("Tahoma", 6F)
			series12.Label = pointSeriesLabel12
			series12.Name = "Population 3"
			xyMarkerWidenAnimation12.PointDelay = System.TimeSpan.Parse("00:00:00.0500000")
			xyMarkerWidenAnimation12.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random
			pointSeriesView12.SeriesPointAnimation = xyMarkerWidenAnimation12
			series12.View = pointSeriesView12
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series10, series11, series12}
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle4.Text = "Random Points Generator"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle4})
'			Me.chart.VisibleChanged += New System.EventHandler(Me.chart_VisibleChanged);
			' 
			' simpleButtonRandom
			' 
			Me.simpleButtonRandom.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.simpleButtonRandom.Location = New System.Drawing.Point(575, 14)
			Me.simpleButtonRandom.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
			Me.simpleButtonRandom.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.simpleButtonRandom.Name = "simpleButtonRandom"
			Me.simpleButtonRandom.Size = New System.Drawing.Size(110, 38)
			Me.simpleButtonRandom.TabIndex = 0
			Me.simpleButtonRandom.Text = "Create Points"
'			Me.simpleButtonRandom.Click += New System.EventHandler(Me.simpleButtonRandom_Click);
			' 
			' cbeLabelPosition
			' 
			Me.cbeLabelPosition.Location = New System.Drawing.Point(257, 37)
			Me.cbeLabelPosition.Name = "cbeLabelPosition"
			Me.cbeLabelPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeLabelPosition.Properties.Items.AddRange(New Object() { "Center", "Outside"})
			Me.cbeLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeLabelPosition.Size = New System.Drawing.Size(72, 20)
			Me.cbeLabelPosition.TabIndex = 56
'			Me.cbeLabelPosition.SelectedIndexChanged += New System.EventHandler(Me.cbeLabelPosition_SelectedIndexChanged);
			' 
			' lblLabelPosition
			' 
			Me.lblLabelPosition.Location = New System.Drawing.Point(182, 40)
			Me.lblLabelPosition.Name = "lblLabelPosition"
			Me.lblLabelPosition.Size = New System.Drawing.Size(69, 13)
			Me.lblLabelPosition.TabIndex = 55
			Me.lblLabelPosition.Text = "Label Position:"
			' 
			' PointDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "PointDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditLabelAngle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeLabelPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents cbeLabelPosition As XtraEditors.ComboBoxEdit
		Private lblLabelPosition As XtraEditors.LabelControl

	End Class
End Namespace
