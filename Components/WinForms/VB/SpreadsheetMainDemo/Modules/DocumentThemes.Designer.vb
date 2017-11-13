Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class DocumentThemesModule
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DocumentThemesModule))
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.fromCompanyLabel = New DevExpress.XtraEditors.LabelControl()
			Me.panel = New DevExpress.XtraEditors.PanelControl()
			Me.spreadsheetBarController1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController()
			Me.spreadsheetCommandBarButtonItem65 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem66 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem67 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem68 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			Me.spreadsheetCommandBarButtonItem69 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.AllowDrop = True
			resources.ApplyResources(Me.spreadsheetControl1, "spreadsheetControl1")
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
			' 
			' comboBoxEdit1
			' 
			resources.ApplyResources(Me.comboBoxEdit1, "comboBoxEdit1")
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("comboBoxEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.comboBoxEdit1.Properties.Items.AddRange(New Object() { resources.GetString("comboBoxEdit1.Properties.Items"), resources.GetString("comboBoxEdit1.Properties.Items1"), resources.GetString("comboBoxEdit1.Properties.Items2"), resources.GetString("comboBoxEdit1.Properties.Items3"), resources.GetString("comboBoxEdit1.Properties.Items4")})
			Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
'			Me.comboBoxEdit1.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEdit1_SelectedIndexChanged);
			' 
			' fromCompanyLabel
			' 
			resources.ApplyResources(Me.fromCompanyLabel, "fromCompanyLabel")
			Me.fromCompanyLabel.Name = "fromCompanyLabel"
			' 
			' panel
			' 
			Me.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel.Controls.Add(Me.fromCompanyLabel)
			Me.panel.Controls.Add(Me.comboBoxEdit1)
			resources.ApplyResources(Me.panel, "panel")
			Me.panel.Name = "panel"
			' 
			' spreadsheetBarController1
			' 
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem65)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem66)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem67)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem68)
			Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem69)
			Me.spreadsheetBarController1.Control = Me.spreadsheetControl1
			' 
			' spreadsheetCommandBarButtonItem65
			' 
			Me.spreadsheetCommandBarButtonItem65.CommandName = "FunctionsInsertSum"
			Me.spreadsheetCommandBarButtonItem65.Id = -1
			Me.spreadsheetCommandBarButtonItem65.Name = "spreadsheetCommandBarButtonItem65"
			' 
			' spreadsheetCommandBarButtonItem66
			' 
			Me.spreadsheetCommandBarButtonItem66.CommandName = "FunctionsInsertAverage"
			Me.spreadsheetCommandBarButtonItem66.Id = -1
			Me.spreadsheetCommandBarButtonItem66.Name = "spreadsheetCommandBarButtonItem66"
			' 
			' spreadsheetCommandBarButtonItem67
			' 
			Me.spreadsheetCommandBarButtonItem67.CommandName = "FunctionsInsertCountNumbers"
			Me.spreadsheetCommandBarButtonItem67.Id = -1
			Me.spreadsheetCommandBarButtonItem67.Name = "spreadsheetCommandBarButtonItem67"
			' 
			' spreadsheetCommandBarButtonItem68
			' 
			Me.spreadsheetCommandBarButtonItem68.CommandName = "FunctionsInsertMax"
			Me.spreadsheetCommandBarButtonItem68.Id = -1
			Me.spreadsheetCommandBarButtonItem68.Name = "spreadsheetCommandBarButtonItem68"
			' 
			' spreadsheetCommandBarButtonItem69
			' 
			Me.spreadsheetCommandBarButtonItem69.CommandName = "FunctionsInsertMin"
			Me.spreadsheetCommandBarButtonItem69.Id = -1
			Me.spreadsheetCommandBarButtonItem69.Name = "spreadsheetCommandBarButtonItem69"
			' 
			' DocumentThemesModule
			' 
			Me.Appearance.Font = (CType(resources.GetObject("DocumentThemesModule.Appearance.Font"), System.Drawing.Font))
			Me.Appearance.Options.UseFont = True
			Me.Controls.Add(Me.spreadsheetControl1)
			Me.Controls.Add(Me.panel)
			Me.Name = "DocumentThemesModule"
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		Private WithEvents comboBoxEdit1 As XtraEditors.ComboBoxEdit
		Private fromCompanyLabel As XtraEditors.LabelControl
		Private panel As XtraEditors.PanelControl
		Private spreadsheetBarController1 As UI.SpreadsheetBarController
		Private spreadsheetCommandBarButtonItem65 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem66 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem67 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem68 As UI.SpreadsheetCommandBarButtonItem
		Private spreadsheetCommandBarButtonItem69 As UI.SpreadsheetCommandBarButtonItem
	End Class
End Namespace
