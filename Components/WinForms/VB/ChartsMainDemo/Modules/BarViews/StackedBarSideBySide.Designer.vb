Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.BarViews
	Partial Public Class StackedBarSideBySideDemo
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
			Dim stackedBarSeriesLabel1 As New DevExpress.XtraCharts.StackedBarSeriesLabel()
			Dim sideBySideStackedBarSeriesView1 As New DevExpress.XtraCharts.SideBySideStackedBarSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle3 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.lblGroup = New DevExpress.XtraEditors.LabelControl()
			Me.radioGroup = New DevExpress.XtraEditors.RadioGroup()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideStackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.lblGroup)
			Me.panel.Controls.Add(Me.radioGroup)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.radioGroup, 0)
			Me.panel.Controls.SetChildIndex(Me.lblGroup, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
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
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.Tickmarks.MinorVisible = False
			xyDiagram1.AxisX.Title.Text = "Countries"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Interlaced = True
			xyDiagram1.AxisY.Label.TextPattern = "{V:0,,}"
			xyDiagram1.AxisY.Title.Text = "Population, millions"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.Margins.Bottom = 10
			Me.chart.Legend.Margins.Left = 10
			Me.chart.Legend.Margins.Right = 10
			Me.chart.Legend.Margins.Top = 10
			Me.chart.Legend.MaxHorizontalPercentage = 75R
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "GenderAge"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Country"
			Me.chart.SeriesTemplate.CrosshairLabelPattern = "{S}" & Constants.vbLf & "{V:0,,.0} million"
			stackedBarSeriesLabel1.TextPattern = "{V:0,,.000}"
			Me.chart.SeriesTemplate.Label = stackedBarSeriesLabel1
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Population"
			Me.chart.SeriesTemplate.View = sideBySideStackedBarSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 2
			chartTitle1.Text = "Population: Age Structure"
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 12F)
			chartTitle2.Text = "Data estimate for end-2016"
			chartTitle3.Alignment = System.Drawing.StringAlignment.Far
			chartTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle3.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle3.Text = "From www.cia.gov"
			chartTitle3.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2, chartTitle3})
'			Me.chart.BoundDataChanged += New DevExpress.XtraCharts.BoundDataChangedEventHandler(Me.chart_BoundDataChanged);
			' 
			' lblGroup
			' 
			Me.lblGroup.Location = New System.Drawing.Point(12, 12)
			Me.lblGroup.Name = "lblGroup"
			Me.lblGroup.Size = New System.Drawing.Size(80, 13)
			Me.lblGroup.TabIndex = 2
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
			Me.radioGroup.TabIndex = 3
'			Me.radioGroup.SelectedIndexChanged += New System.EventHandler(Me.radioGroup_SelectedIndexChanged);
			' 
			' StackedBarSideBySideDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "StackedBarSideBySideDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideStackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chart As ChartControl
		Private lblGroup As DevExpress.XtraEditors.LabelControl
		Private WithEvents radioGroup As DevExpress.XtraEditors.RadioGroup
	End Class
End Namespace
