Namespace DevExpress.SalesDemo.Win.Modules
	Partial Public Class ucSalesPerformance
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
            Dim TextAnnotation1 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
            Dim ChartAnchorPoint1 As DevExpress.XtraCharts.ChartAnchorPoint = New DevExpress.XtraCharts.ChartAnchorPoint()
            Dim FreePosition1 As DevExpress.XtraCharts.FreePosition = New DevExpress.XtraCharts.FreePosition()
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim AreaSeriesView1 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
            Dim AreaSeriesView2 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
            Me.layoutPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.captionPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.valuePresenter1 = New DevExpress.SalesDemo.Win.Modules.ucValuePresenter()
            Me.valuePresenter0 = New DevExpress.SalesDemo.Win.Modules.ucValuePresenter()
            Me.valuePresenter2 = New DevExpress.SalesDemo.Win.Modules.ucValuePresenter()
            Me.buttonsPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
            Me.btnForward = New DevExpress.XtraEditors.SimpleButton()
            Me.btnPreviousDate = New DevExpress.XtraEditors.CheckButton()
            Me.btnCurrentDate = New DevExpress.XtraEditors.CheckButton()
            Me.layoutPanel.SuspendLayout()
            CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(TextAnnotation1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(AreaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(AreaSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.captionPanel.SuspendLayout()
            Me.buttonsPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'layoutPanel
            '
            Me.layoutPanel.ColumnCount = 1
            Me.layoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.layoutPanel.Controls.Add(Me.chart, 0, 1)
            Me.layoutPanel.Controls.Add(Me.captionPanel, 0, 0)
            Me.layoutPanel.Controls.Add(Me.buttonsPanel, 0, 2)
            Me.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutPanel.Location = New System.Drawing.Point(0, 0)
            Me.layoutPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.layoutPanel.Name = "layoutPanel"
            Me.layoutPanel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            Me.layoutPanel.RowCount = 3
            Me.layoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.layoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.layoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.layoutPanel.Size = New System.Drawing.Size(724, 711)
            Me.layoutPanel.TabIndex = 1
            '
            'chart
            '
            ChartAnchorPoint1.X = 50
            ChartAnchorPoint1.Y = 30
            TextAnnotation1.AnchorPoint = ChartAnchorPoint1
            TextAnnotation1.Border.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            TextAnnotation1.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None
            TextAnnotation1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            TextAnnotation1.Name = "Text Annotation 1"
            TextAnnotation1.Padding.Bottom = 7
            TextAnnotation1.Padding.Left = 7
            TextAnnotation1.Padding.Right = 10
            TextAnnotation1.Padding.Top = 7
            TextAnnotation1.Shadow.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            TextAnnotation1.Shadow.Size = 1
            TextAnnotation1.ShapeKind = DevExpress.XtraCharts.ShapeKind.Rectangle
            FreePosition1.DockTargetName = "Default Pane"
            TextAnnotation1.ShapePosition = FreePosition1
            Me.chart.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {TextAnnotation1})
            Me.chart.BackColor = System.Drawing.Color.Transparent
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.DataBindings = Nothing
            XyDiagram1.AxisX.CrosshairAxisLabelOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            XyDiagram1.AxisX.GridLines.Visible = True
            XyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            XyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = False
            XyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
            XyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = False
            XyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            XyDiagram1.AxisX.Tickmarks.MinorVisible = False
            XyDiagram1.AxisX.Tickmarks.Visible = False
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            XyDiagram1.AxisX.WholeRange.SideMarginsValue = 0R
            XyDiagram1.AxisY.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            XyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            XyDiagram1.AxisY.Tickmarks.MinorVisible = False
            XyDiagram1.AxisY.Tickmarks.Visible = False
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            XyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Transparent
            XyDiagram1.Margins.Left = 35
            XyDiagram1.Margins.Right = 21
            Me.chart.Diagram = XyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chart.Legend.Font = New System.Drawing.Font("Tahoma", 10.0!)
            Me.chart.Legend.MarkerSize = New System.Drawing.Size(1, 16)
            Me.chart.Legend.MarkerVisible = False
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Location = New System.Drawing.Point(0, 45)
            Me.chart.Margin = New System.Windows.Forms.Padding(0)
            Me.chart.Name = "chart"
            Me.chart.Padding.Left = 0
            Me.chart.Padding.Right = 0
            PointSeriesLabel1.TextPattern = "{V:N0}"
            Series1.Label = PointSeriesLabel1
            Series1.Name = "Series 1"
            AreaSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            AreaSeriesView1.Transparency = CType(64, Byte)
            Series1.View = AreaSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
            AreaSeriesView2.Transparency = CType(0, Byte)
            Me.chart.SeriesTemplate.View = AreaSeriesView2
            Me.chart.Size = New System.Drawing.Size(724, 621)
            Me.chart.TabIndex = 0
            '
            'captionPanel
            '
            Me.captionPanel.ColumnCount = 4
            Me.captionPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
            Me.captionPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
            Me.captionPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
            Me.captionPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
            Me.captionPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.captionPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.captionPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.captionPanel.Controls.Add(Me.valuePresenter1, 2, 0)
            Me.captionPanel.Controls.Add(Me.valuePresenter0, 1, 0)
            Me.captionPanel.Controls.Add(Me.valuePresenter2, 3, 0)
            Me.captionPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.captionPanel.Location = New System.Drawing.Point(0, 5)
            Me.captionPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.captionPanel.Name = "captionPanel"
            Me.captionPanel.RowCount = 1
            Me.captionPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.captionPanel.Size = New System.Drawing.Size(724, 40)
            Me.captionPanel.TabIndex = 1
            '
            'valuePresenter1
            '
            Me.valuePresenter1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.valuePresenter1.Location = New System.Drawing.Point(264, 0)
            Me.valuePresenter1.Margin = New System.Windows.Forms.Padding(0)
            Me.valuePresenter1.Name = "valuePresenter1"
            Me.valuePresenter1.Size = New System.Drawing.Size(229, 40)
            Me.valuePresenter1.TabIndex = 9
            Me.valuePresenter1.TitleText = "title"
            Me.valuePresenter1.Value = 0R
            Me.valuePresenter1.ValueFormat = "${0:N0}"
            Me.valuePresenter1.ValueTextColor = System.Drawing.SystemColors.ControlText
            '
            'valuePresenter0
            '
            Me.valuePresenter0.Dock = System.Windows.Forms.DockStyle.Fill
            Me.valuePresenter0.Location = New System.Drawing.Point(35, 0)
            Me.valuePresenter0.Margin = New System.Windows.Forms.Padding(0)
            Me.valuePresenter0.Name = "valuePresenter0"
            Me.valuePresenter0.Size = New System.Drawing.Size(229, 40)
            Me.valuePresenter0.TabIndex = 8
            Me.valuePresenter0.TitleText = "title"
            Me.valuePresenter0.Value = 0R
            Me.valuePresenter0.ValueFormat = "${0:N0}"
            Me.valuePresenter0.ValueTextColor = System.Drawing.SystemColors.ControlText
            '
            'valuePresenter2
            '
            Me.valuePresenter2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.valuePresenter2.Location = New System.Drawing.Point(493, 0)
            Me.valuePresenter2.Margin = New System.Windows.Forms.Padding(0)
            Me.valuePresenter2.Name = "valuePresenter2"
            Me.valuePresenter2.Size = New System.Drawing.Size(231, 40)
            Me.valuePresenter2.TabIndex = 10
            Me.valuePresenter2.TitleText = "title"
            Me.valuePresenter2.Value = 0R
            Me.valuePresenter2.ValueFormat = "${0:N0}"
            Me.valuePresenter2.ValueTextColor = System.Drawing.SystemColors.ControlText
            '
            'buttonsPanel
            '
            Me.buttonsPanel.ColumnCount = 6
            Me.buttonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
            Me.buttonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.buttonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.buttonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.buttonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.buttonsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
            Me.buttonsPanel.Controls.Add(Me.btnBack, 1, 0)
            Me.buttonsPanel.Controls.Add(Me.btnForward, 4, 0)
            Me.buttonsPanel.Controls.Add(Me.btnPreviousDate, 2, 0)
            Me.buttonsPanel.Controls.Add(Me.btnCurrentDate, 3, 0)
            Me.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.buttonsPanel.Location = New System.Drawing.Point(0, 666)
            Me.buttonsPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.buttonsPanel.Name = "buttonsPanel"
            Me.buttonsPanel.RowCount = 1
            Me.buttonsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.buttonsPanel.Size = New System.Drawing.Size(724, 40)
            Me.buttonsPanel.TabIndex = 2
            '
            'btnBack
            '
            Me.btnBack.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnBack.Image = Global.My.Resources.Resources.ArrowLeft
            Me.btnBack.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.btnBack.Location = New System.Drawing.Point(35, 3)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New System.Drawing.Size(44, 34)
            Me.btnBack.TabIndex = 0
            '
            'btnForward
            '
            Me.btnForward.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnForward.Image = Global.My.Resources.Resources.ArrowRight
            Me.btnForward.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.btnForward.Location = New System.Drawing.Point(659, 3)
            Me.btnForward.Name = "btnForward"
            Me.btnForward.Size = New System.Drawing.Size(44, 34)
            Me.btnForward.TabIndex = 1
            '
            'btnPreviousDate
            '
            Me.btnPreviousDate.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnPreviousDate.Location = New System.Drawing.Point(85, 3)
            Me.btnPreviousDate.Name = "btnPreviousDate"
            Me.btnPreviousDate.Size = New System.Drawing.Size(281, 34)
            Me.btnPreviousDate.TabIndex = 2
            Me.btnPreviousDate.Text = "prev"
            '
            'btnCurrentDate
            '
            Me.btnCurrentDate.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnCurrentDate.Location = New System.Drawing.Point(372, 3)
            Me.btnCurrentDate.Name = "btnCurrentDate"
            Me.btnCurrentDate.Size = New System.Drawing.Size(281, 34)
            Me.btnCurrentDate.TabIndex = 3
            Me.btnCurrentDate.Text = "current"
            '
            'ucSalesPerformance
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutPanel)
            Me.Name = "ucSalesPerformance"
            Me.Size = New System.Drawing.Size(724, 711)
            Me.layoutPanel.ResumeLayout(False)
            CType(TextAnnotation1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(AreaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(AreaSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
            Me.captionPanel.ResumeLayout(False)
            Me.buttonsPanel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private layoutPanel As System.Windows.Forms.TableLayoutPanel
        Public WithEvents chart As XtraCharts.ChartControl
        Private captionPanel As System.Windows.Forms.TableLayoutPanel
		Private buttonsPanel As System.Windows.Forms.TableLayoutPanel
		Private WithEvents btnBack As XtraEditors.SimpleButton
		Private WithEvents btnForward As XtraEditors.SimpleButton
		Private WithEvents btnPreviousDate As XtraEditors.CheckButton
		Private WithEvents btnCurrentDate As XtraEditors.CheckButton
		Private valuePresenter0 As ucValuePresenter
		Private valuePresenter1 As ucValuePresenter
		Private valuePresenter2 As ucValuePresenter
	End Class
End Namespace
