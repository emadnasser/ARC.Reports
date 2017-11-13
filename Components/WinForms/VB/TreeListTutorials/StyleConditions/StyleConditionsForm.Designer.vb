Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class StyleConditionsForm
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
            Me.propertyGrid1 = New DevExpress.DXperience.Demos.XtraPropertyGrid
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGrid1.Location = New System.Drawing.Point(0, 0)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.ShowCategories = False
            Me.propertyGrid1.ShowDescription = False
            Me.propertyGrid1.Size = New System.Drawing.Size(295, 285)
            Me.propertyGrid1.TabIndex = 0
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.listBoxControl1)
            Me.splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.propertyGrid1)
            Me.splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(456, 289)
            Me.splitContainerControl1.SplitterPosition = 151
            Me.splitContainerControl1.TabIndex = 1
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'listBoxControl1
            '
            Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl1.Location = New System.Drawing.Point(0, 0)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(147, 285)
            Me.listBoxControl1.TabIndex = 0
            '
            'StyleConditionsForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(456, 289)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "StyleConditionsForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Style Conditions"
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region
        Private propertyGrid1 As DevExpress.DXperience.Demos.XtraPropertyGrid
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
