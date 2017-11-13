Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class FullStackedAreaDemo
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
			Dim fullStackedAreaSeriesView1 As New DevExpress.XtraCharts.FullStackedAreaSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.checkValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(fullStackedAreaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.checkValueAsPercent)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.checkValueAsPercent, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 2
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			Me.chart.CrosshairOptions.GroupHeaderPattern = "{A:yyyy}"
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.Title.Text = "Country"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0R
			xyDiagram1.AxisY.Label.TextPattern = "{V:P0}"
			xyDiagram1.AxisY.Title.Text = "Percent"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisualRange.Auto = False
			xyDiagram1.AxisY.VisualRange.AutoSideMargins = False
			xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "1"
			xyDiagram1.AxisY.VisualRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.VisualRange.SideMarginsValue = 0R
			xyDiagram1.AxisY.WholeRange.Auto = False
			xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "1"
			xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Company"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Year"
			Me.chart.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}"
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales"
			Me.chart.SeriesTemplate.View = fullStackedAreaSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Market Share Over Time"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' checkValueAsPercent
			' 
			Me.checkValueAsPercent.Location = New System.Drawing.Point(12, 9)
			Me.checkValueAsPercent.Margin = New System.Windows.Forms.Padding(0)
			Me.checkValueAsPercent.Name = "checkValueAsPercent"
			Me.checkValueAsPercent.Properties.Caption = "Value As Percent"
			Me.checkValueAsPercent.Size = New System.Drawing.Size(104, 19)
			Me.checkValueAsPercent.TabIndex = 1
'			Me.checkValueAsPercent.CheckedChanged += New System.EventHandler(Me.checkEditValueAsPercent_CheckedChanged);
			' 
			' FullStackedAreaDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "FullStackedAreaDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(fullStackedAreaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
