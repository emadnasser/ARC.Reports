Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpellChecker.Demos
	Partial Public Class DifferentSettings
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DifferentSettings))
			Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Dim optionsSpelling2 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Dim optionsSpelling3 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Dim optionsSpelling4 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.grpDescription = New DevExpress.XtraEditors.GroupControl()
			Me.mmDescription = New DevExpress.XtraEditors.MemoEdit()
			Me.grpInfo = New DevExpress.XtraEditors.GroupControl()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.mmAddress = New DevExpress.XtraEditors.MemoEdit()
			Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.txtUrl = New DevExpress.XtraEditors.TextEdit()
			Me.picPhoto = New DevExpress.XtraEditors.PictureEdit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.grpDescription, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grpDescription.SuspendLayout()
			CType(Me.mmDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.grpInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grpInfo.SuspendLayout()
			Me.tableLayoutPanel1.SuspendLayout()
			CType(Me.mmAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.picPhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spellChecker1
			' 
			Me.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = True
			Me.spellChecker1.ParentContainer = Me
			' 
			' panelControl2
			' 
			Me.panelControl2.Controls.Add(Me.grpDescription)
			Me.panelControl2.Controls.Add(Me.grpInfo)
			Me.panelControl2.Controls.Add(Me.picPhoto)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl2.Location = New System.Drawing.Point(0, 39)
			Me.panelControl2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(728, 416)
			Me.panelControl2.TabIndex = 8
			' 
			' grpDescription
			' 
			Me.grpDescription.Controls.Add(Me.mmDescription)
			Me.grpDescription.Dock = System.Windows.Forms.DockStyle.Fill
			Me.grpDescription.Location = New System.Drawing.Point(282, 188)
			Me.grpDescription.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.grpDescription.Name = "grpDescription"
			Me.grpDescription.Size = New System.Drawing.Size(444, 226)
			Me.grpDescription.TabIndex = 12
			Me.grpDescription.Text = "Description"
			' 
			' mmDescription
			' 
			Me.mmDescription.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mmDescription.EditValue = resources.GetString("mmDescription.EditValue")
			Me.mmDescription.Location = New System.Drawing.Point(2, 20)
			Me.mmDescription.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.mmDescription.Name = "mmDescription"
			Me.spellChecker1.SetShowSpellCheckMenu(Me.mmDescription, True)
			Me.mmDescription.Size = New System.Drawing.Size(440, 204)
			Me.spellChecker1.SetSpellCheckerOptions(Me.mmDescription, optionsSpelling1)
			Me.mmDescription.TabIndex = 1
			Me.mmDescription.ToolTip = "default settings"
			' 
			' grpInfo
			' 
			Me.grpInfo.Controls.Add(Me.tableLayoutPanel1)
			Me.grpInfo.Dock = System.Windows.Forms.DockStyle.Left
			Me.grpInfo.Location = New System.Drawing.Point(2, 188)
			Me.grpInfo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.grpInfo.Name = "grpInfo"
			Me.grpInfo.Size = New System.Drawing.Size(280, 226)
			Me.grpInfo.TabIndex = 11
			Me.grpInfo.Text = "Information"
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 2
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Controls.Add(Me.labelControl1, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.mmAddress, 1, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.txtEmail, 1, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.labelControl4, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.labelControl3, 0, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.txtUrl, 1, 0)
			Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(2, 20)
			Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 3
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(276, 204)
			Me.tableLayoutPanel1.TabIndex = 15
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(2, 2)
			Me.labelControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(37, 13)
			Me.labelControl1.TabIndex = 10
			Me.labelControl1.Text = "Source:"
			' 
			' mmAddress
			' 
			Me.mmAddress.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.mmAddress.EditValue = "3131 Las Vegas Blvd S - Las Vegas, NV, United States 89109 "
			Me.mmAddress.Location = New System.Drawing.Point(43, 50)
			Me.mmAddress.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.mmAddress.Name = "mmAddress"
			Me.spellChecker1.SetShowSpellCheckMenu(Me.mmAddress, True)
			Me.mmAddress.Size = New System.Drawing.Size(231, 152)
			optionsSpelling2.CheckSelectedTextFirst = DevExpress.Utils.DefaultBoolean.False
			optionsSpelling2.IgnoreWordsWithNumbers = DevExpress.Utils.DefaultBoolean.True
			Me.spellChecker1.SetSpellCheckerOptions(Me.mmAddress, optionsSpelling2)
			Me.mmAddress.TabIndex = 12
			Me.mmAddress.ToolTip = "words with digits are ignored"
			' 
			' txtEmail
			' 
			Me.txtEmail.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.txtEmail.EditValue = "dealer@ferrari.com"
			Me.txtEmail.Location = New System.Drawing.Point(43, 26)
			Me.txtEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.txtEmail.Name = "txtEmail"
			Me.spellChecker1.SetShowSpellCheckMenu(Me.txtEmail, True)
			Me.txtEmail.Size = New System.Drawing.Size(231, 20)
			optionsSpelling3.CheckSelectedTextFirst = DevExpress.Utils.DefaultBoolean.False
			optionsSpelling3.IgnoreEmails = DevExpress.Utils.DefaultBoolean.True
			Me.spellChecker1.SetSpellCheckerOptions(Me.txtEmail, optionsSpelling3)
			Me.txtEmail.TabIndex = 14
			Me.txtEmail.ToolTip = "emails are ignored"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(2, 26)
			Me.labelControl4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(32, 13)
			Me.labelControl4.TabIndex = 13
			Me.labelControl4.Text = "E-mail:"
			' 
			' labelControl3
			' 
			Me.labelControl3.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelControl3.Location = New System.Drawing.Point(2, 50)
			Me.labelControl3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(35, 13)
			Me.labelControl3.TabIndex = 11
			Me.labelControl3.Text = "Dealer:"
			' 
			' txtUrl
			' 
			Me.txtUrl.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.txtUrl.EditValue = "www.ferrari-cars.net"
			Me.txtUrl.Location = New System.Drawing.Point(43, 2)
			Me.txtUrl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.txtUrl.Name = "txtUrl"
			Me.spellChecker1.SetShowSpellCheckMenu(Me.txtUrl, True)
			Me.txtUrl.Size = New System.Drawing.Size(231, 20)
			optionsSpelling4.CheckSelectedTextFirst = DevExpress.Utils.DefaultBoolean.False
			optionsSpelling4.IgnoreUri = DevExpress.Utils.DefaultBoolean.True
			Me.spellChecker1.SetSpellCheckerOptions(Me.txtUrl, optionsSpelling4)
			Me.txtUrl.TabIndex = 9
			Me.txtUrl.ToolTip = "Urls are ignored"
			' 
			' picPhoto
			' 
			Me.picPhoto.Dock = System.Windows.Forms.DockStyle.Top
			Me.picPhoto.Location = New System.Drawing.Point(2, 2)
			Me.picPhoto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.picPhoto.Name = "picPhoto"
			Me.picPhoto.Properties.ZoomAccelerationFactor = 1R
			Me.picPhoto.Size = New System.Drawing.Size(724, 186)
			Me.picPhoto.TabIndex = 0
			' 
			' DifferentSettings
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
			Me.Controls.Add(Me.panelControl2)
			Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.Name = "DifferentSettings"
			Me.Size = New System.Drawing.Size(728, 455)
'			Me.Load += New System.EventHandler(Me.DifferentSettings_Load);
			Me.Controls.SetChildIndex(Me.panel1, 0)
			Me.Controls.SetChildIndex(Me.panelControl2, 0)
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			CType(Me.grpDescription, System.ComponentModel.ISupportInitialize).EndInit()
			Me.grpDescription.ResumeLayout(False)
			CType(Me.mmDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.grpInfo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.grpInfo.ResumeLayout(False)
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.tableLayoutPanel1.PerformLayout()
			CType(Me.mmAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.picPhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private components As System.ComponentModel.IContainer = Nothing
		Private picPhoto As DevExpress.XtraEditors.PictureEdit
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private grpDescription As XtraEditors.GroupControl
		Private mmDescription As XtraEditors.MemoEdit
		Private grpInfo As XtraEditors.GroupControl
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private labelControl1 As XtraEditors.LabelControl
		Private mmAddress As XtraEditors.MemoEdit
		Private txtEmail As XtraEditors.TextEdit
		Private labelControl4 As XtraEditors.LabelControl
		Private labelControl3 As XtraEditors.LabelControl
		Private txtUrl As XtraEditors.TextEdit
	End Class
End Namespace
