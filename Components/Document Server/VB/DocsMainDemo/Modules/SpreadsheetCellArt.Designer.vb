Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetCellArtModule
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
			Me.loadButton = New DevExpress.XtraEditors.SimpleButton()
			Me.saveButton = New DevExpress.XtraEditors.SimpleButton()
			Me.pictureEdit = New DevExpress.XtraEditors.PictureEdit()
			CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' loadButton
			' 
			Me.loadButton.Location = New System.Drawing.Point(0, 0)
			Me.loadButton.Name = "loadButton"
			Me.loadButton.Size = New System.Drawing.Size(85, 23)
			Me.loadButton.TabIndex = 6
			Me.loadButton.Text = "Load Image..."
'			Me.loadButton.Click += New System.EventHandler(Me.loadButton_Click);
			' 
			' saveButton
			' 
			Me.saveButton.Location = New System.Drawing.Point(90, 0)
			Me.saveButton.Name = "saveButton"
			Me.saveButton.Size = New System.Drawing.Size(90, 23)
			Me.saveButton.TabIndex = 6
			Me.saveButton.Text = "Save in XLSX..."
'			Me.saveButton.Click += New System.EventHandler(Me.saveButton_Click);
			' 
			' pictureEdit
			' 
			Me.pictureEdit.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pictureEdit.Location = New System.Drawing.Point(0, 30)
			Me.pictureEdit.Name = "pictureEdit"
			Me.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.pictureEdit.Size = New System.Drawing.Size(155, 119)
			Me.pictureEdit.TabIndex = 7
			' 
			' BitmapLoaderModule
			' 
			Me.Controls.Add(Me.loadButton)
			Me.Controls.Add(Me.pictureEdit)
			Me.Controls.Add(Me.saveButton)
			Me.Name = "BitmapLoaderModule"
			Me.Size = New System.Drawing.Size(158, 150)
			CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private WithEvents loadButton As SimpleButton
		Private WithEvents saveButton As SimpleButton
		Private pictureEdit As PictureEdit
	End Class
End Namespace
