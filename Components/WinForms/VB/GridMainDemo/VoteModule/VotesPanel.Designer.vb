Namespace DevExpress.VoteApp
	Partial Public Class VotesPanel
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.lbVotesLeft = New DevExpress.XtraEditors.LabelControl()
			Me.lbVotesRight = New DevExpress.XtraEditors.LabelControl()
			Me.SuspendLayout()
			' 
			' lbVotesLeft
			' 
			Me.lbVotesLeft.AllowHtmlString = True
			Me.lbVotesLeft.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.lbVotesLeft.Appearance.ForeColor = System.Drawing.Color.White
			Me.lbVotesLeft.Appearance.Options.UseFont = True
			Me.lbVotesLeft.Appearance.Options.UseForeColor = True
			Me.lbVotesLeft.Appearance.Options.UseTextOptions = True
			Me.lbVotesLeft.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
			Me.lbVotesLeft.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
			Me.lbVotesLeft.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbVotesLeft.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lbVotesLeft.Location = New System.Drawing.Point(0, 0)
			Me.lbVotesLeft.Name = "lbVotesLeft"
			Me.lbVotesLeft.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
			Me.lbVotesLeft.Size = New System.Drawing.Size(212, 93)
			Me.lbVotesLeft.TabIndex = 1
			Me.lbVotesLeft.Text = "<b>100</b> <size=-5><i>Electoral Votes"
			' 
			' lbVotesRight
			' 
			Me.lbVotesRight.AllowHtmlString = True
			Me.lbVotesRight.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.lbVotesRight.Appearance.ForeColor = System.Drawing.Color.White
			Me.lbVotesRight.Appearance.Options.UseFont = True
			Me.lbVotesRight.Appearance.Options.UseForeColor = True
			Me.lbVotesRight.Appearance.Options.UseTextOptions = True
			Me.lbVotesRight.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.lbVotesRight.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
			Me.lbVotesRight.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
			Me.lbVotesRight.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbVotesRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.lbVotesRight.Location = New System.Drawing.Point(212, 0)
			Me.lbVotesRight.Name = "lbVotesRight"
			Me.lbVotesRight.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
			Me.lbVotesRight.Size = New System.Drawing.Size(152, 93)
			Me.lbVotesRight.TabIndex = 2
			Me.lbVotesRight.Text = "<size=-5>Electoral Votes</size> <b>100</b>"
			' 
			' VotesPanel
			' 
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
			Me.BackColor = System.Drawing.Color.Silver
			Me.Controls.Add(Me.lbVotesLeft)
			Me.Controls.Add(Me.lbVotesRight)
			Me.Name = "VotesPanel"
			Me.Size = New System.Drawing.Size(364, 93)
'			Me.Paint += New System.Windows.Forms.PaintEventHandler(Me.VotesPanel_Paint)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lbVotesLeft As DevExpress.XtraEditors.LabelControl
		Private lbVotesRight As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
