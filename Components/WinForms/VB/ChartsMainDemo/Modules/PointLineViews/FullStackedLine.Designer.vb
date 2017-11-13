Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class FullStackedLineDemo
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
			Dim stackedLineSeriesLabel1 As New DevExpress.XtraCharts.StackedLineSeriesLabel()
			Dim fullStackedLineSeriesView1 As New DevExpress.XtraCharts.FullStackedLineSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.checkValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.checkEditShowMarkers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditLabelAngle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedLineSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(fullStackedLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' checkEditShowMarkers
			' 
			' 
			' comboBoxEditMarkerKind
			' 
			' 
			' comboBoxEditLabelAngle
			' 
			' 
			' comboBoxEditMarkerSize
			' 
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.checkValueAsPercent)
			Me.panel.Size = New System.Drawing.Size(697, 66)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditLabelAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.labelAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowMarkers, 0)
			Me.panel.Controls.SetChildIndex(Me.checkValueAsPercent, 0)
			' 
			' checkEditShowLabels
			' 
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(697, 74)
			' 
			' chart
			' 
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
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
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Company"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Year"
			stackedLineSeriesLabel1.TextPattern = "{VP:P0}"
			Me.chart.SeriesTemplate.Label = stackedLineSeriesLabel1
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales"
			Me.chart.SeriesTemplate.View = fullStackedLineSeriesView1
			Me.chart.Size = New System.Drawing.Size(697, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Market Share Over Time"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
'			Me.chart.BoundDataChanged += New DevExpress.XtraCharts.BoundDataChangedEventHandler(Me.chart_BoundDataChanged);
			' 
			' checkValueAsPercent
			' 
			Me.checkValueAsPercent.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkValueAsPercent.Location = New System.Drawing.Point(486, 9)
			Me.checkValueAsPercent.Margin = New System.Windows.Forms.Padding(0)
			Me.checkValueAsPercent.Name = "checkValueAsPercent"
			Me.checkValueAsPercent.Properties.Caption = "Value As Percent"
			Me.checkValueAsPercent.Size = New System.Drawing.Size(104, 19)
			Me.checkValueAsPercent.TabIndex = 59
'			Me.checkValueAsPercent.CheckedChanged += New System.EventHandler(Me.checkValueAsPercent_CheckedChanged);
			' 
			' FullStackedLineDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "FullStackedLineDemo"
			Me.Size = New System.Drawing.Size(697, 500)
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.checkEditShowMarkers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditLabelAngle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedLineSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(fullStackedLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents chart As DevExpress.XtraCharts.ChartControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents checkValueAsPercent As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
