Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpellChecker.Demos
	Partial Public Class CustomDictionary
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
        Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomDictionary))
        Dim OptionsSpelling2 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.mmDictionary = New DevExpress.XtraEditors.MemoEdit()
        Me.memText = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.checkEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.panel1.SuspendLayout
        CType(Me.splitContainerControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainerControl1.SuspendLayout
        CType(Me.mmDictionary.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.memText.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'spellChecker1
        '
        Me.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = true
        Me.spellChecker1.ParentContainer = Me
        '
        'checkEdit1
        '
        Me.checkEdit1.Location = New System.Drawing.Point(590, 9)
        Me.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.checkEdit1.Properties.Appearance.Options.UseForeColor = true
        Me.checkEdit1.Visible = false
        '
        'panel1
        '
        Me.panel1.Size = New System.Drawing.Size(724, 39)
        '
        'splitContainerControl1
        '
        Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainerControl1.Location = New System.Drawing.Point(0, 39)
        Me.splitContainerControl1.Name = "splitContainerControl1"
        Me.splitContainerControl1.Panel1.Controls.Add(Me.mmDictionary)
        Me.splitContainerControl1.Panel1.ShowCaption = true
        Me.splitContainerControl1.Panel1.Text = "Dictionary"
        Me.splitContainerControl1.Panel2.Controls.Add(Me.memText)
        Me.splitContainerControl1.Panel2.ShowCaption = true
        Me.splitContainerControl1.Panel2.Text = "Type text and press the F7 key to check it ..."
        Me.splitContainerControl1.Size = New System.Drawing.Size(724, 473)
        Me.splitContainerControl1.SplitterPosition = 288
        Me.splitContainerControl1.TabIndex = 3
        Me.splitContainerControl1.Text = "splitContainerControl1"
        '
        'mmDictionary
        '
        Me.spellChecker1.SetCanCheckText(Me.mmDictionary, false)
        Me.mmDictionary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mmDictionary.EditValue = "mesto"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"droogs"
        Me.mmDictionary.Location = New System.Drawing.Point(0, 0)
        Me.mmDictionary.Name = "mmDictionary"
        Me.spellChecker1.SetShowSpellCheckMenu(Me.mmDictionary, true)
        Me.mmDictionary.Size = New System.Drawing.Size(288, 473)
        Me.spellChecker1.SetSpellCheckerOptions(Me.mmDictionary, OptionsSpelling1)
        Me.mmDictionary.TabIndex = 0
        '
        'memText
        '
        Me.memText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.memText.EditValue = resources.GetString("memText.EditValue")
        Me.memText.Location = New System.Drawing.Point(0, 0)
        Me.memText.Name = "memText"
        Me.spellChecker1.SetShowSpellCheckMenu(Me.memText, true)
        Me.memText.Size = New System.Drawing.Size(431, 473)
        Me.spellChecker1.SetSpellCheckerOptions(Me.memText, OptionsSpelling2)
        Me.memText.TabIndex = 1
        '
        'CustomDictionary
        '
        Me.Appearance.Options.UseFont = true
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.Controls.Add(Me.splitContainerControl1)
        Me.Name = "CustomDictionary"
        Me.Size = New System.Drawing.Size(724, 512)
        Me.Controls.SetChildIndex(Me.panel1, 0)
        Me.Controls.SetChildIndex(Me.splitContainerControl1, 0)
        CType(Me.checkEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.panel1.ResumeLayout(false)
        Me.panel1.PerformLayout
        CType(Me.splitContainerControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainerControl1.ResumeLayout(false)
        CType(Me.mmDictionary.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.memText.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

		#End Region

		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents mmDictionary As DevExpress.XtraEditors.MemoEdit
		Private WithEvents memText As DevExpress.XtraEditors.MemoEdit
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
