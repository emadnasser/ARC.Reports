Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class HighlightTextModule
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
		Private Sub InitializeComponent()
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.teHighlightText = New DevExpress.XtraEditors.TextEdit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.teHighlightText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel1.Controls.Add(Me.labelControl1)
			Me.panel1.Controls.Add(Me.teHighlightText)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(784, 27)
			Me.panel1.TabIndex = 58
			' 
			' labelControl1
			' 
			Me.labelControl1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelControl1.Location = New System.Drawing.Point(540, 3)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(70, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Highlight Text:"
			' 
			' teHighlightText
			' 
			Me.teHighlightText.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.teHighlightText.EditValue = "here"
			Me.teHighlightText.Location = New System.Drawing.Point(616, 0)
			Me.teHighlightText.Name = "teHighlightText"
			Me.teHighlightText.Size = New System.Drawing.Size(168, 20)
			Me.teHighlightText.TabIndex = 0
'			Me.teHighlightText.EditValueChanging += New DevExpress.XtraEditors.Controls.ChangingEventHandler(Me.teHighlightText_EditValueChanging);

			' 
			' HighlightTextModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panel1)
			Me.Name = "HighlightTextModule"
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.teHighlightText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As XtraEditors.PanelControl
		Private WithEvents teHighlightText As XtraEditors.TextEdit
		Private labelControl1 As XtraEditors.LabelControl
	End Class
End Namespace
