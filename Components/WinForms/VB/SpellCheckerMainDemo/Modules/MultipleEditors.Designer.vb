Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpellChecker.Demos
	Partial Public Class MultipleEditors
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
			Dim optionsSpelling3 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Dim optionsSpelling2 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Dim optionsSpelling4 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Me.memoAbout = New DevExpress.XtraEditors.MemoEdit()
			Me.picPhoto = New DevExpress.XtraEditors.PictureEdit()
			Me.lblName = New DevExpress.XtraEditors.LabelControl()
			Me.lblPosition = New DevExpress.XtraEditors.LabelControl()
			Me.lblBirthDate = New DevExpress.XtraEditors.LabelControl()
			Me.lblAddress = New DevExpress.XtraEditors.LabelControl()
			Me.lblAbout = New DevExpress.XtraEditors.LabelControl()
			Me.memoAddress = New DevExpress.XtraEditors.MemoEdit()
			Me.txtName = New DevExpress.XtraEditors.TextEdit()
			Me.txtPosition = New DevExpress.XtraEditors.TextEdit()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.panel1.SuspendLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.memoAbout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.picPhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.memoAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' spellChecker1
			' 
			Me.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = True
			Me.spellChecker1.ParentContainer = Me
			' 
			' memoAbout
			' 
			Me.memoAbout.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.memoAbout.EditValue = "Education includes a BA in psyhology from Colorado State Univercity in 1970.  She" & " also completed ""The Art of the Cold Call.""  Nancy is a member of Toastmasters I" & "nternationa."
			Me.memoAbout.Location = New System.Drawing.Point(64, 119)
			Me.memoAbout.Margin = New System.Windows.Forms.Padding(2)
			Me.memoAbout.Name = "memoAbout"
			Me.spellChecker1.SetShowSpellCheckMenu(Me.memoAbout, True)
			Me.memoAbout.Size = New System.Drawing.Size(530, 297)
			Me.spellChecker1.SetSpellCheckerOptions(Me.memoAbout, optionsSpelling3)
			Me.memoAbout.TabIndex = 5
			' 
			' picPhoto
			' 
			Me.picPhoto.Location = New System.Drawing.Point(8, 51)
			Me.picPhoto.Margin = New System.Windows.Forms.Padding(2)
			Me.picPhoto.Name = "picPhoto"
			Me.picPhoto.Properties.AllowFocused = False
			Me.picPhoto.Properties.ReadOnly = True
			Me.picPhoto.Properties.ShowMenu = False
			Me.picPhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
			Me.picPhoto.Properties.ZoomAccelerationFactor = 1R
			Me.picPhoto.Size = New System.Drawing.Size(128, 128)
			Me.picPhoto.TabIndex = 2
			' 
			' lblName
			' 
			Me.lblName.Location = New System.Drawing.Point(0, 0)
			Me.lblName.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.lblName.Name = "lblName"
			Me.lblName.Size = New System.Drawing.Size(31, 13)
			Me.lblName.TabIndex = 3
			Me.lblName.Text = "Name:"
			' 
			' lblPosition
			' 
			Me.lblPosition.Location = New System.Drawing.Point(0, 25)
			Me.lblPosition.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.lblPosition.Name = "lblPosition"
			Me.lblPosition.Size = New System.Drawing.Size(41, 13)
			Me.lblPosition.TabIndex = 3
			Me.lblPosition.Text = "Position:"
			' 
			' lblBirthDate
			' 
			Me.lblBirthDate.Location = New System.Drawing.Point(0, 50)
			Me.lblBirthDate.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.lblBirthDate.Name = "lblBirthDate"
			Me.lblBirthDate.Size = New System.Drawing.Size(52, 13)
			Me.lblBirthDate.TabIndex = 3
			Me.lblBirthDate.Text = "Birth Date:"
			' 
			' lblAddress
			' 
			Me.lblAddress.Location = New System.Drawing.Point(0, 75)
			Me.lblAddress.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.lblAddress.Name = "lblAddress"
			Me.lblAddress.Size = New System.Drawing.Size(43, 13)
			Me.lblAddress.TabIndex = 3
			Me.lblAddress.Text = "Address:"
			' 
			' lblAbout
			' 
			Me.lblAbout.Location = New System.Drawing.Point(0, 117)
			Me.lblAbout.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.lblAbout.Name = "lblAbout"
			Me.lblAbout.Size = New System.Drawing.Size(33, 13)
			Me.lblAbout.TabIndex = 3
			Me.lblAbout.Text = "About:"
			' 
			' memoAddress
			' 
			Me.memoAddress.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.memoAddress.EditValue = "USA, Seattle, 507-20th Ave. E. Apt. 2A"
			Me.memoAddress.Location = New System.Drawing.Point(62, 75)
			Me.memoAddress.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
			Me.memoAddress.Name = "memoAddress"
			Me.spellChecker1.SetShowSpellCheckMenu(Me.memoAddress, True)
			Me.memoAddress.Size = New System.Drawing.Size(534, 37)
			Me.spellChecker1.SetSpellCheckerOptions(Me.memoAddress, optionsSpelling2)
			Me.memoAddress.TabIndex = 4
			' 
			' txtName
			' 
			Me.txtName.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.txtName.EditValue = "Nancy Davolio"
			Me.txtName.Location = New System.Drawing.Point(62, 0)
			Me.txtName.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
			Me.txtName.Name = "txtName"
			Me.spellChecker1.SetShowSpellCheckMenu(Me.txtName, True)
			Me.txtName.Size = New System.Drawing.Size(534, 20)
			Me.spellChecker1.SetSpellCheckerOptions(Me.txtName, optionsSpelling1)
			Me.txtName.TabIndex = 1
			' 
			' txtPosition
			' 
			Me.txtPosition.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.txtPosition.EditValue = "Sales Reprseentative"
			Me.txtPosition.Location = New System.Drawing.Point(62, 25)
			Me.txtPosition.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
			Me.txtPosition.Name = "txtPosition"
			Me.spellChecker1.SetShowSpellCheckMenu(Me.txtPosition, True)
			Me.txtPosition.Size = New System.Drawing.Size(534, 20)
			Me.spellChecker1.SetSpellCheckerOptions(Me.txtPosition, optionsSpelling4)
			Me.txtPosition.TabIndex = 2
			' 
			' dateEdit1
			' 
			Me.dateEdit1.EditValue = New System.DateTime(1948, 12, 8, 0, 0, 0, 0)
			Me.dateEdit1.Location = New System.Drawing.Point(62, 50)
			Me.dateEdit1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit1.Size = New System.Drawing.Size(101, 20)
			Me.dateEdit1.TabIndex = 3
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.tableLayoutPanel1.ColumnCount = 2
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Controls.Add(Me.txtName, 1, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.dateEdit1, 1, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.lblName, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.memoAddress, 1, 3)
			Me.tableLayoutPanel1.Controls.Add(Me.memoAbout, 1, 4)
			Me.tableLayoutPanel1.Controls.Add(Me.lblPosition, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.lblBirthDate, 0, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.lblAddress, 0, 3)
			Me.tableLayoutPanel1.Controls.Add(Me.lblAbout, 0, 4)
			Me.tableLayoutPanel1.Controls.Add(Me.txtPosition, 1, 1)
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(150, 51)
			Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(8)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 5
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(596, 418)
			Me.tableLayoutPanel1.TabIndex = 6
			' 
			' MultipleEditors
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Controls.Add(Me.picPhoto)
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "MultipleEditors"
			Me.Size = New System.Drawing.Size(746, 469)
'			Me.Load += New System.EventHandler(Me.MultipleEditors_Load);
			Me.Controls.SetChildIndex(Me.picPhoto, 0)
			Me.Controls.SetChildIndex(Me.tableLayoutPanel1, 0)
			Me.Controls.SetChildIndex(Me.panel1, 0)
			Me.panel1.ResumeLayout(False)
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.memoAbout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.picPhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.memoAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.tableLayoutPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private memoAbout As DevExpress.XtraEditors.MemoEdit
		Private lblName As DevExpress.XtraEditors.LabelControl
		Private lblPosition As DevExpress.XtraEditors.LabelControl
		Private lblBirthDate As DevExpress.XtraEditors.LabelControl
		Private lblAddress As DevExpress.XtraEditors.LabelControl
		Private lblAbout As DevExpress.XtraEditors.LabelControl
		Private memoAddress As DevExpress.XtraEditors.MemoEdit
		Private txtName As DevExpress.XtraEditors.TextEdit
		Private txtPosition As DevExpress.XtraEditors.TextEdit
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private picPhoto As DevExpress.XtraEditors.PictureEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	End Class
End Namespace
