Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleSparklineEdit
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
			Dim lineSparklineView1 As New DevExpress.Sparkline.LineSparklineView()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.ceMarkers = New DevExpress.XtraEditors.ColorEdit()
			Me.cheShowMarkers = New DevExpress.XtraEditors.CheckEdit()
			Me.trbArea = New DevExpress.XtraEditors.TrackBarControl()
			Me.lblArea = New DevExpress.XtraEditors.LabelControl()
			Me.ceNegative = New DevExpress.XtraEditors.ColorEdit()
			Me.cheHighlightNegativePoints = New DevExpress.XtraEditors.CheckEdit()
			Me.lblColor = New DevExpress.XtraEditors.LabelControl()
			Me.ceColor = New DevExpress.XtraEditors.ColorEdit()
			Me.ceMax = New DevExpress.XtraEditors.ColorEdit()
			Me.ceEnd = New DevExpress.XtraEditors.ColorEdit()
			Me.ceMin = New DevExpress.XtraEditors.ColorEdit()
			Me.ceStart = New DevExpress.XtraEditors.ColorEdit()
			Me.cheHighlightEndPoint = New DevExpress.XtraEditors.CheckEdit()
			Me.cheHighlightStartPoint = New DevExpress.XtraEditors.CheckEdit()
			Me.cheHighlightMinPoint = New DevExpress.XtraEditors.CheckEdit()
			Me.cheHighlightMaxPoint = New DevExpress.XtraEditors.CheckEdit()
			Me.cbeView = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblView = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.sparklineEdit = New DevExpress.XtraEditors.SparklineEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.ceMarkers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheShowMarkers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trbArea, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trbArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceNegative.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheHighlightNegativePoints.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheHighlightEndPoint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheHighlightStartPoint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheHighlightMinPoint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheHighlightMaxPoint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.sparklineEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(857, 639)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl2)
			Me.xtraTabPage1.Controls.Add(Me.groupControl3)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(851, 633)
			Me.xtraTabPage1.Text = "Layout and Appearance"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.ceMarkers)
			Me.groupControl2.Controls.Add(Me.cheShowMarkers)
			Me.groupControl2.Controls.Add(Me.trbArea)
			Me.groupControl2.Controls.Add(Me.lblArea)
			Me.groupControl2.Controls.Add(Me.ceNegative)
			Me.groupControl2.Controls.Add(Me.cheHighlightNegativePoints)
			Me.groupControl2.Controls.Add(Me.lblColor)
			Me.groupControl2.Controls.Add(Me.ceColor)
			Me.groupControl2.Controls.Add(Me.ceMax)
			Me.groupControl2.Controls.Add(Me.ceEnd)
			Me.groupControl2.Controls.Add(Me.ceMin)
			Me.groupControl2.Controls.Add(Me.ceStart)
			Me.groupControl2.Controls.Add(Me.cheHighlightEndPoint)
			Me.groupControl2.Controls.Add(Me.cheHighlightStartPoint)
			Me.groupControl2.Controls.Add(Me.cheHighlightMinPoint)
			Me.groupControl2.Controls.Add(Me.cheHighlightMaxPoint)
			Me.groupControl2.Controls.Add(Me.cbeView)
			Me.groupControl2.Controls.Add(Me.lblView)
			Me.groupControl2.Location = New System.Drawing.Point(314, 30)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(320, 333)
			Me.groupControl2.TabIndex = 4
			Me.groupControl2.Text = "Properties"
			' 
			' ceMarkers
			' 
			Me.ceMarkers.EditValue = System.Drawing.Color.Empty
			Me.ceMarkers.Location = New System.Drawing.Point(173, 283)
			Me.ceMarkers.Name = "ceMarkers"
			Me.ceMarkers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.ceMarkers.Size = New System.Drawing.Size(125, 20)
			Me.ceMarkers.TabIndex = 32
'			Me.ceMarkers.EditValueChanged += New System.EventHandler(Me.ceMarkers_EditValueChanged)
			' 
			' cheShowMarkers
			' 
			Me.cheShowMarkers.Location = New System.Drawing.Point(18, 284)
			Me.cheShowMarkers.Name = "cheShowMarkers"
			Me.cheShowMarkers.Properties.AutoWidth = True
			Me.cheShowMarkers.Properties.Caption = "Show Markers"
			Me.cheShowMarkers.Size = New System.Drawing.Size(89, 19)
			Me.cheShowMarkers.TabIndex = 31
'			Me.cheShowMarkers.CheckedChanged += New System.EventHandler(Me.cheShowMarkers_CheckedChanged)
			' 
			' trbArea
			' 
			Me.trbArea.EditValue = Nothing
			Me.trbArea.Location = New System.Drawing.Point(173, 90)
			Me.trbArea.Name = "trbArea"
			Me.trbArea.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.trbArea.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.trbArea.Properties.Maximum = 255
			Me.trbArea.Size = New System.Drawing.Size(125, 45)
			Me.trbArea.TabIndex = 30
'			Me.trbArea.EditValueChanged += New System.EventHandler(Me.trbArea_EditValueChanged)
			' 
			' lblArea
			' 
			Me.lblArea.Location = New System.Drawing.Point(20, 92)
			Me.lblArea.Name = "lblArea"
			Me.lblArea.Size = New System.Drawing.Size(67, 13)
			Me.lblArea.TabIndex = 29
			Me.lblArea.Text = "Area Opacity:"
			' 
			' ceNegative
			' 
			Me.ceNegative.EditValue = System.Drawing.Color.Empty
			Me.ceNegative.Location = New System.Drawing.Point(173, 254)
			Me.ceNegative.Name = "ceNegative"
			Me.ceNegative.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.ceNegative.Size = New System.Drawing.Size(125, 20)
			Me.ceNegative.TabIndex = 28
'			Me.ceNegative.EditValueChanged += New System.EventHandler(Me.ceNegative_EditValueChanged)
			' 
			' cheHighlightNegativePoints
			' 
			Me.cheHighlightNegativePoints.Location = New System.Drawing.Point(18, 255)
			Me.cheHighlightNegativePoints.Name = "cheHighlightNegativePoints"
			Me.cheHighlightNegativePoints.Properties.AutoWidth = True
			Me.cheHighlightNegativePoints.Properties.Caption = "Highlight Negative Points"
			Me.cheHighlightNegativePoints.Size = New System.Drawing.Size(141, 19)
			Me.cheHighlightNegativePoints.TabIndex = 27
'			Me.cheHighlightNegativePoints.CheckedChanged += New System.EventHandler(Me.cheHighlightNegativePoints_CheckedChanged)
			' 
			' lblColor
			' 
			Me.lblColor.Location = New System.Drawing.Point(20, 61)
			Me.lblColor.Name = "lblColor"
			Me.lblColor.Size = New System.Drawing.Size(29, 13)
			Me.lblColor.TabIndex = 26
			Me.lblColor.Text = "Color:"
			' 
			' ceColor
			' 
			Me.ceColor.EditValue = System.Drawing.Color.Empty
			Me.ceColor.Location = New System.Drawing.Point(173, 62)
			Me.ceColor.Name = "ceColor"
			Me.ceColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.ceColor.Size = New System.Drawing.Size(125, 20)
			Me.ceColor.TabIndex = 25
'			Me.ceColor.EditValueChanged += New System.EventHandler(Me.ceColor_EditValueChanged)
			' 
			' ceMax
			' 
			Me.ceMax.EditValue = System.Drawing.Color.Empty
			Me.ceMax.Location = New System.Drawing.Point(173, 225)
			Me.ceMax.Name = "ceMax"
			Me.ceMax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.ceMax.Size = New System.Drawing.Size(125, 20)
			Me.ceMax.TabIndex = 24
'			Me.ceMax.EditValueChanged += New System.EventHandler(Me.ceMax_EditValueChanged)
			' 
			' ceEnd
			' 
			Me.ceEnd.EditValue = System.Drawing.Color.Empty
			Me.ceEnd.Location = New System.Drawing.Point(173, 167)
			Me.ceEnd.Name = "ceEnd"
			Me.ceEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.ceEnd.Size = New System.Drawing.Size(125, 20)
			Me.ceEnd.TabIndex = 23
'			Me.ceEnd.EditValueChanged += New System.EventHandler(Me.ceEnd_EditValueChanged)
			' 
			' ceMin
			' 
			Me.ceMin.EditValue = System.Drawing.Color.Empty
			Me.ceMin.Location = New System.Drawing.Point(173, 196)
			Me.ceMin.Name = "ceMin"
			Me.ceMin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.ceMin.Size = New System.Drawing.Size(125, 20)
			Me.ceMin.TabIndex = 22
'			Me.ceMin.EditValueChanged += New System.EventHandler(Me.ceMin_EditValueChanged)
			' 
			' ceStart
			' 
			Me.ceStart.EditValue = System.Drawing.Color.Empty
			Me.ceStart.Location = New System.Drawing.Point(173, 138)
			Me.ceStart.Name = "ceStart"
			Me.ceStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.ceStart.Size = New System.Drawing.Size(125, 20)
			Me.ceStart.TabIndex = 21
'			Me.ceStart.EditValueChanged += New System.EventHandler(Me.ceStart_EditValueChanged)
			' 
			' cheHighlightEndPoint
			' 
			Me.cheHighlightEndPoint.Location = New System.Drawing.Point(18, 168)
			Me.cheHighlightEndPoint.Name = "cheHighlightEndPoint"
			Me.cheHighlightEndPoint.Properties.AutoWidth = True
			Me.cheHighlightEndPoint.Properties.Caption = "Highlight End Point"
			Me.cheHighlightEndPoint.Size = New System.Drawing.Size(111, 19)
			Me.cheHighlightEndPoint.TabIndex = 20
'			Me.cheHighlightEndPoint.CheckedChanged += New System.EventHandler(Me.cheHighlightEndPoint_CheckedChanged)
			' 
			' cheHighlightStartPoint
			' 
			Me.cheHighlightStartPoint.Location = New System.Drawing.Point(18, 139)
			Me.cheHighlightStartPoint.Name = "cheHighlightStartPoint"
			Me.cheHighlightStartPoint.Properties.AutoWidth = True
			Me.cheHighlightStartPoint.Properties.Caption = "Highlight Start Point"
			Me.cheHighlightStartPoint.Size = New System.Drawing.Size(117, 19)
			Me.cheHighlightStartPoint.TabIndex = 19
'			Me.cheHighlightStartPoint.CheckedChanged += New System.EventHandler(Me.cheHighlightStartPoint_CheckedChanged)
			' 
			' cheHighlightMinPoint
			' 
			Me.cheHighlightMinPoint.Location = New System.Drawing.Point(18, 197)
			Me.cheHighlightMinPoint.Name = "cheHighlightMinPoint"
			Me.cheHighlightMinPoint.Properties.AutoWidth = True
			Me.cheHighlightMinPoint.Properties.Caption = "Highlight Min Point"
			Me.cheHighlightMinPoint.Size = New System.Drawing.Size(109, 19)
			Me.cheHighlightMinPoint.TabIndex = 18
'			Me.cheHighlightMinPoint.CheckedChanged += New System.EventHandler(Me.cheHighlightMinPoint_CheckedChanged)
			' 
			' cheHighlightMaxPoint
			' 
			Me.cheHighlightMaxPoint.Location = New System.Drawing.Point(18, 226)
			Me.cheHighlightMaxPoint.Name = "cheHighlightMaxPoint"
			Me.cheHighlightMaxPoint.Properties.AutoWidth = True
			Me.cheHighlightMaxPoint.Properties.Caption = "Highlight Max Point"
			Me.cheHighlightMaxPoint.Size = New System.Drawing.Size(113, 19)
			Me.cheHighlightMaxPoint.TabIndex = 17
'			Me.cheHighlightMaxPoint.CheckedChanged += New System.EventHandler(Me.cheHighlightMaxPoint_CheckedChanged)
			' 
			' cbeView
			' 
			Me.cbeView.Location = New System.Drawing.Point(173, 33)
			Me.cbeView.Name = "cbeView"
			Me.cbeView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeView.Size = New System.Drawing.Size(125, 20)
			Me.cbeView.TabIndex = 16
'			Me.cbeView.SelectedIndexChanged += New System.EventHandler(Me.cbeView_SelectedIndexChanged)
			' 
			' lblView
			' 
			Me.lblView.Location = New System.Drawing.Point(20, 35)
			Me.lblView.Name = "lblView"
			Me.lblView.Size = New System.Drawing.Size(26, 13)
			Me.lblView.TabIndex = 7
			Me.lblView.Text = "View:"
			' 
			' groupControl3
			' 
			Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl3.Appearance.Options.UseBackColor = True
			Me.groupControl3.Controls.Add(Me.sparklineEdit)
			Me.groupControl3.Location = New System.Drawing.Point(30, 30)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New System.Drawing.Size(253, 333)
			Me.groupControl3.TabIndex = 0
			Me.groupControl3.Text = "Sample"
			' 
			' sparklineEdit
			' 
			Me.sparklineEdit.EditValue = New Double() { 2R, 4R, 5R, 1R, -1R, -2R, -1R, 2R, 4R, 5R, 6R, 3R, 5R}
			Me.sparklineEdit.Location = New System.Drawing.Point(23, 112)
			Me.sparklineEdit.Name = "sparklineEdit"
			Me.sparklineEdit.Properties.Padding = New System.Windows.Forms.Padding(5)
			Me.sparklineEdit.Properties.View = lineSparklineView1
			Me.sparklineEdit.Size = New System.Drawing.Size(207, 91)
			Me.sparklineEdit.TabIndex = 0
			' 
			' ModuleSparklineEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleSparklineEdit"
			Me.Size = New System.Drawing.Size(862, 644)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.ceMarkers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheShowMarkers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trbArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trbArea, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceNegative.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheHighlightNegativePoints.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheHighlightEndPoint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheHighlightStartPoint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheHighlightMinPoint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheHighlightMaxPoint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			CType(Me.sparklineEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private lblView As DevExpress.XtraEditors.LabelControl
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private sparklineEdit As DevExpress.XtraEditors.SparklineEdit
		Private WithEvents cbeView As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents ceNegative As DevExpress.XtraEditors.ColorEdit
		Private WithEvents cheHighlightNegativePoints As DevExpress.XtraEditors.CheckEdit
		Private lblColor As DevExpress.XtraEditors.LabelControl
		Private WithEvents ceColor As DevExpress.XtraEditors.ColorEdit
		Private WithEvents ceMax As DevExpress.XtraEditors.ColorEdit
		Private WithEvents ceEnd As DevExpress.XtraEditors.ColorEdit
		Private WithEvents ceMin As DevExpress.XtraEditors.ColorEdit
		Private WithEvents ceStart As DevExpress.XtraEditors.ColorEdit
		Private WithEvents cheHighlightEndPoint As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cheHighlightStartPoint As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cheHighlightMinPoint As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cheHighlightMaxPoint As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceMarkers As DevExpress.XtraEditors.ColorEdit
		Private WithEvents cheShowMarkers As DevExpress.XtraEditors.CheckEdit
		Private WithEvents trbArea As DevExpress.XtraEditors.TrackBarControl
		Private lblArea As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
