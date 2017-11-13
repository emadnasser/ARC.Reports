Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.BarViews
	Partial Public Class FullStackedBarSideBySideDemo
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim fullStackedBarSeriesLabel1 As New DevExpress.XtraCharts.FullStackedBarSeriesLabel()
			Dim sideBySideFullStackedBarSeriesView1 As New DevExpress.XtraCharts.SideBySideFullStackedBarSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle3 As New DevExpress.XtraCharts.ChartTitle()
			Me.lblGroup = New DevExpress.XtraEditors.LabelControl()
			Me.radioGroup = New DevExpress.XtraEditors.RadioGroup()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.checkValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(fullStackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideFullStackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.checkValueAsPercent)
			Me.panel.Controls.Add(Me.lblGroup)
			Me.panel.Controls.Add(Me.radioGroup)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.radioGroup, 0)
			Me.panel.Controls.SetChildIndex(Me.lblGroup, 0)
			Me.panel.Controls.SetChildIndex(Me.checkValueAsPercent, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' lblGroup
			' 
			Me.lblGroup.Location = New System.Drawing.Point(12, 12)
			Me.lblGroup.Name = "lblGroup"
			Me.lblGroup.Size = New System.Drawing.Size(80, 13)
			Me.lblGroup.TabIndex = 4
			Me.lblGroup.Text = "Group Series by:"
			' 
			' radioGroup
			' 
			Me.radioGroup.Location = New System.Drawing.Point(98, 8)
			Me.radioGroup.Name = "radioGroup"
			Me.radioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.radioGroup.Properties.Appearance.Options.UseBackColor = True
			Me.radioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.radioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Gender"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Age")})
			Me.radioGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.radioGroup.Size = New System.Drawing.Size(123, 22)
			Me.radioGroup.TabIndex = 5
'			Me.radioGroup.SelectedIndexChanged += New System.EventHandler(Me.radioGroup_SelectedIndexChanged);
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.Tickmarks.MinorVisible = False
			xyDiagram1.AxisX.Title.Text = "Countries"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Interlaced = True
			xyDiagram1.AxisY.Label.TextPattern = "{V:P0}"
			xyDiagram1.AxisY.Title.Text = "Percent"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisualRange.Auto = False
			xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "1"
			xyDiagram1.AxisY.VisualRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.WholeRange.Auto = False
			xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "1"
			xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
			Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
			Me.chart.Legend.BackColor = System.Drawing.Color.Transparent
			Me.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "GenderAge"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Country"
			Me.chart.SeriesTemplate.CrosshairLabelPattern = "{S}" & Constants.vbLf & "{V:0,,.00} million"
			fullStackedBarSeriesLabel1.TextPattern = "{VP:P0}"
			Me.chart.SeriesTemplate.Label = fullStackedBarSeriesLabel1
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Population"
			Me.chart.SeriesTemplate.View = sideBySideFullStackedBarSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 2
			chartTitle1.Text = "Population: Age Structure"
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 12F)
			chartTitle2.Text = "Data estimate for mid-2016"
			chartTitle3.Alignment = System.Drawing.StringAlignment.Far
			chartTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle3.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle3.Text = "From www.cia.gov"
			chartTitle3.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2, chartTitle3})
'			Me.chart.BoundDataChanged += New DevExpress.XtraCharts.BoundDataChangedEventHandler(Me.chart_BoundDataChanged);
			' 
			' checkValueAsPercent
			' 
			Me.checkValueAsPercent.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkValueAsPercent.Location = New System.Drawing.Point(492, 9)
			Me.checkValueAsPercent.Margin = New System.Windows.Forms.Padding(0)
			Me.checkValueAsPercent.Name = "checkValueAsPercent"
			Me.checkValueAsPercent.Properties.Caption = "Value As Percent"
			Me.checkValueAsPercent.Size = New System.Drawing.Size(104, 19)
			Me.checkValueAsPercent.TabIndex = 6
'			Me.checkValueAsPercent.CheckedChanged += New System.EventHandler(Me.checkValueAsPercent_CheckedChanged);
			' 
			' FullStackedBarSideBySideDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "FullStackedBarSideBySideDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(fullStackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideFullStackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lblGroup As DevExpress.XtraEditors.LabelControl
		Private WithEvents radioGroup As DevExpress.XtraEditors.RadioGroup
		Private WithEvents chart As ChartControl
		Private WithEvents checkValueAsPercent As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace
