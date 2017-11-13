Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class About
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
			Me.rtbAbout = New System.Windows.Forms.RichTextBox()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.rtbAboutNew = New System.Windows.Forms.RichTextBox()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			Me.xtraTabPage2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' rtbAbout
			' 
			Me.rtbAbout.BackColor = System.Drawing.SystemColors.Window
			Me.rtbAbout.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.rtbAbout.Dock = System.Windows.Forms.DockStyle.Fill
			Me.rtbAbout.Location = New System.Drawing.Point(0, 0)
			Me.rtbAbout.Name = "rtbAbout"
			Me.rtbAbout.ReadOnly = True
			Me.rtbAbout.Size = New System.Drawing.Size(427, 229)
			Me.rtbAbout.TabIndex = 0
			Me.rtbAbout.Text = ""
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(4, 4)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(427, 252)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			Me.xtraTabControl1.Text = "xtraTabControl1"
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.rtbAboutNew)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(418, 222)
			Me.xtraTabPage1.Text = "New features"
			' 
			' rtbAboutNew
			' 
			Me.rtbAboutNew.BackColor = System.Drawing.SystemColors.Window
			Me.rtbAboutNew.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.rtbAboutNew.Dock = System.Windows.Forms.DockStyle.Fill
			Me.rtbAboutNew.Location = New System.Drawing.Point(0, 0)
			Me.rtbAboutNew.Name = "rtbAboutNew"
			Me.rtbAboutNew.ReadOnly = True
			Me.rtbAboutNew.Size = New System.Drawing.Size(418, 222)
			Me.rtbAboutNew.TabIndex = 2
			Me.rtbAboutNew.Text = ""
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.rtbAbout)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(427, 229)
			Me.xtraTabPage2.Text = "Features"
			' 
			' About
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "About"
			Me.Size = New System.Drawing.Size(435, 260)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.About_Load);
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			Me.xtraTabPage2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private rtbAbout As System.Windows.Forms.RichTextBox
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private rtbAboutNew As System.Windows.Forms.RichTextBox
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
