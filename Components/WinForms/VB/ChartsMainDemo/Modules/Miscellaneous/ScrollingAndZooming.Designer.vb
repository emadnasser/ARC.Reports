Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class ScrollingAndZoomingDemo
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
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim stepLineSeriesView1 As New DevExpress.XtraCharts.StepLineSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.btnRestoreView = New DevExpress.XtraEditors.SimpleButton()
			Me.lblHorizontal = New DevExpress.XtraEditors.LabelControl()
			Me.lblVertical = New DevExpress.XtraEditors.LabelControl()
			Me.cbVertAlign = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbHorAlign = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbEnableAxisYScrolling = New DevExpress.XtraEditors.CheckEdit()
			Me.cbEnableAxisYZooming = New DevExpress.XtraEditors.CheckEdit()
			Me.cbEnableAxisXScrolling = New DevExpress.XtraEditors.CheckEdit()
			Me.cbEnableAxisXZooming = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stepLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbVertAlign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbHorAlign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbEnableAxisYScrolling.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbEnableAxisYZooming.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbEnableAxisXScrolling.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbEnableAxisXZooming.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.lblHorizontal)
			Me.panel.Controls.Add(Me.lblVertical)
			Me.panel.Controls.Add(Me.cbEnableAxisYZooming)
			Me.panel.Controls.Add(Me.cbEnableAxisXZooming)
			Me.panel.Controls.Add(Me.cbVertAlign)
			Me.panel.Controls.Add(Me.cbEnableAxisYScrolling)
			Me.panel.Controls.Add(Me.cbHorAlign)
			Me.panel.Controls.Add(Me.cbEnableAxisXScrolling)
			Me.panel.Controls.Add(Me.btnRestoreView)
			Me.panel.Controls.SetChildIndex(Me.btnRestoreView, 0)
			Me.panel.Controls.SetChildIndex(Me.cbEnableAxisXScrolling, 0)
			Me.panel.Controls.SetChildIndex(Me.cbHorAlign, 0)
			Me.panel.Controls.SetChildIndex(Me.cbEnableAxisYScrolling, 0)
			Me.panel.Controls.SetChildIndex(Me.cbVertAlign, 0)
			Me.panel.Controls.SetChildIndex(Me.cbEnableAxisXZooming, 0)
			Me.panel.Controls.SetChildIndex(Me.cbEnableAxisYZooming, 0)
			Me.panel.Controls.SetChildIndex(Me.lblVertical, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.lblHorizontal, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 6
			Me.checkEditShowLabels.Visible = False
			' 
			' chart
			' 
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Title.Text = "Year"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Interlaced = True
			xyDiagram1.AxisY.Title.Text = "$ per Thousand Cubic Feet"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisualRange.Auto = False
			xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "6"
			xyDiagram1.AxisY.VisualRange.MinValueSerializable = "2.25"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			xyDiagram1.EnableAxisXScrolling = True
			xyDiagram1.EnableAxisXZooming = True
			xyDiagram1.EnableAxisYScrolling = True
			xyDiagram1.EnableAxisYZooming = True
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "Date"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series1.Name = "Natural Gas Price"
			series1.ValueDataMembersSerializable = "Price"
			series1.View = lineSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			pointSeriesLabel1.TextPattern = "{V:G2}"
			Me.chart.SeriesTemplate.Label = pointSeriesLabel1
			Me.chart.SeriesTemplate.View = stepLineSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			chartTitle1.Text = "Price of Liquefied U.S. Natural Gas Exports"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.quandl.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' btnRestoreView
			' 
			Me.btnRestoreView.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnRestoreView.Location = New System.Drawing.Point(552, 24)
			Me.btnRestoreView.Margin = New System.Windows.Forms.Padding(10)
			Me.btnRestoreView.Name = "btnRestoreView"
			Me.btnRestoreView.Size = New System.Drawing.Size(138, 22)
			Me.btnRestoreView.TabIndex = 4
			Me.btnRestoreView.Text = "Restore Default Position"
'			Me.btnRestoreView.Click += New System.EventHandler(Me.btnRestoreView_Click);
			' 
			' lblHorizontal
			' 
			Me.lblHorizontal.Location = New System.Drawing.Point(229, 12)
			Me.lblHorizontal.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
			Me.lblHorizontal.Name = "lblHorizontal"
			Me.lblHorizontal.Size = New System.Drawing.Size(99, 13)
			Me.lblHorizontal.TabIndex = 16
			Me.lblHorizontal.Text = "Horizontal Scroll Bar:"
			' 
			' lblVertical
			' 
			Me.lblVertical.Location = New System.Drawing.Point(229, 40)
			Me.lblVertical.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
			Me.lblVertical.Name = "lblVertical"
			Me.lblVertical.Size = New System.Drawing.Size(86, 13)
			Me.lblVertical.TabIndex = 15
			Me.lblVertical.Text = "Vertical Scroll Bar:"
			' 
			' cbVertAlign
			' 
			Me.cbVertAlign.EditValue = ""
			Me.cbVertAlign.Location = New System.Drawing.Point(335, 37)
			Me.cbVertAlign.Margin = New System.Windows.Forms.Padding(4, 0, 10, 0)
			Me.cbVertAlign.Name = "cbVertAlign"
			Me.cbVertAlign.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbVertAlign.Properties.Items.AddRange(New Object() { "Near", "Far"})
			Me.cbVertAlign.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbVertAlign.Size = New System.Drawing.Size(56, 20)
			Me.cbVertAlign.TabIndex = 14
'			Me.cbVertAlign.SelectedIndexChanged += New System.EventHandler(Me.cbVertAlign_SelectedIndexChanged);
			' 
			' cbHorAlign
			' 
			Me.cbHorAlign.EditValue = ""
			Me.cbHorAlign.Location = New System.Drawing.Point(335, 9)
			Me.cbHorAlign.Margin = New System.Windows.Forms.Padding(4, 0, 10, 0)
			Me.cbHorAlign.Name = "cbHorAlign"
			Me.cbHorAlign.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbHorAlign.Properties.Items.AddRange(New Object() { "Near", "Far"})
			Me.cbHorAlign.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbHorAlign.Size = New System.Drawing.Size(56, 20)
			Me.cbHorAlign.TabIndex = 13
'			Me.cbHorAlign.SelectedIndexChanged += New System.EventHandler(Me.cbHorAlign_SelectedIndexChanged);
			' 
			' cbEnableAxisYScrolling
			' 
			Me.cbEnableAxisYScrolling.Location = New System.Drawing.Point(12, 37)
			Me.cbEnableAxisYScrolling.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
			Me.cbEnableAxisYScrolling.Name = "cbEnableAxisYScrolling"
			Me.cbEnableAxisYScrolling.Properties.AutoWidth = True
			Me.cbEnableAxisYScrolling.Properties.Caption = "Y-axis Scrolling"
			Me.cbEnableAxisYScrolling.Size = New System.Drawing.Size(93, 19)
			Me.cbEnableAxisYScrolling.TabIndex = 2
'			Me.cbEnableAxisYScrolling.CheckedChanged += New System.EventHandler(Me.cbEnableAxisYScrolling_CheckedChanged);
			' 
			' cbEnableAxisYZooming
			' 
			Me.cbEnableAxisYZooming.Location = New System.Drawing.Point(118, 37)
			Me.cbEnableAxisYZooming.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
			Me.cbEnableAxisYZooming.Name = "cbEnableAxisYZooming"
			Me.cbEnableAxisYZooming.Properties.AutoWidth = True
			Me.cbEnableAxisYZooming.Properties.Caption = "Y-axis Zooming"
			Me.cbEnableAxisYZooming.Size = New System.Drawing.Size(94, 19)
			Me.cbEnableAxisYZooming.TabIndex = 3
'			Me.cbEnableAxisYZooming.CheckedChanged += New System.EventHandler(Me.cbEnableAxisYZooming_CheckedChanged);
			' 
			' cbEnableAxisXScrolling
			' 
			Me.cbEnableAxisXScrolling.Location = New System.Drawing.Point(12, 9)
			Me.cbEnableAxisXScrolling.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
			Me.cbEnableAxisXScrolling.Name = "cbEnableAxisXScrolling"
			Me.cbEnableAxisXScrolling.Properties.AutoWidth = True
			Me.cbEnableAxisXScrolling.Properties.Caption = "X-axis Scrolling"
			Me.cbEnableAxisXScrolling.Size = New System.Drawing.Size(93, 19)
			Me.cbEnableAxisXScrolling.TabIndex = 2
'			Me.cbEnableAxisXScrolling.CheckedChanged += New System.EventHandler(Me.cbEnableAxisXScrolling_CheckedChanged);
			' 
			' cbEnableAxisXZooming
			' 
			Me.cbEnableAxisXZooming.Location = New System.Drawing.Point(118, 9)
			Me.cbEnableAxisXZooming.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
			Me.cbEnableAxisXZooming.Name = "cbEnableAxisXZooming"
			Me.cbEnableAxisXZooming.Properties.AutoWidth = True
			Me.cbEnableAxisXZooming.Properties.Caption = "X-axis Zooming"
			Me.cbEnableAxisXZooming.Size = New System.Drawing.Size(94, 19)
			Me.cbEnableAxisXZooming.TabIndex = 3
'			Me.cbEnableAxisXZooming.CheckedChanged += New System.EventHandler(Me.cbEnableAxisXZooming_CheckedChanged);
			' 
			' ScrollingAndZoomingDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "ScrollingAndZoomingDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stepLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbVertAlign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbHorAlign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbEnableAxisYScrolling.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbEnableAxisYZooming.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbEnableAxisXScrolling.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbEnableAxisXZooming.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents btnRestoreView As DevExpress.XtraEditors.SimpleButton
		Private lblHorizontal As DevExpress.XtraEditors.LabelControl
		Private lblVertical As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbVertAlign As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbHorAlign As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbEnableAxisYZooming As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cbEnableAxisXZooming As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cbEnableAxisYScrolling As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cbEnableAxisXScrolling As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace
