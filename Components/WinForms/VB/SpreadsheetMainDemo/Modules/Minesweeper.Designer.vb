Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class MinesweeperModule
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

		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.spreadsheetControl = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.cellSizeLabel = New DevExpress.XtraEditors.LabelControl()
			Me.NewGameBtn = New DevExpress.XtraEditors.SimpleButton()
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			Me.cellSizeTrack = New DevExpress.XtraEditors.TrackBarControl()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cellSizeTrack, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cellSizeTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spreadsheetControl
			' 
			Me.spreadsheetControl.AllowDrop = True
			Me.spreadsheetControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetControl.Location = New System.Drawing.Point(0, 42)
			Me.spreadsheetControl.Name = "spreadsheetControl"
			Me.spreadsheetControl.Options.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spreadsheetControl.Options.Export.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl.Options.Export.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl.Options.Import.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl.Options.Import.ThrowExceptionOnInvalidDocument = False
			Me.spreadsheetControl.Options.Import.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl.Size = New System.Drawing.Size(784, 390)
			Me.spreadsheetControl.TabIndex = 55
			Me.spreadsheetControl.Text = "spreadsheetControl1"
			' 
			' cellSizeLabel
			' 
			Me.cellSizeLabel.Location = New System.Drawing.Point(288, 13)
			Me.cellSizeLabel.Name = "cellSizeLabel"
			Me.cellSizeLabel.Size = New System.Drawing.Size(43, 13)
			Me.cellSizeLabel.TabIndex = 57
			Me.cellSizeLabel.Text = "Cell Size:"
			' 
			' NewGameBtn
			' 
			Me.NewGameBtn.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.NewGameBtn.Location = New System.Drawing.Point(704, 8)
			Me.NewGameBtn.Name = "NewGameBtn"
			Me.NewGameBtn.Size = New System.Drawing.Size(75, 23)
			Me.NewGameBtn.TabIndex = 58
			Me.NewGameBtn.Text = "New Game"
'			Me.NewGameBtn.Click += New System.EventHandler(Me.Button1Click);
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.cellSizeLabel)
			Me.panel1.Controls.Add(Me.NewGameBtn)
			Me.panel1.Controls.Add(Me.radioGroup1)
			Me.panel1.Controls.Add(Me.cellSizeTrack)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(784, 42)
			Me.panel1.TabIndex = 54
			' 
			' radioGroup1
			' 
			Me.radioGroup1.Location = New System.Drawing.Point(3, 8)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.radioGroup1.Properties.Columns = 3
			Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Beginner"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Intermediate"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Expert")})
			Me.radioGroup1.Size = New System.Drawing.Size(279, 23)
			Me.radioGroup1.TabIndex = 52
'			Me.radioGroup1.SelectedIndexChanged += New System.EventHandler(Me.RadioGroup1SelectedIndexChanged);
			' 
			' cellSizeTrack
			' 
			Me.cellSizeTrack.EditValue = 18
			Me.cellSizeTrack.Location = New System.Drawing.Point(327, 8)
			Me.cellSizeTrack.Name = "cellSizeTrack"
			Me.cellSizeTrack.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.cellSizeTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.cellSizeTrack.Properties.Maximum = 35
			Me.cellSizeTrack.Properties.Minimum = 18
			Me.cellSizeTrack.Size = New System.Drawing.Size(279, 45)
			Me.cellSizeTrack.TabIndex = 54
			Me.cellSizeTrack.Value = 18
'			Me.cellSizeTrack.ValueChanged += New System.EventHandler(Me.CellSizeTrackValueChanged);
			' 
			' timer1
			' 
			Me.timer1.Interval = 1000
'			Me.timer1.Tick += New System.EventHandler(Me.Timer1Tick);
			' 
			' MinesweeperModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.spreadsheetControl)
			Me.Controls.Add(Me.panel1)
			Me.Name = "MinesweeperModule"
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cellSizeTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cellSizeTrack, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		Private spreadsheetControl As SpreadsheetControl
		Private cellSizeLabel As XtraEditors.LabelControl
		Private WithEvents NewGameBtn As DevExpress.XtraEditors.SimpleButton
		Private panel1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents radioGroup1 As XtraEditors.RadioGroup
		Private WithEvents cellSizeTrack As XtraEditors.TrackBarControl
		Private WithEvents timer1 As System.Windows.Forms.Timer
	End Class
End Namespace
