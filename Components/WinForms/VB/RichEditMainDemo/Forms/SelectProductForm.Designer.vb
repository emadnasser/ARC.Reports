Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos.Forms
	Public Partial Class SelectProductForm
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
			Me.listBoxControl = New DevExpress.XtraEditors.ListBoxControl()
			CType(Me.listBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' listBoxControl
			' 
			Me.listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBoxControl.Location = New System.Drawing.Point(0, 0)
			Me.listBoxControl.Name = "listBoxControl"
			Me.listBoxControl.Size = New System.Drawing.Size(163, 246)
			Me.listBoxControl.SortOrder = System.Windows.Forms.SortOrder.Ascending
			Me.listBoxControl.TabIndex = 0
'			Me.listBoxControl.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.listBoxControl_MouseMove);
'			Me.listBoxControl.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.listBoxControl_MouseClick);
			' 
			' SelectProductForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(163, 246)
			Me.Controls.Add(Me.listBoxControl)
			Me.Name = "SelectProductForm"
			Me.Text = "Select a product"
			CType(Me.listBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents listBoxControl As DevExpress.XtraEditors.ListBoxControl
	End Class
End Namespace
