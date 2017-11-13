Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class PdfTextSearchResultsForm
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
			Me.listBoxControl = New DevExpress.XtraEditors.ListBoxControl()
			CType(Me.listBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' listBoxControl
			' 
			Me.listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBoxControl.Location = New System.Drawing.Point(0, 0)
			Me.listBoxControl.Name = "listBoxControl"
			Me.listBoxControl.Size = New System.Drawing.Size(561, 335)
			Me.listBoxControl.TabIndex = 0
			' 
			' PdfTextSearchResultsForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(561, 335)
			Me.Controls.Add(Me.listBoxControl)
			Me.Name = "PdfTextSearchResultsForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Text Search"
			CType(Me.listBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private listBoxControl As XtraEditors.ListBoxControl
	End Class
End Namespace
