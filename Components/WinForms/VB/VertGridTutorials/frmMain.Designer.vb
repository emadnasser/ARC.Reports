Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class frmMain
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlCaption.SuspendLayout()
            CType(Me.gcNavigations, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcNavigations.SuspendLayout()
            CType(Me.gcContainer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.horzSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcDescription.SuspendLayout()
            CType(Me.pcMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pcMain.SuspendLayout()
            CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnWhatsThis
            '
            Me.btnWhatsThis.Location = New System.Drawing.Point(640, 9)
            Me.btnWhatsThis.Size = New System.Drawing.Size(96, 37)
            '
            'btnAbout
            '
            Me.btnAbout.Location = New System.Drawing.Point(76, 9)
            '
            'pnlHint
            '
            Me.pnlHint.Size = New System.Drawing.Size(696, 33)
            '
            'pnlCaption
            '
            Me.pnlCaption.Location = New System.Drawing.Point(204, 22)
            Me.pnlCaption.Size = New System.Drawing.Size(716, 59)
            '
            'gcNavigations
            '
            Me.gcNavigations.Controls.Add(Me.listBoxControl1)
            Me.gcNavigations.Location = New System.Drawing.Point(0, 22)
            Me.gcNavigations.Size = New System.Drawing.Size(204, 628)
            Me.gcNavigations.Controls.SetChildIndex(Me.listBoxControl1, 0)
            '
            'gcContainer
            '
            Me.gcContainer.Size = New System.Drawing.Size(700, 508)
            '
            'horzSplitter
            '
            Me.horzSplitter.Location = New System.Drawing.Point(8, 516)
            Me.horzSplitter.Size = New System.Drawing.Size(700, 8)
            '
            'gcDescription
            '
            Me.gcDescription.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.gcDescription.Appearance.Options.UseBackColor = True
            Me.gcDescription.Location = New System.Drawing.Point(8, 524)
            Me.gcDescription.Size = New System.Drawing.Size(700, 37)
            '
            'pcMain
            '
            Me.pcMain.Location = New System.Drawing.Point(204, 81)
            Me.pcMain.Size = New System.Drawing.Size(716, 569)
            '
            'listBoxControl1
            '
            Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl1.ItemHeight = 16
            Me.listBoxControl1.Location = New System.Drawing.Point(21, 2)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(181, 624)
            Me.listBoxControl1.TabIndex = 0
            '
            'frmMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(920, 650)
            Me.HintVisible = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmMain"
            Me.Text = "Tutorials (VB code)"
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.ImagePatternFill = CType(resources.GetObject("frmMain.TutorialInfo.ImagePatternFill"), System.Drawing.Image)
            Me.TutorialInfo.ImageWhatsThisButton = CType(resources.GetObject("frmMain.TutorialInfo.ImageWhatsThisButton"), System.Drawing.Image)
            Me.TutorialInfo.ImageWhatsThisButtonStop = CType(resources.GetObject("frmMain.TutorialInfo.ImageWhatsThisButtonStop"), System.Drawing.Image)
            Me.TutorialInfo.SourceFileComment = "'"
            Me.TutorialInfo.SourceFileType = DevExpress.Tutorials.SourceFileType.VB
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlCaption.ResumeLayout(False)
            CType(Me.gcNavigations, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcNavigations.ResumeLayout(False)
            CType(Me.gcContainer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.horzSplitter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcDescription, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcDescription.ResumeLayout(False)
            CType(Me.pcMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pcMain.ResumeLayout(False)
            CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private WithEvents listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
