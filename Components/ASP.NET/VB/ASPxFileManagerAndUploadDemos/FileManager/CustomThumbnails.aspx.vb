Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class FileManager_CustomThumbnails
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub

	Public Sub fileManager_CustomThumbnail(ByVal sender As Object, ByVal e As FileManagerThumbnailCreateEventArgs)
		Select Case (CType(e.Item, FileManagerFile)).Extension
			Case ".avi"
				e.ThumbnailImage.Url = "Images/movie.png"
			Case ".txt"
				e.ThumbnailImage.Url = "Images/txt.png"
			Case ".mp3"
				e.ThumbnailImage.Url = "Images/music.png"
			Case ".xml"
				e.ThumbnailImage.Url = "Images/code.png"
		End Select
	End Sub
End Class
