Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class SplineDemo
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
			Dim splineSeriesView1 As New DevExpress.XtraCharts.SplineSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.labelLineTension = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxLineTension = New DevExpress.XtraEditors.ComboBoxEdit()
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
			CType(splineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxLineTension.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' checkEditShowMarkers
			' 
			Me.checkEditShowMarkers.TabIndex = 4
			' 
			' comboBoxEditMarkerKind
			' 
			Me.comboBoxEditMarkerKind.TabIndex = 0
			' 
			' comboBoxEditLabelAngle
			' 
			Me.comboBoxEditLabelAngle.TabIndex = 2
			' 
			' comboBoxEditMarkerSize
			' 
			Me.comboBoxEditMarkerSize.TabIndex = 1
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelLineTension)
			Me.panel.Controls.Add(Me.comboBoxLineTension)
			Me.panel.Controls.SetChildIndex(Me.comboBoxLineTension, 0)
			Me.panel.Controls.SetChildIndex(Me.labelLineTension, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditLabelAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.labelAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowMarkers, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.TabIndex = 5
			' 
			' chart
			' 
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Continuous
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Title.Text = "Time of Day"
			xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Interlaced = True
			xyDiagram1.AxisY.Label.TextPattern = "{V:G}"
			xyDiagram1.AxisY.Title.Text = "Power, kW"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Branch"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Time"
			Me.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			Me.chart.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}kWt"
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Power"
			Me.chart.SeriesTemplate.View = splineSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Power Consumption per Working Day"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
'			Me.chart.BoundDataChanged += New DevExpress.XtraCharts.BoundDataChangedEventHandler(Me.chart_BoundDataChanged);
			' 
			' labelLineTension
			' 
			Me.labelLineTension.Enabled = False
			Me.labelLineTension.Location = New System.Drawing.Point(148, 40)
			Me.labelLineTension.Name = "labelLineTension"
			Me.labelLineTension.Size = New System.Drawing.Size(103, 13)
			Me.labelLineTension.TabIndex = 60
			Me.labelLineTension.Text = "Line Tension Percent:"
			' 
			' comboBoxLineTension
			' 
			Me.comboBoxLineTension.Location = New System.Drawing.Point(257, 37)
			Me.comboBoxLineTension.Name = "comboBoxLineTension"
			Me.comboBoxLineTension.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxLineTension.Properties.Items.AddRange(New Object() { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
			Me.comboBoxLineTension.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxLineTension.Size = New System.Drawing.Size(60, 20)
			Me.comboBoxLineTension.TabIndex = 3
'			Me.comboBoxLineTension.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEdit1_SelectedIndexChanged);
			' 
			' SplineDemo
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "SplineDemo"
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
			CType(splineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxLineTension.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelLineTension As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBoxLineTension As DevExpress.XtraEditors.ComboBoxEdit
	End Class
End Namespace
