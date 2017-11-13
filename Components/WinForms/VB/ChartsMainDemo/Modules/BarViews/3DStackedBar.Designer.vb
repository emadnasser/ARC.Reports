Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.BarViews
	Partial Public Class StackedBar3dDemo
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
			Dim stackedBar3DSeriesLabel1 As New DevExpress.XtraCharts.StackedBar3DSeriesLabel()
			Dim stackedBar3DSeriesView1 As New DevExpress.XtraCharts.StackedBar3DSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.labelPerspective = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxEditPerspective = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxBar3DModel = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label3DModel = New DevExpress.XtraEditors.LabelControl()
			Me.checkEditShowFacet = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedBar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedBar3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxBar3DModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditShowFacet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnDefaultAngles
			' 
			Me.btnDefaultAngles.Location = New System.Drawing.Point(200, 8)
			Me.btnDefaultAngles.TabIndex = 1
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.checkEditShowFacet)
			Me.panel.Controls.Add(Me.comboBoxBar3DModel)
			Me.panel.Controls.Add(Me.label3DModel)
			Me.panel.Controls.Add(Me.labelPerspective)
			Me.panel.Controls.Add(Me.comboBoxEditPerspective)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditPerspective, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPerspective, 0)
			Me.panel.Controls.SetChildIndex(Me.label3DModel, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxBar3DModel, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowFacet, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.TabIndex = 2
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram3D1.AxisY.Label.TextPattern = "{V:0,,}M"
			xyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
			xyDiagram3D1.RuntimeRotation = True
			xyDiagram3D1.RuntimeScrolling = True
			xyDiagram3D1.RuntimeZooming = True
			xyDiagram3D1.VerticalScrollPercent = 4R
			xyDiagram3D1.ZoomPercent = 150
			Me.chart.Diagram = xyDiagram3D1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Age"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesSorting = DevExpress.XtraCharts.SortingMode.Descending
			Me.chart.SeriesTemplate.ArgumentDataMember = "Country"
			stackedBar3DSeriesLabel1.TextPattern = "{V:0,,.0}"
			Me.chart.SeriesTemplate.Label = stackedBar3DSeriesLabel1
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Population"
			Me.chart.SeriesTemplate.View = stackedBar3DSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 2
			chartTitle1.Text = "Female Age Structure"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.cia.gov"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' labelPerspective
			' 
			Me.labelPerspective.Location = New System.Drawing.Point(12, 12)
			Me.labelPerspective.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelPerspective.Name = "labelPerspective"
			Me.labelPerspective.Size = New System.Drawing.Size(90, 13)
			Me.labelPerspective.TabIndex = 56
			Me.labelPerspective.Text = "Perspective Angle:"
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
			Me.checkEditShowFacet.Size = New System.Drawing.Size(79, 19)
			Me.checkEditShowFacet.TabIndex = 61
'			Me.checkEditShowFacet.CheckedChanged += New System.EventHandler(Me.checkEditShowFacet_CheckedChanged);
			' 
			' StackedBar3dDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "StackedBar3dDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedBar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedBar3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxBar3DModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditShowFacet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private components As System.ComponentModel.IContainer = Nothing
		Private labelPerspective As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBoxEditPerspective As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents comboBoxBar3DModel As DevExpress.XtraEditors.ComboBoxEdit
		Private label3DModel As DevExpress.XtraEditors.LabelControl
		Private WithEvents checkEditShowFacet As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
