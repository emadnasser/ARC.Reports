Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Demos

Partial Public Class ImageGallery_FolderBinding
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		imageGallery.SettingsFolder.ImageSourceFolder = cbSelectFolder.Value.ToString()
		imageGallery.SettingsFolder.ImageCacheFolder = If(chWatermark.Checked, "~\Thumb\ImageGalleryThumbWithWaterMark\", "~\Thumb\ImageGalleryThumb\")
		If chWatermark.Checked Then
			AddHandler imageGallery.CustomImageProcessing, AddressOf imageGallery_CustomImageProcessing
		End If
		imageGallery.UpdateImageCacheFolder()
	End Sub

	Private Sub imageGallery_CustomImageProcessing(ByVal source As Object, ByVal e As DevExpress.Web.ImageGalleryCustomImageProcessingEventArgs)
		PhotoUtils.DrawWatermarkText(e.Graphics, "ASPxImageGallery", "Arial")
	End Sub
End Class
