Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Annotations
	Partial Public Class TextAnnotationDemo
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
			Me.meeMaxText = New DevExpress.XtraEditors.MemoExEdit()
			Me.lblMaxText = New DevExpress.XtraEditors.LabelControl()
			Me.meeMinText = New DevExpress.XtraEditors.MemoExEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.meeMaxText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.meeMinText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.meeMinText)
			Me.panel.Controls.Add(Me.labelControl1)
			Me.panel.Controls.Add(Me.meeMaxText)
			Me.panel.Controls.Add(Me.lblMaxText)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.lblMaxText, 0)
			Me.panel.Controls.SetChildIndex(Me.meeMaxText, 0)
			Me.panel.Controls.SetChildIndex(Me.labelControl1, 0)
			Me.panel.Controls.SetChildIndex(Me.meeMinText, 0)
			' 
			' checkEditShowLabels
			' 
			' 
			' meeMaxText
			' 
			Me.meeMaxText.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.meeMaxText.EditValue = "This is a <b><size=+3>maximum</size></b> point."
			Me.meeMaxText.Location = New System.Drawing.Point(486, 9)
			Me.meeMaxText.MinimumSize = New System.Drawing.Size(50, 0)
			Me.meeMaxText.Name = "meeMaxText"
			Me.meeMaxText.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.meeMaxText.Properties.PopupFormSize = New System.Drawing.Size(480, 150)
			Me.meeMaxText.Properties.ShowIcon = False
			Me.meeMaxText.Size = New System.Drawing.Size(73, 20)
			Me.meeMaxText.TabIndex = 10
'			Me.meeMaxText.TextChanged += New System.EventHandler(Me.meeMaxText_TextChanged);
			' 
			' lblMaxText
			' 
			Me.lblMaxText.Location = New System.Drawing.Point(347, 12)
			Me.lblMaxText.Name = "lblMaxText"
			Me.lblMaxText.Size = New System.Drawing.Size(133, 13)
			Me.lblMaxText.TabIndex = 9
			Me.lblMaxText.Text = "Maximum Value Annotation:"
			' 
			' meeMinText
			' 
			Me.meeMinText.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.meeMinText.EditValue = "This is a <b><size=+3>minimum</size></b> point"
			Me.meeMinText.Location = New System.Drawing.Point(486, 37)
			Me.meeMinText.MinimumSize = New System.Drawing.Size(50, 0)
			Me.meeMinText.Name = "meeMinText"
			Me.meeMinText.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.meeMinText.Properties.PopupFormSize = New System.Drawing.Size(480, 150)
			Me.meeMinText.Properties.ShowIcon = False
			Me.meeMinText.Size = New System.Drawing.Size(73, 20)
			Me.meeMinText.TabIndex = 12
'			Me.meeMinText.TextChanged += New System.EventHandler(Me.meeMinText_TextChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(347, 40)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(129, 13)
			Me.labelControl1.TabIndex = 11
			Me.labelControl1.Text = "Minimum Value Annotation:"
			' 
			' TextAnnotationDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "TextAnnotationDemo"
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.meeMaxText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.meeMinText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents meeMaxText As XtraEditors.MemoExEdit
		Private lblMaxText As XtraEditors.LabelControl
		Private WithEvents meeMinText As XtraEditors.MemoExEdit
		Private labelControl1 As XtraEditors.LabelControl
	End Class
End Namespace
