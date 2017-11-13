Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraTreeList.Demos.Tutorials
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
            Me.lbNode = New DevExpress.XtraEditors.LabelControl
            Me.lbColumn = New DevExpress.XtraEditors.LabelControl
            Me.lbHitTest = New DevExpress.XtraEditors.LabelControl
            Me.label5 = New DevExpress.XtraEditors.LabelControl
            Me.label4 = New DevExpress.XtraEditors.LabelControl
            Me.label3 = New DevExpress.XtraEditors.LabelControl
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.lbCellValue)
            Me.panel2.Controls.Add(Me.label7)
            Me.panel2.Controls.Add(Me.lbNode)
            Me.panel2.Controls.Add(Me.lbColumn)
            Me.panel2.Controls.Add(Me.lbHitTest)
            Me.panel2.Controls.Add(Me.label5)
            Me.panel2.Controls.Add(Me.label4)
            Me.panel2.Controls.Add(Me.label3)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(616, 41)
            Me.panel2.TabIndex = 6
            '
            'lbCellValue
            '
            Me.lbCellValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbCellValue.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbCellValue.Appearance.Options.UseBackColor = True
            Me.lbCellValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbCellValue.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbCellValue.Location = New System.Drawing.Point(470, 10)
            Me.lbCellValue.Name = "lbCellValue"
            Me.lbCellValue.Padding = New System.Windows.Forms.Padding(2)
            Me.lbCellValue.Size = New System.Drawing.Size(71, 18)
            Me.lbCellValue.TabIndex = 1
            '
            'label7
            '
            Me.label7.Location = New System.Drawing.Point(417, 13)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(47, 13)
            Me.label7.TabIndex = 0
            Me.label7.Text = "CellValue:"
            '
            'lbNode
            '
            Me.lbNode.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbNode.Appearance.Options.UseBackColor = True
            Me.lbNode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbNode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbNode.Location = New System.Drawing.Point(358, 10)
            Me.lbNode.Name = "lbNode"
            Me.lbNode.Padding = New System.Windows.Forms.Padding(2)
            Me.lbNode.Size = New System.Drawing.Size(42, 18)
            Me.lbNode.TabIndex = 1
            '
            'lbColumn
            '
            Me.lbColumn.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbColumn.Appearance.Options.UseBackColor = True
            Me.lbColumn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbColumn.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbColumn.Location = New System.Drawing.Point(218, 10)
            Me.lbColumn.Name = "lbColumn"
            Me.lbColumn.Padding = New System.Windows.Forms.Padding(2)
            Me.lbColumn.Size = New System.Drawing.Size(80, 18)
            Me.lbColumn.TabIndex = 1
            '
            'lbHitTest
            '
            Me.lbHitTest.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbHitTest.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lbHitTest.Appearance.Options.UseBackColor = True
            Me.lbHitTest.Appearance.Options.UseFont = True
            Me.lbHitTest.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbHitTest.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbHitTest.Location = New System.Drawing.Point(56, 10)
            Me.lbHitTest.Name = "lbHitTest"
            Me.lbHitTest.Padding = New System.Windows.Forms.Padding(2)
            Me.lbHitTest.Size = New System.Drawing.Size(100, 18)
            Me.lbHitTest.TabIndex = 1
            '
            'label5
            '
            Me.label5.Location = New System.Drawing.Point(312, 13)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(40, 13)
            Me.label5.TabIndex = 0
            Me.label5.Text = "NodeID:"
            '
            'label4
            '
            Me.label4.Location = New System.Drawing.Point(173, 13)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(39, 13)
            Me.label4.TabIndex = 0
            Me.label4.Text = "Column:"
            '
            'label3
            '
            Me.label3.Location = New System.Drawing.Point(12, 13)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(38, 13)
            Me.label3.TabIndex = 0
            Me.label3.Text = "HitTest:"
            '
            'treeList1
            '
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 49)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.Size = New System.Drawing.Size(616, 251)
            Me.treeList1.TabIndex = 7
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 41)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(616, 8)
            Me.panelControl1.TabIndex = 9
            '
            'HitInfo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel2)
            Me.Name = "HitInfo"
            Me.Size = New System.Drawing.Size(616, 300)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private panel2 As PanelControl
        Private lbCellValue As DevExpress.XtraEditors.LabelControl
        Private label7 As DevExpress.XtraEditors.LabelControl
        Private lbNode As DevExpress.XtraEditors.LabelControl
        Private lbColumn As DevExpress.XtraEditors.LabelControl
        Private lbHitTest As DevExpress.XtraEditors.LabelControl
        Private label5 As DevExpress.XtraEditors.LabelControl
        Private label4 As DevExpress.XtraEditors.LabelControl
        Private label3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As PanelControl

	End Class
End Namespace
