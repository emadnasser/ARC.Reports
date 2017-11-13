Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpellChecker.Demos
	Partial Public Class BaseTutorialControl
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
			Me.components = New System.ComponentModel.Container()
			Me.sharedDictionaryStorage1 = New DevExpress.XtraSpellChecker.SharedDictionaryStorage(Me.components)
			Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.btnCheckSpelling = New DevExpress.XtraEditors.SimpleButton()
			Me.panel1.SuspendLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spellChecker1
			' 
			Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en")
			Me.spellChecker1.ParentContainer = Nothing
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.checkEdit1)
			Me.panel1.Controls.Add(Me.btnCheckSpelling)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(716, 39)
			Me.panel1.TabIndex = 1
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEdit1.Location = New System.Drawing.Point(582, 9)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red
			Me.checkEdit1.Properties.Appearance.Options.UseForeColor = True
			Me.checkEdit1.Properties.AutoWidth = True
			Me.checkEdit1.Properties.Caption = "CheckAsYouType Mode"
			Me.checkEdit1.Size = New System.Drawing.Size(134, 19)
			Me.checkEdit1.TabIndex = 7
'			Me.checkEdit1.CheckedChanged += New System.EventHandler(Me.OnCheckedChanged);
			' 
			' btnCheckSpelling
			' 
			Me.btnCheckSpelling.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.btnCheckSpelling.AutoSize = True
			Me.btnCheckSpelling.Location = New System.Drawing.Point(0, 8)
			Me.btnCheckSpelling.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
			Me.btnCheckSpelling.Name = "btnCheckSpelling"
			Me.btnCheckSpelling.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
			Me.btnCheckSpelling.Size = New System.Drawing.Size(149, 22)
			Me.btnCheckSpelling.TabIndex = 6
			Me.btnCheckSpelling.Text = "Check Spelling..."
'			Me.btnCheckSpelling.Click += New System.EventHandler(Me.btnCheckSpelling_Click);
			' 
			' BaseTutorialControl
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
			Me.Controls.Add(Me.panel1)
			Me.Name = "BaseTutorialControl"
			Me.Size = New System.Drawing.Size(716, 396)
'			Me.Load += New System.EventHandler(Me.OnTutorialControlLoaded);
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Protected sharedDictionaryStorage1 As DevExpress.XtraSpellChecker.SharedDictionaryStorage
		Protected WithEvents spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
		Private components As System.ComponentModel.IContainer = Nothing
		Protected WithEvents btnCheckSpelling As XtraEditors.SimpleButton
		Protected WithEvents checkEdit1 As XtraEditors.CheckEdit
		Protected panel1 As System.Windows.Forms.Panel
	End Class
End Namespace
