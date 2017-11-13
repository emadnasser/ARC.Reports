Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class CheckBoxesInLegendDemo
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
			Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.checkEditUseCheckBoxes = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditUseCheckBoxes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.checkEdit2)
			Me.panel.Controls.Add(Me.checkEditUseCheckBoxes)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditUseCheckBoxes, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEdit2, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.Visible = False
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
			Me.chart.AutoLayout = False
			Me.chart.CrosshairOptions.GroupHeaderPattern = "<b>Year: {A:yyyy}</b>"
			Me.chart.CrosshairOptions.ShowArgumentLine = False
			Me.chart.DataBindings = Nothing
			xyDiagram2.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
			xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram2.AxisY.Label.TextPattern = "{V:C0}"
			xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chart.Diagram = xyDiagram2
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.UseCheckBoxes = True
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Series"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Year"
			Me.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			Me.chart.SeriesTemplate.CrosshairLabelPattern = "{S}: {V:c0}"
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Value"
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 2
			chartTitle2.Text = "Goods Sales by Years"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle2})
'			Me.chart.BoundDataChanged += New DevExpress.XtraCharts.BoundDataChangedEventHandler(Me.chart_BoundDataChanged);
			' 
			' checkEditUseCheckBoxes
			' 
			Me.checkEditUseCheckBoxes.EditValue = True
			Me.checkEditUseCheckBoxes.Location = New System.Drawing.Point(12, 9)
			Me.checkEditUseCheckBoxes.Name = "checkEditUseCheckBoxes"
			Me.checkEditUseCheckBoxes.Properties.Caption = "Use Check Boxes in Legend"
			Me.checkEditUseCheckBoxes.Size = New System.Drawing.Size(161, 19)
			Me.checkEditUseCheckBoxes.TabIndex = 2
'			Me.checkEditUseCheckBoxes.CheckedChanged += New System.EventHandler(Me.checkEditUseCheckBoxes_CheckedChanged);
			' 
			' checkEdit2
			' 
			Me.checkEdit2.EditValue = True
			Me.checkEdit2.Location = New System.Drawing.Point(191, 9)
			Me.checkEdit2.Name = "checkEdit2"
			Me.checkEdit2.Properties.Caption = "Checkable Indicators"
			Me.checkEdit2.Size = New System.Drawing.Size(161, 19)
			Me.checkEdit2.TabIndex = 3
'			Me.checkEdit2.CheckedChanged += New System.EventHandler(Me.checkEdit2_CheckedChanged);
			' 
			' CheckBoxesInLegendDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "CheckBoxesInLegendDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditUseCheckBoxes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chart As ChartControl
		Private WithEvents checkEdit2 As XtraEditors.CheckEdit
		Private WithEvents checkEditUseCheckBoxes As XtraEditors.CheckEdit
	End Class
End Namespace
