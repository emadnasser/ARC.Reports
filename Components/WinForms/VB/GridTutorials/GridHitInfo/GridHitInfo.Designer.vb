Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridHitInfoForm
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
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
            Me.panel1 = New DevExpress.XtraEditors.PanelControl
            Me.lbBand = New DevExpress.XtraEditors.LabelControl
            Me.label2 = New DevExpress.XtraEditors.LabelControl
            Me.lbCellValue = New DevExpress.XtraEditors.LabelControl
            Me.label7 = New DevExpress.XtraEditors.LabelControl
            Me.lbRow = New DevExpress.XtraEditors.LabelControl
            Me.lbColumn = New DevExpress.XtraEditors.LabelControl
            Me.lbHitTest = New DevExpress.XtraEditors.LabelControl
            Me.label5 = New DevExpress.XtraEditors.LabelControl
            Me.label4 = New DevExpress.XtraEditors.LabelControl
            Me.label3 = New DevExpress.XtraEditors.LabelControl
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panel1.Controls.Add(Me.lbBand)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.lbCellValue)
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.lbRow)
            Me.panel1.Controls.Add(Me.lbColumn)
            Me.panel1.Controls.Add(Me.lbHitTest)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 386)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(685, 80)
            Me.panel1.TabIndex = 3
            '
            'lbBand
            '
            Me.lbBand.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbBand.Appearance.Options.UseBackColor = True
            Me.lbBand.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbBand.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbBand.Location = New System.Drawing.Point(68, 30)
            Me.lbBand.Name = "lbBand"
            Me.lbBand.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
            Me.lbBand.Size = New System.Drawing.Size(243, 18)
            Me.lbBand.TabIndex = 11
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(4, 32)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(28, 13)
            Me.label2.TabIndex = 10
            Me.label2.Text = "Band:"
            '
            'lbCellValue
            '
            Me.lbCellValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbCellValue.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbCellValue.Appearance.Options.UseBackColor = True
            Me.lbCellValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbCellValue.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbCellValue.Location = New System.Drawing.Point(373, 54)
            Me.lbCellValue.Name = "lbCellValue"
            Me.lbCellValue.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
            Me.lbCellValue.Size = New System.Drawing.Size(298, 18)
            Me.lbCellValue.TabIndex = 7
            '
            'label7
            '
            Me.label7.Location = New System.Drawing.Point(320, 56)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(47, 13)
            Me.label7.TabIndex = 5
            Me.label7.Text = "CellValue:"
            '
            'lbRow
            '
            Me.lbRow.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbRow.Appearance.Options.UseBackColor = True
            Me.lbRow.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbRow.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbRow.Location = New System.Drawing.Point(68, 54)
            Me.lbRow.Name = "lbRow"
            Me.lbRow.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
            Me.lbRow.Size = New System.Drawing.Size(243, 18)
            Me.lbRow.TabIndex = 8
            '
            'lbColumn
            '
            Me.lbColumn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbColumn.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbColumn.Appearance.Options.UseBackColor = True
            Me.lbColumn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbColumn.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbColumn.Location = New System.Drawing.Point(373, 30)
            Me.lbColumn.Name = "lbColumn"
            Me.lbColumn.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
            Me.lbColumn.Size = New System.Drawing.Size(298, 18)
            Me.lbColumn.TabIndex = 9
            '
            'lbHitTest
            '
            Me.lbHitTest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbHitTest.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbHitTest.Appearance.Options.UseBackColor = True
            Me.lbHitTest.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbHitTest.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbHitTest.Location = New System.Drawing.Point(68, 6)
            Me.lbHitTest.Name = "lbHitTest"
            Me.lbHitTest.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
            Me.lbHitTest.Size = New System.Drawing.Size(603, 18)
            Me.lbHitTest.TabIndex = 6
            '
            'label5
            '
            Me.label5.Location = New System.Drawing.Point(4, 56)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(58, 13)
            Me.label5.TabIndex = 3
            Me.label5.Text = "RowHandle:"
            '
            'label4
            '
            Me.label4.Location = New System.Drawing.Point(328, 32)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(39, 13)
            Me.label4.TabIndex = 2
            Me.label4.Text = "Column:"
            '
            'label3
            '
            Me.label3.Location = New System.Drawing.Point(4, 8)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(38, 13)
            Me.label3.TabIndex = 4
            Me.label3.Text = "HitTest:"
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.advBandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(685, 386)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.advBandedGridView1})
            '
            'advBandedGridView1
            '
            Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1})
            Me.advBandedGridView1.GridControl = Me.gridControl1
            Me.advBandedGridView1.Name = "advBandedGridView1"
            '
            'gridBand1
            '
            Me.gridBand1.Caption = "gridBand1"
            Me.gridBand1.Name = "gridBand1"
            '
            'GridHitInfoForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridHitInfoForm"
            Me.Size = New System.Drawing.Size(685, 466)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
        Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Private lbCellValue As DevExpress.XtraEditors.LabelControl
        Private label7 As DevExpress.XtraEditors.LabelControl
        Private lbRow As DevExpress.XtraEditors.LabelControl
        Private lbColumn As DevExpress.XtraEditors.LabelControl
        Private lbHitTest As DevExpress.XtraEditors.LabelControl
        Private label5 As DevExpress.XtraEditors.LabelControl
        Private label4 As DevExpress.XtraEditors.LabelControl
        Private label3 As DevExpress.XtraEditors.LabelControl
        Private lbBand As DevExpress.XtraEditors.LabelControl
        Private label2 As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
