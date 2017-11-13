Imports DevExpress.Utils
Namespace DevExpress.XtraBars.Demos.Tutorials
    Partial Public Class frmMain
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
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
            ' btnWhatsThis
            ' 
            Me.btnWhatsThis.Location = New System.Drawing.Point(640, 9)
            Me.btnWhatsThis.Size = New System.Drawing.Size(96, 37)
            ' 
            ' btnAbout
            ' 
            Me.btnAbout.Location = New System.Drawing.Point(76, 9)
            ' 
            ' pnlHint
            ' 
            Me.pnlHint.BackColor = System.Drawing.Color.LightYellow
            Me.pnlHint.Size = New System.Drawing.Size(686, 40)
            ' 
            ' pnlCaption
            ' 
            Me.pnlCaption.Location = New System.Drawing.Point(204, 22)
            Me.pnlCaption.Size = New System.Drawing.Size(716, 59)
            ' 
            ' gcNavigations
            ' 
            Me.gcNavigations.Controls.Add(Me.listBoxControl1)
            Me.gcNavigations.Location = New System.Drawing.Point(0, 22)
            Me.gcNavigations.Size = New System.Drawing.Size(204, 628)
            ' 
            ' gcContainer
            ' 
            Me.gcContainer.Location = New System.Drawing.Point(13, 13)
            Me.gcContainer.Size = New System.Drawing.Size(690, 487)
            ' 
            ' horzSplitter
            ' 
            Me.horzSplitter.Location = New System.Drawing.Point(13, 500)
            Me.horzSplitter.Size = New System.Drawing.Size(690, 12)
            ' 
            ' gcDescription
            ' 
            Me.gcDescription.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.gcDescription.Appearance.Options.UseBackColor = True
            Me.gcDescription.Location = New System.Drawing.Point(13, 512)
            Me.gcDescription.Size = New System.Drawing.Size(690, 44)
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2013"
            ' 
            ' pcMain
            ' 
            Me.pcMain.Location = New System.Drawing.Point(204, 81)
            Me.pcMain.Padding = New System.Windows.Forms.Padding(13)
            Me.pcMain.Size = New System.Drawing.Size(716, 569)
            ' 
            ' listBoxControl1
            ' 
            Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl1.ItemHeight = 16
            Me.listBoxControl1.Location = New System.Drawing.Point(22, 2)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(180, 624)
            Me.listBoxControl1.TabIndex = 0
            ' 
            ' frmMain
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(920, 650)
            Me.HintVisible = False
            Me.LookAndFeel.SkinName = "Office 2013"
            Me.Name = "frmMain"
            Me.Text = "Tutorials (C# code)"
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.ImagePatternFill = (CType(resources.GetObject("frmMain.TutorialInfo.ImagePatternFill"), System.Drawing.Image))
            Me.TutorialInfo.ImageWhatsThisButton = (CType(resources.GetObject("frmMain.TutorialInfo.ImageWhatsThisButton"), System.Drawing.Image))
            Me.TutorialInfo.ImageWhatsThisButtonStop = (CType(resources.GetObject("frmMain.TutorialInfo.ImageWhatsThisButtonStop"), System.Drawing.Image))
            Me.TutorialInfo.SourceFileComment = "//"
            Me.TutorialInfo.SourceFileType = DevExpress.Tutorials.SourceFileType.CS
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
