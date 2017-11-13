Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace PhotoViewer
	Partial Public Class PhotoGroupCaptionControlBase
		Inherits UserControl
		Public Sub New()
			SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint, True)
			InitializeComponent()
		End Sub
		Private galleryFormCore As GalleryForm
		Public Property GalleryForm() As GalleryForm
			Get
				Return galleryFormCore
			End Get
			Set(ByVal value As GalleryForm)
				galleryFormCore = value
			End Set
		End Property
		Protected Overridable Sub OnGroupIconClick(ByVal sender As Object, ByVal e As EventArgs) Handles groupIcon.Click
		End Sub
		Protected Overridable Sub OnEditButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles editLabel.Click
		End Sub
		Protected Overridable Sub OnRemoveButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles removeLabel.Click
		End Sub
		Protected Overridable Sub OnCollageButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles collageLabel.Click
			XtraMessageBox.Show(Me, "Here you can show your own collage settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub
		Protected Overridable Sub OnSlideShowButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles slideshowLabel.Click
			XtraMessageBox.Show(Me, "Here you can show your own slideshow settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub
		Protected Overridable Sub OnFilmButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles filmLabel.Click
			XtraMessageBox.Show(Me, "Here you can show your own film settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub
	End Class
End Namespace
