Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos.Forms
	Public Partial Class SelectAmountForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
			Me.calcEdit1 = New DevExpress.XtraEditors.CalcEdit()
			CType(Me.calcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' calcEdit1
			' 
			Me.calcEdit1.Dock = System.Windows.Forms.DockStyle.Top
			Me.calcEdit1.Location = New System.Drawing.Point(0, 0)
			Me.calcEdit1.Name = "calcEdit1"
			Me.calcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)})
'			Me.calcEdit1.Properties.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.calcEdit1_Properties_ButtonClick);
			Me.calcEdit1.Size = New System.Drawing.Size(188, 20)
			Me.calcEdit1.TabIndex = 0
'			Me.calcEdit1.ValueChanged += New System.EventHandler(Me.calcEdit1_ValueChanged);
			' 
			' SelectAmountForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoSize = True
			Me.ClientSize = New System.Drawing.Size(188, 20)
			Me.Controls.Add(Me.calcEdit1)
			Me.Name = "SelectAmountForm"
			Me.Text = "Enter the amount"
			CType(Me.calcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents calcEdit1 As DevExpress.XtraEditors.CalcEdit


	End Class
End Namespace
