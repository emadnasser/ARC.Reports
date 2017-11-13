Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpellChecker.Demos
	Partial Public Class CheckMemoEdit
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CheckMemoEdit))
			Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spellChecker1
			' 
			Me.spellChecker1.ParentContainer = Me
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red
			Me.checkEdit1.Properties.Appearance.Options.UseForeColor = True
			' 
			' memoEdit1
			' 
			Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue")
			Me.memoEdit1.Location = New System.Drawing.Point(0, 40)
			Me.memoEdit1.Name = "memoEdit1"
			Me.memoEdit1.Properties.HideSelection = False
			Me.spellChecker1.SetShowSpellCheckMenu(Me.memoEdit1, True)
			Me.memoEdit1.Size = New System.Drawing.Size(716, 356)
			Me.spellChecker1.SetSpellCheckerOptions(Me.memoEdit1, optionsSpelling1)
			Me.memoEdit1.TabIndex = 1
'			Me.memoEdit1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.OnEditControlKeyDown);
			' 
			' CheckMemoEdit
			' 
			Me.Appearance.Options.UseFont = True
			Me.Controls.Add(Me.memoEdit1)
			Me.Name = "CheckMemoEdit"
'			Me.Load += New System.EventHandler(Me.CheckMemoEdit_Load);
			Me.Controls.SetChildIndex(Me.panel1, 0)
			Me.Controls.SetChildIndex(Me.memoEdit1, 0)
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents memoEdit1 As DevExpress.XtraEditors.MemoEdit
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
