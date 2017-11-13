Imports Microsoft.VisualBasic
Imports System
Namespace PhotoViewer
	Partial Public Class FolderGroupCaptionControl
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
			Me.SuspendLayout()
			' 
			' nameLabel
			' 
			Me.nameLabel.Appearance.Font = New System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.nameLabel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
			Me.nameLabel.Size = New System.Drawing.Size(117, 27)
			Me.nameLabel.Text = "FolderName"
			' 
			' dataLabel
			' 
			Me.dataLabel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.dataLabel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
			Me.dataLabel.Size = New System.Drawing.Size(72, 17)
			' 
			' groupIcon
			' 
			Me.groupIcon.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.groupIcon.Appearance.Image = My.Resources.Folder_32x32
			Me.groupIcon.Cursor = System.Windows.Forms.Cursors.Hand
			' 
			' editLabel
			' 
			Me.editLabel.Appearance.Image = My.Resources.Edit_16x16
			Me.editLabel.Location = New System.Drawing.Point(213, 22)
			Me.editLabel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
			Me.editLabel.Size = New System.Drawing.Size(21, 20)
			Me.editLabel.Visible = False
			' 
			' removeLabel
			' 
			Me.removeLabel.Appearance.Image = My.Resources.RemoveAlbum_16x16
			Me.removeLabel.Location = New System.Drawing.Point(249, 22)
			Me.removeLabel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
			Me.removeLabel.Size = New System.Drawing.Size(21, 20)
			Me.removeLabel.ToolTip = "Remove folder from list"
			' 
			' collageLabel
			' 
			Me.collageLabel.Appearance.Image = My.Resources.Collage_16x16
			Me.collageLabel.Location = New System.Drawing.Point(298, 22)
			Me.collageLabel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
			Me.collageLabel.Size = New System.Drawing.Size(21, 20)
			Me.collageLabel.ToolTip = "Make collage"
			' 
			' slideshowLabel
			' 
			Me.slideshowLabel.Appearance.Image = My.Resources.Slideshow_16x16
			Me.slideshowLabel.Location = New System.Drawing.Point(334, 22)
			Me.slideshowLabel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
			Me.slideshowLabel.Size = New System.Drawing.Size(21, 20)
			Me.slideshowLabel.ToolTip = "Make slideshow"
			' 
			' filmLabel
			' 
			Me.filmLabel.Appearance.Image = My.Resources.Film_16x16
			Me.filmLabel.Location = New System.Drawing.Point(370, 22)
			Me.filmLabel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
			Me.filmLabel.Size = New System.Drawing.Size(21, 20)
			Me.filmLabel.ToolTip = "Make film"
			' 
			' separatorLabel
			' 
			Me.separatorLabel.Location = New System.Drawing.Point(285, 27)
			Me.separatorLabel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
			Me.separatorLabel.Size = New System.Drawing.Size(4, 16)
			' 
			' FolderGroupCaptionControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
			Me.Name = "FolderGroupCaptionControl"
			Me.Size = New System.Drawing.Size(410, 69)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
	End Class
End Namespace
