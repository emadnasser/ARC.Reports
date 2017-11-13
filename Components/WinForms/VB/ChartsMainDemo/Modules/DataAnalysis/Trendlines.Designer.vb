Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.DataAnalysis
	Partial Public Class TrendlinesDemo
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim stockSeriesLabel1 As New DevExpress.XtraCharts.StockSeriesLabel()
			Dim stockSeriesView1 As New DevExpress.XtraCharts.StockSeriesView()
			Dim stockSeriesView2 As New DevExpress.XtraCharts.StockSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
			Me.btnDeleteAll = New DevExpress.XtraEditors.SimpleButton()
			Me.lblStartValueLevel = New DevExpress.XtraEditors.LabelControl()
			Me.lblEndValueLevel = New DevExpress.XtraEditors.LabelControl()
			Me.cbeEndValueLevel = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbeStarValueLevel = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cheExtrapolateToInfinity = New DevExpress.XtraEditors.CheckEdit()
			Me.ceColor = New DevExpress.XtraEditors.ColorEdit()
			Me.lblColor = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeEndValueLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeStarValueLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheExtrapolateToInfinity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.lblColor)
			Me.panel.Controls.Add(Me.ceColor)
			Me.panel.Controls.Add(Me.cheExtrapolateToInfinity)
			Me.panel.Controls.Add(Me.lblEndValueLevel)
			Me.panel.Controls.Add(Me.cbeStarValueLevel)
			Me.panel.Controls.Add(Me.cbeEndValueLevel)
			Me.panel.Controls.Add(Me.btnDeleteAll)
			Me.panel.Controls.Add(Me.lblStartValueLevel)
			Me.panel.Controls.Add(Me.btnDelete)
			Me.panel.Controls.SetChildIndex(Me.btnDelete, 0)
			Me.panel.Controls.SetChildIndex(Me.lblStartValueLevel, 0)
			Me.panel.Controls.SetChildIndex(Me.btnDeleteAll, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeEndValueLevel, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeStarValueLevel, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.lblEndValueLevel, 0)
			Me.panel.Controls.SetChildIndex(Me.cheExtrapolateToInfinity, 0)
			Me.panel.Controls.SetChildIndex(Me.ceColor, 0)
			Me.panel.Controls.SetChildIndex(Me.lblColor, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(507, 37)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.Visible = False
			' 
			' chart
			' 
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
			xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
			xyDiagram1.AxisX.DateTimeScaleOptions.GridSpacing = 0.5R
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Interlaced = True
			xyDiagram1.AxisX.Title.Text = "Date"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Title.Text = "US Dollars"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "Date"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			stockSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
			series1.Label = stockSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Apple Inc."
			series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
			series1.ValueDataMembersSerializable = "Low;High;Open;Close"
			stockSeriesView1.LevelLineLength = 0.3R
			series1.View = stockSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.View = stockSeriesView2
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 2
			chartTitle1.Text = "Stock Prices"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.quandl.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
'			Me.chart.BoundDataChanged += New DevExpress.XtraCharts.BoundDataChangedEventHandler(Me.chart_BoundDataChanged);
'			Me.chart.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.chart_KeyDown);
'			Me.chart.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.chart_MouseDown);
'			Me.chart.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.chart_MouseMove);
'			Me.chart.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.chart_MouseUp);
			' 
			' btnDelete
			' 
			Me.btnDelete.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnDelete.Location = New System.Drawing.Point(610, 7)
			Me.btnDelete.Name = "btnDelete"
			Me.btnDelete.Size = New System.Drawing.Size(75, 23)
			Me.btnDelete.TabIndex = 4
			Me.btnDelete.Text = "Delete"
'			Me.btnDelete.Click += New System.EventHandler(Me.btnDelete_Click);
			' 
			' btnDeleteAll
			' 
			Me.btnDeleteAll.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnDeleteAll.Location = New System.Drawing.Point(610, 35)
			Me.btnDeleteAll.Name = "btnDeleteAll"
			Me.btnDeleteAll.Size = New System.Drawing.Size(75, 23)
			Me.btnDeleteAll.TabIndex = 5
			Me.btnDeleteAll.Text = "Clear"
'			Me.btnDeleteAll.Click += New System.EventHandler(Me.btnDeleteAll_Click);
			' 
			' lblStartValueLevel
			' 
			Me.lblStartValueLevel.Location = New System.Drawing.Point(12, 12)
			Me.lblStartValueLevel.Name = "lblStartValueLevel"
			Me.lblStartValueLevel.Size = New System.Drawing.Size(85, 13)
			Me.lblStartValueLevel.TabIndex = 4
			Me.lblStartValueLevel.Text = "Start Value Level:"
			' 
			' lblEndValueLevel
			' 
			Me.lblEndValueLevel.Location = New System.Drawing.Point(12, 40)
			Me.lblEndValueLevel.Name = "lblEndValueLevel"
			Me.lblEndValueLevel.Size = New System.Drawing.Size(79, 13)
			Me.lblEndValueLevel.TabIndex = 5
			Me.lblEndValueLevel.Text = "End Value Level:"
			' 
			' cbeEndValueLevel
			' 
			Me.cbeEndValueLevel.Location = New System.Drawing.Point(103, 37)
			Me.cbeEndValueLevel.Name = "cbeEndValueLevel"
			Me.cbeEndValueLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeEndValueLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeEndValueLevel.Size = New System.Drawing.Size(70, 20)
			Me.cbeEndValueLevel.TabIndex = 1
'			Me.cbeEndValueLevel.SelectedIndexChanged += New System.EventHandler(Me.cbeEndValueLevel_SelectedIndexChanged);
			' 
			' cbeStarValueLevel
			' 
			Me.cbeStarValueLevel.Location = New System.Drawing.Point(103, 9)
			Me.cbeStarValueLevel.Name = "cbeStarValueLevel"
			Me.cbeStarValueLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeStarValueLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeStarValueLevel.Size = New System.Drawing.Size(70, 20)
			Me.cbeStarValueLevel.TabIndex = 0
'			Me.cbeStarValueLevel.SelectedIndexChanged += New System.EventHandler(Me.cbeStarValueLevel_SelectedIndexChanged);
			' 
			' cheExtrapolateToInfinity
			' 
			Me.cheExtrapolateToInfinity.EditValue = True
			Me.cheExtrapolateToInfinity.Location = New System.Drawing.Point(190, 37)
			Me.cheExtrapolateToInfinity.Name = "cheExtrapolateToInfinity"
			Me.cheExtrapolateToInfinity.Properties.Caption = "Extrapolate to Infinity"
			Me.cheExtrapolateToInfinity.Size = New System.Drawing.Size(144, 19)
			Me.cheExtrapolateToInfinity.TabIndex = 3
'			Me.cheExtrapolateToInfinity.CheckedChanged += New System.EventHandler(Me.cheExtrapolateToInfinity_CheckedChanged);
			' 
			' ceColor
			' 
			Me.ceColor.EditValue = System.Drawing.Color.Empty
			Me.ceColor.Location = New System.Drawing.Point(225, 9)
			Me.ceColor.Name = "ceColor"
			Me.ceColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
'			Me.ceColor.Properties.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.ceColor_Properties_ButtonClick);
			Me.ceColor.Size = New System.Drawing.Size(154, 20)
			Me.ceColor.TabIndex = 2
'			Me.ceColor.EditValueChanged += New System.EventHandler(Me.ceColor_EditValueChanged);
'			Me.ceColor.CustomDisplayText += New DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(Me.ceColor_CustomDisplayText);
			' 
			' lblColor
			' 
			Me.lblColor.Location = New System.Drawing.Point(190, 12)
			Me.lblColor.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
			Me.lblColor.Name = "lblColor"
			Me.lblColor.Size = New System.Drawing.Size(29, 13)
			Me.lblColor.TabIndex = 10
			Me.lblColor.Text = "Color:"
			' 
			' TrendlinesDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "TrendlinesDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeEndValueLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeStarValueLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheExtrapolateToInfinity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chart As ChartControl
		Private WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnDeleteAll As DevExpress.XtraEditors.SimpleButton
		Private lblEndValueLevel As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbeStarValueLevel As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbeEndValueLevel As DevExpress.XtraEditors.ComboBoxEdit
		Private lblStartValueLevel As DevExpress.XtraEditors.LabelControl
		Private WithEvents cheExtrapolateToInfinity As DevExpress.XtraEditors.CheckEdit
		Private lblColor As DevExpress.XtraEditors.LabelControl
		Private WithEvents ceColor As DevExpress.XtraEditors.ColorEdit
	End Class
End Namespace
