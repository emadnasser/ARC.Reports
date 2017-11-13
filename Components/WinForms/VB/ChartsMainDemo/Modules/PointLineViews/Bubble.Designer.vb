Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class BubbleDemo
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
			Dim bubbleSeriesLabel1 As New DevExpress.XtraCharts.BubbleSeriesLabel()
			Dim bubbleSeriesView1 As New DevExpress.XtraCharts.BubbleSeriesView()
			Dim xyMarkerWidenAnimation1 As New DevExpress.XtraCharts.XYMarkerWidenAnimation()
			Dim bubbleSeriesLabel2 As New DevExpress.XtraCharts.BubbleSeriesLabel()
			Dim bubbleSeriesView2 As New DevExpress.XtraCharts.BubbleSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.lblMarkerKind = New DevExpress.XtraEditors.LabelControl()
			Me.lblLabelPosition = New DevExpress.XtraEditors.LabelControl()
			Me.lblMaxSize = New DevExpress.XtraEditors.LabelControl()
			Me.lblMinSize = New DevExpress.XtraEditors.LabelControl()
			Me.speMinSize = New DevExpress.XtraEditors.SpinEdit()
			Me.speMaxSize = New DevExpress.XtraEditors.SpinEdit()
			Me.cbeLabelPosition = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbeMarkerKind = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbeTransparency = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblTransparency = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(bubbleSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(bubbleSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(bubbleSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(bubbleSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.speMinSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.speMaxSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeLabelPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeTransparency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.cbeTransparency)
			Me.panel.Controls.Add(Me.lblTransparency)
			Me.panel.Controls.Add(Me.cbeMarkerKind)
			Me.panel.Controls.Add(Me.lblMarkerKind)
			Me.panel.Controls.Add(Me.speMaxSize)
			Me.panel.Controls.Add(Me.cbeLabelPosition)
			Me.panel.Controls.Add(Me.speMinSize)
			Me.panel.Controls.Add(Me.lblMinSize)
			Me.panel.Controls.Add(Me.lblMaxSize)
			Me.panel.Controls.Add(Me.lblLabelPosition)
			Me.panel.Controls.SetChildIndex(Me.lblLabelPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.lblMaxSize, 0)
			Me.panel.Controls.SetChildIndex(Me.lblMinSize, 0)
			Me.panel.Controls.SetChildIndex(Me.speMinSize, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeLabelPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.speMaxSize, 0)
			Me.panel.Controls.SetChildIndex(Me.lblMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.lblTransparency, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeTransparency, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None
			xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
			xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year
			xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Interlaced = True
			xyDiagram1.AxisX.Label.TextPattern = "{A:yyyy}"
			xyDiagram1.AxisX.Tickmarks.MinorVisible = False
			xyDiagram1.AxisX.Title.Text = "Year"
			xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.VisualRange.Auto = False
			xyDiagram1.AxisX.VisualRange.AutoSideMargins = False
			xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "01/01/2016 00:00:00.000"
			xyDiagram1.AxisX.VisualRange.MinValueSerializable = "01/01/2007 00:00:00.000"
			xyDiagram1.AxisX.VisualRange.SideMarginsValue = 0.7R
			xyDiagram1.AxisX.WholeRange.Auto = False
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "01/01/2016 00:00:00.000"
			xyDiagram1.AxisX.WholeRange.MinValueSerializable = "01/01/2007 00:00:00.000"
			xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0.8R
			xyDiagram1.AxisY.Label.TextPattern = "${V}M"
			xyDiagram1.AxisY.Title.Text = "Production Budget"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisualRange.Auto = False
			xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "310"
			xyDiagram1.AxisY.VisualRange.MinValueSerializable = "130"
			xyDiagram1.AxisY.WholeRange.Auto = False
			xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "370"
			xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
			Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "Year"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			bubbleSeriesLabel1.TextPattern = "${W}B"
			series1.Label = bubbleSeriesLabel1
			series1.LegendTextPattern = "{A}"
			series1.Name = "Top 10 Films by Worldwide Grosses "
			series1.ValueDataMembersSerializable = "Budget;Grosses"
			bubbleSeriesView1.AutoSize = False
			bubbleSeriesView1.ColorEach = True
			bubbleSeriesView1.MaxSize = 2.7R
			bubbleSeriesView1.MinSize = 0.8R
			xyMarkerWidenAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
			xyMarkerWidenAnimation1.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random
			bubbleSeriesView1.SeriesPointAnimation = xyMarkerWidenAnimation1
			series1.View = bubbleSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			bubbleSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.Label = bubbleSeriesLabel2
			Me.chart.SeriesTemplate.View = bubbleSeriesView2
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 2
			chartTitle1.Text = "Highest-Grossing Films by Year"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.boxofficemojo.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
'			Me.chart.CustomDrawSeriesPoint += New DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(Me.chart_CustomDrawSeriesPoint);
			' 
			' lblMarkerKind
			' 
			Me.lblMarkerKind.Location = New System.Drawing.Point(13, 40)
			Me.lblMarkerKind.Name = "lblMarkerKind"
			Me.lblMarkerKind.Size = New System.Drawing.Size(60, 13)
			Me.lblMarkerKind.TabIndex = 2
			Me.lblMarkerKind.Text = "Marker Kind:"
			' 
			' lblLabelPosition
			' 
			Me.lblLabelPosition.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.lblLabelPosition.Location = New System.Drawing.Point(550, 12)
			Me.lblLabelPosition.Name = "lblLabelPosition"
			Me.lblLabelPosition.Size = New System.Drawing.Size(69, 13)
			Me.lblLabelPosition.TabIndex = 3
			Me.lblLabelPosition.Text = "Label Position:"
			' 
			' lblMaxSize
			' 
			Me.lblMaxSize.Location = New System.Drawing.Point(207, 12)
			Me.lblMaxSize.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
			Me.lblMaxSize.Name = "lblMaxSize"
			Me.lblMaxSize.Size = New System.Drawing.Size(81, 13)
			Me.lblMaxSize.TabIndex = 4
			Me.lblMaxSize.Text = "Max Bubble Size:"
			' 
			' lblMinSize
			' 
			Me.lblMinSize.Location = New System.Drawing.Point(207, 40)
			Me.lblMinSize.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
			Me.lblMinSize.Name = "lblMinSize"
			Me.lblMinSize.Size = New System.Drawing.Size(77, 13)
			Me.lblMinSize.TabIndex = 5
			Me.lblMinSize.Text = "Min Bubble Size:"
			' 
			' speMinSize
			' 
			Me.speMinSize.EditValue = New Decimal(New Integer() { 8, 0, 0, 65536})
			Me.speMinSize.Location = New System.Drawing.Point(294, 37)
			Me.speMinSize.Name = "speMinSize"
			Me.speMinSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.speMinSize.Properties.Increment = New Decimal(New Integer() { 1, 0, 0, 65536})
			Me.speMinSize.Properties.MaxValue = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.speMinSize.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 65536})
			Me.speMinSize.Properties.ValidateOnEnterKey = True
			Me.speMinSize.Size = New System.Drawing.Size(54, 20)
			Me.speMinSize.TabIndex = 6
'			Me.speMinSize.EditValueChanged += New System.EventHandler(Me.speMinSize_EditValueChanged);
'			Me.speMinSize.EditValueChanging += New DevExpress.XtraEditors.Controls.ChangingEventHandler(Me.speMinSize_EditValueChanging);
			' 
			' speMaxSize
			' 
			Me.speMaxSize.EditValue = New Decimal(New Integer() { 27, 0, 0, 65536})
			Me.speMaxSize.Location = New System.Drawing.Point(294, 9)
			Me.speMaxSize.Name = "speMaxSize"
			Me.speMaxSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.speMaxSize.Properties.Increment = New Decimal(New Integer() { 1, 0, 0, 65536})
			Me.speMaxSize.Properties.MaxValue = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.speMaxSize.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 65536})
			Me.speMaxSize.Properties.ValidateOnEnterKey = True
			Me.speMaxSize.Size = New System.Drawing.Size(54, 20)
			Me.speMaxSize.TabIndex = 7
'			Me.speMaxSize.EditValueChanged += New System.EventHandler(Me.speMaxSize_EditValueChanged);
'			Me.speMaxSize.EditValueChanging += New DevExpress.XtraEditors.Controls.ChangingEventHandler(Me.speMaxSize_EditValueChanging);
			' 
			' cbeLabelPosition
			' 
			Me.cbeLabelPosition.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.cbeLabelPosition.Location = New System.Drawing.Point(625, 9)
			Me.cbeLabelPosition.Name = "cbeLabelPosition"
			Me.cbeLabelPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeLabelPosition.Properties.Items.AddRange(New Object() { "Center", "Outside"})
			Me.cbeLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeLabelPosition.Size = New System.Drawing.Size(60, 20)
			Me.cbeLabelPosition.TabIndex = 8
'			Me.cbeLabelPosition.SelectedIndexChanged += New System.EventHandler(Me.cbeLabelPosition_SelectedIndexChanged);
			' 
			' cbeMarkerKind
			' 
			Me.cbeMarkerKind.Location = New System.Drawing.Point(88, 37)
			Me.cbeMarkerKind.Name = "cbeMarkerKind"
			Me.cbeMarkerKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeMarkerKind.Size = New System.Drawing.Size(110, 20)
			Me.cbeMarkerKind.TabIndex = 9
'			Me.cbeMarkerKind.SelectedIndexChanged += New System.EventHandler(Me.cbeMarkerKind_SelectedIndexChanged);
			' 
			' cbeTransparency
			' 
			Me.cbeTransparency.Location = New System.Drawing.Point(88, 9)
			Me.cbeTransparency.Name = "cbeTransparency"
			Me.cbeTransparency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeTransparency.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeTransparency.Size = New System.Drawing.Size(110, 20)
			Me.cbeTransparency.TabIndex = 11
'			Me.cbeTransparency.SelectedIndexChanged += New System.EventHandler(Me.cbeTransparency_SelectedIndexChanged);
			' 
			' lblTransparency
			' 
			Me.lblTransparency.Location = New System.Drawing.Point(13, 12)
			Me.lblTransparency.Name = "lblTransparency"
			Me.lblTransparency.Size = New System.Drawing.Size(70, 13)
			Me.lblTransparency.TabIndex = 10
			Me.lblTransparency.Text = "Transparency:"
			' 
			' BubbleDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "BubbleDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(bubbleSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(bubbleSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(bubbleSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(bubbleSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.speMinSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.speMaxSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeLabelPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeTransparency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chart As ChartControl
		Private WithEvents cbeMarkerKind As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbeLabelPosition As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents speMinSize As DevExpress.XtraEditors.SpinEdit
		Private WithEvents speMaxSize As DevExpress.XtraEditors.SpinEdit
		Private lblMinSize As DevExpress.XtraEditors.LabelControl
		Private lblMaxSize As DevExpress.XtraEditors.LabelControl
		Private lblMarkerKind As DevExpress.XtraEditors.LabelControl
		Private lblLabelPosition As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbeTransparency As DevExpress.XtraEditors.ComboBoxEdit
		Private lblTransparency As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
