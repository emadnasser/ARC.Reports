Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Partial Public Class NodeChecking
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
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.panel2 = New DevExpress.XtraEditors.PanelControl
            Me.chkAllowIndeterminate = New DevExpress.XtraEditors.CheckEdit
            Me.chkAllowRecursive = New DevExpress.XtraEditors.CheckEdit
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.chkAllowIndeterminate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAllowRecursive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'treeList1
            '
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 50)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.AllowRecursiveNodeChecking = True
            Me.treeList1.OptionsView.ShowCheckBoxes = True
            Me.treeList1.Size = New System.Drawing.Size(551, 250)
            Me.treeList1.TabIndex = 6
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 42)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(551, 8)
            Me.panelControl1.TabIndex = 14
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.chkAllowIndeterminate)
            Me.panel2.Controls.Add(Me.chkAllowRecursive)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(551, 42)
            Me.panel2.TabIndex = 13
            '
            'chkAllowIndeterminate
            '
            Me.chkAllowIndeterminate.Location = New System.Drawing.Point(193, 12)
            Me.chkAllowIndeterminate.Name = "chkAllowIndeterminate"
            Me.chkAllowIndeterminate.Properties.Caption = "Allow Indeterminate Check State"
            Me.chkAllowIndeterminate.Size = New System.Drawing.Size(187, 19)
            Me.chkAllowIndeterminate.TabIndex = 3
            '
            'chkAllowRecursive
            '
            Me.chkAllowRecursive.EditValue = True
            Me.chkAllowRecursive.Location = New System.Drawing.Point(10, 12)
            Me.chkAllowRecursive.Name = "chkAllowRecursive"
            Me.chkAllowRecursive.Properties.Caption = "Allow Recursive Node Checking"
            Me.chkAllowRecursive.Size = New System.Drawing.Size(177, 19)
            Me.chkAllowRecursive.TabIndex = 3
            '
            'NodeChecking
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel2)
            Me.Name = "NodeChecking"
            Me.Size = New System.Drawing.Size(551, 300)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            CType(Me.chkAllowIndeterminate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAllowRecursive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
        Private components As System.ComponentModel.IContainer
        Private WithEvents panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents panel2 As DevExpress.XtraEditors.PanelControl
        Private WithEvents chkAllowIndeterminate As DevExpress.XtraEditors.CheckEdit
        Private WithEvents chkAllowRecursive As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
