Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class ToolTipsDemo
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
			Me.components = New System.ComponentModel.Container()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim barWidenAnimation1 As New DevExpress.XtraCharts.BarWidenAnimation()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.lblToolTipPosition = New DevExpress.XtraEditors.LabelControl()
			Me.cbToolTipPosition = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.defaultToolTipController = New DevExpress.Utils.DefaultToolTipController(Me.components)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbToolTipPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.defaultToolTipController.SetAllowHtmlText(Me.panel, DevExpress.Utils.DefaultBoolean.Default)
			Me.panel.Controls.Add(Me.lblToolTipPosition)
			Me.panel.Controls.Add(Me.cbToolTipPosition)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.cbToolTipPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.lblToolTipPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 4
			Me.checkEditShowLabels.Visible = False
			' 
			' panelRoot
			' 
			Me.defaultToolTipController.SetAllowHtmlText(Me.panelRoot, DevExpress.Utils.DefaultBoolean.Default)
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Interlaced = True
			xyDiagram1.AxisX.MinorCount = 7
			xyDiagram1.AxisX.Title.Text = "Date"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.VisualRange.Auto = False
			xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "2015"
			xyDiagram1.AxisX.VisualRange.MinValueSerializable = "2000"
			xyDiagram1.AxisX.WholeRange.Auto = False
			xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "2015"
			xyDiagram1.AxisX.WholeRange.MinValueSerializable = "2000"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Label.TextPattern = "{V:N0}"
			xyDiagram1.AxisY.Title.Text = ""
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "CountryName"
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "G7 GDP in 2015"
			series1.ValueDataMembersSerializable = "GDPin2015"
			barWidenAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
			sideBySideBarSeriesView1.Animation = barWidenAnimation1
			sideBySideBarSeriesView1.ColorEach = True
			series1.View = sideBySideBarSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "G7 GDP in 2015, in Billions of US$"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "The World Bank: GDP (current US$)"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			Me.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True
			' 
			' lblToolTipPosition
			' 
			Me.lblToolTipPosition.Location = New System.Drawing.Point(12, 12)
			Me.lblToolTipPosition.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.lblToolTipPosition.Name = "lblToolTipPosition"
			Me.lblToolTipPosition.Size = New System.Drawing.Size(81, 13)
			Me.lblToolTipPosition.TabIndex = 60
			Me.lblToolTipPosition.Text = "Tool Tip Position:"
			' 
			' cbToolTipPosition
			' 
			Me.cbToolTipPosition.EditValue = "Mouse Pointer"
			Me.cbToolTipPosition.Location = New System.Drawing.Point(96, 9)
			Me.cbToolTipPosition.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.cbToolTipPosition.Name = "cbToolTipPosition"
			Me.cbToolTipPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbToolTipPosition.Properties.Items.AddRange(New Object() { "Mouse Pointer", "Relative", "Free"})
			Me.cbToolTipPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbToolTipPosition.Size = New System.Drawing.Size(141, 20)
			Me.cbToolTipPosition.TabIndex = 0
'			Me.cbToolTipPosition.SelectedIndexChanged += New System.EventHandler(Me.cbToolTipPosition_SelectedIndexChanged);
			' 
			' defaultToolTipController
			' 
			' 
			' 
			' 
			Me.defaultToolTipController.DefaultController.AppearanceTitle.Options.UseTextOptions = True
			Me.defaultToolTipController.DefaultController.AppearanceTitle.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.defaultToolTipController.DefaultController.AppearanceTitle.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.defaultToolTipController.DefaultController.AutoPopDelay = 90000
			Me.defaultToolTipController.DefaultController.Rounded = True
			Me.defaultToolTipController.DefaultController.ShowBeak = True
			Me.defaultToolTipController.DefaultController.ShowShadow = False
			Me.defaultToolTipController.DefaultController.ToolTipLocation = DevExpress.Utils.ToolTipLocation.TopRight
'			Me.defaultToolTipController.DefaultController.BeforeShow += New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(Me.defaultToolTipController_DefaultController_BeforeShow);
			' 
			' ToolTipsDemo
			' 
			Me.defaultToolTipController.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.Default)
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "ToolTipsDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbToolTipPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private lblToolTipPosition As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbToolTipPosition As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents defaultToolTipController As DevExpress.Utils.DefaultToolTipController

	End Class
End Namespace
