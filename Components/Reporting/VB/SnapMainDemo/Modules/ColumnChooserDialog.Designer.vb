Imports Microsoft.VisualBasic
Imports System
Namespace SnapDemos.Modules
	Partial Public Class ColumnChooserDialog
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
			Me.buttonOk = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.buttonCancel = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' buttonOk
			' 
			Me.buttonOk.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonOk.Location = New System.Drawing.Point(89, 44)
			Me.buttonOk.Name = "buttonOk"
			Me.buttonOk.Size = New System.Drawing.Size(75, 23)
			Me.buttonOk.TabIndex = 0
			Me.buttonOk.Text = "OK"
			Me.buttonOk.UseVisualStyleBackColor = True
'			Me.buttonOk.Click += New System.EventHandler(Me.buttonOk_Click);
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(13, 13)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(77, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Fields to insert:"
			' 
			' panel1
			' 
			Me.panel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel1.Location = New System.Drawing.Point(16, 30)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(230, 8)
			Me.panel1.TabIndex = 2
			' 
			' buttonCancel
			' 
			Me.buttonCancel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonCancel.Location = New System.Drawing.Point(170, 44)
			Me.buttonCancel.Name = "buttonCancel"
			Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
			Me.buttonCancel.TabIndex = 3
			Me.buttonCancel.Text = "Cancel"
			Me.buttonCancel.UseVisualStyleBackColor = True
'			Me.buttonCancel.Click += New System.EventHandler(Me.buttonCancel_Click);
			' 
			' ColumnChooserDialog
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(258, 79)
			Me.Controls.Add(Me.buttonCancel)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.buttonOk)
			Me.Name = "ColumnChooserDialog"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "ColumnChooserDialog"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents buttonOk As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents buttonCancel As System.Windows.Forms.Button
	End Class
End Namespace
