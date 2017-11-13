Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class RichEditFindAndReplace
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
			Me.find = New DevExpress.XtraEditors.LabelControl()
			Me.findTE = New DevExpress.XtraEditors.TextEdit()
			Me.replace = New DevExpress.XtraEditors.LabelControl()
			Me.replaceTE = New DevExpress.XtraEditors.TextEdit()
			Me.printPreviewControl = New DevExpress.XtraPrinting.Control.PrintControl()
			Me.findButton = New DevExpress.XtraEditors.SimpleButton()
			Me.replaceButton = New DevExpress.XtraEditors.SimpleButton()
			Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.findTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.replaceTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' find
			' 
			Me.find.Location = New System.Drawing.Point(0, 9)
			Me.find.Name = "find"
			Me.find.Size = New System.Drawing.Size(24, 13)
			Me.find.TabIndex = 35
			Me.find.Text = "Find:"
			' 
			' findTE
			' 
			Me.findTE.EditValue = ""
			Me.findTE.Location = New System.Drawing.Point(74, 6)
			Me.findTE.Name = "findTE"
			Me.findTE.Size = New System.Drawing.Size(126, 20)
			Me.findTE.TabIndex = 34
			' 
			' replace
			' 
			Me.replace.Location = New System.Drawing.Point(0, 38)
			Me.replace.Name = "replace"
			Me.replace.Size = New System.Drawing.Size(65, 13)
			Me.replace.TabIndex = 37
			Me.replace.Text = "Replace with:"
			' 
			' replaceTE
			' 
			Me.replaceTE.EditValue = ""
			Me.replaceTE.Location = New System.Drawing.Point(74, 35)
			Me.replaceTE.Name = "replaceTE"
			Me.replaceTE.Size = New System.Drawing.Size(125, 20)
			Me.replaceTE.TabIndex = 36
			' 
			' printPreviewControl
			' 
			Me.printPreviewControl.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.printPreviewControl.IsMetric = False
			Me.printPreviewControl.Location = New System.Drawing.Point(0, 62)
			Me.printPreviewControl.Name = "printPreviewControl"
			Me.printPreviewControl.Size = New System.Drawing.Size(784, 367)
			Me.printPreviewControl.TabIndex = 38
			Me.printPreviewControl.TooltipFont = New System.Drawing.Font("Tahoma", 8.25F)
			' 
			' findButton
			' 
			Me.findButton.Location = New System.Drawing.Point(205, 4)
			Me.findButton.Name = "findButton"
			Me.findButton.Size = New System.Drawing.Size(85, 24)
			Me.findButton.TabIndex = 39
			Me.findButton.Text = "Find All"
'			Me.findButton.Click += New System.EventHandler(Me.findButton_Click);
			' 
			' replaceButton
			' 
			Me.replaceButton.Location = New System.Drawing.Point(205, 33)
			Me.replaceButton.Name = "replaceButton"
			Me.replaceButton.Size = New System.Drawing.Size(85, 24)
			Me.replaceButton.TabIndex = 39
			Me.replaceButton.Text = "Replace All"
'			Me.replaceButton.Click += New System.EventHandler(Me.replaceButton_Click);
			' 
			' btnExport
			' 
			Me.btnExport.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnExport.Location = New System.Drawing.Point(695, 33)
			Me.btnExport.Name = "btnExport"
			Me.btnExport.Size = New System.Drawing.Size(89, 24)
			Me.btnExport.TabIndex = 40
			Me.btnExport.Text = "Export"
'			Me.btnExport.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' RichEditFindAndReplace
			' 
			Me.Controls.Add(Me.btnExport)
			Me.Controls.Add(Me.replaceButton)
			Me.Controls.Add(Me.findButton)
			Me.Controls.Add(Me.printPreviewControl)
			Me.Controls.Add(Me.replace)
			Me.Controls.Add(Me.replaceTE)
			Me.Controls.Add(Me.find)
			Me.Controls.Add(Me.findTE)
			Me.Name = "RichEditFindAndReplace"
			CType(Me.findTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.replaceTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private find As LabelControl
		Private findTE As TextEdit
		Private replace As LabelControl
		Private replaceTE As TextEdit
		Private printPreviewControl As XtraPrinting.Control.PrintControl
		Private WithEvents findButton As SimpleButton
		Private WithEvents replaceButton As SimpleButton
		Private WithEvents btnExport As SimpleButton

	End Class
End Namespace
