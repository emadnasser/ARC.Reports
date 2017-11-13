Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class EqualSizeForPiesDoughnutsDemo
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
			Dim simpleDiagram1 As New DevExpress.XtraCharts.SimpleDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pieSeriesLabel1 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("Chang", New Object() { (CObj(304R))}, 0)
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("Chai", New Object() { (CObj(518.4R))}, 1)
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("Steeleye Stout", New Object() { (CObj(288R))}, 2)
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("Sasquatch Ale", New Object() { (CObj(224R))}, 3)
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("Ipoh Coffee", New Object() { (CObj(441.6R))}, 4)
			Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
			Dim seriesTitle1 As New DevExpress.XtraCharts.SeriesTitle()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pieSeriesLabel2 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("Gula Malacca", New Object() { (CObj(325.5R))}, 0)
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("Vegie-spread", New Object() { (CObj(175.5R))}, 1)
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("Sirop d'érable", New Object() { (CObj(342R))}, 2)
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("Genen Shouyu", New Object() { (CObj(400R))}, 3)
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("Northwoods Cranberry", New Object() { (CObj(100R))}, 4)
			Dim pieSeriesView2 As New DevExpress.XtraCharts.PieSeriesView()
			Dim seriesTitle2 As New DevExpress.XtraCharts.SeriesTitle()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim pieSeriesLabel3 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("Queso Cabrales", New Object() { (CObj(168R))}, 0)
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("Mozzarella di Giovanni", New Object() { (CObj(112.2R))}, 1)
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("Geitost", New Object() { (CObj(47.5R))}, 2)
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("Camembert Pierrot", New Object() { (CObj(1088R))}, 3)
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("Gorgonzola Telino", New Object() { (CObj(200R))}, 4)
			Dim pieSeriesView3 As New DevExpress.XtraCharts.PieSeriesView()
			Dim seriesTitle3 As New DevExpress.XtraCharts.SeriesTitle()
			Dim pieSeriesLabel4 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim pieSeriesView4 As New DevExpress.XtraCharts.PieSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.cheEqualPieSize = New DevExpress.XtraEditors.CheckEdit()
			Me.tbcMinAllowedSizePercentage = New DevExpress.XtraEditors.TrackBarControl()
			Me.lcMinAllowedSize = New DevExpress.XtraEditors.LabelControl()
			Me.cbeView = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lcView = New DevExpress.XtraEditors.LabelControl()
			Me.sbRestoreDefaultLayout = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheEqualPieSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbcMinAllowedSizePercentage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbcMinAllowedSizePercentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.sbRestoreDefaultLayout)
			Me.panel.Controls.Add(Me.lcView)
			Me.panel.Controls.Add(Me.cbeView)
			Me.panel.Controls.Add(Me.lcMinAllowedSize)
			Me.panel.Controls.Add(Me.tbcMinAllowedSizePercentage)
			Me.panel.Controls.Add(Me.cheEqualPieSize)
			Me.panel.Size = New System.Drawing.Size(1013, 66)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.cheEqualPieSize, 0)
			Me.panel.Controls.SetChildIndex(Me.tbcMinAllowedSizePercentage, 0)
			Me.panel.Controls.SetChildIndex(Me.lcMinAllowedSize, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeView, 0)
			Me.panel.Controls.SetChildIndex(Me.lcView, 0)
			Me.panel.Controls.SetChildIndex(Me.sbRestoreDefaultLayout, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(8586, 10)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 4
			Me.checkEditShowLabels.Visible = False
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(1013, 74)
			' 
			' chart
			' 
			Me.chart.AutoLayout = False
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			simpleDiagram1.Dimension = 2
			Me.chart.Diagram = simpleDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.PaletteName = "Pastel Kit"
			pieSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			pieSeriesLabel1.Font = New System.Drawing.Font("Tahoma", 12F)
			pieSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
			pieSeriesLabel1.TextPattern = "{A} - {VP:P0}"
			series1.Label = pieSeriesLabel1
			series1.Name = "Beverages"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
			pieSeriesView1.MinAllowedSizePercentage = 10R
			seriesTitle1.Font = New System.Drawing.Font("Tahoma", 16F)
			pieSeriesView1.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() { seriesTitle1})
			series1.View = pieSeriesView1
			pieSeriesLabel2.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			pieSeriesLabel2.Font = New System.Drawing.Font("Tahoma", 12F)
			pieSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
			pieSeriesLabel2.TextPattern = "{A} - {VP:P0}"
			series2.Label = pieSeriesLabel2
			series2.Name = "Condiments"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10})
			pieSeriesView2.MinAllowedSizePercentage = 0R
			pieSeriesView2.Rotation = 10
			seriesTitle2.Font = New System.Drawing.Font("Tahoma", 16F)
			pieSeriesView2.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() { seriesTitle2})
			series2.View = pieSeriesView2
			pieSeriesLabel3.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			pieSeriesLabel3.Font = New System.Drawing.Font("Tahoma", 12F)
			pieSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
			pieSeriesLabel3.TextPattern = "{A} - {VP:P0}"
			series3.Label = pieSeriesLabel3
			series3.Name = "Dairy Products"
			series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15})
			pieSeriesView3.MinAllowedSizePercentage = 10R
			pieSeriesView3.Rotation = -25
			seriesTitle3.Font = New System.Drawing.Font("Tahoma", 16F)
			pieSeriesView3.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() { seriesTitle3})
			series3.View = pieSeriesView3
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3}
			pieSeriesLabel4.TextPattern = "{VP:G2}"
			Me.chart.SeriesTemplate.Label = pieSeriesLabel4
			Me.chart.SeriesTemplate.View = pieSeriesView4
			Me.chart.Size = New System.Drawing.Size(1013, 591)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Company Sales Comparison by Year"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			Me.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True
			' 
			' cheEqualPieSize
			' 
			Me.cheEqualPieSize.Location = New System.Drawing.Point(12, 9)
			Me.cheEqualPieSize.Name = "cheEqualPieSize"
			Me.cheEqualPieSize.Properties.Caption = "Equal Size"
			Me.cheEqualPieSize.Size = New System.Drawing.Size(88, 19)
			Me.cheEqualPieSize.TabIndex = 1
'			Me.cheEqualPieSize.CheckedChanged += New System.EventHandler(Me.cheEqualPieSize_CheckedChanged);
			' 
			' tbcMinAllowedSizePercentage
			' 
			Me.tbcMinAllowedSizePercentage.EditValue = 10
			Me.tbcMinAllowedSizePercentage.Location = New System.Drawing.Point(180, 33)
			Me.tbcMinAllowedSizePercentage.Name = "tbcMinAllowedSizePercentage"
			Me.tbcMinAllowedSizePercentage.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.tbcMinAllowedSizePercentage.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.tbcMinAllowedSizePercentage.Properties.Maximum = 70
			Me.tbcMinAllowedSizePercentage.Properties.Minimum = 10
			Me.tbcMinAllowedSizePercentage.Properties.ShowValueToolTip = True
			Me.tbcMinAllowedSizePercentage.Properties.SmallChange = 5
			Me.tbcMinAllowedSizePercentage.Properties.TickFrequency = 10
			Me.tbcMinAllowedSizePercentage.Properties.TickStyle = System.Windows.Forms.TickStyle.None
			Me.tbcMinAllowedSizePercentage.Size = New System.Drawing.Size(178, 45)
			Me.tbcMinAllowedSizePercentage.TabIndex = 5
			Me.tbcMinAllowedSizePercentage.Value = 10
'			Me.tbcMinAllowedSizePercentage.BeforeShowValueToolTip += New DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(Me.tbcMinAllowedSizePercentage_BeforeShowValueToolTip);
'			Me.tbcMinAllowedSizePercentage.EditValueChanged += New System.EventHandler(Me.tbcMinAllowedSizePercentage_EditValueChanged);
			' 
			' lcMinAllowedSize
			' 
			Me.lcMinAllowedSize.Location = New System.Drawing.Point(180, 12)
			Me.lcMinAllowedSize.Name = "lcMinAllowedSize"
			Me.lcMinAllowedSize.Size = New System.Drawing.Size(178, 13)
			Me.lcMinAllowedSize.TabIndex = 6
			Me.lcMinAllowedSize.Text = "Minimum Allowed Size for Condiments"
			' 
			' cbeView
			' 
			Me.cbeView.EditValue = "Pie"
			Me.cbeView.Location = New System.Drawing.Point(44, 37)
			Me.cbeView.Name = "cbeView"
			Me.cbeView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeView.Properties.Items.AddRange(New Object() { "Pie", "Doughnut"})
			Me.cbeView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeView.Size = New System.Drawing.Size(100, 20)
			Me.cbeView.TabIndex = 7
'			Me.cbeView.SelectedIndexChanged += New System.EventHandler(Me.cbeView_SelectedIndexChanged);
			' 
			' lcView
			' 
			Me.lcView.Location = New System.Drawing.Point(12, 40)
			Me.lcView.Name = "lcView"
			Me.lcView.Size = New System.Drawing.Size(26, 13)
			Me.lcView.TabIndex = 8
			Me.lcView.Text = "View:"
			' 
			' sbRestoreDefaultLayout
			' 
			Me.sbRestoreDefaultLayout.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.sbRestoreDefaultLayout.Location = New System.Drawing.Point(878, 14)
			Me.sbRestoreDefaultLayout.Name = "sbRestoreDefaultLayout"
			Me.sbRestoreDefaultLayout.Size = New System.Drawing.Size(120, 38)
			Me.sbRestoreDefaultLayout.TabIndex = 9
			Me.sbRestoreDefaultLayout.Text = "Restore Default " & Constants.vbCrLf & "Layout"
'			Me.sbRestoreDefaultLayout.Click += New System.EventHandler(Me.seRestoreDefaultLayout_Click);
			' 
			' EqualSizeForPiesDoughnutsDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.MinimumSize = New System.Drawing.Size(1013, 665)
			Me.Name = "EqualSizeForPiesDoughnutsDemo"
			Me.Size = New System.Drawing.Size(1013, 665)
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheEqualPieSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbcMinAllowedSizePercentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbcMinAllowedSizePercentage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents cheEqualPieSize As XtraEditors.CheckEdit
		Private chart As XtraCharts.ChartControl
		Private WithEvents tbcMinAllowedSizePercentage As XtraEditors.TrackBarControl
		Private lcMinAllowedSize As XtraEditors.LabelControl
		Private lcView As XtraEditors.LabelControl
		Private WithEvents cbeView As XtraEditors.ComboBoxEdit
		Private WithEvents sbRestoreDefaultLayout As XtraEditors.SimpleButton

	End Class
End Namespace
