Imports Microsoft.VisualBasic
Imports System
Namespace PivotGridOlapBrowser.Dialogs
	Partial Public Class ConnectionDesigner
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.buttonOK = New DevExpress.XtraEditors.SimpleButton()
			Me.buttonCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			Me.buttonSample = New DevExpress.XtraEditors.SimpleButton()
			Me.chkExisting = New DevExpress.XtraEditors.CheckEdit()
			Me.chkNew = New DevExpress.XtraEditors.CheckEdit()
			Me.existingList = New DevExpress.XtraEditors.ListBoxControl()
			Me.listCube = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelCube = New DevExpress.XtraEditors.LabelControl()
			Me.listCatalog = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelCatalog = New DevExpress.XtraEditors.LabelControl()
			Me.editServer = New DevExpress.XtraEditors.ButtonEdit()
			Me.labelServer = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.radioFile = New DevExpress.XtraEditors.CheckEdit()
			Me.radioServer = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.chkExisting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkNew.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.existingList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listCube.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listCatalog.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.editServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' buttonOK
			' 
			Me.buttonOK.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonOK.Location = New System.Drawing.Point(192, 278)
			Me.buttonOK.Name = "buttonOK"
			Me.buttonOK.Size = New System.Drawing.Size(75, 21)
			Me.buttonOK.TabIndex = 14
			Me.buttonOK.Text = "OK"
'			Me.buttonOK.Click += New System.EventHandler(Me.buttonOK_Click);
			' 
			' buttonCancel
			' 
			Me.buttonCancel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.buttonCancel.Location = New System.Drawing.Point(273, 278)
			Me.buttonCancel.Name = "buttonCancel"
			Me.buttonCancel.Size = New System.Drawing.Size(75, 21)
			Me.buttonCancel.TabIndex = 15
			Me.buttonCancel.Text = "Cancel"
			' 
			' toolTipController1
			' 
			Me.toolTipController1.Rounded = True
			Me.toolTipController1.ToolTipLocation = DevExpress.Utils.ToolTipLocation.RightCenter
			' 
			' buttonSample
			' 
			Me.buttonSample.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonSample.Location = New System.Drawing.Point(12, 278)
			Me.buttonSample.Name = "buttonSample"
			Me.buttonSample.Size = New System.Drawing.Size(75, 21)
			Me.buttonSample.TabIndex = 13
			Me.buttonSample.Text = "Open Sample"
'			Me.buttonSample.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' chkExisting
			' 
			Me.chkExisting.EditValue = True
			Me.chkExisting.Location = New System.Drawing.Point(10, 12)
			Me.chkExisting.Name = "chkExisting"
			Me.chkExisting.Properties.Caption = "Existing connections"
			Me.chkExisting.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.chkExisting.Properties.RadioGroupIndex = 1
			Me.chkExisting.Size = New System.Drawing.Size(183, 19)
			Me.chkExisting.TabIndex = 0
			' 
			' chkNew
			' 
			Me.chkNew.Location = New System.Drawing.Point(10, 126)
			Me.chkNew.Name = "chkNew"
			Me.chkNew.Properties.Caption = "New connection"
			Me.chkNew.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.chkNew.Properties.RadioGroupIndex = 1
			Me.chkNew.Size = New System.Drawing.Size(183, 19)
			Me.chkNew.TabIndex = 2
			Me.chkNew.TabStop = False
			' 
			' existingList
			' 
			Me.existingList.HorizontalScrollbar = True
			Me.existingList.Location = New System.Drawing.Point(26, 37)
			Me.existingList.Name = "existingList"
			Me.existingList.Size = New System.Drawing.Size(322, 68)
			Me.existingList.TabIndex = 1
			' 
			' listCube
			' 
			Me.listCube.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.listCube.Location = New System.Drawing.Point(115, 234)
			Me.listCube.Margin = New System.Windows.Forms.Padding(4)
			Me.listCube.Name = "listCube"
			Me.listCube.Properties.AutoComplete = False
			Me.listCube.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.listCube.Properties.Sorted = True
			Me.listCube.Size = New System.Drawing.Size(233, 20)
			Me.listCube.TabIndex = 24
'			Me.listCube.EditValueChanged += New System.EventHandler(Me.listCube_EditValueChanged);
'			Me.listCube.QueryPopUp += New System.ComponentModel.CancelEventHandler(Me.listCube_QueryPopUp);
			' 
			' labelCube
			' 
			Me.labelCube.Location = New System.Drawing.Point(26, 237)
			Me.labelCube.Margin = New System.Windows.Forms.Padding(4)
			Me.labelCube.Name = "labelCube"
			Me.labelCube.Size = New System.Drawing.Size(25, 13)
			Me.labelCube.TabIndex = 23
			Me.labelCube.Text = "Cube"
			' 
			' listCatalog
			' 
			Me.listCatalog.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.listCatalog.Location = New System.Drawing.Point(115, 206)
			Me.listCatalog.Margin = New System.Windows.Forms.Padding(4)
			Me.listCatalog.Name = "listCatalog"
			Me.listCatalog.Properties.AutoComplete = False
			Me.listCatalog.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.listCatalog.Properties.Sorted = True
			Me.listCatalog.Size = New System.Drawing.Size(233, 20)
			Me.listCatalog.TabIndex = 22
'			Me.listCatalog.EditValueChanged += New System.EventHandler(Me.listCatalog_EditValueChanged);
'			Me.listCatalog.QueryPopUp += New System.ComponentModel.CancelEventHandler(Me.listCatalog_QueryPopUp);
			' 
			' labelCatalog
			' 
			Me.labelCatalog.Location = New System.Drawing.Point(26, 209)
			Me.labelCatalog.Margin = New System.Windows.Forms.Padding(4)
			Me.labelCatalog.Name = "labelCatalog"
			Me.labelCatalog.Size = New System.Drawing.Size(46, 13)
			Me.labelCatalog.TabIndex = 21
			Me.labelCatalog.Text = "Database"
			' 
			' editServer
			' 
			Me.editServer.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.editServer.Location = New System.Drawing.Point(115, 178)
			Me.editServer.Margin = New System.Windows.Forms.Padding(4)
			Me.editServer.Name = "editServer"
			Me.editServer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.editServer.Size = New System.Drawing.Size(233, 20)
			Me.editServer.TabIndex = 20
'			Me.editServer.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.editServer_ButtonClick);
'			Me.editServer.EditValueChanged += New System.EventHandler(Me.editServer_EditValueChanged);
			' 
			' labelServer
			' 
			Me.labelServer.Location = New System.Drawing.Point(26, 181)
			Me.labelServer.Margin = New System.Windows.Forms.Padding(4)
			Me.labelServer.Name = "labelServer"
			Me.labelServer.Size = New System.Drawing.Size(32, 13)
			Me.labelServer.TabIndex = 19
			Me.labelServer.Text = "Server"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(26, 154)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(68, 13)
			Me.labelControl1.TabIndex = 16
			Me.labelControl1.Text = "Connect using"
			' 
			' radioFile
			' 
			Me.radioFile.Location = New System.Drawing.Point(230, 152)
			Me.radioFile.Name = "radioFile"
			Me.radioFile.Properties.Caption = "Cube file"
			Me.radioFile.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioFile.Properties.RadioGroupIndex = 0
			Me.radioFile.Size = New System.Drawing.Size(69, 19)
			Me.radioFile.TabIndex = 18
			Me.radioFile.TabStop = False
'			Me.radioFile.CheckedChanged += New System.EventHandler(Me.radioButton_CheckedChanged);
			' 
			' radioServer
			' 
			Me.radioServer.EditValue = True
			Me.radioServer.Location = New System.Drawing.Point(113, 151)
			Me.radioServer.Name = "radioServer"
			Me.radioServer.Properties.Caption = "Analysis server"
			Me.radioServer.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioServer.Properties.RadioGroupIndex = 0
			Me.radioServer.Size = New System.Drawing.Size(95, 19)
			Me.radioServer.TabIndex = 17
'			Me.radioServer.EditValueChanged += New System.EventHandler(Me.radioServer_EditValueChanged);
'			Me.radioServer.CheckedChanged += New System.EventHandler(Me.radioButton_CheckedChanged);
			' 
			' ConnectionDesigner
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(360, 309)
			Me.Controls.Add(Me.listCube)
			Me.Controls.Add(Me.labelCube)
			Me.Controls.Add(Me.listCatalog)
			Me.Controls.Add(Me.labelCatalog)
			Me.Controls.Add(Me.editServer)
			Me.Controls.Add(Me.labelServer)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.radioFile)
			Me.Controls.Add(Me.radioServer)
			Me.Controls.Add(Me.existingList)
			Me.Controls.Add(Me.chkNew)
			Me.Controls.Add(Me.chkExisting)
			Me.Controls.Add(Me.buttonSample)
			Me.Controls.Add(Me.buttonCancel)
			Me.Controls.Add(Me.buttonOK)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "ConnectionDesigner"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Connection Designer"
			CType(Me.chkExisting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkNew.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.existingList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listCube.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listCatalog.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.editServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents buttonOK As DevExpress.XtraEditors.SimpleButton
		Private buttonCancel As DevExpress.XtraEditors.SimpleButton
		Private toolTipController1 As DevExpress.Utils.ToolTipController
		Private WithEvents buttonSample As DevExpress.XtraEditors.SimpleButton
		Private chkExisting As DevExpress.XtraEditors.CheckEdit
		Private chkNew As DevExpress.XtraEditors.CheckEdit
		Private existingList As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents listCube As DevExpress.XtraEditors.ComboBoxEdit
		Private labelCube As DevExpress.XtraEditors.LabelControl
		Private WithEvents listCatalog As DevExpress.XtraEditors.ComboBoxEdit
		Private labelCatalog As DevExpress.XtraEditors.LabelControl
		Private WithEvents editServer As DevExpress.XtraEditors.ButtonEdit
		Private labelServer As DevExpress.XtraEditors.LabelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents radioFile As DevExpress.XtraEditors.CheckEdit
		Private WithEvents radioServer As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace
