Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Annotations
	Partial Public Class AnnotationDemoBase
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.lblShape = New DevExpress.XtraEditors.LabelControl()
			Me.cbeShape = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblConnector = New DevExpress.XtraEditors.LabelControl()
			Me.cbeConnector = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.tbcAngle = New DevExpress.XtraEditors.ZoomTrackBarControl()
			Me.lblAngle = New DevExpress.XtraEditors.LabelControl()
			Me.sbGeneratePoints = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeShape.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeConnector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbcAngle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbcAngle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.sbGeneratePoints)
			Me.panel.Controls.Add(Me.tbcAngle)
			Me.panel.Controls.Add(Me.lblAngle)
			Me.panel.Controls.Add(Me.lblConnector)
			Me.panel.Controls.Add(Me.cbeConnector)
			Me.panel.Controls.Add(Me.lblShape)
			Me.panel.Controls.Add(Me.cbeShape)
			Me.panel.Controls.SetChildIndex(Me.cbeShape, 0)
			Me.panel.Controls.SetChildIndex(Me.lblShape, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeConnector, 0)
			Me.panel.Controls.SetChildIndex(Me.lblConnector, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.lblAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.tbcAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.sbGeneratePoints, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.Auto = False
			xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "13"
			xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Center
			series1.Label = sideBySideBarSeriesLabel1
			series1.Name = "Random Series"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 2
			' 
			' lblShape
			' 
			Me.lblShape.Location = New System.Drawing.Point(12, 12)
			Me.lblShape.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
			Me.lblShape.Name = "lblShape"
			Me.lblShape.Size = New System.Drawing.Size(34, 13)
			Me.lblShape.TabIndex = 2
			Me.lblShape.Text = "Shape:"
			' 
			' cbeShape
			' 
			Me.cbeShape.EditValue = "Rounded Rectangle"
			Me.cbeShape.Location = New System.Drawing.Point(72, 9)
			Me.cbeShape.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
			Me.cbeShape.Name = "cbeShape"
			Me.cbeShape.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeShape.Properties.Items.AddRange(New Object() { "Rectangle", "Rounded Rectangle", "Ellipse"})
			Me.cbeShape.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeShape.Size = New System.Drawing.Size(122, 20)
			Me.cbeShape.TabIndex = 3
'			Me.cbeShape.SelectedIndexChanged += New System.EventHandler(Me.cbeShape_SelectedIndexChanged);
			' 
			' lblConnector
			' 
			Me.lblConnector.Location = New System.Drawing.Point(12, 40)
			Me.lblConnector.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.lblConnector.Name = "lblConnector"
			Me.lblConnector.Size = New System.Drawing.Size(54, 13)
			Me.lblConnector.TabIndex = 4
			Me.lblConnector.Text = "Connector:"
			' 
			' cbeConnector
			' 
			Me.cbeConnector.EditValue = "Tail"
			Me.cbeConnector.Location = New System.Drawing.Point(72, 37)
			Me.cbeConnector.Name = "cbeConnector"
			Me.cbeConnector.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeConnector.Properties.Items.AddRange(New Object() { "None", "Tail", "Arrow", "Notched Arrow", "Line"})
			Me.cbeConnector.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeConnector.Size = New System.Drawing.Size(122, 20)
			Me.cbeConnector.TabIndex = 5
'			Me.cbeConnector.SelectedIndexChanged += New System.EventHandler(Me.cbeConnector_SelectedIndexChanged);
			' 
			' tbcAngle
			' 
			Me.tbcAngle.EditValue = Nothing
			Me.tbcAngle.Location = New System.Drawing.Point(210, 37)
			Me.tbcAngle.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.tbcAngle.Name = "tbcAngle"
			Me.tbcAngle.Properties.HighlightSelectedRange = False
			Me.tbcAngle.Properties.LargeChange = 10
			Me.tbcAngle.Properties.Maximum = 360
			Me.tbcAngle.Properties.Middle = 180
			Me.tbcAngle.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.tbcAngle.Properties.ShowValueToolTip = True
			Me.tbcAngle.Properties.SmallChange = 5
			Me.tbcAngle.Size = New System.Drawing.Size(120, 16)
			Me.tbcAngle.TabIndex = 6
'			Me.tbcAngle.EditValueChanged += New System.EventHandler(Me.tbcAngle_EditValueChanged);
			' 
			' lblAngle
			' 
			Me.lblAngle.Location = New System.Drawing.Point(254, 12)
			Me.lblAngle.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.lblAngle.Name = "lblAngle"
			Me.lblAngle.Size = New System.Drawing.Size(31, 13)
			Me.lblAngle.TabIndex = 7
			Me.lblAngle.Text = "Angle:"
			' 
			' sbGeneratePoints
			' 
			Me.sbGeneratePoints.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.sbGeneratePoints.Location = New System.Drawing.Point(589, 7)
			Me.sbGeneratePoints.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.sbGeneratePoints.Name = "sbGeneratePoints"
			Me.sbGeneratePoints.Size = New System.Drawing.Size(99, 23)
			Me.sbGeneratePoints.TabIndex = 8
			Me.sbGeneratePoints.Text = "Generate Points"
'			Me.sbGeneratePoints.Click += New System.EventHandler(Me.sbGeneratePoints_Click);
			' 
			' AnnotationDemoBase
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "AnnotationDemoBase"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeShape.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeConnector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbcAngle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbcAngle, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Private lblConnector As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbeConnector As DevExpress.XtraEditors.ComboBoxEdit
		Private lblShape As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbeShape As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents tbcAngle As DevExpress.XtraEditors.ZoomTrackBarControl
		Private lblAngle As DevExpress.XtraEditors.LabelControl
		Private WithEvents sbGeneratePoints As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace
