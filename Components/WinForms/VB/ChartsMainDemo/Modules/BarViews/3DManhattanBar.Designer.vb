Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.BarViews
	Partial Public Class ManhattanBarDemo
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
			Dim bar3DSeriesLabel1 As New DevExpress.XtraCharts.Bar3DSeriesLabel()
			Dim manhattanBarSeriesView1 As New DevExpress.XtraCharts.ManhattanBarSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.comboBoxEditPerspective = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelPerspective = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxBar3DModel = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label3DModel = New DevExpress.XtraEditors.LabelControl()
			Me.checkEditShowFacet = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(manhattanBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxBar3DModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditShowFacet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnDefaultAngles
			' 
			Me.btnDefaultAngles.Location = New System.Drawing.Point(200, 8)
			Me.btnDefaultAngles.Margin = New System.Windows.Forms.Padding(10, 10, 10, 0)
			Me.btnDefaultAngles.TabIndex = 1
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.checkEditShowFacet)
			Me.panel.Controls.Add(Me.comboBoxBar3DModel)
			Me.panel.Controls.Add(Me.label3DModel)
			Me.panel.Controls.Add(Me.labelPerspective)
			Me.panel.Controls.Add(Me.comboBoxEditPerspective)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditPerspective, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPerspective, 0)
			Me.panel.Controls.SetChildIndex(Me.label3DModel, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxBar3DModel, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowFacet, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 2
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram3D1.AxisY.Label.TextPattern = "${V}M"
			xyDiagram3D1.AxisY.NumericScaleOptions.AutoGrid = False
			xyDiagram3D1.AxisY.NumericScaleOptions.GridSpacing = 100R
			xyDiagram3D1.RotationType = DevExpress.XtraCharts.RotationType.UseAngles
			xyDiagram3D1.RuntimeRotation = True
			xyDiagram3D1.RuntimeScrolling = True
			xyDiagram3D1.RuntimeZooming = True
			xyDiagram3D1.VerticalScrollPercent = 6R
			xyDiagram3D1.ZoomPercent = 130
			Me.chart.Diagram = xyDiagram3D1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Year"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesSorting = DevExpress.XtraCharts.SortingMode.Descending
			Me.chart.SeriesTemplate.ArgumentDataMember = "Region"
			bar3DSeriesLabel1.TextPattern = "{V:n2}"
			Me.chart.SeriesTemplate.Label = bar3DSeriesLabel1
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales"
			Me.chart.SeriesTemplate.View = manhattanBarSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			chartTitle1.Text = "DevAV Sales by Regions"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
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
			' comboBoxBar3DModel
			' 
			Me.comboBoxBar3DModel.Location = New System.Drawing.Point(105, 37)
			Me.comboBoxBar3DModel.Name = "comboBoxBar3DModel"
			Me.comboBoxBar3DModel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxBar3DModel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxBar3DModel.Size = New System.Drawing.Size(78, 20)
			Me.comboBoxBar3DModel.TabIndex = 58
'			Me.comboBoxBar3DModel.SelectedIndexChanged += New System.EventHandler(Me.comboBoxBar3DModel_SelectedIndexChanged);
			' 
			' label3DModel
			' 
			Me.label3DModel.Location = New System.Drawing.Point(12, 40)
			Me.label3DModel.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.label3DModel.Name = "label3DModel"
			Me.label3DModel.Size = New System.Drawing.Size(48, 13)
			Me.label3DModel.TabIndex = 57
			Me.label3DModel.Text = "3D Model:"
			' 
			' checkEditShowFacet
			' 
			Me.checkEditShowFacet.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEditShowFacet.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowFacet.Name = "checkEditShowFacet"
			Me.checkEditShowFacet.Properties.Caption = "Show Facet"
			Me.checkEditShowFacet.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowFacet.TabIndex = 60
'			Me.checkEditShowFacet.CheckedChanged += New System.EventHandler(Me.checkEditShowFacet_CheckedChanged);
			' 
			' ManhattanBarDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "ManhattanBarDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(manhattanBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxBar3DModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditShowFacet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelPerspective As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBoxBar3DModel As DevExpress.XtraEditors.ComboBoxEdit
		Private label3DModel As DevExpress.XtraEditors.LabelControl
		Private WithEvents checkEditShowFacet As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
