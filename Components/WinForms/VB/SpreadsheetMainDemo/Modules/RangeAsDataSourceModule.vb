Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils


Namespace DevExpress.XtraSpreadsheet.Demos
	Public Class RangeAsDataSourceModule
		Inherits SpreadSheetTutorialControlBase
		Private verticalSplitContainerControl1 As SplitContainerControl
		Private WithEvents spreadsheet As SpreadsheetControl
		Private panelControl1 As PanelControl
		Private labelControl1 As LabelControl
		Private labelControl2 As LabelControl
		Private WithEvents trbStdDev As ZoomTrackBarControl
		Private WithEvents trbMean As ZoomTrackBarControl
		Private chartControl1 As ChartControl
		Private WithEvents timer1 As Timer
		Private components As IContainer
		Private mean As Double
		Private standardDeviation As Double

		Public Sub New()
			InitializeComponent()
			Me.spreadsheet.LoadDocument(DemoUtils.GetRelativePath("RangeAsDataSource_template.xlsx"), DocumentFormat.Xlsx)
		End Sub

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			Me.spreadsheet.Focus()
			timer1.Enabled = True
		End Sub

		Protected Overrides Sub DoHide()
			timer1.Enabled = False
			MyBase.DoHide()
		End Sub

		Private Sub spreadsheet_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs) Handles spreadsheet.DocumentLoaded
			Dim workbook As IWorkbook = Me.spreadsheet.Document
			Dim sheet As Worksheet = workbook.Worksheets(0)

			Me.chartControl1.DataSource = sheet("B3:D103").GetDataSource()
			Dim series As Series = Me.chartControl1.Series(0)
			series.ArgumentDataMember = "Column 0"
			series.ValueDataMembers.AddRange(New String() { "Column 1" })
			series = Me.chartControl1.Series(1)
			series.ArgumentDataMember = "Column 0"
			series.ValueDataMembers.AddRange(New String() { "Column 2" })

			mean = trbMean.Value / 10.0
			standardDeviation = trbStdDev.Value / 100.0
		End Sub

		Private Sub trbMean_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trbMean.EditValueChanged
			mean = trbMean.Value / 10.0
		End Sub

		Private Sub trbStdDev_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trbStdDev.EditValueChanged
			standardDeviation = trbStdDev.Value / 100.0
		End Sub

		Private Sub spreadsheet_CellValueChanged(ByVal sender As Object, ByVal e As SpreadsheetCellEventArgs) Handles spreadsheet.CellValueChanged
			If e.Cell.GetReferenceA1() = "F3" Then
				trbMean.Value = CInt(Fix(e.Cell.Value.NumericValue * 10))
			ElseIf e.Cell.GetReferenceA1() = "F6" Then
				trbStdDev.Value = CInt(Fix(e.Cell.Value.NumericValue * 100))
			End If
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			Me.spreadsheet.BeginUpdate()
			Try
				Dim sheet As Worksheet = Me.spreadsheet.Document.Worksheets(0)
				If sheet("F3").Value.NumericValue <> mean Then
					sheet("F3").Value = mean
				End If
				If sheet("F6").Value.NumericValue <> standardDeviation Then
					sheet("F6").Value = standardDeviation
				End If
			Finally
				Me.spreadsheet.EndUpdate()
			End Try
		End Sub

		#Region "InitializeComponent"
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim strip1 As New DevExpress.XtraCharts.Strip()
			Dim strip2 As New DevExpress.XtraCharts.Strip()
			Dim strip3 As New DevExpress.XtraCharts.Strip()
			Dim strip4 As New DevExpress.XtraCharts.Strip()
			Dim strip5 As New DevExpress.XtraCharts.Strip()
			Dim xyDiagramPane1 As New DevExpress.XtraCharts.XYDiagramPane()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim scatterLineSeriesView1 As New DevExpress.XtraCharts.ScatterLineSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim scatterLineSeriesView2 As New DevExpress.XtraCharts.ScatterLineSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.verticalSplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.spreadsheet = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.trbStdDev = New DevExpress.XtraEditors.ZoomTrackBarControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.trbMean = New DevExpress.XtraEditors.ZoomTrackBarControl()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			CType(Me.verticalSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.verticalSplitContainerControl1.SuspendLayout()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(strip1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(strip2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(strip3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(strip4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(strip5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagramPane1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(scatterLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(scatterLineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.trbStdDev, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trbStdDev.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trbMean, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trbMean.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' verticalSplitContainerControl1
			' 
			Me.verticalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.verticalSplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
			Me.verticalSplitContainerControl1.Location = New System.Drawing.Point(0, 34)
			Me.verticalSplitContainerControl1.Name = "verticalSplitContainerControl1"
			Me.verticalSplitContainerControl1.Panel1.Controls.Add(Me.spreadsheet)
			Me.verticalSplitContainerControl1.Panel1.Text = "Panel1"
			Me.verticalSplitContainerControl1.Panel2.Controls.Add(Me.chartControl1)
			Me.verticalSplitContainerControl1.Panel2.Text = "Panel2"
			Me.verticalSplitContainerControl1.Size = New System.Drawing.Size(1228, 660)
			Me.verticalSplitContainerControl1.SplitterPosition = 615
			Me.verticalSplitContainerControl1.TabIndex = 0
			Me.verticalSplitContainerControl1.Text = "verticalSplitContainerControl1"
			' 
			' spreadsheet
			' 
			Me.spreadsheet.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheet.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheet.Name = "spreadsheet"
			Me.spreadsheet.Options.Behavior.Column.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
			Me.spreadsheet.Options.Behavior.Column.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
			Me.spreadsheet.Options.Behavior.Row.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
			Me.spreadsheet.Options.Behavior.Row.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
			Me.spreadsheet.Options.Behavior.UseSkinColors = False
			Me.spreadsheet.Options.Export.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheet.Options.Export.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheet.Options.Import.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheet.Options.Import.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheet.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
			Me.spreadsheet.Options.View.ShowPrintArea = False
			Me.spreadsheet.Size = New System.Drawing.Size(615, 660)
			Me.spreadsheet.TabIndex = 7
'			Me.spreadsheet.DocumentLoaded += New System.EventHandler(Me.spreadsheet_DocumentLoaded);
'			Me.spreadsheet.CellValueChanged += New DevExpress.XtraSpreadsheet.CellValueChangedEventHandler(Me.spreadsheet_CellValueChanged);
			' 
			' chartControl1
			' 
			Me.chartControl1.AppearanceNameSerializable = "Light"
			Me.chartControl1.DataBindings = Nothing
			xyDiagram1.AxisX.GridLines.Visible = True
			strip1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(242))))))
			strip1.MaxLimit.AxisValueSerializable = "1"
			strip1.MinLimit.AxisValueSerializable = "-1"
			strip1.Name = "Strip 1"
			strip1.ShowInLegend = False
			strip2.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(242))))))
			strip2.MaxLimit.AxisValueSerializable = "-2"
			strip2.MinLimit.AxisValueSerializable = "-3"
			strip2.Name = "Strip 2"
			strip2.ShowInLegend = False
			strip3.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(242))))))
			strip3.MaxLimit.AxisValueSerializable = "-4"
			strip3.MinLimit.AxisValueSerializable = "-5"
			strip3.Name = "Strip 3"
			strip3.ShowInLegend = False
			strip4.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(242))))))
			strip4.MaxLimit.AxisValueSerializable = "3"
			strip4.MinLimit.AxisValueSerializable = "2"
			strip4.Name = "Strip 4"
			strip4.ShowInLegend = False
			strip5.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(242))))))
			strip5.MaxLimit.AxisValueSerializable = "5"
			strip5.MinLimit.AxisValueSerializable = "4"
			strip5.Name = "Strip 5"
			strip5.ShowInLegend = False
			xyDiagram1.AxisX.Strips.AddRange(New DevExpress.XtraCharts.Strip() { strip1, strip2, strip3, strip4, strip5})
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1;0"
			xyDiagram1.AxisX.VisualRange.Auto = False
			xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "5"
			xyDiagram1.AxisX.VisualRange.MinValueSerializable = "-5"
			xyDiagram1.AxisX.WholeRange.Auto = False
			xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "5"
			xyDiagram1.AxisX.WholeRange.MinValueSerializable = "-5"
			xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1;0"
			xyDiagramPane1.Name = "Pane 1"
			xyDiagramPane1.PaneID = 0
			xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() { xyDiagramPane1})
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Name = "Default Legend"
			Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			series1.CrosshairLabelPattern = "X={A:0.0} Y={V:0.00e+00}"
			series1.Name = "PDF"
			series1.View = scatterLineSeriesView1
			series2.CrosshairLabelPattern = "X={A:0.0} Y={V:0.00e+00}"
			series2.Name = "CDF"
			scatterLineSeriesView2.PaneName = "Pane 1"
			series2.View = scatterLineSeriesView2
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			Me.chartControl1.Size = New System.Drawing.Size(608, 660)
			Me.chartControl1.TabIndex = 0
			chartTitle1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
			chartTitle1.Font = New System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			chartTitle1.Text = "PROBABILITY DENSITY FUNCTION"
			chartTitle1.TextColor = System.Drawing.Color.DimGray
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
			chartTitle2.Font = New System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			chartTitle2.Text = "CUMULATIVE DISTRIBUTION FUNCTION"
			chartTitle2.TextColor = System.Drawing.Color.DimGray
			Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.labelControl2)
			Me.panelControl1.Controls.Add(Me.trbStdDev)
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Controls.Add(Me.trbMean)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(1228, 34)
			Me.panelControl1.TabIndex = 1
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(245, 6)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(95, 13)
			Me.labelControl2.TabIndex = 2
			Me.labelControl2.Text = "Standard deviation:"
			' 
			' trbStdDev
			' 
			Me.trbStdDev.EditValue = 55
			Me.trbStdDev.Location = New System.Drawing.Point(359, 3)
			Me.trbStdDev.Name = "trbStdDev"
			Me.trbStdDev.Properties.Maximum = 100
			Me.trbStdDev.Properties.Minimum = 10
			Me.trbStdDev.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.trbStdDev.Size = New System.Drawing.Size(164, 23)
			Me.trbStdDev.TabIndex = 3
			Me.trbStdDev.Value = 55
'			Me.trbStdDev.EditValueChanged += New System.EventHandler(Me.trbStdDev_EditValueChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(0, 6)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(30, 13)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "Mean:"
			' 
			' trbMean
			' 
			Me.trbMean.Location = New System.Drawing.Point(36, 3)
			Me.trbMean.Name = "trbMean"
			Me.trbMean.Properties.Maximum = 50
			Me.trbMean.Properties.Minimum = -50
			Me.trbMean.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.trbMean.Size = New System.Drawing.Size(164, 23)
			Me.trbMean.TabIndex = 1
			Me.trbMean.Value = 0
'			Me.trbMean.EditValueChanged += New System.EventHandler(Me.trbMean_EditValueChanged);
			' 
			' timer1
			' 
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' RangeAsDataSourceModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.verticalSplitContainerControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "RangeAsDataSourceModule"
			Me.Size = New System.Drawing.Size(1228, 694)
			CType(Me.verticalSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.verticalSplitContainerControl1.ResumeLayout(False)
			CType(strip1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(strip2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(strip3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(strip4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(strip5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagramPane1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(scatterLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(scatterLineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.trbStdDev.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trbStdDev, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trbMean.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trbMean, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "Dispose"
		Private isModuleDisposed As Boolean = False
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not isModuleDisposed) Then
				timer1.Enabled = False
				isModuleDisposed = True
			End If
			MyBase.Dispose(disposing)
		End Sub
		#End Region
	End Class
End Namespace
