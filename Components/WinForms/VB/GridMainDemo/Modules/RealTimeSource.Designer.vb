Namespace DevExpress.XtraGrid.Demos
	Partial Public Class RealTimeSourceDemo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(RealTimeSourceDemo))
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim scatterLineSeriesView1 As New DevExpress.XtraCharts.ScatterLineSeriesView()
			Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim scatterLineSeriesView2 As New DevExpress.XtraCharts.ScatterLineSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.groupBox1 = New DevExpress.XtraEditors.GroupControl()
			Me.trackBar1 = New DevExpress.XtraEditors.TrackBarControl()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.Ticker = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.Last = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.ChgPercent = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.Open = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.High = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.Low = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.DayVal = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.useRealtimeSource = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.groupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(scatterLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(scatterLineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.useRealtimeSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.trackBar1)
			resources.ApplyResources(Me.groupBox1, "groupBox1")
			Me.groupBox1.Name = "groupBox1"
			' 
			' trackBar1
			' 
			resources.ApplyResources(Me.trackBar1, "trackBar1")
			Me.trackBar1.Name = "trackBar1"
			Me.trackBar1.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.trackBar1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.trackBar1.Properties.Maximum = 34
			Me.trackBar1.Value = 10
'			Me.trackBar1.ValueChanged += New System.EventHandler(Me.trackBar1_Scroll)
			' 
			' chartControl1
			' 
			Me.chartControl1.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.FromArgb((CInt((CByte(222)))), (CInt((CByte(57)))), (CInt((CByte(205)))))
			Me.chartControl1.CrosshairOptions.ValueLineColor = System.Drawing.Color.FromArgb((CInt((CByte(222)))), (CInt((CByte(57)))), (CInt((CByte(205)))))
            xyDiagram1.AxisX.Label.TextPattern = "{A:G}"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = True
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Logarithmic = True
            xyDiagram1.AxisY.Label.TextPattern = "{V:G}"
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = True
            xyDiagram1.AxisY.VisualRange.AutoSideMargins = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Legend.TextVisible = False
			resources.ApplyResources(Me.chartControl1, "chartControl1")
			Me.chartControl1.Name = "chartControl1"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			series1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
            pointSeriesLabel1.LineVisibility = Utils.DefaultBoolean.True
            pointSeriesLabel1.TextPattern = "{V:G2}"
			pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			series1.Label = pointSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            resources.ApplyResources(series1, "series1")
			series1.ShowInLegend = False
            series1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.False
			series1.ToolTipSeriesPattern = "{V}"
			scatterLineSeriesView1.LineMarkerOptions.Size = 2
			scatterLineSeriesView1.LineStyle.Thickness = 1
			series1.View = scatterLineSeriesView1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            pointSeriesLabel2.LineVisibility = Utils.DefaultBoolean.True
            pointSeriesLabel2.TextPattern = "{V:G2}"
			Me.chartControl1.SeriesTemplate.Label = pointSeriesLabel2
			Me.chartControl1.SeriesTemplate.View = scatterLineSeriesView2
			resources.ApplyResources(chartTitle1, "chartTitle1")
			chartTitle1.Indent = 0
			Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			Me.chartControl1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chartControl1.ToolTipOptions.ShowForPoints = False
			' 
			' gridControl1
			' 
			resources.ApplyResources(Me.gridControl1, "gridControl1")
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.Ticker, Me.Last, Me.ChgPercent, Me.Open, Me.High, Me.Low, Me.DayVal})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.OptionsBehavior.Editable = False
			Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.gridView1.OptionsSelection.EnableAppearanceFocusedRow = False
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.OptionsView.ShowIndicator = False
'			Me.gridView1.DataSourceChanged += New System.EventHandler(Me.gridView1_DataSourceChanged)
'			Me.gridView1.RowCellStyle += New DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(Me.gridView1_RowCellStyle)
			' 
			' Ticker
			' 
			resources.ApplyResources(Me.Ticker, "Ticker")
			Me.Ticker.FieldName = "Ticker"
			Me.Ticker.Name = "Ticker"
			' 
			' Last
			' 
			resources.ApplyResources(Me.Last, "Last")
			Me.Last.FieldName = "Last"
			Me.Last.Name = "Last"
			' 
			' ChgPercent
			' 
			resources.ApplyResources(Me.ChgPercent, "ChgPercent")
			Me.ChgPercent.FieldName = "ChgPercent"
			Me.ChgPercent.Name = "ChgPercent"
			' 
			' Open
			' 
			resources.ApplyResources(Me.Open, "Open")
			Me.Open.FieldName = "Open"
			Me.Open.Name = "Open"
			' 
			' High
			' 
			resources.ApplyResources(Me.High, "High")
			Me.High.FieldName = "High"
			Me.High.Name = "High"
			' 
			' Low
			' 
			resources.ApplyResources(Me.Low, "Low")
			Me.Low.FieldName = "Low"
			Me.Low.Name = "Low"
			' 
			' DayVal
			' 
			resources.ApplyResources(Me.DayVal, "DayVal")
			Me.DayVal.FieldName = "DayVal"
			Me.DayVal.Name = "DayVal"
			' 
			' useRealtimeSource
			' 
			resources.ApplyResources(Me.useRealtimeSource, "useRealtimeSource")
			Me.useRealtimeSource.Name = "useRealtimeSource"
			Me.useRealtimeSource.Properties.Caption = resources.GetString("useRealtimeSource.Properties.Caption")
			Me.useRealtimeSource.StyleController = Me.layoutControl1
'			Me.useRealtimeSource.CheckedChanged += New System.EventHandler(Me.UnplugRTS_Click)
			' 
			' layoutControl1
			' 
            Me.layoutControl1.AllowCustomization = False
			Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True

			Me.layoutControl1.Controls.Add(Me.chartControl1)
			Me.layoutControl1.Controls.Add(Me.groupBox1)
			Me.layoutControl1.Controls.Add(Me.useRealtimeSource)
			Me.layoutControl1.Controls.Add(Me.gridControl1)
			resources.ApplyResources(Me.layoutControl1, "layoutControl1")
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(795, 490, 450, 350)
			Me.layoutControl1.Root = Me.layoutControlGroup1
			' 
			' layoutControlGroup1
			' 
			resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.splitterItem1, Me.layoutControlItem3, Me.layoutControlItem4})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(794, 543)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.chartControl1
			resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 88)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(238, 455)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.gridControl1
			resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
			Me.layoutControlItem2.Location = New System.Drawing.Point(243, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(551, 543)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' splitterItem1
			' 
			Me.splitterItem1.AllowHotTrack = True
			resources.ApplyResources(Me.splitterItem1, "splitterItem1")
			Me.splitterItem1.Location = New System.Drawing.Point(238, 0)
			Me.splitterItem1.Name = "splitterItem1"
			Me.splitterItem1.Size = New System.Drawing.Size(5, 543)
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.useRealtimeSource
			resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 65)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(238, 23)
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextToControlDistance = 0
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.groupBox1
			resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem4.MaxSize = New System.Drawing.Size(0, 65)
			Me.layoutControlItem4.MinSize = New System.Drawing.Size(104, 65)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(238, 65)
			Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextToControlDistance = 0
			Me.layoutControlItem4.TextVisible = False
			' 
			' RealTimeSourceDemo
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "RealTimeSourceDemo"
			CType(Me.groupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.trackBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(scatterLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(scatterLineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.useRealtimeSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private groupBox1 As DevExpress.XtraEditors.GroupControl
		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents trackBar1 As DevExpress.XtraEditors.TrackBarControl
		Private Ticker As DevExpress.XtraGrid.Columns.GridColumn
		Private Last As DevExpress.XtraGrid.Columns.GridColumn
		Private ChgPercent As DevExpress.XtraGrid.Columns.GridColumn
		Private Open As DevExpress.XtraGrid.Columns.GridColumn
		Private High As DevExpress.XtraGrid.Columns.GridColumn
		Private Low As DevExpress.XtraGrid.Columns.GridColumn
		Private DayVal As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents useRealtimeSource As DevExpress.XtraEditors.CheckEdit
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace
