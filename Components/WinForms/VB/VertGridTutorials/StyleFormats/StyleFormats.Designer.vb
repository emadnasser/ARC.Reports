Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class StyleFormats
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
			Me.panel2 = New PanelControl()
			Me.lsStyles = New DevExpress.XtraEditors.ListBoxControl()
			Me.label3 = New System.Windows.Forms.Label()
			Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.panel2.SuspendLayout()
			CType(Me.lsStyles, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.lsStyles)
			Me.panel2.Controls.Add(Me.label3)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Padding = New System.Windows.Forms.Padding(4)
			Me.panel2.Size = New System.Drawing.Size(128, 482)
			Me.panel2.TabIndex = 9
			' 
			' lsStyles
			' 
			Me.lsStyles.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lsStyles.ItemHeight = 15
			Me.lsStyles.Location = New System.Drawing.Point(4, 24)
			Me.lsStyles.Name = "lsStyles"
			Me.lsStyles.Size = New System.Drawing.Size(120, 454)
			Me.lsStyles.TabIndex = 16
'			Me.lsStyles.SelectedIndexChanged += New System.EventHandler(Me.lsStyles_SelectedIndexChanged);
			' 
			' label3
			' 
			Me.label3.Dock = System.Windows.Forms.DockStyle.Top
			Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.label3.Location = New System.Drawing.Point(4, 4)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(120, 20)
			Me.label3.TabIndex = 17
			Me.label3.Text = "Style Formats:"
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' splitter1
			' 
			Me.splitter1.Location = New System.Drawing.Point(128, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(6, 482)
			Me.splitter1.TabIndex = 10
			Me.splitter1.TabStop = False
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(134, 0)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.Size = New System.Drawing.Size(349, 482)
			Me.vGridControl1.TabIndex = 11
			' 
			' StyleFormats
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "StyleFormats"
			Me.Size = New System.Drawing.Size(483, 482)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.StyleFormats_Load);
			Me.panel2.ResumeLayout(False)
			CType(Me.lsStyles, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel2 As PanelControl
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private WithEvents lsStyles As DevExpress.XtraEditors.ListBoxControl
		Private label3 As System.Windows.Forms.Label
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
