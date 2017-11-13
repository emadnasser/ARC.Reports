Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class HitInfo
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
            Me.panel2 = New DevExpress.XtraEditors.PanelControl
            Me.lbCellValue = New DevExpress.XtraEditors.LabelControl
            Me.label7 = New DevExpress.XtraEditors.LabelControl
            Me.lbRow = New DevExpress.XtraEditors.LabelControl
            Me.lbHitTest = New DevExpress.XtraEditors.LabelControl
            Me.label4 = New DevExpress.XtraEditors.LabelControl
            Me.label3 = New DevExpress.XtraEditors.LabelControl
            Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.lbCellValue)
            Me.panel2.Controls.Add(Me.label7)
            Me.panel2.Controls.Add(Me.lbRow)
            Me.panel2.Controls.Add(Me.lbHitTest)
            Me.panel2.Controls.Add(Me.label4)
            Me.panel2.Controls.Add(Me.label3)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(404, 75)
            Me.panel2.TabIndex = 8
            '
            'lbCellValue
            '
            Me.lbCellValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbCellValue.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbCellValue.Appearance.Options.UseBackColor = True
            Me.lbCellValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbCellValue.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbCellValue.Location = New System.Drawing.Point(66, 44)
            Me.lbCellValue.Name = "lbCellValue"
            Me.lbCellValue.Padding = New System.Windows.Forms.Padding(2)
            Me.lbCellValue.Size = New System.Drawing.Size(318, 18)
            Me.lbCellValue.TabIndex = 1
            '
            'label7
            '
            Me.label7.Location = New System.Drawing.Point(12, 47)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(47, 13)
            Me.label7.TabIndex = 0
            Me.label7.Text = "CellValue:"
            '
            'lbRow
            '
            Me.lbRow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbRow.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbRow.Appearance.Options.UseBackColor = True
            Me.lbRow.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbRow.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbRow.Location = New System.Drawing.Point(215, 10)
            Me.lbRow.Name = "lbRow"
            Me.lbRow.Padding = New System.Windows.Forms.Padding(2)
            Me.lbRow.Size = New System.Drawing.Size(169, 18)
            Me.lbRow.TabIndex = 1
            '
            'lbHitTest
            '
            Me.lbHitTest.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbHitTest.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lbHitTest.Appearance.Options.UseBackColor = True
            Me.lbHitTest.Appearance.Options.UseFont = True
            Me.lbHitTest.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbHitTest.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbHitTest.Location = New System.Drawing.Point(66, 10)
            Me.lbHitTest.Name = "lbHitTest"
            Me.lbHitTest.Padding = New System.Windows.Forms.Padding(2)
            Me.lbHitTest.Size = New System.Drawing.Size(98, 18)
            Me.lbHitTest.TabIndex = 1
            '
            'label4
            '
            Me.label4.Location = New System.Drawing.Point(180, 13)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(25, 13)
            Me.label4.TabIndex = 0
            Me.label4.Text = "Row:"
            '
            'label3
            '
            Me.label3.Location = New System.Drawing.Point(12, 13)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(38, 13)
            Me.label3.TabIndex = 0
            Me.label3.Text = "HitTest:"
            '
            'vGridControl1
            '
            Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.vGridControl1.Location = New System.Drawing.Point(0, 83)
            Me.vGridControl1.Name = "vGridControl1"
            Me.vGridControl1.Size = New System.Drawing.Size(404, 459)
            Me.vGridControl1.TabIndex = 9
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 75)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(404, 8)
            Me.panelControl1.TabIndex = 13
            '
            'HitInfo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.vGridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel2)
            Me.Name = "HitInfo"
            Me.Size = New System.Drawing.Size(404, 542)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private panel2 As PanelControl
        Private lbCellValue As DevExpress.XtraEditors.LabelControl
        Private label7 As DevExpress.XtraEditors.LabelControl
        Private lbRow As DevExpress.XtraEditors.LabelControl
        Private lbHitTest As DevExpress.XtraEditors.LabelControl
        Private label4 As DevExpress.XtraEditors.LabelControl
        Private label3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl1 As PanelControl

	End Class
End Namespace
