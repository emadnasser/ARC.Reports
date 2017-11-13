Namespace DevExpress.XtraGrid.Demos
	Partial Public Class frmSQLConnector
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmSQLConnector))
			Me.npMain = New DevExpress.Utils.Frames.NotePanel()
			Me.pnlButtons = New DevExpress.XtraEditors.PanelControl()
			Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
			Me.sbGenerateDB = New DevExpress.XtraEditors.SimpleButton()
			Me.pnlMain = New DevExpress.XtraEditors.PanelControl()
			Me.lbRecords = New DevExpress.XtraEditors.LabelControl()
			Me.sbAddRecords = New DevExpress.XtraEditors.SimpleButton()
			Me.sbExit = New DevExpress.XtraEditors.SimpleButton()
			Me.seRecordCount = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
			Me.tePassword = New DevExpress.XtraEditors.TextEdit()
			Me.teLogin = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.teServer = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.cbDatabase = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.pnlButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlButtons.SuspendLayout()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlMain.SuspendLayout()
			CType(Me.seRecordCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbDatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' npMain
			' 
			Me.npMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
			resources.ApplyResources(Me.npMain, "npMain")
			Me.npMain.ForeColor = System.Drawing.Color.Black
			Me.npMain.MaxRows = 20
			Me.npMain.Name = "npMain"
			Me.npMain.TabStop = False
			' 
			' pnlButtons
			' 
			Me.pnlButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlButtons.Controls.Add(Me.progressBarControl1)
			resources.ApplyResources(Me.pnlButtons, "pnlButtons")
			Me.pnlButtons.Name = "pnlButtons"
			' 
			' progressBarControl1
			' 
			resources.ApplyResources(Me.progressBarControl1, "progressBarControl1")
			Me.progressBarControl1.Name = "progressBarControl1"
			Me.progressBarControl1.Properties.Maximum = 99
			' 
			' sbGenerateDB
			' 
			resources.ApplyResources(Me.sbGenerateDB, "sbGenerateDB")
			Me.sbGenerateDB.Name = "sbGenerateDB"
'			Me.sbGenerateDB.Click += New System.EventHandler(Me.sbGenerateDB_Click)
			' 
			' pnlMain
			' 
			Me.pnlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlMain.Controls.Add(Me.lbRecords)
			Me.pnlMain.Controls.Add(Me.sbAddRecords)
			Me.pnlMain.Controls.Add(Me.sbExit)
			Me.pnlMain.Controls.Add(Me.seRecordCount)
			Me.pnlMain.Controls.Add(Me.labelControl6)
			Me.pnlMain.Controls.Add(Me.sbGenerateDB)
			Me.pnlMain.Controls.Add(Me.tePassword)
			Me.pnlMain.Controls.Add(Me.teLogin)
			Me.pnlMain.Controls.Add(Me.labelControl5)
			Me.pnlMain.Controls.Add(Me.labelControl4)
			Me.pnlMain.Controls.Add(Me.radioGroup1)
			Me.pnlMain.Controls.Add(Me.labelControl3)
			Me.pnlMain.Controls.Add(Me.teServer)
			Me.pnlMain.Controls.Add(Me.labelControl2)
			Me.pnlMain.Controls.Add(Me.cbDatabase)
			Me.pnlMain.Controls.Add(Me.labelControl1)
			resources.ApplyResources(Me.pnlMain, "pnlMain")
			Me.pnlMain.Name = "pnlMain"
			' 
			' lbRecords
			' 
			Me.lbRecords.Appearance.Font = (CType(resources.GetObject("lbRecords.Appearance.Font"), System.Drawing.Font))
			Me.lbRecords.Appearance.ForeColor = (CType(resources.GetObject("lbRecords.Appearance.ForeColor"), System.Drawing.Color))
			resources.ApplyResources(Me.lbRecords, "lbRecords")
			Me.lbRecords.Name = "lbRecords"
			' 
			' sbAddRecords
			' 
			resources.ApplyResources(Me.sbAddRecords, "sbAddRecords")
			Me.sbAddRecords.Name = "sbAddRecords"
'			Me.sbAddRecords.Click += New System.EventHandler(Me.sbAddRecords_Click)
			' 
			' sbExit
			' 
			resources.ApplyResources(Me.sbExit, "sbExit")
			Me.sbExit.Name = "sbExit"
'			Me.sbExit.Click += New System.EventHandler(Me.sbExit_Click)
			' 
			' seRecordCount
			' 
			resources.ApplyResources(Me.seRecordCount, "seRecordCount")
			Me.seRecordCount.Name = "seRecordCount"
			Me.seRecordCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seRecordCount.Properties.Increment = New Decimal(New Integer() { 1000, 0, 0, 0})
			Me.seRecordCount.Properties.IsFloatValue = False
			Me.seRecordCount.Properties.Mask.EditMask = resources.GetString("seRecordCount.Properties.Mask.EditMask")
			Me.seRecordCount.Properties.Mask.UseMaskAsDisplayFormat = (CBool(resources.GetObject("seRecordCount.Properties.Mask.UseMaskAsDisplayFormat")))
			Me.seRecordCount.Properties.MaxValue = New Decimal(New Integer() { 999999, 0, 0, 0})
			Me.seRecordCount.Properties.MinValue = New Decimal(New Integer() { 1000, 0, 0, 0})
			' 
			' labelControl6
			' 
			resources.ApplyResources(Me.labelControl6, "labelControl6")
			Me.labelControl6.Name = "labelControl6"
			' 
			' tePassword
			' 
			resources.ApplyResources(Me.tePassword, "tePassword")
			Me.tePassword.Name = "tePassword"
			Me.tePassword.Properties.PasswordChar = "*"c
			' 
			' teLogin
			' 
			resources.ApplyResources(Me.teLogin, "teLogin")
			Me.teLogin.Name = "teLogin"
			' 
			' labelControl5
			' 
			resources.ApplyResources(Me.labelControl5, "labelControl5")
			Me.labelControl5.Name = "labelControl5"
			' 
			' labelControl4
			' 
			resources.ApplyResources(Me.labelControl4, "labelControl4")
			Me.labelControl4.Name = "labelControl4"
			' 
			' radioGroup1
			' 
			resources.ApplyResources(Me.radioGroup1, "radioGroup1")
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Properties.Columns = 1
			Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem((CObj(resources.GetObject("radioGroup1.Properties.Items"))), resources.GetString("radioGroup1.Properties.Items1")), New DevExpress.XtraEditors.Controls.RadioGroupItem((CObj(resources.GetObject("radioGroup1.Properties.Items2"))), resources.GetString("radioGroup1.Properties.Items3"))})
'			Me.radioGroup1.SelectedIndexChanged += New System.EventHandler(Me.radioGroup1_SelectedIndexChanged)
			' 
			' labelControl3
			' 
			resources.ApplyResources(Me.labelControl3, "labelControl3")
			Me.labelControl3.Name = "labelControl3"
			' 
			' teServer
			' 
			resources.ApplyResources(Me.teServer, "teServer")
			Me.teServer.Name = "teServer"
'			Me.teServer.EditValueChanged += New System.EventHandler(Me.teServer_EditValueChanged)
			' 
			' labelControl2
			' 
			resources.ApplyResources(Me.labelControl2, "labelControl2")
			Me.labelControl2.Name = "labelControl2"
			' 
			' cbDatabase
			' 
			resources.ApplyResources(Me.cbDatabase, "cbDatabase")
			Me.cbDatabase.Name = "cbDatabase"
			Me.cbDatabase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("cbDatabase.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.cbDatabase.Properties.ReadOnly = True
'			Me.cbDatabase.EditValueChanged += New System.EventHandler(Me.cbDatabase_EditValueChanged)
'			Me.cbDatabase.QueryPopUp += New System.ComponentModel.CancelEventHandler(Me.cbDatabase_QueryPopUp)
			' 
			' labelControl1
			' 
			resources.ApplyResources(Me.labelControl1, "labelControl1")
			Me.labelControl1.Name = "labelControl1"
			' 
			' frmSQLConnector
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pnlMain)
			Me.Controls.Add(Me.pnlButtons)
			Me.Controls.Add(Me.npMain)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Name = "frmSQLConnector"
			Me.ShowInTaskbar = False
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.frmSQLConnector_FormClosing)
			CType(Me.pnlButtons, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlButtons.ResumeLayout(False)
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlMain.ResumeLayout(False)
			Me.pnlMain.PerformLayout()
			CType(Me.seRecordCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbDatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private npMain As DevExpress.Utils.Frames.NotePanel
		Private pnlButtons As DevExpress.XtraEditors.PanelControl
		Private pnlMain As DevExpress.XtraEditors.PanelControl
		Private WithEvents sbGenerateDB As DevExpress.XtraEditors.SimpleButton
		Private tePassword As DevExpress.XtraEditors.TextEdit
		Private teLogin As DevExpress.XtraEditors.TextEdit
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents teServer As DevExpress.XtraEditors.TextEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbDatabase As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private seRecordCount As DevExpress.XtraEditors.SpinEdit
		Private labelControl6 As DevExpress.XtraEditors.LabelControl
		Private WithEvents sbExit As DevExpress.XtraEditors.SimpleButton
		Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
		Private WithEvents sbAddRecords As DevExpress.XtraEditors.SimpleButton
		Private lbRecords As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
