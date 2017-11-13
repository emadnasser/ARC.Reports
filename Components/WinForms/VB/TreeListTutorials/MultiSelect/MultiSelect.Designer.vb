Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class MultiSelect
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
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList
            Me.panel2 = New DevExpress.XtraEditors.PanelControl
            Me.lbSelectedRowsCount = New DevExpress.XtraEditors.LabelControl
            Me.cbMultiSelect = New DevExpress.XtraEditors.CheckEdit
            Me.label3 = New DevExpress.XtraEditors.LabelControl
            Me.panel3 = New DevExpress.XtraEditors.PanelControl
            Me.lbSelectedRows = New DevExpress.XtraEditors.LabelControl
            Me.label4 = New DevExpress.XtraEditors.LabelControl
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.cbMultiSelect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'treeList1
            '
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 50)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.Size = New System.Drawing.Size(553, 206)
            Me.treeList1.TabIndex = 6
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.lbSelectedRowsCount)
            Me.panel2.Controls.Add(Me.cbMultiSelect)
            Me.panel2.Controls.Add(Me.label3)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(553, 42)
            Me.panel2.TabIndex = 7
            '
            'lbSelectedRowsCount
            '
            Me.lbSelectedRowsCount.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbSelectedRowsCount.Appearance.Options.UseBackColor = True
            Me.lbSelectedRowsCount.Appearance.Options.UseTextOptions = True
            Me.lbSelectedRowsCount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbSelectedRowsCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbSelectedRowsCount.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbSelectedRowsCount.Location = New System.Drawing.Point(242, 11)
            Me.lbSelectedRowsCount.Name = "lbSelectedRowsCount"
            Me.lbSelectedRowsCount.Padding = New System.Windows.Forms.Padding(2)
            Me.lbSelectedRowsCount.Size = New System.Drawing.Size(41, 18)
            Me.lbSelectedRowsCount.TabIndex = 4
            '
            'cbMultiSelect
            '
            Me.cbMultiSelect.Location = New System.Drawing.Point(10, 12)
            Me.cbMultiSelect.Name = "cbMultiSelect"
            Me.cbMultiSelect.Properties.Caption = "Multi Select"
            Me.cbMultiSelect.Size = New System.Drawing.Size(100, 18)
            Me.cbMultiSelect.TabIndex = 3
            '
            'label3
            '
            Me.label3.Location = New System.Drawing.Point(126, 14)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(110, 13)
            Me.label3.TabIndex = 2
            Me.label3.Text = "Selected Nodes Count:"
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.lbSelectedRows)
            Me.panel3.Controls.Add(Me.label4)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel3.Location = New System.Drawing.Point(0, 264)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(553, 36)
            Me.panel3.TabIndex = 8
            '
            'lbSelectedRows
            '
            Me.lbSelectedRows.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbSelectedRows.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.lbSelectedRows.Appearance.Options.UseBackColor = True
            Me.lbSelectedRows.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbSelectedRows.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.lbSelectedRows.Location = New System.Drawing.Point(96, 9)
            Me.lbSelectedRows.Name = "lbSelectedRows"
            Me.lbSelectedRows.Padding = New System.Windows.Forms.Padding(2)
            Me.lbSelectedRows.Size = New System.Drawing.Size(451, 18)
            Me.lbSelectedRows.TabIndex = 1
            '
            'label4
            '
            Me.label4.Location = New System.Drawing.Point(12, 12)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(78, 13)
            Me.label4.TabIndex = 0
            Me.label4.Text = "Selected Nodes:"
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 42)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(553, 8)
            Me.panelControl1.TabIndex = 9
            '
            'panelControl2
            '
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl2.Location = New System.Drawing.Point(0, 256)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(553, 8)
            Me.panelControl2.TabIndex = 10
            '
            'MultiSelect
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.panel2)
            Me.Name = "MultiSelect"
            Me.Size = New System.Drawing.Size(553, 300)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            CType(Me.cbMultiSelect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
        Private panel2 As PanelControl
        Private lbSelectedRowsCount As DevExpress.XtraEditors.LabelControl
        Private WithEvents cbMultiSelect As DevExpress.XtraEditors.CheckEdit
        Private label3 As DevExpress.XtraEditors.LabelControl
        Private panel3 As PanelControl
        Private lbSelectedRows As DevExpress.XtraEditors.LabelControl
        Private label4 As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
