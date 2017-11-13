Imports Microsoft.VisualBasic
Imports System
Namespace DashboardMainDemo
	Partial Public Class SalesDetailsPopupForm
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
			Me.components = New System.ComponentModel.Container()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim areaSeriesView1 As New DevExpress.XtraCharts.AreaSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim simpleDiagram1 As New DevExpress.XtraCharts.SimpleDiagram()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim pieSeriesLabel1 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.barChart = New DevExpress.XtraCharts.ChartControl()
			Me.pieChart = New DevExpress.XtraCharts.ChartControl()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			Me.lblUnitsInStockCount = New System.Windows.Forms.Label()
			Me.lblUnitsInStockCaption = New System.Windows.Forms.Label()
			Me.drillThroughGrid = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			CType(Me.barChart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pieChart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.drillThroughGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			Me.xtraTabPage2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.splitContainer1.Location = New System.Drawing.Point(17, 41)
			Me.splitContainer1.Name = "splitContainer1"
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.barChart)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.pieChart)
			Me.splitContainer1.Size = New System.Drawing.Size(823, 269)
			Me.splitContainer1.SplitterDistance = 483
			Me.splitContainer1.TabIndex = 4
			' 
			' barChart
			' 
			Me.barChart.CrosshairOptions.ShowArgumentLine = False
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Label.TextPattern = "{V:$0}"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.barChart.Diagram = xyDiagram1
			Me.barChart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.barChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
			Me.barChart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.RightToLeft
			Me.barChart.Location = New System.Drawing.Point(0, 0)
			Me.barChart.Name = "barChart"
			series1.ArgumentDataMember = "Argument"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series1.Name = "Target"
			series1.ValueDataMembersSerializable = "Target"
			areaSeriesView1.Transparency = (CByte(100))
			series1.View = areaSeriesView1
			series2.ArgumentDataMember = "Argument"
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series2.Name = "Sales"
			series2.ValueDataMembersSerializable = "Actual"
			series2.View = lineSeriesView1
			Me.barChart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			Me.barChart.Size = New System.Drawing.Size(483, 269)
			Me.barChart.TabIndex = 3
'			Me.barChart.CustomDrawCrosshair += New DevExpress.XtraCharts.CustomDrawCrosshairEventHandler(Me.barChart_CustomDrawCrosshair);
'			Me.barChart.CustomDrawAxisLabel += New DevExpress.XtraCharts.CustomDrawAxisLabelEventHandler(Me.barChart_CustomDrawAxisLabel);
			' 
			' pieChart
			' 
			simpleDiagram1.EqualPieSize = False
			Me.pieChart.Diagram = simpleDiagram1
			Me.pieChart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pieChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.pieChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.pieChart.Location = New System.Drawing.Point(0, 0)
			Me.pieChart.Name = "pieChart"
			series3.ArgumentDataMember = "Argument"
			series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
			pieSeriesLabel1.TextPattern = "{A}: {VP:P2}"
			series3.Label = pieSeriesLabel1
			series3.Name = "Product Sales"
			series3.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True
			series3.ToolTipPointPattern = "{A}"
			series3.ValueDataMembersSerializable = "Value"
			pieSeriesView1.RuntimeExploding = False
			pieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise
			series3.View = pieSeriesView1
			Me.pieChart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series3}
			Me.pieChart.Size = New System.Drawing.Size(336, 269)
			Me.pieChart.TabIndex = 2
			Me.pieChart.ToolTipController = Me.toolTipController1
			' 
			' toolTipController1
			' 
'			Me.toolTipController1.BeforeShow += New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(Me.toolTipController1_BeforeShow);
			' 
			' lblUnitsInStockCount
			' 
			Me.lblUnitsInStockCount.AutoSize = True
			Me.lblUnitsInStockCount.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.lblUnitsInStockCount.Location = New System.Drawing.Point(121, 17)
			Me.lblUnitsInStockCount.Name = "lblUnitsInStockCount"
			Me.lblUnitsInStockCount.Size = New System.Drawing.Size(45, 19)
			Me.lblUnitsInStockCount.TabIndex = 1
			Me.lblUnitsInStockCount.Text = "1234"
			' 
			' lblUnitsInStockCaption
			' 
			Me.lblUnitsInStockCaption.AutoSize = True
			Me.lblUnitsInStockCaption.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.lblUnitsInStockCaption.Location = New System.Drawing.Point(14, 17)
			Me.lblUnitsInStockCaption.Name = "lblUnitsInStockCaption"
			Me.lblUnitsInStockCaption.Size = New System.Drawing.Size(110, 19)
			Me.lblUnitsInStockCaption.TabIndex = 0
			Me.lblUnitsInStockCaption.Text = "Units in stock:"
			' 
			' drillThroughGrid
			' 
			Me.drillThroughGrid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.drillThroughGrid.Location = New System.Drawing.Point(0, 0)
			Me.drillThroughGrid.MainView = Me.gridView1
			Me.drillThroughGrid.Margin = New System.Windows.Forms.Padding(0)
			Me.drillThroughGrid.Name = "drillThroughGrid"
			Me.drillThroughGrid.Size = New System.Drawing.Size(858, 327)
			Me.drillThroughGrid.TabIndex = 0
			Me.drillThroughGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gridView1.GridControl = Me.drillThroughGrid
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.Editable = False
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.OptionsView.ShowIndicator = False
'			Me.gridView1.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.gridView1_CustomDrawCell);
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.xtraTabControl1.Location = New System.Drawing.Point(12, 12)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(864, 355)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.splitContainer1)
			Me.xtraTabPage1.Controls.Add(Me.lblUnitsInStockCaption)
			Me.xtraTabPage1.Controls.Add(Me.lblUnitsInStockCount)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(858, 327)
			Me.xtraTabPage1.Text = "Details"
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.drillThroughGrid)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(858, 327)
			Me.xtraTabPage2.Text = "Underlying Data"
			' 
			' SalesDetailsPopupForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(888, 379)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "SalesDetailsPopupForm"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Product Details"
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer1.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barChart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pieChart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.drillThroughGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			Me.xtraTabPage1.PerformLayout()
			Me.xtraTabPage2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private drillThroughGrid As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private lblUnitsInStockCount As System.Windows.Forms.Label
		Private lblUnitsInStockCaption As System.Windows.Forms.Label
		Private WithEvents barChart As DevExpress.XtraCharts.ChartControl
		Private pieChart As DevExpress.XtraCharts.ChartControl
		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private WithEvents toolTipController1 As DevExpress.Utils.ToolTipController
	End Class
End Namespace
