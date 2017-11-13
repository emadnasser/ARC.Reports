Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class Line3dDemo
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
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
			Dim xyDiagram3D1 As New DevExpress.XtraCharts.XYDiagram3D()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim line3DSeriesLabel1 As New DevExpress.XtraCharts.Line3DSeriesLabel()
			Dim line3DSeriesView1 As New DevExpress.XtraCharts.Line3DSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim line3DSeriesLabel2 As New DevExpress.XtraCharts.Line3DSeriesLabel()
			Dim line3DSeriesView2 As New DevExpress.XtraCharts.Line3DSeriesView()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim line3DSeriesLabel3 As New DevExpress.XtraCharts.Line3DSeriesLabel()
			Dim line3DSeriesView3 As New DevExpress.XtraCharts.Line3DSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.comboBoxEditPerspective = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelPerspective = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(line3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(line3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(line3DSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(line3DSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(line3DSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(line3DSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnDefaultAngles
			' 
			Me.btnDefaultAngles.Location = New System.Drawing.Point(203, 8)
			Me.btnDefaultAngles.Margin = New System.Windows.Forms.Padding(10, 10, 10, 0)
			Me.btnDefaultAngles.TabIndex = 1
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelPerspective)
			Me.panel.Controls.Add(Me.comboBoxEditPerspective)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditPerspective, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPerspective, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.TabIndex = 2
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram3D1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
			xyDiagram3D1.AxisX.Label.TextPattern = "{A:yyyy}"
			xyDiagram3D1.AxisY.NumericScaleOptions.AutoGrid = False
			xyDiagram3D1.AxisY.NumericScaleOptions.GridSpacing = 50R
			xyDiagram3D1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			xyDiagram3D1.RotationMatrixSerializable = "0.766044437885284;-0.219846323132515;0.604022800922394;0;0;0.939692616462708;0.34" & "2020153999329;0;-0.642787635326386;-0.262002646923065;0.719846308231354;0;0;0;0;" & "1"
			xyDiagram3D1.RuntimeRotation = True
			xyDiagram3D1.RuntimeScrolling = True
			xyDiagram3D1.RuntimeZooming = True
			xyDiagram3D1.SeriesDistance = 0R
			xyDiagram3D1.VerticalScrollPercent = 6R
			xyDiagram3D1.ZoomPercent = 130
			Me.chart.Diagram = xyDiagram3D1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "Date"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			line3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			line3DSeriesLabel1.TextPattern = "{V:F2}"
			series1.Label = line3DSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Russia"
			series1.ValueDataMembersSerializable = "Russia"
			line3DSeriesView1.LineWidth = 2R
			series1.View = line3DSeriesView1
			series2.ArgumentDataMember = "Date"
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			line3DSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			line3DSeriesLabel2.TextPattern = "{V:F2}"
			series2.Label = line3DSeriesLabel2
			series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series2.Name = "South Africa"
			series2.ValueDataMembersSerializable = "South Africa"
			line3DSeriesView2.LineWidth = 2R
			series2.View = line3DSeriesView2
			series3.ArgumentDataMember = "Date"
			series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			line3DSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			line3DSeriesLabel3.TextPattern = "{V:F2}"
			series3.Label = line3DSeriesLabel3
			series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series3.Name = "Poland"
			series3.ValueDataMembersSerializable = "Poland"
			line3DSeriesView3.LineWidth = 2R
			series3.View = line3DSeriesView3
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3}
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			chartTitle1.Text = "Coal Production, in Millions of Tonnes"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.quandl.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' comboBoxEditPerspective
			' 
			Me.comboBoxEditPerspective.EditValue = ""
			Me.comboBoxEditPerspective.Location = New System.Drawing.Point(105, 9)
			Me.comboBoxEditPerspective.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.comboBoxEditPerspective.Name = "comboBoxEditPerspective"
			Me.comboBoxEditPerspective.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditPerspective.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditPerspective.Size = New System.Drawing.Size(78, 20)
			Me.comboBoxEditPerspective.TabIndex = 0
'			Me.comboBoxEditPerspective.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditPerspective_SelectedIndexChanged);
			' 
			' labelPerspective
			' 
			Me.labelPerspective.Location = New System.Drawing.Point(12, 12)
			Me.labelPerspective.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelPerspective.Name = "labelPerspective"
			Me.labelPerspective.Size = New System.Drawing.Size(90, 13)
			Me.labelPerspective.TabIndex = 13
			Me.labelPerspective.Text = "Perspective Angle:"
			' 
			' Line3dDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "Line3dDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(line3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(line3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(line3DSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(line3DSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(line3DSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(line3DSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelPerspective As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
