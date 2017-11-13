Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetTutorialControl
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
		''' 
		Private Sub InitializeComponent()
			Me.fitToPageCheckEdit_Renamed = New DevExpress.XtraEditors.CheckEdit()
			Me.saveButton = New DevExpress.XtraEditors.SimpleButton()
			Me.spreadsheetTutorialPanel_Renamed = New DevExpress.XtraEditors.PanelControl()
			Me.spreadsheetPreview1 = New DevExpress.Docs.Demos.SpreadsheetPreview()
			CType(Me.fitToPageCheckEdit_Renamed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spreadsheetTutorialPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.spreadsheetTutorialPanel_Renamed.SuspendLayout()
			Me.SuspendLayout()
			' 
			' fitToPageCheckEdit
			' 
			Me.fitToPageCheckEdit_Renamed.Location = New System.Drawing.Point(3, 5)
			Me.fitToPageCheckEdit_Renamed.Name = "fitToPageCheckEdit"
			Me.fitToPageCheckEdit_Renamed.Properties.Caption = "Fit To Page"
			Me.fitToPageCheckEdit_Renamed.Size = New System.Drawing.Size(100, 19)
			Me.fitToPageCheckEdit_Renamed.TabIndex = 30
			' 
			' saveButton
			' 
			Me.saveButton.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.saveButton.Location = New System.Drawing.Point(424, 3)
			Me.saveButton.Name = "saveButton"
			Me.saveButton.Size = New System.Drawing.Size(75, 23)
			Me.saveButton.TabIndex = 31
			Me.saveButton.Text = "Save As..."
'			Me.saveButton.Click += New System.EventHandler(Me.saveButton_Click);
			' 
			' spreadsheetTutorialPanel
			' 
			Me.spreadsheetTutorialPanel_Renamed.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.spreadsheetTutorialPanel_Renamed.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.spreadsheetTutorialPanel_Renamed.Controls.Add(Me.spreadsheetPreview1)
			Me.spreadsheetTutorialPanel_Renamed.Controls.Add(Me.saveButton)
			Me.spreadsheetTutorialPanel_Renamed.Controls.Add(Me.fitToPageCheckEdit_Renamed)
			Me.spreadsheetTutorialPanel_Renamed.Location = New System.Drawing.Point(0, 90)
			Me.spreadsheetTutorialPanel_Renamed.Name = "spreadsheetTutorialPanel"
			Me.spreadsheetTutorialPanel_Renamed.Size = New System.Drawing.Size(500, 410)
			Me.spreadsheetTutorialPanel_Renamed.TabIndex = 33
			' 
			' spreadsheetPreview1
			' 
			Me.spreadsheetPreview1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.spreadsheetPreview1.CanShowBorders = False
			Me.spreadsheetPreview1.Location = New System.Drawing.Point(0, 32)
			Me.spreadsheetPreview1.Name = "spreadsheetPreview1"
			Me.spreadsheetPreview1.Size = New System.Drawing.Size(500, 378)
			Me.spreadsheetPreview1.TabIndex = 33
			Me.spreadsheetPreview1.Workbook = Nothing
			' 
			' SpreadsheetTutorialControl
			' 
			Me.Controls.Add(Me.spreadsheetTutorialPanel_Renamed)
			Me.Name = "SpreadsheetTutorialControl"
			Me.Size = New System.Drawing.Size(500, 500)
			CType(Me.fitToPageCheckEdit_Renamed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spreadsheetTutorialPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.spreadsheetTutorialPanel_Renamed.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private fitToPageCheckEdit_Renamed As CheckEdit
		Private WithEvents saveButton As SimpleButton
		Private spreadsheetPreview1 As SpreadsheetPreview
	End Class
End Namespace
