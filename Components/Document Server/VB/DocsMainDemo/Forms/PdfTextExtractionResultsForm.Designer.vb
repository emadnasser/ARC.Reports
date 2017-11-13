Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class PdfTextExtractionResultsForm
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
			Me.memoEdit = New DevExpress.XtraEditors.MemoEdit()
			CType(Me.memoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' memoEdit
			' 
			Me.memoEdit.Dock = System.Windows.Forms.DockStyle.Fill
			Me.memoEdit.Location = New System.Drawing.Point(0, 0)
			Me.memoEdit.Name = "memoEdit"
			Me.memoEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10F)
			Me.memoEdit.Properties.Appearance.Options.UseFont = True
			Me.memoEdit.Properties.ReadOnly = True
			Me.memoEdit.Size = New System.Drawing.Size(561, 335)
			Me.memoEdit.TabIndex = 0
			Me.memoEdit.UseOptimizedRendering = True
			' 
			' PdfTextExtractionResultsForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(561, 335)
			Me.Controls.Add(Me.memoEdit)
			Me.Name = "PdfTextExtractionResultsForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Text Extraction"
			CType(Me.memoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private memoEdit As XtraEditors.MemoEdit
	End Class
End Namespace
