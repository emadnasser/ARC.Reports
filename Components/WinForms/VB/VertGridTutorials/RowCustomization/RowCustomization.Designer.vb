Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class RowCustomization
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
            Me.sbCustomize = New DevExpress.XtraEditors.SimpleButton
            Me.splitter1 = New DevExpress.XtraEditors.SplitterControl
            Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.sbCustomize)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(332, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Padding = New System.Windows.Forms.Padding(8)
            Me.panel2.Size = New System.Drawing.Size(108, 474)
            Me.panel2.TabIndex = 7
            '
            'sbCustomize
            '
            Me.sbCustomize.Dock = System.Windows.Forms.DockStyle.Top
            Me.sbCustomize.Location = New System.Drawing.Point(8, 8)
            Me.sbCustomize.Name = "sbCustomize"
            Me.sbCustomize.Size = New System.Drawing.Size(92, 61)
            Me.sbCustomize.TabIndex = 2
            Me.sbCustomize.Text = "Customize..."
            '
            'splitter1
            '
            Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
            Me.splitter1.Location = New System.Drawing.Point(326, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(6, 474)
            Me.splitter1.TabIndex = 8
            Me.splitter1.TabStop = False
            '
            'vGridControl1
            '
            Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.vGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.vGridControl1.Name = "vGridControl1"
            Me.vGridControl1.Size = New System.Drawing.Size(326, 474)
            Me.vGridControl1.TabIndex = 9
            '
            'RowCustomization
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.vGridControl1)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.panel2)
            Me.Name = "RowCustomization"
            Me.Size = New System.Drawing.Size(440, 474)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private panel2 As PanelControl
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private WithEvents vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private WithEvents sbCustomize As DevExpress.XtraEditors.SimpleButton
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
